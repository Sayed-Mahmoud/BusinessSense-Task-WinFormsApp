using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BusinessSense_Task
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            //this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormItems()
            {
                Icon = this.Icon,
                Owner = this
            }.Show();
        }

        private void CashSalesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CashSalesInvoice()
            {
                Icon = this.Icon,
                Owner = this
            }.Show();
        }

        private void TotalSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TotalSalesInquiry()
            {
                Icon = this.Icon,
                Owner = this
            }.Show();
        }
    }
}
