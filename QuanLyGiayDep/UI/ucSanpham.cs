using System.Drawing;
using System.Windows.Forms;
using DAO;

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
        }

        private void dgvSanPham_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog() { Filter = "*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png" })
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pcbHinh.Image = Image.FromFile(open.FileName);/*
                    ChiTietSanPham ctsp = chiTietSanPhamBindingSource.Current as ChiTietSanPham;
                    if (ctsp != null)
                    {
                        ctsp.ImgURL = open.FileName;
                    }*/
                    txtfilename.Text = open.FileName;
                }
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}
