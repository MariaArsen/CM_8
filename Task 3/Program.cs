using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp\Тигр.txt";
            string line;
            int l = 0;  //Количество строк
            StreamReader sr = new StreamReader(path);
            while ((line=sr.ReadLine())!=null)
            {
                l++;
            }
            string word;
            int s = 0; //Количество слов
            foreach (string word in sr.ReadLine())
            {
                Convert.ToString(sr.ReadLine());
                s++;
            }
            Console.WriteLine("Количество строк в тексе {0}", l);
            Console.WriteLine("Количество слов в тексе {0}", s);
            Console.WriteLine("Количество символов в тексе {0}", sr.Lengt);
            Console.ReadKey();
        }
    }
}
