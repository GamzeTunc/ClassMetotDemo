using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void ekle (Musteri musteri) //public heryerden erişilmesini sağlıyor.
        {
            Console.WriteLine("Muşteri Eklendi");
        }
        public void listele(Musteri musteri)
        {
            Console.WriteLine("Muşteri Listelendi");
        }
        public void silme (Musteri musteri)
        {
            Console.WriteLine("Muşteri Silindi");
        }
    }
}
