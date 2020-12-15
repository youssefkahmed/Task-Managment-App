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
    public partial class MyTasks : Form
    {
        string username;
        string selectedTaskName = "";
        string selectedEmpName = "";
        string selectedProjName;
        string selectedProjName2;
        List<string> projects = new List<string>();
        List<string> employees = new List<string>();
        string fileLoc;

        public MyTasks(string uname)
        {
            username = uname;
            InitializeComponent();

            tDGV.Rows.Clear();
            eDGV.Rows.Clear();


            if (!File.Exists("Tasks.xml"))
            {
                MessageBox.Show("You Have No Given Tasks.");
            }

            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Tasks.xml");

                XmlNodeList List = doc.GetElementsByTagName("Task");

                for (int i = 0; i < List.Count; i++)
                {
                    XmlNodeList children = List[i].ChildNodes;

                    string tName = children[0].Name;
                    string tValue = children[0].InnerText;

                    string pName = children[1].Name;
                    string pValue = children[1].InnerText;

                    string eName = children[2].Name;
                    string eValue = children[2].InnerText;

                    string cName = children[3].Name;
                    string cValue = children[3].InnerText;

                    if (children[4] != null)
                    {
                        fileLoc = children[4].InnerText;
                        if (fileLoc.Contains(".jpg") || fileLoc.Contains(".png") || fileLoc.Contains(".jpeg"))
                            label5.Text = "File loc +.png";
                        else if (fileLoc.Contains(".txt"))
                            label5.Text = "File loc + .txt";
                    }

                    if (eValue.Equals(username))
                    {
                        if (tDGV.ColumnCount == 0)
                        {
                            tDGV.Columns.Add("Task Name", tName);
                            tDGV.Columns.Add("Project Name", pName);
                            tDGV.Columns.Add("Comment", cName);
                            
                            
                        }

                        bool checker = false;

                        for (int k = 0; k < projects.Count; k++)
                        {
                            if (projects[k].Equals(pValue))
                            {
                                checker = true;
                                break;
                            }
                        }

                        if (checker == false)
                        {
                            projects.Add(pValue);
                        }

                            tDGV.Rows.Add(new string[] { tValue, pValue, cValue });

                        // add chamge here

                    }
                }

                XmlDocument doc2 = new XmlDocument();
                doc2.Load("Tasks.xml");

                XmlNodeList List2 = doc2.GetElementsByTagName("Task");

                for (int j = 0; j < List2.Count; j++)
                {
                    XmlNodeList child = List2[j].ChildNodes;

                    string p_Name = child[1].Name;
                    string p_Value = child[1].InnerText;

                    string e_Name = child[2].Name;
                    string e_Value = child[2].InnerText;

                    for (int k = 0; k < projects.Count; k++)
                    {
                        if (p_Value.Equals(projects[k]) && !e_Value.Equals(username))
                        {
                            if (eDGV.ColumnCount == 0)
                            {
                                eDGV.Columns.Add("Project Name", p_Name);
                                eDGV.Columns.Add("Employee Name", e_Name);

                            }

                            bool checker = false;

                            for (int y = 0; y < eDGV.Rows.Count; y++)
                            {
                                if (eDGV.Rows[y].Cells[0].Value.ToString().Equals(p_Value) && eDGV.Rows[y].Cells[1].Value.ToString().Equals(e_Value))
                                {
                                    checker = true;
                                    break;
                                }
                            }

                            if (checker == false)
                            {
                                eDGV.Rows.Add(new string[] { p_Value, e_Value });
                            }
                        }

                        }
                }

            }
        }

        private void MyTasks_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = tDGV.Rows[index];
                selectedTaskName = selectedRow.Cells[0].Value.ToString();
                selectedProjName = selectedRow.Cells[1].Value.ToString();

                richTextBox1.Text = selectedRow.Cells[2].Value.ToString();
                TB1.Text = selectedTaskName;
            }

            catch (Exception ex)
            {
                MessageBox.Show("No Task Selected!");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (selectedTaskName == "")
            {
                MessageBox.Show("Please Select A Task From The Data Grid View To Update Its Comment!");
            }

            else
            {
                string comment = richTextBox1.Text;

                XmlDocument doc = new XmlDocument();
                doc.Load("Tasks.xml");

                bool checker = false;

                XmlNodeList List = doc.GetElementsByTagName("Task");

                for (int i = 0; i < List.Count; i++)
                {
                    XmlNodeList children = List[i].ChildNodes;

                    string task_name = children[0].InnerText;

                    if (selectedTaskName.Equals(task_name))
                    {
                        children[3].InnerText = comment;
                        checker = true;
                        break;

                    }
                }

                if (checker)
                {
                    MessageBox.Show("Comment Updated Successfully!");
                    doc.Save("Tasks.xml");


                    // Updating Task History File

                    XmlDocument doc4 = new XmlDocument();
                    doc4.Load("TaskHistory.xml");

                    XmlElement TaskHistory = doc4.CreateElement("Task");

                    XmlElement Node = doc4.CreateElement("TaskName");
                    Node.InnerText = selectedTaskName;
                    TaskHistory.AppendChild(Node);

                    Node = doc4.CreateElement("ProjectName");
                    Node.InnerText = selectedProjName;
                    TaskHistory.AppendChild(Node);

                    Node = doc4.CreateElement("EmployeeName");
                    Node.InnerText = username;
                    TaskHistory.AppendChild(Node);

                    Node = doc4.CreateElement("Comment");
                    Node.InnerText = comment;
                    TaskHistory.AppendChild(Node);

                    XmlElement Root = doc4.DocumentElement;
                    Root.AppendChild(TaskHistory);
                    doc4.Save("TaskHistory.xml");

                    tDGV.Update();
                    tDGV.Refresh();
                }

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            User u = new User(username);
            u.Show();
            this.Close();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            try {

                XmlDocument doc = new XmlDocument();
                doc.Load("Tasks.xml");
                bool checker = false;

                XmlNodeList List = doc.GetElementsByTagName("Task");

                for (int i = 0; i < List.Count; i++)
                {
                    XmlNodeList children = List[i].ChildNodes;

                    string task_name = children[0].InnerText;

                    if (selectedTaskName.Equals(task_name) && selectedProjName.Equals(selectedProjName2))
                    {
                        children[2].InnerText = selectedEmpName;
                        checker = true;
                        break;

                    }
                }

                if (checker)
                {
                    MessageBox.Show("Task Forwarded Successfully!");
                    doc.Save("Tasks.xml");

                    // Updating Task History File

                    XmlDocument doc4 = new XmlDocument();
                    doc4.Load("TaskHistory.xml");

                    XmlElement TaskHistory = doc4.CreateElement("Task");

                    XmlElement Node = doc4.CreateElement("TaskName");
                    Node.InnerText = selectedTaskName;
                    TaskHistory.AppendChild(Node);

                    Node = doc4.CreateElement("ProjectName");
                    Node.InnerText = selectedProjName;
                    TaskHistory.AppendChild(Node);

                    Node = doc4.CreateElement("EmployeeName");
                    Node.InnerText = selectedEmpName;
                    TaskHistory.AppendChild(Node);

                    Node = doc4.CreateElement("PreviousEmployeeName");
                    Node.InnerText = username;
                    TaskHistory.AppendChild(Node);

                    Node = doc4.CreateElement("Comment");
                    Node.InnerText = richTextBox1.Text;
                    TaskHistory.AppendChild(Node);

                    XmlElement Root = doc4.DocumentElement;
                    Root.AppendChild(TaskHistory);
                    doc4.Save("TaskHistory.xml");

                    tDGV.Update();
                    tDGV.Refresh();
                    eDGV.Update();
                    eDGV.Refresh();

                }

                else {
                    MessageBox.Show("Please Make Sure You Are Forwarding The Task To An Employee On The Same Project!");
                }

            }

            catch (Exception exe)
            {
                MessageBox.Show("Please Select A Task And An Employee From Each Data Grid Veiw Respectively!");
            }
        }

        private void eDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = eDGV.Rows[index];
                selectedEmpName = selectedRow.Cells[1].Value.ToString();
                selectedProjName2 = selectedRow.Cells[0].Value.ToString();

                TB2.Text = selectedEmpName;
            }

            catch (Exception ex)
            {
                MessageBox.Show("No Employee Selected!");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (!fileLoc.Equals(""))
                check = true;
            if (check)
            {
                Download d = new Download(fileLoc, textBox1.Text.ToString());
                d.Show();
            }
        }
    }
}
