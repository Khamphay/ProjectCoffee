namespace ProjectCoffee
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlTaskBar = new Guna.UI.WinForms.GunaLinePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.btClose = new Guna.UI.WinForms.GunaButton();
            this.btMinimam = new Guna.UI.WinForms.GunaButton();
            this.txtUser = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtPass = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picTweeter = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.picInstragram = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.picIatam = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.picFacebook = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.cbShowPass = new Guna.UI.WinForms.GunaImageCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaCirclePictureBox3 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.pnlTaskBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTweeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstragram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIatam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // pnlTaskBar
            // 
            this.pnlTaskBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.pnlTaskBar.Controls.Add(this.label4);
            this.pnlTaskBar.Controls.Add(this.btClose);
            this.pnlTaskBar.Controls.Add(this.btMinimam);
            this.pnlTaskBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTaskBar.LineColor = System.Drawing.Color.Black;
            this.pnlTaskBar.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlTaskBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTaskBar.Name = "pnlTaskBar";
            this.pnlTaskBar.Size = new System.Drawing.Size(491, 32);
            this.pnlTaskBar.TabIndex = 12;
            this.pnlTaskBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTaskBar_MouseDown);
            this.pnlTaskBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTaskBar_MouseMove);
            this.pnlTaskBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTaskBar_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Login";
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
            this.btClose.Location = new System.Drawing.Point(459, 4);
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
            this.btMinimam.Location = new System.Drawing.Point(415, 4);
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
            // txtUser
            // 
            this.txtUser.Animated = true;
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(0)))));
            this.txtUser.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txtUser.LineSize = 2;
            this.txtUser.Location = new System.Drawing.Point(81, 191);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.Size = new System.Drawing.Size(301, 39);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextOffsetX = 40;
            // 
            // txtPass
            // 
            this.txtPass.Animated = true;
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(0)))));
            this.txtPass.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.txtPass.LineSize = 2;
            this.txtPass.Location = new System.Drawing.Point(81, 279);
            this.txtPass.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.Size = new System.Drawing.Size(301, 39);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextOffsetX = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lao_SomPong", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 47);
            this.label1.TabIndex = 14;
            this.label1.Text = "Login";
            // 
            // picTweeter
            // 
            this.picTweeter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picTweeter.BackColor = System.Drawing.Color.Transparent;
            this.picTweeter.BaseColor = System.Drawing.Color.White;
            this.picTweeter.Image = ((System.Drawing.Image)(resources.GetObject("picTweeter.Image")));
            this.picTweeter.Location = new System.Drawing.Point(188, 409);
            this.picTweeter.Name = "picTweeter";
            this.picTweeter.Size = new System.Drawing.Size(30, 30);
            this.picTweeter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTweeter.TabIndex = 1;
            this.picTweeter.TabStop = false;
            this.picTweeter.UseTransfarantBackground = false;
            this.picTweeter.Click += new System.EventHandler(this.picTweeter_Click);
            // 
            // picInstragram
            // 
            this.picInstragram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picInstragram.BackColor = System.Drawing.Color.Transparent;
            this.picInstragram.BaseColor = System.Drawing.Color.White;
            this.picInstragram.Image = ((System.Drawing.Image)(resources.GetObject("picInstragram.Image")));
            this.picInstragram.Location = new System.Drawing.Point(253, 409);
            this.picInstragram.Name = "picInstragram";
            this.picInstragram.Size = new System.Drawing.Size(30, 30);
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
            this.picIatam.Location = new System.Drawing.Point(320, 409);
            this.picIatam.Name = "picIatam";
            this.picIatam.Size = new System.Drawing.Size(30, 30);
            this.picIatam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIatam.TabIndex = 1;
            this.picIatam.TabStop = false;
            this.picIatam.UseTransfarantBackground = false;
            this.picIatam.Click += new System.EventHandler(this.picIatam_Click);
            // 
            // picFacebook
            // 
            this.picFacebook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picFacebook.BackColor = System.Drawing.Color.Transparent;
            this.picFacebook.BaseColor = System.Drawing.Color.White;
            this.picFacebook.Image = ((System.Drawing.Image)(resources.GetObject("picFacebook.Image")));
            this.picFacebook.Location = new System.Drawing.Point(117, 409);
            this.picFacebook.Name = "picFacebook";
            this.picFacebook.Size = new System.Drawing.Size(30, 30);
            this.picFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFacebook.TabIndex = 1;
            this.picFacebook.TabStop = false;
            this.picFacebook.UseTransfarantBackground = false;
            this.picFacebook.Click += new System.EventHandler(this.picFacebook_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(201, 34);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(80, 80);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 16;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // cbShowPass
            // 
            this.cbShowPass.ImageCheckedOff = ((System.Drawing.Image)(resources.GetObject("cbShowPass.ImageCheckedOff")));
            this.cbShowPass.ImageCheckedOn = ((System.Drawing.Image)(resources.GetObject("cbShowPass.ImageCheckedOn")));
            this.cbShowPass.ImageSize = new System.Drawing.Size(20, 20);
            this.cbShowPass.Location = new System.Drawing.Point(388, 283);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(35, 31);
            this.cbShowPass.TabIndex = 17;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lao_SomPong", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(81, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "User name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lao_SomPong", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(81, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Lao_SomPong", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(143, 334);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 38);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Lao_SomPong", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(259, 334);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 38);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox2.Image")));
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(77, 191);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(36, 36);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox2.TabIndex = 16;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // gunaCirclePictureBox3
            // 
            this.gunaCirclePictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox3.Image")));
            this.gunaCirclePictureBox3.Location = new System.Drawing.Point(77, 279);
            this.gunaCirclePictureBox3.Name = "gunaCirclePictureBox3";
            this.gunaCirclePictureBox3.Size = new System.Drawing.Size(36, 36);
            this.gunaCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox3.TabIndex = 16;
            this.gunaCirclePictureBox3.TabStop = false;
            this.gunaCirclePictureBox3.UseTransfarantBackground = false;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(491, 451);
            this.Controls.Add(this.gunaCirclePictureBox3);
            this.Controls.Add(this.gunaCirclePictureBox2);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.picTweeter);
            this.Controls.Add(this.picInstragram);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.picIatam);
            this.Controls.Add(this.picFacebook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pnlTaskBar);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.pnlTaskBar.ResumeLayout(false);
            this.pnlTaskBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTweeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstragram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIatam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLinePanel pnlTaskBar;
        private Guna.UI.WinForms.GunaButton btClose;
        private Guna.UI.WinForms.GunaButton btMinimam;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox txtPass;
        private Guna.UI.WinForms.GunaLineTextBox txtUser;
        private Guna.UI.WinForms.GunaCirclePictureBox picTweeter;
        private Guna.UI.WinForms.GunaCirclePictureBox picInstragram;
        private Guna.UI.WinForms.GunaCirclePictureBox picIatam;
        private Guna.UI.WinForms.GunaCirclePictureBox picFacebook;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaImageCheckBox cbShowPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox3;
    }
}