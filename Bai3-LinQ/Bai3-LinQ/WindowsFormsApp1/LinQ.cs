using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class LinQ
    {
        public static List<Product> findPriceHighest(List<Product> list)
        {
            if(list!=null && list.Any()) {
                var result= (from p in list
                            orderby p.Gia descending
                            select p).FirstOrDefault();
                
                return new List<Product>() { (Product)result };
            }
            return new List<Product>();
        }
        public static int countEndDate(List<Product> list)
        {
            if(list!=null && list.Any())
            {
                var result = from p in list
                             where DateTime.Parse(p.NgayHH) < DateTime.Now
                             select p;  
                return result.Count();         
            }    
            return 0;
        }
        public static List<Product> deleteAllEndDate(List<Product> list)
        {
            if(list!=null && list.Any())
            {
                var result = from p in list
                             where DateTime.Parse(p.NgayHH) >= DateTime.Now
                             select p;
                return result.ToList();
            }
            return list;
        }
        public static List<Product> showEndDate(List<Product> list)
        {
            if (list != null && list.Any())
            {
                var result = from p in list
                             where DateTime.Parse(p.NgayHH) < DateTime.Now
                             select p;
                return result.ToList();
            }
            return null;
        }
        public static List<Product> deleteOrigin(List<Product> list, string origin) {
            if(list!=null && list.Any())
            {
                var result = from p in list
                             where !p.Xs.Equals(origin)
                             select p;
                return result.ToList();
            }
            return null;
        }
        public static Product findJapan(List<Product> list)
        {
            if (list != null && list.Any())
            {
                var result = (from p in list
                             where p.Xs.Equals("Nhật Bản")
                             select p).FirstOrDefault();
                return (Product)result;
            }
               return null;
        }
        public static List<Product> showFollowPrice(List<Product> list,int  a, int b)
        {
            if(list!=null && list.Any())
            {
                var result = from p in list
                             where p.Gia>=a && p.Gia<=b
                             select p;
                return result.ToList();
            }
            return null;
        }
    }
}
