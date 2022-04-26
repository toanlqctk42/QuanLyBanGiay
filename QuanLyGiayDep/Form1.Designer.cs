
namespace QuanLyGiayDep
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslLoginName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslChinhanh = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.acehome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acesanpham = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acenhanvien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceThongke = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceDangxuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.container.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.statusStrip1);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(48, 31);
            this.container.Margin = new System.Windows.Forms.Padding(2);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(738, 488);
            this.container.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslLoginName,
            this.tsslChinhanh,
            this.tsslNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(738, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslLoginName
            // 
            this.tsslLoginName.Name = "tsslLoginName";
            this.tsslLoginName.Size = new System.Drawing.Size(94, 17);
            this.tsslLoginName.Text = "Tên đăng nhâp : ";
            // 
            // tsslChinhanh
            // 
            this.tsslChinhanh.Name = "tsslChinhanh";
            this.tsslChinhanh.Size = new System.Drawing.Size(70, 17);
            this.tsslChinhanh.Text = "Chi Nhánh :";
            // 
            // tsslNhom
            // 
            this.tsslNhom.Name = "tsslNhom";
            this.tsslNhom.Size = new System.Drawing.Size(47, 17);
            this.tsslNhom.Text = "Nhóm :";
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(DTO.Account);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acehome,
            this.acesanpham,
            this.acenhanvien,
            this.aceThongke,
            this.aceDangxuat});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(48, 488);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // acehome
            // 
            this.acehome.Expanded = true;
            this.acehome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acehome.ImageOptions.Image")));
            this.acehome.Name = "acehome";
            this.acehome.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acehome.Text = "Trang chủ";
            this.acehome.Click += new System.EventHandler(this.acehome_Click);
            // 
            // acesanpham
            // 
            this.acesanpham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acesanpham.ImageOptions.Image")));
            this.acesanpham.Name = "acesanpham";
            this.acesanpham.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acesanpham.Text = "Sản phẩm";
            this.acesanpham.Click += new System.EventHandler(this.acesanpham_Click);
            // 
            // acenhanvien
            // 
            this.acenhanvien.Expanded = true;
            this.acenhanvien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acenhanvien.ImageOptions.Image")));
            this.acenhanvien.Name = "acenhanvien";
            this.acenhanvien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acenhanvien.Text = "Nhân viên";
            this.acenhanvien.Click += new System.EventHandler(this.acenhanvien_Click);
            // 
            // aceThongke
            // 
            this.aceThongke.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceThongke.ImageOptions.Image")));
            this.aceThongke.Name = "aceThongke";
            this.aceThongke.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceThongke.Text = "Thống kê";
            this.aceThongke.Click += new System.EventHandler(this.aceThongke_Click);
            // 
            // aceDangxuat
            // 
            this.aceDangxuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceDangxuat.ImageOptions.Image")));
            this.aceDangxuat.Name = "aceDangxuat";
            this.aceDangxuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceDangxuat.Text = "Đăng xuất";
            this.aceDangxuat.Click += new System.EventHandler(this.aceDangxuat_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(786, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 519);
            this.ControlContainer = this.container;
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Form1.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Tshoes Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acehome;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acenhanvien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceThongke;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDangxuat;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acesanpham;
        public System.Windows.Forms.ToolStripStatusLabel tsslLoginName;
        public System.Windows.Forms.ToolStripStatusLabel tsslChinhanh;
        public System.Windows.Forms.ToolStripStatusLabel tsslNhom;
    }
}

