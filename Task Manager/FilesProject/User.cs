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
    public partial class User : Form
    {
        string username;

        public User(string uname)
        {
            username = uname;
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void MyTasks_Click(object sender, EventArgs e)
        {
            MyTasks mt = new MyTasks(username);
            mt.Show();
            this.Close();
        }
    }
}
