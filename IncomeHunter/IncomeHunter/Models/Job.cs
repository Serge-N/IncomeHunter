using System;

namespace IncomeHunter.Models
{
    public class Job
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public int PayAmount { get; set; }
        public string PayUnit { get; set; }
        public string PayType { get; set; }
        public string Source { get; set; }
        public string Education { get; set; }
        public int Experience { get; set; }
        public string ExperienceUnits { get; set; }
        public string UrlAddress { get; set; }
        public string Description { get; set; }
        public int Form { get; set; } //1 - Internation 0 - local
        public DateTime Date { get; set; }
    }
}