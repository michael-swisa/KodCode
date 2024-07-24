using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shabat_food_custumer;

namespace ShabatFood
{
    public partial class custumer_enter : Form
    {
        List<string> listCustomers = Shabat_meneger.GetCustomers();
        string _customerName;

        public custumer_enter()
        {
            InitializeComponent();
        }

        private void btnInvit_Click(object sender, EventArgs e)
        {
            List<Form1> forms = new List<Form1>();
            List<string> categories = Shabat_meneger.GetCustomers();
            for (int i = 0; i < categories.Count; i++)
            {
                Form1 form1 = new Form1(forms, i, categories[i], _customerName);
                forms.Add(form1);
            }
            forms[0].Show();
        }

        private void CreationListCustomers()
        {
            listCustomers = Shabat_meneger.GetCustomers();
            for (int i = 0; i < listCustomers.Count; i++)
            {
                listBox2.Items.Add(listCustomers[i]);
            }
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            Shabat_meneger.AddCustomer(txtCustomer.Text);
            _customerName = txtCustomer.Text;
            listBox2.Items.Clear();
            CreationListCustomers();
        }

        private void custumer_enter_Load(object sender, EventArgs e)
        {
            CreationListCustomers();
        }
    }
}
