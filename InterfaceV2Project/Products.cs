using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceV2Project {
    class Products : ICalcSales {

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; } 
        public int Units { get; set; }

        public decimal CalcSales() {
            return Price * Units;
        }

        public string About() {
            return "About Products";
        }

        public Products(int ID, string Name, decimal Price, int Units) {
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;
            this.Units = Units;
        


        }
    }
}
