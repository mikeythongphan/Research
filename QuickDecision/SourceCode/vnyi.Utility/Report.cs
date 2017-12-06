using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vnyi.Utility
{
 public  class Report
    {
     public enum ReportType : short                                   
     {
         /// <summary>
         /// Bảng cân đối kế toán
         /// </summary>
         BCDKT = 1,
         /// <summary>
         /// Báo cáo kết qua HDKD Phần 1
         /// </summary>
         BusinessResultsPart1 = 2,
         /// <summary>
         /// Báo cáo kết qua HDKD Phần 2
         /// </summary>
         BusinessResultsPart2= 3,
         /// <summary>
         /// Báo cáo lưu chuyển tiền tệ(Gián tiếp)
         /// </summary>
         CurTransfer= 4,
         /// <summary>
         /// Báo cáo lưu chuyển tiền tệ(Trực tiếp)
         /// </summary>
         CurTransferDirect=5
     }

    }
}
