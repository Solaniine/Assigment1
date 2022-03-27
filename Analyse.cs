using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {

        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text


        public List<int> AnalyseText(string input)
        {
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for (int j = 0; j < 5; j++)
            {
                values.Add(0);

            }

            int n = input.Length;
            int i = 0;

                
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            int numberofsentences = 0;
            for (i = 0; i < input.Length; i++)
            {

                if (input.Contains("."))
                {
                    numberofsentences++;

                }
            }
            //2. Number of vowels
            int numberofvowels = 0;
            for (i = 0; i < input.Length; i++)
            {

                if (input.Contains('a') || input.Contains('e') || input.Contains('i') || input.Contains('o') || input.Contains('u'))
                {
                    numberofvowels++;
  
                }
            }
            //3. Number of consonants
            int numberofcons = 0;
            for (i = 0; i < input.Length; i++)
            {
                numberofcons = input.Length - numberofvowels;
            }
            //4. Number of upper case letters
            int numberofupper = 0;
            for (i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    numberofupper++;

                }
            }
            //5. Number of lower case letters
            int numberoflower = 0;
            for (i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                {
                    numberoflower++;

                }
            }
            Console.WriteLine("num of sentences" + numberofsentences);
            Console.WriteLine("num of vowels " + numberofvowels);
            Console.WriteLine("num of cons "+numberofcons);
            Console.WriteLine("num of upper"+numberofupper);
            Console.WriteLine("num of lower"+ numberoflower);

            return values;
        }
    }
}
