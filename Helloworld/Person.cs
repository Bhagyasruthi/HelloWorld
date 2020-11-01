using System;
namespace Helloworld
{
    class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Introduce()
        {
            Console.WriteLine("Executin introduce");
            Console.WriteLine("My name is " + this.FirstName + " " + this.LastName);
        }

    }
}
