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
        public ScanList()
        {
            stkMainlayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical
            };
            ZXingScannerPage scanPage;
            Button btnScan = new Button
            {
                Text = "Scan",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            btnScan.Clicked += async (a, s) => {
                scanPage = new ZXingScannerPage();
                scanPage.OnScanResult += (result) => {
                    scanPage.IsScanning = false;
                    Device.BeginInvokeOnMainThread(async () => {
                        await Navigation.PopModalAsync();
                        await DisplayAlert("Scanned Barcode", result.Text + " , " + result.BarcodeFormat + " ," + result.ResultPoints[0].ToString(), "OK");
                    });
                };
                await Navigation.PushModalAsync(scanPage);
            };
            stkMainlayout.Children.Add(btnScan);
            Content = stkMainlayout;
        }
    }
}