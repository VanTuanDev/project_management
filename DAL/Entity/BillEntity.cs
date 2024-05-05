namespace DAL.Entity
{
    public class BillEntity
    {
        public int id { get; set; }
        public string customerid { get; set; }
        public string status { get; set; }
        public DateTime time { get; set; }
    }
}