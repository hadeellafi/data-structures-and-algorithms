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
        public Dictionary<T, Vertex<T>> Vertices { get; set; }

        private int _size = 0;
        public Graph()
        {
            AdjacenceyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
            Vertices= new Dictionary<T, Vertex<T>>();
        }
        public Vertex<T> AddVertex(T value)
        {
            Vertex<T> node = new Vertex<T>(value);
            AdjacenceyList.Add(node, new List<Edge<T>>());
            Vertices.Add(value, node);
            _size++;
            return node;
        }

        public void AddDirectEdge(Vertex<T> a, Vertex<T> b, int? w = null) 
        {
            if (Contains(a) && Contains(b))
            {
                AdjacenceyList[a].Add(new Edge<T>
                {
                    weight = w ?? 0,
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
        public List<Vertex<T>> DepthFirst(Vertex<T> node)
        {
            Stack<Vertex<T>> stack = new Stack<Vertex<T>>();
            List<Vertex<T>> visited = new List<Vertex<T>>();
            HashSet<Vertex<T>> visitedSet = new HashSet<Vertex<T>>();

            stack.Push(node);

            while (stack.Count > 0)
            {
                Vertex<T> current = stack.Pop();

                if (!visitedSet.Contains(current))
                {
                    visited.Add(current);
                    visitedSet.Add(current);

                    foreach (var edge in AdjacenceyList[current])
                    {
                        if (!visitedSet.Contains(edge.Vertex))
                        {
                            stack.Push(edge.Vertex);
                        }
                    }
                }
            }

            return visited;
        }


    }
}
