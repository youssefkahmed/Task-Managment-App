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
using System.Xml;

namespace FilesProject
{
    public partial class editProject2 : Form
    {
        string projName;
        XmlDocument doc;
        string selectedTaskName;
        string selectedEmpName;

        public editProject2()
        {
            InitializeComponent();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditProject2_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectForm pf = new ProjectForm();
            pf.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            projName = textBox1.Text;
            dataGridView1.Rows.Clear();

            if (!File.Exists("Tasks.xml"))
            {
                MessageBox.Show("Please Add Tasks First!");
            }

            else
            {
                doc = new XmlDocument();
                doc.Load("Tasks.xml");

                XmlNodeList List = doc.GetElementsByTagName("Task");

                for (int i = 0; i < List.Count; i++)
                {
                    XmlNodeList children = List[i].ChildNodes;
                    string projectName = children[1].InnerText;

                    if (projectName.Equals(projName))
                    {
                        string TaskName = children[0].Name;
                        string valueTN = children[0].InnerText;

                        string EmpName = children[2].Name;
                        string valueEN = children[2].InnerText;

                        string TaskComment = children[3].Name;
                        string valueComment = children[3].InnerText;

                        if (dataGridView1.ColumnCount == 0)
                        {
                            dataGridView1.Columns.Add("TaskName", TaskName);
                            dataGridView1.Columns.Add("EmpName", EmpName);
                            dataGridView1.Columns.Add("TaskComment", TaskComment);

                        }

                        dataGridView1.Rows.Add(new string[] { valueTN, valueEN, valueComment });
                    }
                }
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string taskName = textBox2.Text;
            string empName = textBox3.Text;
            string comment = richTextBox1.Text;

            doc = new XmlDocument();
            doc.Load("Tasks.xml");

            bool checker = false;

            XmlNodeList List = doc.GetElementsByTagName("Task");

            for (int i = 0; i < List.Count; i++){
                XmlNodeList children = List[i].ChildNodes;
                string projectName = children[1].InnerText;
                string tName = children[0].InnerText;

                if (projName.Equals(projectName)) {
                    if (tName.Equals(selectedTaskName)) {
                        children[0].InnerText = taskName;
                        children[2].InnerText = empName;
                        children[3].InnerText = comment;
                        checker = true;
                        break;
                    }
                }
                    
            }



            if (checker)
            {
                MessageBox.Show("Task Succefully Edited");
                doc.Save("Tasks.xml");

                // Updating Task History File

                XmlDocument doc4 = new XmlDocument();
                doc4.Load("TaskHistory.xml");

                XmlElement TaskHistory = doc4.CreateElement("Task");

                XmlElement Node = doc4.CreateElement("TaskName");
                Node.InnerText = taskName;
                TaskHistory.AppendChild(Node);

                Node = doc4.CreateElement("PreviousTaskName");
                Node.InnerText = selectedTaskName;
                TaskHistory.AppendChild(Node);

                Node = doc4.CreateElement("ProjectName");
                Node.InnerText = projName;
                TaskHistory.AppendChild(Node);

                Node = doc4.CreateElement("EmployeeName");
                Node.InnerText = empName;
                TaskHistory.AppendChild(Node);

                Node = doc4.CreateElement("PreviousEmployeeName");
                Node.InnerText = selectedEmpName;
                TaskHistory.AppendChild(Node);

                Node = doc4.CreateElement("Comment");
                Node.InnerText = comment;
                TaskHistory.AppendChild(Node);

                XmlElement Root = doc4.DocumentElement;
                Root.AppendChild(TaskHistory);
                doc4.Save("TaskHistory.xml");
            }
            else {
                MessageBox.Show("Invalid Task or Project");
            }
            
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            selectedTaskName = selectedRow.Cells[0].Value.ToString();
            selectedEmpName = selectedRow.Cells[1].Value.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
