using System;
using Metodos.Types;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parámetros
            Func<double, double> func = Funciones.FuncExp2;
            double inicioEval = -3, finEval = 3, step = 1;
            int iteraciones = 3;

            // Obtenemos la tabla con los intervalos donde cambia de signo
            var intervalos = MetodosNoLineales.BuscarIntervalos(inicioEval, finEval, step, func);

            // Por bisección
            Console.WriteLine("\n=== Bisección ===");
            foreach (Intervalo<double> intervalo in intervalos)
            {
                double output = MetodosNoLineales.Biseccion(intervalo, func, iteraciones);

                Console.WriteLine($"Intervalo [{intervalo.inicio}, {intervalo.fin}]:");
                Console.WriteLine($"Aproximación: {output}, Error relativo: { MetodosNoLineales.ErrorRelativo }");
            }

            // Por Regla Falsa
            Console.WriteLine("\n=== Regla Falsa ===");
            foreach (Intervalo<double> intervalo in intervalos)
            {
                double output = MetodosNoLineales.ReglaFalsa(intervalo, func, iteraciones);

                Console.WriteLine($"Intervalo [{intervalo.inicio}, {intervalo.fin}]:");
                Console.WriteLine($"Aproximación: {output}, Error relativo: { MetodosNoLineales.ErrorRelativo }");
            }
        }
    }
}
