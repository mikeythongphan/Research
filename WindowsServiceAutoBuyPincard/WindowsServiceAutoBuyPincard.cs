using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using WindowsServiceAutoBuyPincard.Systems;
using WindowsServiceAutoBuyPincard.Models;
using System.Threading;
using System.Configuration;
using Librarys.REPORTSPAYMENT;
using Librarys.SYSTEM.CONFIGURATION;
using Librarys.PINCARD;
using Librarys.CC;
using Utilities;
using System.Xml;
using Bases;
using System.Net;
using System.Net.NetworkInformation;
using System.Collections;
using XmlLibrary;
using XmlProtocolLibrary;
using System.Text.RegularExpressions;
using System.Net.Mail;
using Logich;
using WSLogic;
using CommonClass;
using System.Globalization;
using System.IO;

namespace WindowsServiceAutoBuyPincard
{
    partial class WindowsServiceAutoBuyPincard : ServiceBase
    {
        private System.Timers.Timer ACS_Timer;
        private static int TimerCounting = 0;
        private static int PoolCounting = 0;
        private object lockPoolCounting = new object();
        protected static int MaxTryCount = 10;
        protected static int MaxPool = 1;
        protected static int IntervalSeconds = clsFormat.IntConvert(ConfigurationManager.AppSettings["IntervalSeconds"]);
        protected static int DelaySeconds = clsFormat.IntConvert(ConfigurationManager.AppSettings["DelaySeconds"]);
        protected static bool IsStop = false;
        private static int MAX_POOL = 1000;
        private static int MAX_NUMBERS = 10000;
        private DateTime RunTime = DateTime.Now;
        private DateTime BeginTime = DateTime.Now;
        private DateTime EndTime = DateTime.Now;
        private static int ThressholdValue = 0;
        private static int Value = 0;
        private string Email = string.Empty;
        private string EmailCC = string.Empty;
        private string EmailBCC = string.Empty;
        private int Hour = 0;
        private int Minute = 0;
        private int Second = 0;
        /// <summary>
        /// Parameter for buy pincards
        /// </summary>
        private static Models.PinCardEntities db = new Models.PinCardEntities();
        public static List<InventoryPinCode> InventoryPinCodeList { get; set; }
        private static int countBuyPincard = 0;
        private static int notCountBuyPincard = 0;
        private static string ErrorMessage = string.Empty;
        private const string BUYCARD = "BuyCard";
        private const string GETCARD = "GetCard";
        private static string TotalMessage = string.Empty;

        public WindowsServiceAutoBuyPincard()
        {
            InitializeComponent();
        }

        void Run()
        {
            Logger.Log(Environment.NewLine + "_____Service Timer starting...");
            MaxPool = MAX_POOL;
            MaxTryCount = 1000;
            IntervalSeconds = clsFormat.IntConvert(ConfigurationManager.AppSettings["IntervalSeconds"]);
            DelaySeconds = clsFormat.IntConvert(ConfigurationManager.AppSettings["DelaySeconds"]);
            IsStop = false;
            ACS_Timer = new System.Timers.Timer(IntervalSeconds * 1000);
            ACS_Timer.Elapsed += new ElapsedEventHandler(Service_Timer_Function);
            ACS_Timer.Enabled = true;
            ACS_Timer.Start();
        }

