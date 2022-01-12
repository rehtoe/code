using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessor.assets.enhancedObjects.scapeVerse {
    class Tree {
        public Dictionary<Path, Node> references { get; set; }
        public Node Current { get; set; }
        public Tree() {
            references = new Dictionary<Path, Node>();
        }

        public void link(Node host, Node newb) {
            references.Add(new Path(host, newb), newb);
        }
        public Node get(Path p) {
            List<Node> nodes = new List<Node>();
            foreach(Path iin in references.Keys) {
                if (nodes.Contains(iin.From)) {
                    p.To = iin.To;
                }
            }
            return p.To;
        }
        public bool has(Node key) {
            return references.Values.Contains(Current);
        }
        public void Create(int level, obj o) {
            Node nn = new Node(level);
            nn.data = o;
        }
        public void Verify() {

        }
    }

    class Node {
        public bool isRoot { get; }
        public int id { get; }
        public int level { get; set; }
        public obj data { get; set; }
        public Node() {
            id = new Random().Next(0, 999999999);
            data = new obj();
            isRoot = root();
        }
        public Node(Node getID) {
            id = getID.id;
            level = getID.level + 1;
            data = new obj();
        }
        public Node(int baseLevel) {
            id = new Random().Next(0, 999999999);
            level = baseLevel;
            data = new obj();
        }
        bool root() {
            switch (level) {
                default:
                    return false;
            }
        }
    }

    class Path {
        public Node From { get; set; }
        public Node To { get; set; }
        public Path(Node a, Node b) {
            From = a;
            To = b;
        }
        
    }
}
