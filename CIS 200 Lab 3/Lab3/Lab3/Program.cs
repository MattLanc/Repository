using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add system.IO
using System.IO;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gathers user entered text data.
            Console.Write("Enter some data to save: ");
            string userText = Console.ReadLine();
            //gathers the user file name
            Console.Write("Enter the desired file name: ");
            string fileName = Console.ReadLine();

            //Now You! Save the string the user has entered as a text file with the name that the user has entered
            File.WriteAllText(userText, fileName);


            //End part 1

            Console.WriteLine("Your File was saved!");

            //variables to load
            string loadFileName = "Lab3LoadingFile.txt";
            string loadedValue = File.ReadAllText(loadFileName);
            //Part 2 - load the contents of the text file who's name is in the variable loadFileName into loadedValue;

            

            //End part 2

            Console.WriteLine("The loaded contents of the text file are");
            Console.WriteLine(loadedValue);
        }
    }
}
