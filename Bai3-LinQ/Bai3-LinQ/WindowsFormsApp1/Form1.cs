using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string maSP;
        string tenSP;
        int SL;
        int gia;
        string xs;
        DateTime ngayHH;
        List<Product> list= new List<Product>();
        int min=0, max=0;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load_1(object sender, EventArgs e)
        {
            InitializeListView();
        }
        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Mã SP", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Tên SP", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Số lượng", 80, HorizontalAlignment.Right);
            listView1.Columns.Add("Giá", 100, HorizontalAlignment.Right);
            listView1.Columns.Add("Xuất xứ", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Ngày hết hạn", 150, HorizontalAlignment.Left);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView2.View = View.Details;
            listView2.Columns.Add("Mã SP", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Tên SP", 150, HorizontalAlignment.Left);
            listView2.Columns.Add("Số lượng", 80, HorizontalAlignment.Right);
            listView2.Columns.Add("Giá", 100, HorizontalAlignment.Right);
            listView2.Columns.Add("Xuất xứ", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Ngày hết hạn", 150, HorizontalAlignment.Left);
            listView2.FullRowSelect = true;
            listView2.GridLines = true;

            ngayHHtb.Value=DateTime.Now;
           
        }

        private void maSPtb_TextChanged(object sender, EventArgs e)
        {
            maSP = (string) maSPtb.Text;
        }

        private void tenSPtb_TextChanged(object sender, EventArgs e)
        {
            tenSP = (string) tenSPtb.Text;
        }

        private void SLtb_TextChanged(object sender, EventArgs e)
        {
           string temp= SLtb.Text;
            if(int.TryParse(temp,out int ok))
            {
               if(ok>=0)
                {
                    SL = (int)ok;
                }
                else
                {
                    SLtb.Text = "0";
                    MessageBox.Show("Chỉ nhập số nguyên dương");
                }
            }
            else
            {
                SLtb.Text = "0";
                MessageBox.Show("Chỉ nhập số nguyên dương");    
            }
        }

        private void giatb_TextChanged(object sender, EventArgs e)
        {
            string temp = giatb.Text;
            if (int.TryParse(temp, out int ok))
            {
                if (ok >= 0)
                {
                    gia = (int)ok;
                }
                else
                {
                    giatb.Text = "0";
                    MessageBox.Show("Chỉ nhập số nguyên dương");
                }
            }
            else
            {
                giatb.Text = "0";
                MessageBox.Show("Chỉ nhập số nguyên dương");
            }
        }

        private void XStb_TextChanged(object sender, EventArgs e)
        {
            xs=XStb.Text;
        }

        private void ngayHHtb_ValueChanged(object sender, EventArgs e)
        {
            ngayHH=ngayHHtb.Value;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

            Product newprd;
            try
            {
                newprd = new Product(maSP, tenSP, SL, gia, xs, ngayHH.ToString());
                if (list.Any(p => p.MaSP == maSP))
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại. Vui lòng nhập mã sản phẩm khác.");
                    return; // Ngừng thực hiện nếu mã đã tồn tại
                }
                list.Add(newprd);
                showList(list, listView1);

            }
            catch {
                MessageBox.Show("Nhập sai thông tin sản phẩm");
            }
        }
        public void showList(List<Product> lista,ListView view)
        {
            view.Items.Clear();
            if(list!=null && list.Count>0)
            {
                  foreach (var product in lista)
                {
                    ListViewItem item = new ListViewItem(product.MaSP);
                    item.SubItems.Add(product.TenSP);
                    item.SubItems.Add(product.SL.ToString());
                    item.SubItems.Add(product.Gia.ToString());
                    item.SubItems.Add(product.Xs);
                    item.SubItems.Add(product.NgayHH);
                    view.Items.Add(item);
                }
            }
            
        }

        private void giaCaoNhat_Click(object sender, EventArgs e)
        {
            showList(LinQ.findPriceHighest(list), listView2);
        }

        private void tuNhat_Click(object sender, EventArgs e)
        {
            Product temp = LinQ.findJapan(list);
            if(temp!=null)
            {
                showList(new List<Product> { temp }, listView2);
                return;
            }    
            listView2.Items.Clear();
        }

        private void xuatQuaHan_Click(object sender, EventArgs e)
        {
            showList(LinQ.showEndDate(list), listView2);
        }

        private void xuatTheoGia_Click(object sender, EventArgs e)
        {
            showList(LinQ.showFollowPrice(list,min,max), listView2);
            minPrice.Text = "0";
            maxPrice.Text = "0";
            min = 0;
            max = 0;
        }

        private void minPrice_TextChanged(object sender, EventArgs e)
        {
            string temp = minPrice.Text;
            if (int.TryParse(temp, out int ok))
            {
                if (ok >= 0)
                {
                    min = (int)ok;
                }
                else
                {
                    minPrice.Text = "0";
                    min = 0;
                    MessageBox.Show("Chỉ nhập số nguyên dương");
                }
            }
            else
            {
                minPrice.Text = "0";
                min = 0;
                MessageBox.Show("Chỉ nhập số nguyên dương");
            }
        }

       

        private void checkDate_Click(object sender, EventArgs e)
        {
            int temp=LinQ.countEndDate(list);
            if(temp!=null && temp>0)
            {
                MessageBox.Show("Có "+ temp+ " sản phẩm quá hạn");
            }
            else
            {
                MessageBox.Show("Có " + 0+ " sản phẩm");
            }
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            list.Clear();
            showList(list, listView1);
            MessageBox.Show("Đã xóa tất cả sản phẩm");
        }

        private void deletEndDate_Click(object sender, EventArgs e)
        {
            list= LinQ.deleteAllEndDate(list);
            showList(list, listView1);
            MessageBox.Show("Xóa thành công");
        }

        private void xoaTheoXS_Click(object sender, EventArgs e)
        {
            if(xsXoa.Text!=null)
            {
                list = LinQ.deleteOrigin(list, xsXoa.Text);
                showList(list, listView1);
            }
            xsXoa.Text = null;    
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy item được chọn
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Lấy dữ liệu từ item
                maSP = selectedItem.SubItems[0].Text; // Mã sản phẩm
                tenSP = selectedItem.SubItems[1].Text; // Tên sản phẩm
                SL = int.Parse(selectedItem.SubItems[2].Text);
                gia = int.Parse(selectedItem.SubItems[3].Text);
                xs= selectedItem.SubItems[4].Text;
                ngayHH = DateTime.Parse(selectedItem.SubItems[5].Text);
                maSPtb.Text = maSP;
                tenSPtb.Text = tenSP;
                SLtb.Text=SL.ToString();
                giatb.Text = gia.ToString();
                XStb.Text = xs.ToString();
                ngayHHtb.Value = (DateTime)ngayHH;
            }
        }

        private void editProduct_Click(object sender, EventArgs e)
        {
            var productToUpdate = list.FirstOrDefault(p => p.MaSP == maSP);

            // Kiểm tra xem sản phẩm có tồn tại hay không
            if (productToUpdate != null)
            {
                // Cập nhật thông tin sản phẩm
                productToUpdate.TenSP = tenSP;
                productToUpdate.SL = SL;
                productToUpdate.Gia = gia;
                productToUpdate.Xs = xs;
                productToUpdate.NgayHH = ngayHH.ToString();

                // Hiển thị thông báo thành công
                MessageBox.Show("Sản phẩm đã được sửa thành công!");

                // Cập nhật giao diện (nếu cần)
                showList(list, listView1);
            }
            else
            {
                // Hiển thị thông báo nếu không tìm thấy sản phẩm
                MessageBox.Show("Không tìm thấy sản phẩm với mã: " + maSP);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            var productToRemove = list.FirstOrDefault(p => p.MaSP == maSP);

            // Kiểm tra xem sản phẩm có tồn tại hay không
            if (productToRemove != null)
            {
                // Xóa sản phẩm khỏi danh sách
                list.Remove(productToRemove);

                // Hiển thị thông báo thành công
                MessageBox.Show("Sản phẩm đã được xóa thành công!");

                showList(list, listView1);
            }
            else
            {
                // Hiển thị thông báo nếu không tìm thấy sản phẩm
                MessageBox.Show("Không tìm thấy sản phẩm với mã: " + maSP);
            }
        }

        private void maxPrice_TextChanged(object sender, EventArgs e)
        {
            string temp = maxPrice.Text;
            if (int.TryParse(temp, out int ok))
            {
                if (ok >= 0)
                {
                    max = (int)ok;
                }
                else
                {
                    maxPrice.Text = "0";
                    max = 0;
                    MessageBox.Show("Chỉ nhập số nguyên dương");
                }
            }
            else
            {
                maxPrice.Text = "0";
                max = 0;
                MessageBox.Show("Chỉ nhập số nguyên dương");
            }
        }
    }
}
