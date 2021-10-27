using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSenoCosseno.MVC
{
    class Calcular : absPropriedade
    {
        public Calcular(double n1) : base(n1)
        {
            this.Executar();
        }

        public void Executar()
        {
            this.Seno = Math.Sin(this.N1);
            this.Cosseno = Math.Cos(this.N1);
            this.Tangente = Math.Tan(this.N1);
        }
    }
}
