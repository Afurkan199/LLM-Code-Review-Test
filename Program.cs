using System;

namespace CodeReviewTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapay Zeka Testi Başlıyor...");
            
            int[] sayilar = { 10, 20, 30 };
            
            // Bilerek yapılan hata: Dizide sadece 3 eleman var (indeks 0, 1, 2)
            // Ama biz 5. indeksi çağırmaya çalışıyoruz.
            int hataliSayi = sayilar[5]; 
            
            Console.WriteLine("Sayi: " + hataliSayi);
            //test
            // test
            //test2
            
        }
    }
}
