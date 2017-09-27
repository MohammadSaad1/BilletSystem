using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class Bil : KøreTøj
    {
        private int v;

        //protected const int GrundPris = 240;

        public override string KøreTøjType()
        {
            return "Bil";
        }

        

        public override int Pris()
        {
            int total = GrundPris;

            //ekstra 20 % pga lørdag eller søndag
            if (base.Dato.DayOfWeek == DayOfWeek.Saturday || base.Dato.DayOfWeek == DayOfWeek.Sunday)
                total = total * 80 / 100; 


            if (BroBizz)
                return total * 95 / 100;

            return total;
        }

        public Bil()
         :base(240)
        {

        }

    }
}
