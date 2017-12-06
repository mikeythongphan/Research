using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Ext.Net;
using vnyi.DataProvider;

namespace vnyi.Utility
{
    public class clsFuntions
    {
        public static void ThowExceptionToClient(Exception e, ResourceManager sm, string title, string userMsg)
        {
            string sScript = string.Format(@"ShowError('{0}','{1}',Ext.util.JSON.encode({2}) );", title, userMsg,JSON.Serialize(e));

            sm.RegisterOnReadyScript(sScript) ;
        }
        /// <summary>
        /// Lấy modul dua vào Url
        /// </summary>
        /// <param name="Url">Url hiện hành</param>
        /// <returns>Trả về module của trang</returns>
        public static eziposModule GetModuleWithUrl(string Url)
        {
            eziposModule Modul =new eziposModule();
            //Modul CM
            if (Url.Contains("/CM/"))
                Modul = eziposModule.CM;
            else
                if (Url.Contains("/AM/"))
                    Modul = eziposModule.AM;
                else
                //Modul GL
                if (Url.Contains("/GL/"))
                    Modul = eziposModule.GL;
                else
                    //Modul AR
                    if (Url.Contains("/AR/"))
                        Modul = eziposModule.AR;
                    else
                        //Modul AP
                        if (Url.Contains("/AP/"))
                            Modul = eziposModule.AP;
                        else
                            //Modul IC
                            if (Url.Contains("/IC/"))
                                Modul = eziposModule.IC;
                            else
                                //Modul SO
                                if (Url.Contains("/SO/"))
                                    Modul = eziposModule.SO;
                                else
                                    //Modul PO
                                    if (Url.Contains("/PO/"))
                                        Modul = eziposModule.PO;
                                    else
                                        //Modul Meta
                                        if (Url.Contains("/Meta/"))
                                            Modul = eziposModule.MTA;
                                        else
                                            //Modul Báo Cáo
                                            if (Url.Contains("/Report/"))
                                                Modul = eziposModule.REPORT;
                                            else if (Url.Contains("/Common/"))
                                                return eziposModule.COMMON;
                                            else if (Url.Contains("/RES/"))
                                                return eziposModule.EZIRES;


            return Modul;

        }
        public static Icon GetIcon(string IConName)
        {
            Icon Resul = Icon.Accept;
            try
            {
                Resul = (Icon)Enum.Parse(typeof(Icon), IConName);
            }
            catch { Resul = Icon.Folder; }
            return Resul;
        }

