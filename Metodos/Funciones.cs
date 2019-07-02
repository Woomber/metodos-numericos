using System;

namespace Metodos
{
    /// <summary>
    /// Funciones varias para probar los métodos numéricos
    /// </summary>
    static class Funciones
    {
        public static double FuncCubica(double x)
        {
            return x * x * x - 6;
        }

        public static double FuncSin(double x)
        {
            return x * Math.Sin(x) - 1;
        }
        public static double FuncCos(double x)
        {
            return x * x - Math.Cos(x);
        }
        public static double FuncExp(double x)
        {
            return Math.Pow(Math.E, x) + Math.Pow(2, -x) + 2 * Math.Cos(x) - 6;
        }

        public static double FuncSin2(double x)
        {
            return Math.Sin(x) + x - 2;
        }

        public static double FuncExp2(double x)
        {
            return x * Math.Pow(Math.E, x) - 1;
        }
    }
}
