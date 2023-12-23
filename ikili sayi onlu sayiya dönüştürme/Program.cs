using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikili_sayi_onlu_sayiya_dönüştürme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Örnek: İkili sayı sistemindeki bir değeri onlu sayı sistemine dönüştüren program.
start:
            Console.WriteLine("Lütfen ikili sayı sisteminden bir sayı giriniz: ");
            uint sayi = Convert.ToUInt32(Console.ReadLine());

            uint ikiliDeger, onluDeger = 0, tabanDeger = 1, basamakDeger;
            ikiliDeger = sayi;
            while (sayi > 0)
            {
                basamakDeger = sayi % 10;
                onluDeger = onluDeger + basamakDeger * tabanDeger;
                sayi = sayi / 10;
                tabanDeger = tabanDeger * 2;
            }


            Console.Write("İkili (Binary) Sayı: " + ikiliDeger);
            Console.WriteLine("\nOnlu (Decimal) Sayı: " + onluDeger);

            Console.WriteLine("tekrar işlem yapmak istiyor musunz? evet ise e ye hayır ise enter'a basınız: ");
            string devam = Convert.ToString(Console.ReadLine());
            if (devam.ToLower() == "e") 
            {
                goto start;
            }
            
            
            //Ödev: Yukarıdaki örneği ikili sayı sistemindeki değer klavyeden girilecek şekilde yeniden düzenleyiniz(DÜZENLENDİ)


        }
    }
}
