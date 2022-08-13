using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;
using Excel =  Microsoft.Office.Interop.Excel;
namespace BLL
{

    public class ProductBLL
    {
        public bool insert(string tenSanPham, int soLuong, int gia, string phanLoai, string nhaSanXuat)
        {
            Product product = new Product(tenSanPham, soLuong, gia, phanLoai, nhaSanXuat);
            string query = "INSERT INTO tblProduct VALUES(@tenSanPham, @soLuong, @gia, @phanLoai, @nhaSanXuat)";
            ProductDAL productDAL = new ProductDAL();
            productDAL.Command(product, query);
    
            return true;
        }

        public bool update(string tenSanPham, int soLuong, int gia, string phanLoai, string nhaSanXuat)
        {
            Product product = new Product(tenSanPham, soLuong, gia, phanLoai, nhaSanXuat);
            string query = "UPDATE tblProduct" +
                " SET soLuong = @soLuong, gia = @gia, phanLoai = @phanLoai, nhaSanXuat = @nhaSanXuat" +
                " WHERE tenSanPham = @tenSanPham";
            ProductDAL productDAL = new ProductDAL();
            if(productDAL.Command(product, query))
            {
                return true;
            }

            return false;
        }

        public bool delete(string tenSanPham)
        {
            Product product = new Product(tenSanPham, 0, 0, "", "");
            string query = "DELETE FROM tblProduct WHERE tenSanPham = @tenSanPham";
            ProductDAL productDAL = new ProductDAL();
            if(productDAL.Command(product, query))
            {
                return true;
            }

            return false;
        }

        public DataTable loadAll()
        {
            QuerySelect querySelect = new QuerySelect();
            string query = "SELECT * FROM tblProduct";
            DataTable dataTable = querySelect.Select(query);
            return dataTable; 

        }

        public DataTable selectTenSanPhamTheoLoai(string tenSanPham,String loai)
        {
            string query;
            QuerySelect querySelect = new QuerySelect();
            if (loai == "Tất cả")
            {
                 query = "SELECT * FROM tblProduct WHERE tenSanPham like N'%" + tenSanPham + "%'";
            }
            else
            {

                query = "SELECT * FROM tblProduct WHERE tenSanPham like N'%"+tenSanPham+"%' AND phanLoai like N'%"+loai+"%'";
            }
            DataTable dataTable = querySelect.Select(query);
            return dataTable;

        }

        public DataTable selectLoai(string loai)
        {

            QuerySelect querySelect = new QuerySelect();
            string query = "SELECT * FROM tblProduct WHERE phanLoai = N'" + loai + "'";
            DataTable dataTable = querySelect.Select(query);
            return dataTable;

        }


        public int tinhTienOder(DataTable dt)
        {
            int tongTienOrder = 0;

            foreach (DataRow dataRow in dt.Rows)
            {
                tongTienOrder += int.Parse(dataRow[4].ToString());
            }
            return tongTienOrder;
        }

        public void ExportFile(DataTable dataTable, string tenNV,int tongTienHang,int tienKhachDua,int tienThoiLai)
        {
            //Tạo các đối tượng Excel

             Excel.Application oExcel = new  Excel.Application();
                                         
             Excel.Workbooks oBooks;
                                         
             Excel.Sheets oSheets;
                                         
             Excel.Workbook oBook;
                                         
             Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = ( Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = ( Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = "Sheet1";

            // Tạo phần Tiêu đề
             Excel.Range head = oSheet.get_Range("A1", "E1");

            head.MergeCells = true;

            head.Value2 = "Hóa đơn mua hàng";

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment =  Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

             Excel.Range cl1 = oSheet.get_Range("A5", "A5");

            cl1.Value2 = "Id sản phẩm";

            cl1.ColumnWidth = 20.0;

             Excel.Range cl2 = oSheet.get_Range("B5", "B5");

            cl2.Value2 = "Tên sản phẩm";

            cl2.ColumnWidth = 35.0;

             Excel.Range cl3 = oSheet.get_Range("C5", "C5");

            cl3.Value2 = "Giá";
            cl3.ColumnWidth = 15.0;

             Excel.Range cl4 = oSheet.get_Range("D5", "D5");

            cl4.Value2 = "Số lượng";

            cl4.ColumnWidth = 10.5;

             Excel.Range cl5 = oSheet.get_Range("E5", "E5");
            cl5.Value2 = "Thành tiền";
            cl5.ColumnWidth = 15.5;

            Excel.Range cl6 = oSheet.get_Range("A2", "A2");
            cl6.Value2 = "Ngày";

            Excel.Range cl7 = oSheet.get_Range("B2", "B2");
            cl7.Value2 = DateTime.Now.ToString(" dd/MM/yyyy hh:mm:ss tt");

            Excel.Range cl8 = oSheet.get_Range("A3", "A3");
            cl8.Value2 = "Tên Nhân Viên";

            Excel.Range cl9 = oSheet.get_Range("B3", "B3");
            cl9.Value2 = tenNV;

            
            Excel.Range cl10 = oSheet.get_Range("A"+(dataTable.Rows.Count+7).ToString(), "A"+ (dataTable.Rows.Count + 7).ToString());
            cl10.Value2 = "Tổng tiền mua hàng";

            Excel.Range cl11 = oSheet.get_Range("B" + (dataTable.Rows.Count + 7).ToString(), "B" + (dataTable.Rows.Count + 7).ToString());
            cl11.Value2 = tongTienHang.ToString();

            Excel.Range cl12 = oSheet.get_Range("A" + (dataTable.Rows.Count + 8).ToString(), "A" + (dataTable.Rows.Count + 8).ToString());
            cl12.Value2 = "Tiền khách đưa";

            Excel.Range cl13 = oSheet.get_Range("B" + (dataTable.Rows.Count + 8).ToString(), "B" + (dataTable.Rows.Count + 8).ToString());
            cl13.Value2 = tienKhachDua.ToString();

            Excel.Range cl14 = oSheet.get_Range("A" + (dataTable.Rows.Count + 9).ToString(), "A" + (dataTable.Rows.Count + 9).ToString());
            cl14.Value2 = "Tiền thối lại";

            Excel.Range cl15 = oSheet.get_Range("B" + (dataTable.Rows.Count + 9).ToString(), "B" + (dataTable.Rows.Count + 9).ToString());
            cl15.Value2 = tienThoiLai.ToString();

            Excel.Range rowHead = oSheet.get_Range("A5", "E5");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle =  Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 8;

            rowHead.HorizontalAlignment =  Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 6;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

             Excel.Range c1 = ( Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

             Excel.Range c2 = ( Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

             Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle =  Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            // Excel.Range c3 = ( Excel.Range)oSheet.Cells[rowEnd, columnStart];

            // Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment =  Excel.XlHAlign.xlHAlignCenter;
        }

    }
}
