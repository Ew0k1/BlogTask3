using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.WebUI.Models
{
    public class HomeViewModel
    {
        public List<Article> Articles { get; set; }
        public Poll Poll { get; set; }
    }
}