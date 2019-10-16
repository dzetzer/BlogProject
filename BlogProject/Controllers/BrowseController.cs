using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Models;
using BlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class BrowseController : Controller
    {
        PostRepository postRepo;

        public BrowseController(PostRepository postRepo)
        {
            this.postRepo = postRepo;
        }

        public ViewResult Browse()
        {
            var model = postRepo.GetAll();
            return View(model);
        }

        public ViewResult BrowseByCategory(int CategoryId)
        {
            var model = postRepo.GetByCategoryId(CategoryId);
            return View(model);
        }

        public ViewResult BrowseByTag(int TagId)
        {
            var model = postRepo.GetByTagId(TagId);
            return View(model);
        }
    }
}