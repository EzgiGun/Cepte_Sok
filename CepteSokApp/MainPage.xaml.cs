using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CepteSokApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var images = new List<String>
            {
                "Kampanya1.png",
                "Kampanya2.png",
                "Kampanya3.png",
            };
            MainCarouselView.ItemsSource = images;
        }
        async void BellClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kampanyalar());
        }
        async void haftaFirsatClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new haftaFirsatlari());
        }

        async void kTeslimClicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new KargoTeslimat());
        }
        async void MeyvemiSebzemiClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MeyvemiSebzemi());
        }
        async void EtTavukClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EtmiTavukmu());
        }
        async void SutUrunleriClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SutUrunleri());
        }
        async void KahvaltilikClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kahvaltilik());
        }
        async void EkmekPClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EkmekPUrunleri());
        }
        async void DondurulmusUClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DondurulmusUrun());
        }
        async void YemeklilMalzClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new YemeklikMalz());
        }
        async void AtistirmalikClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Atistirmalik());
        }
        async void IcecekClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Icecekler());
        }
        async void KisiselBakimClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KisiselBakim());
        }
    }
}
