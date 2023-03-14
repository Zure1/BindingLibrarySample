namespace BindingLibrarySample.ViewModels
{
    using System;
    using System.ComponentModel;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ICommand AddNumbersCommand { get; }
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        private string numbersSumResult = "Start calculating to see the result!";

        public event PropertyChangedEventHandler PropertyChanged;

        public string NumbersSumResult
        {
            get { return numbersSumResult; }
            set
            {
                numbersSumResult = value;
                OnPropertyChanged(nameof(NumbersSumResult));
            }
        }

        public MainPageViewModel()
        {
            AddNumbersCommand = new Command(AddNumbers);
        }

        private void AddNumbers()
        {
            var sum = Number1 + Number2;
            NumbersSumResult = $"Sum: {sum.ToString()}";
        }

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}