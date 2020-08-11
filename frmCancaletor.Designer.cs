namespace ProjectCoffee
{
    partial class frmCancaletor
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlTaskBar = new Guna.UI.WinForms.GunaLinePanel();
            this.btMinimam = new Guna.UI.WinForms.GunaButton();
            this.btClose = new Guna.UI.WinForms.GunaButton();
            this.cbMostTop = new Guna.UI.WinForms.GunaCheckBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSet = new Guna.UI.WinForms.GunaTextBox();
            this.txtGet = new Guna.UI.WinForms.GunaTextBox();
            this.txtAll = new Guna.UI.WinForms.GunaTextBox();
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pnlTaskBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // pnlTaskBar
            // 
            this.pnlTaskBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.pnlTaskBar.Controls.Add(this.label5);
            this.pnlTaskBar.Controls.Add(this.btMinimam);
            this.pnlTaskBar.Controls.Add(this.btClose);
            this.pnlTaskBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTaskBar.LineColor = System.Drawing.Color.Black;
            this.pnlTaskBar.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlTaskBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTaskBar.Name = "pnlTaskBar";
            this.pnlTaskBar.Size = new System.Drawing.Size(393, 32);
            this.pnlTaskBar.TabIndex = 8;
            this.pnlTaskBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTaskBar_MouseDown);
            this.pnlTaskBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTaskBar_MouseMove);
            this.pnlTaskBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTaskBar_MouseUp);
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
            this.btMinimam.Location = new System.Drawing.Point(325, 3);
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
            this.btClose.Location = new System.Drawing.Point(361, 3);
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
            // cbMostTop
            // 
            this.cbMostTop.BaseColor = System.Drawing.Color.White;
            this.cbMostTop.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.cbMostTop.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbMostTop.FillColor = System.Drawing.Color.White;
            this.cbMostTop.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMostTop.Location = new System.Drawing.Point(12, 257);
            this.cbMostTop.Name = "cbMostTop";
            this.cbMostTop.Size = new System.Drawing.Size(109, 32);
            this.cbMostTop.TabIndex = 10;
            this.cbMostTop.Text = "ສະແດງຢູ່ເທິງສຸດ";
            this.cbMostTop.CheckedChanged += new System.EventHandler(this.cbMostTop_CheckedChanged);
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Image = global::ProjectCoffee.Properties.Resources.save;
            this.btSave.Location = new System.Drawing.Point(292, 254);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(89, 39);
            this.btSave.TabIndex = 11;
            this.btSave.Text = "ບັນທືກ";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lao_Ketmany2", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "ເງິນຖອນ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lao_Ketmany2", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "ເງິນທີ່ໄດ້ຮັບ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lao_Ketmany2", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "ເງິນທັງໝົດ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lao_Ketmany2", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "ຄິດໄລ່ເງິນຖອນ";
            // 
            // txtSet
            // 
            this.txtSet.BackColor = System.Drawing.Color.Transparent;
            this.txtSet.BaseColor = System.Drawing.Color.White;
            this.txtSet.BorderColor = System.Drawing.Color.Silver;
            this.txtSet.BorderSize = 1;
            this.txtSet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSet.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSet.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txtSet.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSet.Font = new System.Drawing.Font("Lao_Ketmany2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSet.Location = new System.Drawing.Point(122, 193);
            this.txtSet.Name = "txtSet";
            this.txtSet.PasswordChar = '\0';
            this.txtSet.Radius = 2;
            this.txtSet.Size = new System.Drawing.Size(259, 44);
            this.txtSet.TabIndex = 12;
            // 
            // txtGet
            // 
            this.txtGet.BackColor = System.Drawing.Color.Transparent;
            this.txtGet.BaseColor = System.Drawing.Color.White;
            this.txtGet.BorderColor = System.Drawing.Color.Silver;
            this.txtGet.BorderSize = 1;
            this.txtGet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGet.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGet.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txtGet.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGet.Font = new System.Drawing.Font("Lao_Ketmany2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGet.Location = new System.Drawing.Point(122, 143);
            this.txtGet.Name = "txtGet";
            this.txtGet.PasswordChar = '\0';
            this.txtGet.Radius = 2;
            this.txtGet.Size = new System.Drawing.Size(259, 44);
            this.txtGet.TabIndex = 0;
            this.txtGet.TextChanged += new System.EventHandler(this.txtGet_TextChanged);
            this.txtGet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGet_KeyPress);
            // 
            // txtAll
            // 
            this.txtAll.BackColor = System.Drawing.Color.Transparent;
            this.txtAll.BaseColor = System.Drawing.Color.White;
            this.txtAll.BorderColor = System.Drawing.Color.Silver;
            this.txtAll.BorderSize = 1;
            this.txtAll.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAll.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAll.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txtAll.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAll.Font = new System.Drawing.Font("Lao_Ketmany2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAll.Location = new System.Drawing.Point(122, 93);
            this.txtAll.Name = "txtAll";
            this.txtAll.PasswordChar = '\0';
            this.txtAll.Radius = 2;
            this.txtAll.Size = new System.Drawing.Size(259, 44);
            this.txtAll.TabIndex = 14;
            // 
            // gunaAnimateWindow1
            // 
            this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
            this.gunaAnimateWindow1.Interval = 200;
            this.gunaAnimateWindow1.TargetControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cucalate Money";
            // 
            // frmCancaletor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(393, 306);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSet);
            this.Controls.Add(this.txtGet);
            this.Controls.Add(this.txtAll);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.cbMostTop);
            this.Controls.Add(this.pnlTaskBar);
            this.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCancaletor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCancaletor";
            this.Load += new System.EventHandler(this.frmCancaletor_Load);
            this.pnlTaskBar.ResumeLayout(false);
            this.pnlTaskBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLinePanel pnlTaskBar;
        private Guna.UI.WinForms.GunaButton btMinimam;
        private Guna.UI.WinForms.GunaButton btClose;
        private Guna.UI.WinForms.GunaCheckBox cbMostTop;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtSet;
        private Guna.UI.WinForms.GunaTextBox txtGet;
        private Guna.UI.WinForms.GunaTextBox txtAll;
        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
        private System.Windows.Forms.Label label5;
    }
}