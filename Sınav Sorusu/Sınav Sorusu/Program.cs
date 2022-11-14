using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, e;
        Baş:
            {
                Console.WriteLine("Kaç saat girdiğinizi yazın");
                a = Convert.ToInt32(Console.ReadLine());
            }
            if (a <= 0)
            {
                goto Baş;
            }
            else
            {
                if (a == 1)
                {
                    Console.WriteLine("6 Tl ödeme sağlamanız lazım.");
                }
                else if (a >= 2 && a <= 8)
                {
                    a = a - 1;
                    b = 6 + (a * 2);
                    Console.WriteLine("Toplam" + b + "Tl");
                }
                else if (a >= 9 && a <= 24)
                {
                    Console.WriteLine("Toplam 25 Tl");
                }
                else
                {
                    c = a / 24;
                    a = a % 24;
                    {
                        if (a == 1)
                        {
                            e = c * 25 + 6;
                            Console.WriteLine("Toplam" + e + "Tl");
                        }
                        else if (a >= 2 && a <= 8)
                        {
                            a = a - 1;
                            e = c * 25 + 6 + (a * 2);
                            Console.WriteLine("Toplam" + e + "Tl");
                        }
                        else if (a >= 9 && a <= 24)
                        {
                            e = (c * 25) + 25;
                            Console.WriteLine("Toplam" + e + "Tl");
                        }
                    }
                }

            }
            goto Baş; //bug varmı diye hızlı bakmak istedim =)
        }
    }
}

