using System;

namespace Metodos.Types
{
    /// <summary>
    /// Una clase que define un intervalo
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Intervalo<T>
    {
        public T inicio { get; set; }
        public T fin { get; set; }

        public Intervalo() { }
        public Intervalo(T inicio, T fin)
        {
            this.inicio = inicio;
            this.fin = fin;
        }
        public Intervalo(Intervalo<T> copia)
        {
            inicio = copia.inicio;
            fin = copia.fin;
        }

    }
}
