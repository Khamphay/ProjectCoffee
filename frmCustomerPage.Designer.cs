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
            this.flPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.lbPrice_Total = new System.Windows.Forms.Label();
            this.lbQtyTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaLinePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flPnl
            // 
            this.flPnl.AutoScroll = true;
            this.flPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flPnl.Font = new System.Drawing.Font("Lao_Ketmany2", 11F);
            this.flPnl.Location = new System.Drawing.Point(0, 72);
            this.flPnl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.flPnl.Name = "flPnl";
            this.flPnl.Padding = new System.Windows.Forms.Padding(10, 10, 10, 20);
            this.flPnl.Size = new System.Drawing.Size(1143, 480);
            this.flPnl.TabIndex = 0;
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(168)))), ((int)(((byte)(175)))));
            this.gunaLinePanel2.Controls.Add(this.lbPrice_Total);
            this.gunaLinePanel2.Controls.Add(this.label2);
            this.gunaLinePanel2.Controls.Add(this.label3);
            this.gunaLinePanel2.Controls.Add(this.label1);
            this.gunaLinePanel2.Controls.Add(this.button1);
            this.gunaLinePanel2.Controls.Add(this.lbQtyTotal);
            this.gunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.DimGray;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(1143, 72);
            this.gunaLinePanel2.TabIndex = 2;
            // 
            // lbPrice_Total
            // 
            this.lbPrice_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice_Total.AutoSize = true;
            this.lbPrice_Total.Location = new System.Drawing.Point(1034, 24);
            this.lbPrice_Total.Name = "lbPrice_Total";
            this.lbPrice_Total.Size = new System.Drawing.Size(59, 28);
            this.lbPrice_Total.TabIndex = 1;
            this.lbPrice_Total.Text = "0.00 ກີບ";
            this.lbPrice_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbQtyTotal
            // 
            this.lbQtyTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQtyTotal.AutoSize = true;
            this.lbQtyTotal.Location = new System.Drawing.Point(832, 24);
            this.lbQtyTotal.Name = "lbQtyTotal";
            this.lbQtyTotal.Size = new System.Drawing.Size(20, 28);
            this.lbQtyTotal.TabIndex = 0;
            this.lbQtyTotal.Text = "0";
            this.lbQtyTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(150, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "ສັ່ງຊື້";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "ຈຳນວນທັງໝົດ:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(955, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "ລາຄາທັງໝົດ:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(865, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "ຈອກ";
            // 
            // frmCustomerPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(665, 0);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1143, 552);
            this.Controls.Add(this.flPnl);
            this.Controls.Add(this.gunaLinePanel2);
            this.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCustomerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerPage";
            this.Load += new System.EventHandler(this.frmCustomerPage_Load);
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPnl;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private System.Windows.Forms.Label lbPrice_Total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbQtyTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}