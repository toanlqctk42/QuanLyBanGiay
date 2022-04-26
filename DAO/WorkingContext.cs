using DTO;

namespace DAO
{
    public sealed class WorkingContext
    {

        private static WorkingContext _instance = null;
        public static WorkingContext Instance => _instance ?? (_instance = new WorkingContext());
        public TshoesContext _dbContext = null;

        private string _currentConnectionString;
        public LoginInfoes CurrentLoginInfo { get; set; }
        public string CurrentBranch { get; set; }
        public int CurrentBranchId { get; set; }
        public string CurrentLoginName { get; set; }

        private WorkingContext()
        {

        }
        public void Initialize (string connectionString)
        {
            _currentConnectionString = connectionString;
            _dbContext = new TshoesContext(_currentConnectionString);
        }

        public void Clear()
        {
            _currentConnectionString = "";
            CurrentLoginInfo = null;
            CurrentBranch = "";
            _dbContext = null;
        }
    }
}
