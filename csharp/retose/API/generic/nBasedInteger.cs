using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.retose.API.generic{
    static class Variables {
        // nth numbers system where n is an integer between 1-9
        public struct nBasedNum {
            // VARIABLES
            // base_ is how many digits there are to base a number system on(between 1 - 9 (inclusive))
            // uses a decimal value to convert to whatever base you want
            int base_;
            int decimal_Value;
            int base_Value;
            // INITIALIZERS
            // depending on how much information you have you can update it with its methods
            //
            public nBasedNum(int base1to9) {
                base_ = base1to9;
                decimal_Value = 0;
                base_Value = 0;
            }
            public nBasedNum(int base1to9, int Decimal) {
                base_ = base1to9;
                decimal_Value = Decimal;
                base_Value = 0;
                update();
            }
            // LOGIC
            // converts a decimal number to a base n number system where 0 < n < 10 and n is an integer
            //
            void update() {
                base_Value = DecimalToNthSystem(decimal_Value, base_);
            }
            int DecimalToNthSystem(int dec, int numOfSym){
                // gets the highest nth power that can go into the decimal
                int powerOf = 0;
                while(true){
                    if(dec < Math.Pow(numOfSym, powerOf)){
                      powerOf--;
                      break;
                    }
                    powerOf++;
                }

                // the maths to Convert
                List<int> digitsOutput = new List<int>();
                int prevRemainder = dec;
                int remainder = dec;

                for(int p = powerOf; p >= 0; p--){
                  remainder = remainder%((int)Math.Pow(numOfSym, p));
                  int ph = prevRemainder - remainder;
                  digitsOutput.Add((ph/(int)Math.Pow(numOfSym, p)));
                  prevRemainder = remainder;
                }

                string num = "";
                foreach(int i in digitsOutput){
                  num += i.ToString();
                }

                int val = 0;
                Int32.TryParse(num, out val);
                return val;
            }
            // PUBLIC READ VARIABLES
            //
            //
            public int Value() {
                update();
                return base_Value;
            }
            public int ValueInDecimal() {
                return decimal_Value;
            }
            //
            //
            //
            public void newBase(int nBasedSystem) {
                base_ = nBasedSystem;
                update();
            }
            public void newDecimal(int Decimal){
                decimal_Value = Decimal;
                update();
            }
            // MATH LOGIC
            // the methods to change the value whether in base n or decimal
            //
            public void Add(int addThis) {
                decimal_Value += addThis;
                update();
            }
        }
    }
}
