using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Manager
{
    public class ClientManager
    {
        private ClientRepository clientDAL;

        public ClientManager()
        {
            clientDAL = new ClientRepository();
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
