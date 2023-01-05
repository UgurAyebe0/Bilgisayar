using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] b = { 0, 0, 0 };
            int a;
            string s = " ";
            string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] Yüzlük = { "Yüz", "İki Yüz", "Üç Yüz", "Dört Yüz", "Beş Yüz", "Alti Yüz ", "Yedi Yüz", "Sekiz Yüz", "Dokuz Yüz" };
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Bir Sayı Giriniz:");
                b[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                if (b[i] / 100 >= 1)
                {
                    Console.Write(Yüzlük[((b[i] / 100) - 1)]);
                    b[i] = b[i] % 100;
                }
                if (b[i] / 10 >= 1)
                {
                    Console.Write(Onlar[((b[i] / 10) - 1)]);
                    b[i] = b[i] % 10;

                }
                if (b[i] % 10 != 0)
                {
                    Console.Write(Birler[(b[i] - 1)]);
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
