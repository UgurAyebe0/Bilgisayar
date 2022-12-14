using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayfa_84_Ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b,c=0,d;
            Console.WriteLine("Kaç Adet Sayi Giriceksiniz");
            b = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[b];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(i+1 + ". Sayiyi Girin");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(i + ". İndex'teki :" + a[i]);
            }
            // 5 elemanlı bir X dizisi içinde son rakamı sıfır olan kaç tane sayı olduğunu hesaplar
            int eleman = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] % 10) == 0)
                {
                    c += a[i];
                    eleman++;
                }
            }
            d = c / eleman;
            Console.WriteLine("\n" + a.Length + " Adet Kadar Dizinizde Eleman Var.");
            Console.WriteLine(eleman + " Adet Kadar Elemanın son basamaği 0'dır");
            Console.WriteLine("Son Basamaği Sıfır olanların toplamı: " + c);
            Console.WriteLine("Son Basamaği Sıfır olanların ortalamasi: " + d);
            Console.ReadLine();
            // ÖDEV: Yukarıdaki örneği son rakamı sıfır olan değerlerin toplamı ve ortalamasını da verecek şekilde yeniden yaz.

        }
    }
}
