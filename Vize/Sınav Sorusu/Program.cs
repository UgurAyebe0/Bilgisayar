using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    // 1 Gün 25 Tl
    // ilk 2 saat 6 Tl
    // Kalan saatler 2 Saat
    internal class Program
    {
        static void Main(string[] args)
        {
            int girilen_saat;
            int hesaplanan_gün;
            int hesaplanan_saat;
            int ödeme = 0;
            Console.WriteLine("Kaç saat girdiğinizi yazın");
            girilen_saat = Convert.ToInt16(Console.ReadLine());

            hesaplanan_gün = girilen_saat / 24;
            hesaplanan_saat = girilen_saat % 24;

            if (hesaplanan_saat <= 2)
            {
                ödeme = (hesaplanan_gün * 25) + 6;
            }
            if (hesaplanan_saat >=2 && hesaplanan_saat <= 8)
            {
                hesaplanan_saat = hesaplanan_saat - 2;
                ödeme = (hesaplanan_gün * 25) + 6 + (hesaplanan_saat * 2);
            }
            if (hesaplanan_saat > 8)
            {
                ödeme = (hesaplanan_gün + 1) * 25;
            }
            Console.WriteLine("{0} Plakalı aracınız için yapacağınız ödeme {1} TL", ödeme);
        }
    }
}
