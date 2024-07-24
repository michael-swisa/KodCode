using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workers
{
    public partial class Form1 : Form
    {
        private Employee[] listWorkers = new Employee[0];
        private int counterCode = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textPon_TextChanged(object sender, EventArgs e) { }

        private Employee CreateWorker()
        {
            Employee worker = new Employee(
                //int.Parse(txtCode.Text),
                ++counterCode,
                int.Parse(txtId.Text),
                txtName.Text,
                txtLastName.Text,
                dateBirth.Value,
                txtPhone.Text,
                txtMobilePhone.Text,
                txtStreet.Text,
                byte.Parse(txtHouseNumber.Text),
                txtCity.Text,
                GetGender(),
                GetStatus()
            );
            return worker;
        }

        private void AddWorkerInList(Employee worker)
        {
            Employee[] tmpArray = new Employee[listWorkers.Length + 1];
            for (int i = 0; i < listWorkers.Length; i++)
            {
                tmpArray[i] = listWorkers[i];
            }
            tmpArray[listWorkers.Length] = worker;
            listWorkers = tmpArray;

            //ClearForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee worker = CreateWorker();
            AddWorkerInList(worker);

            //for (int i = 0; i < listWorkers.Length; i++)
            //{
            //    Console.WriteLine(listWorkers[i].ToString());
            //}
        }

        private bool GetGender()
        {
            if (rbMale.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetStatus()
        {
            if (rbBachelor.Checked == true)
            {
                return "Bachelor";
            }
            else if (rbMarried.Checked == true)
            {
                return "Married";
            }
            else if (rbDivorcee.Checked == true)
            {
                return "divorcee";
            }
            else
            {
                return "widower";
            }
        }

        private void PrintingEmployeeDetails(Employee worker)
        {
            txtCode.Text = worker.Code.ToString();
            txtId.Text = worker.Id.ToString();
            txtName.Text = worker.FirstName;
            txtLastName.Text = worker.LastName;
            dateBirth.Value = worker.BirthDay;
            txtAgi.Text = worker.Age.ToString();
            txtPhone.Text = worker.Phone.ToString();
            txtMobilePhone.Text = worker.Phone.ToString();
            txtStreet.Text = worker.Street;
            txtHouseNumber.Text = worker.NumberHome.ToString();
            txtCity.Text = worker.City;

            if (worker.IsMale == true)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            if (worker.Status == "Bachelor")
            {
                rbBachelor.Checked = true;
            }
            else if (worker.Status == "Married")
            {
                rbMarried.Checked = true;
            }
            else if (worker.Status == "divorcee")
            {
                rbDivorcee.Checked = true;
            }
            else
            {
                rbWidower.Checked = true;
            }
        }

        private void btnScode_Click(object sender, EventArgs e)
        {
            Employee[] worker = new Employee[1];
            for (int i = 0; i < listWorkers.Length; i++)
            {
                if (listWorkers[i].Code == int.Parse(txtCode.Text))
                {
                    worker[0] = listWorkers[i];
                    if (worker[0] != null)
                    {
                        PrintingEmployeeDetails(worker[0]);
                    }
                    ;
                }
            }
        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            //Employee[] worker = new Employee[1];
            //for (int i = 0; i < listWorkers.Length; i++)
            //{
            //    if (listWorkers[i].Id == int.Parse(txtId.Text))
            //    {
            //        worker[0] = listWorkers[i];
            //        if (worker[0] != null)
            //        {
            //            PrintingEmployeeDetails(worker[0]);
            //        }
            //    }
            //}
            Array.Find(listWorkers, workers => workers.Id == int.Parse(txtId.Text));
        }

        int counter = 0;

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (listWorkers.Length > 0)
            {
                if (counter > 0)
                {
                    counter--;
                    if (listWorkers[counter] == null)
                    {
                        counter--;
                    }
                    PrintingEmployeeDetails(listWorkers[counter]);
                }
                else
                {
                    PrintingEmployeeDetails(listWorkers[counter]);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listWorkers.Length > 0)
            {
                if (counter < listWorkers.Length - 1)
                {
                    counter++;
                    if (listWorkers[counter] == null)
                    {
                        counter++;
                    }
                    PrintingEmployeeDetails(listWorkers[counter]);
                }
                else
                {
                    PrintingEmployeeDetails(listWorkers[counter]);
                }
            }
        }

        private void ClearForm()
        {
            txtCode.Text = "";
            txtId.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            txtAgi.Text = "";
            txtPhone.Text = "";
            txtMobilePhone.Text = "";
            txtStreet.Text = "";
            txtHouseNumber.Text = "";
            txtCity.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbBachelor.Checked = false;
            rbMarried.Checked = false;
            rbDivorcee.Checked = false;
            rbWidower.Checked = false;
            dateBirth.Value = DateTime.Now;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //txtCode.Text = "";
            //txtId.Text = "";
            //txtName.Text = "";
            //txtLastName.Text = "";
            //txtAgi.Text = "";
            //txtPhone.Text = "";
            //txtMobilePhone.Text = "";
            //txtStreet.Text = "";
            //txtHouseNumber.Text = "";
            //txtCity.Text = "";
            //rbMale.Checked = false;
            //rbFemale.Checked = false;
            //rbBachelor.Checked = false;
            //rbMarried.Checked = false;
            //rbDivorcee.Checked = false;
            //rbWidower.Checked = false;
            //dateBirth.Value = DateTime.Now;

            ClearForm();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listWorkers.Length; i++)
            {
                if (listWorkers[i].Code == int.Parse(txtCode.Text))
                {
                    listWorkers[i] = CreateWorker();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listWorkers.Length; i++)
            {
                if (listWorkers[i].Code == int.Parse(txtCode.Text))
                {
                    listWorkers[i] = null;
                    break;
                }
            }
        }
    }
}
