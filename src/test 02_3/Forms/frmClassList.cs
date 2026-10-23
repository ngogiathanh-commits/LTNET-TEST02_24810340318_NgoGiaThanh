using test_02_3.Data;
using test_02_3.Models;

namespace test_02_3;

public partial class frmClassList : Form
{
    private readonly BindingSource _binding = new();

    public frmClassList()
    {
        InitializeComponent();
        dgv.DataSource = _binding;
    }

    private void frmClassList_Load(object sender, EventArgs e) => BindGrid();

    private void BindGrid()
    {
        _binding.DataSource = null;
        _binding.DataSource = SchoolRepository.Classes.ToList();
        if (dgv.Columns.Count == 0)
        {
            return;
        }

        dgv.Columns[nameof(SchoolClass.MaLop)]!.HeaderText = "Mã lớp";
        dgv.Columns[nameof(SchoolClass.TenLop)]!.HeaderText = "Tên lớp";
        dgv.Columns[nameof(SchoolClass.Khoa)]!.HeaderText = "Khoa";
        dgv.Columns[nameof(SchoolClass.SiSo)]!.HeaderText = "Sĩ số";
        dgv.Columns[nameof(SchoolClass.Gvcn)]!.HeaderText = "GV chủ nhiệm";
    }

    private SchoolClass ReadInput() => new()
    {
        MaLop = txtMa.Text.Trim(),
        TenLop = txtTen.Text.Trim(),
        Khoa = txtKhoa.Text.Trim(),
        SiSo = (int)numSiSo.Value,
        Gvcn = txtGvcn.Text.Trim()
    };

    private bool ValidateInput(bool adding)
    {
        if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text))
        {
            MessageBox.Show("Vui lòng nhập Mã lớp và Tên lớp.", "Thiếu dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        if (adding && SchoolRepository.Classes.Any(c => c.MaLop.Equals(txtMa.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("Mã lớp đã tồn tại.", "Trùng mã",
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

        SchoolRepository.Classes.Add(ReadInput());
        BindGrid();
        btnClear_Click(sender, e);
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (!ValidateInput(false))
        {
            return;
        }

        var item = SchoolRepository.Classes.FirstOrDefault(c =>
            c.MaLop.Equals(txtMa.Text.Trim(), StringComparison.OrdinalIgnoreCase));
        if (item is null)
        {
            MessageBox.Show("Không tìm thấy lớp học để sửa.", "Không tìm thấy",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var data = ReadInput();
        item.TenLop = data.TenLop;
        item.Khoa = data.Khoa;
        item.SiSo = data.SiSo;
        item.Gvcn = data.Gvcn;
        BindGrid();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgv.CurrentRow?.DataBoundItem is not SchoolClass c)
        {
            MessageBox.Show("Hãy chọn một dòng để xóa.", "Chưa chọn dòng",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (MessageBox.Show($"Xóa lớp {c.MaLop} - {c.TenLop}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        SchoolRepository.Classes.Remove(c);
        BindGrid();
        btnClear_Click(sender, e);
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtMa.Clear();
        txtTen.Clear();
        txtKhoa.Clear();
        txtGvcn.Clear();
        numSiSo.Value = 0;
        txtMa.Focus();
    }

    private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgv.CurrentRow?.DataBoundItem is not SchoolClass c)
        {
            return;
        }

        txtMa.Text = c.MaLop;
        txtTen.Text = c.TenLop;
        txtKhoa.Text = c.Khoa;
        numSiSo.Value = c.SiSo;
        txtGvcn.Text = c.Gvcn;
    }
}
