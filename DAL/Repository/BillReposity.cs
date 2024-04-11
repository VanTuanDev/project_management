using System.Data;
using DAL.Entity;

namespace DAL.Repository
{
    public class BillReposity
    {
        public static BillReposity instance;
        public static BillReposity Instance
        {
            get { if (instance == null) instance = new BillReposity(); return instance; }
            private set { instance = value; }
        }
        private BillReposity() { }

        public DataTable GetBill()
        {
            string query = "GetBill";

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
