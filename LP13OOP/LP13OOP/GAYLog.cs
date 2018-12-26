using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LP13OOP
{
    class GAYLog
    {
        static FileSystemWatcher watcher = new FileSystemWatcher
        {
            Path = @"D:\LP13OOP\LP13OOP\bin\Debug",
            IncludeSubdirectories = true,
            NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName

        };

        public static void Start()
        {
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;

        }
        public static void SearchByDate(string date)
        {
            watcher.EnableRaisingEvents = false;
            using (StreamReader sr = new StreamReader("gaylogfile.txt"))
            {
                while (!sr.EndOfStream)
                {
                    if(sr.ReadLine().StartsWith(date))
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
        }

        private static void OnChanged (object sender, FileSystemEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("gaylogfile.txt", true))
            {
                sw.WriteLine(DateTime.Now + " " + e.ChangeType + " путь " + e.FullPath);
            }
        }
    }
}
