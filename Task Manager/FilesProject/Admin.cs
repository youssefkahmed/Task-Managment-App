using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesProject
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login L = new Login();
            L.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TasksForm tf = new TasksForm();
            tf.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeesMenu E = new EmployeesMenu();
            E.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectForm pf = new ProjectForm();
            pf.Show();
        }
    }
}
