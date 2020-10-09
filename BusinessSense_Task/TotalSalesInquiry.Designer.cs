namespace BusinessSense_Task
{
    partial class TotalSalesInquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalSalesInquiry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ByDateRadioBtn = new System.Windows.Forms.RadioButton();
            this.ByItemRadioBtn = new System.Windows.Forms.RadioButton();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MyDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.PrintBtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.ToDateTimePicker);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.FromDateTimePicker);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 105);
            this.panel1.TabIndex = 0;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrintBtn.Image")));
            this.PrintBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PrintBtn.Location = new System.Drawing.Point(762, 16);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(97, 73);
            this.PrintBtn.TabIndex = 20;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ByDateRadioBtn);
            this.groupBox1.Controls.Add(this.ByItemRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(426, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 60);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales by";
            // 
            // ByDateRadioBtn
            // 
            this.ByDateRadioBtn.AutoSize = true;
            this.ByDateRadioBtn.Location = new System.Drawing.Point(76, 24);
            this.ByDateRadioBtn.Name = "ByDateRadioBtn";
            this.ByDateRadioBtn.Size = new System.Drawing.Size(55, 21);
            this.ByDateRadioBtn.TabIndex = 1;
            this.ByDateRadioBtn.Text = "Date";
            this.ByDateRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ByItemRadioBtn
            // 
            this.ByItemRadioBtn.AutoSize = true;
            this.ByItemRadioBtn.Checked = true;
            this.ByItemRadioBtn.Location = new System.Drawing.Point(16, 25);
            this.ByItemRadioBtn.Name = "ByItemRadioBtn";
            this.ByItemRadioBtn.Size = new System.Drawing.Size(54, 21);
            this.ByItemRadioBtn.TabIndex = 0;
            this.ByItemRadioBtn.TabStop = true;
            this.ByItemRadioBtn.Text = "Item";
            this.ByItemRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SearchBtn.Location = new System.Drawing.Point(638, 9);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(97, 86);
            this.SearchBtn.TabIndex = 18;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.CustomFormat = "";
            this.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateTimePicker.Location = new System.Drawing.Point(255, 40);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(107, 24);
            this.ToDateTimePicker.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Todate";
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.CustomFormat = "";
            this.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateTimePicker.Location = new System.Drawing.Point(85, 40);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(107, 24);
            this.FromDateTimePicker.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Fromdate";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MyDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 449);
            this.panel2.TabIndex = 1;
            // 
            // MyDataGridView
            // 
            this.MyDataGridView.AllowUserToAddRows = false;
            this.MyDataGridView.AllowUserToDeleteRows = false;
            this.MyDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MyDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.MyDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.MyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MyDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.MyDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MyDataGridView.MultiSelect = false;
            this.MyDataGridView.Name = "MyDataGridView";
            this.MyDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.MyDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MyDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyDataGridView.ShowCellErrors = false;
            this.MyDataGridView.ShowEditingIcon = false;
            this.MyDataGridView.ShowRowErrors = false;
            this.MyDataGridView.Size = new System.Drawing.Size(933, 449);
            this.MyDataGridView.TabIndex = 10;
            // 
            // TotalSalesInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TotalSalesInquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Sales Inquiry";
            this.Load += new System.EventHandler(this.TotalSalesInquiry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TotalSalesInquiry_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView MyDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ByDateRadioBtn;
        private System.Windows.Forms.RadioButton ByItemRadioBtn;
        private System.Windows.Forms.Button PrintBtn;
    }
}