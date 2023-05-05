using Microsoft.Reporting.WebForms;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace drug_store.Controller.Basic
{
    internal class Controller
    {
        public Controller() {

        }

        public void generateInvoice()
        {
            // Tạo báo cáo
            LocalReport report = new LocalReport();
            report.ReportPath = "InvoiceReport.rdlc";

            // Tạo dữ liệu cho báo cáo
            DataTable table = new DataTable();
            table.Columns.Add("ProductName", typeof(string));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Total", typeof(decimal));
            table.Rows.Add("Product A", 10.0, 2, 20.0);
            table.Rows.Add("Product B", 20.0, 3, 60.0);
            report.DataSources.Add(new ReportDataSource("ProductTable", table));

            // Truyền tham số cho báo cáo
            ReportParameter[] parameters = new ReportParameter[4];
            parameters[0] = new ReportParameter("CustomerName", "John Smith");
            parameters[1] = new ReportParameter("Address", "123 Main Street");
            parameters[2] = new ReportParameter("PhoneNumber", "555-1234");
            parameters[3] = new ReportParameter("TotalAmount", "80.0");
            report.SetParameters(parameters);

            // Xuất báo cáo ra file PDF
            byte[] pdfBytes = report.Render("PDF");

            // Lưu file PDF
            string filePath = @"C:\MyInvoice.pdf";
            File.WriteAllBytes(filePath, pdfBytes);

            MessageBox.Show("Đã xuất hoá đơn ra file PDF thành công!");
        }

    }
}
