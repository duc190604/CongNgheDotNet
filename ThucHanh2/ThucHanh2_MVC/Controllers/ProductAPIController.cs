using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThucHanh2_MVC.Models;
using ThucHanh2_MVC.Models.ProductModels;
namespace ThucHanh2_MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        QLBanVaLiContext db=new QLBanVaLiContext();
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            var sanPham = (from p in db.TDanhMucSps
                           select new Product
                           {
                               MaSp = p.MaSp,
                               TenSp = p.TenSp,
                               GiaLonNhat = p.GiaLonNhat,
                               GiaNhoNhat = p.GiaNhoNhat,
                               AnhDaiDien = p.AnhDaiDien,
                               CanNang = p.CanNang,
                               DoNoi = p.DoNoi,
                           }).ToList();
            return sanPham;
        }
        [HttpGet("{maloai}")]
        public IEnumerable<Product> GetProductsByCategory(string maloai)
        {
            var sanPham = (from p in db.TDanhMucSps
                           where p.MaLoai == maloai
                           select new Product
                           {
                               MaSp = p.MaSp,
                               TenSp = p.TenSp,
                               GiaLonNhat = p.GiaLonNhat,
                               GiaNhoNhat = p.GiaNhoNhat,
                               AnhDaiDien = p.AnhDaiDien,
                               CanNang = p.CanNang,
                               DoNoi = p.DoNoi,
                           }).ToList();
            return sanPham;
        }
    }
}
