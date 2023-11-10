using System.Threading.Tasks;
using projet.Models.TokenAuth;
using projet.Web.Controllers;
using Shouldly;
using Xunit;

namespace projet.Web.Tests.Controllers
{
    public class HomeController_Tests: projetWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}