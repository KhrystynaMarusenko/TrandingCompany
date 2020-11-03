using AutoMapper;
using BLL.Services;
using DAL.Abstract;
using DAL.Concrete;
using DTO;
using Entity.Concrete;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace BLL.XUnitTest
{
    public class CategoryServiceTests
    {
        [Fact]
        public void CanGetUserById()
        {
            var mapperMoq = new Mock<IMapper>();
            var categoryDalMoq = new Mock<CategoryDal>();
            categoryDalMoq
                .Setup(p => p.GetById(It.IsAny<int>()))
                .Returns(new Category("name", "desc") { Id = 2 });
            var service = new CategoryService(categoryDalMoq.Object, mapperMoq.Object);

            var result = service.GetById(2);

            Assert.Equal(2, result.Id);
        }

        [Fact]
        public void CanGetAllUsers()
        {
            var mapperMoq = new Mock<IMapper>();
            var categoryDalMoq = new Mock<CategoryDal>();
            categoryDalMoq
                .Setup(p => p.GetAll())
                .Returns(new List<Category>() { new Category("name", "desc") { Id = 2 } });
            var service = new CategoryService(categoryDalMoq.Object, mapperMoq.Object);

            var result = service.GetAll();

            Assert.Single(result);
        }

        [Fact]
        public void CanGetUserByName()
        {
            var mapperMoq = new Mock<IMapper>();
            var categoryDalMoq = new Mock<CategoryDal>();
            categoryDalMoq
                .Setup(p => p.GetByName(It.IsAny<string>()))
                .Returns( new Category("name", "desc") { Id = 2 } );
            var service = new CategoryService(categoryDalMoq.Object, mapperMoq.Object);

            var result = service.GetByName("name");

            Assert.NotNull(result);
            Assert.Equal("name", result.Name)
        }
    }
}
