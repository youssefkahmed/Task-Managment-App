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
    public partial class deleteProject : Form
    {
        public deleteProject()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string projectName = textBox1.Text;

            XmlDocument doc = new XmlDocument();
            bool check= false;
            bool PNChecker = false;

            if (File.Exists("Tasks.xml"))
            {
                doc.Load("Tasks.xml");

                XmlNodeList List = doc.GetElementsByTagName("Task");

                for (int i = 0; i < List.Count; i++)
                {
                    XmlNodeList children = List[i].ChildNodes;
                    string pN = children[1].InnerText;

                    if (pN.Equals(projectName))
                    {
                        PNChecker = true;
                    }
                }
            }

           if (PNChecker == false)
           {
                doc.Load("Projects.xml");

                foreach (XmlNode node in doc.SelectNodes("Projects/Project"))
                {
                    if (node.SelectSingleNode("ProjectName").InnerText == projectName)
                    {

                        node.ParentNode.RemoveChild(node);
                        check = true;
                    }
                }

            if (check)
            {
                doc.Save("Projects.xml");
                MessageBox.Show("Succefully Deleted!");
            }

            else {
                MessageBox.Show("Invaid Project Name!");
            }

        }

           else {
               MessageBox.Show("Cannot Delete Project With Active Tasks! (Make Sure To Delete All Tasks Associated With This Project First)");
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
