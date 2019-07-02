using System;
using System.Collections.Generic;
using Metodos.Types;

namespace Metodos
{
    static class MetodosNoLineales
    {

        public static double ErrorAbsoluto { get; set; }
        public static double ErrorRelativo { get; set; }

        /// <summary>
        /// Busca aproximaciones de raíces de una función a través del método de bisección.
        /// Recibe un intervalo donde ocurre un cambio de signo en f(x).
        /// </summary>
        /// <param name="intervalo">El intervalo a evaluar, donde ocurre el cambio de signo</param>
        /// <param name="f">La función a evaluar</param>
        /// <param name="iterations">El número de iteraciones que se van a realizar para la aproximación</param>
        /// <returns></returns>
        public static double Biseccion(Intervalo<double> intervalo, Func<double, double> f, int iterations)
        {
            var currIntervalo = new Intervalo<double>(intervalo);
            double semisuma = 0.0;
            double prevSemi = 0.0;

            for (int i = 0; i <= iterations; i++)
            {
                prevSemi = semisuma;
                semisuma = (currIntervalo.inicio + currIntervalo.fin) / 2;
                if (MismoSigno(f(currIntervalo.inicio), f(semisuma)))
                {
                    currIntervalo.inicio = semisuma;
                }
                else
                {
                    currIntervalo.fin = semisuma;
                }


                // Calculamos el Error
                if (i == 0) continue;
                ErrorAbsoluto = Math.Abs(semisuma - prevSemi);
                ErrorRelativo = ErrorAbsoluto / Math.Abs(semisuma);

            }

            return semisuma;
        }

        /// <summary>
        /// Cambia los valores de 2 variables
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="var1"></param>
        /// <param name="var2"></param>
        static void Swap<T>(ref T var1, ref T var2)
        {
            T tmp = var1;
            var1 = var2;
            var2 = tmp;
        }

        /// <summary>
        /// Verifica si 2 variables tienen el mismo signo
        /// </summary>
        /// <param name="var1"></param>
        /// <param name="var2"></param>
        /// <returns>true si tienen el mismo signo, false si no</returns>
        static bool MismoSigno(double var1, double var2)
        {
            return (var1 < 0 && var2 < 0) || (var1 > 0 && var2 > 0) ? true : false;
        }

        /// <summary>
        /// Tabula una función y encuentra los intervalos donde hay un cambio de signo en f(x)
        /// </summary>
        /// <param name="inicio">Valor de x donde se iniciará la búsqueda</param>
        /// <param name="fin">Valor de x donde se terminará la búsqueda</param>
        /// <param name="step">El incremento de x para la tabulación</param>
        /// <param name="f">La función a evaluar</param>
        /// <returns></returns>
        public static List<Intervalo<double>> BuscarIntervalos(double inicio, double fin, double step, Func<double, double> f)
        {
            var intervalos = new List<Intervalo<double>>();

            if(inicio > fin)
            {
                Swap(ref inicio, ref fin);
            }

            // Colocar el f(x) con la x anterior para comparar con la actual
            double prevF = f(inicio);
            double currX = inicio;
            while (currX <= fin)
            {
                double currF = f(currX);
                if (!MismoSigno(currF, prevF))
                {
                    // Si hubo un cambio de signo, agregar el intervalo a la lista
                    intervalos.Add(new Intervalo<double>(currX - step, currX));
                }
                prevF = currF;
                currX += step;
            }


            return intervalos;
        }
    }
}
