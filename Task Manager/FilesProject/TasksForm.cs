using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FilesProject
{
    public partial class TasksForm : Form
    {
        public TasksForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddTask at = new AddTask();
            at.Show();
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad = new Admin();
            ad.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            editProject2 et = new editProject2();
            et.Show();
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteTask dt = new DeleteTask();
            dt.Show();
            this.Close();
        }

        private void History_Click(object sender, EventArgs e)
        {
            if (File.Exists("TaskHistory.xml"))
            {
                System.Diagnostics.Process.Start("C:\\Users\\Joe\\Documents\\Visual Studio 2012\\Projects\\FilesProject\\FilesProject\\bin\\Debug\\TaskHistory.xml");
            }

            else
            {
                MessageBox.Show("There Are No Tasks!");
            }
        }
    }
}
