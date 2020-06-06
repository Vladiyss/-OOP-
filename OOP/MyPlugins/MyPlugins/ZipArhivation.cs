using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace MyPlugins
{
    public static class ZipArhivation
    {
        public static void ZipProcess( string FileToWrite)
        {
            using (FileStream fileStream = new FileStream(Path.GetFileNameWithoutExtension(FileToWrite) + ".zip", FileMode.Create))
            {
                using (ZipArchive archive = new ZipArchive(fileStream, ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(FileToWrite, Path.GetFileName(FileToWrite));
                }
            }   
        }

        public static void DeZipProcess(string FileToReadFrom)
        {
            if (File.Exists(Path.GetFileNameWithoutExtension(FileToReadFrom) + ".zip"))
            {
                if (Directory.Exists("space"))
                {
                    Directory.Delete("space", true);
                }
                ZipFile.ExtractToDirectory(FileToReadFrom, "space");
                File.Delete(Path.GetFileNameWithoutExtension(FileToReadFrom) + ".zip");
            }
        }
               
    }
}

