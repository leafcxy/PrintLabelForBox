using BarcodeLib;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintLabelForBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Logs.Write("Load...");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // 创建数据源
            DataTable dataTable = new DataTable("WAHL");
            dataTable.Columns.Add("po", typeof(string));
            dataTable.Columns.Add("part_no", typeof(string));
            dataTable.Columns.Add("contents", typeof(string));
            dataTable.Columns.Add("c_no", typeof(string));
            dataTable.Columns.Add("dc", typeof(string));
            dataTable.Columns.Add("barcode", typeof(byte[]));

            Barcode barcode = new Barcode();
            barcode.Encode(TYPE.CODE128, "90643-100 100 piece");
            dataTable.Rows.Add("XXXXXXXXX", "90643-100", "100 PCS", "01", "14/12/23", barcode.GetImageData(SaveTypes.BMP));
            dataTable.Rows.Add("XXXXXXXXX", "90643-101", "100 PCS", "01", "14/12/23", barcode.GetImageData(SaveTypes.BMP));
            dataTable.Rows.Add("XXXXXXXXX", "90643-103", "100 PCS", "01", "14/12/23", barcode.GetImageData(SaveTypes.BMP));

            // 加载报表文件
            LocalReport report = new LocalReport();
            //report.ReportPath = "ReportA4.rdlc";
            report.ReportPath = "ReportA5.rdlc";

            // 设置数据源
            report.DataSources.Add(new ReportDataSource("DataSetA4", dataTable));
            report.Refresh();

            PrintHelper printHelper = new PrintHelper();
            printHelper.PrintStream(report);
        }
    }
}
