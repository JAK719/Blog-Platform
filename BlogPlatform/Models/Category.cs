using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace blog_template_practice.Models
{
    
    public class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public virtual ICollection<Content> Content { get; set; }


        public Category()
        {

        }


        public Category(int catId, string name)
        {
            Id = catId;
            Name = name;
        }

    }

      

  
}
