using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        // Entry Point
        static void Main(string[] args)
        {
            //Setting app vars
            string appName ="Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Christa Stephens";

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            //easier verion of interpolation so that you don't have to keep track of var order
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

        }
    }
}
