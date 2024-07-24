using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shabat_food_host;

namespace shabat_food_custumer
{
    public partial class Form2 : Form
    {
        public List<Form2> forms2;
        public int positon2;

        public Form2(List<Form2> forms, int positon, string categoryName)
        {
            InitializeComponent();
            forms2 = forms;
            positon2 = positon;
            label1.Text = categoryName;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Shabat_meneger.CategoryOrders(label1.Text, dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (positon2 == 0)
            {
                this.Visible = false;
                forms2[forms2.Count - 1].Visible = true;
            }
            else
            {
                this.Visible = false;
                forms2[positon2 - 1].Visible = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (positon2 == forms2.Count - 1)
            {
                this.Visible = false;
                forms2[0].Visible = true;
            }
            else
            {
                forms2[positon2 + 1].Visible = true;
                this.Visible = false;
            }
        }
    }
}
