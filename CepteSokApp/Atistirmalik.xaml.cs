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
    public partial class Atistirmalik : ContentPage
    {
        public Atistirmalik()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#ffe000");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.Black;
        }
        int count = 1;

        void btnm(object sender, EventArgs e)
        {
            count++;
            var btn = (Button)sender;
            label.Text = $"Adet : {count}";
            if (count >= 10)
            {
                count = 0;
            }
        }
        void btnm0(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                count = 1;
            }
            var btn = (Button)sender;
            label.Text = $"Adet : {count}";

        }
        void btnm1(object sender, EventArgs e)
        {
            count++;
            var btn = (Button)sender;
            label1.Text = $"Adet : {count}";
            if (count >= 10)
            {
                count = 0;
            }
        }

        void btnm2(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                count = 1;
            }
            var btn = (Button)sender;
            label1.Text = $"Adet : {count}";

        }
        void btnm3(object sender, EventArgs e)
        {
            count++;
            var btn = (Button)sender;
            label2.Text = $"Adet : {count}";
            if (count >= 10)
            {
                count = 0;
            }
        }

        void btnm4(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                count = 1;
            }
            var btn = (Button)sender;
            label2.Text = $"Adet : {count}";

        }
        void btnm5(object sender, EventArgs e)
        {
            count++;
            var btn = (Button)sender;
            label3.Text = $"Adet : {count}";
            if (count >= 10)
            {
                count = 0;
            }
        }

        void btnm6(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                count = 1;
            }
            var btn = (Button)sender;
            label3.Text = $"Adet : {count}";

        }
        void btnm7(object sender, EventArgs e)
        {
            count++;
            var btn = (Button)sender;
            label4.Text = $"Adet : {count}";
            if (count >= 10)
            {
                count = 0;
            }
        }

        void btnm8(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                count = 1;
            }
            var btn = (Button)sender;
            label4.Text = $"Adet : {count}";

        }
    }
}