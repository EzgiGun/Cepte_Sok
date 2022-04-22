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
    public partial class KargoTeslimat : ContentPage
    {
        public KargoTeslimat()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#ffe000");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.Black;
        }

        int count = 1;
        void btnPlusClicked0(object sender, EventArgs e)
        {
            count++;
            var btn = (Button)sender;
            label.Text = $"Adet : {count}";
            if(count >= 10)
            {
                count = 0;
            }
        }

        void btnEpsClicked0(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                count = 1;
            }
            var btn = (Button)sender;
            label.Text = $"Adet : {count}";
            
        }


        void btnPlusClicked1(object sender, EventArgs e)
        {
            count++;
            var btn = (Button)sender;
            label1.Text = $"Adet : {count}";
            if (count >= 10)
            {
                count = 0;
            }
        }

        void btnEpsClicked1(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                count = 1;
            }
            var btn = (Button)sender;
            label1.Text = $"Adet : {count}";

        }



        void btnPlusClicked2(object sender, EventArgs e)
        {
            count++;
            var btn = (Button)sender;
            label2.Text = $"Adet : {count}";
            if (count >= 10)
            {
                count = 0;
            }
        }

        void btnEpsClicked2(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                count = 1;
            }
            var btn = (Button)sender;
            label2.Text = $"Adet : {count}";

        }




        void btnPlusClicked3(object sender, EventArgs e)
        {
            count++;
            var btn = (Button)sender;
            label3.Text = $"Adet : {count}";
            if (count >= 10)
            {
                count = 0;
            }
        }

        void btnEpsClicked3(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                count = 1;
            }
            var btn = (Button)sender;
            label3.Text = $"Adet : {count}";

        }




        void btnPlusClicked4(object sender, EventArgs e)
        {
            count++;
            var btn = (Button)sender;
            label4.Text = $"Adet : {count}";
            if (count >= 10)
            {
                count = 0;
            }
        }

        void btnEpsClicked4(object sender, EventArgs e)
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