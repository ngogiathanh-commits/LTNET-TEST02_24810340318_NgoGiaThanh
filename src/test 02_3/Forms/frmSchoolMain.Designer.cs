namespace test_02_3;

partial class frmSchoolMain
{
    private System.ComponentModel.IContainer components = null;
    private MenuStrip menuStrip;
    private ToolStripMenuItem mnuHeThong;
    private ToolStripMenuItem mnuLogout;
    private ToolStripMenuItem mnuChangePassword;
    private ToolStripMenuItem mnuExit;
    private ToolStripMenuItem mnuQuanLy;
    private ToolStripMenuItem mnuStudentList;
    private ToolStripMenuItem mnuTeacherList;
    private ToolStripMenuItem mnuClassList;
    private ToolStripMenuItem mnuCourseList;
    private ToolStripMenuItem mnuWindow;
    private ToolStripMenuItem mnuCascade;
    private ToolStripMenuItem mnuTileH;
    private ToolStripMenuItem mnuTileV;
    private ToolStripMenuItem mnuCloseAll;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel lblStaff;
    private ToolStripStatusLabel lblStatus;
    private ToolStripProgressBar progressBar;
    private ToolStripStatusLabel lblClock;
    private System.Windows.Forms.Timer clock;

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
        components = new System.ComponentModel.Container();
        menuStrip = new MenuStrip();
        mnuHeThong = new ToolStripMenuItem();
        mnuLogout = new ToolStripMenuItem();
        mnuChangePassword = new ToolStripMenuItem();
        mnuExit = new ToolStripMenuItem();
        mnuQuanLy = new ToolStripMenuItem();
        mnuStudentList = new ToolStripMenuItem();
        mnuTeacherList = new ToolStripMenuItem();
        mnuClassList = new ToolStripMenuItem();
        mnuCourseList = new ToolStripMenuItem();
        mnuWindow = new ToolStripMenuItem();
        mnuCascade = new ToolStripMenuItem();
        mnuTileH = new ToolStripMenuItem();
        mnuTileV = new ToolStripMenuItem();
        mnuCloseAll = new ToolStripMenuItem();
        statusStrip = new StatusStrip();
        lblStaff = new ToolStripStatusLabel();
        lblStatus = new ToolStripStatusLabel();
        progressBar = new ToolStripProgressBar();
        lblClock = new ToolStripStatusLabel();
        clock = new System.Windows.Forms.Timer(components);
        menuStrip.SuspendLayout();
        statusStrip.SuspendLayout();
        SuspendLayout();

        menuStrip.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuWindow });
        menuStrip.Name = "menuStrip";
        menuStrip.MdiWindowListItem = mnuWindow;
        menuStrip.Padding = new Padding(8, 4, 0, 4);

        mnuHeThong.DropDownItems.AddRange(new ToolStripItem[]
        {
            mnuLogout, mnuChangePassword, new ToolStripSeparator(), mnuExit
        });
        mnuHeThong.Name = "mnuHeThong";
        mnuHeThong.Text = "Hệ thống";

        mnuLogout.Name = "mnuLogout";
        mnuLogout.ShortcutKeys = Keys.Control | Keys.L;
        mnuLogout.Text = "Đăng xuất";
        mnuLogout.Click += mnuLogout_Click;

        mnuChangePassword.Name = "mnuChangePassword";
        mnuChangePassword.Text = "Đổi mật khẩu";
        mnuChangePassword.Click += mnuChangePassword_Click;

        mnuExit.Name = "mnuExit";
        mnuExit.Text = "Thoát";
        mnuExit.Click += mnuExit_Click;

        mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[]
        {
            mnuStudentList, mnuTeacherList, mnuClassList, mnuCourseList
        });
        mnuQuanLy.Name = "mnuQuanLy";
        mnuQuanLy.Text = "Quản lý";

        mnuStudentList.Name = "mnuStudentList";
        mnuStudentList.ShortcutKeys = Keys.Control | Keys.D1;
        mnuStudentList.Text = "Danh sách Sinh viên";
        mnuStudentList.Click += mnuStudentList_Click;

        mnuTeacherList.Name = "mnuTeacherList";
        mnuTeacherList.ShortcutKeys = Keys.Control | Keys.D2;
        mnuTeacherList.Text = "Danh sách Giảng viên";
        mnuTeacherList.Click += mnuTeacherList_Click;

        mnuClassList.Name = "mnuClassList";
        mnuClassList.ShortcutKeys = Keys.Control | Keys.D3;
        mnuClassList.Text = "Danh mục Lớp học";
        mnuClassList.Click += mnuClassList_Click;

        mnuCourseList.Name = "mnuCourseList";
        mnuCourseList.ShortcutKeys = Keys.Control | Keys.D4;
        mnuCourseList.Text = "Danh mục môn học";
        mnuCourseList.Click += mnuCourseList_Click;

        mnuWindow.DropDownItems.AddRange(new ToolStripItem[]
        {
            mnuCascade, mnuTileH, mnuTileV, new ToolStripSeparator(), mnuCloseAll
        });
        mnuWindow.Name = "mnuWindow";
        mnuWindow.Text = "Cửa sổ";

        mnuCascade.Name = "mnuCascade";
        mnuCascade.Text = "Sắp xếp Xếp tầng (Cascade)";
        mnuCascade.Click += mnuCascade_Click;

        mnuTileH.Name = "mnuTileH";
        mnuTileH.Text = "Ngang (Tile Horizontal)";
        mnuTileH.Click += mnuTileH_Click;

        mnuTileV.Name = "mnuTileV";
        mnuTileV.Text = "Dọc (Tile Vertical)";
        mnuTileV.Click += mnuTileV_Click;

        mnuCloseAll.Name = "mnuCloseAll";
        mnuCloseAll.Text = "Đóng tất cả";
        mnuCloseAll.Click += mnuCloseAll_Click;

        statusStrip.Items.AddRange(new ToolStripItem[] { lblStaff, lblStatus, progressBar, lblClock });
        statusStrip.Name = "statusStrip";
        statusStrip.SizingGrip = false;

        lblStaff.BorderSides = ToolStripStatusLabelBorderSides.Right;
        lblStaff.Name = "lblStaff";
        lblStaff.Text = "Cán bộ quản lý: ";
        lblStaff.AutoSize = true;

        lblStatus.Name = "lblStatus";
        lblStatus.Spring = true;
        lblStatus.Text = "Sẵn sàng";
        lblStatus.TextAlign = ContentAlignment.MiddleLeft;

        progressBar.Name = "progressBar";
        progressBar.Size = new Size(140, 16);
        progressBar.Style = ProgressBarStyle.Continuous;

        lblClock.BorderSides = ToolStripStatusLabelBorderSides.Left;
        lblClock.Name = "lblClock";
        lblClock.Text = "00:00:00";

        clock.Interval = 1000;
        clock.Tick += clock_Tick;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1200, 720);
        Controls.Add(statusStrip);
        Controls.Add(menuStrip);
        Font = new Font("Segoe UI", 9F);
        IsMdiContainer = true;
        MainMenuStrip = menuStrip;
        MinimumSize = new Size(980, 620);
        Name = "frmSchoolMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Hệ thống MDI quản lý trường học & đào tạo";
        WindowState = FormWindowState.Maximized;
        Load += frmSchoolMain_Load;
        MdiChildActivate += frmSchoolMain_MdiChildActivate;
        FormClosing += frmSchoolMain_FormClosing;

        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
