using System;
using System.Collections.Generic;
using System.Text;

namespace BankaMusteriTakibi
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteriler musteriler)
        {
            Console.WriteLine("Yeni Müsteri Eklendi : " + musteriler.Adi);

        }

        public void Sil(Musteriler musteriler)
        {
            Console.WriteLine("Müşteri Silindi : " + musteriler.Adi);

        }


        public void Listele(Musteriler musteriler)
        {

            Console.WriteLine("Id : " + musteriler.Id);
            Console.WriteLine("Adi : " + musteriler.Adi);
            Console.WriteLine("Soyad : " + musteriler.Soyad);
            Console.WriteLine("KimlikNo : " + musteriler.KimlikNo);
            Console.WriteLine("TelNo : " + musteriler.TelNo);
            Console.WriteLine("Adres : " + musteriler.Adres);
            Console.WriteLine("---------------------------------------------------");
        }




    }
}




//Musteriler[] Musteri = new Musteriler[] { musteri1, musteri2 };

//foreach (Musteriler Musteriler in Musteri)
//{
//    Console.WriteLine("Id : " + Musteriler.Id);
//    Console.WriteLine("Adi : " + Musteriler.Adi);
//    Console.WriteLine("Soyad : " + Musteriler.Soyad);
//    Console.WriteLine("KimlikNo : " + Musteriler.KimlikNo);
//    Console.WriteLine("TelNo : " + Musteriler.TelNo);
//    Console.WriteLine("Adres : " + Musteriler.Adres);
//    Console.WriteLine("---------------------------------------------------");
//}




