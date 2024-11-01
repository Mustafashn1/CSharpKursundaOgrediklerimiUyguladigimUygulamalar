using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Kursunda_Öğrediklerimi_Uyguladığım_Uygulamalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayibulmaUygulaması();

        }

        static void SayibulmaUygulaması()
        {
            Random random = new Random();
            int hedefSayisi = random.Next(1, 101);
            int tahmin;
            int tahminSayisi = 0;

            Console.WriteLine("1 ila 100 arasında bir sayı giriniz.");

            do
            {
                Console.WriteLine("Tahmininiz :");
                tahmin = int.Parse(Console.ReadLine());
                tahminSayisi++;

                if (tahmin < hedefSayisi)
                    Console.WriteLine("Daha büyük bir sayı giriniz");
                else if (tahmin > hedefSayisi)
                    Console.WriteLine("Daha küçük bir sayı giriniz");
                else
                    Console.WriteLine($"*******************  Tebrikler {tahminSayisi} denemede bildiniz  ******************* ");

            } while (tahmin != hedefSayisi);

            Console.WriteLine($"*******************  Tebrikler Doğru Sayi {tahmin}        *******************");
            Console.ReadLine();
        }


    }
}
