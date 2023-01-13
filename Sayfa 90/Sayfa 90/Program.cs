using System;
namespace or218
{
    class Program
    {
        public static void Main(string[] args)
        {
            int ilr, a , isimr;
            string[] il = { "Muş", "Ağrı", "Bolu", "Mersin", "Ankara", "Sivas", "Kayseri" };
            string[] isim = { "Asuman", "İclal", "Emin", "Bekir", "Ahmet", "Can", "Esma" };
            bool[] D = new bool[7];
            bool[] C = new bool[7];
            Random rastgele = new Random();  
            for (a = 0; a <= 6; a++)
            {
                    do
                    {
                        ilr = rastgele.Next(0, 7);
                    } while (D[ilr] == true);
                    D[ilr] = true;
                    do
                    { 
                        isimr = rastgele.Next(0, 7);
                    } while (C[isimr] == true);
                    C[isimr] = true;
                    Console.WriteLine(isim[isimr] + "\t= " + il[ilr]);
            }
            Console.ReadKey(true);
        }
    }
}
