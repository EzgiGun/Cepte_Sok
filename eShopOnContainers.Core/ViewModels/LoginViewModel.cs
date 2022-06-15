using eShopOnContainers.Core.Extensions;
using eShopOnContainers.Core.Models.User;
using eShopOnContainers.Core.Services.Identity;
using eShopOnContainers.Core.Services.OpenUrl;
using eShopOnContainers.Core.Services.Settings;
using eShopOnContainers.Core.Services.User;
using eShopOnContainers.Core.Validations;
using eShopOnContainers.Core.ViewModels.Base;
using eShopOnContainers.Core.Views;
using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _Username;
        public string Username
        {
            set
            {
                this._Username = value;
                OnPropertChanged();
            }
            get
            {
                return this._Username;
            }
        }



        private string _Password;
        public string Password
        {
            set
            {
                this._Password = value;
                OnPropertChanged();
            }
            get
            {
                return this._Password;
            }
        }
        private bool _IsBusy;
        public bool IsBusy
        {
            set
            {
                this._IsBusy = value;
                OnPropertChanged();
            }
            get
            {
                return this._IsBusy;
            }
        }
        private bool _Result;
        public bool Result
        {
            set
            {
                this._Result = value;
                OnPropertChanged();
            }
            get
            {
                return this._Result;
            }
        }



        public Command LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }



        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginCommandAsync());
            RegisterCommand = new Command(async () => await RegisterCommandAsync());
        }



        private async Task RegisterCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result = await userService.RegisterUser(Username, Password);
                if (Result)
                    await Application.Current.MainPage.DisplayAlert("Success", "Registerede", "OK");
                else
                    await Application.Current.MainPage.DisplayAlert("Error", "User already exists with this credentials", "OK");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }



        private async Task LoginCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result = await userService.LoginUser(Username, Password);
                if (Result)
                {
                    Preferences.Set("Username", Username);
                    await Application.Current.MainPage.Navigation.PushModalAsync(new CatalogView());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Invalid Username or Password", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}