using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KTTH.Models;
using X.PagedList;
using KTTH.Areas.Admin.Data;
namespace KTTH.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeadmin")]
    public class HomeAdminController : Controller
    {
        QLBHContext db= new QLBHContext();
        [Route("")]
         [Route("index")]
        public IActionResult Index()
        {
            // Lấy tổng số sản phẩm
            int totalProducts = db.TDanhMucSps.Count();

            // Lấy số lượng sản phẩm theo từng loại
            var productsByCategory = db.TDanhMucSps
                .GroupBy(p => p.MaLoai)
                .Select(g => new CategoryProductCount
                {
                    MaLoai = g.Key,
                    SoLuong = g.Count()
                })
                .ToList(); // Sử dụng ToList() thay vì ToListAsync() trong một phương thức đồng bộ

            // Khởi tạo ViewModel và truyền dữ liệu
            var viewModel = new ProductStatisticsViewModel
            {
                TotalProducts = totalProducts,
                ProductsByCategory = productsByCategory
            };

            return View(viewModel);
        }

        [Route("danhmucsanpham")]
        public IActionResult DanhMucSanPham(int? page)
        {
            int pageSize = 15;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstsanpham = db.TDanhMucSps.AsNoTracking().OrderBy(x => x.TenSp);
            PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }
        [Route("quanlykhachhang")]
        public IActionResult QuanLyKhachHang(int? page)
        {
            int pageSize = 15;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstsanpham = db.TUsers.AsNoTracking().Where(x=>x.LoaiUser==1).OrderBy(x => x.Username);
            PagedList<TUser> lst = new PagedList<TUser>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }
        [Route("xoakhachhang")]
        [HttpGet]
        public IActionResult XoaKhachHang(string userName)
        {
            TempData["Message"] = "";
            db.Remove(db.TUsers.Find(userName));
            db.SaveChanges();
            TempData["Message"] = "Khách hàng đã được xóa";
            return RedirectToAction("quanlykhachhang", "homeadmin");
        }
        [Route("chitietsanpham")]
        public IActionResult ChiTietSanPham(string maSp)
        {
            var sanPham = db.TDanhMucSps.Find(maSp);
            ViewBag.MaLoai = new SelectList(db.TLoaiSps.ToList(), "MaLoai", "Loai");
            return View(sanPham);
        }
        [Route("themsanphammoi")]
        [HttpGet]
        public IActionResult ThemSanPhamMoi()
        {
            ViewBag.MaLoai = new SelectList(db.TLoaiSps.ToList(), "MaLoai", "Loai");

            return View(); 
        }
        [Route("themsanphammoi")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemSanPhamMoi(TDanhMucSp sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Add(sanPham);
                db.SaveChanges();
                return RedirectToAction("danhmucsanpham");
            }
            return View(sanPham);
        }

        [Route("suasanpham")]
        [HttpGet]
        public IActionResult SuaSanPham(string maSp)
        {
            
            var sanPham= db.TDanhMucSps.Find(maSp);
            ViewBag.MaLoai = new SelectList(db.TLoaiSps.ToList(), "MaLoai", "Loai");
            return View(sanPham);
        }
        [Route("suasanpham")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaSanPham(TDanhMucSp sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("danhmucsanpham");
            }
            return View(sanPham);
        }
        [Route("xoasanpham")]
        [HttpGet]
        public IActionResult XoaSanPham(string maSp)
        {
            TempData["Message"] = "";
           
           
            db.Remove(db.TDanhMucSps.Find(maSp));
            db.SaveChanges();
            TempData["Message"] = "Sản phẩm đã được xóa";
            return RedirectToAction("danhmucsanpham", "homeadmin");
        }
    }
}
