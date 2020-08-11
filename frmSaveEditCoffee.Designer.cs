namespace ProjectCoffee
{
    partial class frmSaveEditCoffee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaveEditCoffee));
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaleprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.cbCatg = new System.Windows.Forms.ComboBox();
            this.picCoffee = new System.Windows.Forms.PictureBox();
            this.btChooseImg = new System.Windows.Forms.Button();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.pnlTaskBar = new Guna.UI.WinForms.GunaLinePanel();
            this.lbCaption = new System.Windows.Forms.Label();
            this.btClose = new Guna.UI.WinForms.GunaButton();
            this.btMinimam = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCoffee)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.pnlTaskBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Location = new System.Drawing.Point(258, 431);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(63, 36);
            this.btCancel.TabIndex = 17;
            this.btCancel.Text = "ຍົກເລີກ";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Location = new System.Drawing.Point(156, 431);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(63, 36);
            this.btSave.TabIndex = 18;
            this.btSave.Text = "ບັນທືກ";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "ປະເພດ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "ຫົວໜ່ວຍ";
            // 
            // txtSaleprice
            // 
            this.txtSaleprice.Location = new System.Drawing.Point(34, 314);
            this.txtSaleprice.Name = "txtSaleprice";
            this.txtSaleprice.Size = new System.Drawing.Size(210, 36);
            this.txtSaleprice.TabIndex = 3;
            this.txtSaleprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "ລາຄາຂາຍ";
            // 
            // txtImprice
            // 
            this.txtImprice.Location = new System.Drawing.Point(34, 244);
            this.txtImprice.Name = "txtImprice";
            this.txtImprice.Size = new System.Drawing.Size(210, 36);
            this.txtImprice.TabIndex = 2;
            this.txtImprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "ລາຄານຳເຂົ້າ";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(34, 171);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(210, 36);
            this.txtname.TabIndex = 1;
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "ຊື່ກາເຟ";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(34, 93);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(210, 36);
            this.txtid.TabIndex = 0;
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "ລະຫັດ";
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(258, 93);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(210, 36);
            this.cbUnit.TabIndex = 6;
            this.cbUnit.SelectedIndexChanged += new System.EventHandler(this.cbUnit_SelectedIndexChanged);
            this.cbUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // cbCatg
            // 
            this.cbCatg.FormattingEnabled = true;
            this.cbCatg.Location = new System.Drawing.Point(258, 171);
            this.cbCatg.Name = "cbCatg";
            this.cbCatg.Size = new System.Drawing.Size(210, 36);
            this.cbCatg.TabIndex = 5;
            this.cbCatg.SelectedIndexChanged += new System.EventHandler(this.cbCatg_SelectedIndexChanged);
            this.cbCatg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // picCoffee
            // 
            this.picCoffee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCoffee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCoffee.Location = new System.Drawing.Point(0, 0);
            this.picCoffee.Name = "picCoffee";
            this.picCoffee.Size = new System.Drawing.Size(210, 137);
            this.picCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoffee.TabIndex = 0;
            this.picCoffee.TabStop = false;
            this.picCoffee.Click += new System.EventHandler(this.picCoffee_Click);
            // 
            // btChooseImg
            // 
            this.btChooseImg.FlatAppearance.BorderSize = 0;
            this.btChooseImg.Image = ((System.Drawing.Image)(resources.GetObject("btChooseImg.Image")));
            this.btChooseImg.Location = new System.Drawing.Point(334, 356);
            this.btChooseImg.Name = "btChooseImg";
            this.btChooseImg.Size = new System.Drawing.Size(39, 33);
            this.btChooseImg.TabIndex = 18;
            this.btChooseImg.UseVisualStyleBackColor = true;
            this.btChooseImg.Click += new System.EventHandler(this.btChooseImg_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.picCoffee);
            this.gunaGroupBox1.LineBottom = 1;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineLeft = 1;
            this.gunaGroupBox1.LineRight = 1;
            this.gunaGroupBox1.LineTop = 1;
            this.gunaGroupBox1.Location = new System.Drawing.Point(258, 213);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 2;
            this.gunaGroupBox1.Size = new System.Drawing.Size(210, 137);
            this.gunaGroupBox1.TabIndex = 1;
            this.gunaGroupBox1.Text = "ຮູບພາບ";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // pnlTaskBar
            // 
            this.pnlTaskBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.pnlTaskBar.Controls.Add(this.lbCaption);
            this.pnlTaskBar.Controls.Add(this.btClose);
            this.pnlTaskBar.Controls.Add(this.btMinimam);
            this.pnlTaskBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTaskBar.LineColor = System.Drawing.Color.Black;
            this.pnlTaskBar.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlTaskBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTaskBar.Name = "pnlTaskBar";
            this.pnlTaskBar.Size = new System.Drawing.Size(518, 32);
            this.pnlTaskBar.TabIndex = 19;
            this.pnlTaskBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTaskBar_MouseDown);
            this.pnlTaskBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTaskBar_MouseMove);
            this.pnlTaskBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTaskBar_MouseUp);
            // 
            // lbCaption
            // 
            this.lbCaption.AutoSize = true;
            this.lbCaption.ForeColor = System.Drawing.Color.White;
            this.lbCaption.Location = new System.Drawing.Point(3, 2);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(43, 28);
            this.lbCaption.TabIndex = 20;
            this.lbCaption.Text = "Save";
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
            this.btClose.Location = new System.Drawing.Point(486, 4);
            this.btClose.Name = "btClose";
            this.btClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btClose.OnHoverImage = null;
            this.btClose.OnPressedColor = System.Drawing.Color.Black;
            this.btClose.Radius = 4;
            this.btClose.Size = new System.Drawing.Size(25, 25);
            this.btClose.TabIndex = 15;
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
            this.btMinimam.Location = new System.Drawing.Point(443, 4);
            this.btMinimam.Name = "btMinimam";
            this.btMinimam.OnHoverBaseColor = System.Drawing.Color.White;
            this.btMinimam.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btMinimam.OnHoverForeColor = System.Drawing.Color.White;
            this.btMinimam.OnHoverImage = null;
            this.btMinimam.OnPressedColor = System.Drawing.Color.Black;
            this.btMinimam.Radius = 4;
            this.btMinimam.Size = new System.Drawing.Size(25, 25);
            this.btMinimam.TabIndex = 15;
            this.btMinimam.Click += new System.EventHandler(this.btMinimam_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // frmSaveEditCoffee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(518, 504);
            this.Controls.Add(this.pnlTaskBar);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.cbCatg);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btChooseImg);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSaleprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(518, 504);
            this.MinimumSize = new System.Drawing.Size(518, 504);
            this.Name = "frmSaveEditCoffee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSaveEditCoffee";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picCoffee)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.pnlTaskBar.ResumeLayout(false);
            this.pnlTaskBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChooseImg;
        public System.Windows.Forms.TextBox txtSaleprice;
        public System.Windows.Forms.TextBox txtImprice;
        public System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.ComboBox cbUnit;
        public System.Windows.Forms.ComboBox cbCatg;
        public System.Windows.Forms.PictureBox picCoffee;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLinePanel pnlTaskBar;
        private Guna.UI.WinForms.GunaButton btClose;
        private Guna.UI.WinForms.GunaButton btMinimam;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        public System.Windows.Forms.Label lbCaption;
    }
}