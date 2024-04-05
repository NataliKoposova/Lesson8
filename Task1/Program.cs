using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp";
            Console.WriteLine("Перечень подкаталогов:");
            string[] dirs = Directory.GetDirectories(path);
            foreach (string s in dirs)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Перечень файлов:");
            string[] files = Directory.GetFiles(path,"*",SearchOption.AllDirectories);
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }
            Console.ReadKey();
        }
    }
}  
