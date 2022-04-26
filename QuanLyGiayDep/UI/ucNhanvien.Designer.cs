
namespace QuanLyGiayDep.UI
{
    partial class ucNhanvien
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nhanvien = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.themnhanvien = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.txtHoten = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtTendangnhap = new DevExpress.XtraEditors.TextEdit();
            this.tentaikhoan = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.mtxtpassWord = new System.Windows.Forms.MaskedTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.cbChucvu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.cbchinhanhadd = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemnhanvien = new DevExpress.XtraEditors.SimpleButton();
            this.xemdsnhanvien = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.tenTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykhoitaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiNhanhIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbChinhanh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chinhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvien)).BeginInit();
            this.nhanvien.SuspendLayout();
            this.themnhanvien.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTendangnhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbChucvu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbchinhanhadd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            this.xemdsnhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbChinhanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhanhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanvien
            // 
            this.nhanvien.Controls.Add(this.themnhanvien);
            this.nhanvien.Controls.Add(this.xemdsnhanvien);
            this.nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanvien.Location = new System.Drawing.Point(0, 0);
            this.nhanvien.Name = "nhanvien";
            this.nhanvien.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.nhanvien.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.themnhanvien,
            this.xemdsnhanvien});
            this.nhanvien.RegularSize = new System.Drawing.Size(604, 513);
            this.nhanvien.SelectedPage = this.themnhanvien;
            this.nhanvien.Size = new System.Drawing.Size(604, 513);
            this.nhanvien.TabIndex = 0;
            this.nhanvien.Text = "Thêm Nhân Viên mới";
            // 
            // themnhanvien
            // 
            this.themnhanvien.Caption = "Thêm Nhân Viên mới";
            this.themnhanvien.Controls.Add(this.flowLayoutPanel1);
            this.themnhanvien.Name = "themnhanvien";
            this.themnhanvien.Size = new System.Drawing.Size(427, 440);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelControl7);
            this.flowLayoutPanel1.Controls.Add(this.panelControl2);
            this.flowLayoutPanel1.Controls.Add(this.panelControl3);
            this.flowLayoutPanel1.Controls.Add(this.panelControl5);
            this.flowLayoutPanel1.Controls.Add(this.panelControl4);
            this.flowLayoutPanel1.Controls.Add(this.panelControl6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(427, 440);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelControl7
            // 
            this.panelControl7.Controls.Add(this.txtHoten);
            this.panelControl7.Controls.Add(this.labelControl5);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl7.Location = new System.Drawing.Point(3, 3);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(308, 39);
            this.panelControl7.TabIndex = 1;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(104, 13);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(133, 20);
            this.txtHoten.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 16);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Họ và Tên :";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtTendangnhap);
            this.panelControl2.Controls.Add(this.tentaikhoan);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(3, 48);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(308, 39);
            this.panelControl2.TabIndex = 2;
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Location = new System.Drawing.Point(104, 13);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(133, 20);
            this.txtTendangnhap.TabIndex = 1;
            // 
            // tentaikhoan
            // 
            this.tentaikhoan.Location = new System.Drawing.Point(17, 16);
            this.tentaikhoan.Name = "tentaikhoan";
            this.tentaikhoan.Size = new System.Drawing.Size(79, 13);
            this.tentaikhoan.TabIndex = 0;
            this.tentaikhoan.Text = "Tên đăng nhập :";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.mtxtpassWord);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(3, 93);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(308, 37);
            this.panelControl3.TabIndex = 3;
            // 
            // mtxtpassWord
            // 
            this.mtxtpassWord.Location = new System.Drawing.Point(104, 13);
            this.mtxtpassWord.Name = "mtxtpassWord";
            this.mtxtpassWord.PasswordChar = '*';
            this.mtxtpassWord.Size = new System.Drawing.Size(133, 21);
            this.mtxtpassWord.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật khẩu :";
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.cbChucvu);
            this.panelControl5.Controls.Add(this.labelControl4);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl5.Location = new System.Drawing.Point(3, 136);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(308, 39);
            this.panelControl5.TabIndex = 4;
            // 
            // cbChucvu
            // 
            this.cbChucvu.Location = new System.Drawing.Point(104, 13);
            this.cbChucvu.Name = "cbChucvu";
            this.cbChucvu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChucvu.Properties.Items.AddRange(new object[] {
            "GIAMDOC",
            "QLCHINHANH",
            "NHANVIEN"});
            this.cbChucvu.Size = new System.Drawing.Size(133, 20);
            this.cbChucvu.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 16);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Chức vụ :";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.cbchinhanhadd);
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl4.Location = new System.Drawing.Point(3, 181);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(308, 39);
            this.panelControl4.TabIndex = 5;
            // 
            // cbchinhanhadd
            // 
            this.cbchinhanhadd.Location = new System.Drawing.Point(104, 13);
            this.cbchinhanhadd.Name = "cbchinhanhadd";
            this.cbchinhanhadd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbchinhanhadd.Properties.Items.AddRange(new object[] {
            "Chi Nhánh 1",
            "Chi Nhánh 2"});
            this.cbchinhanhadd.Size = new System.Drawing.Size(133, 20);
            this.cbchinhanhadd.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Chi nhánh :";
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.btnHuy);
            this.panelControl6.Controls.Add(this.btnThemnhanvien);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl6.Location = new System.Drawing.Point(3, 226);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(308, 39);
            this.panelControl6.TabIndex = 6;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(162, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "&Huỷ";
            // 
            // btnThemnhanvien
            // 
            this.btnThemnhanvien.Location = new System.Drawing.Point(55, 5);
            this.btnThemnhanvien.Name = "btnThemnhanvien";
            this.btnThemnhanvien.Size = new System.Drawing.Size(75, 23);
            this.btnThemnhanvien.TabIndex = 1;
            this.btnThemnhanvien.Text = "&Lưu";
            this.btnThemnhanvien.Click += new System.EventHandler(this.btnThemnhanvien_Click);
            // 
            // xemdsnhanvien
            // 
            this.xemdsnhanvien.Caption = "Xem danh sách nhân viên";
            this.xemdsnhanvien.Controls.Add(this.dgvAccount);
            this.xemdsnhanvien.Controls.Add(this.panelControl1);
            this.xemdsnhanvien.Name = "xemdsnhanvien";
            this.xemdsnhanvien.Size = new System.Drawing.Size(427, 440);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoGenerateColumns = false;
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenTKDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.ngaykhoitaoDataGridViewTextBoxColumn,
            this.chiNhanhIDDataGridViewTextBoxColumn});
            this.dgvAccount.DataSource = this.accountBindingSource;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(0, 30);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(427, 410);
            this.dgvAccount.TabIndex = 2;
            // 
            // tenTKDataGridViewTextBoxColumn
            // 
            this.tenTKDataGridViewTextBoxColumn.DataPropertyName = "TenTK";
            this.tenTKDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            this.tenTKDataGridViewTextBoxColumn.Name = "tenTKDataGridViewTextBoxColumn";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Họ và tên";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // ngaykhoitaoDataGridViewTextBoxColumn
            // 
            this.ngaykhoitaoDataGridViewTextBoxColumn.DataPropertyName = "Ngaykhoitao";
            this.ngaykhoitaoDataGridViewTextBoxColumn.HeaderText = "Ngày tạo";
            this.ngaykhoitaoDataGridViewTextBoxColumn.Name = "ngaykhoitaoDataGridViewTextBoxColumn";
            // 
            // chiNhanhIDDataGridViewTextBoxColumn
            // 
            this.chiNhanhIDDataGridViewTextBoxColumn.DataPropertyName = "ChiNhanh_ID";
            this.chiNhanhIDDataGridViewTextBoxColumn.HeaderText = "Chi nhánh ID";
            this.chiNhanhIDDataGridViewTextBoxColumn.Name = "chiNhanhIDDataGridViewTextBoxColumn";
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(DTO.Account);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbChinhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(427, 30);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chi Nhánh";
            // 
            // cbChinhanh
            // 
            this.cbChinhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chinhanhBindingSource, "TenChiNhanh", true));
            this.cbChinhanh.Location = new System.Drawing.Point(78, 8);
            this.cbChinhanh.Name = "cbChinhanh";
            this.cbChinhanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChinhanh.Properties.Items.AddRange(new object[] {
            "Chi nhánh 1",
            "Chi nhánh 2"});
            this.cbChinhanh.Size = new System.Drawing.Size(147, 20);
            this.cbChinhanh.TabIndex = 0;
            this.cbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cbChinhanh_SelectedIndexChanged);
            // 
            // chinhanhBindingSource
            // 
            this.chinhanhBindingSource.DataSource = typeof(DTO.Chinhanh);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // ucNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nhanvien);
            this.Name = "ucNhanvien";
            this.Size = new System.Drawing.Size(604, 513);
            ((System.ComponentModel.ISupportInitialize)(this.nhanvien)).EndInit();
            this.nhanvien.ResumeLayout(false);
            this.themnhanvien.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTendangnhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbChucvu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbchinhanhadd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.xemdsnhanvien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbChinhanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhanhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane nhanvien;
        private DevExpress.XtraBars.Navigation.NavigationPage themnhanvien;
        private DevExpress.XtraBars.Navigation.NavigationPage xemdsnhanvien;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykhoitaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiNhanhIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbChinhanh;
        private System.Windows.Forms.BindingSource chinhanhBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.TextEdit txtHoten;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtTendangnhap;
        private DevExpress.XtraEditors.LabelControl tentaikhoan;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cbChucvu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbchinhanhadd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThemnhanvien;
        private System.Windows.Forms.MaskedTextBox mtxtpassWord;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}
