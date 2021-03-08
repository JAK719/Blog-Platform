using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Models
{
    public class Category
    {
        public string CatName { get; set; }
        public string Content { get; set;}
        public int CatId { get; set; }

        public Category(int catId, string catName)
        {
            CatId = catId;
            CatName = catName;
        }

    }

      

  
}
