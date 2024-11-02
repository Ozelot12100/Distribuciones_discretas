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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtProbabilidad = new Guna.UI2.WinForms.Guna2TextBox();
            txtIntentos = new Guna.UI2.WinForms.Guna2TextBox();
            btnCalcular = new Guna.UI2.WinForms.Guna2Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtProbabilidad
            // 
            txtProbabilidad.CustomizableEdges = customizableEdges1;
            txtProbabilidad.DefaultText = "";
            txtProbabilidad.Font = new Font("Segoe UI", 9F);
            txtProbabilidad.Location = new Point(30, 38);
            txtProbabilidad.Margin = new Padding(3, 5, 3, 5);
            txtProbabilidad.Name = "txtProbabilidad";
            txtProbabilidad.PasswordChar = '\0';
            txtProbabilidad.PlaceholderText = "Probabilidad de éxito (p)";
            txtProbabilidad.SelectedText = "";
            txtProbabilidad.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtProbabilidad.Size = new Size(271, 48);
            txtProbabilidad.TabIndex = 0;
            txtProbabilidad.KeyPress += txtProbabilidad_KeyPress;
            // 
            // txtIntentos
            // 
            txtIntentos.CustomizableEdges = customizableEdges3;
            txtIntentos.DefaultText = "";
            txtIntentos.Font = new Font("Segoe UI", 9F);
            txtIntentos.Location = new Point(30, 100);
            txtIntentos.Margin = new Padding(3, 5, 3, 5);
            txtIntentos.Name = "txtIntentos";
            txtIntentos.PasswordChar = '\0';
            txtIntentos.PlaceholderText = "Número de intentos hasta el éxito (k)";
            txtIntentos.SelectedText = "";
            txtIntentos.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtIntentos.Size = new Size(271, 48);
            txtIntentos.TabIndex = 1;
            txtIntentos.KeyPress += txtIntentos_KeyPress;
            // 
            // btnCalcular
            // 
            btnCalcular.CustomizableEdges = customizableEdges5;
            btnCalcular.Font = new Font("Segoe UI", 9F);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(30, 162);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCalcular.Size = new Size(100, 56);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(30, 225);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(78, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado:";
            // 
            // Geométrica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 312);
            Controls.Add(txtProbabilidad);
            Controls.Add(txtIntentos);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Geométrica";
            Text = "Distribución Geométrica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}