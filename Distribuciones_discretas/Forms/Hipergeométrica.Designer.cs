namespace Distribuciones_discretas.Forms
{
    partial class Hipergeométrica
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2TextBox txtPoblacionTotal;
        private Guna.UI2.WinForms.Guna2TextBox txtExitosPoblacion;
        private Guna.UI2.WinForms.Guna2TextBox txtTamanoMuestra;
        private Guna.UI2.WinForms.Guna2TextBox txtExitosMuestra;
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
            this.txtPoblacionTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtExitosPoblacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTamanoMuestra = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtExitosMuestra = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCalcular = new Guna.UI2.WinForms.Guna2Button();
            this.lblResultado = new Label();

            // 
            // txtPoblacionTotal
            // 
            this.txtPoblacionTotal.Top = 30;
            this.txtPoblacionTotal.Left = 30;
            this.txtPoblacionTotal.Width = 200;
            this.txtPoblacionTotal.PlaceholderText = "Tamaño total de la población (N)";

            // 
            // txtExitosPoblacion
            // 
            this.txtExitosPoblacion.Top = 80;
            this.txtExitosPoblacion.Left = 30;
            this.txtExitosPoblacion.Width = 200;
            this.txtExitosPoblacion.PlaceholderText = "Éxitos en la población (K)";

            // 
            // txtTamanoMuestra
            // 
            this.txtTamanoMuestra.Top = 130;
            this.txtTamanoMuestra.Left = 30;
            this.txtTamanoMuestra.Width = 200;
            this.txtTamanoMuestra.PlaceholderText = "Tamaño de la muestra (n)";

            // 
            // txtExitosMuestra
            // 
            this.txtExitosMuestra.Top = 180;
            this.txtExitosMuestra.Left = 30;
            this.txtExitosMuestra.Width = 200;
            this.txtExitosMuestra.PlaceholderText = "Éxitos en la muestra (k)";

            // 
            // btnCalcular
            // 
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Top = 230;
            this.btnCalcular.Left = 30;
            this.btnCalcular.Width = 100;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.Top = 280;
            this.lblResultado.Left = 30;
            this.lblResultado.AutoSize = true;

            // 
            // Hipergeométrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.txtPoblacionTotal);
            this.Controls.Add(this.txtExitosPoblacion);
            this.Controls.Add(this.txtTamanoMuestra);
            this.Controls.Add(this.txtExitosMuestra);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Text = "Distribución Hipergeométrica";
            FormBorderStyle = FormBorderStyle.None;
        }

        #endregion
    }
}