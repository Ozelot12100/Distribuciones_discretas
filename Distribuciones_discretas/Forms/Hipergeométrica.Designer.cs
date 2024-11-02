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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtPoblacionTotal = new Guna.UI2.WinForms.Guna2TextBox();
            txtExitosPoblacion = new Guna.UI2.WinForms.Guna2TextBox();
            txtTamanoMuestra = new Guna.UI2.WinForms.Guna2TextBox();
            txtExitosMuestra = new Guna.UI2.WinForms.Guna2TextBox();
            btnCalcular = new Guna.UI2.WinForms.Guna2Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtPoblacionTotal
            // 
            txtPoblacionTotal.CustomizableEdges = customizableEdges1;
            txtPoblacionTotal.DefaultText = "";
            txtPoblacionTotal.Font = new Font("Segoe UI", 9F);
            txtPoblacionTotal.Location = new Point(30, 38);
            txtPoblacionTotal.Margin = new Padding(3, 5, 3, 5);
            txtPoblacionTotal.Name = "txtPoblacionTotal";
            txtPoblacionTotal.PasswordChar = '\0';
            txtPoblacionTotal.PlaceholderText = "Tamaño total de la población (N)";
            txtPoblacionTotal.SelectedText = "";
            txtPoblacionTotal.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtPoblacionTotal.Size = new Size(246, 48);
            txtPoblacionTotal.TabIndex = 0;
            // 
            // txtExitosPoblacion
            // 
            txtExitosPoblacion.CustomizableEdges = customizableEdges3;
            txtExitosPoblacion.DefaultText = "";
            txtExitosPoblacion.Font = new Font("Segoe UI", 9F);
            txtExitosPoblacion.Location = new Point(30, 100);
            txtExitosPoblacion.Margin = new Padding(3, 5, 3, 5);
            txtExitosPoblacion.Name = "txtExitosPoblacion";
            txtExitosPoblacion.PasswordChar = '\0';
            txtExitosPoblacion.PlaceholderText = "Éxitos en la población (K)";
            txtExitosPoblacion.SelectedText = "";
            txtExitosPoblacion.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtExitosPoblacion.Size = new Size(246, 48);
            txtExitosPoblacion.TabIndex = 1;
            // 
            // txtTamanoMuestra
            // 
            txtTamanoMuestra.CustomizableEdges = customizableEdges5;
            txtTamanoMuestra.DefaultText = "";
            txtTamanoMuestra.Font = new Font("Segoe UI", 9F);
            txtTamanoMuestra.Location = new Point(30, 162);
            txtTamanoMuestra.Margin = new Padding(3, 5, 3, 5);
            txtTamanoMuestra.Name = "txtTamanoMuestra";
            txtTamanoMuestra.PasswordChar = '\0';
            txtTamanoMuestra.PlaceholderText = "Tamaño de la muestra (n)";
            txtTamanoMuestra.SelectedText = "";
            txtTamanoMuestra.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTamanoMuestra.Size = new Size(246, 48);
            txtTamanoMuestra.TabIndex = 2;
            // 
            // txtExitosMuestra
            // 
            txtExitosMuestra.CustomizableEdges = customizableEdges7;
            txtExitosMuestra.DefaultText = "";
            txtExitosMuestra.Font = new Font("Segoe UI", 9F);
            txtExitosMuestra.Location = new Point(30, 225);
            txtExitosMuestra.Margin = new Padding(3, 5, 3, 5);
            txtExitosMuestra.Name = "txtExitosMuestra";
            txtExitosMuestra.PasswordChar = '\0';
            txtExitosMuestra.PlaceholderText = "Éxitos en la muestra (k)";
            txtExitosMuestra.SelectedText = "";
            txtExitosMuestra.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtExitosMuestra.Size = new Size(246, 48);
            txtExitosMuestra.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.CustomizableEdges = customizableEdges9;
            btnCalcular.Font = new Font("Segoe UI", 9F);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(30, 288);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCalcular.Size = new Size(100, 56);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(30, 350);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(78, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado:";
            // 
            // Hipergeométrica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 438);
            Controls.Add(txtPoblacionTotal);
            Controls.Add(txtExitosPoblacion);
            Controls.Add(txtTamanoMuestra);
            Controls.Add(txtExitosMuestra);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Hipergeométrica";
            Text = "Distribución Hipergeométrica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}