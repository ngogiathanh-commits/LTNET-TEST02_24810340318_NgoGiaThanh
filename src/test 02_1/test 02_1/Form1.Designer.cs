namespace test_02_1
{
    partial class frmBookingManager
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
            components = new System.ComponentModel.Container();
            grpInput = new GroupBox();
            txtPricePerNight = new TextBox();
            lblPricePerNight = new Label();
            numDays = new NumericUpDown();
            lblDays = new Label();
            dtpCheckIn = new DateTimePicker();
            lblCheckIn = new Label();
            cboRoomType = new ComboBox();
            lblRoomType = new Label();
            txtIdentityCard = new TextBox();
            lblIdentityCard = new Label();
            txtCustomerName = new TextBox();
            lblCustomerName = new Label();
            txtBookingId = new TextBox();
            lblBookingId = new Label();
            grpActions = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvBookings = new DataGridView();
            epError = new ErrorProvider(components);
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDays).BeginInit();
            grpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epError).BeginInit();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Controls.Add(txtPricePerNight);
            grpInput.Controls.Add(lblPricePerNight);
            grpInput.Controls.Add(numDays);
            grpInput.Controls.Add(lblDays);
            grpInput.Controls.Add(dtpCheckIn);
            grpInput.Controls.Add(lblCheckIn);
            grpInput.Controls.Add(cboRoomType);
            grpInput.Controls.Add(lblRoomType);
            grpInput.Controls.Add(txtIdentityCard);
            grpInput.Controls.Add(lblIdentityCard);
            grpInput.Controls.Add(txtCustomerName);
            grpInput.Controls.Add(lblCustomerName);
            grpInput.Controls.Add(txtBookingId);
            grpInput.Controls.Add(lblBookingId);
            grpInput.Location = new Point(12, 12);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(620, 180);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin đặt phòng";
            // 
            // txtPricePerNight
            // 
            txtPricePerNight.Location = new Point(410, 135);
            txtPricePerNight.Name = "txtPricePerNight";
            txtPricePerNight.Size = new Size(180, 27);
            txtPricePerNight.TabIndex = 13;
            // 
            // lblPricePerNight
            // 
            lblPricePerNight.AutoSize = true;
            lblPricePerNight.Location = new Point(310, 138);
            lblPricePerNight.Name = "lblPricePerNight";
            lblPricePerNight.Size = new Size(92, 20);
            lblPricePerNight.TabIndex = 12;
            lblPricePerNight.Text = "Giá/Đêm (đ):";
            // 
            // numDays
            // 
            numDays.Location = new Point(410, 98);
            numDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDays.Name = "numDays";
            numDays.Size = new Size(180, 27);
            numDays.TabIndex = 11;
            numDays.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(310, 100);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(78, 20);
            lblDays.TabIndex = 10;
            lblDays.Text = "Số ngày ở:";
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.CustomFormat = "dd/MM/yyyy";
            dtpCheckIn.Format = DateTimePickerFormat.Custom;
            dtpCheckIn.Location = new Point(410, 60);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(180, 27);
            dtpCheckIn.TabIndex = 9;
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Location = new Point(310, 63);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(83, 20);
            lblCheckIn.TabIndex = 8;
            lblCheckIn.Text = "Ngày nhận:";
            // 
            // cboRoomType
            // 
            cboRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomType.FormattingEnabled = true;
            cboRoomType.Location = new Point(410, 22);
            cboRoomType.Name = "cboRoomType";
            cboRoomType.Size = new Size(180, 28);
            cboRoomType.TabIndex = 7;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(310, 25);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(87, 20);
            lblRoomType.TabIndex = 6;
            lblRoomType.Text = "Loại phòng:";
            // 
            // txtIdentityCard
            // 
            txtIdentityCard.Location = new Point(115, 98);
            txtIdentityCard.Name = "txtIdentityCard";
            txtIdentityCard.Size = new Size(170, 27);
            txtIdentityCard.TabIndex = 5;
            // 
            // lblIdentityCard
            // 
            lblIdentityCard.AutoSize = true;
            lblIdentityCard.Location = new Point(15, 101);
            lblIdentityCard.Name = "lblIdentityCard";
            lblIdentityCard.Size = new Size(92, 20);
            lblIdentityCard.TabIndex = 4;
            lblIdentityCard.Text = "CCCD/CMND:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(115, 60);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(170, 27);
            txtCustomerName.TabIndex = 3;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(15, 63);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(78, 20);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Tên khách:";
            // 
            // txtBookingId
            // 
            txtBookingId.Location = new Point(115, 22);
            txtBookingId.Name = "txtBookingId";
            txtBookingId.Size = new Size(170, 27);
            txtBookingId.TabIndex = 1;
            // 
            // lblBookingId
            // 
            lblBookingId.AutoSize = true;
            lblBookingId.Location = new Point(15, 25);
            lblBookingId.Name = "lblBookingId";
            lblBookingId.Size = new Size(58, 20);
            lblBookingId.TabIndex = 0;
            lblBookingId.Text = "Mã đặt:";
            // 
            // grpActions
            // 
            grpActions.Controls.Add(btnClear);
            grpActions.Controls.Add(btnDelete);
            grpActions.Controls.Add(btnUpdate);
            grpActions.Controls.Add(btnAdd);
            grpActions.Location = new Point(640, 12);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(140, 180);
            grpActions.TabIndex = 1;
            grpActions.TabStop = false;
            grpActions.Text = "Thao tác";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(10, 135);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 32);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm Mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(10, 98);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 32);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(10, 60);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 32);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 32);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm Đặt Phòng";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Location = new Point(12, 200);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(768, 240);
            dgvBookings.TabIndex = 2;
            dgvBookings.CellClick += dgvBookings_CellClick;
            // 
            // epError
            // 
            epError.ContainerControl = this;
            // 
            // frmBookingManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 453);
            Controls.Add(dgvBookings);
            Controls.Add(grpActions);
            Controls.Add(grpInput);
            Name = "frmBookingManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Đặt Phòng Khách Sạn (frmBookingManager)";
            Load += frmBookingManager_Load;
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDays).EndInit();
            grpActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ((System.ComponentModel.ISupportInitialize)epError).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInput;
        private TextBox txtBookingId;
        private Label lblBookingId;
        private TextBox txtCustomerName;
        private Label lblCustomerName;
        private TextBox txtIdentityCard;
        private Label lblIdentityCard;
        private ComboBox cboRoomType;
        private Label lblRoomType;
        private DateTimePicker dtpCheckIn;
        private Label lblCheckIn;
        private NumericUpDown numDays;
        private Label lblDays;
        private TextBox txtPricePerNight;
        private Label lblPricePerNight;
        private GroupBox grpActions;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvBookings;
        private ErrorProvider epError;
    }
}