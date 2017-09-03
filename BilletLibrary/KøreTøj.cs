using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public abstract class KøreTøj
    {
        private string nummerPlade;

        public string NummerPlade
        {
            get { return nummerPlade; }
            set {
                if (value.Length > 7)
                    throw new ArgumentException("Nummerpladen må kun være syv tegn lang");
                
                nummerPlade = value;
            }
        }


        public DateTime Dato { get; set; }

        public bool BroBizz { get; set; }

        public abstract int Pris();

        public abstract string KøreTøjType();

        protected int GrundPris { get; }
        public KøreTøj(int grundpris)
        {
            this.GrundPris = grundpris;
        }

    }
}
