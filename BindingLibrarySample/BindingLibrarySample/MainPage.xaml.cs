using BindingLibrarySample.ViewModels;
using Xamarin.Forms;

namespace BindingLibrarySample
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel;
        
        public MainPage()
        {
            InitializeComponent();

            viewModel = (MainPageViewModel)BindingContext;
        }

        void EntryNumber1_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if (int.TryParse(e.NewTextValue, out int newNumber))
            {
                viewModel.Number1 = newNumber;
            }
        }

        void EntryNumber2_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if (int.TryParse(e.NewTextValue, out int newNumber))
            {
                viewModel.Number2 = newNumber;
            }
        }
    }
}

