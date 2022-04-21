using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;

namespace QuanLyGiayDep
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tsslLoginName.Text ="Tên đăng nhập : "+ WorkingContext.Instance.CurrentLoginName;
            tsslChinhanh.Text = "Chi nhánh : "+WorkingContext.Instance.CurrentBranch;
            tsslNhom.Text = "Nhóm : "+WorkingContext.Instance.CurrentLoginInfo.RoleName;
        }
    }
}
