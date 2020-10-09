namespace BusinessSense_Task
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CashSalesInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inquiriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TotalSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.ItemsToolStripMenuItem,
            this.invoicesToolStripMenuItem,
            this.inquiriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ItemsToolStripMenuItem
            // 
            this.ItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemsToolStripMenuItem1});
            this.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem";
            this.ItemsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ItemsToolStripMenuItem.Text = "Items";
            // 
            // ItemsToolStripMenuItem1
            // 
            this.ItemsToolStripMenuItem1.Name = "ItemsToolStripMenuItem1";
            this.ItemsToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.ItemsToolStripMenuItem1.Text = "Items";
            this.ItemsToolStripMenuItem1.Click += new System.EventHandler(this.ItemsToolStripMenuItem1_Click);
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CashSalesInvoiceToolStripMenuItem});
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.invoicesToolStripMenuItem.Text = "Invoices";
            // 
            // CashSalesInvoiceToolStripMenuItem
            // 
            this.CashSalesInvoiceToolStripMenuItem.Name = "CashSalesInvoiceToolStripMenuItem";
            this.CashSalesInvoiceToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.CashSalesInvoiceToolStripMenuItem.Text = "Cash Sales Invoice";
            this.CashSalesInvoiceToolStripMenuItem.Click += new System.EventHandler(this.CashSalesInvoiceToolStripMenuItem_Click);
            // 
            // inquiriesToolStripMenuItem
            // 
            this.inquiriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TotalSalesToolStripMenuItem});
            this.inquiriesToolStripMenuItem.Name = "inquiriesToolStripMenuItem";
            this.inquiriesToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.inquiriesToolStripMenuItem.Text = "Inquiries/Reports";
            // 
            // TotalSalesToolStripMenuItem
            // 
            this.TotalSalesToolStripMenuItem.Name = "TotalSalesToolStripMenuItem";
            this.TotalSalesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.TotalSalesToolStripMenuItem.Text = "Total Sales";
            this.TotalSalesToolStripMenuItem.Click += new System.EventHandler(this.TotalSalesToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(737, 503);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CashSalesInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inquiriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TotalSalesToolStripMenuItem;
    }
}