using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LP13OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Начало слежения за Debug в папке с программой
            Thread thread = new Thread(GAYLog.Start);
            thread.Start();

            GAYDiscInfo.FreeSpace("D:\\");
            GAYDiscInfo.FileSystemInfo("D:\\");
            GAYDiscInfo.FullDrivesInfo();

            GAYDirInfo.FileQuantity(@"D:\");
            GAYDirInfo.CreationTime(@"D:\");
            GAYDirInfo.SubDirQuantity(@"D:\");

            GAYFileInfo.FullPath(@"D:\in.txt");
            GAYFileInfo.BasicFileInfo(@"D:\in.txt");
            GAYFileInfo.CreationTime(@"D:\in.txt");

            GAYFileManager.InspectDrive(@"D:\");
            GAYFileManager.CopyFiles(@"D:\", ".txt");
            GAYFileManager.ArchiveUnarchive();
            thread.Abort();
            Console.WriteLine("Удалить каталоги? 0-нет 1-да");
            int answer = int.Parse(Console.ReadLine());
            if(answer==1)
            {
                System.IO.Directory.Delete("GAYInspect", true);
                System.IO.Directory.Delete("Unzipped", true);
            }
            GAYLog.SearchByDate("18.12.2018");
        }
    }
}
