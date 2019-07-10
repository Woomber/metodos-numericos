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

        public static double FuncParticula(double t)
        {
            return 34.78 * (1 - Math.Exp(-0.54 * t));
        }

        public static double FuncRaizReciproca(double x)
        {
            return Math.Exp(-x * x / 2) / Math.Sqrt(2 * Math.PI);
        }

        public static double FuncRaizConCubo(double x)
        {
            return Math.Sqrt(x * x * x + 4);
        }
    }
}
