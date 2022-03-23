
namespace ManageTeacher
{
    partial class FormMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripBasis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripSystem,
            this.menuStripManage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(884, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripSystem
            // 
            this.menuStripSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripLog,
            this.menuStripExit});
            this.menuStripSystem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripSystem.Name = "menuStripSystem";
            this.menuStripSystem.Size = new System.Drawing.Size(104, 23);
            this.menuStripSystem.Text = "HỆ THỐNG";
            // 
            // menuStripLog
            // 
            this.menuStripLog.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripLog.Name = "menuStripLog";
            this.menuStripLog.Size = new System.Drawing.Size(180, 24);
            this.menuStripLog.Text = "ĐĂNG NHẬP";
            // 
            // menuStripExit
            // 
            this.menuStripExit.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripExit.Name = "menuStripExit";
            this.menuStripExit.Size = new System.Drawing.Size(180, 24);
            this.menuStripExit.Text = "THOÁT";
            this.menuStripExit.Click += new System.EventHandler(this.menuStripExit_Click);
            // 
            // menuStripManage
            // 
            this.menuStripManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripBasis});
            this.menuStripManage.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripManage.Name = "menuStripManage";
            this.menuStripManage.Size = new System.Drawing.Size(93, 23);
            this.menuStripManage.Text = "QUẢN LÝ";
            // 
            // menuStripBasis
            // 
            this.menuStripBasis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripUnit});
            this.menuStripBasis.Name = "menuStripBasis";
            this.menuStripBasis.Size = new System.Drawing.Size(180, 24);
            this.menuStripBasis.Text = "CƠ SỞ";
            this.menuStripBasis.Click += new System.EventHandler(this.menuStripBasis_Click);
            // 
            // menuStripUnit
            // 
            this.menuStripUnit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripTeacher});
            this.menuStripUnit.Name = "menuStripUnit";
            this.menuStripUnit.Size = new System.Drawing.Size(180, 24);
            this.menuStripUnit.Text = "ĐƠN VỊ";
            this.menuStripUnit.Click += new System.EventHandler(this.menuStripUnit_Click);
            // 
            // menuStripTeacher
            // 
            this.menuStripTeacher.Name = "menuStripTeacher";
            this.menuStripTeacher.Size = new System.Drawing.Size(180, 24);
            this.menuStripTeacher.Text = "GIÁO VIÊN";
            this.menuStripTeacher.Click += new System.EventHandler(this.menuStripTeacher_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMDI";
            this.Text = "FormMDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripSystem;
        private System.Windows.Forms.ToolStripMenuItem menuStripLog;
        private System.Windows.Forms.ToolStripMenuItem menuStripExit;
        private System.Windows.Forms.ToolStripMenuItem menuStripManage;
        private System.Windows.Forms.ToolStripMenuItem menuStripBasis;
        private System.Windows.Forms.ToolStripMenuItem menuStripUnit;
        private System.Windows.Forms.ToolStripMenuItem menuStripTeacher;
    }
}

