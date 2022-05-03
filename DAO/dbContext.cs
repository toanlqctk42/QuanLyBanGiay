using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;

namespace DAO
{
    public class dbContext
    {
        private static dbContext _instance = null;
        public static dbContext Instance => _instance ?? (_instance = new dbContext());

        public bool login(string loginName, string password, string chinhanh, int chinhanhID)
        {
            WorkingContext.Instance.CurrentBranch = chinhanh;
            WorkingContext.Instance.CurrentBranchId = chinhanhID;
            WorkingContext.Instance.CurrentLoginName = loginName;
            
            WorkingContext.Instance.Initialize(Connectionstring(chinhanhID,loginName,password));
            TshoesContext dbcontext = WorkingContext.Instance._dbContext;
            var loginInfo = dbcontext.Database.SqlQuery<LoginInfoes>("exec sp_getLoginInfo @p0", loginName).FirstOrDefault();
            WorkingContext.Instance.CurrentLoginInfo = loginInfo;
            return true;
        }

        public string Connectionstring(int chinhanhId, string loginName, string pass)
        {
            var connectionName = string.Format("Branch{0}", chinhanhId);
            string connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            connectionString = string.Format(connectionString, loginName, pass);
            return connectionString;
        }

        #region return list
        public List<Chinhanh> GetChinhanhs()
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
            return tshoesContext.Chinhanh.ToList();
        }

        public List<SanPham> GetSanphams()
        {
            /*using (TshoesContext tshoesContext = WorkingContext.Instance._dbContext)
            {*/
                TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
                return tshoesContext.SanPham.ToList();/*
            }*/
        }

