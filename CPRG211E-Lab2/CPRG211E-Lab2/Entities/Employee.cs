using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CPRG211E_Lab2.Entities
{
    internal class Employee
    {
        protected string id;
        protected string name;

        public string Id
        {
            get { return id; }
        }

        public string Name
        {
            get => name;
        }

        public Employee() 
        {
        }

        public Employee(string id, string name) 
        {
            this.id = id;
            this.name = name;
        }   
    }
}
