using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPratice
{
    class Program
    {

        static void printResult(string displayWord, IEnumerable input)
        {
            foreach (var obj in input)
            {
                Console.WriteLine(displayWord + obj);
            }
        }
        static void Main(string[] args)
        {
            
            //Case
            int[] numArray = {5, 4, 3, 6, 1};
            
            var squaredNumbers = numArray.Select(x => x * x);
           
            printResult("squared Number : ", squaredNumbers);

            var squaredNumberSum = squaredNumbers.Sum();
            Console.WriteLine("Sum : " + squaredNumberSum);
            Console.WriteLine("Max : " + squaredNumbers.Max());

            var skipTest = squaredNumbers.OrderBy(g => g).Skip(2);

            printResult("skip : ", skipTest);

            

            var numberStringLookup = new Dictionary<string, int>()
            {
                {"zero", 0},
                {"one", 1},
                {"two", 2},
                {"three", 3},
                {"four", 4},
                {"five", 5},
                {"six", 6},
                {"seven", 7},
                {"eight", 8},
                {"nine", 9},
                {"ten", 0 }
            };

            var dictionaryAverage = numberStringLookup.Values.Average();
            Console.WriteLine("Dictionary Avg : " + dictionaryAverage);

            var dictionaryCount = numberStringLookup.Count();
            Console.WriteLine("Dictionary Count : " + dictionaryCount);

            var dictionaryDistinct = numberStringLookup.Values.Distinct();
            printResult("Dictionary Distinct : ", dictionaryDistinct);

            var wordList = new List<string>() { "ten", "nine", "eight", "seven", "six" };

            Console.WriteLine("Any : " + wordList.Any());

            var word = "seven";
            Console.WriteLine(" Contains : " + wordList.Contains(word));
            Console.WriteLine("First : " + wordList.First() + " Last : " + wordList.Last());
        }
    }
}
