using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polecenie18
{
    class Program
    {
        static void Main(string[] args)
        {
            var samochod1 = new Samochod1();
            var samochod2 = new Samochod2();
            samochod1.Color = "zielony";
            samochod2.Color = "zielony";
            Maluj1(samochod1);
            Maluj2(samochod2);
            Console.WriteLine(samochod1.Color + "\n");
            Console.WriteLine(samochod2.Color + "\n");
            Console.ReadLine();
        }

        public static void Maluj1(Samochod1 car1)
        {
            car1.Color = "czerwony";
        }
        public static void Maluj2(Samochod2 car2)
        {
            car2.Color = "czerwony";
        }
    }

    struct Samochod1
    {
        public string Color { get; set; }
    }

    class Samochod2
    {
        public string Color { get; set; }
    }
}
