using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_Lab2.Entities
{
    internal class Wages : Employee
    {
        private double rate;

        public double Rate
        {
            get { return rate; }
        }

        public Wages(string id, string name, double rate)
        {
            this.id = id;
            this.name = name;
            this.rate = rate;
        }
    }
}
