namespace ProjectCoffee
{
    partial class frmCoffee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoffee));
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.dgvCoffee = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.btExit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.picCoffee = new System.Windows.Forms.PictureBox();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoffee)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoffee)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.gunaSeparator1.Location = new System.Drawing.Point(246, 165);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(664, 1);
            this.gunaSeparator1.TabIndex = 8;
            // 
            // dgvCoffee
            // 
            this.dgvCoffee.AllowUserToAddRows = false;
            this.dgvCoffee.AllowUserToDeleteRows = false;
            this.dgvCoffee.AllowUserToResizeRows = false;
            this.dgvCoffee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCoffee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCoffee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgvCoffee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCoffee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCoffee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoffee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCoffee.ColumnHeadersHeight = 40;
            this.dgvCoffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(55)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCoffee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCoffee.EnableHeadersVisualStyles = false;
            this.dgvCoffee.GridColor = System.Drawing.Color.White;
            this.dgvCoffee.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvCoffee.Location = new System.Drawing.Point(246, 126);
            this.dgvCoffee.Name = "dgvCoffee";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoffee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCoffee.RowHeadersWidth = 5;
            this.dgvCoffee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCoffee.RowTemplate.Height = 40;
            this.dgvCoffee.RowTemplate.ReadOnly = true;
            this.dgvCoffee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoffee.Size = new System.Drawing.Size(681, 406);
            this.dgvCoffee.TabIndex = 7;
            this.dgvCoffee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoffee_CellClick);
            this.dgvCoffee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoffee_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaSeparator2);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 114);
            this.panel1.TabIndex = 9;
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaSeparator2.LineColor = System.Drawing.Color.DimGray;
            this.gunaSeparator2.Location = new System.Drawing.Point(0, 113);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(939, 1);
            this.gunaSeparator2.TabIndex = 16;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.Location = new System.Drawing.Point(912, 3);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(24, 25);
            this.btExit.TabIndex = 2;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(246, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(274, 36);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ຄົ້ນຫາ:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(526, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "ຄົ້ນຫາ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btDel
            // 
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.Location = new System.Drawing.Point(168, 441);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(63, 36);
            this.btDel.TabIndex = 2;
            this.btDel.Text = "ລົບ";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btEdit
            // 
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Location = new System.Drawing.Point(88, 440);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(63, 36);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "ແກ້ໄຂ";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Location = new System.Drawing.Point(9, 441);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(63, 36);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "ເພີ່ມ";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // picCoffee
            // 
            this.picCoffee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCoffee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCoffee.Location = new System.Drawing.Point(0, 0);
            this.picCoffee.Name = "picCoffee";
            this.picCoffee.Size = new System.Drawing.Size(228, 189);
            this.picCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoffee.TabIndex = 17;
            this.picCoffee.TabStop = false;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.picCoffee);
            this.gunaGroupBox1.LineBottom = 1;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineLeft = 1;
            this.gunaGroupBox1.LineRight = 1;
            this.gunaGroupBox1.LineTop = 1;
            this.gunaGroupBox1.Location = new System.Drawing.Point(9, 165);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 2;
            this.gunaGroupBox1.Size = new System.Drawing.Size(228, 189);
            this.gunaGroupBox1.TabIndex = 17;
            this.gunaGroupBox1.Text = "ຮູບພາບ";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // frmCoffee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(939, 544);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.dgvCoffee);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCoffee";
            this.Text = "frmCoffee";
            this.Load += new System.EventHandler(this.frmCoffee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoffee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoffee)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.DataGridView dgvCoffee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private System.Windows.Forms.PictureBox picCoffee;
        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
    }
}