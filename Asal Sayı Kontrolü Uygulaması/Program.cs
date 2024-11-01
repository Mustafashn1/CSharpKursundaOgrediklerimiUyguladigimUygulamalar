using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asal_Sayı_Kontrolü_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bir Sayi Giriniz...");
                if (int.TryParse(Console.ReadLine(), out int sayi))
                {
                    if (AsalMi(sayi))
                        Console.WriteLine($"{sayi} asal bir sayıdır.");
                    else
                        Console.WriteLine($"{sayi} asal değildir.");
                }
                else
                {
                    Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen tekrar deneyin.");
                }

            }
        }




        static bool AsalMi(int sayi)
        {
            if (sayi <= 1)
            {
                return false;
            }

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            return true;
            
        }
    }
}
