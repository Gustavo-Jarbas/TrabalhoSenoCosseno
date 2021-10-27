using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSenoCosseno.MVC
{
    class Validacao : absPropriedade
    {
        public Validacao(string numero) : base(numero)
        {
            this.Executar();
        }

        public void Executar()
        {
            try
            {
                this.N1 = Convert.ToInt32(this.Numero);
                this.Resposta = "Tudo certo";
            }
            catch (Exception)
            {
                this.Resposta = "Dados inválidos";
            }
        }
    }
}
