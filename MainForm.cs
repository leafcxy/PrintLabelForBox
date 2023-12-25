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
            if (rbvertical.Checked)
            {
                printA5();
            }
            else if (rbhorizontal.Checked)
            {
                printA4();
            }
        }

        private void printA4()
        {
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                string strcolpo = dgvr.Cells["colpo"].Value.ToString().Trim();
                string strcolpart_no = dgvr.Cells["colpart_no"].Value.ToString().Trim();
                string strcolcontents = dgvr.Cells["colcontents"].Value.ToString().Trim();
                string strcolc_no = dgvr.Cells["colc_no"].Value.ToString().Trim();
                string strcoldc = dgvr.Cells["coldc"].Value.ToString().Trim();
                string strcolbarcode = dgvr.Cells["colbarcode"].Value.ToString().Trim();

                // 创建数据源
                DataTable dataTable = new DataTable("WAHL");
                dataTable.Columns.Add("po", typeof(string));
                dataTable.Columns.Add("part_no", typeof(string));
                dataTable.Columns.Add("contents", typeof(string));
                dataTable.Columns.Add("c_no", typeof(string));
                dataTable.Columns.Add("dc", typeof(string));
                dataTable.Columns.Add("barcode", typeof(byte[]));

                Barcode barcode = new Barcode();
                barcode.Alignment = AlignmentPositions.LEFT;
                barcode.Encode(TYPE.CODE128, strcolbarcode, 550, 50);

                dataTable.Rows.Add(strcolpo, strcolpart_no, strcolcontents, strcolc_no, strcoldc, barcode.GetImageData(SaveTypes.BMP));

                // 加载报表文件
                LocalReport report = new LocalReport();
                report.ReportPath = "ReportA4.rdlc";

                // 设置数据源
                report.DataSources.Add(new ReportDataSource("DataSetA4", dataTable));
                report.Refresh();

                printHelper.PrintStream(report);
            }
        }

        private void printA5()
        {
            // 创建数据源
            DataTable dataTable = new DataTable("WAHL");
            dataTable.Columns.Add("po", typeof(string));
            dataTable.Columns.Add("part_no", typeof(string));
            dataTable.Columns.Add("contents", typeof(string));
            dataTable.Columns.Add("c_no", typeof(string));
            dataTable.Columns.Add("dc", typeof(string));
            dataTable.Columns.Add("barcode", typeof(byte[]));
            dataTable.Columns.Add("po2", typeof(string));
            dataTable.Columns.Add("part_no2", typeof(string));
            dataTable.Columns.Add("contents2", typeof(string));
            dataTable.Columns.Add("c_no2", typeof(string));
            dataTable.Columns.Add("dc2", typeof(string));
            dataTable.Columns.Add("barcode2", typeof(byte[]));

            string strcolpo = "";
            string strcolpart_no = "";
            string strcolcontents = "";
            string strcolc_no = "";
            string strcoldc = "";
            string strcolbarcode = "";

            for (int i = 0; i <dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dgvr = dataGridView1.Rows[i];

                if (i % 2 == 0)
                {
                    strcolpo = dgvr.Cells["colpo"].Value.ToString().Trim();
                    strcolpart_no = dgvr.Cells["colpart_no"].Value.ToString().Trim();
                    strcolcontents = dgvr.Cells["colcontents"].Value.ToString().Trim();
                    strcolc_no = dgvr.Cells["colc_no"].Value.ToString().Trim();
                    strcoldc = dgvr.Cells["coldc"].Value.ToString().Trim();
                    strcolbarcode = dgvr.Cells["colbarcode"].Value.ToString().Trim();
                    if (i == dataGridView1.Rows.Count - 1)
                    {
                        Barcode barcode = new Barcode();
                        barcode.Alignment = AlignmentPositions.LEFT;
                        barcode.Encode(TYPE.CODE128, strcolbarcode, 400, 35);
                        Barcode barcode2 = new Barcode();
                        barcode2.Alignment = AlignmentPositions.LEFT;
                        barcode2.Encode(TYPE.CODE128, "empty", 400, 35);
                        dataTable.Rows.Add(
                            strcolpo,
                            strcolpart_no,
                            strcolcontents,
                            strcolc_no,
                            strcoldc,
                            barcode.GetImageData(SaveTypes.BMP),
                            "", "", "", "", "", barcode2.GetImageData(SaveTypes.BMP));

                        // 加载报表文件
                        LocalReport report = new LocalReport();
                        report.ReportPath = "ReportA5.rdlc";

                        // 设置数据源
                        report.DataSources.Add(new ReportDataSource("DataSetA5", dataTable));
                        report.Refresh();

                        printHelper.PrintStream(report);
                        dataTable.Clear();
                    }
                }
                else if (i % 2 == 1)
                {
                    string strcolpo2 = dgvr.Cells["colpo"].Value.ToString().Trim();
                    string strcolpart_no2 = dgvr.Cells["colpart_no"].Value.ToString().Trim();
                    string strcolcontents2 = dgvr.Cells["colcontents"].Value.ToString().Trim();
                    string strcolc_no2 = dgvr.Cells["colc_no"].Value.ToString().Trim();
                    string strcoldc2 = dgvr.Cells["coldc"].Value.ToString().Trim();
                    string strcolbarcode2 = dgvr.Cells["colbarcode"].Value.ToString().Trim();

                    Barcode barcode = new Barcode();
                    barcode.Alignment = AlignmentPositions.LEFT;
                    barcode.Encode(TYPE.CODE128, strcolbarcode, 400, 35);
                    Barcode barcode2 = new Barcode();
                    barcode2.Alignment = AlignmentPositions.LEFT;
                    barcode2.Encode(TYPE.CODE128, strcolbarcode2, 400, 35);
                    dataTable.Rows.Add(
                        strcolpo,
                        strcolpart_no,
                        strcolcontents,
                        strcolc_no,
                        strcoldc,
                        barcode.GetImageData(SaveTypes.BMP),
                        strcolpo2,
                        strcolpart_no2,
                        strcolcontents2,
                        strcolc_no2,
                        strcoldc2,
                        barcode2.GetImageData(SaveTypes.BMP));

                    // 加载报表文件
                    LocalReport report = new LocalReport();
                    report.ReportPath = "ReportA5.rdlc";

                    // 设置数据源
                    report.DataSources.Add(new ReportDataSource("DataSetA5", dataTable));
                    report.Refresh();

                    printHelper.PrintStream(report);
                    dataTable.Clear();
                }
            }
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
                string strtbcontents = tbcontents.Text.Trim() + "  PCS";
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
