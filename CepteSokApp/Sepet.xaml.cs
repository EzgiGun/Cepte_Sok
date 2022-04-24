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
    public partial class Sepet : ContentPage
    {
        double prc = 0;
        public Sepet(string Name, string source, double price, string explain)
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#ffe000");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.Black;

            MyItemNameShow.Text = Name;
            MyItemExplain.Text = explain;
            prc = price;
            totalLabel.Text = "Toplam Fiyat: " + price.ToString();
            MyItemPrice.Text = price.ToString() + " ₺";
            MyImageCall.Source = source;
        }
        public Sepet()
        {
        }
        int count = 1;


        void btnP(object sender, EventArgs e)
        {
            count++;
            var btn = (Button)sender;
            label.Text = $"Adet : {count}";
            if (count >= 10)
            {
                count = 0;
            }

            totalLabel.Text = "Toplam Fiyat: " + (count * prc).ToString();
        }
        void btnE(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                count = 1;
            }
            var btn = (Button)sender;
            label.Text = $"Adet : {count}";
            totalLabel.Text = "Toplam Fiyat: " + (count * prc).ToString();
        }


    }
}