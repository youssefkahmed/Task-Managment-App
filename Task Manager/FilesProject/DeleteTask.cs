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
    public partial class DeleteTask : Form
    {
        public DeleteTask()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            TasksForm tf = new TasksForm();
            tf.Show();
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string taskName = textBox1.Text;
            bool check = false;

            if (File.Exists("Tasks.xml"))
            {
                XmlDocument doc = new XmlDocument();

                doc.Load("Tasks.xml");

                XmlNodeList List = doc.GetElementsByTagName("Task");

                for (int i = 0; i < List.Count; i++)
                {
                    XmlNodeList children = List[i].ChildNodes;
                    string tName = children[0].InnerText;

                    if (tName.Equals(taskName))
                    {
                        List[i].ParentNode.RemoveChild(List[i]);
                        check = true;
                        break;
                    }
                }

                if (check)
                {
                    doc.Save("Tasks.xml");
                    MessageBox.Show("Task Deleted Successfully!");
                }

                else
                {
                    MessageBox.Show("No Task With Such Name!");
                }

            }

            else {
                MessageBox.Show("Please Add Tasks First!");
            }

        }
    }
}
