using System;
using System.Collections.Generic;
using System.Text;

using Metodos.Types;

namespace Metodos
{
    class Calculo
    {
        /// <summary>
        /// El valor pequeño usado para derivar (el valor que tiene a cero)
        /// </summary>
        public static double H { get; } = Math.Pow(10, -10);

        /// <summary>
        /// Calcula la derivada de una función en un punto mediante una aproximación a la definición de derivada.
        /// Utiliza la propiedad H.
        /// </summary>
        /// <param name="f">La función a derivar</param>
        /// <param name="val">El valor en el que se evalúa la derivada</param>
        /// <returns>Una aproximación a la derivada</returns>
        public static double Derivar(Func<double, double> f, double val)
        {

            return (f(val + H) - f(val)) / H;
        }

        /// <summary>
        /// Calcula la integral definida de una función en un intervalo mediante una aproximación por el método
        /// de Newton-Cotes por rectángulos.
        /// </summary>
        /// <param name="f">La función a integrar</param>
        /// <param name="intervalo">El intervalo de evaluación</param>
        /// <param name="numIntervalos">La cantidad de intervalos en los que se dividirá la función</param>
        /// <returns>Una aproximación a la integral</returns>
        public static double IntegrarRect(Func<double, double> f, Intervalo<double> intervalo, int numIntervalos)
        {
            double delta = Math.Abs(intervalo.fin - intervalo.inicio) / numIntervalos;
            double x0 = intervalo.inicio;
            double x1 = x0 + delta;

            double suma = 0;

            while(x1 <= intervalo.fin)
            {
                suma += f(x0);
                x0 = x1;
                x1 += delta;
            }
            return delta * suma;
        }

    }
}
