using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.WebUI.Models
{
    public class ReviewListViewModel
    {
        public IEnumerable<Review> Reviews { get; set; }
        public Review Review { get; set; }
    }
}