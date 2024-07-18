using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;

namespace SocialNetwork.Tests
{

    [TestFixture]
    public class UserTests
    {
        [Test]
        public void TryRegisterWithWrongEmail_MustReturnException()
        {
            UserService userService = new UserService();
            UserRegistrationData userRegistrationData = new UserRegistrationData();
            userRegistrationData.Firstname = "Имя";
            userRegistrationData.Lastname = "Фамилия";
            userRegistrationData.Email = "testemail";
            userRegistrationData.Password = "password";

            Assert.Catch<Exception>(() => { userService.Register(userRegistrationData); });
        }
    }

        [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1()
        {
            Assert.True(100 == 100);
        }
    }
}