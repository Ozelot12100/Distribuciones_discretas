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
    public partial class Hipergeométrica : Form
    {
        public Hipergeométrica()
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
            int N = int.Parse(txtPoblacionTotal.Text);
            int K = int.Parse(txtExitosPoblacion.Text);
            int n = int.Parse(txtTamanoMuestra.Text);
            int k = int.Parse(txtExitosMuestra.Text);

            // Calcular la probabilidad hipergeométrica usando la clase estática Distribuciones
            double resultado = Distribuciones.CalcularDistribucionHipergeometrica(N, K, n, k);

            // Mostrar el resultado en porcentaje
            lblResultado.Text = $"Resultado: {resultado * 100:F2}%";
        }

        private bool ValidarCampos()
        {
            bool esValido = true;

            // Validar txtPoblacionTotal
            if (!int.TryParse(txtPoblacionTotal.Text, out int N) || N <= 0)
            {
                txtPoblacionTotal.BorderColor = System.Drawing.Color.Red;
                esValido = false;
            }
            else
            {
                txtPoblacionTotal.BorderColor = System.Drawing.Color.Gray;
            }

            // Validar txtExitosPoblacion
            if (!int.TryParse(txtExitosPoblacion.Text, out int K) || K < 0 || K > N)
            {
                txtExitosPoblacion.BorderColor = System.Drawing.Color.Red;
                esValido = false;
            }
            else
            {
                txtExitosPoblacion.BorderColor = System.Drawing.Color.Gray;
            }

            // Validar txtTamanoMuestra
            if (!int.TryParse(txtTamanoMuestra.Text, out int n) || n < 0 || n > N)
            {
                txtTamanoMuestra.BorderColor = System.Drawing.Color.Red;
                esValido = false;
            }
            else
            {
                txtTamanoMuestra.BorderColor = System.Drawing.Color.Gray;
            }

            // Validar txtExitosMuestra
            if (!int.TryParse(txtExitosMuestra.Text, out int k) || k < 0 || k > K || k > n)
            {
                txtExitosMuestra.BorderColor = System.Drawing.Color.Red;
                esValido = false;
            }
            else
            {
                txtExitosMuestra.BorderColor = System.Drawing.Color.Gray;
            }

            return esValido;
        }
    }
}
