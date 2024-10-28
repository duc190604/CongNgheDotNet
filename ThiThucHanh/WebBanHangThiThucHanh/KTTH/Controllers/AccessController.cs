using Microsoft.AspNetCore.Mvc;
using KTTH.Models;

namespace KTTH.Controllers
{
    public class AccessController : Controller
    {
        QLBHContext db = new QLBHContext();
        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult Login(TUser user)
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                var u = db.TUsers.Where(x => x.Username.Equals(user.Username) && x.Password.Equals(user.Password)).FirstOrDefault();
                if (u != null)
                {
                    HttpContext.Session.SetString("UserName", u.Username.ToString());
                    if (u.LoaiUser == 0)
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    
                }
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("UserName");
            return RedirectToAction("Login", "Access");
        }

        //register
        [HttpGet]
        public IActionResult Register()
        {
           
                return View();
         
        
        }
        [HttpPost]
        public IActionResult Register(TUser user)
        {
           
                // Kiểm tra xem người dùng đã tồn tại trong cơ sở dữ liệu chưa
                var existingUser = db.TUsers.FirstOrDefault(x => x.Username.Equals(user.Username));
                if (existingUser != null)
                {
                TempData["Message"] = "Đã tồn tại!";
                return View(user);
                }

                // Thiết lập LoaiUser mặc định là 0 (admin)
                user.LoaiUser = 1;

                // Thêm người dùng mới vào cơ sở dữ liệu
                db.TUsers.Add(user);
                db.SaveChanges();

                // Đặt session sau khi đăng ký thành công
                HttpContext.Session.SetString("UserName", user.Username);
           

            
                    return RedirectToAction("Index", "Home"); 
        }
    }
}
