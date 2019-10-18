using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Models;
using BlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace BlogProject.Controllers
{
    public class BrowseController : Controller
    {
        IRepository<Post> postRepo;
        IRepository<Category> categoryRepo;

        public BrowseController(IRepository<Post> postRepo, IRepository<Category> categoryRepo)
        {
            this.postRepo = postRepo;
            this.categoryRepo = categoryRepo;
        }

        public ViewResult ViewPost(int postId)
        {
            var model = postRepo.GetByID(postId);
            return View(model);
        }

        public ActionResult BrowseAll()
        {
            ViewBag.Categories = categoryRepo.GetAll();
            var model = postRepo.GetAll();
            return View(model);
        }

        public ActionResult BrowseByCategory(int CategoryId)
        {
            ViewBag.Categories = categoryRepo.GetAll();
            PostRepository postRepoChild = postRepo as PostRepository;
            var model = postRepoChild.GetByCategoryId(CategoryId);
            return View(model);
        }

        public ActionResult BrowseByTag(int TagId)
        {
            ViewBag.Categories = categoryRepo.GetAll();
            PostRepository postRepoChild = postRepo as PostRepository;
            var model = postRepoChild.GetByTagId(TagId);
            return View(model);
        }
    }
}