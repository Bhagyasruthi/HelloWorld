using System;
namespace Helloworld
{
    public class FundamentalProgram
    {
        public FundamentalProgram()
        {

        }
        public void execute()
        {
            Console.WriteLine("executing FundamentalProgram");
            Person bhagi = new Person();
            bhagi.FirstName = "Sruthi";
            bhagi.LastName = "Tirumalasetty";
            bhagi.Introduce();
        }
    }
}
