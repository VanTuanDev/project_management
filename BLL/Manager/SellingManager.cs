using System.Diagnostics;
using DAL.Entity;
using DAL.Repository;

namespace BLL.Manager
{
    public class SellingManager
    {
        private SellingRepository Process = null;
        public SellingManager()
        {
            Process = new SellingRepository();
        }
        public int CreateBill(BillEntity bill)
        {
            return Process.CreateBill(bill);
        }
        public void CreateBillDetail(BillDetailEntity billdetail)
        {
            Process.CreateBillDetail(billdetail);
        }
        public string GetProductId(ProductEntity product)
        {
            return Process.GetProductId(product);
        }
        public string GetCustomerId(CustomerEntity customer)
        {
            return Process.GetCustomerId(customer);
        }
        public void UpdateStatusBill(int maHoaDon, string tinhTrang)
        {
            BillEntity hoaDon = new BillEntity
            {
                id = maHoaDon,
                status = tinhTrang
            };

            Process.UpdateStatusBill(hoaDon);
        }
    }
}
