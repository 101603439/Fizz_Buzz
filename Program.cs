using System;

namespace SelectionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string results = "";
        for (int j = 1; j <= 100; j++)
        {
            if ( j % 3 == 0) 
            results = "Fizz ";

            if ( j % 5 == 0) 
            results = results + "Buzz";

            if (results.Length == 0) results = j.ToString();
            
            Console.WriteLine(results);
        }
        }
    }
}
