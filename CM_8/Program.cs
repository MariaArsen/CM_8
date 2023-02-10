using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CM_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp";
            string[] files = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            string[] files2 = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (string file2 in files2)
            {
                Console.WriteLine(file2);
            }

            Console.ReadKey();
        }
    }
}
