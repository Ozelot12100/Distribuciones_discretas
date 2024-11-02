namespace Distribuciones_discretas.Forms
{
    partial class Poisson
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2TextBox txtLambda;
        private Guna.UI2.WinForms.Guna2TextBox txtEventos;
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
            this.txtLambda = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEventos = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCalcular = new Guna.UI2.WinForms.Guna2Button();
            this.lblResultado = new Label();

            // 
            // txtLambda
            // 
            this.txtLambda.Top = 30;
            this.txtLambda.Left = 30;
            this.txtLambda.Width = 200;
            this.txtLambda.PlaceholderText = "Promedio de ocurrencias (λ)";
            this.txtLambda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLambda_KeyPress);

            // 
            // txtEventos
            // 
            this.txtEventos.Top = 80;
            this.txtEventos.Left = 30;
            this.txtEventos.Width = 200;
            this.txtEventos.PlaceholderText = "Número de eventos deseados (k)";
            this.txtEventos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEventos_KeyPress);

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
            // Poisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.txtLambda);
            this.Controls.Add(this.txtEventos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Text = "Distribución Poisson";
        }

        #endregion
    }
}