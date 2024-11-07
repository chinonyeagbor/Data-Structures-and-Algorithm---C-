using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    internal class Customer
    {
        private string name;
        private string age;


        public Customer(string name, string age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public string GetCustomer()
        {
            return this.name + " aged " + this.age + ".";
        }
    }

}
