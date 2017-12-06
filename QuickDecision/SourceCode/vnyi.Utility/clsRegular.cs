using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vnyi.Utility
{
    public enum RegularType
    {

        /// <summary>
        /// Dành cho mã chứng từ    
        /// </summary>
        RegularID = 1,
        /// <summary>
        /// Mã số thuế gồm 10 ký tự số
        /// </summary>
        RegularTaxID = 2,
        /// <summary>
        /// Mail
        /// </summary>
        RegularMail = 3,
        /// <summary>
        /// kiểu số không gồm số 0 ở đầu
        /// </summary>
        RegularNunber = 4,
        /// <summary>
        /// Số phone
        /// </summary>
        RegularPhone = 5,
        /// <summary>
        /// Website
        /// </summary>
        RegularWebsite = 6,
        /// <summary>
        /// Tài khoản 
        /// </summary>
        RegularAccount = 7,
        /// <summary>
        /// Ngày tháng của việt nam
        /// </summary>
        RegularDateVn = 8,
        /// <summary>
        /// Field nhập số tiền
        /// </summary>
        RegularCurrency = 9,
        /// <summary>
        /// Ngày tháng gio của việt nam
        /// </summary>
        RegularDateTimeVn = 10,
        /// <summary>
        /// Số fax
        /// </summary>
        RegularFax = 11,
        /// <summary>
        /// Mã ngân hàng
        /// </summary>
        RegularBankID = 12,
        /// <summary>
        ///Reguler Serrial
        /// </summary>
        RegularSerial = 13,
        /// <summary>
        /// Regular Chứng minh nhân dân
        /// </summary>
        RegularIndentity = 14,
        /// <summary>
        /// Ngày giờ
        /// </summary>
        RegularDateTime = 15,
        /// <summary>
        /// Thời gian :H:m:s
        /// </summary>
        RegularTime = 16,



    }
    public class Regular
    {

        public static RegularType GetRegularType(string RegularTypeValue)
        {
            RegularType Resul = RegularType.RegularID;
            try
            {
                Resul = (RegularType)Enum.Parse(typeof(RegularType), RegularTypeValue);
            }
            catch { Resul = RegularType.RegularID; }
            return Resul;
        }
        public static RegularObject Get(string RegularType)
        {
            RegularType type = GetRegularType(RegularType);
            return Get(type);
        }
        public static RegularObject Get(RegularType RegularType)
        {
            RegularObject Regular = null;
            switch (RegularType)
            {
                case RegularType.RegularID:
                    Regular = new RegularObject();
                    Regular.Regex = @"[a-zA-Z0-9|.|,|!]{1,100}$";
                    Regular.MaskRe = @"[a-zA-Z0-9|.|!|,|-|_]";
                    Regular.MaxLength = 100;
                    break;
                case RegularType.RegularBankID:
                    Regular = new RegularObject();
                    Regular.Regex = @"[a-zA-Z0-9|.|,|-|_]{1,150}$";
                    Regular.MaskRe = @"[a-zA-Z0-9|.|,|-|_]";
                    Regular.MaxLength = 150;
                    break;
                case RegularType.RegularTaxID:
                    Regular = new RegularObject();
                    Regular.Regex = @"[0-9]";
                    Regular.MaskRe = @"[0-9]";
                    Regular.MaxLength = 10;
                    break;
                case RegularType.RegularIndentity:
                    Regular = new RegularObject();
                    Regular.Regex = @"[0-9]{10}$";
                    Regular.MaskRe = @"[0-9]";
                    Regular.MaxLength = 10;
                    break;
                case RegularType.RegularMail:
                    Regular = new RegularObject();
                    Regular.Regex = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
                    Regular.MaskRe = @"[a-z0-9|.|@]";
                    Regular.MaxLength = 100;
                    break;
                case RegularType.RegularNunber:
                    Regular = new RegularObject();
                    Regular.Regex = @"(^-?\d\d*\.\d*$)|(^-?\d\d*$)|(^-?\.\d\d*$)";
                    Regular.MaskRe = @"(^-?\d\d*\.\d*$)|(^-?\d\d*$)|(^-?\.\d\d*$)";
                    break;
                case RegularType.RegularPhone:
                    Regular = new RegularObject();
                    Regular.Regex = @"^((\+\d{1,3}(-| )?\(?\d\)?(-| )?\d{1,5})|(\(?\d{2,6}\)?))(-| )?(\d{3,4})(-| )?(\d{4})(( x| ext)\d{1,5}){0,1}$";
                    Regular.MaskRe = @"[0-9-()]";
                    Regular.MaxLength = 20;
                    break;
                case RegularType.RegularFax:
                    Regular = new RegularObject();
                    Regular.Regex = @"^((\+\d{1,3}(-| )?\(?\d\)?(-| )?\d{1,5})|(\(?\d{2,6}\)?))(-| )?(\d{3,4})(-| )?(\d{4})(( x| ext)\d{1,5}){0,1}$";
                    Regular.MaskRe = @"[0-9-()]";
                    Regular.MaxLength = 20;
                    break;
                case RegularType.RegularWebsite:
                    Regular = new RegularObject();
                    Regular.Regex = @"^(((http?)|(https?))\:\/+\/)?((www)|(WWW)|([a-z0-9_-])+\.)*[a-zA-Z0-9_-]+\.(com|com.vn|vn|org|net|mil|edu|COM|COM.VN|ORG|NET|MIL|EDU)$";
                    Regular.MaskRe = @"[a-z0-9wW:/._-]";
                    Regular.MaxLength = 100;
                    break;
                case RegularType.RegularAccount:
                    Regular = new RegularObject();
                    Regular.Regex = @"[a-zA-Z0-9]{3,10}$";
                    Regular.MaskRe = @"[a-zA-Z0-9 ]";
                    Regular.MaxLength = 10;
                    break;
                case RegularType.RegularDateVn:
                    Regular = new RegularObject();
                    Regular.Format = @"dd/MM/yyyy";
                    Regular.MaskRe = @"[0-9/ :]";
                    Regular.MaxLength = 10;
                    break;
                case RegularType.RegularCurrency:
                    Regular = new RegularObject();
                    Regular.Regex = @"^(0-9){0,13}$+.+(0-9){0,5}$";
                    Regular.MaskRe = @"[0-9.]";
                    Regular.MaxLength = 10;
                    break;
                case RegularType.RegularDateTimeVn:
                    Regular = new RegularObject();
                    Regular.Format = @"dd/MM/yyyy HH:mm:ss";
                    Regular.MaskRe = @"[0-9/]";
                    Regular.MaxLength = 20;
                    break;
                case RegularType.RegularSerial:
                    Regular = new RegularObject();
                    Regular.Regex = @"[a-zA-Z0-9|.|,|-|_]{1,10}$";
                    Regular.MaskRe = @"[a-zA-Z0-9|.|,|-|_]";
                    Regular.MaxLength = 10;
                    break;
                case RegularType.RegularDateTime:
                    Regular = new RegularObject();
                    Regular.Format = @"dd/MM/yyyy HH:mm:ss";
                    Regular.Regex = @"[0-3]\d[/][0-3]\d[/][1-9]\d\d\d\s[0-2]\d[:][0-5]\d[:][0-5]\d";
                    Regular.MaxLength = 19;
                    break;
                case RegularType.RegularTime:
                    Regular = new RegularObject();
                    Regular.Format = @"HH:mm:ss";
                    Regular.MaskRe = @"[0-9/]";
                    Regular.MaxLength = 20;
                    break;
                default: break;
            }
            return Regular;
        }
    }
    public class RegularObject
    {
        public RegularObject()
        {

        }
        public int MaxLength
        {
            get;
            set;
        }
        /// <summary>
        /// Những ký tự được nhập
        /// </summary>
        public string MaskRe
        {
            get;
            set;
        }
        /// <summary>
        /// chuỗi Regular Expressions
        /// </summary>
        public string Regex
        {
            get;
            set;
        }
        /// <summary>
        /// Format cho datefield
        /// </summary>
        public string Format
        {
            get;
            set;
        }

    }

}
