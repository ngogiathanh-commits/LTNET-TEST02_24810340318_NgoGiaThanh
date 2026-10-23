using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_02_5
{
    public partial class frmIoTMonitor : Form
    {
        private CancellationTokenSource cts;
        private BindingList<IoTLogModel> logList = new BindingList<IoTLogModel>();
        private int cycleCount = 0;

        public frmIoTMonitor()
        {
            InitializeComponent();
        }

        private void frmIoTMonitor_Load(object sender, EventArgs e)
        {
            InitControls();
            InitDataGridView();
        }

        private void InitControls()
        {
            btnStop.Enabled = false;
            lblTemperature.Text = "--.- °C";
            lblTemperature.ForeColor = Color.Black;

            lblStatus.Text = "Trạng thái: Chưa kết nối";
            lblCycleCount.Text = "Số chu kỳ tín hiệu: 0";
        }

        private void InitDataGridView()
        {
            dgvLogs.DataSource = logList;
            dgvLogs.AutoGenerateColumns = false;
            dgvLogs.Columns.Clear();

            dgvLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Timestamp",
                HeaderText = "Thời Gian Real-Time",
                Width = 180
            });

            var colTemp = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Temperature",
                HeaderText = "Nhiệt Độ (°C)",
                Width = 130
            };
            colTemp.DefaultCellStyle.Format = "N1";
            dgvLogs.Columns.Add(colTemp);

            dgvLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Cảnh Báo Hệ Thống",
                Width = 160
            });

            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.ReadOnly = true;
        }

        // 1. Nút [Bắt đầu Giám sát]
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            lblStatus.Text = "Trạng thái: Đang kết nối & Giám sát real-time...";
            cts = new CancellationTokenSource();

            // Khởi chạy vòng lặp ngầm trên Thread phụ qua Task.Run
            Task.Run(async () =>
            {
                Random rand = new Random();

                while (!cts.Token.IsCancellationRequested)
                {
                    // Sinh nhiệt độ ngẫu nhiên từ 30.0°C đến 42.0°C
                    double randomTemp = 30.0 + (rand.NextDouble() * 12.0);

                    // Gọi hàm cập nhật UI tuân thủ Thread Safety
                    UpdateUIRealTime(randomTemp);

                    try
                    {
                        // Tạm dừng 2 giây giữa các chu kỳ
                        await Task.Delay(2000, cts.Token);
                    }
                    catch (TaskCanceledException)
                    {
                        break;
                    }
                }
            });
        }

        // 2. Kỹ thuật THREAD SAFETY: Cập nhật giao diện từ Thread phụ
        private void UpdateUIRealTime(double temp)
        {
            // Kiểm tra quy tắc Thread Safety bằng InvokeRequired
            if (this.InvokeRequired)
            {
                // Chuyển ngữ cảnh xử lý từ Thread phụ về UI Thread
                this.Invoke(new Action(() => UpdateUIRealTime(temp)));
                return;
            }

            // --- ĐÃ VỀ LẠI UI THREAD AN TOÀN (KHÔNG BỊ LỖI CROSS-THREAD) ---
            cycleCount++;

            // a. Hiển thị nhiệt độ và đổi màu cảnh báo
            lblTemperature.Text = $"{temp:F1} °C";
            if (temp > 37.0)
            {
                lblTemperature.ForeColor = Color.Red; // Ngưỡng sốt/cảnh báo
            }
            else
            {
                lblTemperature.ForeColor = Color.Green; // Bình thường
            }

            // b. Thêm dòng nhật ký mới lên đầu danh sách DataGridView
            string statusText = temp > 37.0 ? "CẢNH BÁO CAO" : "Bình thường";
            logList.Insert(0, new IoTLogModel(DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy"), temp, statusText));

            // c. Cập nhật StatusStrip
            lblCycleCount.Text = $"Số chu kỳ tín hiệu: {cycleCount}";
        }

        // 3. Nút [Dừng Giám sát]
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopMonitoring();
        }

        private void StopMonitoring()
        {
            if (cts != null && !cts.IsCancellationRequested)
            {
                cts.Cancel();
            }

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblStatus.Text = "Trạng thái: Tạm dừng giám sát";
        }

        private void frmIoTMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopMonitoring();
        }
    }
}