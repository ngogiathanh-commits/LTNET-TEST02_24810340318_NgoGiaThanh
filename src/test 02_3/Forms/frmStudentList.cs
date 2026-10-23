using test_02_3.Data;
using test_02_3.Models;

namespace test_02_3;

public partial class frmStudentList : Form
{
    private readonly BindingSource _binding = new();

    public frmStudentList()
    {
        InitializeComponent();
        dgv.DataSource = _binding;
    }

    private void frmStudentList_Load(object sender, EventArgs e)
    {
        cboGioiTinh.SelectedIndex = 0;
        BindGrid();
    }

    private void BindGrid()
    {
        _binding.DataSource = null;
        _binding.DataSource = SchoolRepository.Students.ToList();
        if (dgv.Columns.Count == 0)
        {
            return;
        }

        dgv.Columns[nameof(Student.MaSv)]!.HeaderText = "Mã SV";
        dgv.Columns[nameof(Student.HoTen)]!.HeaderText = "Họ tên";
        dgv.Columns[nameof(Student.NgaySinh)]!.HeaderText = "Ngày sinh";
        dgv.Columns[nameof(Student.GioiTinh)]!.HeaderText = "Giới tính";
        dgv.Columns[nameof(Student.MaLop)]!.HeaderText = "Mã lớp";
        dgv.Columns[nameof(Student.Email)]!.HeaderText = "Email";
        dgv.Columns[nameof(Student.DienThoai)]!.HeaderText = "Điện thoại";
        dgv.Columns[nameof(Student.NgaySinh)]!.DefaultCellStyle.Format = "dd/MM/yyyy";
    }

    private Student ReadInput() => new()
    {
        MaSv = txtMa.Text.Trim(),
        HoTen = txtHoTen.Text.Trim(),
        NgaySinh = dtpNgaySinh.Value.Date,
        GioiTinh = cboGioiTinh.Text,
        MaLop = txtLop.Text.Trim(),
        Email = txtEmail.Text.Trim(),
        DienThoai = txtSdt.Text.Trim()
    };

    private bool ValidateInput(bool adding)
    {
        if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
        {
            MessageBox.Show("Vui lòng nhập Mã SV và Họ tên.", "Thiếu dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        if (adding && SchoolRepository.Students.Any(s => s.MaSv.Equals(txtMa.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("Mã sinh viên đã tồn tại.", "Trùng mã",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!ValidateInput(adding: true))
        {
            return;
        }

        SchoolRepository.Students.Add(ReadInput());
        BindGrid();
        btnClear_Click(sender, e);
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (!ValidateInput(adding: false))
        {
            return;
        }

        var item = SchoolRepository.Students.FirstOrDefault(s =>
            s.MaSv.Equals(txtMa.Text.Trim(), StringComparison.OrdinalIgnoreCase));
        if (item is null)
        {
            MessageBox.Show("Không tìm thấy sinh viên để sửa. Hãy chọn một dòng trên lưới.", "Không tìm thấy",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var data = ReadInput();
        item.HoTen = data.HoTen;
        item.NgaySinh = data.NgaySinh;
        item.GioiTinh = data.GioiTinh;
        item.MaLop = data.MaLop;
        item.Email = data.Email;
        item.DienThoai = data.DienThoai;
        BindGrid();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgv.CurrentRow?.DataBoundItem is not Student s)
        {
            MessageBox.Show("Hãy chọn một dòng để xóa.", "Chưa chọn dòng",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (MessageBox.Show($"Xóa sinh viên {s.MaSv} - {s.HoTen}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        SchoolRepository.Students.Remove(s);
        BindGrid();
        btnClear_Click(sender, e);
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtMa.Clear();
        txtHoTen.Clear();
        txtLop.Clear();
        txtEmail.Clear();
        txtSdt.Clear();
        cboGioiTinh.SelectedIndex = 0;
        dtpNgaySinh.Value = DateTime.Today.AddYears(-20);
        txtMa.Focus();
    }

    private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgv.CurrentRow?.DataBoundItem is not Student s)
        {
            return;
        }

        txtMa.Text = s.MaSv;
        txtHoTen.Text = s.HoTen;
        dtpNgaySinh.Value = s.NgaySinh;
        cboGioiTinh.Text = s.GioiTinh;
        txtLop.Text = s.MaLop;
        txtEmail.Text = s.Email;
        txtSdt.Text = s.DienThoai;
    }
}
