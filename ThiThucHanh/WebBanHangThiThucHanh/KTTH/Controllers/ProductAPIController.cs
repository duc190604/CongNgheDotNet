using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KTTH.Models;
using KTTH.Models.ProductModels;
namespace KTTH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        QLBHContext db=new QLBHContext();
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            var sanPham = (from p in db.TDanhMucSps
                           select new Product
                           {
                               MaSp = p.MaSp,
                               TenSp = p.TenSp,
                               Gia = p.Gia,
                               AnhDaiDien = p.AnhDaiDien,
                               
                               
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
                               Gia = p.Gia,
                               AnhDaiDien = p.AnhDaiDien,
                               
                             
                           }).ToList();
            return sanPham;
        }
    }
}
