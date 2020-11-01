using System;
namespace Helloworld
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
    class Programm1
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