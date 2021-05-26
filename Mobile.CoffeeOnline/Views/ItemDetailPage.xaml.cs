using Mobile.CoffeeOnline.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Mobile.CoffeeOnline.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}