using ApexRDO.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ApexRDO.Views
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