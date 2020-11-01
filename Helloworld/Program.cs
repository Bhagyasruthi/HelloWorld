using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("My second commit!");
            byte number = 2;
            int count = 10;
            float totalprice = 20.12f;
            char character = 'A';
            bool  working = true;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalprice);
            Console.WriteLine(character);
            Console.WriteLine(working);
            Console.WriteLine("{0} {1} ", byte.MinValue, byte.MaxValue);
            int i = 1;
            byte b = (byte)i;
            Console.WriteLine(b);
            var x = "1234";
            int y = Convert.ToInt32(x);
            Console.WriteLine(y);
            try
            {
                var z = "1234";
                byte c = Convert.ToByte(z);
                Console.WriteLine(c);

            }
            catch (Exception)
            {
                Console.WriteLine("The number couldnot be converted to byte");
            }
            var a = 2;
            var w = 3;
            Console.WriteLine(a + w);


















        }




    }
}
namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var bhagi = new Person();
            bhagi.FirstName = "Bhagya sruthi";
            bhagi.LastName = "Tirumalasetty";
            bhagi.Introduce();

        }
    }
}
