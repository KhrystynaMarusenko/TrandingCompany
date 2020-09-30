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
        public void CanAddUser()
        {
            //Arrange
            var service = new UserService();
            
            //Act
            service.Create("Test Name", "Test Second Name", true, DateTime.Now, "Address", "login", "password");

            //Assert
            var user = service.Get();
            Assert.Single(user);
        }

        [Fact]
        public void CanDeleteUser()
        {
            //Arrange
            var service = new UserService();

            //Act
            service.Create("Test Name", "Test Second Name", true, DateTime.Now, "Address", "login", "password");
            var userId = service.Get().FirstOrDefault(p => p.FirstName == "Test Name").Id;
            service.Delete(userId);
            service.Save();

            //Assert
            var user = service.Get().FirstOrDefault(p => p.FirstName == "Test Name");
            Assert.Null(user);
        }
    }
}
