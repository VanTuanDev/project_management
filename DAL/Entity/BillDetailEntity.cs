namespace DAL.Entity
{
    public class BillDetailEntity
    {
        public int id { get; set; }
        public int billid { get; set; }
        public string itemid { get; set; }
        public int quantity { get; set; }
        public decimal total { get; set; }
    }
}
