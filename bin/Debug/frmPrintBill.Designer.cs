namespace ProjectCoffee
{
    partial class frmPrintBill
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTable_Rport = new ProjectCoffee.dsTable_Rport();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaResize1 = new Guna.UI.WinForms.GunaResize(this.components);
            this.pnlTaskBar = new Guna.UI.WinForms.GunaLinePanel();
            this.Maximam = new Guna.UI.WinForms.GunaButton();
            this.btMinimam = new Guna.UI.WinForms.GunaButton();
            this.btClose = new Guna.UI.WinForms.GunaButton();
            this.gunaResize2 = new Guna.UI.WinForms.GunaResize(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTable_Rport)).BeginInit();
            this.pnlTaskBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBillBindingSource
            // 
            this.tbBillBindingSource.DataMember = "tbBill";
            this.tbBillBindingSource.DataSource = this.dsTable_Rport;
            // 
            // dsTable_Rport
            // 
            this.dsTable_Rport.DataSetName = "dsTable_Rport";
            this.dsTable_Rport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaResize1
            // 
            this.gunaResize1.TargetForm = this;
            // 
            // pnlTaskBar
            // 
            this.pnlTaskBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.pnlTaskBar.Controls.Add(this.Maximam);
            this.pnlTaskBar.Controls.Add(this.btMinimam);
            this.pnlTaskBar.Controls.Add(this.btClose);
            this.pnlTaskBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTaskBar.LineColor = System.Drawing.Color.Black;
            this.pnlTaskBar.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlTaskBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTaskBar.Name = "pnlTaskBar";
            this.pnlTaskBar.Size = new System.Drawing.Size(686, 32);
            this.pnlTaskBar.TabIndex = 8;
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
            this.Maximam.Location = new System.Drawing.Point(614, 4);
            this.Maximam.Name = "Maximam";
            this.Maximam.OnHoverBaseColor = System.Drawing.Color.White;
            this.Maximam.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Maximam.OnHoverForeColor = System.Drawing.Color.White;
            this.Maximam.OnHoverImage = null;
            this.Maximam.OnPressedColor = System.Drawing.Color.Black;
            this.Maximam.Radius = 4;
            this.Maximam.Size = new System.Drawing.Size(25, 25);
            this.Maximam.TabIndex = 17;
            this.Maximam.Click += new System.EventHandler(this.Maximam_Click);
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
            this.btMinimam.Location = new System.Drawing.Point(573, 4);
            this.btMinimam.Name = "btMinimam";
            this.btMinimam.OnHoverBaseColor = System.Drawing.Color.White;
            this.btMinimam.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btMinimam.OnHoverForeColor = System.Drawing.Color.White;
            this.btMinimam.OnHoverImage = null;
            this.btMinimam.OnPressedColor = System.Drawing.Color.Black;
            this.btMinimam.Radius = 4;
            this.btMinimam.Size = new System.Drawing.Size(25, 25);
            this.btMinimam.TabIndex = 18;
            this.btMinimam.Click += new System.EventHandler(this.btMinimam_Click);
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
            this.btClose.Image = global::ProjectCoffee.Properties.Resources.cancel;
            this.btClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btClose.Location = new System.Drawing.Point(654, 3);
            this.btClose.Name = "btClose";
            this.btClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btClose.OnHoverImage = null;
            this.btClose.OnPressedColor = System.Drawing.Color.Black;
            this.btClose.Radius = 4;
            this.btClose.Size = new System.Drawing.Size(25, 25);
            this.btClose.TabIndex = 16;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // gunaResize2
            // 
            this.gunaResize2.TargetForm = this;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbBillBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectCoffee.rdBillSale.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 34);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(678, 508);
            this.reportViewer1.TabIndex = 9;
            // 
            // frmPrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(686, 547);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pnlTaskBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrintBill";
            this.Text = "frmPrintBill";
            this.Load += new System.EventHandler(this.frmPrintBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTable_Rport)).EndInit();
            this.pnlTaskBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaResize gunaResize1;
        private Guna.UI.WinForms.GunaLinePanel pnlTaskBar;
        private Guna.UI.WinForms.GunaButton Maximam;
        private Guna.UI.WinForms.GunaButton btMinimam;
        private Guna.UI.WinForms.GunaButton btClose;
        private Guna.UI.WinForms.GunaResize gunaResize2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbBillBindingSource;
        private dsTable_Rport dsTable_Rport;
    }
}