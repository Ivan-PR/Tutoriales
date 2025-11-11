using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OpenWebinarsData
{
    public static class SystemIOSample
    {
        public static void SampleFile()
        {
            if (File.Exists("C:\\MyDirectory\\MyFile.txt"))
            {
            }
        }

        public static void SampleDirectory()
        {
            Directory.Move("C:\\MyDirectory\\MyFile.txt", "D:\\");
        }

        public static void FileInfoDirectoryInfoSample()
        {
            FileInfo fileInfo = new FileInfo("C:\\MyDirectory\\MyFile.txt");
            DirectoryInfo dirInfo = new DirectoryInfo("C:\\MyDirectory");
        }
    }
}