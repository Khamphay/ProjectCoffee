namespace ProjectCoffee
{
    partial class Form1
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
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlManu = new System.Windows.Forms.Panel();
            this.btAnimate = new Guna.UI.WinForms.GunaButton();
            this.line2 = new Guna.UI.WinForms.GunaSeparator();
            this.line1 = new Guna.UI.WinForms.GunaSeparator();
            this.btReport = new System.Windows.Forms.Button();
            this.btSale = new System.Windows.Forms.Button();
            this.btCatg = new System.Windows.Forms.Button();
            this.btUnit = new System.Windows.Forms.Button();
            this.btCoff = new System.Windows.Forms.Button();
            this.btStaff = new System.Windows.Forms.Button();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lbCom_Name = new System.Windows.Forms.Label();
            this.pnDesktop = new System.Windows.Forms.Panel();
            this.AnimatedMenu = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.pnlTaskBar = new Guna.UI.WinForms.GunaLinePanel();
            this.Maximam = new Guna.UI.WinForms.GunaButton();
            this.btClose = new Guna.UI.WinForms.GunaButton();
            this.btMinimam = new Guna.UI.WinForms.GunaButton();
            this.gunaElipseForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaResize1 = new Guna.UI.WinForms.GunaResize(this.components);
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.pnlManu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.pnlTaskBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlManu
            // 
            this.pnlManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.pnlManu.Controls.Add(this.btAnimate);
            this.pnlManu.Controls.Add(this.line2);
            this.pnlManu.Controls.Add(this.line1);
            this.pnlManu.Controls.Add(this.btReport);
            this.pnlManu.Controls.Add(this.btSale);
            this.pnlManu.Controls.Add(this.btCatg);
            this.pnlManu.Controls.Add(this.btUnit);
            this.pnlManu.Controls.Add(this.btCoff);
            this.pnlManu.Controls.Add(this.btStaff);
            this.pnlManu.Controls.Add(this.gunaCirclePictureBox1);
            this.pnlManu.Controls.Add(this.lbCom_Name);
            this.gunaTransition1.SetDecoration(this.pnlManu, Guna.UI.Animation.DecorationType.None);
            this.pnlManu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlManu.ForeColor = System.Drawing.Color.White;
            this.pnlManu.Location = new System.Drawing.Point(0, 32);
            this.pnlManu.Name = "pnlManu";
            this.pnlManu.Size = new System.Drawing.Size(221, 605);
            this.pnlManu.TabIndex = 0;
            // 
            // btAnimate
            // 
            this.btAnimate.Animated = true;
            this.btAnimate.AnimationHoverSpeed = 2F;
            this.btAnimate.AnimationSpeed = 1F;
            this.btAnimate.BackColor = System.Drawing.Color.Transparent;
            this.btAnimate.BaseColor = System.Drawing.Color.Transparent;
            this.btAnimate.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btAnimate, Guna.UI.Animation.DecorationType.None);
            this.btAnimate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btAnimate.FocusedColor = System.Drawing.Color.Empty;
            this.btAnimate.Font = new System.Drawing.Font("Alice5 95", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnimate.ForeColor = System.Drawing.Color.White;
            this.btAnimate.Image = global::ProjectCoffee.Properties.Resources.menu_vertical1;
            this.btAnimate.ImageSize = new System.Drawing.Size(30, 30);
            this.btAnimate.Location = new System.Drawing.Point(3, 79);
            this.btAnimate.Name = "btAnimate";
            this.btAnimate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(106)))));
            this.btAnimate.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btAnimate.OnHoverForeColor = System.Drawing.Color.White;
            this.btAnimate.OnHoverImage = null;
            this.btAnimate.OnPressedColor = System.Drawing.Color.White;
            this.btAnimate.Radius = 4;
            this.btAnimate.Size = new System.Drawing.Size(114, 45);
            this.btAnimate.TabIndex = 0;
            this.btAnimate.Text = "Menu";
            this.toolTip1.SetToolTip(this.btAnimate, "Menu");
            this.btAnimate.Click += new System.EventHandler(this.btAnimate_Click);
            // 
            // line2
            // 
            this.line2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTransition1.SetDecoration(this.line2, Guna.UI.Animation.DecorationType.None);
            this.line2.LineColor = System.Drawing.Color.Silver;
            this.line2.Location = new System.Drawing.Point(2, 126);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(222, 10);
            this.line2.TabIndex = 3;
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTransition1.SetDecoration(this.line1, Guna.UI.Animation.DecorationType.None);
            this.line1.LineColor = System.Drawing.Color.Silver;
            this.line1.Location = new System.Drawing.Point(2, 66);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(222, 10);
            this.line1.TabIndex = 3;
            // 
            // btReport
            // 
            this.gunaTransition1.SetDecoration(this.btReport, Guna.UI.Animation.DecorationType.None);
            this.btReport.FlatAppearance.BorderSize = 0;
            this.btReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(106)))));
            this.btReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReport.Font = new System.Drawing.Font("Alice5 95", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReport.Image = global::ProjectCoffee.Properties.Resources.report;
            this.btReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReport.Location = new System.Drawing.Point(4, 467);
            this.btReport.Name = "btReport";
            this.btReport.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btReport.Size = new System.Drawing.Size(217, 55);
            this.btReport.TabIndex = 2;
            this.btReport.Text = "Report";
            this.btReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btReport, "Report");
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.Report_Click);
            // 
            // btSale
            // 
            this.gunaTransition1.SetDecoration(this.btSale, Guna.UI.Animation.DecorationType.None);
            this.btSale.FlatAppearance.BorderSize = 0;
            this.btSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(106)))));
            this.btSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSale.Font = new System.Drawing.Font("Alice5 95", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSale.Image = global::ProjectCoffee.Properties.Resources.sale_30px;
            this.btSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSale.Location = new System.Drawing.Point(4, 402);
            this.btSale.Name = "btSale";
            this.btSale.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btSale.Size = new System.Drawing.Size(217, 55);
            this.btSale.TabIndex = 2;
            this.btSale.Text = "Sale";
            this.btSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btSale, "Sale");
            this.btSale.UseVisualStyleBackColor = true;
            this.btSale.Click += new System.EventHandler(this.btSale_Click);
            // 
            // btCatg
            // 
            this.gunaTransition1.SetDecoration(this.btCatg, Guna.UI.Animation.DecorationType.None);
            this.btCatg.FlatAppearance.BorderSize = 0;
            this.btCatg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(106)))));
            this.btCatg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCatg.Font = new System.Drawing.Font("Alice5 95", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCatg.Image = global::ProjectCoffee.Properties.Resources.icons8_sugar_cube_30;
            this.btCatg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCatg.Location = new System.Drawing.Point(4, 337);
            this.btCatg.Name = "btCatg";
            this.btCatg.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btCatg.Size = new System.Drawing.Size(217, 55);
            this.btCatg.TabIndex = 2;
            this.btCatg.Text = "Category";
            this.btCatg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCatg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btCatg, "Category");
            this.btCatg.UseVisualStyleBackColor = true;
            this.btCatg.Click += new System.EventHandler(this.btCatg_Click);
            // 
            // btUnit
            // 
            this.gunaTransition1.SetDecoration(this.btUnit, Guna.UI.Animation.DecorationType.None);
            this.btUnit.FlatAppearance.BorderSize = 0;
            this.btUnit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(106)))));
            this.btUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUnit.Font = new System.Drawing.Font("Alice5 95", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUnit.Image = ((System.Drawing.Image)(resources.GetObject("btUnit.Image")));
            this.btUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUnit.Location = new System.Drawing.Point(4, 272);
            this.btUnit.Name = "btUnit";
            this.btUnit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btUnit.Size = new System.Drawing.Size(217, 55);
            this.btUnit.TabIndex = 2;
            this.btUnit.Text = "Unit";
            this.btUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btUnit, "Unit");
            this.btUnit.UseVisualStyleBackColor = true;
            this.btUnit.Click += new System.EventHandler(this.btUnit_Click);
            // 
            // btCoff
            // 
            this.gunaTransition1.SetDecoration(this.btCoff, Guna.UI.Animation.DecorationType.None);
            this.btCoff.FlatAppearance.BorderSize = 0;
            this.btCoff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(106)))));
            this.btCoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCoff.Font = new System.Drawing.Font("Alice5 95", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCoff.Image = global::ProjectCoffee.Properties.Resources.icons8_tableware_30;
            this.btCoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCoff.Location = new System.Drawing.Point(4, 207);
            this.btCoff.Name = "btCoff";
            this.btCoff.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btCoff.Size = new System.Drawing.Size(217, 55);
            this.btCoff.TabIndex = 2;
            this.btCoff.Text = "Coffee";
            this.btCoff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCoff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btCoff, "Coffee");
            this.btCoff.UseVisualStyleBackColor = true;
            this.btCoff.Click += new System.EventHandler(this.btCoff_Click);
            // 
            // btStaff
            // 
            this.gunaTransition1.SetDecoration(this.btStaff, Guna.UI.Animation.DecorationType.None);
            this.btStaff.FlatAppearance.BorderSize = 0;
            this.btStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(106)))));
            this.btStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStaff.Font = new System.Drawing.Font("Alice5 95", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStaff.Image = ((System.Drawing.Image)(resources.GetObject("btStaff.Image")));
            this.btStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btStaff.Location = new System.Drawing.Point(4, 142);
            this.btStaff.Name = "btStaff";
            this.btStaff.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btStaff.Size = new System.Drawing.Size(217, 55);
            this.btStaff.TabIndex = 2;
            this.btStaff.Text = "Employee";
            this.btStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btStaff, "Employee");
            this.btStaff.UseVisualStyleBackColor = true;
            this.btStaff.Click += new System.EventHandler(this.btStaff_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTransition1.SetDecoration(this.gunaCirclePictureBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(1, 7);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(60, 60);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 1;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // lbCom_Name
            // 
            this.lbCom_Name.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.lbCom_Name, Guna.UI.Animation.DecorationType.None);
            this.lbCom_Name.Font = new System.Drawing.Font("Alice5 95", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCom_Name.Location = new System.Drawing.Point(62, 22);
            this.lbCom_Name.Name = "lbCom_Name";
            this.lbCom_Name.Size = new System.Drawing.Size(158, 31);
            this.lbCom_Name.TabIndex = 0;
            this.lbCom_Name.Text = "Cafe Of My Dream";
            // 
            // pnDesktop
            // 
            this.pnDesktop.AutoScroll = true;
            this.pnDesktop.AutoScrollMinSize = new System.Drawing.Size(800, 500);
            this.pnDesktop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gunaTransition1.SetDecoration(this.pnDesktop, Guna.UI.Animation.DecorationType.None);
            this.pnDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDesktop.Location = new System.Drawing.Point(221, 32);
            this.pnDesktop.Name = "pnDesktop";
            this.pnDesktop.Size = new System.Drawing.Size(930, 605);
            this.pnDesktop.TabIndex = 0;
            // 
            // AnimatedMenu
            // 
            this.AnimatedMenu.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
            this.AnimatedMenu.Interval = 300;
            this.AnimatedMenu.TargetControl = this;
            // 
            // pnlTaskBar
            // 
            this.pnlTaskBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.pnlTaskBar.Controls.Add(this.Maximam);
            this.pnlTaskBar.Controls.Add(this.btClose);
            this.pnlTaskBar.Controls.Add(this.btMinimam);
            this.gunaTransition1.SetDecoration(this.pnlTaskBar, Guna.UI.Animation.DecorationType.None);
            this.pnlTaskBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTaskBar.LineColor = System.Drawing.Color.Black;
            this.pnlTaskBar.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlTaskBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTaskBar.Name = "pnlTaskBar";
            this.pnlTaskBar.Size = new System.Drawing.Size(1151, 32);
            this.pnlTaskBar.TabIndex = 12;
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
            this.gunaTransition1.SetDecoration(this.Maximam, Guna.UI.Animation.DecorationType.None);
            this.Maximam.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Maximam.FocusedColor = System.Drawing.Color.Empty;
            this.Maximam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Maximam.ForeColor = System.Drawing.Color.White;
            this.Maximam.Image = global::ProjectCoffee.Properties.Resources.restore_window;
            this.Maximam.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Maximam.ImageSize = new System.Drawing.Size(23, 23);
            this.Maximam.Location = new System.Drawing.Point(1078, 4);
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
            this.gunaTransition1.SetDecoration(this.btClose, Guna.UI.Animation.DecorationType.None);
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btClose.FocusedColor = System.Drawing.Color.Empty;
            this.btClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Image = global::ProjectCoffee.Properties.Resources.cancel;
            this.btClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btClose.Location = new System.Drawing.Point(1119, 4);
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
            this.gunaTransition1.SetDecoration(this.btMinimam, Guna.UI.Animation.DecorationType.None);
            this.btMinimam.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btMinimam.FocusedColor = System.Drawing.Color.Empty;
            this.btMinimam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btMinimam.ForeColor = System.Drawing.Color.White;
            this.btMinimam.Image = global::ProjectCoffee.Properties.Resources.minus;
            this.btMinimam.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btMinimam.ImageSize = new System.Drawing.Size(20, 20);
            this.btMinimam.Location = new System.Drawing.Point(1037, 4);
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
            // gunaElipseForm
            // 
            this.gunaElipseForm.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaResize1
            // 
            this.gunaResize1.TargetForm = this;
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.gunaTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1151, 637);
            this.Controls.Add(this.pnDesktop);
            this.Controls.Add(this.pnlManu);
            this.Controls.Add(this.pnlTaskBar);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.Font = new System.Drawing.Font("Alice5 95", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlManu.ResumeLayout(false);
            this.pnlManu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.pnlTaskBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManu;
        private System.Windows.Forms.Panel pnDesktop;
        private Guna.UI.WinForms.GunaSeparator line1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Label lbCom_Name;
        private Guna.UI.WinForms.GunaAnimateWindow AnimatedMenu;
        private Guna.UI.WinForms.GunaButton btAnimate;
        private Guna.UI.WinForms.GunaLinePanel pnlTaskBar;
        private Guna.UI.WinForms.GunaButton Maximam;
        private Guna.UI.WinForms.GunaButton btClose;
        private Guna.UI.WinForms.GunaButton btMinimam;
        private Guna.UI.WinForms.GunaElipse gunaElipseForm;
        private Guna.UI.WinForms.GunaSeparator line2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.Button btSale;
        private System.Windows.Forms.Button btCatg;
        private System.Windows.Forms.Button btUnit;
        private System.Windows.Forms.Button btCoff;
        private System.Windows.Forms.Button btStaff;
        private Guna.UI.WinForms.GunaResize gunaResize1;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
    }
}

