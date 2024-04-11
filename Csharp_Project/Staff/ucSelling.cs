using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Project.Staff
{
    public partial class ucSelling : UserControl
    {
        public ucSelling()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectCustomer f = new SelectCustomer();
            f.ShowDialog();
        }
    }
}
