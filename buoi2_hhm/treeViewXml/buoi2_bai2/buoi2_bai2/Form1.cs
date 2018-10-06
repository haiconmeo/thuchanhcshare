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

namespace buoi2_bai2
{
    public partial class Form1 : Form
    {
        XmlDocument document;
        public Form1()
        {
            InitializeComponent();
            document = new XmlDocument();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           

            TreeNode node1 = new TreeNode("C#");
            TreeNode node2 = new TreeNode("VB.NET");
            TreeNode node3 = new TreeNode("C++");
            TreeNode[] array = new TreeNode[] { node1, node2, node3 };
            TreeNode programmingLanguage = new TreeNode("Programming Language", array);
            treeView1.Nodes.Add(programmingLanguage);
            TreeNode node4 = new TreeNode("C==");
            node1.Nodes.Add(node4);
        }
        public void  them(string m)
        {
             TreeNode c = new TreeNode(m);
            treeView1.SelectedNode.Nodes.Add(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            f.mm = them;
           // f.Close();
           // TreeNode c = new TreeNode();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }
        public void edit(string a)
        {
            treeView1.SelectedNode.Text = a;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            f.aa = edit;
           // f.Close();
            //treeView1.SelectedNode.Text="manh";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode[] tns= treeView1.Nodes.Find("c#",true);
            if (tns.Length > 0)
            {
                MessageBox.Show("ok");
            }
            else MessageBox.Show("deo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
