using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafoAct
{
    internal class Grafo
    {
        private int V; // Número de vértices
        private List<int>[] adyacencia; // Lista de adyacencia

        // Constructor
        public Grafo(int v)
        {
            V = v;
            adyacencia = new List<int>[v];
            for (int i = 0; i < v; ++i)
            {
                adyacencia[i] = new List<int>();
            }
        }

        // Método para agregar una arista al grafo no dirigido
        public void AgregarArista(int v, int w)
        {
            adyacencia[v].Add(w);
            adyacencia[w].Add(v);
        }

        // Método para imprimir el grafo
        public void ImprimirGrafo()
        {
            for (int i = 0; i < V; ++i)
            {
                Console.Write("Vértice " + i + ": ");
                foreach (var adyacente in adyacencia[i])
                {
                    Console.Write(adyacente + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
