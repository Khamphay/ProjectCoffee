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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaDateTimePicker2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.rdbReportDate = new Guna.UI.WinForms.GunaRadioButton();
            this.rdbReportMonth = new Guna.UI.WinForms.GunaRadioButton();
            this.rdbReportThisYear = new Guna.UI.WinForms.GunaRadioButton();
            this.rdbReportAll = new Guna.UI.WinForms.GunaRadioButton();
            this.Report = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlTaskBar = new Guna.UI.WinForms.GunaLinePanel();
            this.Maximam = new Guna.UI.WinForms.GunaButton();
            this.btClose = new Guna.UI.WinForms.GunaButton();
            this.btMinimam = new Guna.UI.WinForms.GunaButton();
            this.AnimateWinForm = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.pnlTaskBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaGroupBox1);
            this.panel1.Controls.Add(this.Report);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 605);
            this.panel1.TabIndex = 0;
            // 
            // gunaGroupBox1
            // 
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
            this.gunaGroupBox1.Controls.Add(this.rdbReportMonth);
            this.gunaGroupBox1.Controls.Add(this.rdbReportThisYear);
            this.gunaGroupBox1.Controls.Add(this.rdbReportAll);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaGroupBox1.LineBottom = 1;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Black;
            this.gunaGroupBox1.LineLeft = 1;
            this.gunaGroupBox1.LineRight = 1;
            this.gunaGroupBox1.LineTop = 1;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 2;
            this.gunaGroupBox1.Size = new System.Drawing.Size(295, 605);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Choose Report";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show";
            this.toolTip1.SetToolTip(this.button1, "Show Report");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "ວັນທີເລີ່ມຕົ້ນ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "ວັນທີ່ສິນສຸດ";
            // 
            // gunaDateTimePicker2
            // 
            this.gunaDateTimePicker2.BackColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker2.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker2.BorderColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker2.BorderSize = 0;
            this.gunaDateTimePicker2.CustomFormat = null;
            this.gunaDateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaDateTimePicker2.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDateTimePicker2.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gunaDateTimePicker2.Location = new System.Drawing.Point(14, 391);
            this.gunaDateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker2.Name = "gunaDateTimePicker2";
            this.gunaDateTimePicker2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaDateTimePicker2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.gunaDateTimePicker2.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker2.OnPressedDepth = 3;
            this.gunaDateTimePicker2.Radius = 2;
            this.gunaDateTimePicker2.Size = new System.Drawing.Size(267, 36);
            this.gunaDateTimePicker2.TabIndex = 1;
            this.gunaDateTimePicker2.Text = "17-07-2020";
            this.gunaDateTimePicker2.Value = new System.DateTime(2020, 7, 17, 18, 4, 42, 39);
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker1.BorderSize = 0;
            this.gunaDateTimePicker1.CustomFormat = null;
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(14, 299);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.OnPressedDepth = 3;
            this.gunaDateTimePicker1.Radius = 2;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(267, 36);
            this.gunaDateTimePicker1.TabIndex = 1;
            this.gunaDateTimePicker1.Text = "17-07-2020";
            this.gunaDateTimePicker1.Value = new System.DateTime(2020, 7, 17, 18, 9, 41, 568);
            // 
            // rdbReportDate
            // 
            this.rdbReportDate.BaseColor = System.Drawing.Color.White;
            this.rdbReportDate.CheckedOffColor = System.Drawing.Color.Black;
            this.rdbReportDate.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.rdbReportDate.FillColor = System.Drawing.Color.White;
            this.rdbReportDate.Location = new System.Drawing.Point(46, 77);
            this.rdbReportDate.Name = "rdbReportDate";
            this.rdbReportDate.Size = new System.Drawing.Size(104, 20);
            this.rdbReportDate.TabIndex = 0;
            this.rdbReportDate.Text = "ລາຍງານປະຈຳວັນ";
            this.rdbReportDate.CheckedChanged += new System.EventHandler(this.rdbReportDate_CheckedChanged);
            // 
            // rdbReportMonth
            // 
            this.rdbReportMonth.BaseColor = System.Drawing.Color.White;
            this.rdbReportMonth.CheckedOffColor = System.Drawing.Color.Black;
            this.rdbReportMonth.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.rdbReportMonth.FillColor = System.Drawing.Color.White;
            this.rdbReportMonth.Location = new System.Drawing.Point(46, 120);
            this.rdbReportMonth.Name = "rdbReportMonth";
            this.rdbReportMonth.Size = new System.Drawing.Size(111, 20);
            this.rdbReportMonth.TabIndex = 0;
            this.rdbReportMonth.Text = "ລາຍງານເປັນເດືອນ";
            this.rdbReportMonth.CheckedChanged += new System.EventHandler(this.rdbReportMonth_CheckedChanged);
            // 
            // rdbReportThisYear
            // 
            this.rdbReportThisYear.BaseColor = System.Drawing.Color.White;
            this.rdbReportThisYear.CheckedOffColor = System.Drawing.Color.Black;
            this.rdbReportThisYear.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.rdbReportThisYear.FillColor = System.Drawing.Color.White;
            this.rdbReportThisYear.Location = new System.Drawing.Point(46, 164);
            this.rdbReportThisYear.Name = "rdbReportThisYear";
            this.rdbReportThisYear.Size = new System.Drawing.Size(93, 20);
            this.rdbReportThisYear.TabIndex = 0;
            this.rdbReportThisYear.Text = "ລາຍງານເປັນປີ";
            this.rdbReportThisYear.CheckedChanged += new System.EventHandler(this.rdbReportThisYear_CheckedChanged);
            // 
            // rdbReportAll
            // 
            this.rdbReportAll.BaseColor = System.Drawing.Color.White;
            this.rdbReportAll.Checked = true;
            this.rdbReportAll.CheckedOffColor = System.Drawing.Color.Black;
            this.rdbReportAll.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.rdbReportAll.FillColor = System.Drawing.Color.White;
            this.rdbReportAll.Location = new System.Drawing.Point(46, 208);
            this.rdbReportAll.Name = "rdbReportAll";
            this.rdbReportAll.Size = new System.Drawing.Size(99, 20);
            this.rdbReportAll.TabIndex = 0;
            this.rdbReportAll.Text = "ລາຍງານທັງໝົດ";
            this.rdbReportAll.CheckedChanged += new System.EventHandler(this.rdbReportAll_CheckedChanged);
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
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(304, 32);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(896, 605);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // pnlTaskBar
            // 
            this.pnlTaskBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.pnlTaskBar.Controls.Add(this.Maximam);
            this.pnlTaskBar.Controls.Add(this.btClose);
            this.pnlTaskBar.Controls.Add(this.btMinimam);
            this.pnlTaskBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTaskBar.LineColor = System.Drawing.Color.Black;
            this.pnlTaskBar.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlTaskBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTaskBar.Name = "pnlTaskBar";
            this.pnlTaskBar.Size = new System.Drawing.Size(1200, 32);
            this.pnlTaskBar.TabIndex = 13;
            this.pnlTaskBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTaskBar_MouseDown);
            this.pnlTaskBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTaskBar_MouseMove);
            this.pnlTaskBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTaskBar_MouseUp);
            // 
            // Maximam
            // 
            this.Maximam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximam.AnimationHoverSpeed = 0.07F;
            this.Maximam.AnimationSpeed = 0.03F;
            this.Maximam.BackColor = System.Drawing.Color.Transparent;
            this.Maximam.BaseColor = System.Drawing.Color.Transparent;
            this.Maximam.BorderColor = System.Drawing.Color.Black;
            this.Maximam.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Maximam.FocusedColor = System.Drawing.Color.Empty;
            this.Maximam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Maximam.ForeColor = System.Drawing.Color.White;
            this.Maximam.Image = global::ProjectCoffee.Properties.Resources.restore_window;
            this.Maximam.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Maximam.ImageSize = new System.Drawing.Size(23, 23);
            this.Maximam.Location = new System.Drawing.Point(1127, 4);
            this.Maximam.Name = "Maximam";
            this.Maximam.OnHoverBaseColor = System.Drawing.Color.White;
            this.Maximam.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Maximam.OnHoverForeColor = System.Drawing.Color.White;
            this.Maximam.OnHoverImage = null;
            this.Maximam.OnPressedColor = System.Drawing.Color.Black;
            this.Maximam.Radius = 4;
            this.Maximam.Size = new System.Drawing.Size(25, 25);
            this.Maximam.TabIndex = 15;
            this.toolTip1.SetToolTip(this.Maximam, "Maximize");
            this.Maximam.Click += new System.EventHandler(this.Maximam_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.AnimationHoverSpeed = 0.07F;
            this.btClose.AnimationSpeed = 0.03F;
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.BaseColor = System.Drawing.Color.Transparent;
            this.btClose.BorderColor = System.Drawing.Color.Black;
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btClose.FocusedColor = System.Drawing.Color.Empty;
            this.btClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Image = global::ProjectCoffee.Properties.Resources.delete;
            this.btClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btClose.Location = new System.Drawing.Point(1168, 4);
            this.btClose.Name = "btClose";
            this.btClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btClose.OnHoverImage = null;
            this.btClose.OnPressedColor = System.Drawing.Color.Black;
            this.btClose.Radius = 4;
            this.btClose.Size = new System.Drawing.Size(25, 25);
            this.btClose.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btClose, "Close");
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btMinimam
            // 
            this.btMinimam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimam.AnimationHoverSpeed = 0.07F;
            this.btMinimam.AnimationSpeed = 0.03F;
            this.btMinimam.BackColor = System.Drawing.Color.Transparent;
            this.btMinimam.BaseColor = System.Drawing.Color.Transparent;
            this.btMinimam.BorderColor = System.Drawing.Color.Black;
            this.btMinimam.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btMinimam.FocusedColor = System.Drawing.Color.Empty;
            this.btMinimam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btMinimam.ForeColor = System.Drawing.Color.White;
            this.btMinimam.Image = global::ProjectCoffee.Properties.Resources.minus;
            this.btMinimam.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btMinimam.ImageSize = new System.Drawing.Size(20, 20);
            this.btMinimam.Location = new System.Drawing.Point(1086, 4);
            this.btMinimam.Name = "btMinimam";
            this.btMinimam.OnHoverBaseColor = System.Drawing.Color.White;
            this.btMinimam.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btMinimam.OnHoverForeColor = System.Drawing.Color.White;
            this.btMinimam.OnHoverImage = null;
            this.btMinimam.OnPressedColor = System.Drawing.Color.Black;
            this.btMinimam.Radius = 4;
            this.btMinimam.Size = new System.Drawing.Size(25, 25);
            this.btMinimam.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btMinimam, "Minimize");
            this.btMinimam.Click += new System.EventHandler(this.btMinimam_Click);
            // 
            // AnimateWinForm
            // 
            this.AnimateWinForm.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
            this.AnimateWinForm.Interval = 200;
            this.AnimateWinForm.TargetControl = this;
            // 
            // frmReport_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1200, 637);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTaskBar);
            this.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmReport_Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport_Sale";
            this.Load += new System.EventHandler(this.frmReport_Sale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.pnlTaskBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Label Report;
        private Guna.UI.WinForms.GunaRadioButton rdbReportMonth;
        private Guna.UI.WinForms.GunaRadioButton rdbReportThisYear;
        private Guna.UI.WinForms.GunaRadioButton rdbReportAll;
        private Guna.UI.WinForms.GunaRadioButton rdbReportDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker2;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLinePanel pnlTaskBar;
        private Guna.UI.WinForms.GunaButton Maximam;
        private Guna.UI.WinForms.GunaButton btClose;
        private Guna.UI.WinForms.GunaButton btMinimam;
        public Guna.UI.WinForms.GunaAnimateWindow AnimateWinForm;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}