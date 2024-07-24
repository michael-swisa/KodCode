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
using System.Xml.Linq;

namespace Rabbinate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> MyList()
        {
            List<string> newList = new List<string>();
            newList.Add(CBDayWeek.Text);
            newList.Add(CBDayMonth.Text);
            newList.Add(CBMonth.Text);
            newList.Add(CBYear.Text);
            return newList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = RabbinateManeger.GetToString(MyList());
            MessageBox.Show(result);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RabbinateManeger.Save(MyList());
        }
    }
}
