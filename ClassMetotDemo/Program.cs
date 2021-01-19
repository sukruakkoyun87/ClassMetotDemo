using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Yılmaz";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Yorulmaz";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Samet";
            musteri3.Soyad = "Baloncu";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "Talha";
            musteri4.Soyad = "Kaya";

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Ad = "Emel ";
            musteri5.Soyad = "Yıldız";


            Musteri musteri6 = new Musteri();
            musteri6.Id = 6;
            musteri6.Ad = "Sinem";
            musteri6.Soyad = "Korkmaz";



            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3, musteri4, musteri5,musteri6};


            MusteriManager musteriManager = new MusteriManager();


            musteriManager.Ekle(musteri1);

            musteriManager.Listele(musteriler);


            musteriManager.Sil(musteri5);





        }
    }
}
