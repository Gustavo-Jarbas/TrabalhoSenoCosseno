using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSenoCosseno.MVC
{
    abstract class absPropriedade : intMetodos
    {
        public string Mensagem { get; set; }
        public double N1 { get; set; }
        public double Cosseno { get; protected set; }
        public string Numero { get; protected set; }
        public string Resposta { get ; protected set; }
        public double Seno { get; protected set; }
        public double Tangente { get; protected set; }

        protected absPropriedade(double n1)
        {
            N1 = n1;
        }

        protected absPropriedade(string numero)
        {
            Numero = numero;
        }

        public void Executar()
        {
            
        }

        //Não soube utilizar o ToString :(

    }
}
