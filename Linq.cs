using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
        internal class Program
        {
            static void Main(string[] args)
            {
                int[] num = { 12, 34, 56, 78, 95 };
                var evennum = from number in num where (number % 2 == 0) select number;
                foreach (var num1 in evennum) { Console.WriteLine(num1 + "Even"); }


                int[] scores = { 97, 92, 81, 60 };

                // Define the query expression.
                IEnumerable<int> scoreQuery =
                    from score in scores
                    where score > 80
                    orderby score
                    select score;

                // Execute the query.
                foreach (int i in scoreQuery)
                {
                    Console.Write(i + " ");
                }


                string[] str = { "the", "quick", "brown", "fox", "jumps" };

                IEnumerable<String> query = from word in str where word.Length == 3 orderby word.Length, word.Substring(0, 1) select word;

                foreach (string word in query)
                {
                    Console.WriteLine(word);
                }
                Console.ReadLine();


                List<string> list = new List<string>() { "an", "apple", "at", "day" };
                var query1 = from word in list select word.Substring(0, 2);
                foreach (string s in query1)
                {
                    Console.WriteLine(s);

                }

            }
        }
}
