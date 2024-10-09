using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteQuanLySanPham.Models;

namespace WebsiteQuanLySanPham.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            string connectionString = "LAPTOP-M863II0B\\SQLEXPRESS";
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext(connectionString);
            List<Product> dsProduct = context.Products.ToList();
            return View(dsProduct);
        }
    }
}