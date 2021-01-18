using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.ad = "Katy";
            musteri1.soyad = "Perry";
            musteri1.adres = "USA";

            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.ad = "Dua";
            musteri2.soyad = "Lipa";
            musteri2.adres = "UK";

            Musteri musteri3 = new Musteri();
            musteri3.id = 3;
            musteri3.ad = "Steve ";
            musteri3.soyad = "Carell";
            musteri3.adres = "USA";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();


            Console.WriteLine("\n-------------Müsteriler--------------\n");


            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Musteriler : " + musteri.ad + " " + musteri.soyad);
                Console.WriteLine("Musteri Numarası"+ musteri.id+ "\n");
            }




        }
    }
}
