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
    
    public partial class Form2 : Form
    {
        public delegate void ss(string s);
        public ss dd;

        //ss dd =  new ss(Form1.show);
        public Form2()
        {
            InitializeComponent();
        }

       

        private void form2_text1_TextChanged(object sender, EventArgs e)
        {
            dd(form2_text1.Text);
        }
    }
}
