using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi." + ":" + musteri.name + "  " + musteri.surname + "  " + musteri.id);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi." + ":" + musteri.name + "  " + musteri.surname);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri." + ":" + musteri.name + "  " +  musteri.surname );
        }

    }
}
