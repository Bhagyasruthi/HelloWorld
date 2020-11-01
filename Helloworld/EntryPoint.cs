using System;
namespace Helloworld
{

    public class EntryPoint
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("no arguments passed");
                System.Environment.Exit(1);
            }
            string argument = args[0];
            Console.WriteLine("argument passed :"+argument);

            switch (argument)
            {
                case "first":
                    Console.WriteLine("Executing Fundamental Program");
                    FundamentalProgram programOne = new FundamentalProgram();
                    programOne.execute();
                    break;
                case "second":
                    Console.WriteLine("Executing Fundamental Program Two");
                    FundamentalProgramTwo programTwo = new FundamentalProgramTwo();
                    programTwo.execute();
                    break;
                case "third":
                    Console.WriteLine("Executing Numbner Guess Two");
                    NumberGuess numberGuess = new NumberGuess();
                    numberGuess.execute();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;

            }
        }
    }
}
