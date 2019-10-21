using System;
using System.Collections.Generic;
using BlogProject.Controllers;
using BlogProject.Models;
using BlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using Xunit;

//namespace BlogProject.Tests
//{
//    public class TagRepoTests
//    {
//        public BrowseController underTest;
//        IRepository<Tag> TagRepo;


//        public TagRepoTests()

//        {
//            TagRepo = Substitute.For<IRepository<Tag>>();
//            underTest = new BrowseController(TagRepo);
//        }

//        [Fact]
//        public void Browse_Returns_A_Tag()
//        {
//            var model = underTest.GetbyTagID();

//            Assert.IsType<ViewResult>(model);
//        }

//        [Fact]
//        public void BrowseAll_Passes_All_Tags_To_View()
//        {
//            var expectedTag = new List<Post>();
//            TagRepo.GetAll().Returns(expectedTag);

//            var result = underTest.BrowseAll();

//            Assert.Equal(expectedTag, result.Model);
//        }
//    }
//}
