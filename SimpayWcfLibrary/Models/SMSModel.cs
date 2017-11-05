using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SimpayWcfLibrary.Models
{
    [DataContract]
    public class SMSModel
    {
        public SMSModel()
        {
        }

        public SMSModel(Librarys.CRM.SMS sms)
        {
            ID = sms.ID;
            IndexSMS = sms.IndexSMS;
            PhoneNumber = sms.PhoneNumber;
            ReceiveDate = sms.ReceiveDate;
            CreateDate = sms.CreateDate;
            Content = sms.Content;
            SimNumberFrom = sms.SimNumberFrom;
            Status = sms.Status;
            SMSTypeID = sms.SMSTypeID;
            TransactionID = sms.TransactionID;
        }

        [DataMember]
        public long? ID { get; set; }
        [DataMember]
        public int? TransactionID { get; set; }
        [DataMember]
        public int? SMSTypeID { get; set; }
        [DataMember]
        public int? IndexSMS { get; set; }
        [DataMember]
        public DateTime? CreateDate { get; set; }
        [DataMember]
        public DateTime? ReceiveDate { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string SimNumberFrom { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string Content { get; set; }

        public Librarys.CRM.SMS MappingToSMS()
        {
            return new Librarys.CRM.SMS()
            {
                ID = this.ID,
                IndexSMS = this.IndexSMS,
                PhoneNumber = this.PhoneNumber,
                ReceiveDate = this.ReceiveDate,
                CreateDate = this.CreateDate,
                Content = this.Content,
                SimNumberFrom = this.SimNumberFrom,
                Status = this.Status,
                SMSTypeID = this.SMSTypeID,
                TransactionID = this.TransactionID
            };
        }
    }
}
