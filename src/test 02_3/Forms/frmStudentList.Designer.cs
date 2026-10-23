namespace test_02_3;

partial class frmStudentList
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlEditor;
    private Label lblMa;
    private Label lblHoTen;
    private Label lblNs;
    private Label lblGt;
    private Label lblLop;
    private Label lblEmail;
    private Label lblSdt;
    private TextBox txtMa;
    private TextBox txtHoTen;
    private DateTimePicker dtpNgaySinh;
    private ComboBox cboGioiTinh;
    private TextBox txtLop;
    private TextBox txtEmail;
    private TextBox txtSdt;
    private Button btnAdd;
    private Button btnEdit;
    private Button btnDelete;
    private Button btnClear;
    private DataGridView dgv;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlEditor = new Panel();
        lblMa = new Label();
        txtMa = new TextBox();
        lblHoTen = new Label();
        txtHoTen = new TextBox();
        lblNs = new Label();
        dtpNgaySinh = new DateTimePicker();
        lblGt = new Label();
        cboGioiTinh = new ComboBox();
        lblLop = new Label();
        txtLop = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        lblSdt = new Label();
        txtSdt = new TextBox();
        btnAdd = new Button();
        btnEdit = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        dgv = new DataGridView();
        pnlEditor.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
        SuspendLayout();

        pnlEditor.Dock = DockStyle.Top;
        pnlEditor.Height = 150;
        pnlEditor.Padding = new Padding(12);
        pnlEditor.Controls.AddRange(new Control[]
        {
            lblMa, txtMa, lblHoTen, txtHoTen, lblNs, dtpNgaySinh, lblGt, cboGioiTinh,
            lblLop, txtLop, lblEmail, txtEmail, lblSdt, txtSdt, btnAdd, btnEdit, btnDelete, btnClear
        });

        lblMa.Text = "Mã SV";
        lblMa.Location = new Point(16, 16);
        lblMa.AutoSize = true;
        txtMa.Location = new Point(16, 36);
        txtMa.Size = new Size(110, 27);

        lblHoTen.Text = "Họ tên";
        lblHoTen.Location = new Point(140, 16);
        lblHoTen.AutoSize = true;
        txtHoTen.Location = new Point(140, 36);
        txtHoTen.Size = new Size(200, 27);

        lblNs.Text = "Ngày sinh";
        lblNs.Location = new Point(356, 16);
        lblNs.AutoSize = true;
        dtpNgaySinh.Location = new Point(356, 36);
        dtpNgaySinh.Size = new Size(150, 27);
        dtpNgaySinh.Format = DateTimePickerFormat.Short;

        lblGt.Text = "Giới tính";
        lblGt.Location = new Point(522, 16);
        lblGt.AutoSize = true;
        cboGioiTinh.Location = new Point(522, 36);
        cboGioiTinh.Size = new Size(110, 27);
        cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
        cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });

        lblLop.Text = "Mã lớp";
        lblLop.Location = new Point(16, 72);
        lblLop.AutoSize = true;
        txtLop.Location = new Point(16, 92);
        txtLop.Size = new Size(110, 27);

        lblEmail.Text = "Email";
        lblEmail.Location = new Point(140, 72);
        lblEmail.AutoSize = true;
        txtEmail.Location = new Point(140, 92);
        txtEmail.Size = new Size(200, 27);

        lblSdt.Text = "Điện thoại";
        lblSdt.Location = new Point(356, 72);
        lblSdt.AutoSize = true;
        txtSdt.Location = new Point(356, 92);
        txtSdt.Size = new Size(150, 27);

        btnAdd.Text = "Thêm";
        btnAdd.Location = new Point(522, 90);
        btnAdd.Size = new Size(80, 30);
        btnAdd.Click += btnAdd_Click;

        btnEdit.Text = "Sửa";
        btnEdit.Location = new Point(608, 90);
        btnEdit.Size = new Size(80, 30);
        btnEdit.Click += btnEdit_Click;

        btnDelete.Text = "Xóa";
        btnDelete.Location = new Point(694, 90);
        btnDelete.Size = new Size(80, 30);
        btnDelete.Click += btnDelete_Click;

        btnClear.Text = "Làm mới";
        btnClear.Location = new Point(780, 90);
        btnClear.Size = new Size(80, 30);
        btnClear.Click += btnClear_Click;

        dgv.Dock = DockStyle.Fill;
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.ReadOnly = true;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.MultiSelect = false;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.RowHeadersVisible = false;
        dgv.BackgroundColor = Color.White;
        dgv.CellClick += dgv_CellClick;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 520);
        Controls.Add(dgv);
        Controls.Add(pnlEditor);
        Font = new Font("Segoe UI", 9F);
        Name = "frmStudentList";
        Text = "Danh sách Sinh viên";
        Load += frmStudentList_Load;
        pnlEditor.ResumeLayout(false);
        pnlEditor.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
        ResumeLayout(false);
    }
}
