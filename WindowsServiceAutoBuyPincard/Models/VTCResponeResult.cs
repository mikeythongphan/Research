using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace WindowsServiceAutoBuyPincard.Models
{
    public class ResponeResult
    {
        private string CommandType;
        public int GateCode { set { ResponeCode = value; } get { return ResponeCode; } }
        public int ResponeCode { get; set; }
        public long Orgtransid { get; set; }
        public string VTCTransID { get; set; }
        public int PartnerBalance { get; set; }
        public string DataSign { get; set; }

        // constructor
        public ResponeResult(string pvCommandType)
        {
            CommandType = pvCommandType;
        }

        // parsing a result string to other
        public string parseResult(string pvResponeResultString)
        {
            try
            {
                // pasre result string to object
                // buy carrd :      3002-   100000-     50-     logich- 20100824193823- 124242
                //<ResponseCode>|<OrgTransID>|<VTCTransID>|<PartnerBalance>|<dataSign>
                //get card : 3002-10000-logich-124242
                //<ResponseCode>|<OrgTranID|<ListCard>
                //1|1367372|94329486084875:AMR003533:31/12/2012
                //ListCard = <CardCode1>:<CardSerial1>:<ExpriceDate1>|<CardCoden>:<CardSerialn>:<ExpriceDaten>

                // topup game :     3002-   vtctest1-   10000-  logich- 20100824193823- 124242
                //<ResponseCode>|<OrgTransID>|<PartnerBalance>|<DataSign>
                // topup telco :    3002-   0983463588- 10000-  logich- 20100824193823- 124242
                //<ResponseCode>|<OrgTransID>|<PartnerBalance>|<dataSign>

                string[] resultArray = pvResponeResultString.Trim().Split('|');
                GateCode = Convert.ToInt32(resultArray[0].Trim());

                // check if known GateCode, if unknow GateCode, map to 0
                if (GateCode <= 0)
                {
                    GateCode = VTC.CheckKnowErrorResponeCode(GateCode);
                }
                else
                {
                    GateCode = 1;
                }

                Orgtransid = long.Parse(resultArray[1]);

                // balance
                if (GateCode > 0)
                {
                    if ((CommandType.Equals("TopupTelco") || CommandType.Equals("TopupPartner")))
                    {
                        PartnerBalance = Convert.ToInt32(resultArray[2].Trim());
                    }
                    else if (CommandType.Equals("BuyCard"))
                    {
                        VTCTransID = resultArray[2].ToString().Trim();
                        PartnerBalance = Convert.ToInt32(resultArray[3].Trim());
                    }
                }

                return CommandType.Trim().ToLower() + "{" + GateCode.ToString() + "}";
            }
            catch (Exception ex) { return ex.Message; }

        }
    }
    public class VTC
    {
        public static int[] ResponeCodeArray = new int[24] { 0, -1, -302, -303, -304, -305, -306, -307, -308, -309, -310, -311, -313, -315, -316, -317, -55, -320, -348, -350, -318, -301, -500, -501 };
        public const int UnknowErrorCode = -1;
        public static int CheckKnowErrorResponeCode(int pvErrorResponeCode)
        {
            for (int x = 0; x < VTC.ResponeCodeArray.Length; ++x)
            {
                if (pvErrorResponeCode.Equals(VTC.ResponeCodeArray[x]))
                {
                    return pvErrorResponeCode;
                }
            }
            return 0; // check if known GateCode, if unknow GateCode, map to 0
        }

        public static string GetErrorDetails(string errorCode)
        {
            switch (errorCode)
            {
                case "0":
                    return "Giao dịch chưa xác định";
                case "-1":
                    return "Lỗi hệ thống";
                case "-302":
                    return "Partner không tồn tại hoặc đang tạm dừng hoạt động";
                case "-303":
                    return "Unknown";
                case "-304":
                    return "Dịch vụ này không tồn tại hoặc đang tạm dừng";
                case "-305":
                    return "Chữ ký không hợp lệ ";
                case "-306":
                    return "Mệnh giá không hợp lệ hoặc đang tạm dừng";
                case "-307":
                    return "Tài khoản nạp tiền không tồn tại hoặc không hợp lệ";
                case "-308":
                    return "RequesData không hợp lệ";
                case "-309":
                    return "Ngày giao dịch truyền không đúng";
                case "-310":
                    return "Hết hạn mức cho phép sử dụng dịch vụ này";
                case "-311":
                    return "RequesData hoặc PartnerCode không đúng";
                case "-312":
                    return "Unknown";
                case "-313":
                    return "Mã giao dịch trùng lặp";
                case "-315":
                    return "Phải truyền CommandType ";
                case "-316":
                    return "Phải truyền version";
                case "-317":
                    return "Số lượng thẻ phải lớn hơn 0 ";
                case "-55":
                    return "Số dư tài khoản không đủ để thực hiện giao dịch này";
                case "-320":
                    return "Hệ thống gián đoạn";
                case "-348":
                    return "Tài khoản bị Block";
                case "-350":
                    return "Tài khoản không tồn tại";
                case "-318":
                    return "ServiceCode không đúng";
                case "-301":
                    return "Unknown";
                case "-500":
                    return "Loại thẻ này trong kho hiện đã hết hoặc tạm ngừng xuất";
                case "-501":
                    return "Giao dịch nạp tiền không thành công";
                case "-99":
                    return "Unknown";
                default:
                    return errorCode;
            }
        }
        //public enum CommandTypeId  // just define to check format of result string
        //{
        //    TopupTelco,
        //    TopupGame,
        //    BuyCard,
        //    GetCard,
        //    CheckAccount,
        //    GetBalance
        //}

        //public class ServiceCode // not in use now
        //{
        //    public static string Card_Viettel = "VTC0027"; // 10000, 20000, 30000, 50000, 100000, 200000, 300000, 500000
        //    public static string Card_Vina = "VTC0028"; // 10000, 20000, 30000, 50000, 100000, 200000, 300000, 500000
        //    public static string Card_Mobi = "VTC0029"; // 10000, 20000, 30000, 50000, 100000, 200000, 300000, 500000
        //    public static string Card_Sfone = "VTC0030"; // 10000, 20000, 30000, 50000, 100000, 200000, 300000, 500000             
        //    public static string Card_Zing = "VTC0067"; //20000 60000 120000
        //    public static string Card_Gate = "VTC0068"; // 10000 20000 50000 100000 200000 500000
        //    public static string Card_VTCOnline = "VTC0114"; // 10000 20000 50000 100000 200000 300000 500000
        //    public static string Card_Bidifender = "VTC0129"; // 230000

        //    public static string Topup_OnCash = "VTC0036"; // 10000, 20000, 30000, 50000, 100000, 200000, 300000, 500000
        //    public static string Topup_HocMai = "VTC0040"; // 30000, 50000, 100000
        //    public static string Topup_TruongTrucTuyen = "VTC0041"; // 30000, 50000, 100000
        //    public static string Topup_Viettel = "VTC0056"; // 10000, 20000, 30000, 50000, 100000, 200000, 300000, 500000
        //    public static string Topup_Vina = "VTC0057"; // 10000, 20000, 30000, 50000, 100000, 200000, 300000, 500000
        //    public static string Topup_Mobi = "VTC0058"; // >5000 and % 1000 = 0
        //    public static string Topup_EVN = "VTC0127"; // 10000, 20000, 30000, 50000, 100000, 200000, 300000, 500000            
        //    public static string Topup_Mobi_TraSau = "VTC0130"; // 10000, 20000, 30000, 50000, 100000, 200000, 300000, 500000            
        //    public static string Topup_Vcoin = "VTC0115"; // 10000, 20000, 30000, 50000, 100000, 200000, 300000, 500000            
        //    public static string Topup_Digicom = "VTC0104"; // 10000, 20000, 30000, 50000, 100000, 200000, 300000, 500000            
        //    public static string Topup_Poin_AsiaSoft = "VTC0035"; // 20000, 50000, 100000
        //}
    }
}
