using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace blog_template_practice.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Display(Name = "Name")]
        public string Author { get; set; }
        [Display(Name = "Write your post here")]
        public string Body { get; set; }
        public DateTime PublishDate { get; set; }
        [Display(Name = "Topic")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
               

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
