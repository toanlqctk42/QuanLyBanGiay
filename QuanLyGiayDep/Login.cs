using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using DAO;

namespace QuanLyGiayDep
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        private static Login _instance;
        public static Login Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Login();
                return _instance;
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string branch, loginName, password;
            if (txtloginName.Text == "" || txtpassWord.Text == "")
            {
                MessageBox.Show("vui long nhap thong tin dang nhap");
            }
            if (cbchiNhanh.SelectedIndex < 0)
            {
                MessageBox.Show("vui long chon chi nhanh");
                return;
            }
            branch = cbchiNhanh.Text;
            int branchId = cbchiNhanh.SelectedIndex + 1;
            loginName = txtloginName.Text;
            password = txtpassWord.Text;

            try
            {
                if (dbContext.Instance.login(loginName, password, branch, branchId))
                {
                    this.Hide();
                    if(Form1.Instance.ShowDialog()==DialogResult.OK)
                    {
                        this.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sai Thông tin đăng nhập \r\n" + ex.Message, "Thông Báo", MessageBoxButtons.OK);
                simpleButton2.PerformClick();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}