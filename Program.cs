using System;
using System.Text;

namespace Words_Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Counters
            int countWords = 0;
            int countNumbers = 0;
            int countPunctuation = 0;
            int countUpperWords = 0;
            int countLowerWords = 0;


            //Input
            Console.WriteLine("WORDS COUNTER v1.0");
            Console.WriteLine("Enter the text you want to process:");
            Console.WriteLine();
            string line = Console.ReadLine();

            //Regular seaching

            //Words searching
            string[] words = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            countWords = words.Length;

            //Numbers, Punctiation, Upper and lower symbols searching
            foreach (var symbol in line)
            {
                if (char.IsDigit(symbol))
                {
                    countNumbers++;
                }
                else if (char.IsPunctuation(symbol))
                {
                    countPunctuation++;
                }
                else if (char.IsUpper(symbol))
                {
                    countUpperWords++;
                }
                else if (char.IsLower(symbol))
                {
                    countLowerWords++;
                }
            }

            //Print results
            Console.WriteLine();
            Console.WriteLine("RESULTS:");
            Console.WriteLine($"Words: {countWords}");
            Console.WriteLine($"Punctuations: {countPunctuation}");
            Console.WriteLine($"Numbers: {countNumbers}");
            Console.WriteLine($"Upper symbols: {countUpperWords}");
            Console.WriteLine($"Lower symbols: {countLowerWords}");

            //Input for special symbol
            Console.WriteLine();
            Console.WriteLine("Do you want to search for a specific symbol? (yes / no)");
            
            string answer = Console.ReadLine();

            //Special symbol searching
            if (answer == "yes")
            {
                Console.WriteLine("Enter the symbol you want to search for.");
                char symbolToBeSearched = char.Parse(Console.ReadLine());
                int countSymbol = 0;
                foreach (var symbol in line)
                {
                    if (symbol == symbolToBeSearched)
                    {
                        countSymbol++;
                    }
                }
                //Output
                Console.WriteLine($"The symbol \"{symbolToBeSearched}\" occurs {countSymbol} times.");
            }

        }
    }
}
