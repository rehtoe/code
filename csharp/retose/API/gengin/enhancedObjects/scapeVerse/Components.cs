using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accessor.assets.enhancedObjects.GENERAL;

namespace accessor.assets.enhancedObjects.scapeVerse {

    /// <summary>
    /// objects either 3d planes even points to attach stuff to
    /// </summary>
    class obj : object {
        // VARIABLES
        public string Name { get; set; }
        Component[] attachments { get; set; }
        // INITIALIZERS
        public obj() {
            Name = " ";
            attachments = new Component[0];
            Component comp = new Layer("main");
            add(comp);
            comp = new Transform();
            add(comp);
        }
        public obj(string Label) {
            Name = Label;
            attachments = new Component[0];
            Component comp = new Layer("main");
            add(comp);
            comp = new Transform();
            add(comp);
        }
        // LOGIC
        public void add(Component compp) {
            Component[] ph = attachments;
            attachments = new Component[ph.Length + 1];
            for (int i = 0; i < ph.Length; i++) {
                attachments[i] = ph[i];
            }
            attachments.Append(compp);
        }
        public bool has(string name) {
            foreach (Component c in attachments) {
                if (name == c.label) {
                    return true;
                }
            }
            return false;
        }
        public bool has(Component cc) {
            foreach (Component c in attachments) {
                if (c.label == cc.label) {
                    return true;
                }
            }
            return false;     
        }
        public Component get(string name) {
            if (has(name)) {
                foreach (Component c in attachments) {
                    if (name == c.label) {
                        return c;
                    }
                }
            }
            return null;
        }
    }



    /// <summary>
    /// data or code attached to objects
    /// </summary>
    class Component {
        public string label { get; set; }
        public Component() {
            label = " ";
        }
        public Component(string name) {
            label = name;
        }
    }
    /*
     * LAYER 
    */
    class Layer : Component {
        public bool isVisible { get; set; }
        public Layer() {
            label = "layer";
            isVisible = true;
        }
        public Layer(string name) {
            label = name;
            isVisible = true;
        }
    }
    /*
     * TRANSFORM
    */
    class Transform : Component {
        public Position position { get; set; }
        public Rotation rotation { get; set; }
        public Scale scale { get; set; }

        public Transform() {
            label = "transform";
            position = new Position();
            rotation = new Rotation();
            scale = new Scale();
        }
        public Transform(string name) {
            label = name;
            position = new Position();
            rotation = new Rotation();
            scale = new Scale();
        }
    }

    class Position : Transform {
        public num X { get; set; }
        public num Y { get; set; }
        public num Z { get; set; }
        public Position() {
            label = "position";
            X = new num();
            Y = new num();
            Z = new num();
        }
        public Position(string name) {
            label = name;
            X = new num();
            Y = new num();
            Z = new num();
        }
    }
    class Rotation : Transform {
        public num X { get; set; }
        public num Y { get; set; }
        public num Z { get; set; }
        public Rotation() {
            label = "rotation";
            X = new num();
            Y = new num();
            Z = new num();
        }
        public Rotation(string name) {
            label = name;
            X = new num();
            Y = new num();
            Z = new num();
        }
    }
    class Scale : Transform {
        public num X { get; set; }
        public num Y { get; set; }
        public num Z { get; set; }
        public Scale() {
            label = "scale";
            X = new num();
            Y = new num();
            Z = new num();
        }
        public Scale(string name) {
            label = name;
            X = new num();
            Y = new num();
            Z = new num();
        }
    }
}
