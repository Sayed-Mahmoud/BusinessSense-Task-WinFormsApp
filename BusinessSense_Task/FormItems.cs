using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessSense_Task
{
    public partial class FormItems : Form
    {
        public FormItems()
        {
            InitializeComponent();
        }

        private void FormItems_Load(object sender, EventArgs e)
        {
            this.selectItemsTableAdapter.Fill(this.myDataSet.SelectItems);
            if (MyDataGridView.RowCount < 1)
            {
                AddNew();
            }

            SearchType.ValueMember = "Id";
            SearchType.DisplayMember = "Val";
            SearchType.DataSource = new List<CBoxItems>()
            {
                    new CBoxItems(0, "Item ID"),
                    new CBoxItems(1, "Item BarCode"),
                    new CBoxItems(2, "Item Name")
            };
        }

        private void MyDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error: " + e.Exception.Message + Environment.NewLine + "Row: " + e.RowIndex + Environment.NewLine + "Col: " + e.ColumnIndex);
            e.Cancel = true;
        }


        private void AddNew()
        {
            this.selectItemsBindingSource.AddNew();
            ItemPriceNum.Value = 0;
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            if (this.selectItemsBindingSource.Current == null || !((DataRowView)this.selectItemsBindingSource.Current).IsNew)
            {
                AddNew();
            }
        }


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (this.selectItemsBindingSource.Current == null)
                return;

            if (MessageBox.Show("Are you sure?", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                selectItemsBindingSource.RemoveCurrent();
                selectItemsTableAdapter.Update(myDataSet.SelectItems);
                // this.selectItemsTableAdapter.Fill(this.myDataSet.SelectItems);
                if (MyDataGridView.RowCount < 1)
                {
                    AddNew();
                }
            }
        }

        private void MyDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void MyDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            selectItemsTableAdapter.Update(myDataSet.SelectItems);
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ItemBarcodeTBox.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid Barcode!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (ItemNameTBOX.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (ItemPriceNum.Value <= 0)
            {
                MessageBox.Show("Please enter a valid price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //MyDataGridView.EndEdit();
            selectItemsBindingSource.EndEdit();
            selectItemsTableAdapter.Update(myDataSet.SelectItems);
        }


        private void FormItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
                NewBtn.PerformClick();
            else if (e.Control && e.KeyCode == Keys.S)
                SaveBtn.PerformClick();
            else if (e.Shift && e.KeyCode == Keys.Delete)
                DeleteBtn.PerformClick();
            else if (e.Control && e.KeyCode == Keys.F)
                SearchTxt.Focus();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTxt.Text))
            {
                selectItemsBindingSource.RemoveFilter();
                return;
            }

            if ((int?)SearchType.SelectedValue == 0)
            {
                selectItemsBindingSource.Filter = "Convert(ItemId, 'System.String') LIKE ('%" + SearchTxt.Text + "%')";
            }
            else if ((int?)SearchType.SelectedValue == 1)
            {
                selectItemsBindingSource.Filter = "ItemBarCode LIKE ('%" + SearchTxt.Text + "%')";
            }
            else if ((int?)SearchType.SelectedValue == 2)
            {
                selectItemsBindingSource.Filter = "ItemName LIKE ('%" + SearchTxt.Text + "%')";
            }
        }
    }
    public class CBoxItems
    {
        readonly int? id;
        readonly string val;
        public CBoxItems(int? Id, string Val)
        {
            this.id = Id;
            this.val = Val;
        }

        public int? Id
        {
            get
            {
                return id;
            }
        }
        public string Val
        {
            get
            {
                return val;
            }
        }
    }
}
