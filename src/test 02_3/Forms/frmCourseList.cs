using test_02_3.Data;
using test_02_3.Models;

namespace test_02_3;

public partial class frmCourseList : Form
{
    private readonly BindingSource _binding = new();

    public frmCourseList()
    {
        InitializeComponent();
        dgv.DataSource = _binding;
    }

    private void frmCourseList_Load(object sender, EventArgs e) => BindGrid();

    private void BindGrid()
    {
        _binding.DataSource = null;
        _binding.DataSource = SchoolRepository.Courses.ToList();
        if (dgv.Columns.Count == 0)
        {
            return;
        }

        dgv.Columns[nameof(Course.MaMh)]!.HeaderText = "Mã MH";
        dgv.Columns[nameof(Course.TenMh)]!.HeaderText = "Tên môn học";
        dgv.Columns[nameof(Course.SoTinChi)]!.HeaderText = "Số tín chỉ";
        dgv.Columns[nameof(Course.SoTiet)]!.HeaderText = "Số tiết";
        dgv.Columns[nameof(Course.Khoa)]!.HeaderText = "Khoa";
    }

    private Course ReadInput() => new()
    {
        MaMh = txtMa.Text.Trim(),
        TenMh = txtTen.Text.Trim(),
        SoTinChi = (int)numTinChi.Value,
        SoTiet = (int)numTiet.Value,
        Khoa = txtKhoa.Text.Trim()
    };

    private bool ValidateInput(bool adding)
    {
        if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text))
        {
            MessageBox.Show("Vui lòng nhập Mã môn học và Tên môn học.", "Thiếu dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        if (adding && SchoolRepository.Courses.Any(c => c.MaMh.Equals(txtMa.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("Mã môn học đã tồn tại.", "Trùng mã",
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

        SchoolRepository.Courses.Add(ReadInput());
        BindGrid();
        btnClear_Click(sender, e);
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (!ValidateInput(false))
        {
            return;
        }

        var item = SchoolRepository.Courses.FirstOrDefault(c =>
            c.MaMh.Equals(txtMa.Text.Trim(), StringComparison.OrdinalIgnoreCase));
        if (item is null)
        {
            MessageBox.Show("Không tìm thấy môn học để sửa.", "Không tìm thấy",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var data = ReadInput();
        item.TenMh = data.TenMh;
        item.SoTinChi = data.SoTinChi;
        item.SoTiet = data.SoTiet;
        item.Khoa = data.Khoa;
        BindGrid();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgv.CurrentRow?.DataBoundItem is not Course c)
        {
            MessageBox.Show("Hãy chọn một dòng để xóa.", "Chưa chọn dòng",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (MessageBox.Show($"Xóa môn học {c.MaMh} - {c.TenMh}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        SchoolRepository.Courses.Remove(c);
        BindGrid();
        btnClear_Click(sender, e);
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtMa.Clear();
        txtTen.Clear();
        txtKhoa.Clear();
        numTinChi.Value = 2;
        numTiet.Value = 30;
        txtMa.Focus();
    }

    private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgv.CurrentRow?.DataBoundItem is not Course c)
        {
            return;
        }

        txtMa.Text = c.MaMh;
        txtTen.Text = c.TenMh;
        numTinChi.Value = c.SoTinChi;
        numTiet.Value = c.SoTiet;
        txtKhoa.Text = c.Khoa;
    }
}
