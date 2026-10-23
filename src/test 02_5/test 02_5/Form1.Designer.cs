using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace test_02_5
{
    partial class frmIoTMonitor
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpControl = new GroupBox();
            btnStop = new Button();
            btnStart = new Button();
            grpMonitor = new GroupBox();
            lblTemperature = new Label();
            lblTempTitle = new Label();
            dgvLogs = new DataGridView();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblCycleCount = new ToolStripStatusLabel();
            grpControl.SuspendLayout();
            grpMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grpControl
            // 
            grpControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpControl.Controls.Add(btnStop);
            grpControl.Controls.Add(btnStart);
            grpControl.Location = new Point(12, 12);
            grpControl.Name = "grpControl";
            grpControl.Size = new Size(758, 75);
            grpControl.TabIndex = 0;
            grpControl.TabStop = false;
            grpControl.Text = "Bộ điều khiển giám sát";
            // 
            // btnStop
            // 
            btnStop.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            btnStop.ForeColor = Color.DarkRed;
            btnStop.Location = new Point(200, 25);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(160, 38);
            btnStop.TabIndex = 1;
            btnStop.Text = "Dừng Giám Sát";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            btnStart.ForeColor = Color.DarkGreen;
            btnStart.Location = new Point(20, 25);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(160, 38);
            btnStart.TabIndex = 0;
            btnStart.Text = "Bắt Đầu Giám Sát";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // grpMonitor
            // 
            grpMonitor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpMonitor.Controls.Add(lblTemperature);
            grpMonitor.Controls.Add(lblTempTitle);
            grpMonitor.Location = new Point(12, 95);
            grpMonitor.Name = "grpMonitor";
            grpMonitor.Size = new Size(758, 110);
            grpMonitor.TabIndex = 1;
            grpMonitor.TabStop = false;
            grpMonitor.Text = "Hiển thị tín hiệu Cảm biến Real-Time";
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new System.Drawing.Font("Segoe UI", 28F, FontStyle.Bold);
            lblTemperature.Location = new Point(280, 25);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(181, 62);
            lblTemperature.TabIndex = 1;
            lblTemperature.Text = "36.5 °C";
            // 
            // lblTempTitle
            // 
            lblTempTitle.AutoSize = true;
            lblTempTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblTempTitle.Location = new Point(20, 45);
            lblTempTitle.Name = "lblTempTitle";
            lblTempTitle.Size = new Size(239, 25);
            lblTempTitle.TabIndex = 0;
            lblTempTitle.Text = "Nhiệt độ cảm biến hiện tại:";
            // 
            // dgvLogs
            // 
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.AllowUserToDeleteRows = false;
            dgvLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(12, 215);
            dgvLogs.MultiSelect = false;
            dgvLogs.Name = "dgvLogs";
            dgvLogs.ReadOnly = true;
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.Size = new Size(758, 225);
            dgvLogs.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblCycleCount });
            statusStrip1.Location = new Point(0, 447);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(782, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(618, 20);
            lblStatus.Spring = true;
            lblStatus.Text = "Trạng thái: Chưa kết nối";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCycleCount
            // 
            lblCycleCount.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            lblCycleCount.Name = "lblCycleCount";
            lblCycleCount.Size = new Size(149, 20);
            lblCycleCount.Text = "Số chu kỳ tín hiệu: 0";
            // 
            // frmIoTMonitor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 473);
            Controls.Add(statusStrip1);
            Controls.Add(dgvLogs);
            Controls.Add(grpMonitor);
            Controls.Add(grpControl);
            MinimumSize = new Size(800, 520);
            Name = "frmIoTMonitor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repair & IoT - Hệ Thống Giám Sát Cảm Biến Real-Time";
            FormClosing += frmIoTMonitor_FormClosing;
            Load += frmIoTMonitor_Load;
            grpControl.ResumeLayout(false);
            grpMonitor.ResumeLayout(false);
            grpMonitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpControl;
        private Button btnStop;
        private Button btnStart;
        private GroupBox grpMonitor;
        private Label lblTemperature;
        private Label lblTempTitle;
        private DataGridView dgvLogs;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblCycleCount;
    }
}