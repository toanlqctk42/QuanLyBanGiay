using DAO;
using QuanLyGiayDep.UI;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyGiayDep
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form1();
                return _instance;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tsslLoginName.Text ="|Tên đăng nhập : "+ WorkingContext.Instance.CurrentLoginName;
            tsslChinhanh.Text = "|Chi nhánh : "+WorkingContext.Instance.CurrentBranch;
            tsslNhom.Text = "|Nhóm : "+WorkingContext.Instance.CurrentLoginInfo.RoleName;
            acehome_Click(sender,e);
        }

        private void acenhanvien_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucNhanvien.Instance))
            {
                container.Controls.Add(ucNhanvien.Instance);
                ucNhanvien.Instance.Dock = DockStyle.Fill;
                ucNhanvien.Instance.BringToFront();
            }
            ucNhanvien.Instance.BringToFront();
        }

        private void aceThongke_Click(object sender, EventArgs e)
        {

        }

        private void acesanpham_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucSanpham.Instance))
            {
                container.Controls.Add(ucSanpham.Instance);
                ucSanpham.Instance.Dock = DockStyle.Fill;
                ucSanpham.Instance.BringToFront();
            }
            ucSanpham.Instance.BringToFront();
        }

        private void aceDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
            WorkingContext.Instance.Clear();
        }

        private void acehome_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucHome.Instance))
            {
                container.Controls.Add(ucHome.Instance);
                ucHome.Instance.Dock = DockStyle.Fill;
                ucHome.Instance.BringToFront();
            }
            ucHome.Instance.BringToFront();
        }
    }
}
