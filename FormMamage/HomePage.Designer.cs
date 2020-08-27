namespace ProjectCoffee
{
    partial class HomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation2 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlDesbordTwo = new System.Windows.Forms.Panel();
            this.gunaLinePanel3 = new Guna.UI.WinForms.GunaLinePanel();
            this.listVitem = new System.Windows.Forms.ListView();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.rdbMonth = new System.Windows.Forms.RadioButton();
            this.rdbDate = new System.Windows.Forms.RadioButton();
            this.pnlMain.SuspendLayout();
            this.pnlDesbordTwo.SuspendLayout();
            this.gunaLinePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Controls.Add(this.rdbDate);
            this.pnlMain.Controls.Add(this.rdbMonth);
            this.pnlMain.Controls.Add(this.pnlDesbordTwo);
            this.gunaTransition1.SetDecoration(this.pnlMain, Guna.UI.Animation.DecorationType.None);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(930, 605);
            this.pnlMain.TabIndex = 6;
            // 
            // pnlDesbordTwo
            // 
            this.pnlDesbordTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDesbordTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnlDesbordTwo.Controls.Add(this.gunaLinePanel3);
            this.gunaTransition1.SetDecoration(this.pnlDesbordTwo, Guna.UI.Animation.DecorationType.None);
            this.pnlDesbordTwo.Location = new System.Drawing.Point(0, 46);
            this.pnlDesbordTwo.Name = "pnlDesbordTwo";
            this.pnlDesbordTwo.Size = new System.Drawing.Size(930, 516);
            this.pnlDesbordTwo.TabIndex = 2;
            // 
            // gunaLinePanel3
            // 
            this.gunaLinePanel3.Controls.Add(this.listVitem);
            this.gunaTransition1.SetDecoration(this.gunaLinePanel3, Guna.UI.Animation.DecorationType.None);
            this.gunaLinePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel3.LineBottom = 1;
            this.gunaLinePanel3.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLinePanel3.LineLeft = 1;
            this.gunaLinePanel3.LineRight = 1;
            this.gunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel3.LineTop = 1;
            this.gunaLinePanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel3.Name = "gunaLinePanel3";
            this.gunaLinePanel3.Padding = new System.Windows.Forms.Padding(2);
            this.gunaLinePanel3.Size = new System.Drawing.Size(930, 516);
            this.gunaLinePanel3.TabIndex = 3;
            // 
            // listVitem
            // 
            this.listVitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.listVitem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaTransition1.SetDecoration(this.listVitem, Guna.UI.Animation.DecorationType.None);
            this.listVitem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVitem.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVitem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listVitem.HideSelection = false;
            this.listVitem.Location = new System.Drawing.Point(2, 2);
            this.listVitem.MultiSelect = false;
            this.listVitem.Name = "listVitem";
            this.listVitem.Size = new System.Drawing.Size(926, 512);
            this.listVitem.TabIndex = 1;
            this.listVitem.UseCompatibleStateImageBehavior = false;
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.gunaTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation2;
            // 
            // rdbMonth
            // 
            this.rdbMonth.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.rdbMonth, Guna.UI.Animation.DecorationType.None);
            this.rdbMonth.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMonth.Location = new System.Drawing.Point(353, 10);
            this.rdbMonth.Name = "rdbMonth";
            this.rdbMonth.Size = new System.Drawing.Size(200, 27);
            this.rdbMonth.TabIndex = 5;
            this.rdbMonth.Text = "ສະແດງລາຍການຂາຍໃນເດືອນນີ້";
            this.rdbMonth.UseVisualStyleBackColor = true;
            this.rdbMonth.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbDate
            // 
            this.rdbDate.AutoSize = true;
            this.rdbDate.Checked = true;
            this.gunaTransition1.SetDecoration(this.rdbDate, Guna.UI.Animation.DecorationType.None);
            this.rdbDate.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDate.Location = new System.Drawing.Point(123, 10);
            this.rdbDate.Name = "rdbDate";
            this.rdbDate.Size = new System.Drawing.Size(179, 27);
            this.rdbDate.TabIndex = 6;
            this.rdbDate.TabStop = true;
            this.rdbDate.Text = "ສະແດງລາຍການຂາຍໃນມື້ນີ້";
            this.rdbDate.UseVisualStyleBackColor = true;
            this.rdbDate.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // HomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnlMain);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(930, 605);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlDesbordTwo.ResumeLayout(false);
            this.gunaLinePanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlDesbordTwo;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private System.Windows.Forms.ListView listVitem;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel3;
        private System.Windows.Forms.RadioButton rdbDate;
        private System.Windows.Forms.RadioButton rdbMonth;
    }
}
