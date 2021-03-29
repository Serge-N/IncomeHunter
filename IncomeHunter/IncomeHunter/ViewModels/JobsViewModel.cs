using IncomeHunter.Models;
using IncomeHunter.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IncomeHunter.ViewModels
{
    public class JobsViewModel : BaseViewModel
    {
        private Job _selectedItem;

        public ObservableCollection<Job> Job { get; }
        public Command LoadItemsCommand { get; }
        public Command<Job> ItemTapped { get; }

        public JobsViewModel()
        {
            Title = "Browse";
            Job = new ObservableCollection<Job>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<Job>(OnItemSelected);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Job.Clear();
                var Jobs = await DataStore.GetItemsAsync(true);
                foreach (var item in Jobs)
                {
                    Job.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public Job SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

       

        async void OnItemSelected(Job item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(JobDetailPage)}?{nameof(JobDetailViewModel.ItemId)}={item.Id}");
        }
    }
}