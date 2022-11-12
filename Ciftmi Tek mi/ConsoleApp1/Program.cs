using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b = 2,mod;
            Console.WriteLine("Bir sayı giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            mod = ( a % b);
            if (mod == 0)
                Console.WriteLine("Girilen sayi çift sayıdır.");
            else 
                Console.WriteLine("Girilen sayi tek sayidir.");
            Console.ReadKey();
        }
    }
}
