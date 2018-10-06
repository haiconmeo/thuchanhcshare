using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "abc";
            //txt1.PasswordChar = true;
        }

        private void txt1_TextChanged(object sender, EventArgs e) // khi phat sinh su kien thay doi 
        {
            //MessageBox.Show(txt1.Text+"  djt m3 may");
        }

        private void manh_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            f.Show();
            f.dd = show;
            
        }
        public void show(string s)
        {
            txt1.Text = s;
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt1.Text = cb1.Items[cb1.SelectedIndex].ToString();
        }

        private void cc_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cc.Checked.ToString());
        }
    }
}
