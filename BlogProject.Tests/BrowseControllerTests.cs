using BlogProject.Controllers;
using BlogProject.Models;
using BlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BlogProject.Tests
{
    public class BrowseControllerTests
    {
        public BrowseController underTest;
        IRepository<Post> PostRepo;
      

        public BrowseControllerTests()
        {
            PostRepo = Substitute.For<IRepository<Post>>();
            underTest = new BrowseController(PostRepo);
        }

        [Fact]
        public void Browse_Returns_A_View()
        {

            var model = PostRepository.GetByID();

            Assert.IsType<ViewResult>(model);
        }

        [Fact]
        public void BrowseAll_Passes_All_Posts_To_View()
        {
            var expectedPost = new List<Post>();
            PostRepo.GetAll().Returns(expectedPost);

            var result = underTest.BrowseAll();

            Assert.Equal(expectedPost, result.Model);
        }
    }
}
