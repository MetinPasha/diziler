﻿namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim 
            renkler[0] = "Mavi";
            dizi[3] = 10;


            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);


            // Döngüler ve dizi kullanımı
            // Klavyeden girilen n tane sayının ortalamasını alan bir örnek

            Console.Write("Lütfen eleman sayisini giriniz :");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++) 
            {
                Console.Write("Lütfen {0}. sayiyi giriniz", i + 1);
                sayidizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayidizisi)
                toplam += sayi;

            Console.WriteLine("Ortalama :" + toplam / diziUzunlugu);
    }
}
