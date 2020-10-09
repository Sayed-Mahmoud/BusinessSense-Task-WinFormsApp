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
    public partial class CashSalesInvoice : Form
    {
        public CashSalesInvoice()
        {
            InitializeComponent();
        }

        private void CashSalesInvoice_Load(object sender, EventArgs e)
        {
            this.myDataSet.SelectInvoices_Items.ItemBarCodeColumn.ReadOnly =
                this.myDataSet.SelectInvoices_Items.ItemNameColumn.ReadOnly =
                this.myDataSet.SelectInvoices_Items.TotalPriceColumn.ReadOnly = false;

            this.selectItemInfoTableAdapter.Fill(this.myDataSet.SelectItemInfo);

            FromDateTimePicker.Value = ToDateTimePicker.Value = DateTime.Now.Date;

            AddNewInvoice();
        }

        private void SearchDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (SearchDataGridView.CurrentRow != null)
            {
                this.selectInvoicesTableAdapter.Fill(this.myDataSet.SelectInvoices, (int)SearchDataGridView.CurrentRow.Cells[0].Value);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            selectInvoiceByDateTableAdapter.Fill(myDataSet.SelectInvoiceByDate, FromDateTimePicker.Value.Date, ToDateTimePicker.Value.Date);
        }

        private void InvoiceIdTbox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(InvoiceIdTBox.Text, out int Id))
            {
                this.selectInvoices_ItemsTableAdapter.Fill(this.myDataSet.SelectInvoices_Items, Id);
            }
        }

        private void NewInvoiceBtn_Click(object sender, EventArgs e)
        {
            AddNewInvoice();
        }

        private void DeleteInvoiceBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                selectInvoicesBindingSource.RemoveCurrent();
                selectInvoicesTableAdapter.Update(myDataSet.SelectInvoices);
            }
        }

        private bool CanSave()
        {
            if (ItemIdCBox.SelectedIndex == -1)
            {
                //MessageBox.Show("Please select a valid Item ID/Barcode/Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Please select a valid Item ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (ItemCodeCBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Item Barcode!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (ItemNameCBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Item Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (QtyTBox.Value <= 0)
            {
                MessageBox.Show("Please enter a valid Quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (PriceTBox.Value <= 0)
            {
                MessageBox.Show("Please select a valid Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveInvoiceBtn_Click(object sender, EventArgs e)
        {
            if (!CanSave())
                return;
            else if (MyDataGridView.RowCount < 1)
            {
                MessageBox.Show("Please add at least one item!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectInvoicesBindingSource.EndEdit();
            selectInvoices_ItemsBindingSource.EndEdit();
            MyDataGridView.EndEdit();
            selectInvoicesTableAdapter.Update(myDataSet.SelectInvoices);
            selectInvoices_ItemsTableAdapter.Update(myDataSet.SelectInvoices_Items);
        }

        private void AddNewInvoice()
        {
            SearchDataGridView.ClearSelection();

            this.selectInvoicesBindingSource.AddNew();

            InvoiceIdTBox.Text = MyFunctions.GetScalar("SELECT ISNULL(MAX(ISNULL(InvoiceId, 0)), 0) + 1 FROM Invoices").ToString();
            InvoicedateTimePicker.Value = DateTime.Now;

            selectInvoices_ItemsBindingSource.AddNew();

            Invoice_ItemIDTBox.Text = InvoiceIdTBox.Text;

            TotalItemBox.Text = TotalInvoicePrice.Text = "0";

        }
        private void AddNewItem()
        {
            selectInvoices_ItemsBindingSource.AddNew();
            Invoice_ItemIDTBox.Text = InvoiceIdTBox.Text;
            PriceTBox.Value = QtyTBox.Value = 0;
        }

        private void SetTotals(bool SetInvoice)
        {
            TotalItemBox.Text = Math.Round(QtyTBox.Value * PriceTBox.Value, 2).ToString();

            if (SetInvoice)
            {
                decimal Tot = 0;

                foreach (DataGridViewRow row in MyDataGridView.Rows)
                {
                    var val = row.Cells[TotalPriceCol.Index].Value;
                    if (val != null && !string.IsNullOrEmpty(val.ToString()))
                        Tot += (decimal)val;
                }

                TotalInvoicePrice.Text = Math.Round(Tot, 2).ToString();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!CanSave())
                return;

            /*
            if (MyDataGridView.SelectedRows.Count == 0)
            {
                decimal price = PriceTBox.Value;
                int.TryParse(BillIdTbox.Text, out int InvoiceId);
                var DR = (DataRowView)this.selectInvoices_ItemsBindingSource.AddNew();
                DR[InvoiceIdCol.DataPropertyName] = InvoiceId;
                DR[itemIdCol.DataPropertyName] = ItemCodeCBox.SelectedValue;
                DR[BarCodeCol.DataPropertyName] = ItemCodeCBox.Text;
                DR[itemNameCol.DataPropertyName] = ItemNameCBox.Text;
                DR[QuantityCol.DataPropertyName] = QtyTBox.Value;
                DR[PriceCol.DataPropertyName] = price;
                DR[TotalPriceCol.DataPropertyName] = Math.Round(price * QtyTBox.Value, 2);
            }
            MyDataGridView.ClearSelection();
            */

            selectInvoices_ItemsBindingSource.EndEdit();
            MyDataGridView.EndEdit();
            AddNewItem();
            SetTotals(true);
        }

        private void NewItemBtn_Click(object sender, EventArgs e)
        {
            if (this.selectInvoices_ItemsBindingSource.Current == null || !((DataRowView)this.selectInvoices_ItemsBindingSource.Current).IsNew)
            {
                AddNewItem();
                SetTotals(true);
            }
        }

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error: " + e.Exception.ToString() + Environment.NewLine + "Row: " + e.RowIndex + Environment.NewLine + "Col: " + e.ColumnIndex);
            e.Cancel = true;
        }


        private void ItemCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox CBox = (ComboBox)sender;
            if (CBox.SelectedValue != null)
            {
                if (ItemIdCBox != CBox)
                    ItemIdCBox.SelectedValue = CBox.SelectedValue;
                if (ItemNameCBox != CBox)
                    ItemNameCBox.SelectedValue = CBox.SelectedValue;
                if (ItemCodeCBox != CBox)
                    ItemCodeCBox.SelectedValue = CBox.SelectedValue;
            }

            if (CBox.SelectedIndex != -1)
            {
                SetTotals(false);
            }
            else
                PriceTBox.Value = 0;
        }

        private void QtyPrice_ValueChanged(object sender, EventArgs e)
        {
            SetTotals(false);
        }

        private void CashSalesInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
                NewInvoiceBtn.PerformClick();
            else if (e.Control && e.KeyCode == Keys.S)
                SaveInvoiceBtn.PerformClick();
            else if (e.Shift && e.KeyCode == Keys.Delete)
                DeleteInvoiceBtn.PerformClick();
        }

        private void MyDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.selectInvoices_ItemsBindingSource.List.Count > e.RowIndex && ((DataRowView)this.selectInvoices_ItemsBindingSource[e.RowIndex]).IsNew)
                this.selectInvoices_ItemsBindingSource.RemoveAt(e.RowIndex);
        }

        private void ItemCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox CBox = (ComboBox)sender;
            if (CBox.SelectedIndex != -1)
            {
                if (QtyTBox.Value <= 0)
                    QtyTBox.Value = 1;

                PriceTBox.Value = (decimal)MyFunctions.GetScalar("SELECT ItemSalesPrice FROM Items WHERE (ItemId = @ItemId)", new SqlParameter("@ItemId", CBox.SelectedValue));

                SetTotals(false);
            }
            else
                PriceTBox.Value = 0;
        }
    }
}
