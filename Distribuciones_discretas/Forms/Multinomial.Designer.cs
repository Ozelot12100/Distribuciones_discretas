namespace Distribuciones_discretas.Forms
{
    partial class Multinomial
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2TextBox txtExperimentos;
        private Guna.UI2.WinForms.Guna2TextBox txtProbabilidades;
        private Guna.UI2.WinForms.Guna2TextBox txtFrecuencias;
        private Guna.UI2.WinForms.Guna2Button btnCalcular;
        private Label lblResultado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtExperimentos = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProbabilidades = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFrecuencias = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCalcular = new Guna.UI2.WinForms.Guna2Button();
            this.lblResultado = new Label();

            // 
            // txtExperimentos
            // 
            this.txtExperimentos.Top = 30;
            this.txtExperimentos.Left = 30;
            this.txtExperimentos.Width = 200;
            this.txtExperimentos.PlaceholderText = "Número total de experimentos (n)";

            // 
            // txtProbabilidades
            // 
            this.txtProbabilidades.Top = 80;
            this.txtProbabilidades.Left = 30;
            this.txtProbabilidades.Width = 200;
            this.txtProbabilidades.PlaceholderText = "Probabilidades (p1, p2, ..., pm)";
            this.txtProbabilidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProbabilidades_KeyPress);

            // 
            // txtFrecuencias
            // 
            this.txtFrecuencias.Top = 130;
            this.txtFrecuencias.Left = 30;
            this.txtFrecuencias.Width = 200;
            this.txtFrecuencias.PlaceholderText = "Frecuencias (k1, k2, ..., km)";
            this.txtFrecuencias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrecuencias_KeyPress);

            // 
            // btnCalcular
            // 
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Top = 180;
            this.btnCalcular.Left = 30;
            this.btnCalcular.Width = 100;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.Top = 230;
            this.lblResultado.Left = 30;
            this.lblResultado.AutoSize = true;

            // 
            // Multinomial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.txtExperimentos);
            this.Controls.Add(this.txtProbabilidades);
            this.Controls.Add(this.txtFrecuencias);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Text = "Distribución Multinomial";
            FormBorderStyle = FormBorderStyle.None;
        }

        #endregion
    }
}