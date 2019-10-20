using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Models;
using BlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class PostController : Controller
    {
        IRepository<Post> postRepo;
        IRepository<Category> categoryRepo;

        public PostController(IRepository<Post> postRepo, IRepository<Category> categoryRepo)
        {
            this.postRepo = postRepo;
            this.categoryRepo = categoryRepo;
        }

        [HttpGet]
        public ViewResult Create()
        {
            ViewBag.Categories = categoryRepo.GetAll();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            post.PublishDate = DateTime.Now;
            postRepo.Create(post);
            return RedirectToAction("BrowseAll","Browse");
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            ViewBag.Categories = categoryRepo.GetAll();
            var model = postRepo.GetByID(id);
            return View(model);
        }


        [HttpPost]
        public ActionResult Edit(Post post)
        {
            post.PublishDate = DateTime.Now;
            postRepo.Edit(post);
            return RedirectToAction("BrowseAll", "Browse");
        }

        public ActionResult Delete(int id)
        {
            postRepo.Delete(postRepo.GetByID(id));
            return RedirectToAction("BrowseAll", "Browse");
        }
    }
}