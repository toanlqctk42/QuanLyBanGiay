using DTO;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace DAO
{
    public class dbContext
    {
        private static dbContext _instance = null;
        public static dbContext Instance => _instance ?? (_instance = new dbContext());

        public void login(string loginName, string password, string chinhanh, int chinhanhID)
        {
            WorkingContext.Instance.CurrentBranch = chinhanh;
            WorkingContext.Instance.CurrentBranchId = chinhanhID;
            WorkingContext.Instance.CurrentLoginName = loginName;
            var connectionName = string.Format("Branch{0}", chinhanhID);
            string connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            connectionString = string.Format(connectionString, loginName, password);
            WorkingContext.Instance.Initialize(connectionString);
            var dbcontext = WorkingContext.Instance._dbContext;
            var loginInfo = dbcontext.Database.SqlQuery<LoginInfoes>("exec sp_getLoginInfo @p0", loginName).FirstOrDefault();
            WorkingContext.Instance.CurrentLoginInfo = loginInfo;
        }

        public List<Chinhanh> GetChinhanhs()
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;

            return tshoesContext.Chinhanh.ToList();
        }
    }
}
