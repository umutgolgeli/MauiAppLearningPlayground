using System.Diagnostics;

namespace MauiAppLearningPlayground.ViewModels
{
    public class MainPageViewModel
    {
        public CustomerModel Customer { get; }

        public MainPageViewModel()
        {
            Customer = new CustomerModel
            {
                Name = "Umut",
                Address = null
            };

            if (!string.IsNullOrEmpty(Customer.Name))
            {
                Debug.WriteLine(Customer.Address?.Country);
            }
        }

        public class CustomerModel
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
