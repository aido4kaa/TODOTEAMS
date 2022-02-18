using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using FrontEnd.Pages;
using FrontEnd.Services;
using Xamarin.Essentials;
using JetBrains.Annotations;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Acr.UserDialogs;


namespace FrontEnd.ViewModel
{
    internal class RegisterViewModel
    {
        public async Task<bool> Register(string login, string password, string name)
        {
            var _user = await new UserService().AddNewUser(new User { Login = login, Password = password, Name = name });
            if (_user != null)
            {
                Preferences.Set("current_user_id", _user.Id);
                await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
                return true;
            }
            return false;
        }
        
        public void Toast(string text)
        {
            ToastConfig toastConfig = new ToastConfig(text);
            toastConfig.BackgroundColor = Color.FromHex("#DDCDFF");
            toastConfig.SetDuration(5000);
            UserDialogs.Instance.Toast(toastConfig);
        }
    }
}
