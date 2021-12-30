using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace ApexRDO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanList : ContentPage
    {
        //public ScanList()
        //{
        //    InitializeComponent();
        //}
        StackLayout stkMainlayout;
        List<retval> retVal;
        public ScanList()
        {
          // retVal = new List<retval>();
            InitializeComponent();
           // retval retVal1 = new retval();
           // retVal1.Name = "test";
           // retVal.Add(retVal1);
            collectionView.ItemsSource = retVal;
            //List<retval> retVal = new List<retval>();
            //stkMainlayout = new StackLayout
            //{
            //    HorizontalOptions = LayoutOptions.FillAndExpand,
            //    VerticalOptions = LayoutOptions.FillAndExpand,
            //    Orientation = StackOrientation.Vertical
            //};
            //ZXingScannerPage scanPage;
            //Button btnScan = new Button
            //{
            //    Text = "Scan",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center
            //};
            //btnScan.Clicked += async (a, s) => {
            //    scanPage = new ZXingScannerPage();
            //    scanPage.OnScanResult += (result) => {
            //        scanPage.IsScanning = false;
            //        Device.BeginInvokeOnMainThread(async () => {
            //            await Navigation.PopModalAsync();
            //            retval retVal1 = new retval();
            //            retVal1.Name = result.Text;
            //            retVal.Add(retVal1);
            //            await DisplayAlert("Scanned Barcode", result.Text + " , " + result.BarcodeFormat + " ," + result.ResultPoints[0].ToString(), "OK");

            //        });
            //    };
            //    await Navigation.PushModalAsync(scanPage);
            //};
            //stkMainlayout.Children.Add(btnScan);
            //Content = stkMainlayout;
        }

        public class retval{
            public string Name { get; set; }
        }
        private async void ScanButton(object sender, EventArgs e)
        {         
          
            ZXingScannerPage scanPage;          
           
                scanPage = new ZXingScannerPage();
                scanPage.OnScanResult += (result) => {
                    scanPage.IsScanning = false;
                    Device.BeginInvokeOnMainThread(async () => {
                        await Navigation.PopModalAsync();
                        retval retVal1 = new retval();
                        retVal1.Name = result.Text;
                        retVal.Add(retVal1);
                        collectionView.ItemsSource = retVal;
                        await DisplayAlert("Scanned Barcode", result.Text + " , " + result.BarcodeFormat + " ," + result.ResultPoints[0].ToString(), "OK");

                    });
                };
                await Navigation.PushModalAsync(scanPage);
        }

            private async void BacktoHomePage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//AboutPage");
            //await Navigation.PushAsync(new AboutPage());
            //await Navigation.PushModalAsync(new AboutPage());
        }


    }
}