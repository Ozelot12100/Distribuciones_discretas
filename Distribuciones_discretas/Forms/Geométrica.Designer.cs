namespace Distribuciones_discretas.Forms
{
    partial class Geométrica
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2TextBox txtProbabilidad;
        private Guna.UI2.WinForms.Guna2TextBox txtIntentos;
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
            this.txtProbabilidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIntentos = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCalcular = new Guna.UI2.WinForms.Guna2Button();
            this.lblResultado = new Label();

            // 
            // txtProbabilidad
            // 
            this.txtProbabilidad.Top = 30;
            this.txtProbabilidad.Left = 30;
            this.txtProbabilidad.Width = 200;
            this.txtProbabilidad.PlaceholderText = "Probabilidad de éxito (p)";
            this.txtProbabilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProbabilidad_KeyPress);

            // 
            // txtIntentos
            // 
            this.txtIntentos.Top = 80;
            this.txtIntentos.Left = 30;
            this.txtIntentos.Width = 200;
            this.txtIntentos.PlaceholderText = "Número de intentos hasta el éxito (k)";
            this.txtIntentos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntentos_KeyPress);

            // 
            // btnCalcular
            // 
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Top = 130;
            this.btnCalcular.Left = 30;
            this.btnCalcular.Width = 100;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.Top = 180;
            this.lblResultado.Left = 30;
            this.lblResultado.AutoSize = true;

            // 
            // Geométrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.txtProbabilidad);
            this.Controls.Add(this.txtIntentos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Text = "Distribución Geométrica";
            FormBorderStyle = FormBorderStyle.None;
        }

        #endregion
    }
}