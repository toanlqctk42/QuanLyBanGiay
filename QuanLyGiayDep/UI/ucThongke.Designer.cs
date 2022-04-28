
namespace QuanLyGiayDep.UI
{
    partial class ucThongke
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbChinhanh = new System.Windows.Forms.ComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.billsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNhanVienID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChiNhanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaylapBill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDTKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToTal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(808, 583);
            this.splitContainerControl1.SplitterPosition = 122;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cbChinhanh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(808, 122);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm theo điều kiện";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(230, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chi nhánh :";
            // 
            // cbChinhanh
            // 
            this.cbChinhanh.FormattingEnabled = true;
            this.cbChinhanh.Items.AddRange(new object[] {
            "Chi Nhánh 1",
            "Chi Nhánh 2"});
            this.cbChinhanh.Location = new System.Drawing.Point(306, 70);
            this.cbChinhanh.Name = "cbChinhanh";
            this.cbChinhanh.Size = new System.Drawing.Size(121, 21);
            this.cbChinhanh.TabIndex = 0;
            this.cbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cbChinhanh_SelectedIndexChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(808, 451);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Danh sách Hoá đơn";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.billsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(804, 426);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // billsBindingSource
            // 
            this.billsBindingSource.DataSource = typeof(DTO.Bills);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNhanVienID,
            this.colTenChiNhanh,
            this.colNgaylapBill,
            this.colTenKhachHang,
            this.colSDTKhachHang,
            this.colTienHang,
            this.colDiscount,
            this.colToTal});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colNhanVienID
            // 
            this.colNhanVienID.FieldName = "Nhân viên ID";
            this.colNhanVienID.Name = "colNhanVienID";
            this.colNhanVienID.Visible = true;
            this.colNhanVienID.VisibleIndex = 0;
            // 
            // colTenChiNhanh
            // 
            this.colTenChiNhanh.FieldName = "Tên chi nhánh";
            this.colTenChiNhanh.Name = "colTenChiNhanh";
            this.colTenChiNhanh.Visible = true;
            this.colTenChiNhanh.VisibleIndex = 1;
            // 
            // colNgaylapBill
            // 
            this.colNgaylapBill.FieldName = "Ngày tạo hoá đơn";
            this.colNgaylapBill.Name = "colNgaylapBill";
            this.colNgaylapBill.Visible = true;
            this.colNgaylapBill.VisibleIndex = 2;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.FieldName = "Tên Khách Hàng";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.Visible = true;
            this.colTenKhachHang.VisibleIndex = 3;
            // 
            // colSDTKhachHang
            // 
            this.colSDTKhachHang.FieldName = "SĐT";
            this.colSDTKhachHang.Name = "colSDTKhachHang";
            this.colSDTKhachHang.Visible = true;
            this.colSDTKhachHang.VisibleIndex = 4;
            // 
            // colTienHang
            // 
            this.colTienHang.FieldName = "Tổng";
            this.colTienHang.Name = "colTienHang";
            this.colTienHang.Visible = true;
            this.colTienHang.VisibleIndex = 5;
            // 
            // colDiscount
            // 
            this.colDiscount.FieldName = "Giảm giá";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 6;
            // 
            // colToTal
            // 
            this.colToTal.FieldName = "Thực thu";
            this.colToTal.Name = "colToTal";
            this.colToTal.Visible = true;
            this.colToTal.VisibleIndex = 7;
            // 
            // ucThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ucThongke";
            this.Size = new System.Drawing.Size(808, 583);
            this.Load += new System.EventHandler(this.ucThongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbChinhanh;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource billsBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVienID;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChiNhanh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaylapBill;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colSDTKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTienHang;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colToTal;
    }
}
