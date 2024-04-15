namespace DAL.Entity
{
    public class ProductEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public decimal price { get; set; }
        public int cateid { get; set; }
        public string status { get; set; }
    }
}
