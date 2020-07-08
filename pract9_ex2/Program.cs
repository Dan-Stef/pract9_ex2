using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pract9_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream fileStream = new FileStream("..\\..\\..\\TextFile1.txt", FileMode.OpenOrCreate);
                StreamReader sR = new StreamReader(fileStream);
                Console.WriteLine("Напишите любую букву: ");
                char letter = Convert.ToChar(Console.ReadLine());
                String str1 = String.Empty;

                while ((str1 = sR.ReadLine()) != null)
                {
                    char[] ch = str1.ToCharArray();
                    if (ch[0] == letter) Console.WriteLine(str1);
                    else  Console.WriteLine("С этой буквы не начинается ни одна строка"); break;
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Вы ввели неверные данные");
            }
           
            Console.ReadKey();
        }
    }
}
