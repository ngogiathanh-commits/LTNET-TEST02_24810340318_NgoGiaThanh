namespace test_02_3;

public partial class frmSchoolMain : Form
{
    public frmSchoolMain()
    {
        InitializeComponent();
    }

    private void frmSchoolMain_Load(object sender, EventArgs e)
    {
        foreach (Control control in Controls)
        {
            if (control is MdiClient client)
            {
                client.BackColor = Color.FromArgb(232, 239, 247);
            }
        }

        lblStaff.Text = $"Cán bộ quản lý: {AppSession.StaffName}";
        lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        clock.Start();
        ShowStatus("Sẵn sàng. Chọn chức năng từ thực đơn Quản lý.");
    }

    private void clock_Tick(object sender, EventArgs e)
    {
        lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    }

    private void frmSchoolMain_MdiChildActivate(object sender, EventArgs e)
    {
        ShowStatus(ActiveMdiChild is null
            ? "Không có cửa sổ con đang mở."
            : $"Cửa sổ đang làm việc: {ActiveMdiChild.Text}");
    }

    /// <summary>
    /// Mở Form con MDI: nếu đã có trong MdiChildren thì Activate(), ngược lại tạo instance mới.
    /// </summary>
    public void OpenChild<T>() where T : Form, new()
    {
        foreach (Form child in MdiChildren)
        {
            if (child is T existing)
            {
                if (existing.WindowState == FormWindowState.Minimized)
                {
                    existing.WindowState = FormWindowState.Normal;
                }

                existing.Activate();
                ShowProgress($"Đưa lên trước: {existing.Text}");
                return;
            }
        }

        var form = new T { MdiParent = this };
        form.Show();
        ShowProgress($"Đã mở: {form.Text}");
    }

    public void ShowStatus(string message)
    {
        lblStatus.Text = message;
        lblStaff.Text = $"Cán bộ quản lý: {AppSession.StaffName}";
    }

    private void ShowProgress(string message)
    {
        ShowStatus(message);
        progressBar.Value = 0;
        progressBar.Visible = true;

        var timer = new System.Windows.Forms.Timer { Interval = 30 };
        timer.Tick += (_, _) =>
        {
            if (progressBar.Value >= 100)
            {
                timer.Stop();
                timer.Dispose();
                progressBar.Value = 0;
                return;
            }

            progressBar.Value += 10;
        };
        timer.Start();
    }

    private void mnuStudentList_Click(object sender, EventArgs e) => OpenChild<frmStudentList>();
    private void mnuTeacherList_Click(object sender, EventArgs e) => OpenChild<frmTeacherList>();
    private void mnuClassList_Click(object sender, EventArgs e) => OpenChild<frmClassList>();
    private void mnuCourseList_Click(object sender, EventArgs e) => OpenChild<frmCourseList>();

    private void mnuCascade_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.Cascade);
        ShowStatus("Đã sắp xếp cửa sổ: Xếp tầng (Cascade).");
    }

    private void mnuTileH_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.TileHorizontal);
        ShowStatus("Đã sắp xếp cửa sổ: Ngang (Tile Horizontal).");
    }

    private void mnuTileV_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.TileVertical);
        ShowStatus("Đã sắp xếp cửa sổ: Dọc (Tile Vertical).");
    }

    private void mnuCloseAll_Click(object sender, EventArgs e)
    {
        foreach (Form child in MdiChildren.ToArray())
        {
            child.Close();
        }

        ShowStatus("Đã đóng tất cả cửa sổ con.");
    }

    private void mnuChangePassword_Click(object sender, EventArgs e)
    {
        using var dlg = new frmChangePassword();
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            ShowStatus("Đã đổi mật khẩu thành công.");
        }
    }

    private void mnuLogout_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Đăng xuất khỏi hệ thống?", "Đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        mnuCloseAll_Click(sender, e);
        AppSession.RequestRelogin = true;
        Close();
    }

    private void mnuExit_Click(object sender, EventArgs e) => Close();

    private void frmSchoolMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        clock.Stop();
        if (AppSession.RequestRelogin)
        {
            return;
        }

        if (e.CloseReason == CloseReason.UserClosing)
        {
            var confirm = MessageBox.Show("Thoát ứng dụng?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                e.Cancel = true;
                clock.Start();
            }
        }
    }
}
