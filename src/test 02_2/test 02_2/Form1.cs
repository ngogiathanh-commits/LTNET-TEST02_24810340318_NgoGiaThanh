using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using test_02_2;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace test_02_2
{
    public partial class frmEmployeeManager : Form
    {
        private BindingList<EmployeeModel> employeeList = new BindingList<EmployeeModel>();
        private BindingSource employeeSource = new BindingSource();
        private string currentAvatarPath = "";

        public frmEmployeeManager()
        {
            InitializeComponent();
        }

        private void frmEmployeeManager_Load(object sender, EventArgs e)
        {
            InitDataGridView();
            InitComboBox();

            
            employeeList.Add(new EmployeeModel("NV001", "Nguyễn Văn An", "Trưởng phòng", 25000000, ""));
            employeeList.Add(new EmployeeModel("NV002", "Trần Thị Bích", "Chuyên viên", 15000000, ""));
            employeeList.Add(new EmployeeModel("NV003", "Lê Hoàng Nam", "Lập trình viên", 18000000, ""));

            employeeSource.DataSource = employeeList;
            dgvEmployees.DataSource = employeeSource;

            
            timerClock.Interval = 1000;
            timerClock.Start();

            UpdateStatusStrip();
        }

        
        private void InitDataGridView()
        {
            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.Columns.Clear();

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EmployeeId", HeaderText = "Mã NV", Width = 90 });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "Họ và Tên", Width = 160 });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Position", HeaderText = "Chức Vụ", Width = 130 });

            var colSalary = new DataGridViewTextBoxColumn { DataPropertyName = "Salary", HeaderText = "Lương (VNĐ)", Width = 130 };
            colSalary.DefaultCellStyle.Format = "N0";
            dgvEmployees.Columns.Add(colSalary);

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "AvatarPath", HeaderText = "Đường Dẫn Ảnh", Width = 200 });

            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.ReadOnly = true;
            dgvEmployees.MultiSelect = false;
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void InitComboBox()
        {
            cboPosition.Items.Clear();
            cboPosition.Items.AddRange(new string[] { "Giám đốc", "Trưởng phòng", "Chuyên viên", "Lập trình viên", "Kế toán", "Nhân viên" });
            cboPosition.SelectedIndex = 2;
        }

        
        private void UpdateStatusStrip()
        {
            int totalEmployees = employeeList.Count;
            decimal totalSalary = employeeList.Sum(emp => emp.Salary);

            lblTotalEmployees.Text = $"Tổng số nhân viên: {totalEmployees}";
            lblTotalSalary.Text = $"Tổng quỹ lương: {totalSalary:N0} VNĐ";
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        
        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "File hình ảnh (*.jpg; *.png)|*.jpg;*.png|Tất cả các file (*.*)|*.*";
                ofd.Title = "Chọn ảnh chân dung nhân viên";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentAvatarPath = ofd.FileName;
                    LoadAvatarToPictureBox(currentAvatarPath);
                }
            }
        }

        private void LoadAvatarToPictureBox(string path)
        {
            if (picAvatar.Image != null)
            {
                picAvatar.Image.Dispose();
                picAvatar.Image = null;
            }

            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                try
                {
                    using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        picAvatar.Image = Image.FromStream(stream);
                    }
                }
                catch
                {
                    picAvatar.Image = null;
                }
            }
            else
            {
                picAvatar.Image = null;
            }
        }

        
        private bool ValidateInput(bool isUpdate = false)
        {
            epError.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtEmployeeId.Text))
            {
                epError.SetError(txtEmployeeId, "Mã nhân viên không được để trống!");
                isValid = false;
            }
            else if (!isUpdate && employeeList.Any(emp => emp.EmployeeId.Equals(txtEmployeeId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                epError.SetError(txtEmployeeId, "Mã nhân viên đã tồn tại!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                epError.SetError(txtFullName, "Họ và tên không được để trống!");
                isValid = false;
            }

            if (!decimal.TryParse(txtSalary.Text.Trim(), out decimal salary) || salary < 0)
            {
                epError.SetError(txtSalary, "Lương phải là số không âm!");
                isValid = false;
            }

            return isValid;
        }

      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(isUpdate: false)) return;

            EmployeeModel emp = new EmployeeModel(
                txtEmployeeId.Text.Trim(),
                txtFullName.Text.Trim(),
                cboPosition.SelectedItem.ToString(),
                decimal.Parse(txtSalary.Text.Trim()),
                currentAvatarPath
            );

            employeeList.Add(emp);
            UpdateStatusStrip();
            ClearInput();
            MessageBox.Show("Thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (employeeSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(isUpdate: true)) return;

            EmployeeModel current = (EmployeeModel)employeeSource.Current;
            current.FullName = txtFullName.Text.Trim();
            current.Position = cboPosition.SelectedItem.ToString();
            current.Salary = decimal.Parse(txtSalary.Text.Trim());
            current.AvatarPath = currentAvatarPath;

            employeeSource.ResetCurrentItem();
            UpdateStatusStrip();
            ClearInput();
            MessageBox.Show("Cập nhật hồ sơ nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (employeeSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EmployeeModel current = (EmployeeModel)employeeSource.Current;
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên [{current.FullName}] (Mã: {current.EmployeeId}) không?",
                                              "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                employeeSource.RemoveCurrent();
                UpdateStatusStrip();
                ClearInput();
                MessageBox.Show("Xóa hồ sơ nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && employeeSource.Current != null)
            {
                EmployeeModel current = (EmployeeModel)employeeSource.Current;
                txtEmployeeId.Text = current.EmployeeId;
                txtFullName.Text = current.FullName;
                cboPosition.SelectedItem = current.Position;
                txtSalary.Text = current.Salary.ToString("0.##");
                currentAvatarPath = current.AvatarPath;

                LoadAvatarToPictureBox(currentAvatarPath);
                txtEmployeeId.ReadOnly = true;
            }
        }

       
        private void mnuSaveCsv_Click(object sender, EventArgs e)
        {
            if (employeeList.Count == 0)
            {
                MessageBox.Show("Danh sách nhân sự trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "File CSV (*.csv)|*.csv";
                sfd.Title = "Xuất danh sách nhân sự ra file CSV";
                sfd.FileName = $"DanhSachNhanSu_{DateTime.Now:yyyyMMdd}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {
                            sw.WriteLine("EmployeeId,FullName,Position,Salary,AvatarPath");
                            foreach (var emp in employeeList)
                            {
                                sw.WriteLine($"\"{emp.EmployeeId}\",\"{emp.FullName}\",\"{emp.Position}\",{emp.Salary},\"{emp.AvatarPath}\"");
                            }
                        }
                        MessageBox.Show("Lưu dữ liệu ra file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void mnuOpenCsv_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "File CSV (*.csv)|*.csv";
                ofd.Title = "Mở file CSV danh sách nhân sự";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);
                        if (lines.Length <= 1) return;

                        employeeList.Clear();
                        for (int i = 1; i < lines.Length; i++)
                        {
                            string line = lines[i].Trim();
                            if (string.IsNullOrEmpty(line)) continue;

                            string[] parts = line.Split(',');
                            if (parts.Length >= 4)
                            {
                                string id = parts[0].Trim('"');
                                string name = parts[1].Trim('"');
                                string pos = parts[2].Trim('"');
                                decimal.TryParse(parts[3].Trim('"'), out decimal salary);
                                string path = parts.Length >= 5 ? parts[4].Trim('"') : "";

                                employeeList.Add(new EmployeeModel(id, name, pos, salary, path));
                            }
                        }

                        UpdateStatusStrip();
                        ClearInput();
                        MessageBox.Show("Đọc dữ liệu từ file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Tìm kiếm nhanh
        private void mnuSearch_Click(object sender, EventArgs e)
        {
            string keyword = Microsoft.VisualBasic.Interaction.InputBox("Nhập Mã NV hoặc Họ Tên cần tìm:", "Tìm kiếm nhân sự", "");
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.ToLower();
                var filtered = employeeList.Where(emp => emp.EmployeeId.ToLower().Contains(keyword) || emp.FullName.ToLower().Contains(keyword)).ToList();
                dgvEmployees.DataSource = new BindingList<EmployeeModel>(filtered);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            dgvEmployees.DataSource = employeeSource;
        }

        private void ClearInput()
        {
            txtEmployeeId.Clear();
            txtFullName.Clear();
            if (cboPosition.Items.Count > 0) cboPosition.SelectedIndex = 0;
            txtSalary.Clear();
            currentAvatarPath = "";
            LoadAvatarToPictureBox(null);
            txtEmployeeId.ReadOnly = false;
            epError.Clear();
            txtEmployeeId.Focus();
        }
    }
}
