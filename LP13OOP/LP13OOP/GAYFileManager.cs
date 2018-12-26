using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace LP13OOP
{
   static class GAYFileManager
    {
        public static void InspectDrive (string name)
        {

            DirectoryInfo dir = new DirectoryInfo(name);
            FileInfo[] file = dir.GetFiles();
            Directory.CreateDirectory(@"GAYInspect");
            using (StreamWriter sw = new StreamWriter(@"GAYInspect\gaydirinfo.txt"))
            {
                foreach (DirectoryInfo d in dir.GetDirectories())
                    sw.WriteLine(d.Name); ;

                foreach (FileInfo f in file)
                    sw.WriteLine(f.Name);

            }

            File.Copy(@"GAYInspect\gaydirinfo.txt", @"GAYInspect\gaydirinfoRenamed.txt");
            File.Delete(@"GAYInspect\gaydirinfo.txt");
        }

        public static void CopyFiles (string path, string ext)

        {
            string dirpath = @"GAYFiles";
            Directory.CreateDirectory(dirpath);
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles();
            foreach(FileInfo file in files)
            {
                if (file.Extension == ext)
                    file.CopyTo($@"{dirpath}\{file.Name}");
            }
            Directory.Move(@"GAYFiles", @"GAYInspect\GAYFiles");
        }
        public static void ArchiveUnarchive()
        {

            string dirpath = @"GAYInspect\GAYFiles";
            string zippath = @"GAYInspect\GAYFiles.zip";
            string unzippath = @"Unzipped";
            
          ZipFile.CreateFromDirectory(dirpath, zippath);
          ZipFile.ExtractToDirectory(zippath, unzippath);

        }
    }
}
