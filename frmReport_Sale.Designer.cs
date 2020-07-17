namespace ProjectCoffee
{
    partial class frmReport_Sale
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.Report = new System.Windows.Forms.Label();
            this.rdbReportAll = new Guna.UI.WinForms.GunaRadioButton();
            this.rdbReportThisYear = new Guna.UI.WinForms.GunaRadioButton();
            this.rdbReportMonth = new Guna.UI.WinForms.GunaRadioButton();
            this.rdb = new Guna.UI.WinForms.GunaRadioButton();
            this.rdbReportDate = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaDateTimePicker2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaGroupBox1);
            this.panel1.Controls.Add(this.Report);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 818);
            this.panel1.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(304, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(892, 818);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.button1);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.gunaDateTimePicker2);
            this.gunaGroupBox1.Controls.Add(this.gunaDateTimePicker1);
            this.gunaGroupBox1.Controls.Add(this.rdbReportDate);
            this.gunaGroupBox1.Controls.Add(this.rdb);
            this.gunaGroupBox1.Controls.Add(this.rdbReportMonth);
            this.gunaGroupBox1.Controls.Add(this.rdbReportThisYear);
            this.gunaGroupBox1.Controls.Add(this.rdbReportAll);
            this.gunaGroupBox1.LineBottom = 1;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Black;
            this.gunaGroupBox1.LineLeft = 1;
            this.gunaGroupBox1.LineRight = 1;
            this.gunaGroupBox1.LineTop = 1;
            this.gunaGroupBox1.Location = new System.Drawing.Point(3, 70);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 2;
            this.gunaGroupBox1.Size = new System.Drawing.Size(295, 745);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Choose Report";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.Font = new System.Drawing.Font("Alice5 95", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.Location = new System.Drawing.Point(82, 9);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(115, 58);
            this.Report.TabIndex = 1;
            this.Report.Text = "Report";
            // 
            // rdbReportAll
            // 
            this.rdbReportAll.BaseColor = System.Drawing.Color.White;
            this.rdbReportAll.Checked = true;
            this.rdbReportAll.CheckedOffColor = System.Drawing.Color.Black;
            this.rdbReportAll.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.rdbReportAll.FillColor = System.Drawing.Color.White;
            this.rdbReportAll.Location = new System.Drawing.Point(46, 240);
            this.rdbReportAll.Name = "rdbReportAll";
            this.rdbReportAll.Size = new System.Drawing.Size(103, 32);
            this.rdbReportAll.TabIndex = 0;
            this.rdbReportAll.Text = "ລາຍງານທັງໝົດ";
            this.rdbReportAll.CheckedChanged += new System.EventHandler(this.rdbReportAll_CheckedChanged);
            // 
            // rdbReportThisYear
            // 
            this.rdbReportThisYear.BaseColor = System.Drawing.Color.White;
            this.rdbReportThisYear.CheckedOffColor = System.Drawing.Color.Black;
            this.rdbReportThisYear.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.rdbReportThisYear.FillColor = System.Drawing.Color.White;
            this.rdbReportThisYear.Location = new System.Drawing.Point(46, 199);
            this.rdbReportThisYear.Name = "rdbReportThisYear";
            this.rdbReportThisYear.Size = new System.Drawing.Size(98, 32);
            this.rdbReportThisYear.TabIndex = 0;
            this.rdbReportThisYear.Text = "ລາຍງານເປັນປີ";
            // 
            // rdbReportMonth
            // 
            this.rdbReportMonth.BaseColor = System.Drawing.Color.White;
            this.rdbReportMonth.CheckedOffColor = System.Drawing.Color.Black;
            this.rdbReportMonth.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.rdbReportMonth.FillColor = System.Drawing.Color.White;
            this.rdbReportMonth.Location = new System.Drawing.Point(46, 158);
            this.rdbReportMonth.Name = "rdbReportMonth";
            this.rdbReportMonth.Size = new System.Drawing.Size(118, 32);
            this.rdbReportMonth.TabIndex = 0;
            this.rdbReportMonth.Text = "ລາຍງານເປັນເດືອນ";
            // 
            // rdb
            // 
            this.rdb.BaseColor = System.Drawing.Color.White;
            this.rdb.CheckedOffColor = System.Drawing.Color.Black;
            this.rdb.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.rdb.FillColor = System.Drawing.Color.White;
            this.rdb.Location = new System.Drawing.Point(46, 117);
            this.rdb.Name = "rdb";
            this.rdb.Size = new System.Drawing.Size(100, 32);
            this.rdb.TabIndex = 0;
            this.rdb.Text = "ລາຍງານປະທິດ";
            // 
            // rdbReportDate
            // 
            this.rdbReportDate.BaseColor = System.Drawing.Color.White;
            this.rdbReportDate.CheckedOffColor = System.Drawing.Color.Black;
            this.rdbReportDate.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.rdbReportDate.FillColor = System.Drawing.Color.White;
            this.rdbReportDate.Location = new System.Drawing.Point(46, 76);
            this.rdbReportDate.Name = "rdbReportDate";
            this.rdbReportDate.Size = new System.Drawing.Size(111, 32);
            this.rdbReportDate.TabIndex = 0;
            this.rdbReportDate.Text = "ລາຍງານປະຈຳວັນ";
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker1.BorderSize = 0;
            this.gunaDateTimePicker1.CustomFormat = null;
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(14, 366);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.OnPressedDepth = 3;
            this.gunaDateTimePicker1.Radius = 2;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(267, 41);
            this.gunaDateTimePicker1.TabIndex = 1;
            this.gunaDateTimePicker1.Text = "17-07-2020";
            this.gunaDateTimePicker1.Value = new System.DateTime(2020, 7, 17, 18, 9, 41, 568);
            // 
            // gunaDateTimePicker2
            // 
            this.gunaDateTimePicker2.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker2.BorderColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker2.BorderSize = 0;
            this.gunaDateTimePicker2.CustomFormat = null;
            this.gunaDateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaDateTimePicker2.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDateTimePicker2.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gunaDateTimePicker2.Location = new System.Drawing.Point(14, 495);
            this.gunaDateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker2.Name = "gunaDateTimePicker2";
            this.gunaDateTimePicker2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaDateTimePicker2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.gunaDateTimePicker2.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker2.OnPressedDepth = 3;
            this.gunaDateTimePicker2.Radius = 2;
            this.gunaDateTimePicker2.Size = new System.Drawing.Size(267, 41);
            this.gunaDateTimePicker2.TabIndex = 1;
            this.gunaDateTimePicker2.Text = "17-07-2020";
            this.gunaDateTimePicker2.Value = new System.DateTime(2020, 7, 17, 18, 4, 42, 39);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "ວັນທີ່ສິນສຸດ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "ວັນທີເລີ່ມຕົ້ນ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmReport_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1196, 818);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmReport_Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport_Sale";
            this.Load += new System.EventHandler(this.frmReport_Sale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Label Report;
        private Guna.UI.WinForms.GunaRadioButton rdb;
        private Guna.UI.WinForms.GunaRadioButton rdbReportMonth;
        private Guna.UI.WinForms.GunaRadioButton rdbReportThisYear;
        private Guna.UI.WinForms.GunaRadioButton rdbReportAll;
        private Guna.UI.WinForms.GunaRadioButton rdbReportDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker2;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}