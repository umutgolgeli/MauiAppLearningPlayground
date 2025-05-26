using MauiAppLearningPlayground.ViewModels;

namespace MauiAppLearningPlayground
{
    public partial class MainPage : ContentPage
    {
        public MainPageViewModel ViewModel { get; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new MainPageViewModel();
            BindingContext = ViewModel;
        }
    }

}
