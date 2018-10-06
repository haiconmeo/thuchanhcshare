using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlysinhvien
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
         public delegate void ss(sinhvien a);
         public ss dd;

        private void b_add_Click(object sender, EventArgs e)
        {
            int lh = 0;
            if (r_bang2.Checked == true) { lh = 1; }
            if (r_daihoc.Checked == true) { lh = 0; }
            if (r_caodang.Checked == true) { lh = 2; }
            sinhvien sv1 = new sinhvien
            {
                name = txt_name.Text,
                mssv = txt_mssv.Text,
                ngaysinh = dateTimePicker1.Value,

                diachi = txt_add.Text,
                dienthoai = text_std.Text,
                nienkhoa = txt_nienkhoa.Text,
                loaihinh = lh
            };
            dd(sv1);
            this.Close();
        }
    }
}
