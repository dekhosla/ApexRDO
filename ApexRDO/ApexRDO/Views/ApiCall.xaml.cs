using ApexRDO.Models;
using ApexRDO.Settings;
using ApexRDO.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApexRDO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApiCall : ContentPage
    {
        //public ApiCall()
        //{
        //    InitializeComponent();
        //}
        RestService _restService;

        public ApiCall()
        {
            InitializeComponent();
            _restService = new RestService();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            List<Repository> repositories = await _restService.GetRepositoriesAsync(Constants.GitHubReposEndpoint);
            collectionView.ItemsSource = repositories;
        }

        private async void BacktoHomePage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//AboutPage");
            //await Navigation.PushAsync(new AboutPage());
            //await Navigation.PushModalAsync(new AboutPage());
        }
    }
}