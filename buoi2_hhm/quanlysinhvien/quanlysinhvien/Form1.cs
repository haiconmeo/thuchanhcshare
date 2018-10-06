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
    
    public partial class Form1 : Form
    {
        qlsv ql;
        public Form1()
        {
            InitializeComponent();
            ql = new qlsv();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ql.getlist();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count >0)
            {
                int r = dataGridView1.CurrentRow.Index;
                text_name.Text = dataGridView1.Rows[r].Cells["name"].Value.ToString();
                text_mssv.Text = dataGridView1.Rows[r].Cells["mssv"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[r].Cells["ngaysinh"].Value);
                textBox3.Text = dataGridView1.Rows[r].Cells["diachi"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[r].Cells["dienthoai"].Value.ToString();
                text_khoa.Text = dataGridView1.Rows[r].Cells["nienkhoa"].Value.ToString();
                int loaihinh = Convert.ToInt32(dataGridView1.Rows[r].Cells["loaihinh"].Value.ToString());

                if (loaihinh == 0) { ra_daihoc.Checked = true; ra_caodang.Checked = false; ra_banghai.Checked = false; }
                if (loaihinh == 2) { ra_daihoc.Checked = false; ra_caodang.Checked = true; ra_banghai.Checked = false; }
                if (loaihinh == 1) { ra_daihoc.Checked = false; ra_caodang.Checked = false; ra_banghai.Checked = true; }
            }
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.dd = a_add;
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = ql.l;
        }
         void a_add(sinhvien sv1)
        {
            ql.l.Add(sv1);
            MessageBox.Show("cc");
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            int lh = 0;
            if (ra_banghai.Checked == true) { lh = 1; }
            if (ra_daihoc.Checked == true) { lh = 0; }
            if (ra_caodang.Checked == true) { lh = 2; }
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[index].Cells["name"].Value = text_name.Text;
            dataGridView1.Rows[index].Cells["mssv"].Value = text_mssv.Text;
            dataGridView1.Rows[index].Cells["ngaysinh"].Value = dateTimePicker1.Value;

            dataGridView1.Rows[index].Cells["diachi"].Value = text_addr.Text;
            dataGridView1.Rows[index].Cells["dienthoai"].Value = text_sdt.Text;
            dataGridView1.Rows[index].Cells["nienkhoa"].Value = text_khoa.Text;
            dataGridView1.Rows[index].Cells["loaihinh"].Value = lh;
            

        }

        private void b_del_Click(object sender, EventArgs e)
        {

            ql.delsv(dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = this.ql.getlist();


        }

        private void b_reset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ql.l;
        }
    }
}
