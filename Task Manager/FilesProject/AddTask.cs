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
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Attach_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "PNG Image|.png| JPEG Image|.jpeg| JPG Image|.jpg| PDF File|.pdf| Text Document|.tzt";
            ofd.ShowDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string path = ofd.FileName;
                textBox1.Text = path;
            }﻿
        }

        private void AddTask_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TasksForm tf = new TasksForm();
            tf.Show();
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {

            if (!File.Exists("Employees.xml") || !File.Exists("Projects.xml"))
            {
                MessageBox.Show("Please Add Employees And Projects First!");
            }

            else
            {
             
                    bool checked1 = false;
                    bool checked2 = false;
                    bool checked3 = false;

                    string emp_name = empName.Text.ToString();
                    string projName = projectName.Text.ToString();
                    string tName = taskName.Text.ToString();

                    XmlDocument doc = new XmlDocument();
                    doc.Load("Employees.xml");

                    XmlNodeList List = doc.GetElementsByTagName("Employee");

                    for (int i = 0; i < List.Count; i++)
                    {
                        XmlNodeList children = List[i].ChildNodes;

                        string un = children[1].InnerText;

                        if (un.Equals(emp_name))
                        {
                            checked1 = true;
                            break;
                        }


                    }

                    XmlDocument doc2 = new XmlDocument();
                    doc2.Load("Projects.xml");

                    XmlNodeList List2 = doc2.GetElementsByTagName("Project");

                    for (int i = 0; i < List2.Count; i++)
                    {
                        XmlNodeList children = List2[i].ChildNodes;

                        string proj = children[0].InnerText.ToString();

                        if (proj.Equals(projName))
                        {
                            checked2 = true;
                            break;
                        }
                    }


                    if (checked1 && checked2)
                    {

                        if (!File.Exists("Tasks.xml"))
                        {
                            XmlWriter writer = XmlWriter.Create("Tasks.xml");
                            writer.WriteStartDocument();

                            writer.WriteStartElement("Table");
                            writer.WriteAttributeString("Name", "Tasks");

                            writer.WriteStartElement("Task");

                            writer.WriteStartElement("TaskName");
                            writer.WriteString(taskName.Text.ToString());
                            writer.WriteEndElement();

                            writer.WriteStartElement("ProjectName");
                            writer.WriteString(projName);
                            writer.WriteEndElement();

                            writer.WriteStartElement("EmployeeName");
                            writer.WriteString(emp_name);
                            writer.WriteEndElement();

                            writer.WriteStartElement("Comment");
                            writer.WriteString(richTextBox1.Text.ToString());
                            writer.WriteEndElement();

                            writer.WriteStartElement("FileLoc");
                            writer.WriteString(textBox1.Text.ToString());
                            writer.WriteEndElement();

                        writer.WriteEndElement();

                            writer.WriteEndElement();

                            writer.WriteEndDocument();
                            writer.Close();

                            // Creating Task History

                            if (!File.Exists("TaskHistory.xml"))
                            {
                                XmlWriter writer2 = XmlWriter.Create("TaskHistory.xml");
                                writer2.WriteStartDocument();

                                writer2.WriteStartElement("Table");
                                writer2.WriteAttributeString("Name", "Tasks");

                                writer2.WriteStartElement("Task");

                                writer2.WriteStartElement("TaskName");
                                writer2.WriteString(taskName.Text.ToString());
                                writer2.WriteEndElement();

                                writer2.WriteStartElement("ProjectName");
                                writer2.WriteString(projName);
                                writer2.WriteEndElement();

                                writer2.WriteStartElement("EmployeeName");
                                writer2.WriteString(emp_name);
                                writer2.WriteEndElement();

                                writer2.WriteStartElement("Comment");
                                writer2.WriteString(richTextBox1.Text.ToString());
                                writer2.WriteEndElement();

                                writer2.WriteStartElement("FileLoc");
                                writer2.WriteString(textBox1.Text.ToString());
                                writer2.WriteEndElement();

                            writer2.WriteEndElement();

                                writer2.WriteEndElement();

                                writer2.WriteEndDocument();
                                writer2.Close();
                            }

                            else
                            {

                                XmlDocument doc4 = new XmlDocument();
                                doc4.Load("TaskHistory.xml");

                                XmlElement TaskHistory = doc4.CreateElement("Task");

                                XmlElement Node = doc4.CreateElement("TaskName");
                                Node.InnerText = taskName.Text.ToString();
                                TaskHistory.AppendChild(Node);

                                Node = doc4.CreateElement("ProjectName");
                                Node.InnerText = projName;
                                TaskHistory.AppendChild(Node);

                                Node = doc4.CreateElement("EmployeeName");
                                Node.InnerText = emp_name;
                                TaskHistory.AppendChild(Node);


                                Node = doc4.CreateElement("Comment");
                                Node.InnerText = richTextBox1.Text.ToString();
                                TaskHistory.AppendChild(Node);

                                Node = doc4.CreateElement("FileLoc");
                                Node.InnerText = textBox1.Text.ToString();
                                TaskHistory.AppendChild(Node);

                            XmlElement Root = doc4.DocumentElement;
                                Root.AppendChild(TaskHistory);
                                doc4.Save("TaskHistory.xml");

                            }


                            MessageBox.Show("Task Added Succefully");
                        }

                        else
                        {
                            XmlDocument doc3 = new XmlDocument();
                            doc3.Load("Tasks.xml");

                            XmlNodeList List3 = doc3.GetElementsByTagName("Task");

                            for (int i = 0; i < List3.Count; i++)
                            {
                                XmlNodeList children = List3[i].ChildNodes;

                                string tn = children[0].InnerText;

                                if (tn.Equals(tName))
                                {
                                    checked3 = true;
                                    break;
                                }
                            }

                            if (checked3 == false)
                            {
                                XmlElement Task = doc3.CreateElement("Task");

                                XmlElement node = doc3.CreateElement("TaskName");
                                node.InnerText = taskName.Text.ToString();
                                Task.AppendChild(node);

                                node = doc3.CreateElement("ProjectName");
                                node.InnerText = projName;
                                Task.AppendChild(node);

                                node = doc3.CreateElement("EmployeeName");
                                node.InnerText = emp_name;
                                Task.AppendChild(node);


                                node = doc3.CreateElement("Comment");
                                node.InnerText =textBox1.Text.ToString();
                                Task.AppendChild(node);

                                XmlElement root = doc3.DocumentElement;
                                root.AppendChild(Task);
                                doc3.Save("Tasks.xml");


                                // Creating Task History

                                if (!File.Exists("TaskHistory.xml"))
                                {
                                    XmlWriter writer = XmlWriter.Create("TaskHistory.xml");
                                    writer.WriteStartDocument();

                                    writer.WriteStartElement("Table");
                                    writer.WriteAttributeString("Name", "Tasks");

                                    writer.WriteStartElement("Task");

                                    writer.WriteStartElement("TaskName");
                                    writer.WriteString(taskName.Text.ToString());
                                    writer.WriteEndElement();

                                    writer.WriteStartElement("ProjectName");
                                    writer.WriteString(projName);
                                    writer.WriteEndElement();

                                    writer.WriteStartElement("EmployeeName");
                                    writer.WriteString(emp_name);
                                    writer.WriteEndElement();

                                    writer.WriteStartElement("Comment");
                                    writer.WriteString(richTextBox1.Text.ToString());
                                    writer.WriteEndElement();

                                    writer.WriteStartElement("FileLoc");
                                    writer.WriteString(textBox1.Text.ToString());
                                    writer.WriteEndElement();

                                    writer.WriteEndElement();

                                    writer.WriteEndElement();

                                    writer.WriteEndDocument();
                                    writer.Close();
                                }

                                else
                                {

                                    XmlDocument doc4 = new XmlDocument();
                                    doc4.Load("TaskHistory.xml");

                                    XmlElement TaskHistory = doc4.CreateElement("Task");

                                    XmlElement Node = doc4.CreateElement("TaskName");
                                    Node.InnerText = taskName.Text.ToString();
                                    TaskHistory.AppendChild(Node);

                                    Node = doc4.CreateElement("ProjectName");
                                    Node.InnerText = projName;
                                    TaskHistory.AppendChild(Node);

                                    Node = doc4.CreateElement("EmployeeName");
                                    Node.InnerText = emp_name;
                                    TaskHistory.AppendChild(Node);


                                    Node = doc4.CreateElement("Comment");
                                    Node.InnerText = richTextBox1.Text.ToString();
                                    TaskHistory.AppendChild(Node);

                                    Node = doc4.CreateElement("FileLoc");
                                    Node.InnerText = textBox1.Text.ToString();
                                    TaskHistory.AppendChild(Node);

                                XmlElement Root = doc4.DocumentElement;
                                    Root.AppendChild(TaskHistory);
                                    doc4.Save("TaskHistory.xml");

                                }

                                MessageBox.Show("Task Added Succefully");

                            }

                            else {
                                MessageBox.Show("A Task With This Name Already Exists!");
                            }
                        }
                    }



                    else
                    {
                        MessageBox.Show("Please Make Sure Employee Name And Project Name Are Correct!");
                    }
          

            }

        }
    }

}