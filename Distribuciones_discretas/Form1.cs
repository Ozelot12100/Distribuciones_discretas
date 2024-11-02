using Distribuciones_discretas.Forms;

namespace Distribuciones_discretas
{
    public partial class Form1 : Form
    {
        // Instancias de cada formulario
        private Binomial formBinomial;
        private Geométrica formGeometrica;
        private Hipergeométrica formHipergeometrica;
        private Multinomial formMultinomial;
        private Poisson formPoisson;

        public Form1()
        {
            InitializeComponent();

            // Inicializar instancias de los formularios
            formBinomial = new Binomial();
            formGeometrica = new Geométrica();
            formHipergeometrica = new Hipergeométrica();
            formMultinomial = new Multinomial();
            formPoisson = new Poisson();
            // Establece la primera pestaña como la seleccionada
            
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar la pestaña actual antes de mostrar el formulario nuevo
            TabPage selectedTab = tabControl.SelectedTab;
            selectedTab.Controls.Clear();

            // Mostrar el formulario correspondiente según el índice de la pestaña seleccionada
            switch (tabControl.SelectedIndex)
            {
                case 0: // Pestaña para la Distribución Binomial
                    formBinomial.TopLevel = false;
                    formBinomial.Dock = DockStyle.Fill;
                    selectedTab.Controls.Add(formBinomial);
                    formBinomial.Show();
                    break;

                case 1: // Pestaña para la Distribución Poisson
                    formPoisson.TopLevel = false;
                    formPoisson.Dock = DockStyle.Fill;
                    selectedTab.Controls.Add(formPoisson);
                    formPoisson.Show();
                    break;

                case 2: // Pestaña para la Distribución Geométrica
                    formGeometrica.TopLevel = false;
                    formGeometrica.Dock = DockStyle.Fill;
                    selectedTab.Controls.Add(formGeometrica);
                    formGeometrica.Show();
                    break;

                case 3: // Pestaña para la Distribución Multinomial
                    formMultinomial.TopLevel = false;
                    formMultinomial.Dock = DockStyle.Fill;
                    selectedTab.Controls.Add(formMultinomial);
                    formMultinomial.Show();
                    break;

                case 4: // Pestaña para la Distribución Hipergeométrica
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
