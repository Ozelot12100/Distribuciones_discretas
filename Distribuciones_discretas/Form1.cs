using Distribuciones_discretas.Forms;

namespace Distribuciones_discretas
{
    public partial class Form1 : Form
    {
        // Instancias de cada formulario
        private Binomial formBinomial;
        private Geom�trica formGeometrica;
        private Hipergeom�trica formHipergeometrica;
        private Multinomial formMultinomial;
        private Poisson formPoisson;

        public Form1()
        {
            InitializeComponent();

            // Inicializar instancias de los formularios
            formBinomial = new Binomial();
            formGeometrica = new Geom�trica();
            formHipergeometrica = new Hipergeom�trica();
            formMultinomial = new Multinomial();
            formPoisson = new Poisson();
            // Establece la primera pesta�a como la seleccionada
            
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar la pesta�a actual antes de mostrar el formulario nuevo
            TabPage selectedTab = tabControl.SelectedTab;
            selectedTab.Controls.Clear();

            // Mostrar el formulario correspondiente seg�n el �ndice de la pesta�a seleccionada
            switch (tabControl.SelectedIndex)
            {
                case 0: // Pesta�a para la Distribuci�n Binomial
                    formBinomial.TopLevel = false;
                    formBinomial.Dock = DockStyle.Fill;
                    selectedTab.Controls.Add(formBinomial);
                    formBinomial.Show();
                    break;

                case 1: // Pesta�a para la Distribuci�n Poisson
                    formPoisson.TopLevel = false;
                    formPoisson.Dock = DockStyle.Fill;
                    selectedTab.Controls.Add(formPoisson);
                    formPoisson.Show();
                    break;

                case 2: // Pesta�a para la Distribuci�n Geom�trica
                    formGeometrica.TopLevel = false;
                    formGeometrica.Dock = DockStyle.Fill;
                    selectedTab.Controls.Add(formGeometrica);
                    formGeometrica.Show();
                    break;

                case 3: // Pesta�a para la Distribuci�n Multinomial
                    formMultinomial.TopLevel = false;
                    formMultinomial.Dock = DockStyle.Fill;
                    selectedTab.Controls.Add(formMultinomial);
                    formMultinomial.Show();
                    break;

                case 4: // Pesta�a para la Distribuci�n Hipergeom�trica
                    formHipergeometrica.TopLevel = false;
                    formHipergeometrica.Dock = DockStyle.Fill;
                    selectedTab.Controls.Add(formHipergeometrica);
                    formHipergeometrica.Show();
                    break;

                default:
                    break;
            }
        }
    }
}
