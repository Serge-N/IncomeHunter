using IncomeHunter.ViewModels;
using IncomeHunter.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace IncomeHunter
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
