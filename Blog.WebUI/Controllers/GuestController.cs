using Blog.Domain.Concrete;
using Blog.Domain.Entities;
using Blog.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.WebUI.Controllers
{
    public class GuestController : Controller
    {
        UnitOfWork unitOfWork;

        public GuestController()
        {
            unitOfWork = new UnitOfWork();
        }
        // GET: Guest
        public ActionResult Index()
        {
            var reviews = unitOfWork.Reviews.FindAll();
            ReviewListViewModel model = new ReviewListViewModel();
            model.Reviews = reviews;
            return View(model);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Review review)
        {
            unitOfWork.Reviews.Create(review);
            unitOfWork.Save();
            return RedirectToAction("Index");
        }



        
    }
}