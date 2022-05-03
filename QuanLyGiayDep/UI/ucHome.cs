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
    public partial class ucHome : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucHome _instance;
        public static ucHome Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucHome();
                return _instance;
            }
        }
        public ucHome()
        {
            InitializeComponent();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            chiTietSanPhamBindingSource.DataSource = dbContext.Instance.GetchiTietSanPhams();
        }
    }
}
