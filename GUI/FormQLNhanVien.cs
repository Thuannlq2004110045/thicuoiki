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
    public partial class FormQLNhanVien : Form
    {
        public FormQLNhanVien()
        {
            InitializeComponent();
        }

        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            
            
            StaffBLL staffBLL = new StaffBLL();
            dataGridView1.DataSource = staffBLL.loadAll();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool check;
            StaffBLL staffBLL = new StaffBLL();
            try
            {
                check = staffBLL.insert(textBox1.Text ,textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message, "Thông báo");
                return;
            }

            if (check == true)
            {
                MessageBox.Show("Thêm thành công!!!", "Thông báo");
                FormQLNhanVien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Trùng tên sản phẩm!!!", "Thông báo");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool check;
            StaffBLL staffBLL = new StaffBLL();
            try
            {
                check = staffBLL.update(textBox1.Text ,textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message, "Thông báo");
                return;
            }

            if (check == true)
            {
                MessageBox.Show("Sửa thành công!!!", "Thông báo");
                FormQLNhanVien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên sản phẩm để sửa!!!", "Thông báo");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool check;
            StaffBLL staffBLL = new StaffBLL();
            try
            {
                check = staffBLL.delete(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message, "Thông báo");
                return;
            }

            if (check == true)
            {
                MessageBox.Show("Xóa thành công!!!", "Thông báo");
                FormQLNhanVien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên sản phẩm để xóa!!!", "Thông báo");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox5.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[4].Value.ToString();            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQLSanPham formQLSanPham = new FormQLSanPham();
            formQLSanPham.Show();
            this.Close();
        }
    }
}
