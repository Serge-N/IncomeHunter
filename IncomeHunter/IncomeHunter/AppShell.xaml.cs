using IncomeHunter.Views;
using Xamarin.Forms;

namespace IncomeHunter
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(JobDetailPage), typeof(JobDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
