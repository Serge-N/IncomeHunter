using IncomeHunter.ViewModels;
using Xamarin.Forms;

namespace IncomeHunter.Views
{
    public partial class JobsPage : ContentPage
    {
        JobsViewModel _viewModel;

        public JobsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new JobsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}