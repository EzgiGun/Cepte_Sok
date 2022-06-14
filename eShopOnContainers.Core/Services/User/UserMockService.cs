using eShopOnContainers.Core.Models.User;
using eShopOnContainers.Core.Services.Settings;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eShopOnContainers.Core.Services.User
{
    public class UserMockService : IUserService
    {
        FirebaseClient client;



        private UserInfo MockUserInfo = new UserInfo
        {
            UserId = Guid.NewGuid().ToString(),
            Name = "Ezgi",
            LastName = "Gün",
            PreferredUsername = "Jdoe",
            Email = "jdoe@eshop.com",
            PhoneNumber = "202-555-0165",
            Address = "Seattle, WA",
            Street = "120 E 87th Street",
            ZipCode = "98101",
            Country = "Türkiye",
            State = "İzmir",
            CardNumber = "378282246310005",
            CardHolder = "American Express",
            CardSecurityNumber = "1234"
        };

        private ISettingsService _settingsService;


        public UserMockService()
        {

            _settingsService = DependencyService.Get<ISettingsService>();

            client = new FirebaseClient("https://ceptesokapp-c57b2-default-rtdb.firebaseio.com/");


        }


           

      
        public async Task<UserInfo> GetUserInfoAsync(string authToken)
        {
            await Task.Delay(10);
            return MockUserInfo;
        }
    }
}