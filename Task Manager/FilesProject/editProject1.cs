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
    public partial class editProject1 : Form
    {
        public editProject1()
        {
            InitializeComponent();
        }

        private void EditProject1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string projectName=textBox1.Text;
            string newName = textBox2.Text;

            if (File.Exists("Projects.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Projects.xml");

                // Checks if a project with such name exists
                bool check = false;

                // Checks if there's a project that holds the new name
                bool check2 = false;

                foreach (XmlNode node in doc.SelectNodes("Projects/Project/ProjectName"))
                {
                    if (node.InnerText == newName)
                    {
                        check2 = true;
                        break;
                    }

                    else if (node.InnerText == projectName)
                    {
                        node.InnerText = newName;
                        check = true;
                    }

                }


                if (check2 == false)
                {
                    if (check)
                    {
                        doc.Save("Projects.xml");
                        MessageBox.Show("Project Name Has Been Changed Succefully!");
                    }

                    else
                    {
                        MessageBox.Show("There Is No Project With That Name!");
                    }
                }

                else
                {
                    MessageBox.Show("New Project Name Is Already Taken!");
                }
            }

            else {
                MessageBox.Show("There Are No Existing Projects!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectForm pf = new ProjectForm();
            pf.Show();
        }
    }
}
