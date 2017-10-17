using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Iphone iphone = new Iphone();
            iphone.Fiyat();

            Samsung samsung =new Samsung();
            samsung.Fiyat();

        }

        public abstract class Telefon

        {
            public string Marka { get; }
            public string Model { get; }
            public abstract void Fiyat();

        }


        public class Iphone : Telefon
        {
            public override void Fiyat()
            {
                Console.WriteLine("Iphone fiyatı 4000 ");
                Console.ReadLine();
            }


        }


        public class Samsung : Telefon
        {
            public override void Fiyat()
            {
                Console.WriteLine("Samsung fiyatı 2000");
                Console.ReadLine();
            }
        }
    }

}
