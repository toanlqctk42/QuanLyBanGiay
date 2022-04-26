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
        private ucThongke _instance;
        public ucThongke Instance
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
    }
}
