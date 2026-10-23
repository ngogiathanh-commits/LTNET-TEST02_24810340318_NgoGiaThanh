namespace test_02_3;

public partial class frmChangePassword : Form
{
    public frmChangePassword()
    {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (txtOld.Text != AppSession.Password)
        {
            MessageBox.Show("Mật khẩu hiện tại không đúng.", "Đổi mật khẩu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtOld.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(txtNew.Text) || txtNew.Text.Length < 3)
        {
            MessageBox.Show("Mật khẩu mới phải có ít nhất 3 ký tự.", "Đổi mật khẩu",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNew.Focus();
            return;
        }

        if (txtNew.Text != txtConfirm.Text)
        {
            MessageBox.Show("Xác nhận mật khẩu không khớp.", "Đổi mật khẩu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtConfirm.Focus();
            return;
        }

        AppSession.Password = txtNew.Text;
        MessageBox.Show("Đổi mật khẩu thành công.", "Đổi mật khẩu",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
