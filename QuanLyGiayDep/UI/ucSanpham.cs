using System;
using System.Drawing;
using System.Windows.Forms;
using DAO;
using DTO;

namespace QuanLyGiayDep.UI
{
    public partial class ucSanpham : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucSanpham _instance;
        public static ucSanpham Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSanpham();
                return _instance;
            }
        }
        public ucSanpham()
        {
            InitializeComponent();
        }

        private void ucSanpham_Load(object sender, System.EventArgs e)
        {
            sanPhamBindingSource.DataSource = dbContext.Instance.GetSanphams();
            loadNhomSP();
            loadThuongHieu();
        }

        void loadNhomSP()
        {
            cbNhomSP.DataSource = dbContext.Instance.GetNhomSPs();
            cbNhomSP.DisplayMember = "TenNhomSP";
            cbNhomSP.ValueMember = "NhomSPID";
        }
        void loadThuongHieu()
        {
            cbThuongHieu.DataSource = dbContext.Instance.GetThuongHieus();
            cbThuongHieu.DisplayMember = "TenThuongHieu";
            cbThuongHieu.ValueMember = "ThuongHieuID";
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog() { Filter = "*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png" })
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pcbHinh.Image = Image.FromFile(open.FileName);
                    ChiTietSanPham ctsp = chiTietSanPhamBindingSource.Current as ChiTietSanPham;
                    if (ctsp != null)
                    {
                        ctsp.ImgURL = open.FileName;
                    }
                    txtfilename.Text = open.FileName;
                }
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            SanPham sanPham = new SanPham()
            {
                MaSanPham = txtMaSP.Text,
                TenSanPham = txtTenSP.Text,
                NhomSP_ID = Convert.ToInt32(cbNhomSP.SelectedValue),
                ThuongHieu_ID = Convert.ToInt32(cbThuongHieu.SelectedValue),
                Ngaynhap = DateTime.Now,
                GiaNhap = Convert.ToInt32(txtGiaNhap.Text),
                Giaban = Convert.ToInt32(txtGiaBan.Text),
                Soluong = 0
            };
            try
            {
                int spId = dbContext.Instance.saveSP(sanPham);
                if(spId != 0)
                {
                    foreach (ChiTietSanPham item in chiTietSanPhamBindingSource)
                    {
                        item.SanPham_ID = spId;
                        item.MaSP = sanPham.MaSanPham;
                        item.TenSP = sanPham.TenSanPham;
                        item.Kinhdoanh = 1;
                        dbContext.Instance.SaveCTSanPham(item);
                        sanPham.Soluong += item.Soluong;
                    }

                    dbContext.Instance.saveSP(sanPham);
                    MessageBox.Show("Thêm Thành Công", "Chúc mừng");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống : " + ex.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
