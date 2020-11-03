using AutoMapper;
using BLL.Services;
using DAL.Concrete;
using Entity.Concrete;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BLL.XUnitTest
{
    public class ItemServiceTests
    {
        [Fact]
        public void CanCreateItems()
        {
            var mapperMoq = new Mock<IMapper>();
            var categoryDalMoq = new Mock<CategoryDal>();
            var itemDalMoq = new Mock<ItemDal>();
            itemDalMoq
                .Setup(p => p.Insert(It.IsAny<Item>()))
                .Returns(1);
            var service = new ItemService(itemDalMoq.Object, categoryDalMoq.Object, mapperMoq.Object);

            var result = service.Create(new Views.ItemViewModel()
            { Category = "cat", Description = "desc", Id = 1, InStock = "sure" });

            Assert.True(result);
        }

        [Fact]
        public void CanGetItemByCategory()
        {
            var mapperMoq = new Mock<IMapper>();
            var categoryDalMoq = new Mock<CategoryDal>();
            var itemDalMoq = new Mock<ItemDal>();
            categoryDalMoq
                .Setup(p => p.GetByName("name"))
                .Returns(new Category("name", "desc"));
            itemDalMoq
                .Setup(p => p.GetByFieldName(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(new List<Item> { new Item("name", "desc", 1, 12, "in"));
            var service = new ItemService(itemDalMoq.Object, categoryDalMoq.Object, mapperMoq.Object);

            var result = service.GetByCategory("name");

            Assert.NotNull(result);
            Assert.Single(result);
        }
    }
}
