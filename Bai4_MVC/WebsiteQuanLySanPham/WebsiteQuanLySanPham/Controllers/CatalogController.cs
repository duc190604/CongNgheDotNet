using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteQuanLySanPham.Models;
namespace WebsiteQuanLySanPham.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            string connectionString = "LAPTOP-M863II0B\\SQLEXPRESS";
            QuanLySanPhamDataContext context= new QuanLySanPhamDataContext(connectionString);
            List<Catalog> dsCatalog= context.Catalogs.ToList();
            return View(dsCatalog);
        }
    }
}