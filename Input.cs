using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{

    public class Input
    {
        //Handles the text input for Assessment 1
        //string textfile = "nothing";


        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file

        public string FileTextInput(string file)
        {
            try
            {

                //grabs file and writes whats the file
                StreamReader textfile = new StreamReader("textfile.txt");
                string Read = textfile.ReadToEnd();
                return Read;
                    
                
            }

            //error handling if it can't read the file
            catch (IOException)
            {
             
                
                 return("this dont work pls fix can not find file ");
            }


        }
    }
}
