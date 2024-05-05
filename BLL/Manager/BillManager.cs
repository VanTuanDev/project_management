using DAL.Entity;
using DAL.Repository;
using System.Data;
using System.Diagnostics;

namespace BLL.Manager
{
    public class BillManager
    {
        private BillRepository Process = null;
        public BillManager()
        {
            Process = new BillRepository();
        }
        public System.Data.DataTable GetListBills()
        {
            return Process.GetListBills();
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
        public DataTable GetInfomation(BillEntity bill)
        {
            return Process.GetInfomation(bill);
        }
        public DataTable GetBillDetail(BillDetailEntity billdetail)
        {
            return Process.GetBillDetail(billdetail);
        }
    }
}
