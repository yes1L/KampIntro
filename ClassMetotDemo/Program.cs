using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Kazım Talha";
            musteri1.Soyadi = "YEŞİL";
            musteri1.Bakiye = 2000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Mustafa";
            musteri2.Soyadi = "YEŞİL";
            musteri2.Bakiye = 100;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Göksel";
            musteri3.Soyadi = "YEŞİL";
            musteri3.Bakiye = 4500;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Sanime";
            musteri4.Soyadi = "YEŞİL";
            musteri4.Bakiye = 1000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteri3);
            musteriManager.Sil(musteri4);

        }
    }
}
