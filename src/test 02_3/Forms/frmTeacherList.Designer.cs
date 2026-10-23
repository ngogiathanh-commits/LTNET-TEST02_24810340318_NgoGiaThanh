namespace test_02_3;

partial class frmTeacherList
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlEditor;
    private Label lblMa;
    private Label lblHoTen;
    private Label lblHocVi;
    private Label lblChuyenMon;
    private Label lblSdt;
    private Label lblEmail;
    private TextBox txtMa;
    private TextBox txtHoTen;
    private ComboBox cboHocVi;
    private TextBox txtChuyenMon;
    private TextBox txtSdt;
    private TextBox txtEmail;
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
        lblHocVi = new Label();
        cboHocVi = new ComboBox();
        lblChuyenMon = new Label();
        txtChuyenMon = new TextBox();
        lblSdt = new Label();
        txtSdt = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
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
        pnlEditor.Controls.AddRange(new Control[]
        {
            lblMa, txtMa, lblHoTen, txtHoTen, lblHocVi, cboHocVi, lblChuyenMon, txtChuyenMon,
            lblSdt, txtSdt, lblEmail, txtEmail, btnAdd, btnEdit, btnDelete, btnClear
        });

        lblMa.Text = "Mã GV";
        lblMa.Location = new Point(16, 16);
        lblMa.AutoSize = true;
        txtMa.Location = new Point(16, 36);
        txtMa.Size = new Size(110, 27);

        lblHoTen.Text = "Họ tên";
        lblHoTen.Location = new Point(140, 16);
        lblHoTen.AutoSize = true;
        txtHoTen.Location = new Point(140, 36);
        txtHoTen.Size = new Size(200, 27);

        lblHocVi.Text = "Học vị";
        lblHocVi.Location = new Point(356, 16);
        lblHocVi.AutoSize = true;
        cboHocVi.Location = new Point(356, 36);
        cboHocVi.Size = new Size(150, 27);
        cboHocVi.DropDownStyle = ComboBoxStyle.DropDownList;
        cboHocVi.Items.AddRange(new object[] { "Cử nhân", "Thạc sĩ", "Tiến sĩ", "Phó giáo sư", "Giáo sư" });

        lblChuyenMon.Text = "Chuyên môn";
        lblChuyenMon.Location = new Point(522, 16);
        lblChuyenMon.AutoSize = true;
        txtChuyenMon.Location = new Point(522, 36);
        txtChuyenMon.Size = new Size(200, 27);

        lblSdt.Text = "Điện thoại";
        lblSdt.Location = new Point(16, 72);
        lblSdt.AutoSize = true;
        txtSdt.Location = new Point(16, 92);
        txtSdt.Size = new Size(150, 27);

        lblEmail.Text = "Email";
        lblEmail.Location = new Point(180, 72);
        lblEmail.AutoSize = true;
        txtEmail.Location = new Point(180, 92);
        txtEmail.Size = new Size(220, 27);

        btnAdd.Text = "Thêm";
        btnAdd.Location = new Point(420, 90);
        btnAdd.Size = new Size(80, 30);
        btnAdd.Click += btnAdd_Click;
        btnEdit.Text = "Sửa";
        btnEdit.Location = new Point(506, 90);
        btnEdit.Size = new Size(80, 30);
        btnEdit.Click += btnEdit_Click;
        btnDelete.Text = "Xóa";
        btnDelete.Location = new Point(592, 90);
        btnDelete.Size = new Size(80, 30);
        btnDelete.Click += btnDelete_Click;
        btnClear.Text = "Làm mới";
        btnClear.Location = new Point(678, 90);
        btnClear.Size = new Size(80, 30);
        btnClear.Click += btnClear_Click;

        dgv.Dock = DockStyle.Fill;
        dgv.AllowUserToAddRows = false;
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
        Name = "frmTeacherList";
        Text = "Danh sách Giảng viên";
        Load += frmTeacherList_Load;
        pnlEditor.ResumeLayout(false);
        pnlEditor.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
        ResumeLayout(false);
    }
}
