using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Models
{
    public class Content
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public DateTime PublishDate { get; set; }
        public string Category { get; set; }
        public int Id { get; set; }
               

        public Content()
        {
            
        }
        public Content(int id, string title, string body, string author, DateTime publishDate)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
            PublishDate = publishDate;
            
        }
      
      
       
    }


}
