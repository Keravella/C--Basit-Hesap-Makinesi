using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basit_hesap_makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayı1, sayı2;
            Console.WriteLine("Hoşgeldiniz.");
            Console.WriteLine("Lütfen 1 Sayıyı Giriniz..");
            sayı1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen 2. Sayıyı Giriniz.");
            sayı2 = Convert.ToDouble(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi belirtiniz.");
                Console.WriteLine("1-Toplama işlemi");
                Console.WriteLine("2-Çıkarma işlemi");
                Console.WriteLine("3-Bölme işlemi");
                Console.WriteLine("4-Çarpma işlemi");
                string secim = Console.ReadLine();
                switch (secim)
                {

                    case "1":
                        Console.WriteLine("Toplama işleminin sonucu = " + (sayı1 + sayı2));
                        break;
                    case "2":
                        Console.WriteLine("Çıkarma işleminin sonucu = " + (sayı1 - sayı2));
                        break;
                    case "3":
                        Console.WriteLine("Bölme işleminin sonucu = " + (sayı1 / sayı2));
                        break;
                    case "4":
                        Console.WriteLine("Çarpma işleminin sonucu = " + (sayı1 * sayı2));
                        break;

                }
                Console.ReadLine();
            }
        }
    }
}
