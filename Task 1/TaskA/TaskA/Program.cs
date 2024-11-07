using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array of student object
            Student[] students = new Student[10];

            //List of studdents to be added
            students[0] = new Student("Stephen Coven", "SN001", 18);
            students[1] = new Student("John Doe", "SN002", 19);
            students[2] = new Student("Ann Colt", "SN003", 20);
            students[3] = new Student("Chinonye Agbor", "SN004", 21);
            students[4] = new Student("Grace Bell", "SN005", 22);
            students[5] = new Student("Elun Musk", "SN006", 23);
            students[6] = new Student("Bill Gates", "SN007", 24);
            students[7] = new Student("Ben Johnson", "SN008", 25);
            students[8] = new Student("Donald Trump", "SN009", 26);
            students[9] = new Student("Denzel Washington", "SN010", 27);



            foreach (Student student in students)
            {
                Console.WriteLine(student.GetInformation());
            }
            Console.ReadLine();
        }
    }
}
