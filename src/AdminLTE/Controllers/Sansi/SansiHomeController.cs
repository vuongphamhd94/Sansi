using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.Controllers.Sansi
{
    public class SansiHomeController : Controller
    {
        public IActionResult Index()
        {
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
    }
}
