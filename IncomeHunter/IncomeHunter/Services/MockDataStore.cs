using IncomeHunter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncomeHunter.Services
{
    public class MockDataStore : IDataStore<Job>
    {
        readonly List<Job> Jobs;

        public MockDataStore()
        {
            Jobs = new List<Job>()
            {
                new Job { Id = Guid.NewGuid().ToString(), Title = "Software Developer", Company="Apple", Form= 1, Source="LinkedIn", Education = "Degree", Experience = 5, ExperienceUnits="Year(s)", PayAmount=800000, PayUnit="$", PayType="Year", Location="Remote", Date=DateTime.UtcNow,  UrlAddress="https://linkIn.com/hsgdre/dger", Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "Javascript Developer",Company="Ocracle", Form= 1, Source="LinkedIn", Education = "Degree", Experience = 6, ExperienceUnits="Year(s)", PayAmount=800000, PayUnit="$", PayType="Year", Location="Remote", Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "React Developer", Company="ZESCO",  Form = 0, Source="Zambia Go Jobs", Education = "Degree", Experience = 1, ExperienceUnits="Year(s)", PayAmount=30000, PayUnit="ZMW", PayType="Month",Location="Remote",Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "MAUI Developer", Company="Airtel",  Form= 0, Source="Zambia Go Jobs", Education = "Degree", Experience = 2, ExperienceUnits="Year(s)", PayAmount=20000, PayUnit="ZMW", PayType="Month",Location="Remote", Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "Blazor Developer", Company="IBM",  Form= 1, Source="Glassdoor", Education = "Degree",  Experience = 2, ExperienceUnits="Year(s)", PayAmount=600000, PayUnit="$", PayType="Year",Location="Remote", Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "JS Developer", Company="UNZA",  Form= 1, Source="Zambia Go Jobs", Education = "Degree",  Experience = 1, ExperienceUnits="Year(s)", PayAmount=400000, PayUnit="ZMW", PayType="Year", Location="Remote", Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "Express Developer", Company="Apple",  Form= 1, Source="LinkedIn", Education = "Degree", Experience = 3,  ExperienceUnits="Year(s)", PayAmount=30000, PayUnit="$", PayType="Year", Location="Remote", Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "Node Developer", Company="Facebook",  Form= 1, Source="Reddit", Education = "Degree", Experience = 7, ExperienceUnits="Year(s)", PayAmount=700000, PayUnit="$", PayType="Year", Location="Remote", Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "Desktop Developer",  Company="Apple",  Form= 1, Source="LinkedIn", Education = "Degree", Experience = 2, ExperienceUnits="Year(s)", PayAmount=500000, PayUnit="$", PayType="Year", Location="Remote", Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "C# Developer", Company="Apple",  Form= 1, Source="LinkedIn", Education = "Degree", Experience = 5, ExperienceUnits="Year(s)", PayAmount=90000, PayUnit="$", PayType="Year", Location="Remote", Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "Donet Developer", Company="Google",  Form= 1, Source="StackOverflow",Education = "Degree", Experience = 8, ExperienceUnits="Year(s)", PayAmount=700000, PayUnit="$", PayType="Year", Location="Remote", Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "Python Developer", Company="MTN", Form= 0, Source="Zambia Go Jobs", Education = "Degree", Experience = 1, ExperienceUnits="Year(s)", PayAmount=25000, PayUnit="ZMW", PayType="Month", Location="Remote", Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "Django Developer",Company="Apple", Form= 1, Source="HoneyPot", Education = "Degree", Experience = 3, ExperienceUnits="Year(s)", PayAmount=5000, PayUnit="$", PayType="Month", Location="Remote", Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "Flask Developer", Company="Zanaco", Form= 0, Source="LinkedIn", Education = "Degree", Experience = 1, ExperienceUnits="Year(s)", PayAmount=15000, PayUnit="ZMW", PayType="Month", Location="Remote",  Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "Azure Developer",Company="KCM",  Form= 0, Source="LinkedIn", Education = "Degree", Experience = 3, ExperienceUnits="Year(s)", PayAmount=10000, PayUnit="ZMW", PayType="Month", Location="Remote", Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "Cloud Developer", Company="Unliver", Form= 1, Source="LinkedIn", Education = "Degree", Experience = 2, ExperienceUnits="Year(s)", PayAmount=300000, PayUnit="$", PayType="Year", Location="Remote", Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "Mobile Developer", Company="Trade Kings", Form= 0, Source="Zambia Go Jobs", Education = "Degree", Experience = 1, ExperienceUnits="Year(s)", PayAmount=12000, PayUnit="ZMW", PayType="Year", Location="Remote", Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger",  Description="This is an item description." },
                new Job { Id = Guid.NewGuid().ToString(), Title = "Unity Developer", Company="Microsoft",  Form= 1, Source="LinkedIn", Education = "Degree", Experience = 2, ExperienceUnits="Year(s)", PayAmount=5000, PayUnit="$", PayType="Month", Location="Remote", Date=DateTime.UtcNow, UrlAddress="https://linkIn.com/hsgdre/dger", Description="This is an item description." }
            };
        }

        public async Task<Job> GetItemAsync(string id)
        {
            return await Task.FromResult(Jobs.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Job>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(Jobs);
        }
    }
}