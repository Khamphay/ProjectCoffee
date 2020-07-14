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
            this.SuspendLayout();
            // 
            // flPnl
            // 
            this.flPnl.AutoScroll = true;
            this.flPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flPnl.Font = new System.Drawing.Font("Lao_Ketmany2", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flPnl.Location = new System.Drawing.Point(0, 72);
            this.flPnl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flPnl.Name = "flPnl";
            this.flPnl.Padding = new System.Windows.Forms.Padding(10, 10, 10, 20);
            this.flPnl.Size = new System.Drawing.Size(981, 403);
            this.flPnl.TabIndex = 0;
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel2.LineBottom = 1;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.DimGray;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(981, 72);
            this.gunaLinePanel2.TabIndex = 2;
            // 
            // frmCustomerPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(981, 475);
            this.Controls.Add(this.flPnl);
            this.Controls.Add(this.gunaLinePanel2);
            this.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCustomerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerPage";
            this.Load += new System.EventHandler(this.frmCustomerPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPnl;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
    }
}