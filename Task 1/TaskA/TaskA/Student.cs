using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskA
{
    internal class Student
    {
        private string name;
        private string id;
        private int age;

        public Student(string name, string id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }
        public string Name 
        { 
            get { return name; } 
            set { name = value; }
        }
        
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string GetInformation()
        {
            return "Student, " + name + " with id " + id + " is " + age + " years old.";
        }
    }
}
