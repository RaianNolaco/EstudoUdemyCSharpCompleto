using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCursoUdemy
{
    internal class HerdarClasseAbstrata : TesteAbstracao
    {

        public override void metodQueFazAlgo()
        {
            Console.WriteLine($"Estou sendo mostrado pela classe {nameof(HerdarClasseAbstrata)}");
        }
    }
}
