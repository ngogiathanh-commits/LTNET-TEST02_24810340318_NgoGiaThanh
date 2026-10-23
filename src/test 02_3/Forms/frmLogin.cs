namespace test_02_3;

public partial class frmLogin : Form
{
    public frmLogin()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        var user = txtUser.Text.Trim();
        var pass = txtPass.Text;

        if (user.Equals(AppSession.Username, StringComparison.OrdinalIgnoreCase) && pass == AppSession.Password)
        {
            AppSession.StaffName = user.Equals("admin", StringComparison.OrdinalIgnoreCase)
                ? "Nguyễn Văn Quản Trị"
                : user;
            DialogResult = DialogResult.OK;
            Close();
            return;
        }

        MessageBox.Show("Sai tài khoản hoặc mật khẩu.\nTài khoản mẫu: admin / 123", "Đăng nhập thất bại",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtPass.SelectAll();
        txtPass.Focus();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
