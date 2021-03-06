﻿using System;
using System.IO;

namespace Task3
{
    public class Program
    {
        static void Main()
        {
            DirectoryInfo dirInfo = new DirectoryInfo (@"C:\PP2\Week1"); // создана переменная типа каталога с информацией о конкретном пути
            file_tree (dirInfo, 0); // отображение tree файлов

        }
        static void file_tree (DirectoryInfo dirInfo, int k) { // dirInfo - текущий каталог, а k - количество родительских каталогов.

            string files = dirInfo.GetFiles(); // создал список файлов, расположенных в текущем каталоге
            Console.ForegroundColor = ConsoleColor.Yellow; // изменить цвет файлов на yellow
            foreach (string i in files) {  // итерация файл
                for (int j = 0; j < 4*k; j++)
                                // печать вкладок длиной в 4 раза выше уровня, так что имя родительского каталога будет за пределами вкладки
                Console.WriteLine (i.Name); // print имя файла
                
            }
            string subdirs = dirInfo.GetDirectories(); // создан список информации о подкаталогах текущего каталога 
            foreach (string i in subdirs) { // итерация подкаталоги

                Console.ForegroundColor = ConsoleColor.White; // изменить цвет подкаталог на white
                for (int j = 0; j < 4*k; j++)
                   
                Console.WriteLine(i.Name); // print  каталог
                file_tree (i, k + 1); // показать рекурсивно
            }
            Console.ForegroundColor = ConsoleColor.White; // 
        }
    }
}