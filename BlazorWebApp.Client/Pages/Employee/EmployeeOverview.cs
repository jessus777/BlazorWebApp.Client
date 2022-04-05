using BlazorWebApp.Shared;
namespace BlazorWebApp.Client.Pages.Employee
{
    public partial class EmployeeOverview
    {
        public IEnumerable<BlazorWebApp.Shared.Employee> Employees { get; set; }
        public List<Country> Countries { get; set; }
        public List<JobCategory> JobCategories { get; set; }

        private void InitializeJobCategories()
        {
            JobCategories = new List<JobCategory>()
            {
                new JobCategory { JobCategoryId = 1, JobCategoryName = "Pie research"},
                new JobCategory{JobCategoryId = 2, JobCategoryName = "Sales"},
                new JobCategory { JobCategoryId = 3, JobCategoryName = "Management"},
                new JobCategory{JobCategoryId = 4, JobCategoryName = "Store staff"} ,
                new JobCategory { JobCategoryId = 5, JobCategoryName = "Finance"},
                new JobCategory{JobCategoryId = 6, JobCategoryName = "QA"},
                new JobCategory { JobCategoryId = 7, JobCategoryName = "IT"},
                new JobCategory{JobCategoryId = 8, JobCategoryName = "Cleaning"},
                new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"},
                new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"}

            };
        }

        private void InitializeCountries()
        {
            Countries = new List<Country>
            {
                new Country{CountryId = 1, Name = "Belgium"},
                new Country{CountryId = 2, Name = "Netherlands"},
                new Country{CountryId = 3, Name = "USA"},
                new Country{CountryId = 4, Name = "Japan"},
                new Country{CountryId = 5, Name = "China"},
                new Country{CountryId = 6, Name = "UK"},
                new Country{CountryId = 7, Name = "France"},
                new Country{CountryId = 8, Name = "Brazil"}
            };
        }

        private void InitializeEmployees()
        {
            var e1 = new BlazorWebApp.Shared.Employee
            {
                CountryId = 1,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1989,3,11),
                City = "Brussels",
                Email = "bethan@bethanyspieshop.com",
                EmployeeId = 1,
                FirstName = "Bethany",
                LastName = "Smith",
                Gender = Gender.Female,
                PhoneNumber = "3534534677",
                Smoker = false,
                Street = "Grote Mark 1",
                Zip = "1000",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2015,3,1)
            };
        }
    }
}
