using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi." + musteri.id + "  " + musteri.ad + "  " + musteri.soyad);
        }

        public void delete(Musteri musteri)
        {
            Console.WriteLine("Kişiler Silindi." + musteri.id + "  " + musteri.ad + "  " + musteri.soyad);
        }

        public void list(Musteri musteri)
        {
            Console.WriteLine("Kişiler Listelendi." + musteri.id + "  " + musteri.ad + "  " + musteri.soyad);
        }



    }
}