        private void Service_Timer_Function(object obj, ElapsedEventArgs e)
        {
            try
            {
                if (!IsStop)
                {
                    try
                    {
                        if (TimerCounting % 100 == 0)
                        {
                            if (TimerCounting > 1000)
                                TimerCounting = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Log("TimerCounting : " + ex.Message);
                        Logger.Log("TimerCounting : " + ex.StackTrace);
                        Logger.Log("TimerCounting : " + ex.InnerException);
                    }
                    TimerCounting++;
                    Logger.Log("_____Service Timer started");
                    Logger.Log("TimerCounting: \t" + TimerCounting.ToString());
                    Logger.Log("PoolCounting: \t" + PoolCounting.ToString());

                    Logger.Log("Get Config Type 3 from Database:______________________________________________");
                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Pincard"].ConnectionString;
                    List<Librarys.PINCARD.CONFIGURATION> lstConfig3 = DataOut.PINCARD_GetAllCONFIGURATIONListByTypeId(3);
                    if (lstConfig3.Count > 0)
                    {
                        #region Prepare quantity of pincards in store
                        Logger.Log("Prepare quantity of pincards in store:______________________________________________");
                        foreach (Librarys.PINCARD.CONFIGURATION config in lstConfig3)
                        {
                            RunTime = clsFormat.DateConvert(config.ConfigDate);
                            Hour = config.ConfigTime.Hours;
                            Minute = config.ConfigTime.Minutes;
                            Second = config.ConfigTime.Seconds;
                            Email = config.ConfigEmailTo;
                            EmailCC = config.ConfigEmailCC;
                            EmailBCC = config.ConfigEmailBCC;
                            Value = clsFormat.IntConvert(config.ConfigValue);
                        }
                        #endregion
                    }

                    Logger.Log("Get Config Type 4 from Database:______________________________________________");
                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Pincard"].ConnectionString;
                    List<Librarys.PINCARD.CONFIGURATION> lstConfig4 = DataOut.PINCARD_GetAllCONFIGURATIONListByTypeId(4);
                    if (lstConfig4.Count > 0)
                    {
                        #region Syn data from pincards to report
                        Logger.Log("Syn data from pincards to report:______________________________________________");
                        foreach (Librarys.PINCARD.CONFIGURATION config in lstConfig4)
                        {
                            RunTime = clsFormat.DateConvert(config.ConfigDate);
                            Hour = config.ConfigTime.Hours;
                            Minute = config.ConfigTime.Minutes;
                            Second = config.ConfigTime.Seconds;
                            Email = config.ConfigEmailTo;
                            EmailCC = config.ConfigEmailCC;
                            EmailBCC = config.ConfigEmailBCC;
                            Value = clsFormat.IntConvert(config.ConfigValue);
                        }
                        if (DateTime.Now.Hour == Hour && DateTime.Now.Minute == Minute)
                        {
                            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Pincard"].ConnectionString;
                            DataSet ds = DataOut.PINCARD_GeDataToSyncFromPincards();
                            if (ds.Tables.Count > 0)
                            {
                                foreach (DataRow row in ds.Tables[0].Rows)
                                {
                                    CONSOLIDATORS obj1 = new CONSOLIDATORS();
                                    obj1.ConsolidatorAddress = row["ConsolidatorAddress"].ToString();
                                    obj1.ConsolidatorCellPhone = row["ConsolidatorCellPhone"].ToString();
                                    obj1.ConsolidatorID = clsFormat.IntConvertNull(row["ConsolidatorID"].ToString());
                                    obj1.ConsolidatorNo = row["ConsolidatorNo"].ToString();
                                    obj1.ConsolidatorOrder = clsFormat.IntConvertNull(row["ConsolidatorOrder"].ToString());
                                    obj1.ConsolidatorPhone = row["ConsolidatorPhone"].ToString();
                                    obj1.CosolidatorName = row["CosolidatorName"].ToString();
                                    obj1.IsActive = clsFormat.BooleanConvert(row["IsActive"]);
                                    obj1.IsDelete = clsFormat.BooleanConvert(row["IsDelete"]);
                                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Report"].ConnectionString;
                                    DataIn.PINCARD_CONSOLIDATORS_InsertUpdate(obj1);
                                }
                                foreach (DataRow row in ds.Tables[1].Rows)
                                {
                                    PINCARDCOSTS obj1 = new PINCARDCOSTS();
                                    obj1.Cost = clsFormat.DecimalConvert(row["Cost"].ToString());
                                    obj1.IsActive = clsFormat.BooleanConvert(row["IsActive"]);
                                    obj1.IsDelete = clsFormat.BooleanConvert(row["IsDelete"]);
                                    obj1.PincardCostDesc = row["PincardCostDesc"].ToString();
                                    obj1.PincardCostID = clsFormat.IntConvertNull(row["PincardCostID"].ToString());
                                    obj1.PincardCostName = row["PincardCostName"].ToString();
                                    obj1.PincardCostNo = row["PincardCostNo"].ToString();
                                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Report"].ConnectionString;
                                    DataIn.PINCARD_PINCARDCOSTS_InsertUpdate(obj1);
                                }
                                foreach (DataRow row in ds.Tables[2].Rows)
                                {
                                    PINCARDNOMINALS obj1 = new PINCARDNOMINALS();
                                    obj1.FK_PincardCostID = clsFormat.IntConvertNull(row["FK_PincardCostID"].ToString());
                                    obj1.FK_ServiceConsolidatorID = clsFormat.IntConvertNull(row["FK_ServiceConsolidatorID"].ToString());
                                    obj1.LogichCostCode = row["LogichCostCode"].ToString();
                                    obj1.PincardNominalID = clsFormat.IntConvertNull(row["PincardNominalID"].ToString());
                                    obj1.PincardNominalName = row["PincardNominalName"].ToString();
                                    obj1.UPGCardProductionID = clsFormat.IntConvertNull(row["UPGCardProductionID"].ToString());
                                    obj1.Commission = clsFormat.DecimalConvertNull(row["Commission"].ToString());
                                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Report"].ConnectionString;
                                    DataIn.PINCARD_PINCARDNOMINALS_InsertUpdate(obj1);
                                }
                                foreach (DataRow row in ds.Tables[3].Rows)
                                {
                                    PINCARDTYPES obj1 = new PINCARDTYPES();
                                    obj1.IsActive = clsFormat.BooleanConvert(row["IsActive"]);
                                    obj1.IsDelete = clsFormat.BooleanConvert(row["IsDelete"]);
                                    obj1.PinCardTypeId = clsFormat.IntConvertNull(row["PinCardTypeId"].ToString());
                                    obj1.PinCardTypeName = row["PinCardTypeName"].ToString();
                                    obj1.PinCardTypeNo = row["PinCardTypeNo"].ToString();
                                    obj1.Priority = clsFormat.IntConvertNull(row["Priority"].ToString());
                                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Report"].ConnectionString;
                                    DataIn.PINCARD_PINCARDTYPES_InsertUpdate(obj1);
                                }
                                foreach (DataRow row in ds.Tables[4].Rows)
                                {
                                    Librarys.PINCARD.PROVIDERS obj1 = new Librarys.PINCARD.PROVIDERS();
                                    obj1.IsActive = clsFormat.BooleanConvert(row["IsActive"]);
                                    obj1.ProviderId = clsFormat.IntConvertNull(row["ProviderId"].ToString());
                                    obj1.ProviderImageUrl = row["ProviderImageUrl"].ToString();
                                    obj1.ProviderName = row["ProviderName"].ToString();
                                    obj1.ProviderNo = row["ProviderNo"].ToString();
                                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Report"].ConnectionString;
                                    DataIn.PINCARD_PROVIDERS_InsertUpdate(obj1);
                                }
                                foreach (DataRow row in ds.Tables[5].Rows)
                                {
                                    SERVICECONSOLIDATORS obj1 = new SERVICECONSOLIDATORS();
                                    obj1.FK_ConsolidatorID = clsFormat.IntConvertNull(row["FK_ConsolidatorID"].ToString());
                                    obj1.FK_ServiceID = clsFormat.IntConvertNull(row["FK_ServiceID"].ToString());
                                    obj1.ServiceConsolidatorID = clsFormat.IntConvertNull(row["ServiceConsolidatorID"].ToString());
                                    obj1.ServiceConsolidatorName = row["ServiceConsolidatorName"].ToString();
                                    obj1.ServiceConsolidatorOrder = clsFormat.IntConvertNull(row["ServiceConsolidatorOrder"].ToString());
                                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Report"].ConnectionString;
                                    DataIn.PINCARD_SERVICECONSOLIDATORS_InsertUpdate(obj1);
                                }
                                foreach (DataRow row in ds.Tables[6].Rows)
                                {
                                    Librarys.PINCARD.SERVICES obj1 = new Librarys.PINCARD.SERVICES();
                                    obj1.FK_ProviderID = clsFormat.IntConvertNull(row["FK_ProviderID"].ToString());
                                    obj1.ServiceID = clsFormat.IntConvertNull(row["ServiceID"].ToString());
                                    obj1.ServiceDesc = row["ServiceDesc"].ToString();
                                    obj1.ServiceName = row["ServiceName"].ToString();
                                    obj1.ServiceNo = row["ServiceNo"].ToString();
                                    obj1.ServiceOrder = clsFormat.IntConvertNull(row["ServiceOrder"].ToString());
                                    obj1.IsActive = clsFormat.BooleanConvert(row["IsActive"]);
                                    obj1.IsDelete = clsFormat.BooleanConvert(row["IsDelete"]);
                                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Report"].ConnectionString;
                                    DataIn.PINCARD_SERVICES_InsertUpdate(obj1);
                                }
                                Logger.Log("Syn data from pincards to report : Successfull !");
                            }
                        }
                        #endregion
                    }

                    #region Deactive Tariff Nominal
                    Logger.Log("Get tariff nominal is active from database to deactive:______________________________________________");
                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Pincard"].ConnectionString;
                    List<Librarys.PINCARD.TARIFFNOMINAL> lstTariffNominal1 = DataOut.PINCARD_GetAllTARIFFNOMINALListIsActive();
                    if (lstTariffNominal1.Count > 0)
                    {
                        foreach (Librarys.PINCARD.TARIFFNOMINAL tariffnominal in lstTariffNominal1)
                        {
                            Int64 TariffNominalID = clsFormat.Int64Convert(tariffnominal.TariffNominalID);
                            Int64 TariffID = clsFormat.Int64Convert(tariffnominal.TariffID);
                            Int64 ThresholdID = clsFormat.Int64Convert(tariffnominal.ThresholdID);
                            int NominalID = clsFormat.IntConvert(tariffnominal.NominalID);
                            DateTime FromDate = clsFormat.DateConvert(tariffnominal.FromDate);
                            DateTime ToDate = clsFormat.DateConvert(tariffnominal.ToDate);
                            foreach (Librarys.PINCARD.TARIFFNOMINAL tariffnominal1 in lstTariffNominal1)
                            {
                                if (tariffnominal1.IsActive == true)
                                {
                                    if (tariffnominal1.TariffID == TariffID && tariffnominal1.ThresholdID == ThresholdID
                                        && tariffnominal1.FromDate == FromDate && tariffnominal1.ToDate == ToDate
                                        && tariffnominal1.NominalID == NominalID && tariffnominal1.TariffNominalID != TariffNominalID)
                                    {
                                        tariffnominal1.IsActive = false;
                                        tariffnominal1.UpdateBy = 1;
                                        tariffnominal1.UpdateDate = DateTime.Now;
                                        if (DataIn.PINCARD_TARIFFNOMINAL_InsertUpdate(tariffnominal1))
                                        {
                                            Logger.Log("Deactive tariff of nominal : " + tariffnominal.TariffNominalID.ToString());
                                        }
                                    }
                                }
                            }
                            if (tariffnominal.ToDate != null && tariffnominal.IsActive == true)
                            {
                                if (tariffnominal.ToDate < DateTime.Now)
                                {
                                    tariffnominal.IsActive = false;
                                    tariffnominal.UpdateBy = 1;
                                    tariffnominal.UpdateDate = DateTime.Now;
                                    if (DataIn.PINCARD_TARIFFNOMINAL_InsertUpdate(tariffnominal))
                                    {
                                        Logger.Log("Deactive tariff of nominal : " + tariffnominal.TariffNominalID.ToString());
                                    }
                                }
                            }
                        }
                    }
                    #endregion

                    #region Deactive Threshold Nominal
                    Logger.Log("Get threshold nominal is active from database to deactive:______________________________________________");
                    List<THRESHOLDNOMINAL> lstThresholdNominal1 = DataOut.PINCARD_GetAllTHRESHOLDNOMINALListIsActive();
                    if (lstThresholdNominal1.Count > 0)
                    {
                        foreach (THRESHOLDNOMINAL thresholdnominal in lstThresholdNominal1)
                        {
                            Int64 ThresholdNominalID = clsFormat.Int64Convert(thresholdnominal.ThresholdNominalID);
                            Int64 ThresholdID = clsFormat.Int64Convert(thresholdnominal.ThresholdID);
                            int NominalID = clsFormat.IntConvert(thresholdnominal.NominalID);
                            DateTime FromDate = clsFormat.DateConvert(thresholdnominal.FromDate);
                            DateTime Todate = clsFormat.DateConvert(thresholdnominal.ToDate);
                            foreach (THRESHOLDNOMINAL thresholdnominal1 in lstThresholdNominal1)
                            {
                                if (thresholdnominal1.IsActive == true)
                                {
                                    if (thresholdnominal1.ThresholdID == ThresholdID && thresholdnominal1.NominalID == NominalID
                                        && thresholdnominal1.FromDate == FromDate && thresholdnominal1.ToDate == Todate
                                        && thresholdnominal1.ThresholdNominalID != ThresholdNominalID)
                                    {
                                        thresholdnominal1.IsActive = false;
                                        thresholdnominal1.UpdateBy = 1;
                                        thresholdnominal1.UpdateDate = DateTime.Now;
                                        if (DataIn.PINCARD_THRESHOLDNOMINAL_InsertUpdate(thresholdnominal1))
                                        {
                                            Logger.Log("Deactive threshold of nominal : " + thresholdnominal1.ThresholdNominalID.ToString());
                                        }
                                    }
                                }
                            }
                            if (thresholdnominal.ToDate != null)
                            {
                                if (thresholdnominal.ToDate < DateTime.Now && thresholdnominal.IsActive == true)
                                {
                                    thresholdnominal.IsActive = false;
                                    thresholdnominal.UpdateBy = 1;
                                    thresholdnominal.UpdateDate = DateTime.Now;
                                    if (DataIn.PINCARD_THRESHOLDNOMINAL_InsertUpdate(thresholdnominal))
                                    {
                                        Logger.Log("Deactive threshold of nominal : " + thresholdnominal.ThresholdNominalID.ToString());
                                    }
                                }
                            }
                        }
                    }
                    #endregion

                    Logger.Log("Get Config Type 1 from Database:______________________________________________");
                    List<Librarys.PINCARD.CONFIGURATION> lstConfig1 = DataOut.PINCARD_GetAllCONFIGURATIONListByTypeId(1);
                    if (lstConfig1.Count > 0)
                    {
                        #region lstConfig1.Count > 0
                        foreach (Librarys.PINCARD.CONFIGURATION config in lstConfig1)
                        {
                            RunTime = clsFormat.DateConvert(config.ConfigDate);
                            Hour = config.ConfigTime.Hours;
                            Minute = config.ConfigTime.Minutes;
                            Second = config.ConfigTime.Seconds;
                            Email = config.ConfigEmailTo;
                            EmailCC = config.ConfigEmailCC;
                            EmailBCC = config.ConfigEmailBCC;
                            Value = clsFormat.IntConvert(config.ConfigValue);
                        }

                        if (DateTime.Now.Hour == Hour && DateTime.Now.Minute == Minute)
                        {
                            #region Process Tariff Nominal of Pincards
                            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Pincard"].ConnectionString;
                            List<Librarys.PINCARD.TARIFFNOMINAL> lstTariffNominal = DataOut.PINCARD_GetAllTARIFFNOMINALListIsActive();
                            Logger.Log("Get tariff of nominal list from database to auto buy :______________________________________________" + lstTariffNominal.Count);
                            if (lstTariffNominal.Count > 0)
                            {
                                foreach (Librarys.PINCARD.TARIFFNOMINAL tariffnominal in lstTariffNominal)
                                {
                                    Logger.Log("TariffNominalID : " + tariffnominal.TariffNominalID);
                                    Logger.Log("Get threshold of nominal list from database to auto buy :______________________________________________" + tariffnominal.TariffNominalID);
                                    List<THRESHOLD> lstThresshold = DataOut.PINCARD_GetAllTHRESHOLDListIsActiveById(clsFormat.Int64Convert(tariffnominal.ThresholdID));
                                    if (lstThresshold.Count > 0)
                                    {
                                        foreach (THRESHOLD threshold in lstThresshold)
                                        {
                                            ThressholdValue = clsFormat.IntConvert(threshold.ThresholdValue);
                                            Logger.Log("Threshold values pincards of tariff ___________________________________________________________________________________" + tariffnominal.TariffNominalID);
                                        }
                                    }
                                    List<PINCARDNOMINALS> lstPincardNominal = DataOut.PINCARD_GetAllPINCARDNOMINALSListByUPGCardProductionID(clsFormat.Int64Convert(tariffnominal.NominalID));
                                    if (lstPincardNominal.Count > 0)
                                    {
                                        bool IsEmail = false;
                                        foreach (PINCARDNOMINALS pinmon in lstPincardNominal)
                                        {
                                            if (pinmon.ConsolidatorID == 1)
                                            {
                                                #region Logich
                                                List<InventoryPinCode> lstPinCode = PincardController.GetAvailablePincards();
                                                Logger.Log("Get Inventory pincards from UPG___________________________________________________________________________________" + lstPinCode.Count.ToString());
                                                if (lstPinCode.Count > 0)
                                                {
                                                    foreach (InventoryPinCode pincode in lstPinCode)
                                                    {
                                                        Value = clsFormat.IntConvert(pincode.CardsCount);
                                                        Logger.Log("Inventory of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                        if (ThressholdValue > Value && pinmon.UPGCardProductionID == clsFormat.IntConvertNull(pincode.CardProductionID))
                                                        {
                                                            IsEmail = true;
                                                            int NumNeedBuy = ThressholdValue - Value;
                                                            double Commission = (double)pinmon.Commission;
                                                            Logger.Log("Buy pincards from Logich with quantity : " + NumNeedBuy + "| Commission : " + Commission);
                                                            for (int a = 0; a < NumNeedBuy; a++)
                                                            {
                                                                if (BuyPincard(1, clsFormat.IntConvert(pinmon.ConsolidatorID), Commission, clsFormat.StringConvert(pinmon.UPGCardProductionID)))
                                                                {
                                                                    Librarys.PINCARD.BUYCARDHISTORY objBuyHis = new Librarys.PINCARD.BUYCARDHISTORY();
                                                                    objBuyHis.BuyDate = DateTime.Now;
                                                                    objBuyHis.BuyID = null;
                                                                    objBuyHis.CardCount = Value;
                                                                    objBuyHis.Commission = clsFormat.DecimalConvert(Commission);
                                                                    objBuyHis.ConsolidatorID = pinmon.ConsolidatorID;
                                                                    objBuyHis.NominalID = clsFormat.Int64Convert(pincode.CardProductionID);
                                                                    objBuyHis.NominalName = pincode.CardNominalName;
                                                                    objBuyHis.Note = "Action buy pincards from Logich";
                                                                    objBuyHis.NumberBuy = 1;
                                                                    objBuyHis.Privider = "LOGICH";
                                                                    objBuyHis.TariffNominalID = tariffnominal.TariffNominalID;
                                                                    objBuyHis.ThresholdID = ThressholdValue;
                                                                    objBuyHis.ThresholdNominalID = null;
                                                                    DataIn.PINCARD_BUYCARDHISTORY_InsertUpdate(objBuyHis);
                                                                    Logger.Log("Action buy pincards from Logich sucessful with TariffNominalID : " + tariffnominal.TariffNominalID + " | CardProductionID : " + pincode.CardProductionID);
                                                                }
                                                                else
                                                                {
                                                                    Logger.Log("Action buy pincards from Logich failure with TariffNominalID : " + tariffnominal.TariffNominalID + " | CardProductionID : " + pincode.CardProductionID);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Logger.Log("Not pincards find in inventory___________________________________________________________________________________");
                                                }
                                                #endregion
                                            }

                                            if (pinmon.ConsolidatorID == 2)
                                            {
                                                #region VTC
                                                List<InventoryPinCode> lstPinCode = PincardController.GetAvailablePincards();
                                                Logger.Log("Get Inventory pincards from UPG___________________________________________________________________________________" + lstPinCode.Count.ToString());
                                                if (lstPinCode.Count > 0)
                                                {
                                                    foreach (InventoryPinCode pincode in lstPinCode)
                                                    {
                                                        Value = clsFormat.IntConvert(pincode.CardsCount);
                                                        Logger.Log("Inventory of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                        if (ThressholdValue > Value && pinmon.UPGCardProductionID == clsFormat.IntConvertNull(pincode.CardProductionID))
                                                        {
                                                            IsEmail = true;
                                                            int NumNeedBuy = ThressholdValue - Value;
                                                            double Commission = (double)pinmon.Commission;
                                                            Logger.Log("Buy pincards from VTC with quantity : " + NumNeedBuy + "| Commission : " + Commission);
                                                            for (int a = 0; a < NumNeedBuy; a++)
                                                            {
                                                                if (BuyPincard(1, clsFormat.IntConvert(pinmon.ConsolidatorID), Commission, clsFormat.StringConvert(pinmon.UPGCardProductionID)))
                                                                {
                                                                    Librarys.PINCARD.BUYCARDHISTORY objBuyHis = new Librarys.PINCARD.BUYCARDHISTORY();
                                                                    objBuyHis.BuyDate = DateTime.Now;
                                                                    objBuyHis.BuyID = null;
                                                                    objBuyHis.CardCount = Value;
                                                                    objBuyHis.Commission = clsFormat.DecimalConvert(Commission);
                                                                    objBuyHis.ConsolidatorID = pinmon.ConsolidatorID;
                                                                    objBuyHis.NominalID = clsFormat.Int64Convert(pincode.CardProductionID);
                                                                    objBuyHis.NominalName = pincode.CardNominalName;
                                                                    objBuyHis.Note = "Action buy pincards from VTC";
                                                                    objBuyHis.NumberBuy = 1;
                                                                    objBuyHis.Privider = "VTC";
                                                                    objBuyHis.TariffNominalID = tariffnominal.TariffNominalID;
                                                                    objBuyHis.ThresholdID = ThressholdValue;
                                                                    objBuyHis.ThresholdNominalID = null;
                                                                    DataIn.PINCARD_BUYCARDHISTORY_InsertUpdate(objBuyHis);
                                                                    Logger.Log("Action buy pincards from VTC sucessful with TariffNominalID : " + tariffnominal.TariffNominalID + " | CardProductionID : " + pincode.CardProductionID + " | Number Cards Need Buy : " + NumNeedBuy);
                                                                }
                                                                else
                                                                {
                                                                    Logger.Log("Action buy pincards from VTC failure with TariffNominalID : " + tariffnominal.TariffNominalID + " | CardProductionID : " + pincode.CardProductionID + " | Number Cards Need Buy : " + NumNeedBuy);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Logger.Log("Not pincards find in inventory___________________________________________________________________________________");
                                                }
                                                #endregion
                                            }
                                        }

                                        foreach (PINCARDNOMINALS pinmon in lstPincardNominal)
                                        {
                                            #region Send email to user
                                            List<InventoryPinCode> lstPinCode = PincardController.GetAvailablePincards();
                                            Logger.Log("Get Inventory pincards from UPG___________________________________________________________________________________" + lstPinCode.Count.ToString());
                                            if (lstPinCode.Count > 0)
                                            {
                                                Logger.Log("Inventory pincards from UPG : " + lstPinCode.Count);
                                                foreach (InventoryPinCode pincode in lstPinCode)
                                                {
                                                    Value = clsFormat.IntConvert(pincode.CardsCount);
                                                    Logger.Log("Inventory of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                    if (ThressholdValue > Value && IsEmail 
                                                        && pinmon.UPGCardProductionID == clsFormat.IntConvertNull(pincode.CardProductionID))
                                                    {
                                                        if (Email != string.Empty)
                                                        {
                                                            Logger.Log("Send Email information of TariffNominalID : " + tariffnominal.TariffNominalID);
                                                            string messageBody = "- Số lượng mã thẻ : " + pinmon.PincardNominalName + " - ID : " + pinmon.UPGCardProductionID + " đã mua không đủ số lượng sàn." + "<br/>"
                                                                + " - Xin kiểm tra lại thông tin ở các nhà cung cấp.";
                                                            string[] sep = { ";" };
                                                            string[] strResult = Email.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                                                            if (strResult.Length > 0)
                                                            {
                                                                foreach (string subString in strResult)
                                                                {
                                                                    if (subString != string.Empty && subString != null)
                                                                    {
                                                                        SendMail(messageBody, subString.Trim());
                                                                    }
                                                                }
                                                            }
                                                            Logger.Log("Send Email information of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                        }
                                                    }
                                                }
                                            }
                                            #endregion
                                            break;
                                        }
                                    }
                                }
                            }
                            #endregion

                            #region Process Threshold Nominal of Pincards
                            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Pincard"].ConnectionString;
                            List<THRESHOLDNOMINAL> lstThresholdNominal = DataOut.PINCARD_GetAllTHRESHOLDNOMINALListIsActive();
                            Logger.Log("Get list threshold of pincards from database to auto buy :______________________________________________" + lstThresholdNominal.Count);
                            if (lstThresholdNominal.Count > 0)
                            {
                                foreach (THRESHOLDNOMINAL thresholdnominal in lstThresholdNominal)
                                {
                                    Logger.Log("ThresholdNominalID : " + thresholdnominal.ThresholdNominalID);
                                    Logger.Log("Get threshold of nominal list from database to auto buy :______________________________________________" + thresholdnominal.ThresholdNominalID);
                                    List<THRESHOLD> lstThresshold = DataOut.PINCARD_GetAllTHRESHOLDListIsActiveById(clsFormat.Int64Convert(thresholdnominal.ThresholdID));
                                    if (lstThresshold.Count > 0)
                                    {
                                        foreach (THRESHOLD threshold in lstThresshold)
                                        {
                                            ThressholdValue = clsFormat.IntConvert(threshold.ThresholdValue);
                                            Logger.Log("Threshold values of pincards ___________________________________________________________________________________" + thresholdnominal.ThresholdNominalID);
                                        }
                                    }
                                    List<PINCARDNOMINALS> lstPincardNominal = DataOut.PINCARD_GetAllPINCARDNOMINALSListByUPGCardProductionID(clsFormat.Int64Convert(thresholdnominal.NominalID));
                                    if (lstPincardNominal.Count > 0)
                                    {
                                        bool IsEmail = false;
                                        foreach (PINCARDNOMINALS pinmon in lstPincardNominal)
                                        {
                                            if (pinmon.ConsolidatorID == 1)
                                            {
                                                #region Logich
                                                List<InventoryPinCode> lstPinCode = PincardController.GetAvailablePincards();
                                                Logger.Log("Get Inventory pincards from UPG___________________________________________________________________________________" + lstPinCode.Count.ToString());
                                                if (lstPinCode.Count > 0)
                                                {
                                                    foreach (InventoryPinCode pincode in lstPinCode)
                                                    {
                                                        Value = clsFormat.IntConvert(pincode.CardsCount);
                                                        Logger.Log("Inventory of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                        if (ThressholdValue > Value && pinmon.UPGCardProductionID == clsFormat.IntConvertNull(pincode.CardProductionID))
                                                        {
                                                            IsEmail = true;
                                                            int NumNeedBuy = ThressholdValue - Value;
                                                            double Commission = (double)pinmon.Commission;
                                                            Logger.Log("Buy pincards from Logich with quantity : " + NumNeedBuy + "| Commission : " + Commission);
                                                            for (int a = 0; a < NumNeedBuy; a++)
                                                            {
                                                                if (BuyPincard(1, clsFormat.IntConvert(pinmon.ConsolidatorID), Commission, clsFormat.StringConvert(pinmon.UPGCardProductionID)))
                                                                {
                                                                    Librarys.PINCARD.BUYCARDHISTORY objBuyHis = new Librarys.PINCARD.BUYCARDHISTORY();
                                                                    objBuyHis.BuyDate = DateTime.Now;
                                                                    objBuyHis.BuyID = null;
                                                                    objBuyHis.CardCount = Value;
                                                                    objBuyHis.Commission = clsFormat.DecimalConvert(Commission);
                                                                    objBuyHis.ConsolidatorID = pinmon.ConsolidatorID;
                                                                    objBuyHis.NominalID = clsFormat.Int64Convert(pincode.CardProductionID);
                                                                    objBuyHis.NominalName = pincode.CardNominalName;
                                                                    objBuyHis.Note = "Action buy pincards from Logich";
                                                                    objBuyHis.NumberBuy = 1;
                                                                    objBuyHis.Privider = "LOGICH";
                                                                    objBuyHis.TariffNominalID = null;
                                                                    objBuyHis.ThresholdID = ThressholdValue;
                                                                    objBuyHis.ThresholdNominalID = thresholdnominal.ThresholdNominalID;
                                                                    DataIn.PINCARD_BUYCARDHISTORY_InsertUpdate(objBuyHis);
                                                                    Logger.Log("Action buy pincards from Logich sucessful with ThresholdNominalID : " + thresholdnominal.ThresholdNominalID + " | CardProductionID : " + pincode.CardProductionID);
                                                                }
                                                                else
                                                                {
                                                                    Logger.Log("Action buy pincards from Logich failure with ThresholdNominalID : " + thresholdnominal.ThresholdNominalID + " | CardProductionID : " + pincode.CardProductionID);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Logger.Log("Not pincards find in inventory___________________________________________________________________________________");
                                                }
                                                #endregion
                                            }

                                            if (pinmon.ConsolidatorID == 2)
                                            {
                                                #region VTC
                                                List<InventoryPinCode> lstPinCode = PincardController.GetAvailablePincards();
                                                Logger.Log("Get Inventory pincards from UPG___________________________________________________________________________________" + lstPinCode.Count.ToString());
                                                if (lstPinCode.Count > 0)
                                                {
                                                    foreach (InventoryPinCode pincode in lstPinCode)
                                                    {
                                                        Value = clsFormat.IntConvert(pincode.CardsCount);
                                                        Logger.Log("Inventory of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                        if (ThressholdValue > Value && pinmon.UPGCardProductionID == clsFormat.IntConvertNull(pincode.CardProductionID))
                                                        {
                                                            IsEmail = true;
                                                            int NumNeedBuy = ThressholdValue - Value;
                                                            double Commission = (double)pinmon.Commission;
                                                            Logger.Log("Buy pincards from VTC with quantity : " + NumNeedBuy + "| Commission : " + Commission);
                                                            for (int a = 0; a < NumNeedBuy; a++)
                                                            {
                                                                if (BuyPincard(1, clsFormat.IntConvert(pinmon.ConsolidatorID), Commission, clsFormat.StringConvert(pinmon.UPGCardProductionID)))
                                                                {
                                                                    Librarys.PINCARD.BUYCARDHISTORY objBuyHis = new Librarys.PINCARD.BUYCARDHISTORY();
                                                                    objBuyHis.BuyDate = DateTime.Now;
                                                                    objBuyHis.BuyID = null;
                                                                    objBuyHis.CardCount = Value;
                                                                    objBuyHis.Commission = clsFormat.DecimalConvert(Commission);
                                                                    objBuyHis.ConsolidatorID = pinmon.ConsolidatorID;
                                                                    objBuyHis.NominalID = clsFormat.Int64Convert(pincode.CardProductionID);
                                                                    objBuyHis.NominalName = pincode.CardNominalName;
                                                                    objBuyHis.Note = "Action buy pincards from VTC";
                                                                    objBuyHis.NumberBuy = 1;
                                                                    objBuyHis.Privider = "VTC";
                                                                    objBuyHis.TariffNominalID = null;
                                                                    objBuyHis.ThresholdID = ThressholdValue;
                                                                    objBuyHis.ThresholdNominalID = thresholdnominal.ThresholdNominalID;
                                                                    DataIn.PINCARD_BUYCARDHISTORY_InsertUpdate(objBuyHis);
                                                                    Logger.Log("Action buy pincards from VTC sucessful with ThresholdNominalID : " + thresholdnominal.ThresholdNominalID + " | CardProductionID : " + pincode.CardProductionID + " | Number Cards Need Buy : " + NumNeedBuy);
                                                                }
                                                                else
                                                                {
                                                                    Logger.Log("Action buy pincards from VTC failure with ThresholdNominalID : " + thresholdnominal.ThresholdNominalID + " | CardProductionID : " + pincode.CardProductionID + " | Number Cards Need Buy : " + NumNeedBuy);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Logger.Log("Not pincards find in inventory___________________________________________________________________________________");
                                                }
                                                #endregion
                                            }
                                        }

                                        foreach (PINCARDNOMINALS pinmon in lstPincardNominal)
                                        {
                                            #region Send email to user
                                            List<InventoryPinCode> lstPinCode = PincardController.GetAvailablePincards();
                                            Logger.Log("Get Inventory pincards from UPG___________________________________________________________________________________" + lstPinCode.Count.ToString());
                                            if (lstPinCode.Count > 0)
                                            {
                                                Logger.Log("Inventory pincards from UPG : " + lstPinCode.Count);
                                                foreach (InventoryPinCode pincode in lstPinCode)
                                                {
                                                    Value = clsFormat.IntConvert(pincode.CardsCount);
                                                    Logger.Log("Inventory of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                    if (ThressholdValue > Value && IsEmail
                                                        && pinmon.UPGCardProductionID == clsFormat.IntConvertNull(pincode.CardProductionID))
                                                    {
                                                        if (Email != string.Empty)
                                                        {
                                                            Logger.Log("Send Email information of ThresholdNominalID : " + thresholdnominal.ThresholdNominalID);
                                                            string messageBody = "- Số lượng mã thẻ : " + pinmon.PincardNominalName + " - ID : " + pinmon.UPGCardProductionID + " đã mua không đủ số lượng sàn." + "<br/>"
                                                                + " - Xin kiểm tra lại thông tin ở các nhà cung cấp.";
                                                            string[] sep = { ";" };
                                                            string[] strResult = Email.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                                                            if (strResult.Length > 0)
                                                            {
                                                                foreach (string subString in strResult)
                                                                {
                                                                    if (subString != string.Empty && subString != null)
                                                                    {
                                                                        SendMail(messageBody, subString.Trim());
                                                                    }
                                                                }
                                                            }
                                                            Logger.Log("Send Email information of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                        }
                                                    }
                                                }
                                            }
                                            #endregion
                                            break;
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    }
                    else
                    {
                        #region lstConfig1.Count <= 0
                        Logger.Log("Get Config Type 2 from Database:______________________________________________");
                        Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Pincard"].ConnectionString;
                        List<Librarys.PINCARD.CONFIGURATION> lstConfig2 = DataOut.PINCARD_GetAllCONFIGURATIONListByTypeId(2);
                        if (lstConfig2.Count > 0)
                        {
                            foreach (Librarys.PINCARD.CONFIGURATION config in lstConfig2)
                            {
                                RunTime = clsFormat.DateConvert(config.ConfigDate);
                                Hour = config.ConfigTime.Hours;
                                Minute = config.ConfigTime.Minutes;
                                Second = config.ConfigTime.Seconds;
                                Email = config.ConfigEmailTo;
                                EmailCC = config.ConfigEmailCC;
                                EmailBCC = config.ConfigEmailBCC;
                                Value = clsFormat.IntConvert(config.ConfigValue);
                            }

                            #region Process Tariff Nominal of Pincards
                            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Pincard"].ConnectionString;
                            List<Librarys.PINCARD.TARIFFNOMINAL> lstTariffNominal = DataOut.PINCARD_GetAllTARIFFNOMINALListIsActive();
                            Logger.Log("Get tariff of nominal list from database to auto buy :______________________________________________" + lstTariffNominal.Count);
                            if (lstTariffNominal.Count > 0)
                            {
                                foreach (Librarys.PINCARD.TARIFFNOMINAL tariffnominal in lstTariffNominal)
                                {
                                    Logger.Log("TariffNominalID : " + tariffnominal.TariffNominalID);
                                    Logger.Log("Get threshold of nominal list from database to auto buy :______________________________________________" + tariffnominal.TariffNominalID);
                                    List<THRESHOLD> lstThresshold = DataOut.PINCARD_GetAllTHRESHOLDListIsActiveById(clsFormat.Int64Convert(tariffnominal.ThresholdID));
                                    if (lstThresshold.Count > 0)
                                    {
                                        foreach (THRESHOLD threshold in lstThresshold)
                                        {
                                            ThressholdValue = clsFormat.IntConvert(threshold.ThresholdValue);
                                            Logger.Log("Threshold values pincards of tariff ___________________________________________________________________________________" + tariffnominal.TariffNominalID);
                                        }
                                    }
                                    List<PINCARDNOMINALS> lstPincardNominal = DataOut.PINCARD_GetAllPINCARDNOMINALSListByUPGCardProductionID(clsFormat.Int64Convert(tariffnominal.NominalID));
                                    if (lstPincardNominal.Count > 0)
                                    {
                                        bool IsEmail = false;
                                        foreach (PINCARDNOMINALS pinmon in lstPincardNominal)
                                        {
                                            if (pinmon.ConsolidatorID == 1)
                                            {
                                                #region Logich
                                                List<InventoryPinCode> lstPinCode = PincardController.GetAvailablePincards();
                                                Logger.Log("Get Inventory pincards from UPG___________________________________________________________________________________" + lstPinCode.Count.ToString());
                                                if (lstPinCode.Count > 0)
                                                {
                                                    foreach (InventoryPinCode pincode in lstPinCode)
                                                    {
                                                        Value = clsFormat.IntConvert(pincode.CardsCount);
                                                        Logger.Log("Inventory of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                        if (ThressholdValue > Value && pinmon.UPGCardProductionID == clsFormat.IntConvertNull(pincode.CardProductionID))
                                                        {
                                                            IsEmail = true;
                                                            int NumNeedBuy = ThressholdValue - Value;
                                                            double Commission = (double)pinmon.Commission;
                                                            Logger.Log("Buy pincards from Logich with quantity : " + NumNeedBuy + "| Commission : " + Commission);
                                                            for (int a = 0; a < NumNeedBuy; a++)
                                                            {
                                                                if (BuyPincard(1, clsFormat.IntConvert(pinmon.ConsolidatorID), Commission, clsFormat.StringConvert(pinmon.UPGCardProductionID)))
                                                                {
                                                                    Librarys.PINCARD.BUYCARDHISTORY objBuyHis = new Librarys.PINCARD.BUYCARDHISTORY();
                                                                    objBuyHis.BuyDate = DateTime.Now;
                                                                    objBuyHis.BuyID = null;
                                                                    objBuyHis.CardCount = Value;
                                                                    objBuyHis.Commission = clsFormat.DecimalConvert(Commission);
                                                                    objBuyHis.ConsolidatorID = pinmon.ConsolidatorID;
                                                                    objBuyHis.NominalID = clsFormat.Int64Convert(pincode.CardProductionID);
                                                                    objBuyHis.NominalName = pincode.CardNominalName;
                                                                    objBuyHis.Note = "Action buy pincards from Logich";
                                                                    objBuyHis.NumberBuy = 1;
                                                                    objBuyHis.Privider = "LOGICH";
                                                                    objBuyHis.TariffNominalID = tariffnominal.TariffNominalID;
                                                                    objBuyHis.ThresholdID = ThressholdValue;
                                                                    objBuyHis.ThresholdNominalID = null;
                                                                    DataIn.PINCARD_BUYCARDHISTORY_InsertUpdate(objBuyHis);
                                                                    Logger.Log("Action buy pincards from Logich sucessful with TariffNominalID : " + tariffnominal.TariffNominalID + " | CardProductionID : " + pincode.CardProductionID);
                                                                }
                                                                else
                                                                {
                                                                    Logger.Log("Action buy pincards from Logich failure with TariffNominalID : " + tariffnominal.TariffNominalID + " | CardProductionID : " + pincode.CardProductionID);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Logger.Log("Not pincards find in inventory___________________________________________________________________________________");
                                                }
                                                #endregion
                                            }

                                            if (pinmon.ConsolidatorID == 2)
                                            {
                                                #region VTC
                                                List<InventoryPinCode> lstPinCode = PincardController.GetAvailablePincards();
                                                Logger.Log("Get Inventory pincards from UPG___________________________________________________________________________________" + lstPinCode.Count.ToString());
                                                if (lstPinCode.Count > 0)
                                                {
                                                    foreach (InventoryPinCode pincode in lstPinCode)
                                                    {
                                                        Value = clsFormat.IntConvert(pincode.CardsCount);
                                                        Logger.Log("Inventory of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                        if (ThressholdValue > Value && pinmon.UPGCardProductionID == clsFormat.IntConvertNull(pincode.CardProductionID))
                                                        {
                                                            IsEmail = true;
                                                            int NumNeedBuy = ThressholdValue - Value;
                                                            double Commission = (double)pinmon.Commission;
                                                            Logger.Log("Buy pincards from VTC with quantity : " + NumNeedBuy + "| Commission : " + Commission);
                                                            for (int a = 0; a < NumNeedBuy; a++)
                                                            {
                                                                if (BuyPincard(1, clsFormat.IntConvert(pinmon.ConsolidatorID), Commission, clsFormat.StringConvert(pinmon.UPGCardProductionID)))
                                                                {
                                                                    Librarys.PINCARD.BUYCARDHISTORY objBuyHis = new Librarys.PINCARD.BUYCARDHISTORY();
                                                                    objBuyHis.BuyDate = DateTime.Now;
                                                                    objBuyHis.BuyID = null;
                                                                    objBuyHis.CardCount = Value;
                                                                    objBuyHis.Commission = clsFormat.DecimalConvert(Commission);
                                                                    objBuyHis.ConsolidatorID = pinmon.ConsolidatorID;
                                                                    objBuyHis.NominalID = clsFormat.Int64Convert(pincode.CardProductionID);
                                                                    objBuyHis.NominalName = pincode.CardNominalName;
                                                                    objBuyHis.Note = "Action buy pincards from VTC";
                                                                    objBuyHis.NumberBuy = 1;
                                                                    objBuyHis.Privider = "VTC";
                                                                    objBuyHis.TariffNominalID = tariffnominal.TariffNominalID;
                                                                    objBuyHis.ThresholdID = ThressholdValue;
                                                                    objBuyHis.ThresholdNominalID = null;
                                                                    DataIn.PINCARD_BUYCARDHISTORY_InsertUpdate(objBuyHis);
                                                                    Logger.Log("Action buy pincards from VTC sucessful with TariffNominalID : " + tariffnominal.TariffNominalID + " | CardProductionID : " + pincode.CardProductionID + " | Number Cards Need Buy : " + NumNeedBuy);
                                                                }
                                                                else
                                                                {
                                                                    Logger.Log("Action buy pincards from VTC failure with TariffNominalID : " + tariffnominal.TariffNominalID + " | CardProductionID : " + pincode.CardProductionID + " | Number Cards Need Buy : " + NumNeedBuy);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Logger.Log("Not pincards find in inventory___________________________________________________________________________________");
                                                }
                                                #endregion
                                            }
                                        }

                                        foreach (PINCARDNOMINALS pinmon in lstPincardNominal)
                                        {
                                            #region Send email to user
                                            List<InventoryPinCode> lstPinCode = PincardController.GetAvailablePincards();
                                            Logger.Log("Get Inventory pincards from UPG___________________________________________________________________________________" + lstPinCode.Count.ToString());
                                            if (lstPinCode.Count > 0)
                                            {
                                                Logger.Log("Inventory pincards from UPG : " + lstPinCode.Count);
                                                foreach (InventoryPinCode pincode in lstPinCode)
                                                {
                                                    Value = clsFormat.IntConvert(pincode.CardsCount);
                                                    Logger.Log("Inventory of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                    if (ThressholdValue > Value && IsEmail
                                                        && pinmon.UPGCardProductionID == clsFormat.IntConvertNull(pincode.CardProductionID))
                                                    {
                                                        if (Email != string.Empty)
                                                        {
                                                            Logger.Log("Send Email information of TariffNominalID : " + tariffnominal.TariffNominalID);
                                                            string messageBody = "- Số lượng mã thẻ : " + pinmon.PincardNominalName + " - ID : " + pinmon.UPGCardProductionID + " đã mua không đủ số lượng sàn." + "<br/>"
                                                                + " - Xin kiểm tra lại thông tin ở các nhà cung cấp.";
                                                            string[] sep = { ";" };
                                                            string[] strResult = Email.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                                                            if (strResult.Length > 0)
                                                            {
                                                                foreach (string subString in strResult)
                                                                {
                                                                    if (subString != string.Empty && subString != null)
                                                                    {
                                                                        SendMail(messageBody, subString.Trim());
                                                                    }
                                                                }
                                                            }
                                                            Logger.Log("Send Email information of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                        }
                                                    }
                                                }
                                            }
                                            #endregion
                                            break;
                                        }
                                    }
                                }
                            }
                            #endregion

                            #region Process Threshold Nominal of Pincards
                            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Pincard"].ConnectionString;
                            List<THRESHOLDNOMINAL> lstThresholdNominal = DataOut.PINCARD_GetAllTHRESHOLDNOMINALListIsActive();
                            Logger.Log("Get list threshold of pincards from database to auto buy :______________________________________________" + lstThresholdNominal.Count);
                            if (lstThresholdNominal.Count > 0)
                            {
                                foreach (THRESHOLDNOMINAL thresholdnominal in lstThresholdNominal)
                                {
                                    Logger.Log("ThresholdNominalID : " + thresholdnominal.ThresholdNominalID);
                                    Logger.Log("Get threshold of nominal list from database to auto buy :______________________________________________" + thresholdnominal.ThresholdNominalID);
                                    List<THRESHOLD> lstThresshold = DataOut.PINCARD_GetAllTHRESHOLDListIsActiveById(clsFormat.Int64Convert(thresholdnominal.ThresholdID));
                                    if (lstThresshold.Count > 0)
                                    {
                                        foreach (THRESHOLD threshold in lstThresshold)
                                        {
                                            ThressholdValue = clsFormat.IntConvert(threshold.ThresholdValue);
                                            Logger.Log("Threshold values of pincards ___________________________________________________________________________________" + thresholdnominal.ThresholdNominalID);
                                        }
                                    }
                                    List<PINCARDNOMINALS> lstPincardNominal = DataOut.PINCARD_GetAllPINCARDNOMINALSListByUPGCardProductionID(clsFormat.Int64Convert(thresholdnominal.NominalID));
                                    if (lstPincardNominal.Count > 0)
                                    {
                                        bool IsEmail = false;
                                        foreach (PINCARDNOMINALS pinmon in lstPincardNominal)
                                        {
                                            if (pinmon.ConsolidatorID == 1)
                                            {
                                                #region Logich
                                                List<InventoryPinCode> lstPinCode = PincardController.GetAvailablePincards();
                                                Logger.Log("Get Inventory pincards from UPG___________________________________________________________________________________" + lstPinCode.Count.ToString());
                                                if (lstPinCode.Count > 0)
                                                {
                                                    foreach (InventoryPinCode pincode in lstPinCode)
                                                    {
                                                        Value = clsFormat.IntConvert(pincode.CardsCount);
                                                        Logger.Log("Inventory of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                        if (ThressholdValue > Value && pinmon.UPGCardProductionID == clsFormat.IntConvertNull(pincode.CardProductionID))
                                                        {
                                                            IsEmail = true;
                                                            int NumNeedBuy = ThressholdValue - Value;
                                                            double Commission = (double)pinmon.Commission;
                                                            Logger.Log("Buy pincards from Logich with quantity : " + NumNeedBuy + "| Commission : " + Commission);
                                                            for (int a = 0; a < NumNeedBuy; a++)
                                                            {
                                                                if (BuyPincard(1, clsFormat.IntConvert(pinmon.ConsolidatorID), Commission, clsFormat.StringConvert(pinmon.UPGCardProductionID)))
                                                                {
                                                                    Librarys.PINCARD.BUYCARDHISTORY objBuyHis = new Librarys.PINCARD.BUYCARDHISTORY();
                                                                    objBuyHis.BuyDate = DateTime.Now;
                                                                    objBuyHis.BuyID = null;
                                                                    objBuyHis.CardCount = Value;
                                                                    objBuyHis.Commission = clsFormat.DecimalConvert(Commission);
                                                                    objBuyHis.ConsolidatorID = pinmon.ConsolidatorID;
                                                                    objBuyHis.NominalID = clsFormat.Int64Convert(pincode.CardProductionID);
                                                                    objBuyHis.NominalName = pincode.CardNominalName;
                                                                    objBuyHis.Note = "Action buy pincards from Logich";
                                                                    objBuyHis.NumberBuy = 1;
                                                                    objBuyHis.Privider = "LOGICH";
                                                                    objBuyHis.TariffNominalID = null;
                                                                    objBuyHis.ThresholdID = ThressholdValue;
                                                                    objBuyHis.ThresholdNominalID = thresholdnominal.ThresholdNominalID;
                                                                    DataIn.PINCARD_BUYCARDHISTORY_InsertUpdate(objBuyHis);
                                                                    Logger.Log("Action buy pincards from Logich sucessful with ThresholdNominalID : " + thresholdnominal.ThresholdNominalID + " | CardProductionID : " + pincode.CardProductionID);
                                                                }
                                                                else
                                                                {
                                                                    Logger.Log("Action buy pincards from Logich failure with ThresholdNominalID : " + thresholdnominal.ThresholdNominalID + " | CardProductionID : " + pincode.CardProductionID);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Logger.Log("Not pincards find in inventory___________________________________________________________________________________");
                                                }
                                                #endregion
                                            }

                                            if (pinmon.ConsolidatorID == 2)
                                            {
                                                #region VTC
                                                List<InventoryPinCode> lstPinCode = PincardController.GetAvailablePincards();
                                                Logger.Log("Get Inventory pincards from UPG___________________________________________________________________________________" + lstPinCode.Count.ToString());
                                                if (lstPinCode.Count > 0)
                                                {
                                                    foreach (InventoryPinCode pincode in lstPinCode)
                                                    {
                                                        Value = clsFormat.IntConvert(pincode.CardsCount);
                                                        Logger.Log("Inventory of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                        if (ThressholdValue > Value && pinmon.UPGCardProductionID == clsFormat.IntConvertNull(pincode.CardProductionID))
                                                        {
                                                            IsEmail = true;
                                                            int NumNeedBuy = ThressholdValue - Value;
                                                            double Commission = (double)pinmon.Commission;
                                                            Logger.Log("Buy pincards from VTC with quantity : " + NumNeedBuy + "| Commission : " + Commission);
                                                            for (int a = 0; a < NumNeedBuy; a++)
                                                            {
                                                                if (BuyPincard(1, clsFormat.IntConvert(pinmon.ConsolidatorID), Commission, clsFormat.StringConvert(pinmon.UPGCardProductionID)))
                                                                {
                                                                    Librarys.PINCARD.BUYCARDHISTORY objBuyHis = new Librarys.PINCARD.BUYCARDHISTORY();
                                                                    objBuyHis.BuyDate = DateTime.Now;
                                                                    objBuyHis.BuyID = null;
                                                                    objBuyHis.CardCount = Value;
                                                                    objBuyHis.Commission = clsFormat.DecimalConvert(Commission);
                                                                    objBuyHis.ConsolidatorID = pinmon.ConsolidatorID;
                                                                    objBuyHis.NominalID = clsFormat.Int64Convert(pincode.CardProductionID);
                                                                    objBuyHis.NominalName = pincode.CardNominalName;
                                                                    objBuyHis.Note = "Action buy pincards from VTC";
                                                                    objBuyHis.NumberBuy = 1;
                                                                    objBuyHis.Privider = "VTC";
                                                                    objBuyHis.TariffNominalID = null;
                                                                    objBuyHis.ThresholdID = ThressholdValue;
                                                                    objBuyHis.ThresholdNominalID = thresholdnominal.ThresholdNominalID;
                                                                    DataIn.PINCARD_BUYCARDHISTORY_InsertUpdate(objBuyHis);
                                                                    Logger.Log("Action buy pincards from VTC sucessful with ThresholdNominalID : " + thresholdnominal.ThresholdNominalID + " | CardProductionID : " + pincode.CardProductionID + " | Number Cards Need Buy : " + NumNeedBuy);
                                                                }
                                                                else
                                                                {
                                                                    Logger.Log("Action buy pincards from VTC failure with ThresholdNominalID : " + thresholdnominal.ThresholdNominalID + " | CardProductionID : " + pincode.CardProductionID + " | Number Cards Need Buy : " + NumNeedBuy);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Logger.Log("Not pincards find in inventory___________________________________________________________________________________");
                                                }
                                                #endregion
                                            }
                                        }

                                        foreach (PINCARDNOMINALS pinmon in lstPincardNominal)
                                        {
                                            #region Send email to user
                                            List<InventoryPinCode> lstPinCode = PincardController.GetAvailablePincards();
                                            Logger.Log("Get Inventory pincards from UPG___________________________________________________________________________________" + lstPinCode.Count.ToString());
                                            if (lstPinCode.Count > 0)
                                            {
                                                Logger.Log("Inventory pincards from UPG : " + lstPinCode.Count);
                                                foreach (InventoryPinCode pincode in lstPinCode)
                                                {
                                                    Value = clsFormat.IntConvert(pincode.CardsCount);
                                                    Logger.Log("Inventory of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                    if (ThressholdValue > Value && IsEmail
                                                        && pinmon.UPGCardProductionID == clsFormat.IntConvertNull(pincode.CardProductionID))
                                                    {
                                                        if (Email != string.Empty)
                                                        {
                                                            Logger.Log("Send Email information of ThresholdNominalID : " + thresholdnominal.ThresholdNominalID);
                                                            string messageBody = "- Số lượng mã thẻ : " + pinmon.PincardNominalName + " - ID : " + pinmon.UPGCardProductionID + " đã mua không đủ số lượng sàn." + "<br/>"
                                                                + " - Xin kiểm tra lại thông tin ở các nhà cung cấp.";
                                                            string[] sep = { ";" };
                                                            string[] strResult = Email.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                                                            if (strResult.Length > 0)
                                                            {
                                                                foreach (string subString in strResult)
                                                                {
                                                                    if (subString != string.Empty && subString != null)
                                                                    {
                                                                        SendMail(messageBody, subString.Trim());
                                                                    }
                                                                }
                                                            }
                                                            Logger.Log("Send Email information of pincard CardProductionID : " + pincode.CardProductionID + "|CardNominalName : " + pincode.CardNominalName + "|CardsCount : " + pincode.CardsCount);
                                                        }
                                                    }
                                                }
                                            }
                                            #endregion
                                            break;
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    }
                }
                else
                {
                    Logger.Log("_____Service Timer Stopping...");
                    if (PoolCounting > 0)
                    {
                        Logger.Log("Waiting for " + PoolCounting.ToString() + " processing...");
                    }
                    else
                    {
                        ACS_Timer.Stop();
                        Logger.Log("_____ACS Timer Stopped");
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Service_Timer_Function_ERROR: " + ex.Message);
                Logger.Log("Service_Timer_Function_ERROR: " + ex.StackTrace);
                Logger.Log("Service_Timer_Function_ERROR: " + ex.InnerException);
            }
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
            this.Run();
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
            try
            {
                this.ServiceStop();
            }
            finally
            {
                this.Dispose();
            }
        }

        private void ServiceStop()
        {
            Logger.Log("_____Service Timer stopped: ______________________________________________");
            IsStop = true;
        }

        public new void Dispose()
        {
            this.lockPoolCounting = null;
            this.ACS_Timer = null;

            GC.SuppressFinalize(this);
            GC.Collect();
        }

        protected override void Finalize()
        {
            Dispose();
        }

        public static string getNeedString(string message, string beginString, string endString)
        {
            string strOut = message.Substring(message.IndexOf(beginString) + beginString.Length, (message.IndexOf(endString) - (message.IndexOf(beginString) + beginString.Length)));
            return strOut;
        }

        public bool isAddressAvailable(string address)
        {
            Ping ping = new Ping();
            try
            {
                return ping.Send(address, 100).Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }

        private bool IsNumber(string text)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }

        protected bool isValidEmail(string inputEmail)
        {
            bool Result = true;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                Result = true;
            else
            {
                Result = false;
            }
            return Result;
        }

        protected void SendMail(string messageBody, string Address)
        {
            var fromAddress = new MailAddress("simpaynoreply@simpay.com.vn", "Simpay");

            const string fromPassword = "sp123456";
            const string subject = "Thông tin tự động mua mã thẻ.";

            var smtp = new SmtpClient
            {
                Host = "mail.simpay.com.vn",
                Port = 25,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

            };

            string[] receivers = { Address };
            foreach (var receiver in receivers)
            {
                var toAddress = new MailAddress(receiver, "Agent");
                var mailMessage = new MailMessage();
                mailMessage.From = fromAddress;
                mailMessage.To.Add(toAddress);
                mailMessage.Subject = subject;
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = messageBody;
                smtp.Send(mailMessage);
            }
        }

        protected bool BuyPincard(int count, int ConsolidatorId, double Commission, string CardProductionId)
        {
            var inventoryPinCodeController = new InventoryPinCodeController();
            InventoryPinCodeList = inventoryPinCodeController.GetInventoryPinCode().Where(i => i.CardProductionID == CardProductionId).ToList();
            var objPincardController = new PincardController();
            var objLogichController = new LogichController();
            int consolidatorId = ConsolidatorId;
            var objInventoryPinCode = InventoryPinCodeList[0];
            string errorMessage = string.Empty;
            string totalMessage = string.Empty;
            bool IsBuySucessful = true;

            string consolidatorCostNo = objPincardController.GetPincardNominalCode(Convert.ToInt32(objInventoryPinCode.CardProductionID), consolidatorId).Trim();

            if (!string.IsNullOrEmpty(consolidatorCostNo) && objInventoryPinCode.CardsCount >= 0)
            {
                string consolidatorCode = objPincardController.GetConsolidatorNo(consolidatorId).Trim();
                // Logich consolidator
                if (consolidatorCode == "C25120131")
                {
                    #region Buy Card Logich
                    try
                    {
                        response objResponse = objLogichController.ResponsePincode(consolidatorCostNo.Trim());
                        if (objResponse.state == "0")
                        {
                            // Log

                            Logich.Tools.Logger("Success - Balance:" + objResponse.balance + " - Message:" + objResponse.message + " - State:" + objResponse.state, "BuyPinCard", "BuyLogich");
                            double pincardCost = Convert.ToDouble(objInventoryPinCode.Cost);
                            string pincode = Logich.PincardSecurity.Decrypt(objResponse.products[0].code.Trim(), ConfigurationManager.AppSettings["keydecrypt"]);
                            string serial = objResponse.products[0].serial.Trim();
                            DateTime expireDate = ConvertExpireDateToDatetime(objResponse.products[0].expdate.Trim());
                            CultureInfo provider = CultureInfo.InvariantCulture;
                            var cardProductionId = Convert.ToInt32(objInventoryPinCode.CardProductionID);
                            var objPincardNominal =
                                db.PincardNominals.Include("PincardCost").Include("ServiceConsolidator").FirstOrDefault(u => u.UPGCardProductionID == cardProductionId && u.LogichCostCode.Equals(consolidatorCostNo));
                            Models.PincardCost objPincardCost = db.PincardCosts.FirstOrDefault(p => p.PincardCostID == objPincardNominal.FK_PincardCostID);
                            Models.PinCard newPinCard = new Models.PinCard()
                            {
                                // Hash Code Pincard To MD5
                                PinCode = CommonClass.StringValidator.GetMD5String(pincode),
                                SerialNumber = serial,
                                CreateDate = DateTime.Now,
                                CurrentCommission = Commission,
                                //ExpireDate = DateTime.ParseExact(dr["ExpireDate"].ToString(), "dd/MM/yyyy", provider),
                                ExpireDate = expireDate,
                                IsTransferToUpg = false,
                                FK_PincardTypeID = 3,
                                FK_PincardNominalID = objPincardNominal.PincardNominalID

                            };
                            if (!Models.PinCard.GetExistPincode(pincode))
                            {
                                db.AddToPinCards(newPinCard);
                                bool isSuccess = Models.PinCard.CreatePinCards(Convert.ToInt32(objPincardNominal.UPGCardProductionID), pincode, serial, newPinCard.ExpireDate, objPincardCost.Cost.ToString());
                                if (!isSuccess)
                                {
                                    IsBuySucessful = false;
                                    newPinCard.IsTransferToUpg = false;
                                    //Loi UPG
                                    errorMessage = objResponse.state + ";" + "-1";
                                    totalMessage += "Tranfer UPG fail{pincode: " + pincode + ",serial:" + serial + ", expireDate:" + newPinCard.ExpireDate.ToString() + "};";
                                    Logich.Tools.Logger("Error UPG Fail - State:" + objResponse.state + " - TransType:" + objResponse.transtime, "BuyPinCard", "BuyLogich");
                                    db.SaveChanges();
                                }
                                else
                                {
                                    IsBuySucessful = true;
                                    newPinCard.IsTransferToUpg = true;
                                    newPinCard.SellDate = DateTime.Now;
                                    db.SaveChanges();
                                    countBuyPincard++;
                                    //Thanh cong--> chay tiep
                                    errorMessage = objResponse.state + ";" + count.ToString();
                                }
                            }
                            else
                            {
                                IsBuySucessful = false;
                                notCountBuyPincard++;
                                //"Mã thẻ đã tồn tại trong hệ thống";
                                errorMessage = objResponse.state + ";" + "-2";
                                totalMessage += "Mã thẻ đã tồn tại trong hệ thống:{pincode: " + pincode + ",serial:" + serial + ", expireDate:" + newPinCard.ExpireDate.ToString() + "};";
                                Logich.Tools.Logger("Error Save Pincard: Mã thẻ đã tồn tại trong hệ thống", "BuyPinCard", "BuyLogich");
                            }

                        }
                        else
                        {
                            IsBuySucessful = false;
                            notCountBuyPincard++;
                            //khong mua duoc tu logich
                            errorMessage = (objResponse.state + ";" + objResponse.message);
                            totalMessage += "Lỗi Logich:" + objResponse.message + ";";
                            Logich.Tools.Logger("Fail - State:" + objResponse.state + " - Message:" + objResponse.message, "BuyPinCard", "BuyLogich");
                        }
                    }
                    catch (System.ServiceProcess.TimeoutException timeEx)
                    {
                        IsBuySucessful = false;
                        notCountBuyPincard++;
                        errorMessage = ("-999" + ";TimeoutException: " + timeEx.Message + ", vui lòng chụp hình lại rồi gửi cho nhân viên kỹ thuật kiểm tra.");
                        totalMessage += "TimeoutException: " + timeEx.Message + ";";
                        Logich.Tools.Logger("TimeoutException:" + timeEx.Message, "BuyPinCard", "BuyLogich");
                    }
                    catch (Exception ex)
                    {
                        IsBuySucessful = false;
                        notCountBuyPincard++;
                        errorMessage = ("-999" + ";simpayerror: " + ex.Message + ", vui lòng chụp hình lại rồi gửi cho nhân viên kỹ thuật kiểm tra.");
                        totalMessage += "simpayerror: " + ex.Message + ";";
                        Logich.Tools.Logger("simpayerror:" + ex.Message, "BuyPinCard", "BuyLogich");
                    }
                    #endregion
                }
                // VTC Consolidator
                else if (consolidatorCode == "C25120132")
                {
                    #region Buy Card VTC Consolidator
                    try
                    {
                        RequestData requestData = new RequestData();
                        requestData.Amount = objInventoryPinCode.Cost.ToString();
                        requestData.ServiceCode = consolidatorCostNo;
                        requestData.OrgTransID = DateTime.Now.Ticks.ToString();
                        requestData.Quantity = 1;
                        requestData.TransDate = DateTime.Now.ToString("yyyyMMddHHmmss");
                        string privateKey = ReadFile(ConfigurationSettings.AppSettings["PrivateKeyUrl"]);
                        // update late
                        string partnerCode = ConfigurationSettings.AppSettings["partnercodeVTC"].ToString();
                        string dataToSign = consolidatorCostNo + "-" + requestData.Amount + "-" + requestData.Quantity + "-" + partnerCode
                            + "-" + requestData.TransDate + "-" + requestData.OrgTransID;
                        requestData.DataSign = Security.CreateSignRSA(dataToSign, privateKey);
                        var goodPaygate = new GoodsPaygate();
                        string resultString = goodPaygate.RequestTransaction(requestData.ToXmlString(), partnerCode, BUYCARD, "1.0");
                        //Thread.Sleep(200);
                        ResponeResult result = new ResponeResult(BUYCARD);
                        string parseResultStringRespone = result.parseResult(resultString);
                        string errorCode = parseResultStringRespone.Split('{')[1].Split('}')[0];
                        string errorDetails = VTC.GetErrorDetails(errorCode);
                        if (result.ResponeCode > 0)
                        {
                            Logich.Tools.Logger("Success - Balance:" + result.PartnerBalance + " - VTCTransID:" + result.VTCTransID, "BuyPinCard", "BuyVTC");
                            // Get card 
                            requestData.Account = null;
                            requestData.TransDate = null;
                            requestData.OrgTransID = result.VTCTransID;
                            dataToSign = consolidatorCostNo + "-" + requestData.Amount + "-" + partnerCode + "-" + result.VTCTransID;
                            requestData.DataSign = Security.CreateSignRSA(dataToSign, privateKey);
                            resultString = goodPaygate.RequestTransaction(requestData.ToXmlString(), partnerCode, GETCARD, "1.0");
                            string tripleDES = ConfigurationSettings.AppSettings["TripleDES"].ToString();
                            resultString = Security.Decrypt(tripleDES, resultString);
                            // parser Result
                            String[] m = resultString.Split('|');
                            String[] n = m[m.Length - 1].Split(':');
                            //string vtcPublicKey = ReadFile(ConfigurationSettings.AppSettings["VTC_PublicKeyUrl"]);
                            //vtcPublicKey = vtcPublicKey.Replace("rsakeyvalue>", "Rsakeyvalue>").Replace("modulus>", "Modulus>").Replace("exponent>", "Exponent>");
                            //var plaintextRep = m[0] + "-" + m[1] + "-" + m[2];
                            //bool isVerify = Security.CheckSignRSA(plaintextRep, m[3], vtcPublicKey);
                            var cardProductionId = Convert.ToInt32(objInventoryPinCode.CardProductionID);
                            var objPincardNominal =
                                db.PincardNominals.Include("PincardCost").Include("ServiceConsolidator").FirstOrDefault(u => u.UPGCardProductionID == cardProductionId && u.LogichCostCode.Equals(consolidatorCostNo));
                            Models.PincardCost objPincardCost = db.PincardCosts.FirstOrDefault(p => p.PincardCostID == objPincardNominal.FK_PincardCostID);
                            DateTime expireDate = ConvertExpireDateToDatetime(n[2].Trim());
                            Models.PinCard newPinCard = new Models.PinCard()
                            {
                                PinCode = CommonClass.StringValidator.GetMD5String(n[0]),
                                SerialNumber = n[1],
                                CreateDate = DateTime.Now,
                                CurrentCommission = Commission,
                                ExpireDate = expireDate,
                                IsTransferToUpg = false,
                                FK_PincardTypeID = 3,
                                FK_PincardNominalID = objPincardNominal.PincardNominalID
                            };
                            if (!Models.PinCard.GetExistPincode(n[0]))
                            {
                                db.AddToPinCards(newPinCard);
                                bool isSuccess = Models.PinCard.CreatePinCards(Convert.ToInt32(objPincardNominal.UPGCardProductionID), n[0], n[1], newPinCard.ExpireDate, objPincardCost.Cost.ToString());
                                if (!isSuccess)
                                {
                                    IsBuySucessful = false;
                                    newPinCard.IsTransferToUpg = false;
                                    //Loi UPG
                                    errorMessage = "0;-1";
                                    totalMessage += "Tranfer UPG fail{pincode: " + n[0] + ",serial:" + n[1] + ", expireDate:" + n[2] + "};";
                                    Logich.Tools.Logger("Error UPG Fail - VTCTransID:" + result.VTCTransID, "BuyPinCard", "BuyVTC");
                                    db.SaveChanges();
                                }
                                else
                                {
                                    IsBuySucessful = true;
                                    newPinCard.IsTransferToUpg = true;
                                    newPinCard.SellDate = DateTime.Now;
                                    db.SaveChanges();
                                    countBuyPincard++;
                                    //Thanh cong--> chay tiep
                                    errorMessage = "0;" + count.ToString();
                                }
                            }
                            else
                            {
                                IsBuySucessful = false;
                                notCountBuyPincard++;
                                //"Mã thẻ đã tồn tại trong hệ thống";
                                errorMessage = "0;-2";
                                totalMessage += "Mã thẻ đã tồn tại trong hệ thống:{pincode: " + n[0] + ",serial:" + n[1] + ", expireDate:" + n[2] + "};";
                                Logich.Tools.Logger("Error Save Pincard: Mã thẻ đã tồn tại trong hệ thống", "BuyPinCard", "BuyVTC");
                            }
                        }
                        else
                        {
                            IsBuySucessful = false;
                            notCountBuyPincard++;
                            //khong mua duoc tu VTC
                            errorMessage = ("-999" + ";Lỗi VTC: " + errorDetails);
                            totalMessage += "Lỗi VTC:" + errorDetails + ";";
                            Logich.Tools.Logger("Error VTC - Code:" + errorCode + " - Details:" + errorDetails, "BuyPinCard", "BuyVTC");
                        }
                    }
                    catch (System.ServiceProcess.TimeoutException ex)
                    {
                        IsBuySucessful = false;
                        // Send Email to LEad or Cs
                        notCountBuyPincard++;
                        errorMessage = ("-999" + ";TimeOutException: " + ex.Message + "; vui lòng chụp hình lại rồi gửi cho nhân viên kỹ thuật kiểm tra.");
                        totalMessage += "TimeOutException: " + ex.Message + ";";
                        Logich.Tools.Logger("TimeOutException:" + ex.ToString(), "BuyPinCard", "BuyVTC");
                    }
                    catch (Exception e)
                    {
                        IsBuySucessful = false;
                        notCountBuyPincard++;
                        errorMessage = ("-999" + ";Error: " + e.Message + "; vui lòng chụp hình lại rồi gửi cho nhân viên kỹ thuật kiểm tra.");
                        totalMessage += "Error: " + e.Message + ";";

                        Logich.Tools.Logger("Error:" + e.ToString(), "BuyPinCard", "BuyVTC");
                    }
                    #endregion
                }
            }
            else
            {
                IsBuySucessful = false;
                notCountBuyPincard++;
                errorMessage = "-999" + ";simpayerror: Không mua được mã thẻ vì không lấy được mã Consolidator Hoặc số lượng tồn kho vượt quá số lượng tồn kho tối thiểu";
                totalMessage += "simpayerror: Không mua được mã thẻ vì không lấy được mã Consolidator Hoặc số lượng tồn kho vượt quá số lượng tồn kho tối thiểu;";
                Logich.Tools.Logger("simpayerror: Không mua được mã thẻ vì không lấy được mã Consolidator Hoặc số lượng tồn kho vượt quá số lượng tồn kho tối thiểu;", "BuyPinCard", "BuyVTCAndLogich");
            }

            return IsBuySucessful;
        }

        private static string ReadFile(string filePath)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(filePath);
                string privateKey = streamReader.ReadToEnd();
                return privateKey;
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
            }
        }

        public static DateTime ConvertExpireDateToDatetime(string expdate)
        {
            DateTime exp = new DateTime();
            if (expdate.Length == 8)
            {
                string year = expdate.Substring(0, 4);

                string month = expdate.Substring(4, 2);
                string day = expdate.Substring(6, 2);
                //DateTime a = Convert.ToDateTime(date);


                string strDate = string.Format("{0}-{1}-{2}", year, month, day);
                DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
                dtfi.ShortDatePattern = "yyyy-MM-dd";
                dtfi.DateSeparator = "-";
                DateTime objDate = Convert.ToDateTime(strDate, dtfi);
                exp = objDate;
            }
            else if (expdate.Length == 10)
            {
                string[] date = expdate.Split('/');
                string year = date[2];

                string month = date[1];
                string day = date[0];
                //DateTime a = Convert.ToDateTime(date);


                string strDate = string.Format("{0}-{1}-{2}", year, month, day);
                DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
                dtfi.ShortDatePattern = "yyyy-MM-dd";
                dtfi.DateSeparator = "-";
                DateTime objDate = Convert.ToDateTime(strDate, dtfi);
                exp = objDate;
            }
            else
            {
                MessageBox.Show("Định dạng thời gian hết hạn mã thẻ không đúng!");
            }
            return exp;
        }

        private void GetBalance()
        {
            var request = new RequestData();
            string plaintext = string.Empty;
            string PartnerCode = string.Empty;
            string IsVerify = string.Empty;
            string privateKey = ReadFile(ConfigurationManager.AppSettings["PrivateKeyUrl"]);
            request.DataSign = Security.CreateSignRSA(plaintext, privateKey);
            string requestXml = request.ToXmlString();
            var goodsPaygate = new GoodsPaygate();
            string strResult = goodsPaygate.RequestTransaction(requestXml, PartnerCode, string.Empty, "1.0");
            string[] arrResult = strResult.Split('|');
            if (arrResult.Length >= 2)
            {
                var vtc_rsa_publicKey = ReadFile(ConfigurationManager.AppSettings["VTCPublicKeyUrl"]);
                string VTC_rsa_PublicKey = vtc_rsa_publicKey.Replace("rsakeyvalue>", "Rsakeyvalue>").Replace("modulus>", "Modulus>").Replace("exponent>", "Exponent>");
                var plaintextRep = arrResult[0];
                bool isVerify = Security.CheckSignRSA(plaintextRep, arrResult[1], VTC_rsa_PublicKey);
                IsVerify = isVerify ? "isVerify = true" : "isVerify = false";
            }
            var cls = new RequestData(requestXml);
        }
    }
}
