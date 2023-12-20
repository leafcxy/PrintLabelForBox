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
        private PrintHelper printHelper = new PrintHelper();

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
            barcode.Encode(TYPE.CODE128, "90643-100 100 piece",600,300);
            dataTable.Rows.Add("XXXXXXXXX", "90643-100", "100 PCS", "01", "14/12/23", barcode.GetImageData(SaveTypes.BMP));

            // 加载报表文件
            LocalReport report = new LocalReport();
            //report.ReportPath = "ReportA4.rdlc";
            report.ReportPath = "ReportA5.rdlc";

            // 设置数据源
            report.DataSources.Add(new ReportDataSource("DataSetA4", dataTable));
            report.Refresh();

            printHelper.PrintStream(report);



            


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int intCopies = 1;
            if (cbCopies.Checked)
            {
                intCopies = Convert.ToInt32(numericUpDown1.Value);
            }
            for(int i = 0; i < intCopies; i++)
            {
                string strtbpo = tbpo.Text.Trim();
                string strtbpart_no = tbpart_no.Text.Trim();
                string strtbcontents = tbcontents.Text.Trim() + " PCS";
                string strtbc_no = tbc_no.Text.Trim();
                string strdtpdc = dtpdc.Text.Trim();
                string strtbbarcode = tbbarcode.Text.Trim();
                if (strtbpo=="" || strtbpart_no=="" || strtbcontents=="")
                {
                    MessageBox.Show("empty");
                    return;
                }
                dataGridView1.Rows.Add(new object[] { strtbpo, strtbpart_no, strtbcontents, strtbc_no, strdtpdc, strtbbarcode });
            }
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select the file you want to open";
            ofd.Filter = "excel|*.xls";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                ExcelHelper excelHelper = new ExcelHelper(filePath);
                DataTable dt = excelHelper.ExcelToDataTable("template", true);
                foreach(DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(new object[] { dr["P/O#"].ToString().Trim(), dr["PART NO."].ToString().Trim(), dr["CONTENTS(PCS)"].ToString().Trim(), dr["C/NO."].ToString().Trim(), dr["D/C"].ToString().Trim(), dr["BARCODE"].ToString().Trim() });
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("template.xls");
        }
    }
}
