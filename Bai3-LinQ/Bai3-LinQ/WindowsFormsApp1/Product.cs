using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Product
    {
        // Các biến private
        private string _maSP;
        private string _tenSP;
        private int _SL;
        private int _gia;
        private string _xs;
        private string _ngayHH;

        // Các thuộc tính (properties) với getter và setter
        public string MaSP
        {
            get { return _maSP; }
            set { _maSP = value; }
        }

        public string TenSP
        {
            get { return _tenSP; }
            set { _tenSP = value; }
        }

        public int SL
        {
            get { return _SL; }
            set { _SL = value; }
        }

        public int Gia
        {
            get { return _gia; }
            set { _gia = value; }
        }

        public string Xs
        {
            get { return _xs; }
            set { _xs = value; }
        }

        public string NgayHH
        {
            get { return _ngayHH; }
            set { _ngayHH = value; }
        }

        // Constructor để khởi tạo Product với các giá trị
        public Product(string maSP, string tenSP, int SL, int gia, string xs, string ngayHH)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.SL = SL;
            this.Gia = gia;
            this.Xs = xs;
            this.NgayHH = ngayHH;
        }
    }

}
