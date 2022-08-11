using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormHoaDon : Form
    {
        String tenKH;
        String ngay;
        String tongtien;
        public FormHoaDon(string tenKH, string ngay, string tongtien, DataGridView dataGridView)
        {
            this.tenKH = tenKH;
            InitializeComponent();
            this.ngay = ngay;
            this.tongtien=tongtien;
            this.dataGridView1.DataSource = dataGridView.DataSource;

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            label2.Text = "Tổng tiền: " + tongtien;
            label3.Text = "Tên khách hàng: " + tenKH;
            label4.Text = "Ngày: "+ ngay;

        }
    }
}
