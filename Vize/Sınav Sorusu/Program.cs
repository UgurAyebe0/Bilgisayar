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
            girilen_saat = Convert.ToInt32(Console.ReadLine());

            hesaplanan_gün = girilen_saat / 24;
            hesaplanan_saat = girilen_saat % 24;

            if (hesaplanan_saat <= 2)
            {
                ödeme = (hesaplanan_gün * 25) + 6;
            }
            if (hesaplanan_saat >= 2 && hesaplanan_saat <= 8)
            {
                hesaplanan_saat = hesaplanan_saat - 2;
                ödeme = (hesaplanan_gün * 25) + 6 + (hesaplanan_saat * 2);
            }
            if (hesaplanan_saat > 8)
            {
                ödeme = (hesaplanan_gün + 1) * 25;
            }
            Console.WriteLine("Yapacağınız ödeme {0} TL", ödeme);
        }
    }
}


/*
public class Main {
    public static void main(String[] args) {

        int girilensaat = 25;
        int hesaplanansaat = girilensaat % 24; // 2
        int hesaplanangün = girilensaat / 24;
        int ödeme = 0;

        while (hesaplanansaat > 7) {
            ödeme = hesaplanangün * 25 + 25;
            hesaplanansaat = 0;
        }
        while (hesaplanansaat > 2) {
            ödeme += 2;
            hesaplanansaat -= 1;
        }
        while (hesaplanansaat > 0) {
            ödeme += 6;
            hesaplanansaat -= 2;
        }
        ödeme = ödeme + hesaplanangün * 25;
        System.out.println("Yapacağınız ödeme: " + ödeme);
    }
}
*/
