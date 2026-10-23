namespace test_02_3;

partial class frmLogin
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Label lblUser;
    private Label lblPass;
    private TextBox txtUser;
    private TextBox txtPass;
    private Button btnLogin;
    private Button btnCancel;
    private Panel pnlCard;

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
        lblTitle = new Label();
        pnlCard = new Panel();
        lblUser = new Label();
        txtUser = new TextBox();
        lblPass = new Label();
        txtPass = new TextBox();
        btnLogin = new Button();
        btnCancel = new Button();
        pnlCard.SuspendLayout();
        SuspendLayout();

        lblTitle.Dock = DockStyle.Top;
        lblTitle.Font = new Font("Segoe UI Semibold", 14F);
        lblTitle.ForeColor = Color.White;
        lblTitle.BackColor = Color.FromArgb(15, 76, 129);
        lblTitle.Height = 64;
        lblTitle.Text = "Đăng nhập hệ thống trường học";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;

        pnlCard.Location = new Point(40, 90);
        pnlCard.Size = new Size(360, 180);
        pnlCard.Controls.Add(lblUser);
        pnlCard.Controls.Add(txtUser);
        pnlCard.Controls.Add(lblPass);
        pnlCard.Controls.Add(txtPass);
        pnlCard.Controls.Add(btnLogin);
        pnlCard.Controls.Add(btnCancel);

        lblUser.AutoSize = true;
        lblUser.Location = new Point(12, 18);
        lblUser.Text = "Tài khoản";

        txtUser.Location = new Point(12, 40);
        txtUser.Size = new Size(336, 27);
        txtUser.Text = "admin";

        lblPass.AutoSize = true;
        lblPass.Location = new Point(12, 78);
        lblPass.Text = "Mật khẩu";

        txtPass.Location = new Point(12, 100);
        txtPass.Size = new Size(336, 27);
        txtPass.UseSystemPasswordChar = true;
        txtPass.Text = "123";

        btnLogin.Location = new Point(12, 140);
        btnLogin.Size = new Size(160, 32);
        btnLogin.Text = "Đăng nhập";
        btnLogin.BackColor = Color.FromArgb(15, 76, 129);
        btnLogin.ForeColor = Color.White;
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Click += btnLogin_Click;

        btnCancel.Location = new Point(188, 140);
        btnCancel.Size = new Size(160, 32);
        btnCancel.Text = "Thoát";
        btnCancel.Click += btnCancel_Click;

        AcceptButton = btnLogin;
        CancelButton = btnCancel;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 300);
        Controls.Add(pnlCard);
        Controls.Add(lblTitle);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "frmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Đăng nhập";
        pnlCard.ResumeLayout(false);
        pnlCard.PerformLayout();
        ResumeLayout(false);
    }
}
