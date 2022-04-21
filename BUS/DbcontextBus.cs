using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class DbcontextBus
    {
        private static DbcontextBus _instance = null;
        public static DbcontextBus Instance => _instance ?? (_instance = new DbcontextBus());
        public bool Login(string loginName, string password, string chinhanh, int chinhanhID)
        {
            dbContext.Instance.login(loginName, password, chinhanh, chinhanhID);
            return true;
        }

        public List<Chinhanh> chinhanhs ()
        {
            return dbContext.Instance.GetChinhanhs();
        }
    }
}
