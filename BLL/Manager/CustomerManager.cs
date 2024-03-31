using DAL.Repository;
using System.Data;

namespace BLL.Manager
{
    public class CustomerManager
    {
        private CustomerRepository clientDAL;

        public CustomerManager()
        {
            clientDAL = new CustomerRepository();
        }

        public DataTable GetClients()
        {
            return clientDAL.GetClients();
        }
        public bool DeleteClient(int clientID)
        {
            return clientDAL.DeleteClient(clientID);
        }
        public bool InsertClient(int clientId, string clientName, string clientAddress, string clientPhone)
        {
            return clientDAL.InsertClient(clientId, clientName, clientAddress, clientPhone);
        }
        public bool UpdateClient(int clientId, string newClientName, string newClientAddress, string newClientPhone)
        {
            return clientDAL.UpdateClient(clientId, newClientName, newClientAddress, newClientPhone);
        }
    }
}
