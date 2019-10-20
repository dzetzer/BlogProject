using System;
using System.Collections.Generic;
using BlogProject.Controllers;
using BlogProject.Models;
using BlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using Xunit;

namespace BlogProject.Tests
{
    public class CategoryRepoTests
    {
        public BrowseController underTest;
        IRepository<Category> CategoryRepo;


        public CategoryRepoTests()

        {
            CategoryRepo = Substitute.For<IRepository<Category>>();
            underTest = new BrowseController(CategoryRepo);
        }

        [Fact]
        public void Browse_Returns_A_View()
        {
            var model = underTest.GetbyCategoryID();

            Assert.IsType<ViewResult>(model);
        }

        [Fact]
        public void BrowseAll_Passes_All_Categories_To_View()
        {
            var expectedCategory = new List<Category>();
            CategoryRepo.GetAll().Returns(expectedCategory);

            var result = underTest.BrowseAll();

            Assert.Equal(expectedCategory, result.Model);
        }
    }
}
