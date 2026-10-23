using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_02_4
{
    public partial class frmWarehouseAnalytics : Form
    {
        // Quản lý ngắt tiến trình bất đồng bộ
        private CancellationTokenSource cts;

        public frmWarehouseAnalytics()
        {
            InitializeComponent();
        }

        private void frmWarehouseAnalytics_Load(object sender, EventArgs e)
        {
            InitControls();
            InitDataGridView();
        }

        private void InitControls()
        {
            cboWarehouse.Items.AddRange(new string[] {
                "Kho Tổng - Hà Nội",
                "Kho Miền Trung - Đà Nẵng",
                "Kho Miền Nam - TP.HCM",
                "Kho Sắp Sửa Chữa - Hải Phòng"
            });
            cboWarehouse.SelectedIndex = 0;

            dtpFromDate.Value = DateTime.Today.AddMonths(-1);
            dtpToDate.Value = DateTime.Today;

            btnCancel.Enabled = false; // Mặc định khóa nút Hủy khi chưa chạy tác vụ
            pgbStatus.Value = 0;
            lblPercent.Text = "0%";
        }

        private void InitDataGridView()
        {
            dgvReportData.AutoGenerateColumns = false;
            dgvReportData.Columns.Clear();

            dgvReportData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ItemCode", HeaderText = "Mã VT", Width = 100 });
            dgvReportData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ItemName", HeaderText = "Tên Vật Tư / Sản Phẩm", Width = 220 });
            dgvReportData.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Category", HeaderText = "Danh Mục", Width = 140 });

            var colQty = new DataGridViewTextBoxColumn { DataPropertyName = "StockQuantity", HeaderText = "Tồn Kho", Width = 90 };
            colQty.DefaultCellStyle.Format = "N0";
            dgvReportData.Columns.Add(colQty);

            var colPrice = new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Đơn Giá (VNĐ)", Width = 130 };
            colPrice.DefaultCellStyle.Format = "N0";
            dgvReportData.Columns.Add(colPrice);

            var colTotal = new DataGridViewTextBoxColumn { DataPropertyName = "TotalValue", HeaderText = "Giá Trị Tồn (VNĐ)", Width = 150 };
            colTotal.DefaultCellStyle.Format = "N0";
            dgvReportData.Columns.Add(colTotal);

            dgvReportData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportData.ReadOnly = true;
        }

        // 1. Tác vụ quét & tính toán dữ liệu kho dưới Background Thread
        private List<InventoryReportModel> FetchWarehouseData(CancellationToken token, IProgress<int> progress)
        {
            var resultList = new List<InventoryReportModel>();
            int totalSteps = 100;

            for (int i = 1; i <= totalSteps; i++)
            {
                // Kiểm tra xem người dùng có bấm "Hủy Tác Vụ" hay không
                if (token.IsCancellationRequested)
                {
                    return null;
                }

                // Giả lập độ trễ xử lý (100 bước x 45ms = ~4.5 giây)
                Thread.Sleep(45);

                resultList.Add(new InventoryReportModel
                {
                    ItemCode = $"VT{i:D4}",
                    ItemName = $"Linh kiện vật tư cao cấp #{i}",
                    Category = (i % 2 == 0) ? "Cơ khí chế tạo" : "Thiết bị điện tử",
                    StockQuantity = i * 15,
                    UnitPrice = 120000 + (i * 2500),
                    TotalValue = (i * 15) * (120000 + (i * 2500))
                });

                // Báo cáo phần trăm hoàn thành về UI Thread
                int percent = (i * 100) / totalSteps;
                progress?.Report(percent);
            }

            return resultList;
        }

        // 2. Nút [Thống Kê Kho] (Async / Await)
        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            btnAnalyze.Enabled = false;
            btnCancel.Enabled = true;
            dgvReportData.DataSource = null;

            pgbStatus.Value = 0;
            lblPercent.Text = "0%";

            cts = new CancellationTokenSource();

            IProgress<int> progress = new Progress<int>(percent =>
            {
                pgbStatus.Value = percent;
                lblPercent.Text = $"{percent}%";
            });

            try
            {
                // Chạy hàm ngầm (không cần truyền cts.Token vào tham số thứ 2 của Task.Run)
                List<InventoryReportModel> reportData = await Task.Run(() => FetchWarehouseData(cts.Token, progress));

                // Kiểm tra nếu kết quả trả về null hoặc đã bị hủy
                if (reportData == null || cts.Token.IsCancellationRequested)
                {
                    pgbStatus.Value = 0;
                    lblPercent.Text = "0%";
                    MessageBox.Show("Đã hủy tác vụ thống kê kho hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgvReportData.DataSource = reportData;
                MessageBox.Show($"Tổng hợp dữ liệu thành công! Tìm thấy {reportData.Count} bản ghi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xảy ra lỗi trong quá trình xử lý: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAnalyze.Enabled = true;
                btnCancel.Enabled = false;
                cts?.Dispose();
                cts = null;
            }
        }

        // 3. Nút [Hủy Tác Vụ] (Cancellation)
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cts != null && !cts.IsCancellationRequested)
            {
                cts.Cancel(); // Gửi tín hiệu hủy tiến trình ngầm
            }
        }
    }
}