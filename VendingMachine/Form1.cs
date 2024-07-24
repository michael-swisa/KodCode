using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        private DrinkManeger drinkManeger;

        public Form1()
        {
            InitializeComponent();
            XmlDocument DrinksDocument = MainProject.Main();
            drinkManeger = new DrinkManeger(DrinksDocument);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtPrice.Text = (float.Parse(txtPrice.Text) + 0.5).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtPrice.Text = (float.Parse(txtPrice.Text) - 0.5).ToString();
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            List<List<string>> drinksList = drinkManeger.GetDrinksData();
            foreach (List<string> drink in drinksList)
            {
                dataGridView1.Rows.Add(drink.ToArray());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> newDrink = new List<string>();
            newDrink.Add(txtName.Text);
            newDrink.Add(CBSoger.Text);
            newDrink.Add(CBCoffee.Text);
            newDrink.Add(CBMilk.Text);
            newDrink.Add(CBCacao.Text);
            newDrink.Add(txtPrice.Text);

            drinkManeger.AddDrink(newDrink);
            dataGridView1.Rows.Add(newDrink.ToArray());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            drinkManeger.Save();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (txtName.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                {
                    DialogResult result = MessageBox.Show(
                        "האם ברצונך לעדכן את המוצר?",
                        "עדכון מוצר",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        CBSoger.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        CBCoffee.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        CBMilk.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        CBCacao.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        txtPrice.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

                        btnUpdate.Visible = true;
                    }

                    break;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult result = MessageBox.Show(
                    "האם ברצונך לעדכן את המוצר?",
                    "עדכון מוצר",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    CBSoger.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    CBCoffee.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    CBMilk.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    CBCacao.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                    btnUpdate.Visible = true;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> newDrink = new List<string>();
            newDrink.Add(txtName.Text);
            newDrink.Add(CBSoger.Text);
            newDrink.Add(CBCoffee.Text);
            newDrink.Add(CBMilk.Text);
            newDrink.Add(CBCacao.Text);
            newDrink.Add(txtPrice.Text);

            drinkManeger.UpdateDrink(newDrink);

            UpdateDataGridView();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "האם ברצונך למחוק את המוצר?",
                "עדכון מוצר",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                drinkManeger.DelDrink(txtName.Text);
                UpdateDataGridView();
            }
        }
    }
}
