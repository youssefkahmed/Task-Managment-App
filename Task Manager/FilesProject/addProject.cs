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
    public partial class addProject : Form
    {
        public addProject()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string projectName = textBox1.Text.ToString();

                if (!File.Exists("Projects.xml"))
                {
                    XmlWriter writer = XmlWriter.Create("Projects.xml");
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Projects");
                    writer.WriteStartElement("Project");

                    writer.WriteStartElement("ProjectName");
                    writer.WriteString(projectName);
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Close();

                    MessageBox.Show("Project Added Succefully");

                }

                else
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("Projects.xml");
                    XmlNodeList List = doc.GetElementsByTagName("Project");

                    bool check = false;

                    for (int i = 0; i < List.Count; i++)
                    {
                        XmlNodeList children = List[i].ChildNodes;

                        string pn = children[0].InnerText;

                        if (pn.Equals(projectName))
                        {
                            check = true;
                            break;
                        }
                    }

                    if (check == false)
                    {
                        XmlElement project = doc.CreateElement("Project");
                        XmlElement node = doc.CreateElement("ProjectName");
                        node.InnerText = projectName;
                        project.AppendChild(node);

                        XmlElement root = doc.DocumentElement;
                        root.AppendChild(project);
                        doc.Save("Projects.xml");

                        MessageBox.Show("Project Added Succefully");
                    }

                    else
                    {
                        MessageBox.Show("A Project With This Name Already Exists!");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Project Name!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectForm pf = new ProjectForm();
            pf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
