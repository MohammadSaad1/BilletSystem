using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class Bil : KøreTøj
    {

        private const int bilPris = 240;

        public override string KøreTøjType()
        {
            return "Bil";
        }

        public override int Pris()
        {
            if (BroBizz)
                return bilPris * 95 / 100;

            return bilPris;
        }
    }
}
