namespace PrintLabelForBox
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblpo = new System.Windows.Forms.Label();
            this.tbpo = new System.Windows.Forms.TextBox();
            this.tbpart_no = new System.Windows.Forms.TextBox();
            this.lblpart_no = new System.Windows.Forms.Label();
            this.tbcontents = new System.Windows.Forms.TextBox();
            this.lblcontents = new System.Windows.Forms.Label();
            this.lblbarcode = new System.Windows.Forms.Label();
            this.tbbarcode = new System.Windows.Forms.TextBox();
            this.lbldc = new System.Windows.Forms.Label();
            this.lblc_no = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colpo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpart_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcontents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colc_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbvertical = new System.Windows.Forms.RadioButton();
            this.rbhorizontal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnoutput = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnimport = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbCopies = new System.Windows.Forms.CheckBox();
            this.dtpdc = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblpcs = new System.Windows.Forms.Label();
            this.tbc_no1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbc_no2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(552, 22);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblpo
            // 
            this.lblpo.AutoSize = true;
            this.lblpo.Location = new System.Drawing.Point(159, 28);
            this.lblpo.Name = "lblpo";
            this.lblpo.Size = new System.Drawing.Size(28, 12);
            this.lblpo.TabIndex = 1;
            this.lblpo.Text = "P/O#";
            // 
            // tbpo
            // 
            this.tbpo.Location = new System.Drawing.Point(226, 23);
            this.tbpo.Name = "tbpo";
            this.tbpo.Size = new System.Drawing.Size(100, 22);
            this.tbpo.TabIndex = 2;
            // 
            // tbpart_no
            // 
            this.tbpart_no.Location = new System.Drawing.Point(442, 23);
            this.tbpart_no.Name = "tbpart_no";
            this.tbpart_no.Size = new System.Drawing.Size(100, 22);
            this.tbpart_no.TabIndex = 4;
            // 
            // lblpart_no
            // 
            this.lblpart_no.AutoSize = true;
            this.lblpart_no.Location = new System.Drawing.Point(379, 28);
            this.lblpart_no.Name = "lblpart_no";
            this.lblpart_no.Size = new System.Drawing.Size(56, 12);
            this.lblpart_no.TabIndex = 3;
            this.lblpart_no.Text = "PART NO.";
            // 
            // tbcontents
            // 
            this.tbcontents.Location = new System.Drawing.Point(653, 23);
            this.tbcontents.Name = "tbcontents";
            this.tbcontents.Size = new System.Drawing.Size(100, 22);
            this.tbcontents.TabIndex = 6;
            this.tbcontents.TextChanged += new System.EventHandler(this.tbcontents_TextChanged);
            // 
            // lblcontents
            // 
            this.lblcontents.AutoSize = true;
            this.lblcontents.Location = new System.Drawing.Point(582, 28);
            this.lblcontents.Name = "lblcontents";
            this.lblcontents.Size = new System.Drawing.Size(64, 12);
            this.lblcontents.TabIndex = 5;
            this.lblcontents.Text = "CONTENTS";
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.Location = new System.Drawing.Point(582, 70);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(60, 12);
            this.lblbarcode.TabIndex = 11;
            this.lblbarcode.Text = "BARCODE";
            // 
            // tbbarcode
            // 
            this.tbbarcode.Enabled = false;
            this.tbbarcode.Location = new System.Drawing.Point(653, 65);
            this.tbbarcode.Name = "tbbarcode";
            this.tbbarcode.Size = new System.Drawing.Size(150, 22);
            this.tbbarcode.TabIndex = 10;
            // 
            // lbldc
            // 
            this.lbldc.AutoSize = true;
            this.lbldc.Location = new System.Drawing.Point(379, 70);
            this.lbldc.Name = "lbldc";
            this.lbldc.Size = new System.Drawing.Size(24, 12);
            this.lbldc.TabIndex = 9;
            this.lbldc.Text = "D/C";
            // 
            // lblc_no
            // 
            this.lblc_no.AutoSize = true;
            this.lblc_no.Location = new System.Drawing.Point(159, 70);
            this.lblc_no.Name = "lblc_no";
            this.lblc_no.Size = new System.Drawing.Size(35, 12);
            this.lblc_no.TabIndex = 7;
            this.lblc_no.Text = "C/NO.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colpo,
            this.colpart_no,
            this.colcontents,
            this.colc_no,
            this.coldc,
            this.colbarcode});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(984, 447);
            this.dataGridView1.TabIndex = 13;
            // 
            // colpo
            // 
            this.colpo.HeaderText = "P/O#";
            this.colpo.Name = "colpo";
            // 
            // colpart_no
            // 
            this.colpart_no.HeaderText = "PART NO.";
            this.colpart_no.Name = "colpart_no";
            // 
            // colcontents
            // 
            this.colcontents.HeaderText = "CONTENTS(PCS)";
            this.colcontents.Name = "colcontents";
            // 
            // colc_no
            // 
            this.colc_no.HeaderText = "C/NO.";
            this.colc_no.Name = "colc_no";
            // 
            // coldc
            // 
            this.coldc.HeaderText = "D/C";
            this.coldc.Name = "coldc";
            // 
            // colbarcode
            // 
            this.colbarcode.HeaderText = "BARCODE";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.Width = 140;
            // 
            // rbvertical
            // 
            this.rbvertical.AutoSize = true;
            this.rbvertical.Checked = true;
            this.rbvertical.Location = new System.Drawing.Point(227, 25);
            this.rbvertical.Name = "rbvertical";
            this.rbvertical.Size = new System.Drawing.Size(113, 16);
            this.rbvertical.TabIndex = 14;
            this.rbvertical.TabStop = true;
            this.rbvertical.Text = "WAHL-A4-vertical";
            this.rbvertical.UseVisualStyleBackColor = true;
            // 
            // rbhorizontal
            // 
            this.rbhorizontal.AutoSize = true;
            this.rbhorizontal.Location = new System.Drawing.Point(361, 25);
            this.rbhorizontal.Name = "rbhorizontal";
            this.rbhorizontal.Size = new System.Drawing.Size(126, 16);
            this.rbhorizontal.TabIndex = 15;
            this.rbhorizontal.Text = "WAHL-A4-horizontal";
            this.rbhorizontal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnoutput);
            this.groupBox1.Controls.Add(this.rbhorizontal);
            this.groupBox1.Controls.Add(this.rbvertical);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 601);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 60);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printing operation";
            // 
            // btnoutput
            // 
            this.btnoutput.Location = new System.Drawing.Point(659, 22);
            this.btnoutput.Name = "btnoutput";
            this.btnoutput.Size = new System.Drawing.Size(100, 23);
            this.btnoutput.TabIndex = 27;
            this.btnoutput.Text = "OutputToPDF";
            this.btnoutput.UseVisualStyleBackColor = true;
            this.btnoutput.Click += new System.EventHandler(this.btnoutput_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(329, 107);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 17;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(605, 107);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(75, 23);
            this.btnimport.TabIndex = 18;
            this.btnimport.Text = "Import";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(704, 112);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(44, 12);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "template";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cbCopies
            // 
            this.cbCopies.AutoSize = true;
            this.cbCopies.Location = new System.Drawing.Point(159, 110);
            this.cbCopies.Name = "cbCopies";
            this.cbCopies.Size = new System.Drawing.Size(56, 16);
            this.cbCopies.TabIndex = 22;
            this.cbCopies.Text = "Copies";
            this.cbCopies.UseVisualStyleBackColor = true;
            this.cbCopies.Visible = false;
            // 
            // dtpdc
            // 
            this.dtpdc.CustomFormat = "dd/MM/yy";
            this.dtpdc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdc.Location = new System.Drawing.Point(442, 65);
            this.dtpdc.Name = "dtpdc";
            this.dtpdc.Size = new System.Drawing.Size(100, 22);
            this.dtpdc.TabIndex = 23;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(226, 107);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 22);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.Visible = false;
            // 
            // lblpcs
            // 
            this.lblpcs.AutoSize = true;
            this.lblpcs.Location = new System.Drawing.Point(759, 28);
            this.lblpcs.Name = "lblpcs";
            this.lblpcs.Size = new System.Drawing.Size(33, 12);
            this.lblpcs.TabIndex = 25;
            this.lblpcs.Text = "(PCS)";
            // 
            // tbc_no1
            // 
            this.tbc_no1.Location = new System.Drawing.Point(226, 65);
            this.tbc_no1.Name = "tbc_no1";
            this.tbc_no1.Size = new System.Drawing.Size(40, 22);
            this.tbc_no1.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbc_no2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.tbpo);
            this.panel1.Controls.Add(this.lblpo);
            this.panel1.Controls.Add(this.tbc_no1);
            this.panel1.Controls.Add(this.lblpart_no);
            this.panel1.Controls.Add(this.lblpcs);
            this.panel1.Controls.Add(this.tbpart_no);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.lblcontents);
            this.panel1.Controls.Add(this.dtpdc);
            this.panel1.Controls.Add(this.tbcontents);
            this.panel1.Controls.Add(this.cbCopies);
            this.panel1.Controls.Add(this.lblc_no);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.lbldc);
            this.panel1.Controls.Add(this.btnimport);
            this.panel1.Controls.Add(this.tbbarcode);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.lblbarcode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 154);
            this.panel1.TabIndex = 27;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(810, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbc_no2
            // 
            this.tbc_no2.Location = new System.Drawing.Point(286, 65);
            this.tbc_no2.Name = "tbc_no2";
            this.tbc_no2.Size = new System.Drawing.Size(40, 22);
            this.tbc_no2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "~";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(412, 107);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Outer box label print";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblpo;
        private System.Windows.Forms.TextBox tbpo;
        private System.Windows.Forms.TextBox tbpart_no;
        private System.Windows.Forms.Label lblpart_no;
        private System.Windows.Forms.TextBox tbcontents;
        private System.Windows.Forms.Label lblcontents;
        private System.Windows.Forms.Label lblbarcode;
        private System.Windows.Forms.TextBox tbbarcode;
        private System.Windows.Forms.Label lbldc;
        private System.Windows.Forms.Label lblc_no;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbvertical;
        private System.Windows.Forms.RadioButton rbhorizontal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox cbCopies;
        private System.Windows.Forms.DateTimePicker dtpdc;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblpcs;
        private System.Windows.Forms.TextBox tbc_no1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpart_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcontents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colc_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbarcode;
        private System.Windows.Forms.Button btnoutput;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbc_no2;
        private System.Windows.Forms.Button btnClear;
    }
}

