using System;

namespace bootcamp
{
    public class MakeAnInstanceOfMe: IMakeAnInstanceOfMe
    {
        public void sayHello()
        {
            Console.WriteLine("Hello World!");
        }
    }
}