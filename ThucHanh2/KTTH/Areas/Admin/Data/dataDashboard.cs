namespace KTTH.Areas.Admin.Data
{
    public class CategoryProductCount
    {
        public string MaLoai { get; set; } = string.Empty;
        public int SoLuong { get; set; }
    }

    public class ProductStatisticsViewModel
    {
        public int TotalProducts { get; set; }
        public List<CategoryProductCount> ProductsByCategory { get; set; } = new List<CategoryProductCount>();
    }
}
