using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace DelUnitTests
{
	public class CategoryServiceTests
	{
		[Fact]
		public void CanAddCategory()
		{
			//Arrange
			var service = new CategoryService();

			//Act
			service.Create("Test Name");
			service.Save();

			//Assert
			var category = service.Get().FirstOrDefault(p => p.CategoryName == "Test Name");
			Assert.NotNull(category);
		}

		[Fact]
		public void CanNotGetNotExistingCategory()
		{
			var service = new CategoryService();

			service.Create("Test Name");
			service.Save();

			var category = service.Get().FirstOrDefault(p => p.CategoryName == "Name");
			Assert.Null(category);
		}

		[Fact]
		public void CanDeleteExistingCategory()
		{
			var service = new CategoryService();

			service.Create("Test Name");
			service.Save();
			var categoryId = service.Get().FirstOrDefault(p => p.CategoryName == "Test Name").Id;
			service.Delete(categoryId);
			service.Save();


			var categories = service.Get();
			Assert.Null(categories);

		}

		public void CanChangeExistingCategory()
		{

			var service = new CategoryService();

			service.Create("Test Name");
			service.Save();
			var categoryId = service.Get().FirstOrDefault(p => p.CategoryName == "Test Name").Id;
			service.Change(categoryId, "New Name");
			service.Save();

			var id = service.Get().FirstOrDefault(p => p.CategoryName == "New Name").Id;
			Assert.Equal(id, categoryId);
		}
	}
}
