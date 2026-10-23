namespace test_02_3;

partial class frmChangePassword
{
    private System.ComponentModel.IContainer components = null;
    private Label lblOld;
    private Label lblNew;
    private Label lblConfirm;
    private TextBox txtOld;
    private TextBox txtNew;
    private TextBox txtConfirm;
    private Button btnSave;
    private Button btnCancel;

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
        lblOld = new Label();
        txtOld = new TextBox();
        lblNew = new Label();
        txtNew = new TextBox();
        lblConfirm = new Label();
        txtConfirm = new TextBox();
        btnSave = new Button();
        btnCancel = new Button();
        SuspendLayout();

        lblOld.AutoSize = true;
        lblOld.Location = new Point(24, 24);
        lblOld.Text = "Mật khẩu hiện tại";
        txtOld.Location = new Point(24, 46);
        txtOld.Size = new Size(320, 27);
        txtOld.UseSystemPasswordChar = true;

        lblNew.AutoSize = true;
        lblNew.Location = new Point(24, 86);
        lblNew.Text = "Mật khẩu mới";
        txtNew.Location = new Point(24, 108);
        txtNew.Size = new Size(320, 27);
        txtNew.UseSystemPasswordChar = true;

        lblConfirm.AutoSize = true;
        lblConfirm.Location = new Point(24, 148);
        lblConfirm.Text = "Xác nhận mật khẩu mới";
        txtConfirm.Location = new Point(24, 170);
        txtConfirm.Size = new Size(320, 27);
        txtConfirm.UseSystemPasswordChar = true;

        btnSave.Location = new Point(24, 220);
        btnSave.Size = new Size(150, 32);
        btnSave.Text = "Lưu";
        btnSave.BackColor = Color.FromArgb(15, 76, 129);
        btnSave.ForeColor = Color.White;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Click += btnSave_Click;

        btnCancel.Location = new Point(194, 220);
        btnCancel.Size = new Size(150, 32);
        btnCancel.Text = "Hủy";
        btnCancel.Click += btnCancel_Click;

        AcceptButton = btnSave;
        CancelButton = btnCancel;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(370, 280);
        Controls.AddRange(new Control[] { lblOld, txtOld, lblNew, txtNew, lblConfirm, txtConfirm, btnSave, btnCancel });
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "frmChangePassword";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Đổi mật khẩu";
        ResumeLayout(false);
        PerformLayout();
    }
}
