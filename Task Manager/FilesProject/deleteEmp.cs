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
    public partial class deleteEmp : Form
    {
        public deleteEmp()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            EmployeesMenu em = new EmployeesMenu();
            em.Show();
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string empName = textBox1.Text;
            bool check = true;

            if (File.Exists("Employees.xml"))
            {
                XmlDocument doc = new XmlDocument();

                if (File.Exists("Tasks.xml"))
                {
                    doc.Load("Tasks.xml");

                    XmlNodeList List = doc.GetElementsByTagName("Task");

                    for (int i = 0; i < List.Count; i++)
                    {
                        XmlNodeList children = List[i].ChildNodes;
                        string eName = children[2].InnerText;

                        if (eName.Equals(empName))
                        {
                            check = false;
                            break;
                        }
                    }
                }

                if (check)
                {
                    bool checker = false;

                    doc = new XmlDocument();

                    doc.Load("Employees.xml");

                    XmlNodeList List = doc.GetElementsByTagName("Employee");

                    for (int i = 0; i < List.Count; i++)
                    {
                        XmlNodeList children = List[i].ChildNodes;
                        string eName = children[1].InnerText;

                        if (eName.Equals(empName))
                        {
                            List[i].ParentNode.RemoveChild(List[i]);
                            checker = true;
                            break;
                        }
                    }

                    if (checker)
                    {
                        doc.Save("Employees.xml");
                        MessageBox.Show("Succefully Deleted!");
                    }

                    else
                    {
                        MessageBox.Show("Invaid Employee Username!");
                    }
                }

                else
                {
                    MessageBox.Show("Can't Delete An Employee Who's Assigned To A Task!");
                }

            }

            else {
                MessageBox.Show("Please Add Employees First!");
            }
        }
    }
}
