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
    public partial class Poisson : Form
    {
        public Poisson()
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
            double lambda = double.Parse(txtLambda.Text);
            int k = int.Parse(txtEventos.Text);

            // Calcular la probabilidad Poisson usando la clase estática Distribuciones
            double resultado = Distribuciones.CalcularDistribucionPoisson(lambda, k);

            // Mostrar el resultado en porcentaje
            lblResultado.Text = $"Resultado: {resultado * 100:F2}%";
        }

        private bool ValidarCampos()
        {
            bool esValido = true;

            // Validar txtLambda
            if (!double.TryParse(txtLambda.Text, out double lambda) || lambda < 0)
            {
                txtLambda.BorderColor = System.Drawing.Color.Red;
                esValido = false;
            }
            else
            {
                txtLambda.BorderColor = System.Drawing.Color.Gray;
            }

            // Validar txtEventos
            if (!int.TryParse(txtEventos.Text, out int k) || k < 0)
            {
                txtEventos.BorderColor = System.Drawing.Color.Red;
                esValido = false;
            }
            else
            {
                txtEventos.BorderColor = System.Drawing.Color.Gray;
            }

            return esValido;
        }

        private void txtLambda_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, punto decimal y control de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && txtLambda.Text.Contains("."))
            {
                e.Handled = true;
            }

            // Evitar que el punto decimal sea el primer carácter
            if (e.KeyChar == '.' && txtLambda.Text.Length == 0)
            {
                e.Handled = true;
            }
        }

        private void txtEventos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y control de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
