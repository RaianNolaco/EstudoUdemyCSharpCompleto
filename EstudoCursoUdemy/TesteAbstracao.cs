using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCursoUdemy
{
    public abstract class TesteAbstracao
    {
       
        public decimal somaValor( decimal n1, decimal n2)
        {
            return n1 + n2;
        }

        public abstract void metodQueFazAlgo();
    }
}
