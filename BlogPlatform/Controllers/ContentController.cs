using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace blog_template_practice.Controllers
{
    public class ContentController : Controller
    {
        IRepository<Content> contentRepo;

        public ContentController(IRepository<Content> contentRepo)
        {
            this.contentRepo = contentRepo;
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

        public ViewResult Create()
        {
            return View(new Content());
        }

        [HttpPost]
        public ActionResult Create(Content model)
        {
            contentRepo.Create(model);
            ViewBag.Result = "You made a new post";

            return View();
        }

        public ViewResult Update(int id)
        {
            var category = contentRepo.GetById(id);

            return View(category);
        }

        [HttpPost]
        public ViewResult Update(Content model)
        {
            contentRepo.Update(model);
            ViewBag.Result = "You updated your post.";

            return View();
        }

        public ActionResult Delete(int id)
        {
            var content = contentRepo.GetById(id);

            contentRepo.Delete(content);

            return RedirectToAction("Index");
        }

    }
}
