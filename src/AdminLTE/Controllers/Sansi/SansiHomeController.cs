using AdminLTE.Models.SansiModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AdminLTE.Data;

namespace AdminLTE.Controllers.Sansi
{
    public class SansiHomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        #region Ctor

        public SansiHomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion
        /// <summary>
        /// Trang chủ san-si
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var t = _dbContext.SanPham.ToList();
            return View();

        }
        public IActionResult IndexQuanLyDonHang()
        {
            return View();
        }
        public IActionResult IndexSuaDon()
        {
            return View();
        }
        public IActionResult IndexCaiDatThayDoiThongTin()
        {
            return View();
        }
        public IActionResult IndexTaoDonHangKyGui()
        {
            return View();
        }
        public IActionResult IndexTimKiemSanPham()
        {
            return View();
        }
        public IActionResult IndexCaiDatDiaChiGiaoHang()
        {
            return View();
        }
        public IActionResult IndexCaiDatThayDoiMatKhau()
        {
            return View();
        }

        //summary
        // danh sách các sản phẩm Sansi
        public JsonResult AddDanhMucSanPham(SanPhamModel data)
        {
            _dbContext.SanPham.Add(data);
            _dbContext.SaveChanges();
            return new JsonResult("");
        }
        public IActionResult IndexDanhMucSanPham(int id)
        {
            var listDanhMucSanPham = new List<DanhMucSanPhamModel>();
            var listSanPham = new List<SanPhamModel>();
            var thoiTrang = new List<SanPhamModel>();
            var theThao = new List<SanPhamModel>();
            var doGiaDung = new List<SanPhamModel>();
            listSanPham.AddRange(_dbContext.SanPham.ToList());

            thoiTrang = listSanPham.Where(x => x.Type == 1).ToList();
            theThao = listSanPham.Where(x => x.Type == 2).ToList();
            doGiaDung = listSanPham.Where(x => x.Type == 3).ToList();

            var danhMucSanPham1 = new DanhMucSanPhamModel
            {
                Id = 1,

                ThoiTrang = thoiTrang,
                DoGiaDung = doGiaDung,
                TheThao = theThao

            };

            listDanhMucSanPham.Add(danhMucSanPham1);

            var danhMucSP = listDanhMucSanPham.FirstOrDefault(x => x.Id == id);
            return View(danhMucSP);
        }
        public IActionResult IndexKhieuNai()
        {
            return View();
        }
        public IActionResult IndexChiTietDonHang()
        {
            return View();
        }
        public IActionResult IndexNhaCungCap()
        {
            return View();
        }
        public IActionResult IndexThemMoiNhaCungCap()
        {
            return View();
        }
        public IActionResult IndexQuanLyDonKyGui()
        {
            return View();
        }
        public IActionResult IndexThanhToan()
        {
            return View();
        }
        public IActionResult IndexTinTuc01()
        {
            return View();
        }
        public IActionResult IndexChiTietTin(int id)
        {
            var lstModel = new List<ChiTietTinModel>();
            var listChiTietTien_DB = _dbContext.ChiTietTin.ToList();
            var listTinMoi_DB = _dbContext.TinMoi.ToList();
            foreach (var item in listChiTietTien_DB)
            {
                item.ListTinMoi = listTinMoi_DB.Where(x => x.ChiTietTinModelId == item.Id).ToList();
            }
            var model = listChiTietTien_DB.FirstOrDefault(x => x.Id == id);

            return View(model);
        }
        public IActionResult IndexTinTuc2()
        {
            return View();
        }
        public IActionResult IndexLichSuGiaoDich()
        {
            return View();
        }
        public IActionResult IndexRutTien()
        {
            return View();
        }
        public IActionResult IndexTaoDonHang()
        {
            return View();
        }
        public IActionResult IndexUuDai()
        {
            return View();
        }
    }
}
