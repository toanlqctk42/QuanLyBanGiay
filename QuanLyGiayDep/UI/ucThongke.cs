using DAO;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiayDep.UI
{
    public partial class ucThongke : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucThongke _instance;
        public static ucThongke Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucThongke();
                return _instance;
            }
        }
        public ucThongke()
        {
            InitializeComponent();
        }

        private void ucThongke_Load(object sender, EventArgs e)
        {
            billsBindingSource.DataSource = dbContext.Instance.GetBills();
            if(WorkingContext.Instance.CurrentLoginInfo.RoleName == "GIAMDOC")
            {
                cbChinhanh.Enabled = true;
            }
            else
            {
                cbChinhanh.Enabled = false;
            }    
        }


        private void cbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            billsBindingSource.DataSource = dbContext.Instance.FilterBills_chinhanhID(cbChinhanh.SelectedIndex + 1);
        }
    }
}
