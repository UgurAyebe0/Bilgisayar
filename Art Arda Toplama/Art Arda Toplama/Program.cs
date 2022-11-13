using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Arda_Toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int sayi1, sayi2;
                Console.WriteLine("Ana Sayiyi Giriniz:");
                sayi1 = Convert.ToInt32(Console.ReadLine());
            Tekrar:
                Console.WriteLine("Toplanacak sayıyı girin:");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                sayi1 = sayi1 + sayi2;
                Console.WriteLine("Sayımız" + sayi1);
                if (sayi1 == 83)
                    Console.WriteLine("Döngü Bitti.");
                else
                    goto Tekrar;
            }
            Console.ReadKey();
        }
    }
}
