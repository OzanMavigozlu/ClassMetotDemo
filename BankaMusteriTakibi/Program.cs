using System;

namespace BankaMusteriTakibi
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteriler musteri1 = new Musteriler();
            musteri1.Id = 1;
            musteri1.Adi = "Ozan";
            musteri1.Soyad= "Mavigözlü";
            musteri1.KimlikNo = 415546874848951;
            musteri1.TelNo=05336548973;
            musteri1.Adres = "Uzay Yolu , Dolanbaçlı Sok. No:45 D/89";

            Musteriler musteri2 = new Musteriler();
            musteri2.Id = 2;
            musteri2.Adi = "Arda";
            musteri2.Soyad = "Karaosmanoğlu";
            musteri2.KimlikNo = 5415274848951;
            musteri2.TelNo = 05332548413;
            musteri2.Adres = "Saman Yolu , Kızkaçıran Sok. No:02 D/3";

            MusteriManager musteriler = new MusteriManager();
            musteriler.MusteriEkleme(musteri1);
            musteriler.MusteriEkleme(musteri2);


            Console.WriteLine("--------------------------Müşteri Listesi--------------------------");

            musteriler.Listele(musteri1);
            musteriler.Listele(musteri2);


            musteriler.Sil(musteri1); 
            musteriler.Sil(musteri2);


        }
    }
}
