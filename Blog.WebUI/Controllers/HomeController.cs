using Blog.Domain.Concrete;
using Blog.Domain.Entities;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.WebUI.Models;

namespace Blog.WebUI.Controllers
{
    public class HomeController : Controller
    {
      
        static Random random = new Random();
        UnitOfWork unit;

        public HomeController()
        {
            unit = new UnitOfWork();
        }

        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            List<Article> articles = unit.Articles.FindAll().ToList();
            List<Poll> polls = unit.Polls.FindAll().ToList();
            Poll poll = polls[0];
           
            model.Articles = articles;
            model.Poll = poll;
            return View(model);
        }
        public ActionResult Article(int id)
        {
            Article article = unit.Articles.Find(id);
          
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }
       
        [HttpPost]
        public ActionResult Vote(Poll poll, string vote)
        {
            var pl = unit.Polls.Find(poll.PollId);
            foreach (var item in pl.Answers)
            {
                if (item.Text == vote)
                {
                    item.AddVote();
                    unit.Answers.Update(item);
                    unit.Save();
                    break;
                }
            }
            return RedirectToAction("Index");

        }

       
    }
}