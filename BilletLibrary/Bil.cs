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

        /// <summary>
        /// beregner prisen for bil på bagrund af om der er brobizz og om det er
        /// en tur i weekenden
        /// </summary>
        /// <returns></returns>
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
