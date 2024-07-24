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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;
            string result = EmployeeManager.Login(txtId.Text, txtPassword.Text, txtFullName.Text);
            MessageBox.Show(result);
        }

        private void btnChingPass_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword();
            frm.Show();
        }

        private void btnYourClock_Click(object sender, EventArgs e)
        {
            YourTime frm = new YourTime();
            frm.Show();
        }
    }
}
