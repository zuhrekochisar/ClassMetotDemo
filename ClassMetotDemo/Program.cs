using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriName = "Zühre";
            musteri1.MusteriLastName = "Koçhisar";
            musteri1.MusteriCity = "İzmir";
            musteri1.MusteriPhoneNumber = "05112223344";
            

            musteriManager.Add(musteri1);
            musteriManager.Update(musteri1);

            

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriName = "Burcu";
            musteri2.MusteriLastName = "Başaran";
            musteri2.MusteriCity = "Bursa";
            musteri2.MusteriPhoneNumber = "05221115577";

            musteriManager.Add(musteri2);


            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriName = "Öznur";
            musteri3.MusteriLastName = "Aksoy";
            musteri3.MusteriCity = "İstanbul";
            musteri3.MusteriPhoneNumber = "05661115577";

            musteriManager.Add(musteri3);


            Musteri musteri4 = new Musteri();
            musteri4.MusteriId = 3;
            musteri4.MusteriName = "Mihriban";
            musteri4.MusteriLastName = "Dilsiz";
            musteri4.MusteriCity = "Çanakkale";
            musteri4.MusteriPhoneNumber = "05991115577";

            musteriManager.Add(musteri4);


            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri4 };
            musteriManager.Listed(musteriler);
            Console.WriteLine("Listeleme İşlemi Tamamlandı");


        }
    }
}
