using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    internal class Program
    {
        //KDV hesaplama programı
        //Kullanıcıdan alınan ürün fiyatı ve KDV oranına göre KDV'li fiyatı hesaplayan program
        //Fiyata KDV oranı dahilse KDV'siz fiyatı hesaplayan program
        //Fiyata KDV dahil değilse KDV'li fiyatı hesaplayan program
        //Kullanıcı KDV dahil veya hariç olduğunu seçecektir
        //3 tane KDV oranı olacak. Bunlar %1, %10 ve %20
        //KDV oranı seçimi yapılacak
        //Methot kullanılacak

        static decimal FiyatHesapla(decimal fiyat, decimal kdvOrani)
        {
            Console.WriteLine("Fiyata KDV dahil mi? (E/H):");
            string kdvDahilMi = Console.ReadLine().ToUpper();

            if (kdvDahilMi == "E")
            {
                decimal kdvSizFiyat = fiyat / (1 + kdvOrani);
                return kdvSizFiyat;
            }
            else
            {
                decimal kdvliFiyat = fiyat * (1 + kdvOrani);
                return kdvliFiyat;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Ürün fiyatını giriniz:");
            decimal fiyat = Convert.ToDecimal(Console.ReadLine());

            Console.Write("KDV oranını seçiniz (%1, %10, %20):");
            decimal kdvOrani = Convert.ToDecimal(Console.ReadLine()) / 100;

            decimal sonuc = FiyatHesapla(fiyat, kdvOrani);

            Console.WriteLine("Hesaplanan fiyat: {0}", sonuc);

            Console.ReadLine();
        }
    }
}
