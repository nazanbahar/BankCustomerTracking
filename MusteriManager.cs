using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //id Category IbanNo TCKimlikNo KrediNotu MusteriAdi MusteriSoyadi MusteriTelefon  MusteriAdres
        //Musteri array inde > (musteriler Musteri[] musteriler)
        public void GetAll(Musteri[] musteriler) {

            foreach (Musteri musteri in musteriler)
            {
                //Musteri Classındaki musterileri musteri allias takma isimle listeledik.
                Console.WriteLine(musteri.Id+ musteri.Category + musteri.IbanNo + musteri.TCKimlikNo + musteri.KrediNotu +
                                  musteri.MusteriAdi + musteri.MusteriSoyadi + musteri.MusteriTelefon + musteri.MusteriAdres);
            }
        
        }

        public void Add(Musteri musteriler) {
            //Musteri Classına musterileri musteri özelliklerindeki bilgileri ekledik.
            Console.WriteLine("Sisteme Başarıyla Eklendi..." +
                               musteriler.Id + musteriler.Category + musteriler.IbanNo + musteriler.TCKimlikNo + musteriler.KrediNotu +
                               musteriler.MusteriAdi + musteriler.MusteriSoyadi + musteriler.MusteriTelefon + musteriler.MusteriAdres);
        }


        public void Delete(Musteri musteri) {
            // Musteri Classındaki musteri bilgilerini silmek.
             Console.WriteLine("Sistemden Silindi..." +
                               musteri.Id + musteri.Category + musteri.IbanNo + musteri.TCKimlikNo + musteri.KrediNotu +
                               musteri.MusteriAdi + musteri.MusteriSoyadi + musteri.MusteriTelefon + musteri.MusteriAdres);
        }

        public void Update(Musteri musteri) {

            Console.WriteLine("" + musteri.IbanNo + musteri.MusteriAdi + musteri.MusteriSoyadi);
        
        }

    }
}
