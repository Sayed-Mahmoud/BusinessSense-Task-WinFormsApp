using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessSense_Task.Reports
{
    public partial class TotalSalesReport : Form
    {
        //private DateTime FromDate, ToDate;
        readonly byte ShowType;
        readonly object MyDataSource;
        public TotalSalesReport(object MyDataSource, byte ShowType)//DateTime FromDate, DateTime ToDate, byte ShowType)
        {
            InitializeComponent();
            this.MyDataSource = MyDataSource;
            this.ShowType = ShowType;
            /*
            this.FromDate = FromDate;
            this.ToDate = ToDate;
            */
        }

        private void TotalSalesReport_Load(object sender, EventArgs e)
        {
            ReportClass totalSales;
            if (ShowType == 0)
            {
                totalSales = new BusinessSense_Task.Reports.TotalSalesByItem();
            }
            else
            {
                totalSales = new BusinessSense_Task.Reports.TotalSalesByDate();
            }
            totalSales.SetDataSource(this.MyDataSource);
            this.crystalReportViewer1.ReportSource = totalSales;
            this.crystalReportViewer1.Refresh();
        }
    }
}
