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


        //public ViewResult ViewPost(int id)
        //{
        //    var model = postRepo.GetByID(id);
        //    return View(model);

        //var model = underTest.GetbyCategoryID();

        //    Assert.IsType<ViewResult>(model);

        [Fact]
        public void Browse_Returns_A_View()
        {

            var model = PostRepository.GetByID();

            Assert.IsType<ViewResult>(model);
        }



        //Arrange



        //Act



        //Assert



        //[Fact]
        //public void Browse_Returns_A_View()
        //{
        //    var model = underTest.BrowseAll();

        //    Assert.IsType<ViewResult>(model);
        //}

        //[Fact]
        //public void BrowseAll_Passes_All_Posts_To_View()
        //{
        //    var expectedPost = new List<Post>();
        //    PostRepo.GetAll().Returns(expectedPost);

        //    var result = underTest.BrowseAll();

        //    Assert.Equal(expectedPost, result.Model);
        //}

        //public BrowseController underTest;
        //IRepository<Category> CategoryRepo;

        //public BrowseControllerTests()
        //{
        //    CategoryRepo = Substitute.For<IRepository<Category>>();
        //    underTest = new BrowseController(CategoryRepo);
        //}

        //[Fact]
        //public void Browse_Returns_A_View()
        //{
        //    var model = underTest.GetbyCategoryID();

        //    Assert.IsType<ViewResult>(model);
        //}

        //[Fact]
        //public void BrowseAll_Passes_All_Categories_To_View()
        //{
        //    var expectedCategory = new List<Category>();
        //    CategoryRepo.GetAll().Returns(expectedCategory);

        //    var result = underTest.BrowseAll();

        //    Assert.Equal(expectedCategory, result.Model);
        //}

        //[Fact]
        //public void Browse_Returns_A_Tag()
        //{
        //    var model = underTest.GetbyTagID();

        //    Assert.IsType<ViewResult>(model);
        //}

        //[Fact]
        //public void BrowseAll_Passes_All_Tags_To_View()
        //{
        //    var expectedTag = new List<Post>();
        //    TagRepo.GetAll().Returns(expectedTag);

        //    var result = underTest.BrowseAll();

        //    Assert.Equal(expectedTag, result.Model);
        //}
    }
}
