namespace Distribuciones_discretas
{
   partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private TabPage tabBinomial;
        private TabPage tabPoisson;
        private TabPage tabGeometrica;
        private TabPage tabMultinomial;
        private TabPage tabHipergeometrica;

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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabBinomial = new TabPage();
            this.tabPoisson = new TabPage();
            this.tabGeometrica = new TabPage();
            this.tabMultinomial = new TabPage();
            this.tabHipergeometrica = new TabPage();

            // Configuración del TabControl
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;

            // Configuración de las pestañas
            this.tabBinomial.Text = "Distribución Binomial";
            this.tabPoisson.Text = "Distribución Poisson";
            this.tabGeometrica.Text = "Distribución Geométrica";
            this.tabMultinomial.Text = "Distribución Multinomial";
            this.tabHipergeometrica.Text = "Distribución Hipergeométrica";

            // Agregar las pestañas al TabControl
            this.tabControl.TabPages.Add(this.tabBinomial);
            this.tabControl.TabPages.Add(this.tabPoisson);
            this.tabControl.TabPages.Add(this.tabGeometrica);
            this.tabControl.TabPages.Add(this.tabMultinomial);
            this.tabControl.TabPages.Add(this.tabHipergeometrica);

            // Asignar el evento SelectedIndexChanged
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);

            // Configuración de Form1
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Text = "Menú Principal de Distribuciones Discretas";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
