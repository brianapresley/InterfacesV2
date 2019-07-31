using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceV2Project {
    class Services : ICalcSales {

        public int ID { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public int Hours { get; set; }

        public decimal CalcSales() {
            return Rate * Hours;
        }

        public string About() {
            return "About Services";
        }

        public Services(int ID, string Name, int Rate, int Hours) {
            this.ID = ID;
            this.Name = Name;
            this.Rate = Rate;
            this.Hours = Hours;
        }

    }

}

