using System;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo path1 = new DirectoryInfo (@"C:\PP2\Week2\path");  // создать  каталога для исходной папки
            DirectoryInfo path2 = new DirectoryInfo (@"C:\PP2\Week2\path1"); // создать  каталога для папки назначения
            string file = Console.ReadLine("Напиши имя файла . формат"); // прочитайте имя файла, который нужно переместить

            
            string sourcefile = Path.Combine(path1.FullName, file); //путь к исходному файлу
            string folderfile =  Path.Combine(path2.FullName, file); //путь к файлу назначения
            if (!File.Exists (sourcefile)) { // если исходный файл существует, то создайте новый файл с текстом «$ file_name $ + было создано»
                Console.WriteLine ();  
                File.WriteAllText (sourcefile, file ); 
            }
            Console.WriteLine ( sourcefile, folderfile); 
            File.Move (sourcefile, folderfile); 
            Console.WriteLine (); 
        }
        static void show (DirectoryInfo x) {  // использовал эту функцию для печати содержимого каталога для тестирования. Не используется в основной функции
            Console.WriteLine (x.FullName);
            var files = x.GetFileSystemInfos();
            
            foreach (var i in files) {
                Console.WriteLine("    " + i.Name);
                Console.ReadKey();
            }
        }
    }
}