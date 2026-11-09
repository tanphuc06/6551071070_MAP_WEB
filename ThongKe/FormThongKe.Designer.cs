using System.Windows.Forms.DataVisualization.Charting;

namespace HotelManagement.ThongKe
{
    partial class FormThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChartArea chartAreaDichVu = new ChartArea();
            Legend legendDichVu = new Legend();
            Series seriesDichVu = new Series();
            ChartArea chartAreaDoanhThu = new ChartArea();
            Legend legendDoanhThu = new Legend();
            Series seriesDoanhThu = new Series();
            ChartArea chartAreaSoPhong = new ChartArea();
            Legend legendSoPhong = new Legend();
            Series seriesSoPhong = new Series();

            panelBoLoc = new Panel();
            lblTuNgay = new Label();
            dtpTuNgay = new DateTimePicker();
            lblDenNgay = new Label();
            dtpDenNgay = new DateTimePicker();
            btnXemThongKe = new Button();

            tlpChinh = new TableLayoutPanel();
            tlpTrai = new TableLayoutPanel();
            tlpPhai = new TableLayoutPanel();
            tlpKpiPhai = new TableLayoutPanel();

            panelKpiDoanhThuPhong = new Panel();
            picDoanhThuPhong = new PictureBox();
            lblTieuDeDoanhThuPhong = new Label();
            lblDoanhThuPhong = new Label();

            panelKpiDoanhThuDichVu = new Panel();
            picDoanhThuDichVu = new PictureBox();
            lblTieuDeDoanhThuDichVu = new Label();
            lblDoanhThuDichVu = new Label();

            panelKpiSoPhongDat = new Panel();
            picSoPhongDat = new PictureBox();
            lblTieuDeSoPhongDat = new Label();
            lblSoPhongDat = new Label();

            panelTop1 = new Panel();
            picTop1 = new PictureBox();
            lblTieuDeTop1 = new Label();
            lblTopLoaiPhongDoanhThu = new Label();

            panelTop2 = new Panel();
            picTop2 = new PictureBox();
            lblTieuDeTop2 = new Label();
            lblTopLoaiPhongDatNhieu = new Label();

            panelTop3 = new Panel();
            picTop3 = new PictureBox();
            lblTieuDeTop3 = new Label();
            lblTopDichVu = new Label();

            panelBieuDoDichVu = new Panel();
            lblTieuDeBieuDoDichVu = new Label();
            chartDichVu = new Chart();

            panelBieuDoDoanhThuPhong = new Panel();
            lblTieuDeBieuDoDoanhThu = new Label();
            chartDoanhThuPhong = new Chart();

            panelBieuDoSoPhongDat = new Panel();
            lblTieuDeBieuDoSoPhong = new Label();
            chartSoPhongDat = new Chart();

