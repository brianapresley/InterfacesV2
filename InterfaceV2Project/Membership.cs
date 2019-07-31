using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceV2Project {
    class Membership : ICalcSales {

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public int Units { get; set; }

        public decimal CalcSales() {
            return Fee * Units;
        }

        public string About() {
            return "About Products";
        }

        public Membership(int ID, string Name, decimal Fee, int Units) {
            this.ID = ID;
            this.Name = Name;
            this.Fee = Fee;
            this.Units = Units;
        }
    }
}


/* To use multiple cursors press Alt + Shift + Arrow Keys 
 * To use multiple cursors press Alt + Shift + Arrow Keys 
 * To use multiple cursors press Alt + Shift + Arrow Keys 
 * To use multiple cursors press Alt + Shift + Arrow Keys 
 * To use multiple cursors press Alt + Shift + Arrow Keys 
 * To use multiple cursors press Alt + Shift + Arrow Keys 
 * OR CTRL + Alt and click where you want the multiple cursors to go */

 