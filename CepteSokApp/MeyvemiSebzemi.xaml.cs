using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CepteSokApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MeyvemiSebzemi : ContentPage
    {
        public MeyvemiSebzemi()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#ffe000");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.Black;
        }
        async void MeyveClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MeyveSebze());
        }
        async void SebzeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sebze());
        }
    }
}