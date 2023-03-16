namespace BindingLibrarySample.Droid.Services
{
    using System;
    using BindingLibrarySample.Services;

    public class AddNumberService : IAddNumberService
	{
        public int AddNumbers(int number1, int number2)
        {
            var adder = new Adder(); // Adder is the class from the binding library
            var sum = adder.AddNumbers(number1, number2);
            return sum;
        }
    }
}

