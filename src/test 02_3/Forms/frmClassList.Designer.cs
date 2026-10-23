namespace test_02_3;

partial class frmClassList
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlEditor;
    private Label lblMa;
    private Label lblTen;
    private Label lblKhoa;
    private Label lblSiSo;
    private Label lblGvcn;
    private TextBox txtMa;
    private TextBox txtTen;
    private TextBox txtKhoa;
    private NumericUpDown numSiSo;
    private TextBox txtGvcn;
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
        lblKhoa = new Label();
        txtKhoa = new TextBox();
        lblSiSo = new Label();
        numSiSo = new NumericUpDown();
        lblGvcn = new Label();
        txtGvcn = new TextBox();
        btnAdd = new Button();
        btnEdit = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        dgv = new DataGridView();
        pnlEditor.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numSiSo).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
        SuspendLayout();

        pnlEditor.Dock = DockStyle.Top;
        pnlEditor.Height = 150;
        pnlEditor.Controls.AddRange(new Control[]
        {
            lblMa, txtMa, lblTen, txtTen, lblKhoa, txtKhoa, lblSiSo, numSiSo,
            lblGvcn, txtGvcn, btnAdd, btnEdit, btnDelete, btnClear
        });

        lblMa.Text = "Mã lớp";
        lblMa.Location = new Point(16, 16);
        lblMa.AutoSize = true;
        txtMa.Location = new Point(16, 36);
        txtMa.Size = new Size(110, 27);

        lblTen.Text = "Tên lớp";
        lblTen.Location = new Point(140, 16);
        lblTen.AutoSize = true;
        txtTen.Location = new Point(140, 36);
        txtTen.Size = new Size(250, 27);

        lblKhoa.Text = "Khoa";
        lblKhoa.Location = new Point(406, 16);
        lblKhoa.AutoSize = true;
        txtKhoa.Location = new Point(406, 36);
        txtKhoa.Size = new Size(150, 27);

        lblSiSo.Text = "Sĩ số";
        lblSiSo.Location = new Point(16, 72);
        lblSiSo.AutoSize = true;
        numSiSo.Location = new Point(16, 92);
        numSiSo.Size = new Size(110, 27);
        numSiSo.Maximum = 200;

        lblGvcn.Text = "GV chủ nhiệm";
        lblGvcn.Location = new Point(140, 72);
        lblGvcn.AutoSize = true;
        txtGvcn.Location = new Point(140, 92);
        txtGvcn.Size = new Size(250, 27);

        btnAdd.Text = "Thêm";
        btnAdd.Location = new Point(406, 90);
        btnAdd.Size = new Size(80, 30);
        btnAdd.Click += btnAdd_Click;
        btnEdit.Text = "Sửa";
        btnEdit.Location = new Point(492, 90);
        btnEdit.Size = new Size(80, 30);
        btnEdit.Click += btnEdit_Click;
        btnDelete.Text = "Xóa";
        btnDelete.Location = new Point(578, 90);
        btnDelete.Size = new Size(80, 30);
        btnDelete.Click += btnDelete_Click;
        btnClear.Text = "Làm mới";
        btnClear.Location = new Point(664, 90);
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
        Name = "frmClassList";
        Text = "Danh mục Lớp học";
        Load += frmClassList_Load;
        pnlEditor.ResumeLayout(false);
        pnlEditor.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numSiSo).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
        ResumeLayout(false);
    }
}
