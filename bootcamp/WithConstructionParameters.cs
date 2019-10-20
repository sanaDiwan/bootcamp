using System;

namespace bootcamp
{
    public class WithConstructionParameters: IWithConstructionParameters
    {
        public void displayNumber(int param)
        {
            Console.WriteLine($"You have entered: {param}");
        }

    }
}