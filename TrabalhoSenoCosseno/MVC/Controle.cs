using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSenoCosseno.MVC
{
    class Controle : absPropriedade
    {
        private absPropriedade converter;
        public Controle(string numero) : base(numero)
        {
            this.Executar();
        }

        public void Executar()
        {
            converter = new Validacao(this.Numero);
            if(converter.Resposta != "Dados inválidos")
            {
                converter = new Calcular(Convert.ToDouble(this.Numero));

                this.Seno = converter.Seno;
                this.Cosseno = converter.Cosseno;
                this.Tangente = converter.Tangente;
            }
        }   
    }
}
