using System;
using System.Globalization;

namespace or211
{
    class Program
    {
        public static void Main(string[] args)
        {
            int c, EnBuyuk = 0, yer = 0, d = 0;
            String[] A = { "Emin", "Emir", "İclal", "Bekir", "Cem", "Arda", "Kaan", "Metin", "Can", "Ramiz" };
            int[] B = { 56, 78, 95, 23, 95, 87, 61, 77, 45, 33 };
            int[] Kontrol = new int[B.Length];
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
                    Kontrol[d] = yer;
                    d++;
                    B[yer] = 0;
                    yer = 0;
                    c = 0;

                }
            }
            for (c = 0; c <= d - 1; c++)
                Console.WriteLine("En Yüksek Notu Alan Kişi: " + A[Kontrol[c]]);


            Console.ReadKey(true);
        }
    }
}
