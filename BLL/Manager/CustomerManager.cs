using DAL.Entity;
using DAL.Repository;
using System.Data;

namespace BLL.Manager
{
    public class CustomerManager
    {
        private CustomerRepository clientDAL;

        public CustomerManager()
        {
            clientDAL = CustomerRepository.Instance;
        }

        public DataTable GetClients()
        {
            return clientDAL.GetClients();
        }
        public bool DeleteClient(CustomerEntity entity)
        {
            return clientDAL.DeleteClient(entity);
        }
        public bool InsertClient(CustomerEntity entity, ref string error)
        {
            return clientDAL.InsertClient(entity, ref error);
        }
        public bool UpdateClient(CustomerEntity entity)
        {
            return clientDAL.UpdateClient(entity);
        }
    }
}
