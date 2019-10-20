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
                .BuildServiceProvider();

            //do the actual work here
            var makeAnInstanceOfMe = serviceProvider.GetService<IMakeAnInstanceOfMe>();
            makeAnInstanceOfMe.sayHello();
        }
    }

    public class MakeAnInstanceOfMe: IMakeAnInstanceOfMe
    {
        public void sayHello()
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IMakeAnInstanceOfMe
    {
        void sayHello();
    }
}
