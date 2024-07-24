using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClock
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = EmployeeManager.ChangePassword(
                txtId.Text,
                txtOldPass.Text,
                txtNewPass.Text,
                txtNewPass2.Text
            );
            MessageBox.Show(result);
        }
    }
}
