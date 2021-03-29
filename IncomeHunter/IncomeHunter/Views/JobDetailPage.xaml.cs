using IncomeHunter.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace IncomeHunter.Views
{
    public partial class JobDetailPage : ContentPage
    {
        public JobDetailPage()
        {
            InitializeComponent();
            BindingContext = new JobDetailViewModel();
        }
    }
}