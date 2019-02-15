using System;
using System.IO;

namespace Task_3
{
    public class Program
    {
        static void Main()
        {
            DirectoryInfo root = new DirectoryInfo (@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU"); // created directory type variable with the information about certain path.
            file_tree (root, 0); // showing a file tree
        }
        static void file_tree (DirectoryInfo root, int lvl) { // root is the current directory, and lvl represents the number of parent directories
            var files = root.GetFiles(); // created a list of files located in current directory
            Console.ForegroundColor = ConsoleColor.DarkGray; // change text color to dark grey to highlighting files
            foreach (var i in files) {  // iterating through the files
                for (int j = 0; j < 4*lvl; j++)
                           // printing tabs of length 4 times level, so that the the name of parent directory will be a tab beyond

                Console.WriteLine (i.Name); // printing the name of the file
                
            }
            var subdirs = root.GetDirectories(); // created a list of information about subdirectories of the current directory 
            foreach (var i in subdirs) { // iterating through the sub-directories
                Console.ForegroundColor = ConsoleColor.White; // chaning the text color to white, used for subdirectories
                for (int j = 0; j < 4*lvl; j++)
                    
                Console.WriteLine(i.Name); // print  name of the directory
                file_tree (i, lvl + 1); // recursively print contents of the subdirectory
            }
            Console.ForegroundColor = ConsoleColor.White; // in the end return the default color of the text
        }
    }
}