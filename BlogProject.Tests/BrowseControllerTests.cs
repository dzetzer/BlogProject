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
        BrowseController underTest;
        IRepository<Post> PostRepo;

        public BrowseControllerTests()
        {
            PostRepo = Substitute.For<IRepository<Post>>();
            underTest = new BrowseController(PostRepo);
        }

        [Fact]
        public void Browse_Returns_A_View()
        {
            var result = underTest.Browse();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void BrowseAll_Passes_All_Posts_To_View()
        {
            var expectedPost = new List<Post>();
            PostRepo.GetAll().Returns(expectedPost);

            var result = underTest.BrowseAll();

            Assert.Equal(expectedPost, result.Model);
        }

        [Fact]
        public void ViewPost_Returns_A_View()
        {
            var result = underTest.ViewPost(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void ViewPost_Passes_Post_To_View()
        {
            var expectedPost = new Post();
            PostRepo.GetByID(1).Returns(expectedPost);

            var result = underTest.Post(1);

            Assert.Equal(expectedPost, result.Model);
        }

    }
}
