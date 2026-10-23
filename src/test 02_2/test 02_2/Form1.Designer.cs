using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace test_02_2
{
    partial class frmEmployeeManager
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
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuOpenCsv = new ToolStripMenuItem();
            mnuSaveCsv = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuTask = new ToolStripMenuItem();
            mnuAdd = new ToolStripMenuItem();
            mnuDelete = new ToolStripMenuItem();
            mnuSearch = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbOpen = new ToolStripButton();
            tsbSave = new ToolStripButton();
            tsbAdd = new ToolStripButton();
            grpDetail = new GroupBox();
            btnSelectAvatar = new Button();
            picAvatar = new PictureBox();
            txtSalary = new TextBox();
            lblSalary = new Label();
            cboPosition = new ComboBox();
            lblPosition = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            txtEmployeeId = new TextBox();
            lblEmployeeId = new Label();
            grpActions = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvEmployees = new DataGridView();
            statusStrip1 = new StatusStrip();
            lblTotalEmployees = new ToolStripStatusLabel();
            lblTotalSalary = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            timerClock = new System.Windows.Forms.Timer(components);
            epError = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            grpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epError).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuTask });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(882, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuOpenCsv, mnuSaveCsv, toolStripSeparator1, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "File";
            // 
            // mnuOpenCsv
            // 
            mnuOpenCsv.Name = "mnuOpenCsv";
            mnuOpenCsv.Size = new Size(171, 26);
            mnuOpenCsv.Text = "Mở file CSV";
            mnuOpenCsv.Click += mnuOpenCsv_Click;
            // 
            // mnuSaveCsv
            // 
            mnuSaveCsv.Name = "mnuSaveCsv";
            mnuSaveCsv.Size = new Size(171, 26);
            mnuSaveCsv.Text = "Lưu file CSV";
            mnuSaveCsv.Click += mnuSaveCsv_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(168, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(171, 26);
            mnuExit.Text = "Thoát";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuTask
            // 
            mnuTask.DropDownItems.AddRange(new ToolStripItem[] { mnuAdd, mnuDelete, mnuSearch });
            mnuTask.Name = "mnuTask";
            mnuTask.Size = new Size(63, 24);
            mnuTask.Text = "Tác vụ";
            // 
            // mnuAdd
            // 
            mnuAdd.Name = "mnuAdd";
            mnuAdd.Size = new Size(159, 26);
            mnuAdd.Text = "Thêm mới";
            mnuAdd.Click += btnAdd_Click;
            // 
            // mnuDelete
            // 
            mnuDelete.Name = "mnuDelete";
            mnuDelete.Size = new Size(159, 26);
            mnuDelete.Text = "Xóa";
            mnuDelete.Click += btnDelete_Click;
            // 
            // mnuSearch
            // 
            mnuSearch.Name = "mnuSearch";
            mnuSearch.Size = new Size(159, 26);
            mnuSearch.Text = "Tìm kiếm";
            mnuSearch.Click += mnuSearch_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbOpen, tsbSave, tsbAdd });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(882, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            tsbOpen.ImageTransparentColor = Color.Magenta;
            tsbOpen.Name = "tsbOpen";
            tsbOpen.Size = new Size(90, 24);
            tsbOpen.Text = "Mở file CSV";
            tsbOpen.Click += mnuOpenCsv_Click;
            // 
            // tsbSave
            // 
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(92, 24);
            tsbSave.Text = "Lưu file CSV";
            tsbSave.Click += mnuSaveCsv_Click;
            // 
            // tsbAdd
            // 
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(80, 24);
            tsbAdd.Text = "Thêm mới";
            tsbAdd.Click += btnAdd_Click;
            // 
            // grpDetail
            // 
            grpDetail.Controls.Add(btnSelectAvatar);
            grpDetail.Controls.Add(picAvatar);
            grpDetail.Controls.Add(txtSalary);
            grpDetail.Controls.Add(lblSalary);
            grpDetail.Controls.Add(cboPosition);
            grpDetail.Controls.Add(lblPosition);
            grpDetail.Controls.Add(txtFullName);
            grpDetail.Controls.Add(lblFullName);
            grpDetail.Controls.Add(txtEmployeeId);
            grpDetail.Controls.Add(lblEmployeeId);
            grpDetail.Location = new Point(12, 60);
            grpDetail.Name = "grpDetail";
            grpDetail.Size = new Size(700, 180);
            grpDetail.TabIndex = 2;
            grpDetail.TabStop = false;
            grpDetail.Text = "Thông tin chi tiết nhân sự";
            // 
            // btnSelectAvatar
            // 
            btnSelectAvatar.Location = new Point(545, 140);
            btnSelectAvatar.Name = "btnSelectAvatar";
            btnSelectAvatar.Size = new Size(135, 30);
            btnSelectAvatar.TabIndex = 9;
            btnSelectAvatar.Text = "Chọn ảnh...";
            btnSelectAvatar.UseVisualStyleBackColor = true;
            btnSelectAvatar.Click += btnSelectAvatar_Click;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(545, 22);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(135, 110);
            picAvatar.TabIndex = 8;
            picAvatar.TabStop = false;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(120, 137);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(390, 27);
            txtSalary.TabIndex = 7;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(15, 140);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(99, 20);
            lblSalary.TabIndex = 6;
            lblSalary.Text = "Lương (VNĐ):";
            // 
            // cboPosition
            // 
            cboPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPosition.FormattingEnabled = true;
            cboPosition.Location = new Point(120, 98);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(390, 28);
            cboPosition.TabIndex = 5;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(15, 101);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(64, 20);
            lblPosition.TabIndex = 4;
            lblPosition.Text = "Chức vụ:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(120, 60);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(390, 27);
            txtFullName.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(15, 63);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 20);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Họ và tên:";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(120, 22);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(390, 27);
            txtEmployeeId.TabIndex = 1;
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Location = new Point(15, 25);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(57, 20);
            lblEmployeeId.TabIndex = 0;
            lblEmployeeId.Text = "Mã NV:";
            // 
            // grpActions
            // 
            grpActions.Controls.Add(btnClear);
            grpActions.Controls.Add(btnDelete);
            grpActions.Controls.Add(btnUpdate);
            grpActions.Controls.Add(btnAdd);
            grpActions.Location = new Point(725, 60);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(145, 180);
            grpActions.TabIndex = 3;
            grpActions.TabStop = false;
            grpActions.Text = "Thao tác";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 135);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 32);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm Mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 98);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 32);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 60);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 32);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 32);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm Mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 250);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(858, 270);
            dgvEmployees.TabIndex = 4;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTotalEmployees, lblTotalSalary, lblClock });
            statusStrip1.Location = new Point(0, 522);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(882, 26);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTotalEmployees
            // 
            lblTotalEmployees.Name = "lblTotalEmployees";
            lblTotalEmployees.Size = new Size(144, 20);
            lblTotalEmployees.Text = "Tổng số nhân viên: 0";
            // 
            // lblTotalSalary
            // 
            lblTotalSalary.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalSalary.ForeColor = Color.Blue;
            lblTotalSalary.Name = "lblTotalSalary";
            lblTotalSalary.Size = new Size(580, 20);
            lblTotalSalary.Spring = true;
            lblTotalSalary.Text = "Tổng quỹ lương: 0 VNĐ";
            lblTotalSalary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblClock
            // 
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(143, 20);
            lblClock.Text = "00/00/0000 00:00:00";
            // 
            // timerClock
            // 
            timerClock.Tick += timerClock_Tick;
            // 
            // epError
            // 
            epError.ContainerControl = this;
            // 
            // frmEmployeeManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 548);
            Controls.Add(statusStrip1);
            Controls.Add(dgvEmployees);
            Controls.Add(grpActions);
            Controls.Add(grpDetail);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmEmployeeManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Hồ Sơ Nhân Sự & Thông Tin Lương";
            Load += frmEmployeeManager_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            grpDetail.ResumeLayout(false);
            grpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            grpActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuOpenCsv;
        private ToolStripMenuItem mnuSaveCsv;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuTask;
        private ToolStripMenuItem mnuAdd;
        private ToolStripMenuItem mnuDelete;
        private ToolStripMenuItem mnuSearch;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbOpen;
        private ToolStripButton tsbSave;
        private ToolStripButton tsbAdd;
        private GroupBox grpDetail;
        private Label lblEmployeeId;
        private TextBox txtEmployeeId;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblPosition;
        private ComboBox cboPosition;
        private Label lblSalary;
        private TextBox txtSalary;
        private PictureBox picAvatar;
        private Button btnSelectAvatar;
        private GroupBox grpActions;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvEmployees;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTotalEmployees;
        private ToolStripStatusLabel lblTotalSalary;
        private ToolStripStatusLabel lblClock;
        private System.Windows.Forms.Timer timerClock;
        private ErrorProvider epError;
    }
}