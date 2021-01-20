using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //id Category IbanNo TCKimlikNo KrediNotu MusteriAdi MusteriSoyadi MusteriTelefon  MusteriAdres
            Musteri musteri1 = new Musteri();
            
            musteri1.Id = 9000101;
            musteri1.Category = 1;
            musteri1.IbanNo = "TR-900923423434";
            musteri1.TCKimlikNo = 656734342;
            musteri1.KrediNotu = 700;
            musteri1.MusteriAdi = "Eda Nur";
            musteri1.MusteriSoyadi = "YORULMAZ";
            musteri1.MusteriTelefon = 334232323;
            musteri1.MusteriAdres = "Degol Cad. 12/5-Ankara";
            musteri1.MusteriBakiye = 356.50;

            Musteri musteri2 = new Musteri();

            musteri2.Id = 9000102;
            musteri2.Category = 2;
            musteri2.IbanNo = "TR-900923423436";
            musteri2.TCKimlikNo = 656734342;
            musteri2.KrediNotu = 1000;
            musteri2.MusteriAdi = "Erol";
            musteri2.MusteriSoyadi = "GUNES";
            musteri2.MusteriTelefon = 334232325;
            musteri2.MusteriAdres = "İran Cad. 12/3-Ankara";
            musteri2.MusteriBakiye = 956.342;

            Musteri musteri3 = new Musteri();

            musteri3.Id = 9000103;
            musteri3.Category = 3;
            musteri3.IbanNo = "TR-900923423435";
            musteri3.TCKimlikNo = 656734342;
            musteri3.KrediNotu = 30;
            musteri3.MusteriAdi = "Cemal";
            musteri3.MusteriSoyadi = "KAFADAR";
            musteri3.MusteriTelefon = 334232324;
            musteri3.MusteriAdres = "Akdeniz Cad. 12/9-Ankara";
            musteri3.MusteriBakiye = 750;

            //array-dizi
            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };
            //foreach döngüsü
            foreach (Musteri musteri in musteriler)
            {
                //"Id :" + ekle eklenen verinin etiketi de belli olsun...
                //etiket + veri
                
                Console.WriteLine("Id :" + musteri.Id );
                Console.WriteLine("Iban No :" + musteri.IbanNo);
                Console.WriteLine("TC Kimlik No :" + musteri.TCKimlikNo);
                Console.WriteLine("Kredi Notu :" + musteri.KrediNotu);
                //aynı satırda ad soyad yazmak için
                Console.WriteLine("Müşteri Adı Soyadı :" + musteri.MusteriAdi  + "" +musteri.MusteriSoyadi);
                Console.WriteLine("Telefon :" + musteri.MusteriTelefon);
                Console.WriteLine("Adres :" + musteri.MusteriAdres);
            }
           
            MusteriManager musteriManager = new MusteriManager();

            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3 };

            Console.WriteLine("****TÜM MÜŞTERİ LİSTESİ HAZIRLANIYOR...");
            musteriManager.GetAll(musteris);
            Console.WriteLine("***Listesi Sonu************************");

            Console.WriteLine("****ADDING...");
            musteriManager.Add(musteri1);

            Console.WriteLine("****DELETEING...");
            musteriManager.Delete(musteri2);

            //Console.ReadLine();


        }



    }
}
