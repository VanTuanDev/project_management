using BLL.Manager;
using System.Data;
using DAL.Entity;
using System.Security.Principal;

namespace Csharp_Project.Staff
{
    public partial class ucBillManager : UserControl
    {
        private BillManager billBLL;
        public ucBillManager()
        {
            billBLL = new BillManager();
            InitializeComponent();
        }

        private void ucBillManager_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
