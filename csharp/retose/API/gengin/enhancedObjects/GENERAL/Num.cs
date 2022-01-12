using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessor.assets.enhancedObjects.GENERAL {
    class objEnhanced : object {
        public Type varType { get; set; }
        public objEnhanced() {
            varType = typeof(object);
        }
        public objEnhanced(Type t) {
            varType = t;
        }
    }

    class mod {
        public bool isActive { get; set; }
        public string name { get; set; }
        public mod() {
            isActive = false;
            name = "n/a";
        }
        public mod(string label) {
            isActive = false;
            name = label;
        }
        public decimal code(decimal dec) {
            return dec;
        }
    }
    class integer : mod {
        public integer() {
            isActive = false;
            name = "integer";
        }
        public integer(bool Active) {
            isActive = Active;
            name = "integer";
        }
        public new decimal code(decimal dec) {
            return (Int64) dec;
        }
    }
    class range : mod {
        public decimal lowerBound { get; set; }
        public decimal upperBound { get; set; }
        public range() {
            lowerBound = 0;
            upperBound = 0;
            isActive = false;
            name = "range";
        }
        public range(decimal lowerBoundry, decimal upperBoundry) {
            lowerBound = lowerBoundry;
            upperBound = upperBoundry;
            isActive = true;
            name = "range";
        }
        public new decimal code(decimal dec) {
            if(dec < lowerBound) {
                return lowerBound;
            }else if(dec > upperBound) {
                return upperBound;
            } else {
                return dec;
            }
        }
    }
    class loop : mod {
        public range bounds { get; set; }
        public loop() {
            bounds = new range();
            isActive = false;
            name = "loop";
        }
        public loop(range Boundries) {
            bounds = Boundries;
            isActive = false;
            name = "loop";
        }
        public new decimal code(decimal dec) {
            if (dec < bounds.lowerBound) {
                decimal ph = bounds.lowerBound - dec;
                return bounds.upperBound - ph;
            } else if (dec > bounds.upperBound) {
                decimal ph = dec - bounds.upperBound;
                return bounds.lowerBound + ph;
            } else {
                return dec;
            }
        }
    }
    class nbase : mod {
        public decimal baseOf { get; set; }
        public nbase() {
            baseOf = 10;
            isActive = false;
            name = "nbase";
        }
        public nbase(decimal BaseOf) {
            baseOf = BaseOf;
            isActive = true;
            name = "nbase";
        }
        public new decimal code(decimal dec) {
            decimal number = 0;
            string NUMBER = "";
            decimal Ph1 = dec;
            int maxPower = 0, phPower = 0;
            while (number == 0) {
                while (Ph1 != 0) {
                    if (Ph1 - (decimal)Math.Pow((double)baseOf, maxPower) < Ph1) {
                        maxPower++;
                    } else {
                        phPower = maxPower--;
                        decimal phINT = Math.Floor(Ph1 / (decimal)Math.Pow((double)baseOf, phPower));
                        NUMBER += phINT.ToString();
                        Ph1 = Ph1 % phINT;
                        break;
                    }
                }
                maxPower = 0;
                phPower = 0;
                if(Ph1 == 0) {
                    number = Convert.ToDecimal(NUMBER);
                }
            }
            return number;
        }
    }

    class num : objEnhanced {
        public decimal value { get; set; }
        public Dictionary<string, mod> mods { get; set; }
        public num() {
            varType = typeof(decimal);
            value = 0.0m;

            mods = new Dictionary<string, mod>();
            mods.Add("integer", new integer());
            mods.Add("range", new range());
            mods.Add("loop", new loop());
            mods.Add("nbase", new nbase());
        }
        public num(decimal startVal) {
            varType = typeof(decimal);
            value = startVal;

            mods = new Dictionary<string, mod>();
            mods.Add("integer", new integer());
            mods.Add("range", new range());
            mods.Add("loop", new loop());
            mods.Add("nbase", new nbase());
        }
        // ValueAte does logic for val;
        public decimal val() {
            logic();
            return value;
        }
        
        internal void logic() {
            switch (mods["integer"].isActive) {
                default:
                case false:

                    break;

                case true:
                    value = mods["integer"].code(value);
                    break;
            }
            switch (mods["range"].isActive) {
                default:
                case false:

                        break;
                
                case true:
                    value = mods["range"].code(value);
                    break;
            }
            switch (mods["loop"].isActive) {
                default:
                case false:

                    break;

                case true:
                    value = mods["loop"].code(value);
                    break;
            }
            switch (mods["nbase"].isActive) {
                default:
                case false:

                    break;

                case true:
                    value = mods["nbase"].code(value);
                    break;
            }
        }
    }
}
