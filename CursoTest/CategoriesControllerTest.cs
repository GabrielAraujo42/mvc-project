using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Microsoft.EntityFrameworkCore;
using Xunit;
using CursoMVC.Models;
using CursoAPI.Controllers;

namespace CursoTest
{
    public class CategoriesControllerTest
    {
        private readonly Mock<DbSet<Category>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Category _category;

        public CategoriesControllerTest()
        {
            _mockSet = new Mock<DbSet<Category>>();
            _mockContext = new Mock<Context>();
            _category = new Category { id = 1, description = "Category Test"};

            _mockContext.Setup(m => m.Categories).Returns(_mockSet.Object);

            _mockContext.Setup(m => m.Categories.FindAsync(1)).ReturnsAsync(_category);
        }

        [Fact]
        public async Task Get_Category()
        {
            var service = new CategoriesController(_mockContext.Object);

            await service.GetCategory(1);

            _mockSet.Verify(m => m.FindAsync(1), Times.Once());
        }
    }
}
