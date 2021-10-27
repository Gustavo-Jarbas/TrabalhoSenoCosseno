
namespace TrabalhoSenoCosseno
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSeno = new System.Windows.Forms.Label();
            this.lblCosseno = new System.Windows.Forms.Label();
            this.lblTangente = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(48, 132);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(168, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(48, 69);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(168, 23);
            this.txbNumero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira um ângulo até 360 graus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cosseno =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seno =";
            // 
            // lblSeno
            // 
            this.lblSeno.AutoSize = true;
            this.lblSeno.Location = new System.Drawing.Point(138, 267);
            this.lblSeno.Name = "lblSeno";
            this.lblSeno.Size = new System.Drawing.Size(59, 15);
            this.lblSeno.TabIndex = 5;
            this.lblSeno.Text = "Resultado";
            // 
            // lblCosseno
            // 
            this.lblCosseno.AutoSize = true;
            this.lblCosseno.Location = new System.Drawing.Point(138, 310);
            this.lblCosseno.Name = "lblCosseno";
            this.lblCosseno.Size = new System.Drawing.Size(59, 15);
            this.lblCosseno.TabIndex = 6;
            this.lblCosseno.Text = "Resultado";
            // 
            // lblTangente
            // 
            this.lblTangente.AutoSize = true;
            this.lblTangente.Location = new System.Drawing.Point(138, 352);
            this.lblTangente.Name = "lblTangente";
            this.lblTangente.Size = new System.Drawing.Size(59, 15);
            this.lblTangente.TabIndex = 7;
            this.lblTangente.Text = "Resultado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tangente =";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTangente);
            this.Controls.Add(this.lblCosseno);
            this.Controls.Add(this.lblSeno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FormPrincipal";
            this.Text = "Seno Cosseno Tangente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSeno;
        private System.Windows.Forms.Label lblCosseno;
        private System.Windows.Forms.Label lblTangente;
        private System.Windows.Forms.Label label7;
    }
}

