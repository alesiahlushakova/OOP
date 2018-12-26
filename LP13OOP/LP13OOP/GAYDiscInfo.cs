using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LP13OOP
{
    static class GAYDiscInfo
    {
        public static void FreeSpace ( string name)
        {
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                if( di.Name==name && di.IsReady)
                {
                    Console.WriteLine($"Доступный объем на диске {name.First()} : {di.AvailableFreeSpace} \n");
                }
            }
        }
        public static void FileSystemInfo (string name)
        {
            foreach( DriveInfo di in DriveInfo.GetDrives())
            {
                if(di.Name==name && di.IsReady)
                {
                    Console.WriteLine($"Тип файловой системы и формат диска {name.First()} : {di.DriveType} , {di.DriveType} \n");
                }
            }
        }
        public static void FullDrivesInfo ()
        {
            foreach(DriveInfo di in DriveInfo.GetDrives())
            {
                if(di.IsReady)
                {
                    Console.WriteLine($" Имя: {di.Name}\n Объем: {di.TotalSize}\n Доступный объем: {di.TotalFreeSpace}\n Метка тома: {di.VolumeLabel}/n");
                }
            }
        }
    }
}
