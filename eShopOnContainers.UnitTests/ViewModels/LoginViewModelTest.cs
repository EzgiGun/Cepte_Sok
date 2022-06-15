using eShopOnContainers.Core.Models.Navigation;
using eShopOnContainers.Core.Models.User;
using eShopOnContainers.Core.Services.Settings;
using eShopOnContainers.Core.ViewModels;
using eShopOnContainers.Core.ViewModels.Base;
using eShopOnContainers.UnitTests.Mocks;
using Firebase.Database;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace eShopOnContainers.UnitTests.ViewModels
{
    public class LoginViewModelTest
    {
        FirebaseClient client = new FirebaseClient("https://ceptesokapp-c57b2-default-rtdb.firebaseio.com/");



        [Fact]
        public async Task RegisterUser()
        {

        
                    await client
                  .Child("Users")
                  .PostAsync(new UserInfo() { Username = "Test", Name = "", Password = "Test", Address = "", CardHolder = "", CardNumber = "", CardSecurityNumber = "", Country = "", Email = "", LastName = "", PhoneNumber = "", PreferredUsername = "", State = "", Street = "", UserId = "", ZipCode = "" });

            bool hasUser = await IsUserExists("Test");
              

            Assert.Equal(true,hasUser);
        }


        [Fact]
        public async Task UserExistsTest()
        {


            var user = (await client.Child("Users")
               .OnceAsync<UserInfo>()).Where(u => u.Object.Username == "ezgi").FirstOrDefault();



            Assert.NotNull(user);
        }


        [Fact]
        public async Task UserNotExistsTest()
        {

            var user = (await client.Child("Users")
               .OnceAsync<UserInfo>()).Where(u => u.Object.Username == "boylekullaniciyok").FirstOrDefault();



            Assert.Null(user);
        }


        [Fact]
        public async Task LoginTrueTest()
        {

            var user = (await client.Child("Users")
             .OnceAsync<UserInfo>()).Where(u => u.Object.Username == "ezgi")
             .Where(u => u.Object.Password == "123").FirstOrDefault();




            Assert.NotNull(user);
        }



        [Fact]
        public async Task LoginFalseTest()
        {

            var user = (await client.Child("Users")
             .OnceAsync<UserInfo>()).Where(u => u.Object.Username == "ezgi")
             .Where(u => u.Object.Password == "1234").FirstOrDefault();




            Assert.Null(user);
        }



        public async Task<bool> IsUserExists(string uname)
        {
            var user = (await client.Child("Users")
            .OnceAsync<UserInfo>()).Where(u => u.Object.Username == uname).FirstOrDefault();

            return (user != null);
        }



    }
}
