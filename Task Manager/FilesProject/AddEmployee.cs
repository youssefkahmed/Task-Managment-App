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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void unLabel_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {

            try
            {
                string ID = id.Text.ToString();
                string uName = un.Text.ToString();
                string password = pass.Text.ToString();
                string empName = name.Text.ToString();
                string gen = gender.SelectedItem.ToString();
                string department = dep.SelectedItem.ToString();
                string type = typeBox.SelectedItem.ToString();

                if (type.Equals("User"))
                {
                    if (!File.Exists("Employees.xml"))
                    {
                        XmlWriter writer = XmlWriter.Create("Employees.xml");

                        writer.WriteStartDocument();
                        writer.WriteStartElement("Table");
                        writer.WriteAttributeString("Name", "Employees");

                        writer.WriteStartElement("Employee");

                        writer.WriteStartElement("ID");
                        writer.WriteString(ID);
                        writer.WriteEndElement();

                        writer.WriteStartElement("Username");
                        writer.WriteString(uName);
                        writer.WriteEndElement();

                        writer.WriteStartElement("Password");
                        writer.WriteString(password);
                        writer.WriteEndElement();

                        writer.WriteStartElement("Name");
                        writer.WriteString(empName);
                        writer.WriteEndElement();

                        writer.WriteStartElement("Gender");
                        writer.WriteString(gen);
                        writer.WriteEndElement();

                        writer.WriteStartElement("Department");
                        writer.WriteString(department);
                        writer.WriteEndElement();



                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Close();

                        MessageBox.Show("Employeee Successfully Added!");
                    }

                    else
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.Load("Employees.xml");
                        XmlNodeList List = doc.GetElementsByTagName("Employee");

                        // checks if username already exists
                        bool check = false;

                        // checks if ID already exists
                        bool check2 = false;

                        for (int i = 0; i < List.Count; i++)
                        {
                            XmlNodeList children = List[i].ChildNodes;

                            string user_name = children[1].InnerText;
                            string i_d = children[0].InnerText;

                            if (user_name.Equals(uName))
                            {
                                check = true;
                                break;
                            }

                            if (i_d.Equals(ID))
                            {
                                check2 = true;
                                break;
                            }

                        }

                        if (check == false && check2 == false)
                        {

                            XmlElement Emp = doc.CreateElement("Employee");

                            XmlElement node = doc.CreateElement("ID");
                            node.InnerText = ID;
                            Emp.AppendChild(node);

                            node = doc.CreateElement("Username");
                            node.InnerText = uName;
                            Emp.AppendChild(node);

                            node = doc.CreateElement("Password");
                            node.InnerText = password;
                            Emp.AppendChild(node);

                            node = doc.CreateElement("Name");
                            node.InnerText = empName;
                            Emp.AppendChild(node);

                            node = doc.CreateElement("Gender");
                            node.InnerText = gen;
                            Emp.AppendChild(node);

                            node = doc.CreateElement("Department");
                            node.InnerText = department;
                            Emp.AppendChild(node);

                            XmlElement root = doc.DocumentElement;
                            root.AppendChild(Emp);

                            doc.Save("Employees.xml");

                            MessageBox.Show("Employeee Successfully Added!");
                        }

                        else
                        {
                            MessageBox.Show("Username And/Or ID Already Taken!");
                        }

                    }
                }



                else {

                    XmlDocument doc = new XmlDocument();
                    doc.Load("Admins.xml");
                    XmlNodeList List = doc.GetElementsByTagName("Admin");

                    // checks if username already exists
                    bool check = false;

                    // checks if ID already exists
                    bool check2 = false;

                    for (int i = 0; i < List.Count; i++)
                    {
                        XmlNodeList children = List[i].ChildNodes;

                        string user_name = children[0].InnerText;

                        if (user_name.Equals(uName))
                        {
                            check = true;
                            break;
                        }

                        if (children[2] != null)
                        {
                            string i_d = children[2].InnerText;

                            if (i_d.Equals(ID))
                            {
                                check2 = true;
                                break;
                            }
                        }
                    }

                    if (check == false && check2 == false)
                    {

                        XmlElement Ad = doc.CreateElement("Admin");

                        XmlElement node = doc.CreateElement("Username");
                        node.InnerText = uName;
                        Ad.AppendChild(node);

                        node = doc.CreateElement("Password");
                        node.InnerText = password;
                        Ad.AppendChild(node);

                        node = doc.CreateElement("ID");
                        node.InnerText = ID;
                        Ad.AppendChild(node);

                        node = doc.CreateElement("Name");
                        node.InnerText = empName;
                        Ad.AppendChild(node);

                        node = doc.CreateElement("Gender");
                        node.InnerText = gen;
                        Ad.AppendChild(node);

                        node = doc.CreateElement("Department");
                        node.InnerText = department;
                        Ad.AppendChild(node);

                        XmlElement root = doc.DocumentElement;
                        root.AppendChild(Ad);

                        doc.Save("Admins.xml");

                        MessageBox.Show("Admin Successfully Added!");
                    }

                    else
                    {
                        MessageBox.Show("Username And/Or ID Already Taken!");
                    }


                }



            } // end of try

            catch (Exception ex)
            {
                MessageBox.Show("Please Enter All Required Info!");
            }
        }
    }
}
