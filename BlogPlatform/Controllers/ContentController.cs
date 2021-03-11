using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace blog_template_practice.Controllers
{
    public class ContentController : Controller
    {
        IRepository<Content> contentRepo;

        public ContentController(IRepository<Content> contentRepo)
        {
            this.contentRepo = contentRepo;
        }

        private void DropDownList()
        {
            var categories = contentRepo.PopulateCategoryList();

            ViewBag.Category = categories;
        }

        

        public ViewResult Index()
        {
            var contentList = contentRepo.GetAll();
            return View(contentList);
        }

        public ViewResult Details(int id)
        {
            var content = contentRepo.GetById(id);

            return View(content);
        }

        public ViewResult Create(int categoryId)
        {
            DropDownList();

            return View(new Content() {CategoryId = categoryId });
        }

        [HttpPost]
        public ActionResult Create(Content model)
        {
            DropDownList();

            ViewBag.Result = "You made a new post";

            model.PublishDate = DateTime.Now;

            contentRepo.Create(model);

            return View();
        }

        public ViewResult CreateByCategoryId(int id)
        {
            DropDownList();
                       
            return View(new Content() { CategoryId = id });
        }



        public ViewResult Update(int id)
        {
            var category = contentRepo.GetById(id);

            DropDownList();

            return View(category);
        }

        [HttpPost]
        public ViewResult Update(Content model)
        {
            contentRepo.Update(model);
            
            ViewBag.Result = "You updated your post.";

            model.PublishDate = DateTime.Now;

            DropDownList();

            return View();
        }



        public ActionResult Delete(int id)
        {

            var content = contentRepo.GetById(id);

            contentRepo.Delete(content);

            return RedirectToAction("Details", "Category", new { id = content.CategoryId});
        }
        



    }
}
