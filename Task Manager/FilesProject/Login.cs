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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (utComboBox.SelectedIndex == 0)
            {
                string uName = unText.Text.ToString();
                string Pass = passText.Text.ToString();
                string type = "Admin";
                Boolean check = false;

                XmlDocument doc = new XmlDocument();
                doc.Load("Admins.xml");

                XmlNodeList List = doc.GetElementsByTagName("Admin");

                for (int i = 0; i < List.Count; i++)
                {
                    XmlNodeList children = List[i].ChildNodes;

                    if (uName.Equals(children[0].InnerText) && Pass.Equals(children[1].InnerText))
                    {
                        check = true;
                        break;
                    }
                }

                if (check == true)
                {
                    Admin A = new Admin();
                    A.Show();
                    this.Hide();
                    //this.Close();

                }

                else {
                    MessageBox.Show("Please Make Sure Username And Password Are Correct!");
                }



            }

            else if (utComboBox.SelectedIndex == 1)
            {
                string uName = unText.Text.ToString();
                string Pass = passText.Text.ToString();
                string type = "User";
                Boolean check = false;

                if (File.Exists("Employees.xml"))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("Employees.xml");

                    XmlNodeList List = doc.GetElementsByTagName("Employee");

                    for (int i = 0; i < List.Count; i++)
                    {
                        XmlNodeList children = List[i].ChildNodes;

                        if (uName.Equals(children[1].InnerText) && Pass.Equals(children[2].InnerText))
                        {
                            check = true;
                            break;
                        }
                    }

                    if (check == true)
                    {
                        User u = new User(uName);
                        u.Show();
                        this.Hide();
                        //this.Close();

                    }

                    else
                    {
                        MessageBox.Show("Please Make Sure Username And Password Are Correct!");
                    }
                }

                else {
                    MessageBox.Show("There Are No Registered Users! (Try Logging In With An Administrator Account)");
                }
            }

            else {
                MessageBox.Show("Please choose user type and enter all required data!");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
