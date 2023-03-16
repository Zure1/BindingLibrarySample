namespace BindingLibrarySample.iOS.Services
{
    using System;
    using Binding;
    using BindingLibrarySample.Services;

    public class AddNumberService : IAddNumberService
    {
#nullable enable
        public int AddNumbers(int number1, int number2)
        {
            Foundation.NSError? error = null;

            var n1 = new PositiveNumber((nint)number1, out error);
            if (error != null)
            {
                throw new ArgumentOutOfRangeException(nameof(number1));
            }

            var n2 = new PositiveNumber((nint)number2, out error);
            if (error != null)
            {
                throw new ArgumentOutOfRangeException(nameof(number2));
            }

            var adder = new Adder(); // Adder is the class from the binding library
            var sum = adder.AddWithA(n1, n2);

            return (int)sum.Value;
        }
#nullable disable
    }
}

