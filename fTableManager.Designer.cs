namespace QuanLyQuanCaFe
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lwBILL = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbCatary = new System.Windows.Forms.ComboBox();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.brAddFood = new System.Windows.Forms.Button();
            this.flpnFood = new System.Windows.Forms.FlowLayoutPanel();
            this.btCheckOut = new System.Windows.Forms.Button();
            this.btSale = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.NoCotrol = new System.Windows.Forms.NumericUpDown();
            this.cbMove = new System.Windows.Forms.ComboBox();
            this.btMove = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoCotrol)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lwBILL);
            this.panel2.Location = new System.Drawing.Point(496, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 322);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbMove);
            this.panel3.Controls.Add(this.NoCotrol);
            this.panel3.Controls.Add(this.btMove);
            this.panel3.Controls.Add(this.btSale);
            this.panel3.Controls.Add(this.btCheckOut);
            this.panel3.Location = new System.Drawing.Point(496, 442);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 111);
            this.panel3.TabIndex = 3;
            // 
            // lwBILL
            // 
            this.lwBILL.Location = new System.Drawing.Point(3, 3);
            this.lwBILL.Name = "lwBILL";
            this.lwBILL.Size = new System.Drawing.Size(529, 319);
            this.lwBILL.TabIndex = 0;
            this.lwBILL.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.brAddFood);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCatary);
            this.panel4.Location = new System.Drawing.Point(498, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(530, 63);
            this.panel4.TabIndex = 4;
            // 
            // cbCatary
            // 
            this.cbCatary.FormattingEnabled = true;
            this.cbCatary.Location = new System.Drawing.Point(3, 3);
            this.cbCatary.Name = "cbCatary";
            this.cbCatary.Size = new System.Drawing.Size(191, 21);
            this.cbCatary.TabIndex = 0;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 30);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(191, 21);
            this.cbFood.TabIndex = 0;
            // 
            // brAddFood
            // 
            this.brAddFood.Location = new System.Drawing.Point(223, 3);
            this.brAddFood.Name = "brAddFood";
            this.brAddFood.Size = new System.Drawing.Size(161, 55);
            this.brAddFood.TabIndex = 1;
            this.brAddFood.Text = "Thêm món";
            this.brAddFood.UseVisualStyleBackColor = true;
            // 
            // flpnFood
            // 
            this.flpnFood.Location = new System.Drawing.Point(19, 33);
            this.flpnFood.Name = "flpnFood";
            this.flpnFood.Size = new System.Drawing.Size(468, 519);
            this.flpnFood.TabIndex = 5;
            // 
            // btCheckOut
            // 
            this.btCheckOut.Location = new System.Drawing.Point(367, 16);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(133, 83);
            this.btCheckOut.TabIndex = 0;
            this.btCheckOut.Text = "Thanh toán";
            this.btCheckOut.UseVisualStyleBackColor = true;
            this.btCheckOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSale
            // 
            this.btSale.Location = new System.Drawing.Point(225, 15);
            this.btSale.Name = "btSale";
            this.btSale.Size = new System.Drawing.Size(136, 57);
            this.btSale.TabIndex = 0;
            this.btSale.Text = "Giảm giá";
            this.btSale.UseVisualStyleBackColor = true;
            this.btSale.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // NoCotrol
            // 
            this.NoCotrol.Location = new System.Drawing.Point(225, 79);
            this.NoCotrol.Name = "NoCotrol";
            this.NoCotrol.Size = new System.Drawing.Size(136, 20);
            this.NoCotrol.TabIndex = 2;
            this.NoCotrol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbMove
            // 
            this.cbMove.FormattingEnabled = true;
            this.cbMove.Location = new System.Drawing.Point(14, 78);
            this.cbMove.Name = "cbMove";
            this.cbMove.Size = new System.Drawing.Size(136, 21);
            this.cbMove.TabIndex = 0;
            // 
            // btMove
            // 
            this.btMove.Location = new System.Drawing.Point(14, 15);
            this.btMove.Name = "btMove";
            this.btMove.Size = new System.Drawing.Size(136, 57);
            this.btMove.TabIndex = 0;
            this.btMove.Text = "Chuyển bàn";
            this.btMove.UseVisualStyleBackColor = true;
            this.btMove.Click += new System.EventHandler(this.button1_Click);
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 562);
            this.Controls.Add(this.flpnFood);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NoCotrol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lwBILL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btCheckOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button brAddFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCatary;
        private System.Windows.Forms.FlowLayoutPanel flpnFood;
        private System.Windows.Forms.ComboBox cbMove;
        private System.Windows.Forms.NumericUpDown NoCotrol;
        private System.Windows.Forms.Button btMove;
        private System.Windows.Forms.Button btSale;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}