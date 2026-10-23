using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace test_02_1
{
    public partial class frmBookingManager : Form
    {
        private BindingList<BookingModel> bookingList = new BindingList<BookingModel>();
        private BindingSource bookingSource = new BindingSource();
        private int autoIdCounter = 1;

        public frmBookingManager()
        {
            InitializeComponent();
        }

        private void frmBookingManager_Load(object sender, EventArgs e)
        {
            InitDataGridView();
            InitControls();

            // Khởi tạo một số dữ liệu mẫu
            bookingList.Add(new BookingModel("BK001", "Nguyễn Văn An", "012345678901", "Deluxe", DateTime.Today, 3, 1200000));
            bookingList.Add(new BookingModel("BK002", "Trần Thị Bích", "098765432109", "VIP", DateTime.Today.AddDays(1), 2, 2500000));
            autoIdCounter = 3;

            // Gán dữ liệu qua BindingSource
            bookingSource.DataSource = bookingList;
            dgvBookings.DataSource = bookingSource;

            GenerateNewBookingId();
        }

        // 1. Cấu hình DataGridView bằng code (AutoGenerateColumns = false)
        private void InitDataGridView()
        {
            dgvBookings.AutoGenerateColumns = false;
            dgvBookings.Columns.Clear();

            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "BookingId", HeaderText = "Mã Đặt", Width = 90 });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CustomerName", HeaderText = "Tên Khách", Width = 150 });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdentityCard", HeaderText = "CCCD/CMND", Width = 120 });
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "RoomType", HeaderText = "Loại Phòng", Width = 110 });

            var colCheckIn = new DataGridViewTextBoxColumn { DataPropertyName = "CheckInDate", HeaderText = "Ngày Nhận", Width = 110 };
            colCheckIn.DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvBookings.Columns.Add(colCheckIn);

            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DaysCount", HeaderText = "Số Đêm", Width = 80 });

            var colPrice = new DataGridViewTextBoxColumn { DataPropertyName = "PricePerNight", HeaderText = "Giá/Đêm (VNĐ)", Width = 130 };
            colPrice.DefaultCellStyle.Format = "N0";
            dgvBookings.Columns.Add(colPrice);

            // Cấu hình thuộc tính giao diện Grid
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.ReadOnly = true;
            dgvBookings.MultiSelect = false;
        }

        private void InitControls()
        {
            cboRoomType.Items.Clear();
            cboRoomType.Items.AddRange(new string[] { "Standard", "Deluxe", "VIP" });
            cboRoomType.SelectedIndex = 0;

            numDays.Minimum = 1;
            numDays.Maximum = 365;
            numDays.Value = 1;

            dtpCheckIn.Value = DateTime.Today;
            txtPricePerNight.Text = "500000";
        }

        // Tự động tạo mã đặt phòng dạng BK001, BK002...
        private void GenerateNewBookingId()
        {
            txtBookingId.Text = $"BK{autoIdCounter:D3}";
            txtBookingId.ReadOnly = true;
        }

        // 2. Kiểm tra hợp lệ dữ liệu bằng ErrorProvider
        private bool ValidateInput()
        {
            epError.Clear();
            bool isValid = true;

            // Tên khách hàng không được để trống
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                epError.SetError(txtCustomerName, "Tên khách hàng không được để trống!");
                isValid = false;
            }

            // CCCD phải đủ 9 hoặc 12 chữ số
            string idCard = txtIdentityCard.Text.Trim();
            if (string.IsNullOrWhiteSpace(idCard) || !(idCard.Length == 9 || idCard.Length == 12) || !idCard.All(char.IsDigit))
            {
                epError.SetError(txtIdentityCard, "CCCD/CMND phải là dãy số gồm đúng 9 hoặc 12 chữ số!");
                isValid = false;
            }

            // Giá phòng phải lớn hơn 0
            if (!decimal.TryParse(txtPricePerNight.Text.Trim(), out decimal price) || price <= 0)
            {
                epError.SetError(txtPricePerNight, "Giá phòng phải là số dương lớn hơn 0!");
                isValid = false;
            }

            return isValid;
        }

        // Nút Thêm đặt phòng
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            BookingModel booking = new BookingModel
            {
                BookingId = txtBookingId.Text.Trim(),
                CustomerName = txtCustomerName.Text.Trim(),
                IdentityCard = txtIdentityCard.Text.Trim(),
                RoomType = cboRoomType.SelectedItem.ToString(),
                CheckInDate = dtpCheckIn.Value.Date,
                DaysCount = (int)numDays.Value,
                PricePerNight = decimal.Parse(txtPricePerNight.Text.Trim())
            };

            bookingList.Add(booking);
            autoIdCounter++;
            ClearInput();
            MessageBox.Show("Thêm mới đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút Cập nhật đặt phòng
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bookingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin đặt phòng cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            BookingModel current = (BookingModel)bookingSource.Current;
            current.CustomerName = txtCustomerName.Text.Trim();
            current.IdentityCard = txtIdentityCard.Text.Trim();
            current.RoomType = cboRoomType.SelectedItem.ToString();
            current.CheckInDate = dtpCheckIn.Value.Date;
            current.DaysCount = (int)numDays.Value;
            current.PricePerNight = decimal.Parse(txtPricePerNight.Text.Trim());

            bookingSource.ResetCurrentItem(); // Cập nhật lại Grid
            MessageBox.Show("Cập nhật thông tin đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút Xóa đặt phòng
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bookingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn đặt phòng cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BookingModel current = (BookingModel)bookingSource.Current;

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa đặt phòng [{current.BookingId}] của khách hàng [{current.CustomerName}] không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                bookingSource.RemoveCurrent();
                ClearInput();
                MessageBox.Show("Đã xóa thông tin đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Nút Làm mới
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            GenerateNewBookingId();
            txtCustomerName.Clear();
            txtIdentityCard.Clear();
            cboRoomType.SelectedIndex = 0;
            dtpCheckIn.Value = DateTime.Today;
            numDays.Value = 1;
            txtPricePerNight.Text = "500000";
            epError.Clear();
            txtCustomerName.Focus();
        }

        // 3. Đồng bộ 2 chiều: Khi chọn một dòng trên Grid -> Đẩy lên các ô nhập liệu
        private void dgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && bookingSource.Current != null)
            {
                BookingModel current = (BookingModel)bookingSource.Current;
                txtBookingId.Text = current.BookingId;
                txtCustomerName.Text = current.CustomerName;
                txtIdentityCard.Text = current.IdentityCard;
                cboRoomType.SelectedItem = current.RoomType;
                dtpCheckIn.Value = current.CheckInDate;
                numDays.Value = current.DaysCount;
                txtPricePerNight.Text = current.PricePerNight.ToString("0.##");
            }
        }
    }
}
