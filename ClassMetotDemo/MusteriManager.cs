using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarılı bir şekilde kayıt oldu :"+musteri.Id+musteri.Name+musteri.Age);
        }
        public void Remove(Musteri musteri)
        {
            Console.WriteLine("Müşteri hesabı silindi :"+musteri.Id);
        }
        public void  Liste(Musteri musteri)
        {
            Console.WriteLine("Müsterilerin Bilgileri : "+musteri.Id + musteri.Name+musteri.Description+musteri.Age);
        }
    }
}
