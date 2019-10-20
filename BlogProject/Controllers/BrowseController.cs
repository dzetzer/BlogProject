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
        IRepository<Tag> tagRepo;

        public BrowseController(IRepository<Post> postRepo, IRepository<Category> categoryRepo, IRepository<Tag> tagRepo)
        {
            this.tagRepo = tagRepo;
            this.postRepo = postRepo;
            this.categoryRepo = categoryRepo;
        }

        public object GetbyCategoryID()
        {
            throw new NotImplementedException();
        }

        public ViewResult ViewPost(int id)
        {
            var model = postRepo.GetByID(id);
            return View(model);
        }

        public ActionResult BrowseAll()
        {
            ViewBag.Tags = tagRepo.GetAll();
            ViewBag.Categories = categoryRepo.GetAll();
            var model = postRepo.GetAll();
            return View(model);
        }

        public object GetbyID()
        {
            throw new NotImplementedException();
        }

        public ActionResult BrowseByCategory(int id)
        {
            ViewBag.Tags = tagRepo.GetAll();
            ViewBag.Categories = categoryRepo.GetAll();
            PostRepository postRepoChild = postRepo as PostRepository;
            var model = postRepoChild.GetByCategoryId(id);
            return View(model);
        }

        public ActionResult BrowseByTag(int id)
        {
            ViewBag.Tags = tagRepo.GetAll();
            ViewBag.Categories = categoryRepo.GetAll();
            PostRepository postRepoChild = postRepo as PostRepository;
            var model = postRepoChild.GetByTagId(id);
            return View(model);
        }
    }
}