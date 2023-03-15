namespace BindingLibrarySample.iOS.Services
{
    using System;
    using BindingLibrarySample.Services;

    public class AddNumberService : IAddNumberService
    {
        public int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}

