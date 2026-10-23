using test_02_3.Data;
using test_02_3.Models;

namespace test_02_3;

public partial class frmTeacherList : Form
{
    private readonly BindingSource _binding = new();

    public frmTeacherList()
    {
        InitializeComponent();
        dgv.DataSource = _binding;
    }

    private void frmTeacherList_Load(object sender, EventArgs e)
    {
        cboHocVi.SelectedIndex = 1;
        BindGrid();
    }

    private void BindGrid()
    {
        _binding.DataSource = null;
        _binding.DataSource = SchoolRepository.Teachers.ToList();
        if (dgv.Columns.Count == 0)
        {
            return;
        }

        dgv.Columns[nameof(Teacher.MaGv)]!.HeaderText = "Mã GV";
        dgv.Columns[nameof(Teacher.HoTen)]!.HeaderText = "Họ tên";
        dgv.Columns[nameof(Teacher.HocVi)]!.HeaderText = "Học vị";
        dgv.Columns[nameof(Teacher.ChuyenMon)]!.HeaderText = "Chuyên môn";
        dgv.Columns[nameof(Teacher.DienThoai)]!.HeaderText = "Điện thoại";
        dgv.Columns[nameof(Teacher.Email)]!.HeaderText = "Email";
    }

    private Teacher ReadInput() => new()
    {
        MaGv = txtMa.Text.Trim(),
        HoTen = txtHoTen.Text.Trim(),
        HocVi = cboHocVi.Text,
        ChuyenMon = txtChuyenMon.Text.Trim(),
        DienThoai = txtSdt.Text.Trim(),
        Email = txtEmail.Text.Trim()
    };

    private bool ValidateInput(bool adding)
    {
        if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
        {
            MessageBox.Show("Vui lòng nhập Mã GV và Họ tên.", "Thiếu dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        if (adding && SchoolRepository.Teachers.Any(t => t.MaGv.Equals(txtMa.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("Mã giảng viên đã tồn tại.", "Trùng mã",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!ValidateInput(true))
        {
            return;
        }

        SchoolRepository.Teachers.Add(ReadInput());
        BindGrid();
        btnClear_Click(sender, e);
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (!ValidateInput(false))
        {
            return;
        }

        var item = SchoolRepository.Teachers.FirstOrDefault(t =>
            t.MaGv.Equals(txtMa.Text.Trim(), StringComparison.OrdinalIgnoreCase));
        if (item is null)
        {
            MessageBox.Show("Không tìm thấy giảng viên để sửa.", "Không tìm thấy",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var data = ReadInput();
        item.HoTen = data.HoTen;
        item.HocVi = data.HocVi;
        item.ChuyenMon = data.ChuyenMon;
        item.DienThoai = data.DienThoai;
        item.Email = data.Email;
        BindGrid();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgv.CurrentRow?.DataBoundItem is not Teacher t)
        {
            MessageBox.Show("Hãy chọn một dòng để xóa.", "Chưa chọn dòng",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (MessageBox.Show($"Xóa giảng viên {t.MaGv} - {t.HoTen}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        SchoolRepository.Teachers.Remove(t);
        BindGrid();
        btnClear_Click(sender, e);
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtMa.Clear();
        txtHoTen.Clear();
        txtChuyenMon.Clear();
        txtSdt.Clear();
        txtEmail.Clear();
        cboHocVi.SelectedIndex = 1;
        txtMa.Focus();
    }

    private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgv.CurrentRow?.DataBoundItem is not Teacher t)
        {
            return;
        }

        txtMa.Text = t.MaGv;
        txtHoTen.Text = t.HoTen;
        cboHocVi.Text = t.HocVi;
        txtChuyenMon.Text = t.ChuyenMon;
        txtSdt.Text = t.DienThoai;
        txtEmail.Text = t.Email;
    }
}
