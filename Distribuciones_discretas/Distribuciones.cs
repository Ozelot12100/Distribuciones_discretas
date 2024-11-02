using System;

namespace Distribuciones_discretas
{
    public static class Distribuciones
    {
        public static double CalcularDistribucionBinomial(int n, double p, int k)
        {
            double combinaciones = Factorial(n) / (Factorial(k) * Factorial(n - k));
            return combinaciones * Math.Pow(p, k) * Math.Pow(1 - p, n - k);
        }

        public static double CalcularDistribucionPoisson(double lambda, int k)
        {
            return (Math.Pow(lambda, k) * Math.Exp(-lambda)) / Factorial(k);
        }

        public static double CalcularDistribucionGeometrica(double p, int k)
        {
            return p * Math.Pow(1 - p, k - 1);
        }

        public static double CalcularDistribucionMultinomial(int n, double[] probabilidades, int[] frecuencias)
        {
            double coeficiente = Factorial(n);
            for (int i = 0; i < frecuencias.Length; i++)
            {
                coeficiente /= Factorial(frecuencias[i]);
            }

            double resultado = coeficiente;
            for (int i = 0; i < probabilidades.Length; i++)
            {
                resultado *= Math.Pow(probabilidades[i], frecuencias[i]);
            }

            return resultado;
        }

        public static double CalcularDistribucionHipergeometrica(int N, int K, int n, int k)
        {
            return (Combinacion(K, k) * Combinacion(N - K, n - k)) / (double)Combinacion(N, n);
        }

        private static int Factorial(int x)
        {
            int result = 1;
            for (int i = 2; i <= x; i++)
                result *= i;
            return result;
        }

        private static int Combinacion(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }
    }
}
