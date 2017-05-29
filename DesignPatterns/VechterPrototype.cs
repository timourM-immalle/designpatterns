using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class VechterPrototype
    {
        private string naam;

        protected VechterPrototype(string naam)
        {
            this.naam = naam;
        }

        public VechterPrototype Klonen()
        {
            return (VechterPrototype)this.MemberwiseClone();
        }

        public void ToonVechter()
        {
            Console.WriteLine("naam: {0}", naam);
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
    }
}