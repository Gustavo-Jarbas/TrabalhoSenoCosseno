using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoSenoCosseno.MVC;

namespace TrabalhoSenoCosseno
{
    public partial class FormPrincipal : Form
    {
        private Controle controlador;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            controlador = new Controle(txbNumero.Text.ToString());

            if (controlador.Resposta != "Dados inválidos")
            {
                lblCosseno.Text = controlador.Cosseno.ToString();
                lblSeno.Text = controlador.Seno.ToString();
                lblTangente.Text = controlador.Tangente.ToString();
            }
            else
            {
                lblCosseno.Text = "Número invalido";
                lblSeno.Text = "Número invalido";
                lblTangente.Text = "Número invalido";
            }
        }
    }
}
