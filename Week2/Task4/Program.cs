using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{

    class Program
    {
        public class SimpleFileCopyandDelete
        {
            static void Main()
            {
                string fileName = "test3.txt";
                string Path = @"C:\Users\Nurik\Desktop\C#\Week2\path";
                string Path1 = @"C:\Users\Nurik\Desktop\C#\Week2\path1";
                string sourceFile = System.IO.Path.Combine(Path, fileName);
                string destFile = System.IO.Path.Combine(Path1, fileName);
                if (!System.IO.Directory.Exists(Path1))
                {
                    System.IO.Directory.CreateDirectory(Path1);
                }
                System.IO.File.Copy(sourceFile, destFile, true);
                if (System.IO.Directory.Exists(Path))
                {
                    string[] files = System.IO.Directory.GetFiles(Path);

                    
                    foreach (string s in files)
                    {
                        
                        fileName = System.IO.Path.GetFileName(s);
                        destFile = System.IO.Path.Combine(Path1, fileName);
                        System.IO.File.Copy(s, destFile, true);
                    }
                }
                else
                {
                    Console.WriteLine("Исходный путь не существует!");
                }
                
                if (System.IO.File.Exists(@"C:\Users\Nurik\Desktop\C#\Week2\path\test3.txt"))
                {
                    
                    try
                    {
                        System.IO.File.Delete(@"C:\Users\Nurik\Desktop\C#\Week2\path\test3.txt");
                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }
               

             
                Console.WriteLine("Нажмите Enter");
                Console.ReadKey();
            }
        }

       

            }
        }

        