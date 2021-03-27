using IncomeHunter.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace IncomeHunter.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new JobDetailViewModel();
        }
    }
}