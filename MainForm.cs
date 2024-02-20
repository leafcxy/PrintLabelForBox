using BarcodeLib;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            List<LocalReport> result = new List<LocalReport>();
            if (rbvertical.Checked)
            {
                result = printA5();
            }
            else if (rbhorizontal.Checked)
            {
                result = printA4();
            }
            foreach(LocalReport report in result)
            {
                printHelper.PrintStream(report);
            }
        }

        private List<LocalReport> printA4()
        {
            List<LocalReport> result = new List<LocalReport>();
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

                BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
                barcode.Alignment = AlignmentPositions.LEFT;
                barcode.Encode(TYPE.CODE128, strcolbarcode, 550, 50);

                dataTable.Rows.Add(strcolpo, strcolpart_no, strcolcontents, strcolc_no, strcoldc, barcode.GetImageData(SaveTypes.BMP));

                // 加载报表文件
                LocalReport report = new LocalReport();
                report.ReportPath = "ReportA4.rdlc";

                // 设置数据源
                report.DataSources.Add(new ReportDataSource("DataSetA4", dataTable));
                report.Refresh();

                //printHelper.PrintStream(report);
                result.Add(report);
            }
            return result;
        }

        private List<LocalReport> printA5()
        {
            List<LocalReport> result = new List<LocalReport>();
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
                        BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
                        barcode.Alignment = AlignmentPositions.LEFT;
                        barcode.Encode(TYPE.CODE128, strcolbarcode, 400, 35);
                        BarcodeLib.Barcode barcode2 = new BarcodeLib.Barcode();
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

                        //printHelper.PrintStream(report);
                        result.Add(report);
                        //dataTable.Clear();
                        dataTable = new DataTable("WAHL");
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

                    BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
                    barcode.Alignment = AlignmentPositions.LEFT;
                    barcode.Encode(TYPE.CODE128, strcolbarcode, 400, 35);
                    BarcodeLib.Barcode barcode2 = new BarcodeLib.Barcode();
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

                    //printHelper.PrintStream(report);
                    result.Add(report);
                    //dataTable.Clear();
                    dataTable = new DataTable("WAHL");
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
                }
            }
            return result;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //int intCopies = 1;
            //if (cbCopies.Checked)
            //{
            //    intCopies = Convert.ToInt32(numericUpDown1.Value);
            //}
            //for(int i = 0; i < intCopies; i++)
            //{
            //    string strtbpo = tbpo.Text.Trim();
            //    string strtbpart_no = tbpart_no.Text.Trim();
            //    string strtbcontents = tbcontents.Text.Trim() + "  PCS";
            //    string strtbc_no = tbc_no1.Text.Trim();
            //    string strdtpdc = dtpdc.Text.Trim();
            //    string strtbbarcode = tbbarcode.Text.Trim();
            //    if (strtbpo=="" || strtbpart_no=="" || strtbcontents=="")
            //    {
            //        MessageBox.Show("empty");
            //        return;
            //    }
            //    dataGridView1.Rows.Add(new object[] { strtbpo, strtbpart_no, strtbcontents, strtbc_no, strdtpdc, strtbbarcode });
            //}

            try
            {
                string strno1 = tbc_no1.Text.Trim();
                string strno2 = tbc_no2.Text.Trim();
                if(strno1 == "" || strno2 == "")
                {
                    string strtbpo = tbpo.Text.Trim();
                    string strtbpart_no = tbpart_no.Text.Trim();
                    string strtbcontents = tbcontents.Text.Trim() + "  PCS";
                    string strtbc_no = "";
                    string strdtpdc = dtpdc.Text.Trim();
                    string strtbbarcode = tbbarcode.Text.Trim();
                    if (strtbpo == "" || strtbpart_no == "" || strtbcontents == "")
                    {
                        MessageBox.Show("empty");
                        return;
                    }
                    dataGridView1.Rows.Add(new object[] { strtbpo, strtbpart_no, strtbcontents, strtbc_no, strdtpdc, strtbbarcode });
                }
                else
                {
                    int intst = Convert.ToInt32(strno1);
                    int inten = Convert.ToInt32(strno2);
                    for (; intst <= inten; intst++)
                    {
                        string strtbpo = tbpo.Text.Trim();
                        string strtbpart_no = tbpart_no.Text.Trim();
                        string strtbcontents = tbcontents.Text.Trim() + "  PCS";
                        string strtbc_no = intst.ToString("00");
                        string strdtpdc = dtpdc.Text.Trim();
                        string strtbbarcode = tbbarcode.Text.Trim();
                        if (strtbpo == "" || strtbpart_no == "" || strtbcontents == "")
                        {
                            MessageBox.Show("empty");
                            return;
                        }
                        dataGridView1.Rows.Add(new object[] { strtbpo, strtbpart_no, strtbcontents, strtbc_no, strdtpdc, strtbbarcode });
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.Write(ex);
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

        private void btnoutput_Click(object sender, EventArgs e)
        {
            List<LocalReport> result = new List<LocalReport>();
            List<string> output = new List<string>();
            string strTimeStamp = GetTimeStamp();
            int i = 1;
            if (rbvertical.Checked)
            {
                result = printA5();
            }
            else if (rbhorizontal.Checked)
            {
                result = printA4();
            }
            foreach (LocalReport report in result)
            {
                //printHelper.PrintStream(report);

                // 渲染报表
                byte[] renderedBytes;
                string mimeType;
                string encoding;
                string fileNameExtension;
                Warning[] warnings;
                string[] streams;

                renderedBytes = report.Render("PDF", null, out mimeType, out encoding, out fileNameExtension, out streams, out warnings);

                string outputPath = $"{AppDomain.CurrentDomain.BaseDirectory}\\reports\\report{strTimeStamp}-{i}.pdf";
                FileInfo fileInfo = new FileInfo(outputPath);
                if (!fileInfo.Directory.Exists)
                {
                    fileInfo.Directory.Create();
                }
                File.WriteAllBytes(outputPath, renderedBytes);
                output.Add(outputPath);
                i++;
            }
            if(output.Count > 1)
            {
                iTextSharpPdfMerge(output, $"{AppDomain.CurrentDomain.BaseDirectory}\\reports\\report{strTimeStamp}-Merge.pdf");
            }
            //System.Diagnostics.Process.Start("explorer.exe", $"{AppDomain.CurrentDomain.BaseDirectory}\\reports\\");
            MessageBox.Show($"Output to path:{AppDomain.CurrentDomain.BaseDirectory}\\reports\\", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        private static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }

        /// <summary>
        /// 合并PDF文件
        /// </summary>
        /// <param name="inFiles">待合并文件列表</param>
        /// <param name="outFile">合并生成的文件名称</param>
        private static void iTextSharpPdfMerge(List<String> inFiles, String outFile)
        {
            using (var stream = new FileStream(outFile, FileMode.Create))
            {
                using (var doc = new Document())
                {
                    using (var pdf = new PdfCopy(doc, stream))
                    {
                        doc.Open();
                        inFiles.ForEach(file =>
                        {
                            var reader = new PdfReader(file);
                            for (int i = 0; i < reader.NumberOfPages; i++)
                            {
                                var page = pdf.GetImportedPage(reader, i + 1);
                                pdf.AddPage(page);
                            }
                            pdf.FreeReader(reader);
                            reader.Close();
                        });
                    }
                }
            }
        }

        /// <summary>
        /// 按每页拆分PDF文件
        /// </summary>
        /// <param name="inFile">待拆分PDF文件名称</param>
        private static void iTextSharpPdfSplit(string inFile)
        {
            using (var reader = new PdfReader(inFile))
            {
                // 注意起始页是从1开始的
                for (int i = 1; i <= new PdfReader(inFile).NumberOfPages; i++)
                {
                    using (var sourceDocument = new Document(reader.GetPageSizeWithRotation(i)))
                    {
                        var pdfCopyProvider = new PdfCopy(sourceDocument, new System.IO.FileStream($"iTextSharp_拆分_{i}.pdf", System.IO.FileMode.Create));
                        sourceDocument.Open();
                        var importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                        pdfCopyProvider.AddPage(importedPage);
                    }
                }
            }
        }

        private void tbcontents_TextChanged(object sender, EventArgs e)
        {
            //型號名 空格 裝箱數piece
            tbbarcode.Text = tbpart_no.Text.Trim() + " " + tbcontents.Text.Trim() + "piece";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbbarcode.Enabled = true;
            }
            else
            {
                tbbarcode.Enabled = false;
            }
        }
    }
}
