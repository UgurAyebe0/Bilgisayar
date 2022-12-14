using System;
namespace or214
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a;
            string s = " ";
            string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] Yüzlük = { "Yüz", "İki Yüz", "Üç Yüz", "Dört Yüz", "Beş Yüz", "Alti Yüz ", "Yedi Yüz", "Sekiz Yüz", "Dokuz Yüz" };
            Console.Write("Bir Sayı Giriniz:");
            a = int.Parse(Console.ReadLine());
            if (a / 100 >= 1)
            { 
                s += Yüzlük[(a / 100) - 1];
                a = a % 100;
            }
            if (a / 10 >= 1)
            {
                s += Onlar[(a / 10) - 1];
                a = a % 10;
            }
            if (a % 10 != 0)
            { 
                s += Birler[(a % 10) - 1];
            }

            Console.WriteLine(s);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}