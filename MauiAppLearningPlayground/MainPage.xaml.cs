using System.Diagnostics;

namespace MauiAppLearningPlayground
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();

            Customer customer = new Customer()
            {
                Name =  "Umut",
                Address = null                           
            };

            if (!string.IsNullOrEmpty(customer.Name)) {
                Debug.WriteLine(customer.Address?.Country);
            }

            //Bang Operator
            if (!string.IsNullOrEmpty(customer.Name))
            {
                Debug.WriteLine(customer.Address!.Country!);
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
