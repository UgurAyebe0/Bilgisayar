using System;
namespace or094
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a,b;
            Console.Write("Bir Sayı Giriniz");
            b = Convert.ToInt32(Console.ReadLine());
            String s = "b Sayısı Asal Sayı";
            if (b == 1)
            {
                Console.WriteLine("ASAL DEĞİL!");
                goto bitir; }
            for (a = 2; a <= b / 2; a++)
            {
                if (b % a == 0)
                {
                    s = "b Sayısı Asal Sayı Değil!";
                    break;
                }
            }
            Console.WriteLine(s);
        bitir: Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);
        }
    }
}
