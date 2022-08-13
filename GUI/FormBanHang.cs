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

        DataTable dt;

        int tongTienOrder = 0;
        int tienTraLai = 0;
        int tienKhachDua = 0;
        ProductBLL productBLL = new ProductBLL();
        public FormBanHang(string tenNV)
        {

            InitializeComponent();
            this.tenNV = tenNV;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Chưa nhập tiền khách đưa !!!", "Thông báo");
                return;
            }
            if (int.Parse(textBox2.Text) < tongTienOrder)
            {
                MessageBox.Show("Tiền khách đưa không đủ!!!","Thông báo");
                return;
            }
            tienKhachDua = int.Parse(textBox2.Text);
            tienTraLai = tienKhachDua - tongTienOrder;
            textBox1.Text = tienTraLai.ToString();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Tất cả";
            ProductBLL productBLL = new ProductBLL();
            label1.Text = tenNV;
            dataGridView2.DataSource = productBLL.loadAll();



            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dt = new DataTable();

            dt.Columns.Add("Id Sản phẩm");
            dt.Columns.Add("Tên Sản phẩm");
            dt.Columns.Add("Giá");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Tổng tiền");
            dataGridView1.DataSource = dt;
            label11.Text = tongTienOrder.ToString();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
 
            textBox4.Text = dataGridView2.SelectedCells[1].Value.ToString();
            textBox5.Text = dataGridView2.SelectedCells[3].Value.ToString();
            textBox6.Text = "1";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Tất cả")
            {
                FormBanHang_Load(sender, e);
                return;
            }
            
            dataGridView2.DataSource = productBLL.selectLoai(comboBox1.Text);
        }
        int idSP = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int tongSL;
            int tongTien;

            if(textBox4.Text == ""||textBox5.Text == "")
            {
                return;
            }
            foreach (DataRow dataRow in dt.Rows)
            {
                
                if (textBox4.Text == dataRow[1].ToString())
                {
                    tongSL = int.Parse(textBox6.Text) + int.Parse(dataRow[3].ToString());
                    dataRow[3] = tongSL.ToString();
                    tongTien = int.Parse(dataRow[2].ToString()) * int.Parse(dataRow[3].ToString());
                    dataRow[4] = tongTien.ToString();
                    tongTienOrder =      productBLL.tinhTienOder(dt);
                    
                    label11.Text = tongTienOrder.ToString();
                    return;
                }
            }

            idSP++;
            DataRow row = dt.NewRow();

            row[0] = idSP.ToString();
            row[1] = textBox4.Text;
            row[2] = textBox5.Text;
            row[3] = textBox6.Text;

            tongTien = int.Parse(row[2].ToString()) * int.Parse(row[3].ToString());
            
            row[4] = tongTien.ToString();

            dt.Rows.Add(row);



            tongTienOrder = productBLL.tinhTienOder(dt);
            label11.Text = tongTienOrder.ToString();
        }
        private void tinhTienOder()
        {
            tongTienOrder = 0;
           
            foreach (DataRow dataRow in dt.Rows)
            {
                tongTienOrder += int.Parse(dataRow[4].ToString());
            }
            label11.Text = tongTienOrder.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            label11.Text = "0";
            dt.Clear();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string name = textBox7.Text;

            if (name == "")
            {
                if (comboBox1.Text == "Tất cả")
                {
                    FormBanHang_Load(sender, e);

                }
                else
                {
                    dataGridView2.DataSource = productBLL.selectLoai(comboBox1.Text);
                }
            }
            else
            {
                ProductBLL productBLL = new ProductBLL();
                dataGridView2.DataSource = productBLL.selectTenSanPhamTheoLoai(name, comboBox1.Text);
            }
        }



        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected)
                {
                    if (dt.Rows.Count < 1)
                    {
                        return;
                    }
                    tongTienOrder -= int.Parse(dt.Rows[i][4].ToString());
                    label11.Text = tongTienOrder.ToString();
                    dataGridView1.Rows.RemoveAt(i);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count < 2)
            {
                MessageBox.Show("Hóa đơn phải có ít nhất 1 sản phẩm");
                return;
            }
            productBLL.ExportFile(dt,tenNV,tongTienOrder,tienKhachDua,tienTraLai);
            
        }
    }

}
