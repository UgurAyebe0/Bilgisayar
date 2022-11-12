using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/*
 

Otomobil için 2 saat: 5tl sonraki her saat 1 tl, 10 saatten sonrası günlük sabit ücret…
Kamyon için 2 saat 8 tl, sonraki her saat 2 tl, 8 saatten sonra günlük sabit ücret
İş makinası 2 saat 12 tl sonraki her saat 3 tl, 8 saatten sonra günlük sabit


*/
namespace Otopark_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int araba, saat , ödeme , a , b , c ;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Otopark üçretini hesaplayabilmek için araba türünüzü seçin:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Otomobil(1)\nKamyon (2)\nİş Makinesi (3)");
            Console.ForegroundColor = ConsoleColor.Green;
            araba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kaç saat park edildiğini yazın");
            saat = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            if (saat <= 0)
            Console.WriteLine("Buraya hiç park edememiş olamazsın Dostum ?");
            else
            {
                if (araba == 1)
                {
                    if (saat <= 2)
                    {
                        ödeme = saat * 5;
                        Console.WriteLine("Yapacağiniz Ödeme= " + ödeme + "Tl");
                        saat=0;
                    }
                    if (saat >= 2 && saat <= 10)
                    {
                        saat = saat - 2;
                        ödeme = (2 * 5) + saat;
                        Console.WriteLine("Yapacağiniz Ödeme= " + ödeme + "Tl");
                        saat = 0;
                    }
                    if (saat >= 11 && saat <= 24)
                    {
                        Console.WriteLine("Yapacağiniz Ödeme 18 Tl");
                        saat = 0;
                    }
                    if (saat > 24)
                    { 
                         a = saat / 24; //gün    2 gün    29
                         b = saat % 24; //saat   5 saat
                        {
                            if (b <= 2)
                            {
                                ödeme = (a * 18) + (b*5);
                                Console.WriteLine("Yapacağiniz Ödeme " + ödeme + "Tl");
                                b = 0;
                            }
                            if (b >= 2 && b <= 10)
                            {
                                b = b - 2;
                                ödeme = (a * 18) + (2 * 5) + b;
                                Console.WriteLine("Yapacağiniz Ödeme " + ödeme + "Tl");
                                b = 0;
                            }
                            if (b >= 11 && b <= 24)
                            {
                                ödeme = (a * 18) + 18;
                                Console.WriteLine("Yapacağiniz Ödeme " + ödeme + "Tl");
                                b = 0;
                            }
                        }
                    }
                }
                if (araba == 2)
                {
                    if (saat <= 2)
                    {
                        ödeme = saat * 8;
                        Console.WriteLine("Yapacağiniz Ödeme= " + ödeme + "Tl");
                        saat = 0;
                    }
                    if (saat >= 2 && saat <= 10)
                    {
                        saat = saat - 2;
                        ödeme = (2 * 8) + (saat*2);
                        Console.WriteLine("Yapacağiniz Ödeme= " + ödeme + "Tl");
                        saat = 0;
                    }
                    if (saat >= 11 && saat <= 24)
                    {
                        Console.WriteLine("Yapacağiniz Ödeme 28 Tl");
                        saat = 0;
                    }
                    if (saat > 24)
                    {
                        a = saat / 24; //gün    2 gün    29
                        b = saat % 24; //saat   5 saat
                        {
                            if (b <= 2)
                            {
                                ödeme = (a * 28) + (b * 8);
                                Console.WriteLine("Yapacağiniz Ödeme " + ödeme + "Tl");
                                b = 0;
                            }
                            if (b >= 2 && b <= 10)
                            {
                                b = b - 2;
                                ödeme = (a * 28) + (2 * 8) + (b*2);
                                Console.WriteLine("Yapacağiniz Ödeme " + ödeme + "Tl");
                                b = 0;
                            }
                            if (b >= 11 && b <= 24)
                            {
                                ödeme = (a * 28) + 28;
                                Console.WriteLine("Yapacağiniz Ödeme " + ödeme + "Tl");
                                b = 0;
                            }
                        }
                    }
                }
                if (araba == 3)
                {
                    if (saat <= 2)
                    {
                        ödeme = saat * 12;
                        Console.WriteLine("Yapacağiniz Ödeme= " + ödeme + "Tl");
                        saat = 0;
                    }
                    if (saat >= 2 && saat <= 10)
                    {
                        saat = saat - 2;
                        ödeme = (2 * 12) + (saat * 3);
                        Console.WriteLine("Yapacağiniz Ödeme= " + ödeme + "Tl");
                        saat = 0;
                    }
                    if (saat >= 11 && saat <= 24)
                    {
                        Console.WriteLine("Yapacağiniz Ödeme 42 Tl");
                        saat = 0;
                    }
                    if (saat > 24)
                    {
                        a = saat / 24; //gün    2 gün    29
                        b = saat % 24; //saat   5 saat
                        {
                            if (b <= 2)
                            {
                                ödeme = (a * 42) + (b * 12);
                                Console.WriteLine("Yapacağiniz Ödeme " + ödeme + "Tl");
                                b = 0;
                            }
                            if (b >= 2 && b <= 10)
                            {
                                b = b - 2;
                                ödeme = (a * 42) + (2 * 12) + (b * 3);
                                Console.WriteLine("Yapacağiniz Ödeme " + ödeme + "Tl");
                                b = 0;
                            }
                            if (b >= 11 && b <= 24)
                            {
                                ödeme = (a * 42) + 42;
                                Console.WriteLine("Yapacağiniz Ödeme " + ödeme + "Tl");
                                b = 0;
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
