namespace test_02_3;

partial class frmCourseList
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlEditor;
    private Label lblMa;
    private Label lblTen;
    private Label lblTinChi;
    private Label lblTiet;
    private Label lblKhoa;
    private TextBox txtMa;
    private TextBox txtTen;
    private NumericUpDown numTinChi;
    private NumericUpDown numTiet;
    private TextBox txtKhoa;
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
        lblTen = new Label();
        txtTen = new TextBox();
        lblTinChi = new Label();
        numTinChi = new NumericUpDown();
        lblTiet = new Label();
        numTiet = new NumericUpDown();
        lblKhoa = new Label();
        txtKhoa = new TextBox();
        btnAdd = new Button();
        btnEdit = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        dgv = new DataGridView();
        pnlEditor.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numTinChi).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numTiet).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
        SuspendLayout();

        pnlEditor.Dock = DockStyle.Top;
        pnlEditor.Height = 150;
        pnlEditor.Controls.AddRange(new Control[]
        {
            lblMa, txtMa, lblTen, txtTen, lblTinChi, numTinChi, lblTiet, numTiet,
            lblKhoa, txtKhoa, btnAdd, btnEdit, btnDelete, btnClear
        });

        lblMa.Text = "Mã MH";
        lblMa.Location = new Point(16, 16);
        lblMa.AutoSize = true;
        txtMa.Location = new Point(16, 36);
        txtMa.Size = new Size(110, 27);

        lblTen.Text = "Tên môn học";
        lblTen.Location = new Point(140, 16);
        lblTen.AutoSize = true;
        txtTen.Location = new Point(140, 36);
        txtTen.Size = new Size(260, 27);

        lblTinChi.Text = "Số tín chỉ";
        lblTinChi.Location = new Point(416, 16);
        lblTinChi.AutoSize = true;
        numTinChi.Location = new Point(416, 36);
        numTinChi.Size = new Size(80, 27);
        numTinChi.Minimum = 1;
        numTinChi.Maximum = 10;
        numTinChi.Value = 2;

        lblTiet.Text = "Số tiết";
        lblTiet.Location = new Point(512, 16);
        lblTiet.AutoSize = true;
        numTiet.Location = new Point(512, 36);
        numTiet.Size = new Size(80, 27);
        numTiet.Minimum = 15;
        numTiet.Maximum = 120;
        numTiet.Value = 30;

        lblKhoa.Text = "Khoa";
        lblKhoa.Location = new Point(16, 72);
        lblKhoa.AutoSize = true;
        txtKhoa.Location = new Point(16, 92);
        txtKhoa.Size = new Size(150, 27);

        btnAdd.Text = "Thêm";
        btnAdd.Location = new Point(190, 90);
        btnAdd.Size = new Size(80, 30);
        btnAdd.Click += btnAdd_Click;
        btnEdit.Text = "Sửa";
        btnEdit.Location = new Point(276, 90);
        btnEdit.Size = new Size(80, 30);
        btnEdit.Click += btnEdit_Click;
        btnDelete.Text = "Xóa";
        btnDelete.Location = new Point(362, 90);
        btnDelete.Size = new Size(80, 30);
        btnDelete.Click += btnDelete_Click;
        btnClear.Text = "Làm mới";
        btnClear.Location = new Point(448, 90);
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
        Name = "frmCourseList";
        Text = "Danh mục môn học";
        Load += frmCourseList_Load;
        pnlEditor.ResumeLayout(false);
        pnlEditor.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numTinChi).EndInit();
        ((System.ComponentModel.ISupportInitialize)numTiet).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
        ResumeLayout(false);
    }
}
