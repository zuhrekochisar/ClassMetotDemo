using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriName + " " +musteri.MusteriLastName);          
            Console.WriteLine("Müşteri Ekleme Başarılı");
            Console.WriteLine("****************************************************");
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri Başarıyla Güncellendi: " +musteri.MusteriName + " " + musteri.MusteriLastName);
            Console.WriteLine("****************************************************");
        }

        public void Listed(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id:" + musteri.MusteriId);
                Console.WriteLine("Müşteri Adı:" + musteri.MusteriName);
                Console.WriteLine("Müşteri Soyadı:" + musteri.MusteriLastName);
                Console.WriteLine("Müşteri Şehir:" + musteri.MusteriCity);
                Console.WriteLine("Müşteri Telefon Numarası:" + musteri.MusteriPhoneNumber);
                Console.WriteLine("****************************************************");

            }
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Silme İşlemi Tamamlandı", musteri.MusteriName, musteri.MusteriLastName);
            Console.WriteLine("****************************************************");
        }
    }
}
