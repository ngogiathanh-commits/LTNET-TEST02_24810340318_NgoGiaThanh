namespace test_02_4
{
    partial class frmWarehouseAnalytics
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpCriteria = new GroupBox();
            btnCancel = new Button();
            btnAnalyze = new Button();
            dtpToDate = new DateTimePicker();
            lblToDate = new Label();
            dtpFromDate = new DateTimePicker();
            lblFromDate = new Label();
            cboWarehouse = new ComboBox();
            lblWarehouse = new Label();
            grpStatus = new GroupBox();
            lblPercent = new Label();
            pgbStatus = new ProgressBar();
            dgvReportData = new DataGridView();
            grpCriteria.SuspendLayout();
            grpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportData).BeginInit();
            SuspendLayout();
            // 
            // grpCriteria
            // 
            grpCriteria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpCriteria.Controls.Add(btnCancel);
            grpCriteria.Controls.Add(btnAnalyze);
            grpCriteria.Controls.Add(dtpToDate);
            grpCriteria.Controls.Add(lblToDate);
            grpCriteria.Controls.Add(dtpFromDate);
            grpCriteria.Controls.Add(lblFromDate);
            grpCriteria.Controls.Add(cboWarehouse);
            grpCriteria.Controls.Add(lblWarehouse);
            grpCriteria.Location = new Point(12, 12);
            grpCriteria.Name = "grpCriteria";
            grpCriteria.Size = new Size(858, 100);
            grpCriteria.TabIndex = 0;
            grpCriteria.TabStop = false;
            grpCriteria.Text = "Tiêu chí thống kê";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(715, 48);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy Tác Vụ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAnalyze.Location = new Point(575, 48);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(130, 35);
            btnAnalyze.TabIndex = 6;
            btnAnalyze.Text = "Thống Kê Kho";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // dtpToDate
            // 
            dtpToDate.CustomFormat = "dd/MM/yyyy";
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Location = new Point(415, 52);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(135, 27);
            dtpToDate.TabIndex = 5;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Location = new Point(415, 25);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(75, 20);
            lblToDate.TabIndex = 4;
            lblToDate.Text = "Đến ngày:";
            // 
            // dtpFromDate
            // 
            dtpFromDate.CustomFormat = "dd/MM/yyyy";
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.Location = new Point(265, 52);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(135, 27);
            dtpFromDate.TabIndex = 3;
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Location = new Point(265, 25);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(65, 20);
            lblFromDate.TabIndex = 2;
            lblFromDate.Text = "Từ ngày:";
            // 
            // cboWarehouse
            // 
            cboWarehouse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWarehouse.FormattingEnabled = true;
            cboWarehouse.Location = new Point(15, 52);
            cboWarehouse.Name = "cboWarehouse";
            cboWarehouse.Size = new Size(230, 28);
            cboWarehouse.TabIndex = 1;
            // 
            // lblWarehouse
            // 
            lblWarehouse.AutoSize = true;
            lblWarehouse.Location = new Point(15, 25);
            lblWarehouse.Name = "lblWarehouse";
            lblWarehouse.Size = new Size(119, 20);
            lblWarehouse.TabIndex = 0;
            lblWarehouse.Text = "Chọn kho hàng:";
            // 
            // grpStatus
            // 
            grpStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpStatus.Controls.Add(lblPercent);
            grpStatus.Controls.Add(pgbStatus);
            grpStatus.Location = new Point(12, 118);
            grpStatus.Name = "grpStatus";
            grpStatus.Size = new Size(858, 65);
            grpStatus.TabIndex = 1;
            grpStatus.TabStop = false;
            grpStatus.Text = "Tiến trình tổng hợp dữ liệu";
            // 
            // lblPercent
            // 
            lblPercent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPercent.AutoSize = true;
            lblPercent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPercent.Location = new Point(795, 25);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(35, 23);
            lblPercent.TabIndex = 1;
            lblPercent.Text = "0%";
            // 
            // pgbStatus
            // 
            pgbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pgbStatus.Location = new Point(15, 25);
            pgbStatus.Name = "pgbStatus";
            pgbStatus.Size = new Size(765, 25);
            pgbStatus.TabIndex = 0;
            // 
            // dgvReportData
            // 
            dgvReportData.AllowUserToAddRows = false;
            dgvReportData.AllowUserToDeleteRows = false;
            dgvReportData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReportData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportData.Location = new Point(12, 189);
            dgvReportData.MultiSelect = false;
            dgvReportData.Name = "dgvReportData";
            dgvReportData.ReadOnly = true;
            dgvReportData.RowHeadersWidth = 51;
            dgvReportData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportData.Size = new Size(858, 352);
            dgvReportData.TabIndex = 2;
            // 
            // frmWarehouseAnalytics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(dgvReportData);
            Controls.Add(grpStatus);
            Controls.Add(grpCriteria);
            MinimumSize = new Size(900, 600);
            Name = "frmWarehouseAnalytics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phân Tích & Thống Kê Dữ Liệu Tồn Kho";
            Load += frmWarehouseAnalytics_Load;
            grpCriteria.ResumeLayout(false);
            grpCriteria.PerformLayout();
            grpStatus.ResumeLayout(false);
            grpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCriteria;
        private ComboBox cboWarehouse;
        private Label lblWarehouse;
        private DateTimePicker dtpToDate;
        private Label lblToDate;
        private DateTimePicker dtpFromDate;
        private Label lblFromDate;
        private Button btnCancel;
        private Button btnAnalyze;
        private GroupBox grpStatus;
        private Label lblPercent;
        private ProgressBar pgbStatus;
        private DataGridView dgvReportData;
    }
}