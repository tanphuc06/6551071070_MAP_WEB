using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.ThongKe
{
    public partial class FormThongKe : Form
    {
        private readonly CultureInfo _viVN = new CultureInfo("vi-VN");

        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object? sender, EventArgs e)
        {
            DateTime macDinhTuNgay = new DateTime(2022, 1, 1);
            DateTime macDinhDenNgay = DateTime.Today >= macDinhTuNgay ? DateTime.Today : macDinhTuNgay;

            dtpTuNgay.Value = macDinhTuNgay;
            dtpDenNgay.Value = macDinhDenNgay;

            TaiDuLieuThongKe();
        }

        private void btnXemThongKe_Click(object? sender, EventArgs e)
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpTuNgay.Focus();
                return;
            }

            TaiDuLieuThongKe();
        }

        private void TaiDuLieuThongKe()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgaySau = dtpDenNgay.Value.Date.AddDays(1);

            try
            {
                using var db = new HotelManagementContext();

                var loaiPhongs = db.LoaiPhongs
                    .AsNoTracking()
                    .OrderBy(lp => lp.TenLph)
                    .Select(lp => new { lp.MaLph, lp.TenLph })
                    .ToList();

                var dsCtdp = db.Ctdps
                    .AsNoTracking()
                    .Where(c => c.DaXoa != true)
                    .Select(c => new
                    {
                        c.MaCtdp,
                        c.CheckIn,
                        c.CheckOut,
                        c.TrangThai,
                        ThanhTien = c.ThanhTien ?? 0m,
                        MaLph = c.MaPhNavigation.MaLph,
                        TenLph = c.MaPhNavigation.MaLphNavigation.TenLph,
                        NgayHoaDon = c.HoaDons
                            .Where(h => h.DaXoa != true)
                            .OrderByDescending(h => h.NgHd)
                            .Select(h => h.NgHd)
                            .FirstOrDefault()
                    })
                    .ToList();

                // Phiếu đặt phòng trong khoảng thời gian (theo ngày CheckIn)
                var dsDatTrongKy = dsCtdp
                    .Where(c => c.CheckIn >= tuNgay && c.CheckIn < denNgaySau)
                    .ToList();

                // Phiếu đã thanh toán/hoàn tất tính doanh thu trong khoảng thời gian
                var dsDoanhThuTrongKy = dsCtdp
                    .Where(c =>
                    {
                        bool daHoanTat = c.TrangThai == "Đã thanh toán"
                                         || c.TrangThai == "Đã xong"
                                         || c.NgayHoaDon != null;
                        if (!daHoanTat)
                            return false;

                        DateTime ngayTinhDoanhThu = c.NgayHoaDon ?? c.CheckOut;
                        return ngayTinhDoanhThu >= tuNgay && ngayTinhDoanhThu < denNgaySau;
                    })
                    .ToList();

                var maCtdpDoanhThu = dsDoanhThuTrongKy
                    .Select(c => c.MaCtdp)
                    .Distinct()
                    .ToList();

                var dsDichVuTrongKy = maCtdpDoanhThu.Count == 0
                    ? new List<(string MaDv, string TenDv, int Sl, decimal ThanhTien)>()
                    : db.Ctdvs
                        .AsNoTracking()
                        .Where(v => v.DaXoa != true && maCtdpDoanhThu.Contains(v.MaCtdp))
                        .Select(v => new
                        {
                            v.MaDv,
                            TenDv = v.MaDvNavigation.TenDv,
                            v.Sl,
                            ThanhTien = v.ThanhTien ?? (v.Sl * v.MaDvNavigation.DonGia)
                        })
                        .ToList()
                        .Select(v => (v.MaDv, v.TenDv, v.Sl, v.ThanhTien))
                        .ToList();

                // 3 thẻ KPI
                decimal tongDoanhThuPhong = dsDoanhThuTrongKy.Sum(c => c.ThanhTien);
                decimal tongDoanhThuDichVu = dsDichVuTrongKy.Sum(v => v.ThanhTien);
                int tongSoPhongDat = dsDatTrongKy.Count;

                lblDoanhThuPhong.Text = DinhDangTien(tongDoanhThuPhong);
                lblDoanhThuDichVu.Text = DinhDangTien(tongDoanhThuDichVu);
                lblSoPhongDat.Text = tongSoPhongDat.ToString("N0", _viVN);

                // Top 1: Loại phòng doanh thu cao nhất
                var doanhThuTheoLoai = dsDoanhThuTrongKy
                    .GroupBy(c => new { c.MaLph, c.TenLph })
                    .Select(g => new
                    {
                        g.Key.MaLph,
                        g.Key.TenLph,
                        DoanhThu = g.Sum(x => x.ThanhTien)
                    })
                    .OrderByDescending(x => x.DoanhThu)
                    .ToList();

                var topDoanhThuPhong = doanhThuTheoLoai.FirstOrDefault();
                lblTopLoaiPhongDoanhThu.Text = topDoanhThuPhong != null && topDoanhThuPhong.DoanhThu > 0
                    ? $"{topDoanhThuPhong.TenLph} ({DinhDangTien(topDoanhThuPhong.DoanhThu)})"
                    : "Chưa có dữ liệu";

                // Top 2: Loại phòng được đặt nhiều nhất
                var luotDatTheoLoai = dsDatTrongKy
                    .GroupBy(c => new { c.MaLph, c.TenLph })
                    .Select(g => new
                    {
                        g.Key.MaLph,
                        g.Key.TenLph,
                        SoLuot = g.Count()
                    })
                    .OrderByDescending(x => x.SoLuot)
                    .ToList();

                var topDatNhieu = luotDatTheoLoai.FirstOrDefault();
                lblTopLoaiPhongDatNhieu.Text = topDatNhieu != null && topDatNhieu.SoLuot > 0
                    ? $"{topDatNhieu.TenLph} ({topDatNhieu.SoLuot} lượt)"
                    : "Chưa có dữ liệu";

                // Top 3: Dịch vụ doanh thu cao nhất
                var doanhThuTheoDichVu = dsDichVuTrongKy
                    .GroupBy(v => new { v.MaDv, v.TenDv })
                    .Select(g => new
                    {
                        g.Key.MaDv,
                        g.Key.TenDv,
                        SoLuong = g.Sum(x => x.Sl),
                        DoanhThu = g.Sum(x => x.ThanhTien)
                    })
                    .OrderByDescending(x => x.DoanhThu)
                    .ThenByDescending(x => x.SoLuong)
                    .ToList();

                var topDichVu = doanhThuTheoDichVu.FirstOrDefault();
                lblTopDichVu.Text = topDichVu != null && topDichVu.DoanhThu > 0
                    ? $"{topDichVu.TenDv} ({DinhDangTien(topDichVu.DoanhThu)})"
                    : "Chưa có dữ liệu";

                // Biểu đồ tròn: Các dịch vụ được sử dụng
                VeBieuDoDichVu(doanhThuTheoDichVu
                    .Select(d => (d.TenDv, d.SoLuong, d.DoanhThu))
                    .Where(d => d.SoLuong > 0)
                    .ToList());

                // Biểu đồ cột: Doanh thu thuê phòng theo loại phòng
                var doanhThuMap = doanhThuTheoLoai.ToDictionary(x => x.MaLph, x => x.DoanhThu);
                var duLieuDoanhThuCot = loaiPhongs
                    .Select(lp => (lp.TenLph, doanhThuMap.TryGetValue(lp.MaLph, out decimal dt) ? dt : 0m))
                    .ToList();
                VeBieuDoDoanhThuPhong(duLieuDoanhThuCot);

                // Biểu đồ cột: Số phòng được đặt theo loại phòng
                var luotDatMap = luotDatTheoLoai.ToDictionary(x => x.MaLph, x => x.SoLuot);
                var duLieuSoPhongCot = loaiPhongs
                    .Select(lp => (lp.TenLph, luotDatMap.TryGetValue(lp.MaLph, out int sl) ? sl : 0))
                    .ToList();
                VeBieuDoSoPhongDat(duLieuSoPhongCot);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu thống kê: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string DinhDangTien(decimal soTien)
        {
            return soTien.ToString("N0", _viVN) + " VND";
        }

        private void VeBieuDoDichVu(List<(string TenDv, int SoLuong, decimal DoanhThu)> duLieu)
        {
            var series = chartDichVu.Series["DichVu"];
            series.Points.Clear();
            chartDichVu.Titles.Clear();

            if (duLieu.Count == 0)
            {
                chartDichVu.Titles.Add(new Title("Không có dịch vụ được sử dụng trong khoảng thời gian này",
                    Docking.Top, new Font("Segoe UI", 10F, FontStyle.Italic), Color.Gray));
                return;
            }

            foreach (var item in duLieu)
            {
                int index = series.Points.AddXY(item.TenDv, item.SoLuong);
                var diem = series.Points[index];
                diem.LegendText = item.TenDv;
                diem.Label = string.Empty;
                diem.ToolTip = $"{item.TenDv}: {item.SoLuong} lượt ({DinhDangTien(item.DoanhThu)})";
            }
        }

        private void VeBieuDoDoanhThuPhong(List<(string TenLph, decimal DoanhThu)> duLieu)
        {
            var series = chartDoanhThuPhong.Series["Doanh thu theo loại phòng"];
            series.Points.Clear();
            chartDoanhThuPhong.Titles.Clear();

            var area = chartDoanhThuPhong.ChartAreas["ChartAreaDoanhThu"];
            area.AxisY.LabelStyle.Format = "N0";
            area.AxisX.Interval = 1;

            if (duLieu.Count == 0 || duLieu.All(d => d.DoanhThu == 0))
            {
                area.AxisY.Maximum = 1000000;
            }
            else
            {
                area.AxisY.Maximum = double.NaN;
            }

            foreach (var item in duLieu)
            {
                int index = series.Points.AddXY(item.TenLph, (double)item.DoanhThu);
                series.Points[index].ToolTip = $"{item.TenLph}: {DinhDangTien(item.DoanhThu)}";
            }
        }

        private void VeBieuDoSoPhongDat(List<(string TenLph, int SoLuot)> duLieu)
        {
            var series = chartSoPhongDat.Series["Số lượng đặt"];
            series.Points.Clear();
            chartSoPhongDat.Titles.Clear();

            var area = chartSoPhongDat.ChartAreas["ChartAreaSoPhong"];
            area.AxisX.Interval = 1;
            area.AxisY.LabelStyle.Format = "N0";

            int max = duLieu.Count == 0 ? 0 : duLieu.Max(d => d.SoLuot);
            if (max == 0)
            {
                area.AxisY.Maximum = 4;
                area.AxisY.Interval = 1;
            }
            else if (max <= 10)
            {
                area.AxisY.Maximum = double.NaN;
                area.AxisY.Interval = 1;
            }
            else
            {
                area.AxisY.Maximum = double.NaN;
                area.AxisY.Interval = double.NaN;
            }

            foreach (var item in duLieu)
            {
                int index = series.Points.AddXY(item.TenLph, item.SoLuot);
                series.Points[index].ToolTip = $"{item.TenLph}: {item.SoLuot} lượt";
            }
        }
    }
}
