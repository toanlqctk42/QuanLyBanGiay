using DAO;
using System;
using System.Windows.Forms;

namespace QuanLyGiayDep.UI
{
    public partial class ucNhanvien : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucNhanvien _instance;
        public static ucNhanvien Instance 
        { 
            get
            {
                if (_instance == null)
                    _instance = new ucNhanvien();
                return _instance;
            }
        }
        public ucNhanvien()
        {
            InitializeComponent();
            dgvAccount.DataSource = dbContext.Instance.GetAccounts();
            if(WorkingContext.Instance.CurrentLoginInfo.RoleName !="GIAMDOC")
            {
                cbChinhanh.ReadOnly = true;
                cbChinhanh.Text = WorkingContext.Instance.CurrentBranch;
            }
        }

        private void btnThemnhanvien_Click(object sender, EventArgs e)
        {
            int chinhanhID = cbchinhanhadd.SelectedIndex + 1;
            try
            {
                if (dbContext.Instance.ThemNhanVien(txtTendangnhap.Text, mtxtpassWord.Text, cbChucvu.Text,chinhanhID, txtHoten.Text) == 0)
                {
                    MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm không thành công "+ex.Message, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAccount.DataSource = dbContext.Instance.FilterAccount_chinhanhID(cbChinhanh.SelectedIndex+1);
        }
    }
}
