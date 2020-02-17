using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Keyword
    {
        public int KeywordId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
