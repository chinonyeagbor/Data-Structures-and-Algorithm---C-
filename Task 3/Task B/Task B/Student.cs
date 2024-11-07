using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    internal class Student
    {
        //public class Student

        private string name;
        private string id;
        private bool enrolledStatus;


        public Student(string name, string id, bool enrolledStatus)
        {
            this.name = name;
            this.id = id;
            this.enrolledStatus = enrolledStatus;
        }

        public string Name //property(s)
        {
            get { return name; }
            set { name = value; }
        }

        public string Id //property(s)
        {
            get { return id; }
            set { id = value; }
        }

        public bool EnrolledStatus
        {
            get { return enrolledStatus; }
            set { enrolledStatus = value; }
        }
    }
}

    
