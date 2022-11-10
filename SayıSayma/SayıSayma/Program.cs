using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
             hangi iki sayi arasindaki sayilari kullanicidan
                isteyin algoritma genel olucak hangi iki tam sayi arasinda sayilae goruntulenecek
                ve artan sira mi azalan siralama mi, sirali sayilar mi tekler mi ciftler mi
*/
namespace SayıSayma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, işlem1, art=1, devamlılık=1;
            Console.WriteLine("1. Sayiyi Giriniz.");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayiyi Giriniz.");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bu sayıların arasındaki sayıları;\n---> Sırayla küçükten büyüğe doğru 0,\n---> Sırayla büyükten küçüğe doğru için 1 girin.");
            işlem1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayılar kaçar kaçar artış göstermeli ?");
            art = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sonuçlar aşağiya yazılmıştır.");
            if (işlem1 == 0)
            {
                if (sayi1 < sayi2) // 1 - 11
                    for (; sayi1 <= sayi2; sayi1+=art)
                    {
                        if (sayi1 >= sayi2) break;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sayi1);
                    }
                else 
                    for (; sayi2 <= sayi1; sayi2+=art)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sayi2);
                        if (sayi2 >= sayi1) break;
                    }
            }
            if (işlem1 == 1)                                   
            {
                if (sayi1 > sayi2)
                    for (; sayi1 >= sayi2; sayi1-=art)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(sayi1);
                        if (sayi1 == sayi2) break;
                    }
                else 
                    for (; sayi2 >= sayi1; sayi2-=art)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(sayi2);
                        if (sayi1 >= sayi2) break;
                    }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cıkmak için bir tuşa basın.");
            Console.ReadKey();

        }
    }
}
