using eShopOnContainers.Core.Extensions;
using eShopOnContainers.Core.Models.Catalog;
using Firebase.Database;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eShopOnContainers.Core.Services.Catalog
{
    public class CatalogMockService : ICatalogService
    {

        FirebaseClient client;


        private ObservableCollection<CatalogBrand> MockCatalogBrand = new ObservableCollection<CatalogBrand>
        {
            new CatalogBrand { Id = 1, Brand = "Meyveler ve Sebzeler" },
            new CatalogBrand { Id = 2, Brand = "Et & Tavuk" },
            new CatalogBrand { Id = 2, Brand = "Süt Ürünleri" },
            new CatalogBrand { Id = 2, Brand = "Kahvaltılık" },
            new CatalogBrand { Id = 2, Brand = "Ekmek & Pastane" },
        };

        private ObservableCollection<CatalogType> MockCatalogType = new ObservableCollection<CatalogType>
        {
            new CatalogType { Id = 1, Type = "All" },
        };

        public ObservableCollection<CatalogItem> MockCatalog;

        public CatalogMockService()
        {
            client = new FirebaseClient("https://ceptesokapp-c57b2-default-rtdb.firebaseio.com/");

            getItemsFromService();
        }

        public async void getItemsFromService()
        {
            MockCatalog = await getProducts();

        }


        public async Task<ObservableCollection<CatalogItem>> getProducts()
        {
            ObservableCollection<CatalogItem> productList = (await client.Child("Products")
            .OnceAsync<CatalogItem>()).Select(item => new CatalogItem
            {
                Id = item.Object.Id,
                Name = item.Object.Name,
                PictureUri = item.Object.PictureUri,
                Price = item.Object.Price,
                Description = item.Object.Description,
                CatalogBrand = item.Object.CatalogBrand,
                CatalogType = item.Object.CatalogType,
                CatalogBrandId = item.Object.CatalogBrandId,
                CatalogTypeId = item.Object.CatalogTypeId,


            }).ToObservableCollection<CatalogItem>();

            return productList;
        }

        public async Task<ObservableCollection<CatalogItem>> GetCatalogAsync()
        {
            await Task.Delay(10);

            return MockCatalog;
        }

        public async Task<ObservableCollection<CatalogItem>> FilterAsync(int catalogBrandId, int catalogTypeId)
        {
            await Task.Delay(10);

            return MockCatalog
                .Where(c => c.CatalogBrandId == catalogBrandId &&
                c.CatalogTypeId == catalogTypeId)
                .ToObservableCollection();
        }

        public async Task<ObservableCollection<CatalogBrand>> GetCatalogBrandAsync()
        {
            await Task.Delay(10);

            return MockCatalogBrand;
        }

        public async Task<ObservableCollection<CatalogType>> GetCatalogTypeAsync()
        {
            await Task.Delay(10);

            return MockCatalogType;
        }
    }
}