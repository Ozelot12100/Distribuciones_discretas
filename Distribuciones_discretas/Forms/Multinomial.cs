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
    public partial class Multinomial : Form
    {
        public Multinomial()
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
            int n = int.Parse(txtExperimentos.Text);
            double[] probabilidades = txtProbabilidades.Text.Split(',').Select(double.Parse).ToArray();
            int[] frecuencias = txtFrecuencias.Text.Split(',').Select(int.Parse).ToArray();

            // Calcular la probabilidad multinomial usando la clase estática Distribuciones
            double resultado = Distribuciones.CalcularDistribucionMultinomial(n, probabilidades, frecuencias);

            // Mostrar el resultado en porcentaje
            lblResultado.Text = $"Resultado: {resultado * 100:F2}%";
        }

        private bool ValidarCampos()
        {
            bool esValido = true;

            // Validar txtExperimentos
            if (!int.TryParse(txtExperimentos.Text, out int n) || n < 1)
            {
                txtExperimentos.BorderColor = System.Drawing.Color.Red;
                esValido = false;
            }
            else
            {
                txtExperimentos.BorderColor = System.Drawing.Color.Gray;
            }

            // Inicializar las variables para probabilidades y frecuencias
            double[] probabilidades = null;
            int[] frecuencias = null;

            // Validar txtProbabilidades
            string[] probStrings = txtProbabilidades.Text.Split(',');
            if (probStrings.All(s => double.TryParse(s, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double prob) && prob >= 0 && prob <= 1))
            {
                probabilidades = probStrings.Select(s => double.Parse(s, System.Globalization.CultureInfo.InvariantCulture)).ToArray();
            }
            else
            {
                txtProbabilidades.BorderColor = System.Drawing.Color.Red;
                esValido = false;
            }

            // Validar txtFrecuencias
            string[] freqStrings = txtFrecuencias.Text.Split(',');
            if (freqStrings.All(s => int.TryParse(s, out int freq) && freq >= 0))
            {
                frecuencias = freqStrings.Select(int.Parse).ToArray();
            }
            else
            {
                txtFrecuencias.BorderColor = System.Drawing.Color.Red;
                esValido = false;
            }

            return esValido;
        }


        private void txtProbabilidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, coma, punto y control de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtFrecuencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, coma y control de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
