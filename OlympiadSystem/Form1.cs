using OlympiadSystem.Domain;
using OlympiadSystem.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlympiadSystem
{
    public partial class formPersonInfo : Form
    {
        IStudentManager StudentManager; 

        public formPersonInfo()
        {
            InitializeComponent();
            StudentManager = new StudentManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            var result = Int32.TryParse(textBoxAge.Text,out age);
            if (!result)
            {
                MessageBox.Show("Было введено некорректное значение для возраста!");
            }
            else
            {
                StudentManager.AddStudent(new Student() { FirstName = textBoxName.Text, LastName = textBoxLastName.Text, Age = age, University = textBoxSchool.Text });
                StudentManager.WriteStudents();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelAge_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
