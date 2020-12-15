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
    public partial class DisplayEmployees : Form
    {
        string selectedEmpName = "";
        XmlDocument doc;

        public DisplayEmployees()
        {
            InitializeComponent();


            DGV.Rows.Clear();

            if (!File.Exists("Employees.xml"))
            {
                MessageBox.Show("Please Add Employees First!");
            }

            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Employees.xml");

                XmlNodeList List = doc.GetElementsByTagName("Employee");

                for (int i = 0; i < List.Count; i++)
                {
                    XmlNodeList children = List[i].ChildNodes;

                    string id = children[0].Name;
                    string iValue = children[0].InnerText;

                    string un = children[1].Name;
                    string uValue = children[1].InnerText;

                    string pass = children[2].Name;
                    string pValue = children[2].InnerText;

                    string name = children[3].Name;
                    string nValue = children[3].InnerText;

                    string gender = children[4].Name;
                    string gValue = children[4].InnerText;

                    string dep = children[5].Name;
                    string dValue = children[5].InnerText;

                    if (DGV.ColumnCount == 0)
                    {
                        DGV.Columns.Add("ID", id);
                        DGV.Columns.Add("Username", un);
                        DGV.Columns.Add("Password", pass);
                        DGV.Columns.Add("Name", name);
                        DGV.Columns.Add("Gender", gender);
                        DGV.Columns.Add("Department", dep);
                    }

                    DGV.Rows.Add(new string[] { iValue, uValue, pValue, nValue, gValue, dValue });

                }

            }
        }

        private void DisplayEmployees_Load(object sender, EventArgs e)
        {

        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DGV.Rows[index];
            selectedEmpName = selectedRow.Cells[1].Value.ToString();
        }


        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DGV.Rows[index];
            selectedEmpName = selectedRow.Cells[1].Value.ToString();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            EmployeesMenu em = new EmployeesMenu();
            em.Show();
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (selectedEmpName.Equals(""))
            {
                MessageBox.Show("Please Select An Employee From The Data Grid View First!");
            }

            else
            {

                try
                {
                    string username = un.Text;
                    string password = pass.Text;
                    string empName = name.Text;
                    string gender = gen.SelectedItem.ToString();
                    string department = dep.SelectedItem.ToString();

                    doc = new XmlDocument();
                    doc.Load("Employees.xml");

                    bool UNChecker = true;
                    bool check = false;

                    XmlNodeList List = doc.GetElementsByTagName("Employee");

                    for (int i = 0; i < List.Count; i++)
                    {
                        XmlNodeList children = List[i].ChildNodes;
                        string userN = children[1].InnerText;

                        if (username.Equals(userN) && !selectedEmpName.Equals(userN))
                        {
                            UNChecker = false;
                        }

                    }

                    if (UNChecker)
                    {
                        List = doc.GetElementsByTagName("Employee");

                    for (int i = 0; i < List.Count; i++)
                    {
                        XmlNodeList children = List[i].ChildNodes;
                        string userN = children[1].InnerText;

                        if (selectedEmpName.Equals(userN))
                        {
                            children[1].InnerText = username;
                            children[2].InnerText = password;
                            children[3].InnerText = empName;
                            children[4].InnerText = gender;
                            children[5].InnerText = department;

                            doc.Save("Employees.xml");

                            if (File.Exists("Tasks.xml"))
                            {
                            doc = new XmlDocument();
                            doc.Load("Tasks.xml");

                            XmlNodeList List2 = doc.GetElementsByTagName("Task");
                            string oldName = selectedEmpName;

                            for (int j = 0; j < List2.Count; j++)
                            {
                                XmlNodeList child = List2[j].ChildNodes;
                                string UN = child[2].InnerText;

                                if (oldName.Equals(UN))
                                {

                                    child[2].InnerText = username;
                                    continue;

                                }
                            }

                            doc.Save("Tasks.xml");

                            }

                            MessageBox.Show("Employee Successfully Updated!");

                            break;
                        }

                    }

                    }
                    else
                    {
                        MessageBox.Show("Username Already Taken!");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter All Required Info!");
                }
            }

            
        }

        private void DGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DGV.Rows[index];
            selectedEmpName = selectedRow.Cells[1].Value.ToString();
        }



    }
}
