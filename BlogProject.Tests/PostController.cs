using BlogProject.Controllers;
using BlogProject.Models;
using BlogProject.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BlogProject.Tests
{
    public class PostControllerTests
    {

        PostController underTest;
        IRepository<BlogContext> PostRepo;


        public PostControllerTests()
        {
            PostRepo = Substitute.For<IRepository<Post>>();
            underTest = new PostController(PostRepo);
        }


        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Post();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Coffees_To_View()
        {
            var expectedCoffees = new List<Coffee>();
            coffeeRepo.GetAll().Returns(expectedCoffees);

            var result = underTest.Index();

            Assert.Equal(expectedCoffees, result.Model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Course_To_View()
        {
            var expectedCoffee = new Coffee();
            coffeeRepo.GetById(1).Returns(expectedCoffee);

            var result = underTest.Details(1);

            Assert.Equal(expectedCoffee, result.Model);
        }

    }
}