using System.Collections.Generic;

namespace Fase4NombreApellido
{
    public class ArbolBinario
    {
        private Nodo raiz;

        public Nodo Raiz => raiz;

        public void Insertar(int valor)
        {
            raiz = InsertarRecursivo(raiz, valor);
        }

        private Nodo InsertarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null)
                return new Nodo(valor);

            if (valor < nodo.Valor)
                nodo.Izquierda = InsertarRecursivo(nodo.Izquierda, valor);
            else if (valor > nodo.Valor)
                nodo.Derecha = InsertarRecursivo(nodo.Derecha, valor);

            return nodo;
        }

        // Método para obtener la altura del árbol
        public int ObtenerAltura()
        {
            return CalcularAltura(raiz);
        }

        private int CalcularAltura(Nodo nodo)
        {
            if (nodo == null) return 0;
            return 1 + System.Math.Max(
                CalcularAltura(nodo.Izquierda),
                CalcularAltura(nodo.Derecha)
            );
        }

        // Resto de métodos (Existe, Preorden, Inorden, Postorden)
        public bool Existe(int valor)
        {
            return ExisteRecursivo(raiz, valor);
        }

        private bool ExisteRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null) return false;
            if (nodo.Valor == valor) return true;
            return valor < nodo.Valor ?
                ExisteRecursivo(nodo.Izquierda, valor) :
                ExisteRecursivo(nodo.Derecha, valor);
        }

        public string Preorden()
        {
            List<int> resultado = new List<int>();
            PreordenRecursivo(raiz, resultado);
            return string.Join(" ", resultado);
        }

        private void PreordenRecursivo(Nodo nodo, List<int> lista)
        {
            if (nodo == null) return;
            lista.Add(nodo.Valor);
            PreordenRecursivo(nodo.Izquierda, lista);
            PreordenRecursivo(nodo.Derecha, lista);
        }

        public string Inorden()
        {
            List<int> resultado = new List<int>();
            InordenRecursivo(raiz, resultado);
            return string.Join(" ", resultado);
        }

        private void InordenRecursivo(Nodo nodo, List<int> lista)
        {
            if (nodo == null) return;
            InordenRecursivo(nodo.Izquierda, lista);
            lista.Add(nodo.Valor);
            InordenRecursivo(nodo.Derecha, lista);
        }

        public string Postorden()
        {
            List<int> resultado = new List<int>();
            PostordenRecursivo(raiz, resultado);
            return string.Join(" ", resultado);
        }

        private void PostordenRecursivo(Nodo nodo, List<int> lista)
        {
            if (nodo == null) return;
            PostordenRecursivo(nodo.Izquierda, lista);
            PostordenRecursivo(nodo.Derecha, lista);
            lista.Add(nodo.Valor);
        }
    }
}