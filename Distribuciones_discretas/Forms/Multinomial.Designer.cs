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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtExperimentos = new Guna.UI2.WinForms.Guna2TextBox();
            txtProbabilidades = new Guna.UI2.WinForms.Guna2TextBox();
            txtFrecuencias = new Guna.UI2.WinForms.Guna2TextBox();
            btnCalcular = new Guna.UI2.WinForms.Guna2Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtExperimentos
            // 
            txtExperimentos.CustomizableEdges = customizableEdges1;
            txtExperimentos.DefaultText = "";
            txtExperimentos.Font = new Font("Segoe UI", 9F);
            txtExperimentos.Location = new Point(30, 38);
            txtExperimentos.Margin = new Padding(3, 5, 3, 5);
            txtExperimentos.Name = "txtExperimentos";
            txtExperimentos.PasswordChar = '\0';
            txtExperimentos.PlaceholderText = "Número total de experimentos (n)";
            txtExperimentos.SelectedText = "";
            txtExperimentos.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtExperimentos.Size = new Size(258, 48);
            txtExperimentos.TabIndex = 0;
            // 
            // txtProbabilidades
            // 
            txtProbabilidades.CustomizableEdges = customizableEdges3;
            txtProbabilidades.DefaultText = "";
            txtProbabilidades.Font = new Font("Segoe UI", 9F);
            txtProbabilidades.Location = new Point(30, 100);
            txtProbabilidades.Margin = new Padding(3, 5, 3, 5);
            txtProbabilidades.Name = "txtProbabilidades";
            txtProbabilidades.PasswordChar = '\0';
            txtProbabilidades.PlaceholderText = "Probabilidades (p1, p2, ..., pm)";
            txtProbabilidades.SelectedText = "";
            txtProbabilidades.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtProbabilidades.Size = new Size(258, 48);
            txtProbabilidades.TabIndex = 1;
            txtProbabilidades.KeyPress += txtProbabilidades_KeyPress;
            // 
            // txtFrecuencias
            // 
            txtFrecuencias.CustomizableEdges = customizableEdges5;
            txtFrecuencias.DefaultText = "";
            txtFrecuencias.Font = new Font("Segoe UI", 9F);
            txtFrecuencias.Location = new Point(30, 162);
            txtFrecuencias.Margin = new Padding(3, 5, 3, 5);
            txtFrecuencias.Name = "txtFrecuencias";
            txtFrecuencias.PasswordChar = '\0';
            txtFrecuencias.PlaceholderText = "Frecuencias (k1, k2, ..., km)";
            txtFrecuencias.SelectedText = "";
            txtFrecuencias.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtFrecuencias.Size = new Size(258, 48);
            txtFrecuencias.TabIndex = 2;
            txtFrecuencias.KeyPress += txtFrecuencias_KeyPress;
            // 
            // btnCalcular
            // 
            btnCalcular.CustomizableEdges = customizableEdges7;
            btnCalcular.Font = new Font("Segoe UI", 9F);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(30, 225);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnCalcular.Size = new Size(100, 56);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(30, 288);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(78, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado:";
            // 
            // Multinomial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 375);
            Controls.Add(txtExperimentos);
            Controls.Add(txtProbabilidades);
            Controls.Add(txtFrecuencias);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Multinomial";
            Text = "Distribución Multinomial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}