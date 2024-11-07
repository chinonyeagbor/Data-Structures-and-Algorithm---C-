using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_B
{
    public partial class Form1 : Form
    {
        Dictionary<string, Student> students;
        public Form1()
        {
            InitializeComponent();
            students = new Dictionary<string, Student>();
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
            IdTextBox.Clear();
            NameTextBox.Clear();

            PreviewLabel.Text = $"Student with ID {id} removed successfully!";

        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            string id = IdTextBox.Text;

            if (!students.ContainsKey(id))
            {
                MessageBox.Show("Error, not found!");
                return ;
            }

            bool enrolledStatus = students[id].EnrolledStatus;
            IdTextBox.Clear();
            EnrolledCheckBox.Checked = false;
            MessageBox.Show($"Student enrollment status is {enrolledStatus}");

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string id = IdTextBox.Text;
            bool enrolledStatus = EnrolledCheckBox.Checked;

            if (!students.ContainsKey(id))
            {
                MessageBox.Show("Error not Found");
                return;
            }

            students[id].EnrolledStatus = enrolledStatus;
            StudentsList();
            IdTextBox.Clear();
            EnrolledCheckBox.Checked = false;
            MessageBox.Show($"Student {id} enrollment status updated!");
        }

        private void StudentsList()
        {
            StudentsListBox.Items.Clear();

            foreach (Student student in students.Values)
            {
                StudentsListBox.Items.Add($"Student ID {student.Id}, {student.Name} has enrollment status {student.EnrolledStatus}");
            }
        }
    }     
}
