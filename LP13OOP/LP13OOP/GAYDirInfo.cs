using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LP13OOP
{
    static class GAYDirInfo
    {
        public static void FileQuantity (string path)
        {
            Console.WriteLine($"Количество файло в директории {path} : {Directory.GetFiles(path).Length} \n");

        }
        public static void CreationTime (string path)
        {
            Console.WriteLine($"Время создания каталога {path} : {Directory.GetCreationTime(path)} \n");
        }
        public static void  SubDirQuantity (string path)
        {
            Console.WriteLine($"Количество поддиректориев в директории {path} : {Directory.GetDirectories(path)} \n");
        }
        public static void ParentDir (string path)
        {
            Console.WriteLine($"Количество файло в директории {path} : {Directory.GetParent(path)} \n");
        }
    }
}
