using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eShopOnContainers.Core.ViewModels;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            List<Image> images = new List<Image>()
            {
                new Image(){Source="https://img.tozlu.com/Uploads/SayfaTasarim/Sayfa10/Mutluluk-Zamani-6afd.jpg"},
                new Image(){Source="https://img.tozlu.com/Uploads/SayfaTasarim/Sayfa10/Yeni-Sezon-Ilk-Firsatlari-7808.jpg"},
                new Image(){Source="https://img.tozlu.com/Uploads/SayfaTasarim/Sayfa10/Ilk-Bahar-Yaz-Koleksiyonu-8529.jpg"}
            };
            HomePageCarousel.ItemsSource = images;
            }
    }
}