using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
       
        
        public void outputFile(List<String> List, string file)
        {
            Analyse analysee = new Analyse();
            string list = "nothing";
            //Receive a list of integers back
            analysee.AnalyseText(list );
            Console.WriteLine("Number of Sentences"+""+List[0]);
            Console.WriteLine("Number of Vowels "+""+list[1]);
            Console.WriteLine("Number of upper "+""+list[2]); 
            Console.WriteLine("Number of lower"+""+list[3]);     
 
        }
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

    }
}
