using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class Graph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacenceyList { get; set; }
        private int _size = 0;
        public Graph()
        {
            AdjacenceyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }
        public Vertex<T> AddVertex(T vertex)
        {
            Vertex<T> node = new Vertex<T>(vertex);

            AdjacenceyList.Add(node, new List<Edge<T>>());

            _size++;

            return node;


        }
        public void AddDirectEdge(Vertex<T> a, Vertex<T> b)//connect a with b
        {
            if (Contains(a) && Contains(b))
            {
                AdjacenceyList[a].Add(new Edge<T>
                {
                    weight = 0,
                    Vertex = b,
                });
            }
        }
        public void AddUnDirectEdge(Vertex<T> a, Vertex<T> b)
        {
            if (Contains(a) && Contains(b))
            {
                AddDirectEdge(a, b);
                AddDirectEdge(b, a);
            }
        }
        public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
        {
            return AdjacenceyList[vertex];
        }
        public int Size()
        {
            return _size;
        }

        public HashSet<T> GetVertices()
        {
            HashSet<T> result = new HashSet<T>();
            foreach (var item in AdjacenceyList)
            {
                result.Add(item.Key.Value);
            }
            return result;
        }
        public bool Contains(Vertex<T> vertex)
        {
            return AdjacenceyList.ContainsKey(vertex);
        }
        public List<Vertex<T>> BreadthFirst(Vertex<T> node)
        {
            Queue<Vertex<T>> queue = new Queue<Vertex<T>>();
            List<Vertex<T>>visited= new List<Vertex<T>>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                Vertex<T> nodeToAdd= queue.Peek();

                visited.Add(nodeToAdd);
                foreach (var item in AdjacenceyList[nodeToAdd])
                {
                    if (!visited.Contains(item.Vertex))
                    {
                        queue.Enqueue(item.Vertex);
                    }
                }
                queue.Dequeue();
            }
            return visited;
        }

    }
}
