using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri muster = new Musteri();
            muster.Id = 1;
            muster.Ad = "Gamze";
            muster.Soyad = "TUNÇ";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.ekle(muster);
            musteriManager.listele(muster);
            musteriManager.silme(muster);

            Console.ReadLine();
        }

        

        
    }
}
