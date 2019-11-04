/*
Author:     Michael Hart
Date:       11/3/19
CTEC 135:   Microsoft Software Development with C#
<Module 6, Programming Assignment 5, Problem 1>
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_1
{
    // LINQ

    // Create a static method that:
    //     creates an array of strings(the ordering of the strings should be random)
    //     create a LINQ statement that returns the strings that start with 'a' - 'f'
    //     output the result
    //     modify the array in such a way that the result will be different
    //     output the result again
    //     modify the array in such a way that the result will be different
    //     capture the result as a List<string> object and return it
    // in Main, output the returned result

    class Program
    {
        static void Main(string[] args)
        {
            // define an array of strings
            string[] randomMovies = {"Fight Club", "Dirty Harry",
            "Goldfinger", "Gone with the Wind", "It's a Wonderful Life",
            "Caddyshack"};

            // desired query: strings that start with 'a' through 'f'            
            List<string> finalResult = QueryOverMovies(randomMovies);

            Console.WriteLine("***** Returned results from QueryOverMovies() method *****");
            foreach (string s in finalResult)
            {
                Console.WriteLine("Item: {0}", s);
            }
            Console.WriteLine();
           
        }

        
        static List<string> QueryOverMovies(string[] inputArray)
        {
            // create a LINQ statement that returns the strings that start with 'a' - 'f'
            var subset = from movie in inputArray
                         where movie.StartsWith("A") || movie.StartsWith("B") ||
                         movie.StartsWith("C") || movie.StartsWith("D") ||
                         movie.StartsWith("E") || movie.StartsWith("F")
                         orderby movie
                         select movie;

            // output the result
            Console.WriteLine("***** Immediate results using LINQ query *****");
            foreach (var s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }
            Console.WriteLine();

            // modify the array in such a way that the result will be different
            inputArray[0] = "Top Gun";
            inputArray[3] = "Home Alone";

            // output the result again
            Console.WriteLine("***** Results after change to strings *****");
            foreach (var s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }
            Console.WriteLine();

            // modify the array in such a way that the result will be different
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray[i].Length; j++)
                {
                    if (i % 2 == 0)
                        inputArray[i] = "All Dogs Go To Heaven 2";                   
                }                
            }
            Console.WriteLine();

            // capture the result as a List<string> object and return it
            List<string> output = (from game in inputArray
                                       where game.Contains(" ")
                                       orderby game
                                       select game).ToList<string>();

            return output;
        }        
    }
}
