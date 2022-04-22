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
    public partial class EtmiTavukmu : ContentPage
    {
        public EtmiTavukmu()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#ffe000");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.Black;
        }
        async void EtClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EtTavuk());
        }
        async void TavukClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tavuk());
        }
    }
}