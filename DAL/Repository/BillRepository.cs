using DAL.Entity;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Repository
{
    public class BillRepository
    {
        private DataProvider database = new DataProvider();
        public DataTable GetListBills()
        {
            SqlParameter[] parameters = null;
            return database.ExecuteQuery2("GetListBills", parameters);
        }

        public void UpdateStatusBill(BillEntity bill)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", bill.id),
                new SqlParameter("@status", bill.status)
            };

            database.ExecuteNonQuery("UpdateStatusBill", parameters);
        }
        public DataTable GetCustomerName(BillEntity bill)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", bill.id)
            };

            return database.ExecuteQuery2("GetCustomerName", parameters);
        }
        public DataTable GetBillDetail(BillDetailEntity billdetail)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@billid", billdetail.billid)
            };

            return database.ExecuteQuery2("GetBillDetail", parameters);
        }
    }
}
