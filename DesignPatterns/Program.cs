using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            VechterPrototype ninja = new Ninja("Blauw");
            VechterPrototype samurai = new Ninja("Groen");

            //wordt gerefereerd naar zelfde plaats ==> ninja aanpassen == ninjakopie aanpassen
            VechterPrototype ninjakopie = ninja;
            VechterPrototype samuraikopie = samurai;

            //ninja aanpassen != ninjakloon aanpassen
            VechterPrototype ninjakloon = ninja.Klonen();
            VechterPrototype samuraikloon = samurai.Klonen();

            ninja.Naam = "Gold";
            samurai.Naam = "Silver";

            Console.WriteLine("Originele ninja");
            Console.WriteLine("----------");
            ninja.ToonVechter();
            Console.WriteLine();

            Console.WriteLine("Gekopieerde ninja");
            Console.WriteLine("----------");
            ninjakopie.ToonVechter();
            Console.WriteLine();

            Console.WriteLine("Gekloonde ninja");
            Console.WriteLine("----------");
            ninjakloon.ToonVechter();
            Console.WriteLine();

            Console.WriteLine("Originele samurai");
            Console.WriteLine("----------");
            samurai.ToonVechter();
            Console.WriteLine();

            Console.WriteLine("Gekopieerde Samurai");
            Console.WriteLine("----------");
            samuraikopie.ToonVechter();
            Console.WriteLine();

            Console.WriteLine("Gekloonde samurai");
            Console.WriteLine("----------");
            samuraikloon.ToonVechter();
            Console.WriteLine();

            //Console.ReadLine();
        }
    }
}