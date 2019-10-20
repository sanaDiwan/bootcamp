using System;
using Microsoft.Extensions.DependencyInjection;

namespace bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IMakeAnInstanceOfMe, MakeAnInstanceOfMe>()
                .AddSingleton<IWithConstructionParameters, WithConstructionParameters>()
                .BuildServiceProvider();

            //do the actual work here
            var makeAnInstanceOfMe = serviceProvider.GetService<IMakeAnInstanceOfMe>();
            makeAnInstanceOfMe.sayHello();

            var withConstructionParameters = serviceProvider.GetService<IWithConstructionParameters>();
            Console.WriteLine("Enter a number: ");
            var param = Convert.ToInt32(Console.ReadLine());
            withConstructionParameters.displayNumber(param);
        }
    }
}
