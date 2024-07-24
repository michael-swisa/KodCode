using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shabat_food_host;

namespace shabat_food_custumer
{
    public partial class Form1 : Form
    {
        List<string> foodCategories = Shabat_meneger.GetCategories();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvit_Click(object sender, EventArgs e)
        {
            List<Form2> forms = new List<Form2>();
            List<string> categories = Shabat_meneger.GetCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                Form2 form2 = new Form2(forms, i, categories[i]);
                forms.Add(form2);
            }
            forms[0].Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // בדוק אם יש פריט נבחר
            if (listBox2.SelectedItem != null)
            {
                // עדכן את תיבת הטקסט עם הפריט הנבחר

                txtCategory.Text = listBox2.SelectedItem.ToString();
            }
        }

        private void CreationListCategories()
        {
            foodCategories = Shabat_meneger.GetCategories();
            for (int i = 0; i < foodCategories.Count; i++)
            {
                listBox2.Items.Add(foodCategories[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreationListCategories();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Shabat_meneger.AddCategory(txtCategory.Text);
            txtCategory.Text = "";
            listBox2.Items.Clear();
            CreationListCategories();
        }

        private void txtCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBox2.Items.Clear();
            if (e.KeyChar != (char)Keys.Enter)
            {
                for (int i = 0; i < foodCategories.Count; i++)
                {
                    if (e.KeyChar == (char)Keys.Delete)
                    {
                        listBox2.Items.Remove(foodCategories[i]);
                    }

                    if (foodCategories[i].StartsWith(txtCategory.Text + e.KeyChar))
                    {
                        listBox2.Items.Add(foodCategories[i]);

                        //listBox2.Items.Add($"{i + 1}. {foodCategories[i]}");
                    }
                }
            }
        }

        //private void txtCategory_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    listBox2.Items.Clear();
        //    string searchPrefix = txtCategory.Text + e.KeyChar;

        //    if (e.KeyChar != (char)Keys.Enter)
        //    {
        //        foreach (var category in foodCategories)
        //        {
        //            if (e.KeyChar == (char)Keys.Delete)
        //            {
        //                listBox2.Items.Remove(category);
        //            }

        //            if (category.StartsWith(searchPrefix))
        //            {
        //                listBox2.Items.Add(category);
        //            }
        //        }
        //    }
        //}

        private void btnDelCategory_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Shabat_meneger.DeleteCategory(txtCategory.Text);
            txtCategory.Text = "";
            CreationListCategories();
        }

        private void txtCategory_TextChanged(object sender, EventArgs e) { }
    }
}
