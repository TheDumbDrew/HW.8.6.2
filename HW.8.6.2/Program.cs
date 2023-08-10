using System;
using System.IO;
//В заданиях использую диск H, так как на нем расположены все файлы по обучению
namespace DirectoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCatalogs(); //   Вызов метода получения директорий
        }

        static void GetCatalogs()
        {
            string dirName = @"H:\\/1Обучение/TEST"; // Прописываем путь к корневой директории
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

                foreach (string d in dirs) // Выведем их все
                    Console.WriteLine(d);

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                foreach (string s in files)   // Выведем их все
                    Console.WriteLine(s);
                TotalSize = long(0++)
                Console.WriteLine("Общий объем файлов:" dirName.TotalSize);
            }
        }
    }
}








//H:/1Обучение/TEST/InternalPapka