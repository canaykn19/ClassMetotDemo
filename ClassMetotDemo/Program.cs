using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri=new Musteri();
            musteri.id = 1;
            musteri.name = "Can";
            musteri.surname = "Aykın";
            
            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.name = "İrem";
            musteri2.surname = "Teke";
            
            Musteri musteri3 = new Musteri();
            musteri3.id = 3;
            musteri3.name = "Enes";
            musteri3.surname = "Şahin";

           

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            Console.WriteLine("--------------------");
            musteriManager.Sil(musteri);
            Console.WriteLine("--------------------");
            musteriManager.Listele(musteri2);
            Console.WriteLine("--------------------");
            Console.ReadKey();
        }

    }
}
