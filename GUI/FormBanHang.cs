using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FormBanHang : Form
    {
        String tenNV;
        public FormBanHang(string tenNV)
        {
            this.tenNV = tenNV; 
            InitializeComponent();
            this.tenNV = tenNV;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool check = TestAccountDAL.insert();

            MessageBox.Show(check.ToString());
            

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySieuThiDataSet.tblStaff' table. You can move, or remove it, as needed.
            this.tblStaffTableAdapter.Fill(this.quanLySieuThiDataSet.tblStaff);
            FormLogin formLogin = new FormLogin();
            label1.Text = tenNV;
            label3.Text = DateTime.Now.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormHoaDon formHoaDon = new FormHoaDon(textBox3.Text , label3.Text, label11.Text, dataGridView1);
            formHoaDon.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
