using DAL.Repository;
using System.Data;
using System.Text;
using DAL.Entity;

namespace BLL.Manager
{
    public class BillManager
    {
        private BillReposity billDAL;
        public BillManager()
        {
            billDAL = BillReposity.Instance;
        }
        public DataTable GetBill()
        {
            return billDAL.GetBill();
        }
    }
}
