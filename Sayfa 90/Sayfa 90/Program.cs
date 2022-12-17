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
            for (a = 0; a <= 6; a++) 
                Console.WriteLine("Bool D dizisinin " + a + ". elemanı= " + D[a]);
                Random rastgele = new Random();
            for (a = 0; a <= 6; a++)
            {
                {
                    do
                    { //bu döngü ve d[sayi]=true satırı ile bir şehire birden fazla öğretmen atanması engelleniyor.
                        ilr = rastgele.Next(0, 7);//sıfır dahil, 7 dahil değil.
                    } while (D[ilr] == true);
                    D[ilr] = true;
                }
                {
                    do
                    { //bu döngü ve d[sayi]=true satırı ile bir şehire birden fazla öğretmen atanması engelleniyor.
                        isimr = rastgele.Next(0, 7);//sıfır dahil, 7 dahil değil.
                    } while (C[isimr] == true);
                    C[isimr] = true;
                }
                Console.WriteLine(isim[isimr] + "\t= " + il[ilr]);
            }
            for (a = 0; a <= 6; a++)
            {
                Console.WriteLine("Bool D dizisinin " + a + ". elemanı= " + D[a]);
            }
                Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
