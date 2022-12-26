using System;
using System.Globalization;

namespace or211
{
    class Program
    {
        public static void Main(string[] args)
        {
            int c, EnBuyuk = 0, yer = 0;
            String[] A = { "Emin", "Emir", "İclal", "Bekir", "Cem", "Arda", "Kaan", "Metin", "Can", "Ramiz" };
            int[] B = { 56, 78, 95, 23, 95, 87, 61, 77, 45, 33 };
            Console.WriteLine("En Yüksek Notu Alan Kişi:");
            for (c = 0; c <= B.Length - 1; c++)
            {
                for (c = 0; c <= B.Length - 1; c++)
                {
                    if (B[c] >= EnBuyuk)
                    {
                        EnBuyuk = B[c];
                        yer = c;
                    }
                }
                if (yer != 0)
                {
                    Console.WriteLine(A[(yer)]);
                    B[yer] = 0;
                    yer = 0;
                    c = 0;
                }
            }
            Console.ReadKey(true);
        }
    }
}