        public List<Account> GetAccounts()
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
            return tshoesContext.Account.Where(x => x.ChiNhanh_ID == WorkingContext.Instance.CurrentBranchId).ToList();
        }

        public List<Bills> GetBills()
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
            return tshoesContext.Bills.ToList();
        }

        public List<BillDetails> GetBillDetails()
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
            return tshoesContext.BillDetails.ToList();
        }

        public List<Account> FilterAccount_chinhanhID(int chinhanhID)
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
            if(chinhanhID != WorkingContext.Instance.CurrentBranchId)
            {
                return tshoesContext.Database.SqlQuery<Account>("exec [dbo].[sp_GetAllUSer]").ToList();
            }
            else
            {
                return tshoesContext.Account.ToList();
            }
        }

        public List<Bills> FilterBills_chinhanhID(int chinhanhID)
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
            if (chinhanhID != WorkingContext.Instance.CurrentBranchId)
            {
                return tshoesContext.Database.SqlQuery<Bills>("exec [dbo].[sp_GetAllBills]").ToList();
            }
            else
            {
                return tshoesContext.Bills.ToList();
            }
        }

        public List<SanPham> GetSanPhams()
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
            return tshoesContext.SanPham.ToList();
        }

        public List<ChiTietSanPham> GetchiTietSanPhams()
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
            return tshoesContext.ChiTietSanPham.ToList();
        }

        public List<NhomSP> GetNhomSPs()
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
            return tshoesContext.NhomSP.ToList();
        }

        public List<ThuongHieu> GetThuongHieus()
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
            return tshoesContext.ThuongHieu.ToList();
        }

        #endregion
        public int ThemNhanVien(string loginName , string password , string roleName,int chinhanhID,string Hoten)
        {
            try
            {
                var tshoesContext = WorkingContext.Instance._dbContext;
                if(Convert.ToInt32(tshoesContext.Database.ExecuteSqlCommand($"DECLARE @return_value int" +
                    $" EXEC  @return_value = [dbo].[SP_TaoTaiKhoan]" +
                    $" @LGNAME = N'{loginName}', " +
                    $" @PASS = N'{password}'," +
                    $"@USERNAME = N'{Hoten}'," +
                    $"@ROLE = N'{roleName}' " +
                    $"SELECT  'Return Value' = @return_value"))==0)
                {
                    Account account = new Account()
                    {
                        TenTK = loginName,
                        Fullname = Hoten,
                        Ngaykhoitao = DateTime.Now,
                        MatKhau = password,
                        ChiNhanh_ID = chinhanhID,
                        Active = 1
                    };
                    tshoesContext.Account.Add(account);
                    tshoesContext.SaveChanges();
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch
            {
                return 1;
            }
        }

        public int saveSP(SanPham sanPham)
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
            
            if (sanPham != null)
            {
                if (tshoesContext.Entry(sanPham).State == EntityState.Detached)
                    tshoesContext.Set<SanPham>().Attach(sanPham);

                if (sanPham.SanPhamID == 0)
                    tshoesContext.Entry(sanPham).State = EntityState.Added;
                else
                    tshoesContext.Entry(sanPham).State = EntityState.Modified;

                tshoesContext.SaveChanges();
                return sanPham.SanPhamID;
            }
            else
            {
                return 0;
            }
        }
        public int SaveCTSanPham(ChiTietSanPham chiTietSanPham)
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
                if (chiTietSanPham != null)
                {
                    if (tshoesContext.Entry(chiTietSanPham).State == EntityState.Detached)
                        tshoesContext.Set<ChiTietSanPham>().Attach(chiTietSanPham);

                    if (chiTietSanPham.ChitietSPID == 0)
                        tshoesContext.Entry(chiTietSanPham).State = EntityState.Added;
                    else
                        tshoesContext.Entry(chiTietSanPham).State = EntityState.Modified;

                    /*tshoesContext.ChiTietSanPham.u*/
                    tshoesContext.SaveChanges();

                    return chiTietSanPham.ChitietSPID;
                }
                else
                {
                    return 0;
                }
        }

        public List<ChiTietSanPham> LayDsSanPhamDaBan(int chinhanhID , DateTime ngaybatdau , DateTime NgayKetThuc)
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
            if(chinhanhID != WorkingContext.Instance.CurrentBranchId)
            {
                return tshoesContext.Database.SqlQuery<ChiTietSanPham>($"exec sp_dsMatHangDaBan '{ngaybatdau}', '{NgayKetThuc}'").ToList();
            }
            else
            {
                List<ChiTietSanPham> ct = new List<ChiTietSanPham>();
                foreach (var ctsp in GetchiTietSanPhams())
                {
                    ctsp.Soluong = 0;
                    foreach (var dt in GetBillDetails())
                    {
                        if(ctsp.ChitietSPID == dt.ChitietSP_ID)
                        {
                            foreach (var bi in GetBills())
                            {
                                if(bi.BillID == dt.Bills_ID && bi.NgaylapBill>= ngaybatdau && bi.NgaylapBill<=NgayKetThuc)
                                {
                                    ctsp.Soluong += dt.Soluong;
                                }
                            }
                        }
                    }
                    if(ctsp.Soluong != 0)
                    {
                        ct.Add(ctsp);
                    }
                }
                return ct;

            }
        }

        public List<ChiTietSanPham> LaydsbanhangtheocuaNhanVien(int chinhanhID , int NhanVienID)
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
            if (chinhanhID != WorkingContext.Instance.CurrentBranchId)
            {
                return tshoesContext.Database.SqlQuery<ChiTietSanPham>($"exec sp_dsSanPham_NhanVienDaBan {NhanVienID}").ToList();
            }
            else
            {
                List<ChiTietSanPham> ct = new List<ChiTietSanPham>();
                foreach (var ctsp in GetchiTietSanPhams())
                {
                    ctsp.Soluong = 0;
                    foreach (var dt in GetBillDetails())
                    {
                        if (ctsp.ChitietSPID == dt.ChitietSP_ID)
                        {
                            foreach (var bi in GetBills())
                            {
                                if (bi.BillID == dt.Bills_ID && bi.NhanVienID == NhanVienID)
                                {
                                    ctsp.Soluong += dt.Soluong;
                                }
                            }
                        }
                    }
                    if (ctsp.Soluong != 0)
                    {
                        ct.Add(ctsp);
                    }
                }
                return ct;
            }
        }

        public List<ChiTietSanPham> SanPhamBanChayNhatTheochiNhanh(int chinhanhID , int sothongke , DateTime ngaybatdau , DateTime ngayketthuc)
        {
            TshoesContext tshoesContext = WorkingContext.Instance._dbContext;
            if(chinhanhID == WorkingContext.Instance.CurrentBranchId)
            {
                return tshoesContext.Database.SqlQuery<ChiTietSanPham>($"exec sp_SanPhamBanChayNhat {sothongke},'{ngaybatdau}','{ngayketthuc}'").ToList();
            }
            else
            {
                List<ChiTietSanPham> ct = new List<ChiTietSanPham>();
                foreach (var ctsp in GetchiTietSanPhams())
                {
                    ctsp.Soluong = 0;
                    foreach (var dt in GetBillDetails())
                    {
                        if (ctsp.ChitietSPID == dt.ChitietSP_ID)
                        {
                            foreach (var bi in GetBills())
                            {
                                if (bi.BillID == dt.Bills_ID && bi.NgaylapBill >= ngaybatdau && bi.NgaylapBill <= ngayketthuc)
                                {
                                    ctsp.Soluong += dt.Soluong;
                                }
                            }
                        }
                    }
                    if (ctsp.Soluong != 0)
                    {
                        ct.Add(ctsp);
                    }
                }
                for (int i = 0; i < ct.Count-1; i++)
                {
                    for (int j = i+1; j < ct.Count; j++)
                    {
                        if(ct[i].Soluong<ct[j].Soluong)
                        {
                            ChiTietSanPham temp = ct[i];
                            ct[i] = ct[j];
                            ct[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < ct.Count; i++)
                {
                    if(i>sothongke)
                    {
                        ct.RemoveAt(i);
                    }
                }
                return ct;
            }
        }
    }
}
