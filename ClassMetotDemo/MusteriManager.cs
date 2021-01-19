using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {

            Console.WriteLine("Eklenen Musteri Bilgileri [ Id : {0}   Adı : {1}  Soyadı : {2} ]",musteri.Id,musteri.Ad,musteri.Soyad);

            Console.WriteLine("===========================================\n");
        }



        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri Listesi   \n");

            foreach (Musteri musteri in musteriler)
            {

                
                Console.WriteLine("[ Id : {0}   Adı : {1}  Soyadı : {2} ]", musteri.Id, musteri.Ad, musteri.Soyad);

            }

            Console.WriteLine("===========================================\n");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşteri Bilgileri   \n");
            Console.WriteLine("[ Id : {0}   Adı : {1}  Soyadı : {2} ]", musteri.Id, musteri.Ad, musteri.Soyad);
        }
    }
}
