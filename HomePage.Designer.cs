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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pnBottom = new System.Windows.Forms.Panel();
            this.picInstragram = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.picIatam = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.picTweeter = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.picFacebook = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gbMenu = new Guna.UI.WinForms.GunaGroupBox();
            this.btReport = new System.Windows.Forms.Button();
            this.btSale = new System.Windows.Forms.Button();
            this.pnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInstragram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIatam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTweeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacebook)).BeginInit();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.picInstragram);
            this.pnBottom.Controls.Add(this.picIatam);
            this.pnBottom.Controls.Add(this.picTweeter);
            this.pnBottom.Controls.Add(this.picFacebook);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 536);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(915, 72);
            this.pnBottom.TabIndex = 0;
            // 
            // picInstragram
            // 
            this.picInstragram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picInstragram.BackColor = System.Drawing.Color.Transparent;
            this.picInstragram.BaseColor = System.Drawing.Color.White;
            this.picInstragram.Image = ((System.Drawing.Image)(resources.GetObject("picInstragram.Image")));
            this.picInstragram.Location = new System.Drawing.Point(419, 21);
            this.picInstragram.Name = "picInstragram";
            this.picInstragram.Size = new System.Drawing.Size(35, 35);
            this.picInstragram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInstragram.TabIndex = 1;
            this.picInstragram.TabStop = false;
            this.picInstragram.UseTransfarantBackground = false;
            this.picInstragram.Click += new System.EventHandler(this.picInstragram_Click);
            // 
            // picIatam
            // 
            this.picIatam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picIatam.BackColor = System.Drawing.Color.Transparent;
            this.picIatam.BaseColor = System.Drawing.Color.White;
            this.picIatam.Image = ((System.Drawing.Image)(resources.GetObject("picIatam.Image")));
            this.picIatam.Location = new System.Drawing.Point(486, 21);
            this.picIatam.Name = "picIatam";
            this.picIatam.Size = new System.Drawing.Size(35, 35);
            this.picIatam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIatam.TabIndex = 1;
            this.picIatam.TabStop = false;
            this.picIatam.UseTransfarantBackground = false;
            this.picIatam.Click += new System.EventHandler(this.picIatam_Click);
            // 
            // picTweeter
            // 
            this.picTweeter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picTweeter.BackColor = System.Drawing.Color.Transparent;
            this.picTweeter.BaseColor = System.Drawing.Color.White;
            this.picTweeter.Image = ((System.Drawing.Image)(resources.GetObject("picTweeter.Image")));
            this.picTweeter.Location = new System.Drawing.Point(354, 21);
            this.picTweeter.Name = "picTweeter";
            this.picTweeter.Size = new System.Drawing.Size(35, 35);
            this.picTweeter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTweeter.TabIndex = 1;
            this.picTweeter.TabStop = false;
            this.picTweeter.UseTransfarantBackground = false;
            // 
            // picFacebook
            // 
            this.picFacebook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picFacebook.BackColor = System.Drawing.Color.Transparent;
            this.picFacebook.BaseColor = System.Drawing.Color.White;
            this.picFacebook.Image = ((System.Drawing.Image)(resources.GetObject("picFacebook.Image")));
            this.picFacebook.Location = new System.Drawing.Point(283, 21);
            this.picFacebook.Name = "picFacebook";
            this.picFacebook.Size = new System.Drawing.Size(35, 35);
            this.picFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFacebook.TabIndex = 1;
            this.picFacebook.TabStop = false;
            this.picFacebook.UseTransfarantBackground = false;
            this.picFacebook.Click += new System.EventHandler(this.picFacebook_Click);
            // 
            // gbMenu
            // 
            this.gbMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbMenu.BackColor = System.Drawing.Color.Transparent;
            this.gbMenu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbMenu.BorderColor = System.Drawing.Color.Gainsboro;
            this.gbMenu.BorderSize = 1;
            this.gbMenu.Controls.Add(this.btReport);
            this.gbMenu.Controls.Add(this.btSale);
            this.gbMenu.Font = new System.Drawing.Font("Alice5 95", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMenu.ForeColor = System.Drawing.Color.White;
            this.gbMenu.LineBottom = 1;
            this.gbMenu.LineColor = System.Drawing.Color.Gainsboro;
            this.gbMenu.LineLeft = 1;
            this.gbMenu.LineRight = 1;
            this.gbMenu.LineTop = 1;
            this.gbMenu.Location = new System.Drawing.Point(247, 111);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Radius = 4;
            this.gbMenu.Size = new System.Drawing.Size(485, 336);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.Text = "Menu";
            this.gbMenu.TextLocation = new System.Drawing.Point(4, -10);
            // 
            // btReport
            // 
            this.btReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReport.Font = new System.Drawing.Font("Alice5 95", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReport.Location = new System.Drawing.Point(287, 117);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(129, 104);
            this.btReport.TabIndex = 0;
            this.btReport.Text = "Report";
            this.btReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btReport.UseVisualStyleBackColor = true;
            // 
            // btSale
            // 
            this.btSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSale.Font = new System.Drawing.Font("Alice5 95", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSale.Location = new System.Drawing.Point(81, 117);
            this.btSale.Name = "btSale";
            this.btSale.Size = new System.Drawing.Size(129, 104);
            this.btSale.TabIndex = 0;
            this.btSale.Text = "Sale";
            this.btSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSale.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.pnBottom);
            this.Font = new System.Drawing.Font("Alice5 95", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(915, 608);
            this.pnBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInstragram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIatam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTweeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacebook)).EndInit();
            this.gbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBottom;
        private Guna.UI.WinForms.GunaCirclePictureBox picInstragram;
        private Guna.UI.WinForms.GunaCirclePictureBox picIatam;
        private Guna.UI.WinForms.GunaCirclePictureBox picTweeter;
        private Guna.UI.WinForms.GunaCirclePictureBox picFacebook;
        private Guna.UI.WinForms.GunaGroupBox gbMenu;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.Button btSale;
    }
}
