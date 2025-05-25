using System.Diagnostics;

namespace MauiAppLearningPlayground;

public partial class EncapsulationSample : ContentPage
{
	public EncapsulationSample()
	{
		InitializeComponent();

		var fee = new Fee();

		fee.Amount = 100;
        Debug.WriteLine($"Valid fee set: {fee.Amount}");

		fee.Amount = -50; 
		Debug.WriteLine($"Attempted to set negative fee and didn't change value is still: {fee.Amount}");

    }

	public class Fee
	{ 
		private decimal _amount;

		public decimal Amount 
		{
			get { return _amount; }
			set
			{
				if(value >=0)
					_amount = value;
				else
					Debug.WriteLine("Fee amount cannot be negative.");
            }
		}
    }

}