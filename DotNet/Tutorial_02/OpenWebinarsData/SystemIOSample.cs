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

        public static void WorkingWithFile()
        {
            // Stream

            // MemoryStream StreamWriter StreamReader FileStream

            // StreamWriter writer = new StreamWriter("C:\\MyDirectory\\MyFile.txt"); StreamReader
            // reader = new StreamReader("C:\\MyDirectory\\MyFile.txt"); FileStream fileStream = new
            // FileStream("C:\\MyDirectory\\MyFile.txt", FileMode.OpenOrCreate);

            FileStream fileStr = new FileStream("C:\\MyDirectory\\MyFile.txt", FileMode.OpenOrCreate);
            fileStr.Seek(0, SeekOrigin.Begin);
            fileStr.Close();
        }
    }
}