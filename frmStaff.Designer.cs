namespace ProjectCoffee
{
    partial class frmStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.btDel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.btBack = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToResizeRows = false;
            this.dgvStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.ColumnHeadersHeight = 40;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaff.EnableHeadersVisualStyles = false;
            this.dgvStaff.GridColor = System.Drawing.Color.White;
            this.dgvStaff.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvStaff.Location = new System.Drawing.Point(12, 126);
            this.dgvStaff.MinimumSize = new System.Drawing.Size(776, 317);
            this.dgvStaff.Name = "dgvStaff";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaff.RowHeadersWidth = 5;
            this.dgvStaff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStaff.RowTemplate.Height = 40;
            this.dgvStaff.RowTemplate.ReadOnly = true;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(915, 412);
            this.dgvStaff.TabIndex = 4;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            this.dgvStaff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btBack);
            this.panel1.Controls.Add(this.gunaSeparator2);
            this.panel1.Controls.Add(this.btDel);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 114);
            this.panel1.TabIndex = 6;
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
            // btDel
            // 
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.Location = new System.Drawing.Point(660, 36);
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
            this.btEdit.Location = new System.Drawing.Point(579, 36);
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
            this.btAdd.Location = new System.Drawing.Point(498, 37);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(63, 36);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "ເພີ່ມ";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(274, 36);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ຄົ້ນຫາ:";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.gunaSeparator1.Location = new System.Drawing.Point(12, 165);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(898, 1);
            this.gunaSeparator1.TabIndex = 5;
            // 
            // btBack
            // 
            this.btBack.Animated = true;
            this.btBack.AnimationHoverSpeed = 2F;
            this.btBack.AnimationSpeed = 1F;
            this.btBack.BackColor = System.Drawing.Color.Transparent;
            this.btBack.BaseColor = System.Drawing.Color.Transparent;
            this.btBack.BorderColor = System.Drawing.Color.Black;
            this.btBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btBack.FocusedColor = System.Drawing.Color.Empty;
            this.btBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btBack.ForeColor = System.Drawing.Color.White;
            this.btBack.Image = global::ProjectCoffee.Properties.Resources.go_back_30px;
            this.btBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btBack.ImageOffsetX = 2;
            this.btBack.ImageSize = new System.Drawing.Size(23, 23);
            this.btBack.Location = new System.Drawing.Point(4, 4);
            this.btBack.Name = "btBack";
            this.btBack.OnHoverBaseColor = System.Drawing.Color.White;
            this.btBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btBack.OnHoverImage = null;
            this.btBack.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.btBack.Radius = 4;
            this.btBack.Size = new System.Drawing.Size(30, 30);
            this.btBack.TabIndex = 18;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // frmStaff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(939, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.dgvStaff);
            this.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStaff";
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaButton btBack;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}