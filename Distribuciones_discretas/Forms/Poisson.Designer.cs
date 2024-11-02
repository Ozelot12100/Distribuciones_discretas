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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtLambda = new Guna.UI2.WinForms.Guna2TextBox();
            txtEventos = new Guna.UI2.WinForms.Guna2TextBox();
            btnCalcular = new Guna.UI2.WinForms.Guna2Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtLambda
            // 
            txtLambda.CustomizableEdges = customizableEdges1;
            txtLambda.DefaultText = "";
            txtLambda.Font = new Font("Segoe UI", 9F);
            txtLambda.Location = new Point(30, 38);
            txtLambda.Margin = new Padding(3, 5, 3, 5);
            txtLambda.Name = "txtLambda";
            txtLambda.PasswordChar = '\0';
            txtLambda.PlaceholderText = "Promedio de ocurrencias (λ)";
            txtLambda.SelectedText = "";
            txtLambda.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtLambda.Size = new Size(241, 48);
            txtLambda.TabIndex = 0;
            txtLambda.KeyPress += txtLambda_KeyPress;
            // 
            // txtEventos
            // 
            txtEventos.CustomizableEdges = customizableEdges3;
            txtEventos.DefaultText = "";
            txtEventos.Font = new Font("Segoe UI", 9F);
            txtEventos.Location = new Point(30, 100);
            txtEventos.Margin = new Padding(3, 5, 3, 5);
            txtEventos.Name = "txtEventos";
            txtEventos.PasswordChar = '\0';
            txtEventos.PlaceholderText = "Número de eventos deseados (k)";
            txtEventos.SelectedText = "";
            txtEventos.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtEventos.Size = new Size(241, 48);
            txtEventos.TabIndex = 1;
            txtEventos.KeyPress += txtEventos_KeyPress;
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
            // Poisson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 312);
            Controls.Add(txtLambda);
            Controls.Add(txtEventos);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Poisson";
            Text = "Distribución Poisson";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}