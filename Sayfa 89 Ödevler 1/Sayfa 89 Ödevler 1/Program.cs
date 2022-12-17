using System;
namespace or214
{
    class Program
    {
        public static void Main(string[] args)
        {
            byte a;
            string s = " ";
            string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            Console.Write("Bir Sayı Giriniz: ");//72 – 80 – 6 
            a = Byte.Parse(Console.ReadLine());
            if (a > 0 && a<100)
            {
                if (a / 10 >= 1)
                { //Sayı iki veya daha fazla basamaklı mı?
                    s = Onlar[(a / 10) - 1];
                }//s= yetmiş – seksen -
                if (a % 10 != 0)
                { //Sayının son basamağı sıfır değilse yaz
                    s = s + Birler[(a % 10) - 1];
                }//s= yetmiş+iki – “ altı”
                Console.WriteLine(s);//yetmişiki – seksen – “ altı”
            }
            else
            {
                Console.Write("Sayi 1 ile 99 arasında pozitif bir sayi değildir.");
            }    
            Console.ReadKey(true);
        }
    }
}

// ÖDEV: Programda önce girilen sayının en çok iki basamaklı ve 1 – 99 arasında pozitif sayı olduğunu kontrol ettiriniz. 
// Eğer girilen sayı gerekli şartı sağlamıyor ise programın “Uygun değer girmediniz” mesajı ile sonlanmasını sağlayınız.