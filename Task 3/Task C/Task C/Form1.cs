using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_C
{
    public partial class Form1 : Form
    {
        Dictionary<string, Student> students;
        public Form1()
        {
            InitializeComponent();
            students = new Dictionary<string, Student>();
        }

        private void StudentsList()
        {
            StudentListBox.Items.Clear();

            foreach (Student student in students.Values)
            {
                StudentListBox.Items.Add($"Student ID {student.Id}, {student.Name} has enrollment status {student.EnrolledStatus}");
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            string id = IdTextBox.Text;
            string name = NameTextBox.Text;

            if (students.ContainsKey(id))
            {
                MessageBox.Show("Error: ID already exists!");
                return;
            }

            Student newStudent = new Student(name, id, true);
            students[newStudent.Id] = newStudent;
            StudentsList();
            DisplayAllStudents();
            IdTextBox.Clear();
            NameTextBox.Clear();
            PreviewLabel.Text = $"New student: ID {newStudent.Id}, {newStudent.Name} enrolled successfully!";
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string id = IdTextBox.Text;

            if (!students.ContainsKey(id))
            {
                MessageBox.Show("Error: Not Found!");
                return;
            }

            students.Remove(id);
            StudentsList();
            DisplayAllStudents();
            IdTextBox.Clear();
            NameTextBox.Clear();

            PreviewLabel.Text = $"Student with ID {id} removed successfully!";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string id = IdTextBox.Text;
            bool enrolledStatus = EnrolledCheckBox.Checked;

            if (!students.ContainsKey(id))
            {
                MessageBox.Show("Error not found!");
                return;
            }

            students[id].EnrolledStatus = enrolledStatus;
            StudentsList();
            DisplayAllStudents();
            IdTextBox.Clear();
            EnrolledCheckBox.Checked = false;
            MessageBox.Show($"Student {id}, enrollment status updated!");
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            string id = IdTextBox.Text;

            if (!students.ContainsKey(id))
            {
                MessageBox.Show("Error, not found!");
                return;
            }

            bool enrolledStatus = students[id].EnrolledStatus;
            IdTextBox.Clear();
            EnrolledCheckBox.Checked = false;
            MessageBox.Show($"Student {id}, enrollment status is {enrolledStatus}");
            StudentListBox.Items.Add($"Student {id}, enrollment status is {enrolledStatus}");
        }

        private void DisplayNameButton_Click(object sender, EventArgs e)
        {
            StudentListBox.Items.Clear();
            string name = NameTextBox.Text;

            var studentsByName = students.Values.Where(s => s.Name.Equals(name)).ToList(); 
            
            if (!studentsByName.Any())
            {
                MessageBox.Show($"{name} not found!");
            }
            else
            {
                foreach (Student student in studentsByName)
                {
                    StudentListBox.Items.Add($"Student ID {student.Id}, Enrolled: {student.EnrolledStatus}");
                }
            }
        }

        private void StudentStatusButton_Click(object sender, EventArgs e)
 
            {
            StudentListBox.Items.Clear();
            
            var enrolledStudents = students.Values.Where(s => s.EnrolledStatus);

            if (!enrolledStudents.Any())
            {
                MessageBox.Show("No enrolled students found.");
            }
            else
            {
                StudentListBox.Items.Add("_____Enrolled Student List_____");
                foreach (Student student in enrolledStudents)
                {
                    StudentListBox.Items.Add($"Student ID {student.Id}, {student.Name}, Enrolled: {student.EnrolledStatus}");
                }
            }
        }

        private void DisplayAllStudents()
        {
            StudentListBox.Items.Clear();

            foreach (Student student in students.Values)
            {
                StudentListBox.Items.Add($"ID: {student.Id}, Name: {student.Name}, Enrolled: {student.EnrolledStatus}");
            }
        }
    }
}
