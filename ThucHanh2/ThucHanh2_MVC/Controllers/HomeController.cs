using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using ThucHanh2_MVC.Models;
using ThucHanh2_MVC.Models.Authentication;
using ThucHanh2_MVC.ViewModels;
using X.PagedList;

namespace ThucHanh2_MVC.Controllers
{
    public class HomeController : Controller
    {
        QLBanVaLiContext db= new QLBanVaLiContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //[Authentication]
        public IActionResult Index(int?page)
        {
            int pageSize = 8;
            int pageNumber=page==null||page<0?1:page.Value;
            var lstsanpham= db.TDanhMucSps.AsNoTracking().OrderBy(x=>x.TenSp);
            PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult SanPhamTheoLoai(string maloai, int?page)  
        {
			int pageSize = 8;
			int pageNumber = page == null || page < 0 ? 1 : page.Value;
			var lstsanpham = db.TDanhMucSps.AsNoTracking().Where(x=>x.MaLoai==maloai).OrderBy(x => x.TenSp);
			PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(lstsanpham, pageNumber, pageSize);
            ViewBag.maloai=maloai;
			return View(lst);
		}
        public IActionResult ChiTietSanPham(string masp)
        {
            var sanPham = db.TDanhMucSps.SingleOrDefault(x => x.MaSp == masp);
            var anhSanPham = db.TAnhSps.Where(x => x.MaSp == masp).ToList();
            var chiTietSanPhamViewModel = new ChiTietSanPhamViewModel { danhMucSp = sanPham, anhMucSp = anhSanPham };
            return View(chiTietSanPhamViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}