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
        static void Main(string[] args)
        {
            string path, path2;
            Console.WriteLine("Введите путь к файлу и имя");
            path = Console.ReadLine();
            //the variable which holds the path of file which will be coped 
            Console.WriteLine("Введите путь куда вы будете копировать и имя файла");
            path2 = Console.ReadLine();
            //variable which holds path where will go the copied file 
            FileInfo file = new FileInfo(path);
            //create the file which will be manipulated
            file.CopyTo(path2);
            //copy the file which is in fileinfo class to path2
            file.Delete();
            //delete the copiedd file 
        }
    }
}