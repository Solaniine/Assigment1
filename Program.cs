//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();


            //Create 'Input' object
            //Get either manually entered text, or text from a file

            string file = "text";


            Input input= new Input();
            input.FileTextInput(file);
            string textfile = input.FileTextInput(file);



            //Create an 'Analyse' object
            Analyse analysee = new Analyse();

            //Receive a list of integers back
            analysee.AnalyseText(textfile);
            parameters = analysee.AnalyseText(textfile);

            //Report the results of the analysis
            Input input2 = new Input();
            Report report = new Report();
            Report(List<string>);



            //TO ADD: Get the frequency of individual letters?




        }



    }
}
