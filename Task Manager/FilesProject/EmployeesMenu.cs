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
using System.IO;

namespace FilesProject
{
    public partial class EmployeesMenu : Form
    {
        public EmployeesMenu()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeesMenu_Load(object sender, EventArgs e)
        {

        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            ae.Show();
            
        }

        private void Display_Click(object sender, EventArgs e)
        {
            DisplayEmployees d = new DisplayEmployees();
            d.Show();
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            deleteEmp de = new deleteEmp();
            de.Show();
            this.Close();
        }
    }
}
