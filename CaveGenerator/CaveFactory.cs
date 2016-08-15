// @author: Atanasiu Alexandru-Marian
// @created: 15/08/2016
// @updated: 15/08/2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveGenerator {
    public class CaveFactory {
        
    }


    /* Unoriented Graph Class */
    class Graph {
        private LinkedList<GraphNode> _nodes;
        public LinkedList<GraphNode> Nodes {
            get { return _nodes; }
        }

        public Graph (int numberOfNodes) {
            _nodes = new LinkedList<GraphNode>();

            for (int i = 0; i < numberOfNodes; i++) {
                _nodes.AddLast(new GraphNode());
            }
        }

        public Graph () {
            _nodes = new LinkedList<GraphNode>();
        }

        public void AddNode () {
            _nodes.AddLast(new GraphNode());
        }

        public void AddLink (int i, int j) {
            if (i < _nodes.Count && j < _nodes.Count) {
                GraphNode first = _nodes.ElementAt(i);
                GraphNode second = _nodes.ElementAt(j);

                first.addNode(second);
                second.addNode(first);
            }
        }

        public void RemoveLink (int i, int j) {
            if (i < _nodes.Count && j < _nodes.Count) {
                GraphNode first = _nodes.ElementAt(i);
                GraphNode second = _nodes.ElementAt(j);

                first.removeNode(second);
                second.removeNode(first);
            }
        }
    }

    /* Unoriented graph node class */
    class GraphNode {
        private LinkedList<GraphNode> _neighbours;
        public LinkedList<GraphNode> Neighbours {
            get { return _neighbours; }
        }

        public GraphNode () {
            _neighbours = new LinkedList<GraphNode>();
        }

        public void addNode (GraphNode node) {
            _neighbours.AddLast(node);
        }

        public void removeNode (GraphNode node) {
            _neighbours.Remove(node);
        }
    }

}
