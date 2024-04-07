using System.Data;
using DAL.Entity;

namespace DAL.Repository
{
    public class CustomerRepository
    {
        public static CustomerRepository instance;
        public static CustomerRepository Instance
        {
            get { if (instance == null) instance = new CustomerRepository(); return instance; }
            private set { instance = value; }
        }
        private CustomerRepository() { }
        public DataTable GetClients()
        {
            string query = "GetClients";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool DeleteClient(CustomerEntity entity)
        {
            string query = "DeleteClient @ClientID ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { entity.id });
            return result > 0;
        }
        public bool InsertClient(CustomerEntity entity)
        {
            string query = "InsertClient @ClientId , @ClientName , @ClientAddress , @ClientPhone";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { entity.id, entity.fullname, entity.address, entity.phonenumber });
            return result > 0;
        }
        public bool UpdateClient(CustomerEntity entity)
        {
            string query = "UpdateClient @ClientId , @NewClientName , @NewClientAddress , @NewClientPhone";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { entity.id, entity.fullname, entity.address, entity.phonenumber });
            return result > 0;
        }
    }
}