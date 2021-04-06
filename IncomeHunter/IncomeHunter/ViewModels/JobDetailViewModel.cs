using IncomeHunter.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IncomeHunter.ViewModels
{
    [QueryProperty(nameof(JobId), nameof(JobId))]
    public class JobDetailViewModel : BaseViewModel
    {
        private string id;
        private string title;
        private string description;
        private string company;
        private string location;
        private string payAmount;
        private string source;
        private string education;
        private string experience;
        private string urlAddress;
        private int form;
        private DateTime date;

        public new string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string Company
        {
            get => company;
            set => SetProperty(ref company, value);
        }

        public string Location
        {
            get => location;
            set => SetProperty(ref location, value);
        }
        public string PayAmount
        {
            get => payAmount;
            set => SetProperty(ref payAmount, value);
        }
        

        public string Source
        {
            get => source;
            set => SetProperty(ref source, value);
        }

        public string Education
        {
            get => education;
            set => SetProperty(ref education, value);
        }
        public string Experience
        {
            get => experience;
            set => SetProperty(ref experience, value);
        }
       
        public string UrlAddress
        {
            get => urlAddress;
            set => SetProperty(ref urlAddress, value);
        }

        public int Form
        {
            get => form;
            set => SetProperty(ref form, value);
        }

        public DateTime Date
        {
            get => date;
            set => SetProperty(ref date, value);
        }

        public string JobId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string jobId)
        {
            try
            {
                var job = await DataStore.GetItemAsync(jobId);
                Title = job.Title;
                Company = job.Company;
                Location = job.Location;
                PayAmount = $"{job.PayUnit} {job.PayAmount:#,##0} per {job.PayType}";
                Source = job.Source;
                Education = job.Education;
                Experience = $"{job.Experience} {job.ExperienceUnits}";
                Description = job.Description;
                UrlAddress = job.UrlAddress;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Job");
            }
        }
    }
}
