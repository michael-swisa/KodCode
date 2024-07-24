using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shabat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pillar pillar = new Pillar();
            pillar.Heigth = int.Parse(txth.Text);
            pillar.Width = int.Parse(txtw.Text);
            if (RH.Checked)
            {
                pillar.Location = "RH";
            }
            else if (RHR.Checked)
            {
                pillar.Location = "RHR";
            }
            else if (CAR.Checked)
            {
                pillar.Location = "CAR";
            }
            string status = pillar.GetStatus();
            Console.WriteLine(status);
            MessageBox.Show(status);
        }
    }
}
