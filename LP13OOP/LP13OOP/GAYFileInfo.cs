using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LP13OOP
{
   static class GAYFileInfo
    {
        public static void FullPath (string path)
        {
            FileInfo fi = new FileInfo(path);
            Console.WriteLine($"Full path to {fi.Name}: {fi.FullName} \n");

        }
        public static void CreationTime (string path)
        {
            FileInfo fi = new FileInfo(path);
            Console.WriteLine($"Время создания файла {fi.Name} : {fi.CreationTime} \n");
        }
        public static void BasicFileInfo (string path)
        {
            FileInfo fi = new FileInfo(path);
            Console.WriteLine($"Имя файла {fi.Name}");
            Console.WriteLine($"Расширение файла {fi.Extension}");
            Console.WriteLine($"Размер файла {fi.Length}");
        }
       
    }
}
