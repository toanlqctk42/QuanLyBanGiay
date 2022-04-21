using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using DAO;
using BUS;

namespace QuanLyGiayDep
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
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
                if (DbcontextBus.Instance.Login(loginName, password, branch, branchId))
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sai Thông tin đăng nhập \r\n" + ex.Message, "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}