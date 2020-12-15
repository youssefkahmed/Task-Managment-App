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
    public partial class editProjectMenu : Form
    {
        public editProjectMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            editProject1 cn = new editProject1();
            cn.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            editProject2 ct = new editProject2();
            ct.Show();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            ProjectForm pf = new ProjectForm();
            pf.Show();
            this.Close();
        }
    }
}
