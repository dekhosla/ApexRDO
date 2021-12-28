﻿using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApexRDO.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {

            InitializeComponent();
           
        }
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ApiCall());
        }
        private async void NavigateButton_OnClickedSecond(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotesPage());
        }
        private async void NavigateButton_OnClickedThird(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemsPage());
        }
    }
}