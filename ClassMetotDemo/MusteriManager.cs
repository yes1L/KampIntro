using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi");
            Console.WriteLine(" Musteri adi : " + musteri.Adi+", "+ " Musteri Soyadi : " + musteri.Soyadi);
            Console.WriteLine("----------------");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi");
            Console.WriteLine(" Musteri adi : " + musteri.Adi + ", " + " Musteri Soyadi : " + musteri.Soyadi);
            Console.WriteLine("----------------");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi");
            Console.WriteLine(" Musteri adi : " + musteri.Adi + ", " + " Musteri Soyadi : " + musteri.Soyadi);
            Console.WriteLine("----------------");
        }
    }
}
