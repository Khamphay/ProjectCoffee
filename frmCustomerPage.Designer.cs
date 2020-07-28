namespace ProjectCoffee
{
    partial class frmCustomerPage
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
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbBill = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPrice_Total_display = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.lbQtyTotal_display = new System.Windows.Forms.Label();
            this.AnimatedWinFrm = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.pnlTaskBar = new Guna.UI.WinForms.GunaLinePanel();
            this.Maximam = new Guna.UI.WinForms.GunaButton();
            this.btMinimam = new Guna.UI.WinForms.GunaButton();
            this.btClose = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaResize1 = new Guna.UI.WinForms.GunaResize(this.components);
            this.gunaLinePanel2.SuspendLayout();
            this.pnlTaskBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.gunaLinePanel2.Controls.Add(this.label5);
            this.gunaLinePanel2.Controls.Add(this.txtSearch);
            this.gunaLinePanel2.Controls.Add(this.lbBill);
            this.gunaLinePanel2.Controls.Add(this.label4);
            this.gunaLinePanel2.Controls.Add(this.lbPrice_Total_display);
            this.gunaLinePanel2.Controls.Add(this.label2);
            this.gunaLinePanel2.Controls.Add(this.label3);
            this.gunaLinePanel2.Controls.Add(this.label1);
            this.gunaLinePanel2.Controls.Add(this.btCancel);
            this.gunaLinePanel2.Controls.Add(this.btAdd);
            this.gunaLinePanel2.Controls.Add(this.lbQtyTotal_display);
            this.gunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.DimGray;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(0, 32);
            this.gunaLinePanel2.MinimumSize = new System.Drawing.Size(1190, 72);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(1254, 72);
            this.gunaLinePanel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "ຄົ້ນຫາ:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(494, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(238, 36);
            this.txtSearch.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtSearch, "Shearch");
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lbBill
            // 
            this.lbBill.AutoSize = true;
            this.lbBill.Location = new System.Drawing.Point(52, 24);
            this.lbBill.Name = "lbBill";
            this.lbBill.Size = new System.Drawing.Size(48, 28);
            this.lbBill.TabIndex = 4;
            this.lbBill.Text = "00/00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "ເລກບິນ:";
            // 
            // lbPrice_Total_display
            // 
            this.lbPrice_Total_display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice_Total_display.AutoSize = true;
            this.lbPrice_Total_display.Location = new System.Drawing.Point(1083, 24);
            this.lbPrice_Total_display.Name = "lbPrice_Total_display";
            this.lbPrice_Total_display.Size = new System.Drawing.Size(59, 28);
            this.lbPrice_Total_display.TabIndex = 1;
            this.lbPrice_Total_display.Text = "0.00 ກີບ";
            this.lbPrice_Total_display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1004, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "ລາຄາທັງໝົດ:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(935, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "ຈອກ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(812, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "ຈຳນວນທັງໝົດ:";
            // 
            // btCancel
            // 
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Image = global::ProjectCoffee.Properties.Resources.delete;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancel.Location = new System.Drawing.Point(314, 19);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(89, 39);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "ຍົກເລີກ";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btCancel, "Cancel");
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAdd
            // 
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Image = global::ProjectCoffee.Properties.Resources.save;
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdd.Location = new System.Drawing.Point(213, 19);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(89, 39);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "ສັ່ງຊື້";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btAdd, "Buy");
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbQtyTotal_display
            // 
            this.lbQtyTotal_display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQtyTotal_display.AutoSize = true;
            this.lbQtyTotal_display.Location = new System.Drawing.Point(902, 24);
            this.lbQtyTotal_display.Name = "lbQtyTotal_display";
            this.lbQtyTotal_display.Size = new System.Drawing.Size(20, 28);
            this.lbQtyTotal_display.TabIndex = 0;
            this.lbQtyTotal_display.Text = "0";
            this.lbQtyTotal_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnimatedWinFrm
            // 
            this.AnimatedWinFrm.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
            this.AnimatedWinFrm.Interval = 200;
            this.AnimatedWinFrm.TargetControl = this;
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
            this.pnlTaskBar.Size = new System.Drawing.Size(1254, 32);
            this.pnlTaskBar.TabIndex = 7;
            this.pnlTaskBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaLinePanel1_MouseDown);
            this.pnlTaskBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gunaLinePanel1_MouseMove);
            this.pnlTaskBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gunaLinePanel1_MouseUp);
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
            this.Maximam.Location = new System.Drawing.Point(1182, 4);
            this.Maximam.Name = "Maximam";
            this.Maximam.OnHoverBaseColor = System.Drawing.Color.White;
            this.Maximam.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Maximam.OnHoverForeColor = System.Drawing.Color.White;
            this.Maximam.OnHoverImage = null;
            this.Maximam.OnPressedColor = System.Drawing.Color.Black;
            this.Maximam.Radius = 4;
            this.Maximam.Size = new System.Drawing.Size(25, 25);
            this.Maximam.TabIndex = 17;
            this.toolTip1.SetToolTip(this.Maximam, "Maximize");
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
            this.btMinimam.Location = new System.Drawing.Point(1141, 4);
            this.btMinimam.Name = "btMinimam";
            this.btMinimam.OnHoverBaseColor = System.Drawing.Color.White;
            this.btMinimam.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btMinimam.OnHoverForeColor = System.Drawing.Color.White;
            this.btMinimam.OnHoverImage = null;
            this.btMinimam.OnPressedColor = System.Drawing.Color.Black;
            this.btMinimam.Radius = 4;
            this.btMinimam.Size = new System.Drawing.Size(25, 25);
            this.btMinimam.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btMinimam, "Minimize");
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
            this.btClose.Location = new System.Drawing.Point(1222, 3);
            this.btClose.Name = "btClose";
            this.btClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btClose.OnHoverImage = null;
            this.btClose.OnPressedColor = System.Drawing.Color.Black;
            this.btClose.Radius = 4;
            this.btClose.Size = new System.Drawing.Size(25, 25);
            this.btClose.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btClose, "Close");
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // flPnl
            // 
            this.flPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flPnl.AutoScroll = true;
            this.flPnl.Location = new System.Drawing.Point(8, 112);
            this.flPnl.Name = "flPnl";
            this.flPnl.Size = new System.Drawing.Size(1239, 519);
            this.flPnl.TabIndex = 8;
            // 
            // gunaResize1
            // 
            this.gunaResize1.TargetForm = this;
            // 
            // frmCustomerPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(665, 0);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1254, 637);
            this.Controls.Add(this.flPnl);
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.pnlTaskBar);
            this.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomerPage";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerPage";
            this.Load += new System.EventHandler(this.frmCustomerPage_Load);
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            this.pnlTaskBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private System.Windows.Forms.Label lbPrice_Total_display;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lbQtyTotal_display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btCancel;
        public Guna.UI.WinForms.GunaAnimateWindow AnimatedWinFrm;
        private Guna.UI.WinForms.GunaLinePanel pnlTaskBar;
        private Guna.UI.WinForms.GunaButton btClose;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton Maximam;
        private Guna.UI.WinForms.GunaButton btMinimam;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel flPnl;
        private Guna.UI.WinForms.GunaResize gunaResize1;
    }
}