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
                cbChinhanh.SelectedIndex = WorkingContext.Instance.CurrentBranchId - 1;
            }    
        }


        private void cbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            billsBindingSource.DataSource = dbContext.Instance.FilterBills_chinhanhID(cbChinhanh.SelectedIndex + 1);
        }

        private void btnTimdsMatHangDaBan_Click(object sender, EventArgs e)
        {
            
            int index = cbKieuThongKe.SelectedIndex + 1;
            try
            {
                switch (index)
                {
                    case 1:
                        pnTimNV.Visible = false;
                        chiTietSanPhamBindingSource.DataSource = dbContext.Instance.LayDsSanPhamDaBan(
                            cbChinhanhTimMatHangDaBan.SelectedIndex + 1,
                            dENgayBatDauThongKeMatHang.DateTime,
                            dENgayKetThucThongKeMatHang.DateTime);
                        break;
                    case 2:
                        pnTimNV.Visible = true;
                        chiTietSanPhamBindingSource.DataSource = dbContext.Instance.LaydsbanhangtheocuaNhanVien(
                            cbChinhanhTimMatHangDaBan.SelectedIndex + 1, cbTenNV.SelectedIndex + 1);
                        break;
                    case 3:
                        pnTimNV.Visible = false;
                        chiTietSanPhamBindingSource.DataSource = dbContext.Instance.SanPhamBanChayNhatTheochiNhanh(
                            cbChinhanhTimMatHangDaBan.SelectedIndex + 1, (int)numSoLuongTim.Value,
                            dENgayBatDauThongKeMatHang.DateTime, dENgayKetThucThongKeMatHang.DateTime);
                        break;
                    default:
                        pnTimNV.Visible = false;
                        break;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi Thống kê : " + ex.Message);
            }
        }

        private void cbKieuThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbKieuThongKe.SelectedIndex + 1;
            switch(index)
            {
                case 1:
                    pnTimNV.Visible = false;
                    pnSoLuong.Visible = false;
                    break;
                case 2:
                    pnTimNV.Visible = true;
                    pnSoLuong.Visible = false;
                    break;
                case 3:
                    pnTimNV.Visible = false;
                    pnSoLuong.Visible = true;
                    break;
                default:
                    pnTimNV.Visible = false;
                    pnSoLuong.Visible = false;
                    break;
                       
            }
        }

        private void cbChinhanhTimMatHangDaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayDSNhanVien(cbChinhanhTimMatHangDaBan.SelectedIndex + 1);
        }

        public void LayDSNhanVien(int chinhanhID)
        {
            cbTenNV.DataSource = null;
            cbTenNV.DataSource = dbContext.Instance.FilterAccount_chinhanhID(chinhanhID);
            cbTenNV.DisplayMember = "Fullname";
            cbTenNV.ValueMember = "NhanVienID";
        }
    }
}
