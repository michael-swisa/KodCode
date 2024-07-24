using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace college
{
    public partial class Form1 : Form
    {
        List<string> courses = College_meneger.GetCourses();

        public Form1()
        {
            InitializeComponent();
        }

        private void CreationListCourses()
        {
            courses = College_meneger.GetCourses();
            for (int i = 0; i < courses.Count; i++)
            {
                listBox1.Items.Add(courses[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreationListCourses();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // עדכן את תיבת הטקסט עם הפריט הנבחר
                txtCours.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string preice = College_meneger.AddUser(txtFullName.Text, txtCours.Text);
            MessageBox.Show(preice);
        }
    }
}
