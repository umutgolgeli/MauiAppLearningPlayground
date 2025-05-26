using System.Diagnostics;

namespace MauiAppLearningPlayground.ViewModels
{
    public class MainPageViewModel
    {
        public Customer Customer { get; }

        public MainPageViewModel()
        {
            Customer = new Customer
            {
                Name = "Umut",
                Address = null
            };

            if (!string.IsNullOrEmpty(Customer.Name))
            {
                Debug.WriteLine(Customer.Address?.Country);
            }
        }

        public class Customer
        {
            public string Name { get; set; }
            public Address? Address { get; set; }
        }

        public class Address
        {
            public string Country { get; set; }
        }
    }
}
