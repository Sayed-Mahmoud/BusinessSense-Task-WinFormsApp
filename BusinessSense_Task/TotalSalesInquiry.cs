using BusinessSense_Task.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessSense_Task
{
    public partial class TotalSalesInquiry : Form
    {
        byte ShowType;

        public TotalSalesInquiry()
        {
            InitializeComponent();
        }

        private void TotalSalesInquiry_Load(object sender, EventArgs e)
        {
            FromDateTimePicker.Value = ToDateTimePicker.Value = DateTime.Now.Date;

            MyDataGridView.AutoGenerateColumns = true;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            MyDataGridView.DataSource = null;

            using (SqlConnection connection = new SqlConnection(MyFunctions.MyConnection))
            {
                using (SqlCommand command = new SqlCommand("", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                })
                {
                    command.Parameters.AddRange(new SqlParameter[] {
                new SqlParameter("@FromDate", FromDateTimePicker.Value),
                new SqlParameter("@ToDate", ToDateTimePicker.Value) });
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    using (DataTable table = new DataTable
                    {
                        Locale = System.Globalization.CultureInfo.InvariantCulture
                    })
                    {


                        if (ByItemRadioBtn.Checked)
                        {
                            ShowType = 0;
                            command.CommandText = "SelectTotalSalesByItem";
                        }
                        else
                        {
                            ShowType = 1;
                            command.CommandText = "TotalSalesByDate";
                        }

                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        MyDataGridView.DataSource = table;
                    }
                }
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (MyDataGridView.DataSource != null)
            {
                using (TotalSalesReport ts = new TotalSalesReport(MyDataGridView.DataSource, this.ShowType))
                {
                    ts.ShowDialog();
                }
            }
        }

        private void TotalSalesInquiry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
                SearchBtn.PerformClick();
            else if (e.Control && e.KeyCode == Keys.P)
                PrintBtn.PerformClick();
        }
    }
}
