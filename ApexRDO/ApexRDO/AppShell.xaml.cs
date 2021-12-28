using ApexRDO.ViewModels;
using ApexRDO.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ApexRDO
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));            
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(NoteEntryPage), typeof(NoteEntryPage));
            Routing.RegisterRoute($"nameof(AboutPage)", typeof(AboutPage));
        }

    }
}
