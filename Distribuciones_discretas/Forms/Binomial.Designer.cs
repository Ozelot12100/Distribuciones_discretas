namespace Distribuciones_discretas.Forms
{
    partial class Binomial
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2TextBox txtEnsayos;
        private Guna.UI2.WinForms.Guna2TextBox txtProbabilidad;
        private Guna.UI2.WinForms.Guna2TextBox txtExitos;
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
            this.txtEnsayos = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProbabilidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtExitos = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCalcular = new Guna.UI2.WinForms.Guna2Button();
            this.lblResultado = new Label();

            // 
            // txtEnsayos
            // 
            this.txtEnsayos.Top = 30;
            this.txtEnsayos.Left = 30;
            this.txtEnsayos.Width = 200;
            this.txtEnsayos.PlaceholderText = "Número de ensayos (n)";

            // 
            // txtProbabilidad
            // 
            this.txtProbabilidad.Top = 80;
            this.txtProbabilidad.Left = 30;
            this.txtProbabilidad.Width = 200;
            this.txtProbabilidad.PlaceholderText = "Probabilidad de éxito (p)";
            this.txtProbabilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProbabilidad_KeyPress);

            // 
            // txtExitos
            // 
            this.txtExitos.Top = 130;
            this.txtExitos.Left = 30;
            this.txtExitos.Width = 200;
            this.txtExitos.PlaceholderText = "Número de éxitos deseados (k)";
            this.txtExitos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExitos_KeyPress);

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
            // Binomial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.txtEnsayos);
            this.Controls.Add(this.txtProbabilidad);
            this.Controls.Add(this.txtExitos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Text = "Distribución Binomial";
        }

        #endregion
    }
}