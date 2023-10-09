using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Sınav_Sorusu_A
{
    internal class Program
    {
        // İlçeleri kullanıcı giricek
        // İsimleri kullanıcı giricek
        // İlçe ve isimleri karışık atıcak.
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç tane ilçe ve isim gireceksiniz ?"); // Consolda kaç ilçe girileceği soruluyor.
            int adet = Convert.ToInt16(Console.ReadLine()); // adet yerelini console girilen rakam olarak alınacak.
            string[] ilçe = new string[adet]; // İlçe Stringin boyu consolda girilen değer olarak sayılacak.
            string[] isim = new string[adet]; // İsim Stringin boyu consolda girilen değer olarak sayılacak.
            for (int i = 0; i < adet; i++) // her indixe bir döngüde belirliyoruz.
            {
                Console.WriteLine((i+1)+". İlçeyi Giriniz:"); // Consola i+1= 1. Sayiyi Giriniz Yazacak
                ilçe[i] = Console.ReadLine(); // 0. İndis numarasından girilen değeri kaydedecek.
            }
            for (int i = 0; i < adet; i++) // her indixe bir döngüde belirliyoruz.
            {
                Console.WriteLine((i + 1) + ". İsmi Giriniz:"); // Consola i+1= 1. Sayiyi Giriniz Yazacak
                isim[i] = Console.ReadLine(); // 0. İndis numarasından girilen değeri kaydedecek.
            }
            /* Buraya kadar İlçe ve İsim değerlerini kabul edip bulduk.
            
                         string[] il = { "Muş", "Ağrı", "Bolu", "Mersin", "Ankara", "Sivas", "Kayseri" };
                         string[] isim = { "Asuman", "İclal", "Emin", "Bekir", "Ahmet", "Can", "Esma" };

            Örneğin yukarıda onceden girilen değerleri en başta for dongusu sayesinde kullanıcdan bu verilerin boyutunu ve içeriğini girmesini istedik.*/

            int ilçekontrol, isimkontrol; // İlçe ve isimlerin indixlerini tutmak için belirliyoruz
            Random kontrol = new Random (); // Random sayı yerelini acıyoruz
            bool[] ilçedoğrulama = new bool[adet]; // Bool kalıbını acıyoruz True False özelliğinden yararlancaz.
            bool[] isimdoğrulama = new bool[adet]; // Neden cünkü isim kontrol 5 ise ve burada isimkontrol false ise 5. indixi alırız. Ama true ise almayiz bunu aşadaki kotta sağlicaz.
            for (int i = 0; i < adet; i++) //burada bir döngü gerçekleştiricez.
            {
                do
                {
                    ilçekontrol = kontrol.Next(0, adet); // İlçe kontrole bir sayi atiyoruz.
                } while (ilçedoğrulama[ilçekontrol] == true); // Burda boşmu dolu mu diye kontrol ediyoruz. ve True değilse aşa gidiyor true ise yukarı cıkıyor kod
                ilçedoğrulama[ilçekontrol] = true; // kod buraya geldiğinde burasi boş olduğunu gösteriyor ve biz artık dolu olduğunu ifade ediyoruz.
                do // Buraya kadar Boş bir ilçeyi elimize aldık. Sıra boş bir İsimde
                {
                    isimkontrol = kontrol.Next(0, adet); // isim kontrole bir sayi seçiyoruz 2 diyelim.
                } while (isimdoğrulama[isimkontrol] == true); // Burada 2 sayisinin true mi falsemi bakıyoruz. True ise do birkez daha tekrarlanır false ise aşa gidilir.
                isimdoğrulama[isimkontrol] = true; // burada artık true olduğunu dolu olduğunu söylüyoruz. 
                // Artık elimizde 1 boş ilçe ve 1 boş şehir var ve aşağida bunu belirtiyoruz.
                Console.WriteLine(isim[isimkontrol] + " " + ilçe[ilçekontrol]); //Konsola boş ilçe ve isim yazilir.
            }
        }
    }
}