            panelBoLoc.SuspendLayout();
            tlpChinh.SuspendLayout();
            tlpTrai.SuspendLayout();
            tlpPhai.SuspendLayout();
            tlpKpiPhai.SuspendLayout();
            panelKpiDoanhThuPhong.SuspendLayout();
            panelKpiDoanhThuDichVu.SuspendLayout();
            panelKpiSoPhongDat.SuspendLayout();
            panelTop1.SuspendLayout();
            panelTop2.SuspendLayout();
            panelTop3.SuspendLayout();
            panelBieuDoDichVu.SuspendLayout();
            panelBieuDoDoanhThuPhong.SuspendLayout();
            panelBieuDoSoPhongDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDoanhThuPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDoanhThuDichVu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSoPhongDat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTop1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTop2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTop3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDichVu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThuPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartSoPhongDat).BeginInit();
            SuspendLayout();

            // 
            // panelBoLoc
            // 
            panelBoLoc.BackColor = Color.FromArgb(228, 232, 246);
            panelBoLoc.Controls.Add(btnXemThongKe);
            panelBoLoc.Controls.Add(dtpDenNgay);
            panelBoLoc.Controls.Add(lblDenNgay);
            panelBoLoc.Controls.Add(dtpTuNgay);
            panelBoLoc.Controls.Add(lblTuNgay);
            panelBoLoc.Dock = DockStyle.Top;
            panelBoLoc.Location = new Point(0, 0);
            panelBoLoc.Name = "panelBoLoc";
            panelBoLoc.Padding = new Padding(16, 12, 16, 12);
            panelBoLoc.Size = new Size(1240, 66);
            panelBoLoc.TabIndex = 0;

            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            lblTuNgay.ForeColor = Color.FromArgb(40, 40, 60);
            lblTuNgay.Location = new Point(20, 21);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(76, 25);
            lblTuNgay.TabIndex = 0;
            lblTuNgay.Text = "Từ ngày";

            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            dtpTuNgay.Format = DateTimePickerFormat.Long;
            dtpTuNgay.Location = new Point(104, 17);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(270, 31);
            dtpTuNgay.TabIndex = 1;

            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            lblDenNgay.ForeColor = Color.FromArgb(40, 40, 60);
            lblDenNgay.Location = new Point(394, 21);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(88, 25);
            lblDenNgay.TabIndex = 2;
            lblDenNgay.Text = "Đến ngày";

            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            dtpDenNgay.Format = DateTimePickerFormat.Long;
            dtpDenNgay.Location = new Point(490, 17);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(270, 31);
            dtpDenNgay.TabIndex = 3;

            // 
            // btnXemThongKe
            // 
            btnXemThongKe.BackColor = Color.FromArgb(228, 246, 250);
            btnXemThongKe.Cursor = Cursors.Hand;
            btnXemThongKe.FlatAppearance.BorderColor = Color.FromArgb(130, 170, 190);
            btnXemThongKe.FlatStyle = FlatStyle.Flat;
            btnXemThongKe.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnXemThongKe.ForeColor = Color.FromArgb(25, 65, 85);
            btnXemThongKe.Location = new Point(786, 14);
            btnXemThongKe.Name = "btnXemThongKe";
            btnXemThongKe.Size = new Size(165, 38);
            btnXemThongKe.TabIndex = 4;
            btnXemThongKe.Text = "Xem thống kê";
            btnXemThongKe.UseVisualStyleBackColor = false;
            btnXemThongKe.Click += btnXemThongKe_Click;

            // 
            // tlpChinh
            // 
            tlpChinh.BackColor = Color.FromArgb(245, 246, 250);
            tlpChinh.ColumnCount = 2;
            tlpChinh.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tlpChinh.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            tlpChinh.Controls.Add(tlpTrai, 0, 0);
            tlpChinh.Controls.Add(tlpPhai, 1, 0);
            tlpChinh.Dock = DockStyle.Fill;
            tlpChinh.Location = new Point(0, 66);
            tlpChinh.Name = "tlpChinh";
            tlpChinh.Padding = new Padding(12);
            tlpChinh.RowCount = 1;
            tlpChinh.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpChinh.Size = new Size(1240, 754);
            tlpChinh.TabIndex = 1;

            // 
            // tlpTrai
            // 
            tlpTrai.ColumnCount = 1;
            tlpTrai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTrai.Controls.Add(panelKpiDoanhThuPhong, 0, 0);
            tlpTrai.Controls.Add(panelTop1, 0, 1);
            tlpTrai.Controls.Add(panelTop2, 0, 2);
            tlpTrai.Controls.Add(panelTop3, 0, 3);
            tlpTrai.Controls.Add(panelBieuDoDichVu, 0, 4);
            tlpTrai.Dock = DockStyle.Fill;
            tlpTrai.Location = new Point(15, 15);
            tlpTrai.Margin = new Padding(0, 0, 10, 0);
            tlpTrai.Name = "tlpTrai";
            tlpTrai.RowCount = 5;
            tlpTrai.RowStyles.Add(new RowStyle(SizeType.Absolute, 108F));
            tlpTrai.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tlpTrai.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tlpTrai.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tlpTrai.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTrai.Size = new Size(502, 724);
            tlpTrai.TabIndex = 0;

            // 
            // panelKpiDoanhThuPhong
            // 
            panelKpiDoanhThuPhong.BackColor = Color.FromArgb(255, 128, 96);
            panelKpiDoanhThuPhong.Controls.Add(lblDoanhThuPhong);
            panelKpiDoanhThuPhong.Controls.Add(lblTieuDeDoanhThuPhong);
            panelKpiDoanhThuPhong.Controls.Add(picDoanhThuPhong);
            panelKpiDoanhThuPhong.Dock = DockStyle.Fill;
            panelKpiDoanhThuPhong.Location = new Point(0, 0);
            panelKpiDoanhThuPhong.Margin = new Padding(0, 0, 0, 10);
            panelKpiDoanhThuPhong.Name = "panelKpiDoanhThuPhong";
            panelKpiDoanhThuPhong.Size = new Size(502, 98);
            panelKpiDoanhThuPhong.TabIndex = 0;

            // 
            // picDoanhThuPhong
            // 
            picDoanhThuPhong.BackColor = Color.Transparent;
            picDoanhThuPhong.Image = Properties.Resources.DoanhThuThue;
            picDoanhThuPhong.Location = new Point(18, 17);
            picDoanhThuPhong.Name = "picDoanhThuPhong";
            picDoanhThuPhong.Size = new Size(64, 64);
            picDoanhThuPhong.SizeMode = PictureBoxSizeMode.Zoom;
            picDoanhThuPhong.TabIndex = 0;
            picDoanhThuPhong.TabStop = false;

            // 
            // lblTieuDeDoanhThuPhong
            // 
            lblTieuDeDoanhThuPhong.AutoSize = true;
            lblTieuDeDoanhThuPhong.BackColor = Color.Transparent;
            lblTieuDeDoanhThuPhong.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblTieuDeDoanhThuPhong.ForeColor = Color.White;
            lblTieuDeDoanhThuPhong.Location = new Point(98, 16);
            lblTieuDeDoanhThuPhong.Name = "lblTieuDeDoanhThuPhong";
            lblTieuDeDoanhThuPhong.Size = new Size(202, 28);
            lblTieuDeDoanhThuPhong.TabIndex = 1;
            lblTieuDeDoanhThuPhong.Text = "Doanh thu thuê phòng";

            // 
            // lblDoanhThuPhong
            // 
            lblDoanhThuPhong.AutoSize = true;
            lblDoanhThuPhong.BackColor = Color.Transparent;
            lblDoanhThuPhong.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDoanhThuPhong.ForeColor = Color.White;
            lblDoanhThuPhong.Location = new Point(98, 49);
            lblDoanhThuPhong.Name = "lblDoanhThuPhong";
            lblDoanhThuPhong.Size = new Size(100, 37);
            lblDoanhThuPhong.TabIndex = 2;
            lblDoanhThuPhong.Text = "0 VND";

            // 
            // panelTop1
            // 
            panelTop1.BackColor = Color.FromArgb(228, 224, 248);
            panelTop1.Controls.Add(lblTopLoaiPhongDoanhThu);
            panelTop1.Controls.Add(lblTieuDeTop1);
            panelTop1.Controls.Add(picTop1);
            panelTop1.Dock = DockStyle.Fill;
            panelTop1.Location = new Point(0, 108);
            panelTop1.Margin = new Padding(0, 0, 0, 8);
            panelTop1.Name = "panelTop1";
            panelTop1.Size = new Size(502, 80);
            panelTop1.TabIndex = 1;

            // 
            // picTop1
            // 
            picTop1.BackColor = Color.Transparent;
            picTop1.Image = Properties.Resources.top1;
            picTop1.Location = new Point(14, 14);
            picTop1.Name = "picTop1";
            picTop1.Size = new Size(52, 52);
            picTop1.SizeMode = PictureBoxSizeMode.Zoom;
            picTop1.TabIndex = 0;
            picTop1.TabStop = false;

            // 
            // lblTieuDeTop1
            // 
            lblTieuDeTop1.AutoSize = true;
            lblTieuDeTop1.BackColor = Color.Transparent;
            lblTieuDeTop1.Font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
            lblTieuDeTop1.ForeColor = Color.FromArgb(165, 42, 42);
            lblTieuDeTop1.Location = new Point(78, 12);
            lblTieuDeTop1.Name = "lblTieuDeTop1";
            lblTieuDeTop1.Size = new Size(256, 24);
            lblTieuDeTop1.TabIndex = 1;
            lblTieuDeTop1.Text = "Loại phòng doanh thu cao nhất";

            // 
            // lblTopLoaiPhongDoanhThu
            // 
            lblTopLoaiPhongDoanhThu.AutoSize = true;
            lblTopLoaiPhongDoanhThu.BackColor = Color.Transparent;
            lblTopLoaiPhongDoanhThu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTopLoaiPhongDoanhThu.ForeColor = Color.FromArgb(0, 0, 128);
            lblTopLoaiPhongDoanhThu.Location = new Point(78, 40);
            lblTopLoaiPhongDoanhThu.Name = "lblTopLoaiPhongDoanhThu";
            lblTopLoaiPhongDoanhThu.Size = new Size(158, 28);
            lblTopLoaiPhongDoanhThu.TabIndex = 2;
            lblTopLoaiPhongDoanhThu.Text = "Chưa có dữ liệu";

            // 
            // panelTop2
            // 
            panelTop2.BackColor = Color.FromArgb(228, 224, 248);
            panelTop2.Controls.Add(lblTopLoaiPhongDatNhieu);
            panelTop2.Controls.Add(lblTieuDeTop2);
            panelTop2.Controls.Add(picTop2);
            panelTop2.Dock = DockStyle.Fill;
            panelTop2.Location = new Point(0, 196);
            panelTop2.Margin = new Padding(0, 0, 0, 8);
            panelTop2.Name = "panelTop2";
            panelTop2.Size = new Size(502, 80);
            panelTop2.TabIndex = 2;

            // 
            // picTop2
            // 
            picTop2.BackColor = Color.Transparent;
            picTop2.Image = Properties.Resources.top2;
            picTop2.Location = new Point(14, 14);
            picTop2.Name = "picTop2";
            picTop2.Size = new Size(52, 52);
            picTop2.SizeMode = PictureBoxSizeMode.Zoom;
            picTop2.TabIndex = 0;
            picTop2.TabStop = false;

            // 
            // lblTieuDeTop2
            // 
            lblTieuDeTop2.AutoSize = true;
            lblTieuDeTop2.BackColor = Color.Transparent;
            lblTieuDeTop2.Font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
            lblTieuDeTop2.ForeColor = Color.FromArgb(165, 42, 42);
            lblTieuDeTop2.Location = new Point(78, 12);
            lblTieuDeTop2.Name = "lblTieuDeTop2";
            lblTieuDeTop2.Size = new Size(276, 24);
            lblTieuDeTop2.TabIndex = 1;
            lblTieuDeTop2.Text = "Loại phòng được đặt nhiều nhất";

            // 
            // lblTopLoaiPhongDatNhieu
            // 
            lblTopLoaiPhongDatNhieu.AutoSize = true;
            lblTopLoaiPhongDatNhieu.BackColor = Color.Transparent;
            lblTopLoaiPhongDatNhieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTopLoaiPhongDatNhieu.ForeColor = Color.FromArgb(0, 0, 128);
            lblTopLoaiPhongDatNhieu.Location = new Point(78, 40);
            lblTopLoaiPhongDatNhieu.Name = "lblTopLoaiPhongDatNhieu";
            lblTopLoaiPhongDatNhieu.Size = new Size(158, 28);
            lblTopLoaiPhongDatNhieu.TabIndex = 2;
            lblTopLoaiPhongDatNhieu.Text = "Chưa có dữ liệu";

            // 
            // panelTop3
            // 
            panelTop3.BackColor = Color.FromArgb(228, 224, 248);
            panelTop3.Controls.Add(lblTopDichVu);
            panelTop3.Controls.Add(lblTieuDeTop3);
            panelTop3.Controls.Add(picTop3);
            panelTop3.Dock = DockStyle.Fill;
            panelTop3.Location = new Point(0, 284);
            panelTop3.Margin = new Padding(0, 0, 0, 8);
            panelTop3.Name = "panelTop3";
            panelTop3.Size = new Size(502, 80);
            panelTop3.TabIndex = 3;

            // 
            // picTop3
            // 
            picTop3.BackColor = Color.Transparent;
            picTop3.Image = Properties.Resources.top3;
            picTop3.Location = new Point(14, 14);
            picTop3.Name = "picTop3";
            picTop3.Size = new Size(52, 52);
            picTop3.SizeMode = PictureBoxSizeMode.Zoom;
            picTop3.TabIndex = 0;
            picTop3.TabStop = false;

            // 
            // lblTieuDeTop3
            // 
            lblTieuDeTop3.AutoSize = true;
            lblTieuDeTop3.BackColor = Color.Transparent;
            lblTieuDeTop3.Font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
            lblTieuDeTop3.ForeColor = Color.FromArgb(165, 42, 42);
            lblTieuDeTop3.Location = new Point(78, 12);
            lblTieuDeTop3.Name = "lblTieuDeTop3";
            lblTieuDeTop3.Size = new Size(227, 24);
            lblTieuDeTop3.TabIndex = 1;
            lblTieuDeTop3.Text = "Dịch vụ doanh thu cao nhất";

            // 
            // lblTopDichVu
            // 
            lblTopDichVu.AutoSize = true;
            lblTopDichVu.BackColor = Color.Transparent;
            lblTopDichVu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTopDichVu.ForeColor = Color.FromArgb(0, 0, 128);
            lblTopDichVu.Location = new Point(78, 40);
            lblTopDichVu.Name = "lblTopDichVu";
            lblTopDichVu.Size = new Size(158, 28);
            lblTopDichVu.TabIndex = 2;
            lblTopDichVu.Text = "Chưa có dữ liệu";

            // 
            // panelBieuDoDichVu
            // 
            panelBieuDoDichVu.BackColor = Color.FromArgb(228, 224, 248);
            panelBieuDoDichVu.Controls.Add(chartDichVu);
            panelBieuDoDichVu.Controls.Add(lblTieuDeBieuDoDichVu);
            panelBieuDoDichVu.Dock = DockStyle.Fill;
            panelBieuDoDichVu.Location = new Point(0, 372);
            panelBieuDoDichVu.Margin = new Padding(0);
            panelBieuDoDichVu.Name = "panelBieuDoDichVu";
            panelBieuDoDichVu.Padding = new Padding(8, 0, 8, 8);
            panelBieuDoDichVu.Size = new Size(502, 352);
            panelBieuDoDichVu.TabIndex = 4;

            // 
            // lblTieuDeBieuDoDichVu
            // 
            lblTieuDeBieuDoDichVu.Dock = DockStyle.Top;
            lblTieuDeBieuDoDichVu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTieuDeBieuDoDichVu.ForeColor = Color.FromArgb(165, 42, 42);
            lblTieuDeBieuDoDichVu.Location = new Point(8, 0);
            lblTieuDeBieuDoDichVu.Name = "lblTieuDeBieuDoDichVu";
            lblTieuDeBieuDoDichVu.Padding = new Padding(4, 6, 0, 2);
            lblTieuDeBieuDoDichVu.Size = new Size(486, 36);
            lblTieuDeBieuDoDichVu.TabIndex = 0;
            lblTieuDeBieuDoDichVu.Text = "Các dịch vụ được sử dụng";

            // 
            // chartDichVu
            // 
            chartDichVu.BackColor = Color.White;
            chartAreaDichVu.BackColor = Color.White;
            chartAreaDichVu.Name = "ChartAreaDichVu";
            chartDichVu.ChartAreas.Add(chartAreaDichVu);
            chartDichVu.Dock = DockStyle.Fill;
            legendDichVu.BackColor = Color.White;
            legendDichVu.Docking = Docking.Right;
            legendDichVu.Font = new Font("Segoe UI", 9.5F);
            legendDichVu.Name = "LegendDichVu";
            chartDichVu.Legends.Add(legendDichVu);
            chartDichVu.Location = new Point(8, 36);
            chartDichVu.Name = "chartDichVu";
            chartDichVu.Palette = ChartColorPalette.BrightPastel;
            seriesDichVu.ChartArea = "ChartAreaDichVu";
            seriesDichVu.ChartType = SeriesChartType.Pie;
            seriesDichVu.Legend = "LegendDichVu";
            seriesDichVu.Name = "DichVu";
            chartDichVu.Series.Add(seriesDichVu);
            chartDichVu.Size = new Size(486, 308);
            chartDichVu.TabIndex = 1;

            // 
            // tlpPhai
            // 
            tlpPhai.ColumnCount = 1;
            tlpPhai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPhai.Controls.Add(tlpKpiPhai, 0, 0);
            tlpPhai.Controls.Add(panelBieuDoDoanhThuPhong, 0, 1);
            tlpPhai.Controls.Add(panelBieuDoSoPhongDat, 0, 2);
            tlpPhai.Dock = DockStyle.Fill;
            tlpPhai.Location = new Point(527, 15);
            tlpPhai.Margin = new Padding(0);
            tlpPhai.Name = "tlpPhai";
            tlpPhai.RowCount = 3;
            tlpPhai.RowStyles.Add(new RowStyle(SizeType.Absolute, 108F));
            tlpPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpPhai.Size = new Size(698, 724);
            tlpPhai.TabIndex = 1;

            // 
            // tlpKpiPhai
            // 
            tlpKpiPhai.ColumnCount = 2;
            tlpKpiPhai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKpiPhai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKpiPhai.Controls.Add(panelKpiDoanhThuDichVu, 0, 0);
            tlpKpiPhai.Controls.Add(panelKpiSoPhongDat, 1, 0);
            tlpKpiPhai.Dock = DockStyle.Fill;
            tlpKpiPhai.Location = new Point(0, 0);
            tlpKpiPhai.Margin = new Padding(0, 0, 0, 10);
            tlpKpiPhai.Name = "tlpKpiPhai";
            tlpKpiPhai.RowCount = 1;
            tlpKpiPhai.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKpiPhai.Size = new Size(698, 98);
            tlpKpiPhai.TabIndex = 0;

            // 
            // panelKpiDoanhThuDichVu
            // 
            panelKpiDoanhThuDichVu.BackColor = Color.FromArgb(212, 178, 56);
            panelKpiDoanhThuDichVu.Controls.Add(lblDoanhThuDichVu);
            panelKpiDoanhThuDichVu.Controls.Add(lblTieuDeDoanhThuDichVu);
            panelKpiDoanhThuDichVu.Controls.Add(picDoanhThuDichVu);
            panelKpiDoanhThuDichVu.Dock = DockStyle.Fill;
            panelKpiDoanhThuDichVu.Location = new Point(0, 0);
            panelKpiDoanhThuDichVu.Margin = new Padding(0, 0, 5, 0);
            panelKpiDoanhThuDichVu.Name = "panelKpiDoanhThuDichVu";
            panelKpiDoanhThuDichVu.Size = new Size(344, 98);
            panelKpiDoanhThuDichVu.TabIndex = 0;

            // 
            // picDoanhThuDichVu
            // 
            picDoanhThuDichVu.BackColor = Color.Transparent;
            picDoanhThuDichVu.Image = Properties.Resources.DoanhThu;
            picDoanhThuDichVu.Location = new Point(16, 17);
            picDoanhThuDichVu.Name = "picDoanhThuDichVu";
            picDoanhThuDichVu.Size = new Size(64, 64);
            picDoanhThuDichVu.SizeMode = PictureBoxSizeMode.Zoom;
            picDoanhThuDichVu.TabIndex = 0;
            picDoanhThuDichVu.TabStop = false;

            // 
            // lblTieuDeDoanhThuDichVu
            // 
            lblTieuDeDoanhThuDichVu.AutoSize = true;
            lblTieuDeDoanhThuDichVu.BackColor = Color.Transparent;
            lblTieuDeDoanhThuDichVu.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblTieuDeDoanhThuDichVu.ForeColor = Color.White;
            lblTieuDeDoanhThuDichVu.Location = new Point(92, 16);
            lblTieuDeDoanhThuDichVu.Name = "lblTieuDeDoanhThuDichVu";
            lblTieuDeDoanhThuDichVu.Size = new Size(169, 28);
            lblTieuDeDoanhThuDichVu.TabIndex = 1;
            lblTieuDeDoanhThuDichVu.Text = "Doanh thu dịch vụ";

            // 
            // lblDoanhThuDichVu
            // 
            lblDoanhThuDichVu.AutoSize = true;
            lblDoanhThuDichVu.BackColor = Color.Transparent;
            lblDoanhThuDichVu.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDoanhThuDichVu.ForeColor = Color.White;
            lblDoanhThuDichVu.Location = new Point(92, 49);
            lblDoanhThuDichVu.Name = "lblDoanhThuDichVu";
            lblDoanhThuDichVu.Size = new Size(100, 37);
            lblDoanhThuDichVu.TabIndex = 2;
            lblDoanhThuDichVu.Text = "0 VND";

            // 
            // panelKpiSoPhongDat
            // 
            panelKpiSoPhongDat.BackColor = Color.FromArgb(106, 176, 98);
            panelKpiSoPhongDat.Controls.Add(lblSoPhongDat);
            panelKpiSoPhongDat.Controls.Add(lblTieuDeSoPhongDat);
            panelKpiSoPhongDat.Controls.Add(picSoPhongDat);
            panelKpiSoPhongDat.Dock = DockStyle.Fill;
            panelKpiSoPhongDat.Location = new Point(354, 0);
            panelKpiSoPhongDat.Margin = new Padding(5, 0, 0, 0);
            panelKpiSoPhongDat.Name = "panelKpiSoPhongDat";
            panelKpiSoPhongDat.Size = new Size(344, 98);
            panelKpiSoPhongDat.TabIndex = 1;

            // 
            // picSoPhongDat
            // 
            picSoPhongDat.BackColor = Color.Transparent;
            picSoPhongDat.Image = Properties.Resources.SoPhongDat;
            picSoPhongDat.Location = new Point(16, 17);
            picSoPhongDat.Name = "picSoPhongDat";
            picSoPhongDat.Size = new Size(64, 64);
            picSoPhongDat.SizeMode = PictureBoxSizeMode.Zoom;
            picSoPhongDat.TabIndex = 0;
            picSoPhongDat.TabStop = false;

            // 
            // lblTieuDeSoPhongDat
            // 
            lblTieuDeSoPhongDat.AutoSize = true;
            lblTieuDeSoPhongDat.BackColor = Color.Transparent;
            lblTieuDeSoPhongDat.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblTieuDeSoPhongDat.ForeColor = Color.White;
            lblTieuDeSoPhongDat.Location = new Point(92, 16);
            lblTieuDeSoPhongDat.Name = "lblTieuDeSoPhongDat";
            lblTieuDeSoPhongDat.Size = new Size(128, 28);
            lblTieuDeSoPhongDat.TabIndex = 1;
            lblTieuDeSoPhongDat.Text = "Số phòng đặt";

            // 
            // lblSoPhongDat
            // 
            lblSoPhongDat.AutoSize = true;
            lblSoPhongDat.BackColor = Color.Transparent;
            lblSoPhongDat.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSoPhongDat.ForeColor = Color.White;
            lblSoPhongDat.Location = new Point(92, 49);
            lblSoPhongDat.Name = "lblSoPhongDat";
            lblSoPhongDat.Size = new Size(31, 37);
            lblSoPhongDat.TabIndex = 2;
            lblSoPhongDat.Text = "0";

            // 
            // panelBieuDoDoanhThuPhong
            // 
            panelBieuDoDoanhThuPhong.BackColor = Color.FromArgb(228, 224, 248);
            panelBieuDoDoanhThuPhong.Controls.Add(chartDoanhThuPhong);
            panelBieuDoDoanhThuPhong.Controls.Add(lblTieuDeBieuDoDoanhThu);
            panelBieuDoDoanhThuPhong.Dock = DockStyle.Fill;
            panelBieuDoDoanhThuPhong.Location = new Point(0, 108);
            panelBieuDoDoanhThuPhong.Margin = new Padding(0, 0, 0, 8);
            panelBieuDoDoanhThuPhong.Name = "panelBieuDoDoanhThuPhong";
            panelBieuDoDoanhThuPhong.Padding = new Padding(8, 0, 8, 8);
            panelBieuDoDoanhThuPhong.Size = new Size(698, 300);
            panelBieuDoDoanhThuPhong.TabIndex = 1;

            // 
            // lblTieuDeBieuDoDoanhThu
            // 
            lblTieuDeBieuDoDoanhThu.Dock = DockStyle.Top;
            lblTieuDeBieuDoDoanhThu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTieuDeBieuDoDoanhThu.ForeColor = Color.FromArgb(165, 42, 42);
            lblTieuDeBieuDoDoanhThu.Location = new Point(8, 0);
            lblTieuDeBieuDoDoanhThu.Name = "lblTieuDeBieuDoDoanhThu";
            lblTieuDeBieuDoDoanhThu.Padding = new Padding(4, 6, 0, 2);
            lblTieuDeBieuDoDoanhThu.Size = new Size(682, 36);
            lblTieuDeBieuDoDoanhThu.TabIndex = 0;
            lblTieuDeBieuDoDoanhThu.Text = "Doanh thu thuê phòng";

            // 
            // chartDoanhThuPhong
            // 
            chartDoanhThuPhong.BackColor = Color.White;
            chartAreaDoanhThu.AxisX.MajorGrid.Enabled = false;
            chartAreaDoanhThu.AxisY.MajorGrid.LineColor = Color.Gainsboro;
            chartAreaDoanhThu.BackColor = Color.White;
            chartAreaDoanhThu.Name = "ChartAreaDoanhThu";
            chartDoanhThuPhong.ChartAreas.Add(chartAreaDoanhThu);
            chartDoanhThuPhong.Dock = DockStyle.Fill;
            legendDoanhThu.BackColor = Color.White;
            legendDoanhThu.Docking = Docking.Right;
            legendDoanhThu.Font = new Font("Segoe UI", 9.5F);
            legendDoanhThu.Name = "LegendDoanhThu";
            chartDoanhThuPhong.Legends.Add(legendDoanhThu);
            chartDoanhThuPhong.Location = new Point(8, 36);
            chartDoanhThuPhong.Name = "chartDoanhThuPhong";
            seriesDoanhThu.ChartArea = "ChartAreaDoanhThu";
            seriesDoanhThu.ChartType = SeriesChartType.Column;
            seriesDoanhThu.Color = Color.FromArgb(46, 134, 193);
            seriesDoanhThu.Legend = "LegendDoanhThu";
            seriesDoanhThu.Name = "Doanh thu theo loại phòng";
            chartDoanhThuPhong.Series.Add(seriesDoanhThu);
            chartDoanhThuPhong.Size = new Size(682, 256);
            chartDoanhThuPhong.TabIndex = 1;

            // 
            // panelBieuDoSoPhongDat
            // 
            panelBieuDoSoPhongDat.BackColor = Color.FromArgb(228, 224, 248);
            panelBieuDoSoPhongDat.Controls.Add(chartSoPhongDat);
            panelBieuDoSoPhongDat.Controls.Add(lblTieuDeBieuDoSoPhong);
            panelBieuDoSoPhongDat.Dock = DockStyle.Fill;
            panelBieuDoSoPhongDat.Location = new Point(0, 416);
            panelBieuDoSoPhongDat.Margin = new Padding(0);
            panelBieuDoSoPhongDat.Name = "panelBieuDoSoPhongDat";
            panelBieuDoSoPhongDat.Padding = new Padding(8, 0, 8, 8);
            panelBieuDoSoPhongDat.Size = new Size(698, 308);
            panelBieuDoSoPhongDat.TabIndex = 2;

            // 
            // lblTieuDeBieuDoSoPhong
            // 
            lblTieuDeBieuDoSoPhong.Dock = DockStyle.Top;
            lblTieuDeBieuDoSoPhong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTieuDeBieuDoSoPhong.ForeColor = Color.FromArgb(165, 42, 42);
            lblTieuDeBieuDoSoPhong.Location = new Point(8, 0);
            lblTieuDeBieuDoSoPhong.Name = "lblTieuDeBieuDoSoPhong";
            lblTieuDeBieuDoSoPhong.Padding = new Padding(4, 6, 0, 2);
            lblTieuDeBieuDoSoPhong.Size = new Size(682, 36);
            lblTieuDeBieuDoSoPhong.TabIndex = 0;
            lblTieuDeBieuDoSoPhong.Text = "Số phòng được đặt";

            // 
            // chartSoPhongDat
            // 
            chartSoPhongDat.BackColor = Color.White;
            chartAreaSoPhong.AxisX.MajorGrid.Enabled = false;
            chartAreaSoPhong.AxisY.MajorGrid.LineColor = Color.Gainsboro;
            chartAreaSoPhong.BackColor = Color.White;
            chartAreaSoPhong.Name = "ChartAreaSoPhong";
            chartSoPhongDat.ChartAreas.Add(chartAreaSoPhong);
            chartSoPhongDat.Dock = DockStyle.Fill;
            legendSoPhong.BackColor = Color.White;
            legendSoPhong.Docking = Docking.Right;
            legendSoPhong.Font = new Font("Segoe UI", 9.5F);
            legendSoPhong.Name = "LegendSoPhong";
            chartSoPhongDat.Legends.Add(legendSoPhong);
            chartSoPhongDat.Location = new Point(8, 36);
            chartSoPhongDat.Name = "chartSoPhongDat";
            seriesSoPhong.ChartArea = "ChartAreaSoPhong";
            seriesSoPhong.ChartType = SeriesChartType.Column;
            seriesSoPhong.Color = Color.FromArgb(46, 134, 193);
            seriesSoPhong.Legend = "LegendSoPhong";
            seriesSoPhong.Name = "Số lượng đặt";
            chartSoPhongDat.Series.Add(seriesSoPhong);
            chartSoPhongDat.Size = new Size(682, 264);
            chartSoPhongDat.TabIndex = 1;

            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 820);
            Controls.Add(tlpChinh);
            Controls.Add(panelBoLoc);
            Name = "FormThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh thu và tình hình đặt phòng";
            Load += FormThongKe_Load;

            panelBoLoc.ResumeLayout(false);
            panelBoLoc.PerformLayout();
            tlpChinh.ResumeLayout(false);
            tlpTrai.ResumeLayout(false);
            tlpPhai.ResumeLayout(false);
            tlpKpiPhai.ResumeLayout(false);
            panelKpiDoanhThuPhong.ResumeLayout(false);
            panelKpiDoanhThuPhong.PerformLayout();
            panelKpiDoanhThuDichVu.ResumeLayout(false);
            panelKpiDoanhThuDichVu.PerformLayout();
            panelKpiSoPhongDat.ResumeLayout(false);
            panelKpiSoPhongDat.PerformLayout();
            panelTop1.ResumeLayout(false);
            panelTop1.PerformLayout();
            panelTop2.ResumeLayout(false);
            panelTop2.PerformLayout();
            panelTop3.ResumeLayout(false);
            panelTop3.PerformLayout();
            panelBieuDoDichVu.ResumeLayout(false);
            panelBieuDoDoanhThuPhong.ResumeLayout(false);
            panelBieuDoSoPhongDat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDoanhThuPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDoanhThuDichVu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSoPhongDat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTop1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTop2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTop3).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDichVu).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThuPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartSoPhongDat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelBoLoc;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnXemThongKe;
        private System.Windows.Forms.TableLayoutPanel tlpChinh;
        private System.Windows.Forms.TableLayoutPanel tlpTrai;
        private System.Windows.Forms.TableLayoutPanel tlpPhai;
        private System.Windows.Forms.TableLayoutPanel tlpKpiPhai;
        private System.Windows.Forms.Panel panelKpiDoanhThuPhong;
        private System.Windows.Forms.PictureBox picDoanhThuPhong;
        private System.Windows.Forms.Label lblTieuDeDoanhThuPhong;
        private System.Windows.Forms.Label lblDoanhThuPhong;
        private System.Windows.Forms.Panel panelKpiDoanhThuDichVu;
        private System.Windows.Forms.PictureBox picDoanhThuDichVu;
        private System.Windows.Forms.Label lblTieuDeDoanhThuDichVu;
        private System.Windows.Forms.Label lblDoanhThuDichVu;
        private System.Windows.Forms.Panel panelKpiSoPhongDat;
        private System.Windows.Forms.PictureBox picSoPhongDat;
        private System.Windows.Forms.Label lblTieuDeSoPhongDat;
        private System.Windows.Forms.Label lblSoPhongDat;
        private System.Windows.Forms.Panel panelTop1;
        private System.Windows.Forms.PictureBox picTop1;
        private System.Windows.Forms.Label lblTieuDeTop1;
        private System.Windows.Forms.Label lblTopLoaiPhongDoanhThu;
        private System.Windows.Forms.Panel panelTop2;
        private System.Windows.Forms.PictureBox picTop2;
        private System.Windows.Forms.Label lblTieuDeTop2;
        private System.Windows.Forms.Label lblTopLoaiPhongDatNhieu;
        private System.Windows.Forms.Panel panelTop3;
        private System.Windows.Forms.PictureBox picTop3;
        private System.Windows.Forms.Label lblTieuDeTop3;
        private System.Windows.Forms.Label lblTopDichVu;
        private System.Windows.Forms.Panel panelBieuDoDichVu;
        private System.Windows.Forms.Label lblTieuDeBieuDoDichVu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDichVu;
        private System.Windows.Forms.Panel panelBieuDoDoanhThuPhong;
        private System.Windows.Forms.Label lblTieuDeBieuDoDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThuPhong;
        private System.Windows.Forms.Panel panelBieuDoSoPhongDat;
        private System.Windows.Forms.Label lblTieuDeBieuDoSoPhong;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSoPhongDat;
    }
}
