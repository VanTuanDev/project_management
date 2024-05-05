using DAL.Entity;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Repository
{
    public class SellingRepository
    {
        private DataProvider database = new DataProvider();

        public string GetProductId(ProductEntity product)
        {
            string maSanPham = null;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@productName", product.name)
            };

            maSanPham = database.ExecuteScalarStoredProcedure("GetProductId", parameters);

            return maSanPham;
        }
        public string GetCustomerId(CustomerEntity customer)
        {
            string maKhachHang = null;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@customerName", customer.fullname)
            };

            maKhachHang = database.ExecuteScalarStoredProcedure("GetCustomerId", parameters);

            return maKhachHang;
        }

        public int CreateBill(BillEntity bill)
        {
            SqlParameter[] parameters = new SqlParameter[4]
            {
                new SqlParameter("@customerid", bill.customerid),
                new SqlParameter("@status", bill.status),
                new SqlParameter("@time", bill.time),
                new SqlParameter("@id", SqlDbType.Int) { Direction = ParameterDirection.Output }
            };

            database.ExecuteNonQuery("CreateBill", parameters);

            int maHoaDon = Convert.ToInt32(parameters[3].Value);
            return maHoaDon;
        }

        public void CreateBillDetail(BillDetailEntity billdetail)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@billid", billdetail.billid),
                new SqlParameter("@itemid", billdetail.itemid),
                new SqlParameter("@quantity", billdetail.quantity),
                new SqlParameter("@total", billdetail.total)
            };

            database.ExecuteNonQuery("CreateBillDetail", parameters);
        }
    }
}
