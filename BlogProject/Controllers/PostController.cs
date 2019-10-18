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
        public ActionResult Create(Models.Post post)
        {
            post.PublishDate = DateTime.Now;
            postRepo.Create(post);
            return RedirectToAction("Browse","Browse");
        }
    }
}