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
    public partial class Kampanyalar : ContentPage
    {
        public Kampanyalar()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#ffe000");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.Black;
        }
    }
}