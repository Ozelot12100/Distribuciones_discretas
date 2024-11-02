using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuciones_discretas.Forms
{
    public partial class Binomial : Form
    {
        public Binomial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validar campos antes de calcular
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios correctamente.");
                return;
            }

            // Obtener valores
            int n = int.Parse(txtEnsayos.Text);
            double p = double.Parse(txtProbabilidad.Text);
            int k = int.Parse(txtExitos.Text);

            // Calcular la probabilidad binomial usando la clase estática Distribuciones
            double resultado = Distribuciones.CalcularDistribucionBinomial(n, p, k);

            // Mostrar el resultado en porcentaje
            lblResultado.Text = $"Resultado: {resultado * 100:F2}%";
        }

        private bool ValidarCampos()
        {
            bool esValido = true;

            // Validar txtEnsayos
            if (!int.TryParse(txtEnsayos.Text, out int n) || n < 0)
            {
                txtEnsayos.BorderColor = System.Drawing.Color.Red;
                esValido = false;
            }
            else
            {
                txtEnsayos.BorderColor = System.Drawing.Color.Gray;
            }

            // Validar txtProbabilidad
            if (!double.TryParse(txtProbabilidad.Text, out double p) || p < 0 || p > 1)
            {
                txtProbabilidad.BorderColor = System.Drawing.Color.Red;
                esValido = false;
            }
            else
            {
                txtProbabilidad.BorderColor = System.Drawing.Color.Gray;
            }

            // Validar txtExitos
            if (!int.TryParse(txtExitos.Text, out int k) || k < 0 || k > n)
            {
                txtExitos.BorderColor = System.Drawing.Color.Red;
                esValido = false;
            }
            else
            {
                txtExitos.BorderColor = System.Drawing.Color.Gray;
            }

            return esValido;
        }

        private void txtProbabilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, punto decimal y control de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && txtProbabilidad.Text.Contains("."))
            {
                e.Handled = true;
            }

            // Evitar que el punto decimal sea el primer carácter
            if (e.KeyChar == '.' && txtProbabilidad.Text.Length == 0)
            {
                e.Handled = true;
            }
        }

        private void txtExitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y control de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
