using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Hocam ödevi yaparken biraz sıkıntılar yaşandı ama olsun,, 
 */
namespace BursVeren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gelir = 0, basari = 0, cevap = 0;
            Console.Write("Gelir giriniz: ");
            gelir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Basari giriniz: ");
            basari = Convert.ToInt32(Console.ReadLine());
            if (gelir < 3001 && basari <= 4)
            {
                cevap = 1;
                //Hata Ayıklama Console.WriteLine("1");
            if (gelir >= 5000 && gelir <= 6000 && basari >= 8 && basari <= 10)
            {
                cevap = 2;
                //Hata Ayıklama Console.WriteLine("2");
            }
            if (gelir > 3000 && gelir <= 5000 && basari >= 4 && basari <= 7)
            {
                cevap = 3;
                //Hata Ayıklama Console.WriteLine("3");
            } } 
            else
            {
                cevap = 4;
                //Hata Ayıklama Console.WriteLine("4");
            }
            switch (cevap)
            { 
            case 1: Console.WriteLine("400 Tl Burs Kazandınız."); break;
            case 2: Console.WriteLine("500 Tl Burs Kazandınız."); break;
            case 3: Console.WriteLine("750 Tl Burs Kazandınız."); break;
            case 4: Console.WriteLine("Burs Kazanamadınız"); break;
            }
            Console.WriteLine("Cıkmak için bir tuşa basın"); 
            Console.ReadKey();
        }
    }
}