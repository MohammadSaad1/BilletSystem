using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class Bil : KøreTøj
    {
        public override string KøreTøjType()
        {
            return "Bil";
        }

        public override int Pris()
        {
            return 240;
        }
    }
}