        /// <summarys>
        /// kiem tra hop le
        /// </summary>
        /// <param name="ojb">tham so muon kiem tra</param>
        /// <param name="paterm">kiem muon kiem tra</param>
        /// <returns></returns>
        public static bool Validate(object ojb, string pattern)
        {
            try
            {
                return Regex.IsMatch(ojb.ToString(), pattern);
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
        /// <summary>
        /// Get currentRate Default in System
        /// </summary>
        /// <param name="OrgID">ID of Org</param>
        /// <param name="CurrentcyChange"> ID of currentcy that u want change</param>
        /// <returns>CurrentCyRate</returns>
        public static decimal GetCurrentcyRateDefault(int ? OrgID, int ? CurrentcyChange)
        {
            decimal Current;
            object obj = SqlHelper.ExecuteScalar("spCurrentCyrateGetDefault", OrgID, CurrentcyChange);
            Current = clsFormat.DecimalConvert(obj);
            if (Current <= 0)
                Current = 1;
            return Current;
        }
        #region doc so cua hung vnyi
        private static string DocBo9ChuSo(string sBo9SoCanDoc, string sGroupSeperate, bool bLaDauChuoi)
        {
            string ChuoiConSo, PhanNguyen;
            string ChuoiTienChinhThuc = string.Empty;

            ChuoiConSo = PhanNguyen = string.Empty;//PhanThapPhan = string.Empty;
            string[] ChuoiTach;
            //string[] TenLop = { "tỷ", "triệu", "nghìn", "đồng" };
            //string[] TenLop = { "tỷ", "triệu", "nghìn", "" };     // 
            string[] TenLop = { "triệu", "nghìn", "" };
            string[] ChuoiChuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] ChuoiChuSoDonVi = { "không", "mốt", "hai", "ba", "bốn", "lăm", "sáu", "bảy", "tám", "chín" };
            string[] ChuoiChuSoChuc = { "không", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
            //ChuoiConSo = sBo9SoCanDoc.ToString("###############.00");
            ChuoiTach = sBo9SoCanDoc.Split(sGroupSeperate.ToCharArray());
            PhanNguyen = ChuoiTach.GetValue(0).ToString();
            //PhanThapPhan = ChuoiTach.GetValue(1).ToString();
            for (; PhanNguyen.Length < 9; PhanNguyen = "0" + PhanNguyen) ;
            for (int i = 0; i < TenLop.Length; i++)
            {
                string ChuoiCon = string.Empty;
                string Tram, Chuc, DonVi;
                Tram = Chuc = DonVi = string.Empty;
                ChuoiCon = PhanNguyen.Substring(3 * i, 3);
                if (Convert.ToDouble(ChuoiCon) > 0)
                {
                    if (Convert.ToDouble(ChuoiCon.Substring(0, 1)) > 0)
                    {
                        Tram = String.Format("{0} trăm", ChuoiChuSo.GetValue(Convert.ToInt16(ChuoiCon.Substring(0, 1))));

                        if (ChuoiCon.Substring(1, 1) == "0")
                        {
                            if (ChuoiCon.Substring(2, 1) != "0")
                                Chuc = String.Format("lẻ {0}", ChuoiChuSo.GetValue(Convert.ToInt16(ChuoiCon.Substring(2, 1)))); //chuoi so thuong
                        }
                        else
                        {
                            if (ChuoiCon.Substring(1, 2) == "11")
                                Chuc = "mười một";
                            else
                            {
                                if (ChuoiCon.Substring(2, 1) != "0")
                                    DonVi = ChuoiChuSoDonVi.GetValue(Convert.ToInt16(ChuoiCon.Substring(2, 1))).ToString(); // chuoi hang don vi

                                Chuc = ChuoiChuSoChuc.GetValue(Convert.ToInt16(ChuoiCon.Substring(1, 1))).ToString();
                            }
                        }
                    }
                    else
                    {
                        if (ChuoiTienChinhThuc != "")
                        {
                            Tram = "không trăm";
                        }
                        else
                        {
                            if (bLaDauChuoi == false)
                                Tram = "không trăm";
                        }

                        if (ChuoiCon.Substring(1, 1) != "0")
                        {
                            if (ChuoiCon.Substring(1, 2) == "11")
                                Chuc = "mười một";
                            else
                            {
                                if (ChuoiCon.Substring(2, 1) != "0")
                                    DonVi = ChuoiChuSoDonVi.GetValue(Convert.ToInt16(ChuoiCon.Substring(2, 1))).ToString(); // chuoi hang don vi
                                Chuc = ChuoiChuSoChuc.GetValue(Convert.ToInt16(ChuoiCon.Substring(1, 1))).ToString(); ;
                            }
                        }
                        else
                        {
                            DonVi = ChuoiChuSo.GetValue(Convert.ToInt16(ChuoiCon.Substring(2, 1))).ToString(); //chuoi so thuong
                            if (ChuoiTienChinhThuc != string.Empty)
                                DonVi = String.Format("lẻ {0}", DonVi);
                        }
                    }


                    ChuoiTienChinhThuc = String.Format("{0} {1} {2} {3} {4}", ChuoiTienChinhThuc, Tram, Chuc, DonVi, TenLop.GetValue(i));
                }
            }
            return ChuoiTienChinhThuc.Replace("  ", " ");
        }        

        public static string ChuyenTienSoThanhChuVN(object Value)
        {
            decimal Amount = clsFormat.DecimalConvert(Value);
            return ChuyenTienSoThanhChuVN(Amount, '.');
        }

        public static string ChuyenTienSoThanhChuVN(decimal SoTien, char sSeperate)
        {

            string ChuoiConSo, PhanNguyen, PhanThapPhan;
            string ChuoiTienChinhThuc = string.Empty;

            ChuoiConSo = PhanNguyen = PhanThapPhan = string.Empty;
            string[] ChuoiTach;
            string[] DonViTien = { "tỷ", "triệu", "nghin", "đồng" };
            string[] ChuoiChuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] ChuoiChuSoDonVi = { "không", "mốt", "hai", "ba", "bốn", "lăm", "sáu", "bảy", "tám", "chín" };
            string[] ChuoiChuSoChuc = { "không", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
            ChuoiConSo = SoTien.ToString("###############.00");
            ChuoiTach = ChuoiConSo.Split(sSeperate);
            PhanNguyen = ChuoiTach.GetValue(0).ToString();
            if(ChuoiTach.Length>=2)
            PhanThapPhan = ChuoiTach.GetValue(1).ToString();
            for (; PhanNguyen.Length < 12; PhanNguyen = "0" + PhanNguyen) ;
            for (int i = 0; i < 4; i++)
            {
                string ChuoiCon = string.Empty;
                string Tram, Chuc, DonVi;
                Tram = Chuc = DonVi = string.Empty;
                ChuoiCon = PhanNguyen.Substring(3 * i, 3);
                if (Convert.ToDouble(ChuoiCon) > 0)
                {
                    if (Convert.ToDouble(ChuoiCon.Substring(0, 1)) > 0)
                    {
                        Tram = String.Format("{0} trăm", ChuoiChuSo.GetValue(Convert.ToInt16(ChuoiCon.Substring(0, 1))));

                        if (ChuoiCon.Substring(1, 1) == "0")
                        {
                            if (ChuoiCon.Substring(2, 1) != "0")
                                Chuc = String.Format("lẻ {0}", ChuoiChuSo.GetValue(Convert.ToInt16(ChuoiCon.Substring(2, 1)))); //chuoi so thuong
                        }
                        else
                        {
                            if (ChuoiCon.Substring(1, 2) == "11")
                                Chuc = "mười một";
                            else
                            {
                                if (ChuoiCon.Substring(2, 1) != "0")
                                    DonVi = ChuoiChuSoDonVi.GetValue(Convert.ToInt16(ChuoiCon.Substring(2, 1))).ToString(); // chuoi hang don vi

                                Chuc = ChuoiChuSoChuc.GetValue(Convert.ToInt16(ChuoiCon.Substring(1, 1))).ToString();
                            }
                        }
                    }
                    else
                    {
                        if (ChuoiCon.Substring(1, 1) != "0")
                        {
                            if (ChuoiCon.Substring(1, 2) == "11")
                                Chuc = "mười một";
                            else
                            {
                                if (ChuoiCon.Substring(2, 1) != "0")
                                    DonVi = ChuoiChuSoDonVi.GetValue(Convert.ToInt16(ChuoiCon.Substring(2, 1))).ToString(); // chuoi hang don vi
                                Chuc = ChuoiChuSoChuc.GetValue(Convert.ToInt16(ChuoiCon.Substring(1, 1))).ToString(); ;
                            }
                        }
                        else
                        {
                            //chuoi so thuong
                            if (ChuoiTienChinhThuc != string.Empty)
                                DonVi = "lẻ " + ChuoiChuSo.GetValue(Convert.ToInt16(ChuoiCon.Substring(2, 1))).ToString();
                            else
                                DonVi = ChuoiChuSo.GetValue(Convert.ToInt16(ChuoiCon.Substring(2, 1))).ToString();
                        }
                    }


                    ChuoiTienChinhThuc = String.Format("{0} {1} {2} {3} {4}", ChuoiTienChinhThuc, Tram, Chuc, DonVi, DonViTien.GetValue(i));
                }
            }
            ChuoiTienChinhThuc = ChuoiTienChinhThuc.Trim();            
            if (ChuoiTienChinhThuc.Length >1)
            ChuoiTienChinhThuc = ChuoiTienChinhThuc.Substring(0, 1).ToUpper() + ChuoiTienChinhThuc.Substring(1, ChuoiTienChinhThuc.Length-1);
            return ChuoiTienChinhThuc;


        }

        #endregion
 
    }  
}
