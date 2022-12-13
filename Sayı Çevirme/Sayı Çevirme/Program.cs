using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2li_sistemi_10lu_yapma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Yapaçağınız işlemi seçin:\n2'lik sistemden 10'luk sisteme dönüştürmek için (0)\n10'luk sistemi 2'lik sisteme dönüştürmek için (1)");
            int seçim;
            seçim = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 0, c = 1, d = 0;
            string onluk = " ";
            if (seçim == 0)
            {
                Console.WriteLine("2'lik bir sayı girin");
                a = Convert.ToInt32(Console.ReadLine());
                while (a > 0)
                {
                    if (a == 1)
                    {
                        d += 1;
                        a /= 10;
                    }
                    if (a % 10 == 1)
                    {
                        a /= 10;
                        b++;
                        while (b > 0)
                        {
                            b--;
                            c = c * 2;
                            if (b == 0)
                            {
                                d += c;
                            }
                        }
                    }
                    if (a % 10 == 0)
                    {
                        a /= 10;
                        b++;
                    }
                }
                Console.WriteLine(d);
                Console.ReadKey();
            }
            if (seçim == 1)
            {
                Console.WriteLine("10'luk bir sayı girin");
                a = Convert.ToInt32(Console.ReadLine());
                while (a > 0)
                {  // Alta gördüğünüz 3 satirlik kodu dinime imanıma 2 saate kodladım. Binbir farklı yol denedim inan bana olmadi 
                    b = a % 2;  //Kağitta yaptiğim 4 farklı yolu koda geçirmeye çaliştim ama başarisizlik..
                    a = a / 2;  //Şuan 3 saatlik emeklerime üzülüyorum.....
                    onluk = b + onluk; // Hayırlısı Yıkılmadık...
                }
                Console.WriteLine(onluk);
                Console.ReadKey();
            }
        }
    }
}
