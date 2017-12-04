﻿/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     1/16/2009 12:01:09 PM                        */
/*==============================================================*/


alter table APBUSINESS
   drop constraint FK_APBUSINE_RELATIONS_PUBCURRE
go

alter table APBUSINESS
   drop constraint FK_APBUSINE_RELATIONS_PUBPAYME
go

alter table APBUSINESS
   drop constraint FK_APBUSINE_RELATIONS_PUBBATCH
go

alter table APBUSINESS
   drop constraint FK_APBUSINE_RELATIONS_PUBOBJEC
go

alter table ARBUSINESS
   drop constraint FK_ARBUSINE_RELATIONS_PUBPAYME
go

alter table ARBUSINESS
   drop constraint FK_ARBUSINE_RELATIONS_PUBBATCH
go

alter table ARBUSINESS
   drop constraint FK_ARBUSINE_RELATIONS_PUBCURRE
go

alter table ARBUSINESS
   drop constraint FK_ARBUSINE_RELATIONS_PUBOBJEC
go

alter table CMPAYMENT
   drop constraint FK_CMPAYMEN_CMPAY_BAN_PUBBANK
go

alter table CMPAYMENT
   drop constraint FK_CMPAYMEN_CM_PAMENT_PUBCURRE
go

alter table CMPAYMENT
   drop constraint FK_CMPAYMEN_RELATIONS_PUBOBJEC
go

alter table CMPAYMENT
   drop constraint FK_CMPAYMEN_RELATIONS_PUBBATCH
go

alter table CMPAYMENT_LOG
   drop constraint FK_CMPAYMEN_CMPAYLOG_PUBINVOI
go

alter table CMPAYMENT_LOG
   drop constraint FK_CMPAYMEN_CMPAYMENT_CMPAYMEN
go

alter table CMRECEIPT
   drop constraint FK_CMRECEIP_BANK_PUBBANK
go

alter table CMRECEIPT
   drop constraint FK_CMRECEIP_CURENCY_T_PUBCURRE
go

alter table CMRECEIPT
   drop constraint FK_CMRECEIP_RELATIONS_PUBBATCH
go

alter table CMRECEIPT
   drop constraint FK_CMRECEIP_RELATIONS_PUBBANKD
go

alter table CMRECEIPTLOG
   drop constraint FK_CMRECEIP_CMRECEIPT_CMRECEIP
go

alter table CMRECEIPTLOG
   drop constraint FK_CMRECEIP_INVOICE_C_PUBINVOI
go

alter table PROPPAYDETAIL
   drop constraint FK_PROPPAYD_RELATIONS_PUBPROPO
go

alter table PROPPAYDETAIL
   drop constraint FK_PROPPAYD_RELATIONS_PUBCONTR
go

alter table PUBCOSTPRICEINOUT
   drop constraint FK_PUBCOSTP_RELATIONS_PUBTURNO
go

alter table PUBDECLARATION
   drop constraint FK_PUBDECLA_RELATIONS_PUBCOUNT
go

alter table PUBDECLARATIONDETAIL
   drop constraint FK_PUBDECLA_RELATIONS_PUBDECLA
go

alter table PUBDECLARATIONDETAIL
   drop constraint FK_PUBDECLA_RELATIONS_PUBITEMS
go

alter table PUBDECLARATIONDETAIL
   drop constraint FK_PUBDECLA_RELATIONS_PUBTURNO
go

alter table PUBDECLARATIONDETAIL
   drop constraint FK_PUBDECLA_RELATIONS_PUBENTRY
go

alter table PUBDESCRIPTORITEM
   drop constraint FK_PUBDESCR_RELATIONS_PUBOBJEC
go

alter table PUBDESCRIPTORITEM
   drop constraint FK_PUBDESCR_RELATIONS_PUBCURRE
go

alter table PUBENTRY
   drop constraint FK_PUBENTRY_RELATIONS_PUBBANK
go

alter table PUBENTRY
   drop constraint FK_PUBENTRY_RELATIONS_PUBCONTR
go

alter table PUBINVOICE
   drop constraint FK_PUBINVOI_RELATIONS_PUBCURRE
go

alter table PUBINVOICEDETAIL
   drop constraint FK_PUBINVOI_ITEM_PUBINVOI
go

alter table PUBINVOICEDETAIL
   drop constraint FK_PUBINVOI_RELATIONS_PUBPROJE
go

alter table PUBINVOICEDETAIL
   drop constraint FK_PUBINVOI_RELATIONS_PUBCONTR
go

alter table PUBINVOICEDETAIL
   drop constraint FK_PUBINVOI_RELATIONS_PUBITEMS
go

alter table PUBINVOICEDETAIL
   drop constraint FK_PUBINVOI_RELATIONS_PUBENTRY
go

alter table PUBINVOICEDETAIL
   drop constraint FK_PUBINVOI_RELATIONS_PUBTAXRA
go

alter table PUBINVOICEDETAIL
   drop constraint FK_PUBINVOI_RELATIONS_PUBWAREH
go

alter table PUBINVOICEDETAIL
   drop constraint FK_PUBINVOI_RELATIONS_PUBTURNO
go

alter table PUBITEMS
   drop constraint FK_PUBITEMS_RELATIONS_PUBCURRE
go

alter table PUBITEMS
   drop constraint FK_PUBITEMS_RELATIONS_PUBWAREH
go

alter table PUBITEMS
   drop constraint FK_PUBITEMS_RELATIONS_PUBOBJEC
go

alter table PUBTAX
   drop constraint FK_PUBTAX_RELATIONS_PUBTAXRA
go

alter table PUBTURNOVER
   drop constraint FK_PUBTURNO_RELATIONS_PUBTURNO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('APBUSINESS')
            and   name  = 'RELATIONSHIP_115_FK'
            and   indid > 0
            and   indid < 255)
   drop index APBUSINESS.RELATIONSHIP_115_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('APBUSINESS')
            and   name  = 'RELATIONSHIP_116_FK'
            and   indid > 0
            and   indid < 255)
   drop index APBUSINESS.RELATIONSHIP_116_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('APBUSINESS')
            and   name  = 'RELATIONSHIP_126_FK'
            and   indid > 0
            and   indid < 255)
   drop index APBUSINESS.RELATIONSHIP_126_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('APBUSINESS')
            and   name  = 'RELATIONSHIP_86_FK'
            and   indid > 0
            and   indid < 255)
   drop index APBUSINESS.RELATIONSHIP_86_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ARBUSINESS')
            and   name  = 'RELATIONSHIP_117_FK'
            and   indid > 0
            and   indid < 255)
   drop index ARBUSINESS.RELATIONSHIP_117_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ARBUSINESS')
            and   name  = 'RELATIONSHIP_127_FK'
            and   indid > 0
            and   indid < 255)
   drop index ARBUSINESS.RELATIONSHIP_127_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ARBUSINESS')
            and   name  = 'RELATIONSHIP_132_FK'
            and   indid > 0
            and   indid < 255)
   drop index ARBUSINESS.RELATIONSHIP_132_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ARBUSINESS')
            and   name  = 'RELATIONSHIP_47_FK'
            and   indid > 0
            and   indid < 255)
   drop index ARBUSINESS.RELATIONSHIP_47_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CMPAYMENT')
            and   name  = 'CMPAY_BANK_FK'
            and   indid > 0
            and   indid < 255)
   drop index CMPAYMENT.CMPAY_BANK_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CMPAYMENT')
            and   name  = 'CM_PAMENT_CURENCY_TYPE_FK'
            and   indid > 0
            and   indid < 255)
   drop index CMPAYMENT.CM_PAMENT_CURENCY_TYPE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CMPAYMENT')
            and   name  = 'RELATIONSHIP_112_FK'
            and   indid > 0
            and   indid < 255)
   drop index CMPAYMENT.RELATIONSHIP_112_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CMPAYMENT')
            and   name  = 'RELATIONSHIP_31_FK'
            and   indid > 0
            and   indid < 255)
   drop index CMPAYMENT.RELATIONSHIP_31_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CMPAYMENT_LOG')
            and   name  = 'CMPAYLOG_FK'
            and   indid > 0
            and   indid < 255)
   drop index CMPAYMENT_LOG.CMPAYLOG_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CMPAYMENT_LOG')
            and   name  = 'CMPAYMENT_LOG_FK'
            and   indid > 0
            and   indid < 255)
   drop index CMPAYMENT_LOG.CMPAYMENT_LOG_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CMRECEIPT')
            and   name  = 'BANK_FK'
            and   indid > 0
            and   indid < 255)
   drop index CMRECEIPT.BANK_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CMRECEIPT')
            and   name  = 'CURENCY_TYPE_FK'
            and   indid > 0
            and   indid < 255)
   drop index CMRECEIPT.CURENCY_TYPE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CMRECEIPT')
            and   name  = 'RELATIONSHIP_30_FK'
            and   indid > 0
            and   indid < 255)
   drop index CMRECEIPT.RELATIONSHIP_30_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CMRECEIPT')
            and   name  = 'RELATIONSHIP_70_FK'
            and   indid > 0
            and   indid < 255)
   drop index CMRECEIPT.RELATIONSHIP_70_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CMRECEIPTLOG')
            and   name  = 'CMRECEIPT_LOG_FK'
            and   indid > 0
            and   indid < 255)
   drop index CMRECEIPTLOG.CMRECEIPT_LOG_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CMRECEIPTLOG')
            and   name  = 'INVOICE_CMRECEIPT_LOG_FK'
            and   indid > 0
            and   indid < 255)
   drop index CMRECEIPTLOG.INVOICE_CMRECEIPT_LOG_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PROPPAYDETAIL')
            and   name  = 'RELATIONSHIP_59_FK'
            and   indid > 0
            and   indid < 255)
   drop index PROPPAYDETAIL.RELATIONSHIP_59_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PROPPAYDETAIL')
            and   name  = 'RELATIONSHIP_60_FK'
            and   indid > 0
            and   indid < 255)
   drop index PROPPAYDETAIL.RELATIONSHIP_60_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBCOSTPRICEINOUT')
            and   name  = 'RELATIONSHIP_104_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBCOSTPRICEINOUT.RELATIONSHIP_104_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBDECLARATION')
            and   name  = 'RELATIONSHIP_69_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBDECLARATION.RELATIONSHIP_69_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBDECLARATIONDETAIL')
            and   name  = 'RELATIONSHIP_46_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBDECLARATIONDETAIL.RELATIONSHIP_46_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBDECLARATIONDETAIL')
            and   name  = 'RELATIONSHIP_55_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBDECLARATIONDETAIL.RELATIONSHIP_55_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBDECLARATIONDETAIL')
            and   name  = 'RELATIONSHIP_68_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBDECLARATIONDETAIL.RELATIONSHIP_68_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBDECLARATIONDETAIL')
            and   name  = 'RELATIONSHIP_90_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBDECLARATIONDETAIL.RELATIONSHIP_90_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBDESCRIPTORITEM')
            and   name  = 'RELATIONSHIP_105_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBDESCRIPTORITEM.RELATIONSHIP_105_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBDESCRIPTORITEM')
            and   name  = 'RELATIONSHIP_107_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBDESCRIPTORITEM.RELATIONSHIP_107_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBENTRY')
            and   name  = 'RELATIONSHIP_54_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBENTRY.RELATIONSHIP_54_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBENTRY')
            and   name  = 'RELATIONSHIP_72_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBENTRY.RELATIONSHIP_72_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBINVOICE')
            and   name  = 'RELATIONSHIP_125_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBINVOICE.RELATIONSHIP_125_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBINVOICEDETAIL')
            and   name  = 'ITEM_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBINVOICEDETAIL.ITEM_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBINVOICEDETAIL')
            and   name  = 'RELATIONSHIP_128_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBINVOICEDETAIL.RELATIONSHIP_128_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBINVOICEDETAIL')
            and   name  = 'RELATIONSHIP_129_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBINVOICEDETAIL.RELATIONSHIP_129_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBINVOICEDETAIL')
            and   name  = 'RELATIONSHIP_130_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBINVOICEDETAIL.RELATIONSHIP_130_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBINVOICEDETAIL')
            and   name  = 'RELATIONSHIP_61_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBINVOICEDETAIL.RELATIONSHIP_61_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBINVOICEDETAIL')
            and   name  = 'RELATIONSHIP_62_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBINVOICEDETAIL.RELATIONSHIP_62_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBINVOICEDETAIL')
            and   name  = 'RELATIONSHIP_63_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBINVOICEDETAIL.RELATIONSHIP_63_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBINVOICEDETAIL')
            and   name  = 'RELATIONSHIP_65_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBINVOICEDETAIL.RELATIONSHIP_65_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBITEMS')
            and   name  = 'RELATIONSHIP_106_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBITEMS.RELATIONSHIP_106_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBITEMS')
            and   name  = 'RELATIONSHIP_87_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBITEMS.RELATIONSHIP_87_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBITEMS')
            and   name  = 'RELATIONSHIP_88_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBITEMS.RELATIONSHIP_88_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBTAX')
            and   name  = 'RELATIONSHIP_73_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBTAX.RELATIONSHIP_73_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBTURNOVER')
            and   name  = 'RELATIONSHIP_64_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBTURNOVER.RELATIONSHIP_64_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('APBUSINESS')
            and   type = 'U')
   drop table APBUSINESS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ARBUSINESS')
            and   type = 'U')
   drop table ARBUSINESS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CMPAYMENT')
            and   type = 'U')
   drop table CMPAYMENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CMPAYMENT_LOG')
            and   type = 'U')
   drop table CMPAYMENT_LOG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CMRECEIPT')
            and   type = 'U')
   drop table CMRECEIPT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CMRECEIPTLOG')
            and   type = 'U')
   drop table CMRECEIPTLOG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROPPAYDETAIL')
            and   type = 'U')
   drop table PROPPAYDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBBANK')
            and   type = 'U')
   drop table PUBBANK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBBANKDETAIL')
            and   type = 'U')
   drop table PUBBANKDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBBATCH')
            and   type = 'U')
   drop table PUBBATCH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBCONTRACT')
            and   type = 'U')
   drop table PUBCONTRACT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBCOSTPRICEINOUT')
            and   type = 'U')
   drop table PUBCOSTPRICEINOUT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBCOUNTRY')
            and   type = 'U')
   drop table PUBCOUNTRY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBCURRENCY')
            and   type = 'U')
   drop table PUBCURRENCY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBDECLARATION')
            and   type = 'U')
   drop table PUBDECLARATION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBDECLARATIONDETAIL')
            and   type = 'U')
   drop table PUBDECLARATIONDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBDESCRIPTORITEM')
            and   type = 'U')
   drop table PUBDESCRIPTORITEM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBENTRY')
            and   type = 'U')
   drop table PUBENTRY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBINVOICE')
            and   type = 'U')
   drop table PUBINVOICE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBINVOICEDETAIL')
            and   type = 'U')
   drop table PUBINVOICEDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBITEMS')
            and   type = 'U')
   drop table PUBITEMS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBOBJECT')
            and   type = 'U')
   drop table PUBOBJECT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBPAYMENTMETHOD')
            and   type = 'U')
   drop table PUBPAYMENTMETHOD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBPLAN')
            and   type = 'U')
   drop table PUBPLAN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBPROJECT')
            and   type = 'U')
   drop table PUBPROJECT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBPROPOSEPAY')
            and   type = 'U')
   drop table PUBPROPOSEPAY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBTAX')
            and   type = 'U')
   drop table PUBTAX
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBTAXRATE')
            and   type = 'U')
   drop table PUBTAXRATE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBTURNOVER')
            and   type = 'U')
   drop table PUBTURNOVER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBTURNOVERTYPE')
            and   type = 'U')
   drop table PUBTURNOVERTYPE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBWAREHOUSE')
            and   type = 'U')
   drop table PUBWAREHOUSE
go

/*==============================================================*/
/* Table: APBUSINESS                                            */
/*==============================================================*/
create table APBUSINESS (
   AP_DOCUMENTID        bigint               not null,
   OBJ_AUTOID2          int                  null,
   CUR_AUTOID4          smallint             null,
   PAY_AUTOID3          int                  null,
   PUBAT_AUTOID         int                  null,
   AP_SUMMARY           nvarchar(200)        null,
   AP_VOUCHERDATE       datetime             null,
   AP_FINANCEPERIODID   smallint             null,
   AP_EXCHANGERATE      decimal(18,3)        null,
   AP_DEBTACCOUNT       nchar(10)            null,
   AP_ITEMSSTATUS       bit                  null,
   AP_LISTPO            nchar(200)           null,
   AP_INVOICEIDLIST     nchar(200)           null,
   AP_DECIDLIST         nchar(200)           null,
   AP_BUSTYPE           smallint             null,
   AP_IEPRICETYPE       smallint             null,
   AP_LISTPROPOSEPAYMENT nchar(100)           null,
   AP_ISRESTORE         bit                  null default 0,
   AP_ISACTIVE          bit                  null,
   AP_SHIPPINGID        smallint             null,
   AP_PAYMENTTERM       smallint             null,
   AP_DUEDATE           datetime             null,
   AP_ERRORTYPE         smallint             null,
   constraint PK_APBUSINESS primary key nonclustered (AP_DOCUMENTID)
)
go

declare @CmtAPBUSINESS varchar(128)
select @CmtAPBUSINESS = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'nghiệp vụ công nợ phải trả',
   'user', @CmtAPBUSINESS, 'table', 'APBUSINESS'
go

execute sp_addextendedproperty 'MS_Description', 
   'thuộc document nào Và là khóa chính',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_DOCUMENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã đối tượng tự động tăng',
   'user', '', 'table', 'APBUSINESS', 'column', 'OBJ_AUTOID2'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'APBUSINESS', 'column', 'CUR_AUTOID4'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'APBUSINESS', 'column', 'PAY_AUTOID3'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã tự động tăng',
   'user', '', 'table', 'APBUSINESS', 'column', 'PUBAT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'mô tả',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_SUMMARY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ngày chứng từ',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_VOUCHERDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Liên kết với bảng kì tài chính
   
   exam : 1,2,3 ..',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_FINANCEPERIODID'
go

execute sp_addextendedproperty 'MS_Description', 
   'tỷ giá chuyển đổi',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_EXCHANGERATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'tài khoản công nợ',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_DEBTACCOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tình trạng hàng hóa
   Đã nhập kho hay chua
   ',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_ITEMSSTATUS'
go

execute sp_addextendedproperty 'MS_Description', 
   'Danh sách các nghiệp vụ trước
   Order01;Order002
   ',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_LISTPO'
go

execute sp_addextendedproperty 'MS_Description', 
   'Danh sach hoa đơn',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_INVOICEIDLIST'
go

execute sp_addextendedproperty 'MS_Description', 
   'Danh sách tờ khai
   TK001;TK002',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_DECIDLIST'
go

execute sp_addextendedproperty 'MS_Description', 
   'loại chứng từ 
   1 hàng trong nước 
   2 hàng nhập khẩu',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_BUSTYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại giá nhập khẩu
   cho biết thông tin nhập khẩu vận chuyển giá tương ứng với vị trí nhận hàng mà nhà cung cấp đưa ra
   1 FOB
   2  CIF
   3 C&F
   4  EXW
   danh cho trường hợp nhập khẩu',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_IEPRICETYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Danh sách yêu cầu thanh toán
   POS001;POS002',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_LISTPROPOSEPAYMENT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Hàng trả lại
   1 Trả lại
   0 Normal',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_ISRESTORE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Kích hoạt
   true :kich hoat
   Fale: khong kich hoat',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_ISACTIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Vần chuyên',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_SHIPPINGID'
go

execute sp_addextendedproperty 'MS_Description', 
   'điều khoản thanh toán liên kết với điều khoản thanh toán',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_PAYMENTTERM'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày bắt đầu tính công nợ 
   để dựa vào tính',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_DUEDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại lỗi 
   danh cho GL trả về để biết lỗi gì
   liên kết với bảng loại lỗi',
   'user', '', 'table', 'APBUSINESS', 'column', 'AP_ERRORTYPE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_86_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_86_FK on APBUSINESS (
OBJ_AUTOID2 ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_126_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_126_FK on APBUSINESS (
PUBAT_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_115_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_115_FK on APBUSINESS (
CUR_AUTOID4 ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_116_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_116_FK on APBUSINESS (
PAY_AUTOID3 ASC
)
go

/*==============================================================*/
/* Table: ARBUSINESS                                            */
/*==============================================================*/
create table ARBUSINESS (
   AR_DOCUMENTID        int                  not null,
   CUR_AUTOID4          smallint             null,
   PUBAT_AUTOID         int                  null,
   OBJ_AUTOID2          int                  null,
   PAY_AUTOID3          int                  null,
   AR_SUMMARY           nvarchar(200)        null,
   AR_VOUCHERDATE       datetime             null,
   AR_FINANCEPERIODID   smallint             null,
   AR_EXCHANGERATE      decimal(18,3)        null,
   AR_DEBTACCOUNT       nchar(10)            null,
   AR_ITEMSSTATUS       bit                  null,
   AR_EXECUTEBY         smallint             null,
   AR_BUSTYPE           smallint             null,
   AR_LISTSO            nchar(200)           null,
   AR_LISTDECLA         nchar(200)           null,
   AR_LISTINVOI         nchar(200)           null,
   AR_LISTPROPOSEID     nchar(100)           null,
   AR_ISRETURN          bit                  null default 0,
   AR_ISACTIVE          bit                  null,
   AR_IEPRICETYPE       smallint             null,
   AR_SHIPPINGID        smallint             null,
   AR_PAYMENTTERM       smallint             null,
   AR_DUEDATE           datetime             null,
   AR_ERRORTYPE         smallint             null,
   constraint PK_ARBUSINESS primary key nonclustered (AR_DOCUMENTID)
)
go

declare @CmtARBUSINESS varchar(128)
select @CmtARBUSINESS = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nghiệp vụ  Công nợ Phải thu  ( Account Receipt)
   chú y phần kho ,Shipping  : lấy từ của PO
   ',
   'user', @CmtARBUSINESS, 'table', 'ARBUSINESS'
go

execute sp_addextendedproperty 'MS_Description', 
   'AR_DocumentID',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_DOCUMENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'ARBUSINESS', 'column', 'CUR_AUTOID4'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã tự động tăng',
   'user', '', 'table', 'ARBUSINESS', 'column', 'PUBAT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã đối tượng tự động tăng',
   'user', '', 'table', 'ARBUSINESS', 'column', 'OBJ_AUTOID2'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'ARBUSINESS', 'column', 'PAY_AUTOID3'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mô tả nghiệp vụ',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_SUMMARY'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày chứng từ',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_VOUCHERDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'FinancialCycle
   Kỳ tài chính',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_FINANCEPERIODID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tỷ giá chuyển đổi được lưu tại đây',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_EXCHANGERATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tài khoản nợ',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_DEBTACCOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'xuất kho chua
   trạng thái hàng hóa',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_ITEMSSTATUS'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ngưởi thực hiện  Liên kết bảng Object,Là nhân viên',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_EXECUTEBY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại chứng từ 
   1 hàng trong nước
   2 hàng xuất ',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_BUSTYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Danh sach nghiệp vụ đổ xuống  
   danh sách ID
   vd:
   OD001;OD002',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_LISTSO'
go

execute sp_addextendedproperty 'MS_Description', 
   'List Declaration
   Danh sach tờ khai',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_LISTDECLA'
go

execute sp_addextendedproperty 'MS_Description', 
   'ListInvoiceID
   danh sách hóa đơn
   HD001;HD002',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_LISTINVOI'
go

execute sp_addextendedproperty 'MS_Description', 
   'Danh sách yêu cầu thanh toán',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_LISTPROPOSEID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Hàng trả lại
   1 :trả lại
   0 normal',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_ISRETURN'
go

execute sp_addextendedproperty 'MS_Description', 
   'Được kích hoạt hay không',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_ISACTIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại giá nhập khẩu
   cho biết thông tin nhập khẩu vận chuyển giá tương ứng với vị trí nhận hàng mà nhà cung cấp đưa ra
   1 FOB
   2  CIF
   3 C&F
   4  EXW
   danh cho trường hợp nhập khẩu',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_IEPRICETYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Danh sách vận chuyển',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_SHIPPINGID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Liên kết với bảng điều khoản than toán',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_PAYMENTTERM'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày bắt đầu tính công nợ 
   để dựa vào tính',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_DUEDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại lỗi 
   trạng thái được GL trả về cho biết lỗi gì 
   cho biết thông tin bị lỗi gì',
   'user', '', 'table', 'ARBUSINESS', 'column', 'AR_ERRORTYPE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_132_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_132_FK on ARBUSINESS (
CUR_AUTOID4 ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_127_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_127_FK on ARBUSINESS (
PUBAT_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_47_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_47_FK on ARBUSINESS (
OBJ_AUTOID2 ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_117_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_117_FK on ARBUSINESS (
PAY_AUTOID3 ASC
)
go

/*==============================================================*/
/* Table: CMPAYMENT                                             */
/*==============================================================*/
create table CMPAYMENT (
   CMP_DOCUMENTID       int                  not null,
   PUBAT_AUTOID         int                  null,
   OBJ_AUTOID2          int                  null,
   BAK_AUTOID3          smallint             null,
   CUR_AUTOID4          smallint             null,
   CMP_DOCUMENTNO       smallint             null,
   CMP_DESCRIPTION      nvarchar(200)        null,
   CMP_PAYMENTBY        smallint             null,
   CMP_FINANCEPERIODID  smallint             null,
   CMP_EXCHANGERATE     decimal(18,3)        null,
   CMP_DEFINEMONEY      decimal(18,3)        null,
   CMP_BASICMONEY       decimal(18,3)        null,
   CMP_TYPE             smallint             null,
   CMP_ISDIRECT         bit                  null,
   CMP_AMOUNT           decimal(18,3)        null,
   CMP_LISTSOURCEID     nchar(200)           null,
   CMP_ISRETURN         bit                  null default 0,
   CMP_LISTPLAN         nchar(200)           null,
   CMP_DECIDLIST        nchar(200)           null,
   CMP_INVOICEIDLIST    nchar(200)           null,
   CMP_LISTPROPOSE      nchar(100)           null,
   CMP_SHIPPINGID       smallint             null,
   CMP_ERRORTYPE        smallint             null,
   CMP_PAYMENTMETHOD    smallint             null,
   CMP_IEPRICETYPE      smallint             null,
   CMP_ISPREPAY         bit                  null,
   constraint PK_CMPAYMENT primary key nonclustered (CMP_DOCUMENTID)
)
go

declare @CmtCMPAYMENT varchar(128)
select @CmtCMPAYMENT = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Công nợ phải trả bên phân hệ CM (Cash Manager)',
   'user', @CmtCMPAYMENT, 'table', 'CMPAYMENT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã chứng từ',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_DOCUMENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã tự động tăng',
   'user', '', 'table', 'CMPAYMENT', 'column', 'PUBAT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã đối tượng tự động tăng',
   'user', '', 'table', 'CMPAYMENT', 'column', 'OBJ_AUTOID2'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'CMPAYMENT', 'column', 'BAK_AUTOID3'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CUR_AUTOID4'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã chứng từ quan lý theo chuẩn CMP001',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_DOCUMENTNO'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mô tả',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Người Trả',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_PAYMENTBY'
go

execute sp_addextendedproperty 'MS_Description', 
   'FinanceCycle
   kỳ tài chính',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_FINANCEPERIODID'
go

execute sp_addextendedproperty 'MS_Description', 
   'tỷ giá chuyển đổi',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_EXCHANGERATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'tiền hoạch toán',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_DEFINEMONEY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tiền nguyên tệ',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_BASICMONEY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại chứng từ 
   1 công nợ
   2 khác',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_TYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Trả trực tiếp để biết thông tin thu theo quy trình hay nghiệp vụ lẻ
   true : lẽ tự xuất phát từ bản thân',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_ISDIRECT'
go

execute sp_addextendedproperty 'MS_Description', 
   'số tiền',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_AMOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Danh sách nghiệp  SO hoặc PO
   SO001;SO002
   
   trường hợp PO là trường hợp trả lại',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_LISTSOURCEID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Hàng trả lại',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_ISRETURN'
go

execute sp_addextendedproperty 'MS_Description', 
   'Kế hoạch Nào 
   danh sách kế hoạch
   KH001;KH002',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_LISTPLAN'
go

execute sp_addextendedproperty 'MS_Description', 
   'Danh sách Tờ khai
   TK001;TK002',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_DECIDLIST'
go

execute sp_addextendedproperty 'MS_Description', 
   'Danh sách hóa đơn
   IV001;IV002',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_INVOICEIDLIST'
go

execute sp_addextendedproperty 'MS_Description', 
   'danh sách yêu cầu thanh toán
   PRO001;PRO02',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_LISTPROPOSE'
go

execute sp_addextendedproperty 'MS_Description', 
   'vận chuyển',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_SHIPPINGID'
go

execute sp_addextendedproperty 'MS_Description', 
   'bị lỗi gì cho thông tin liên quan tới lỗi 
   biết đường mà sủa',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_ERRORTYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Phương thức thanh toán 
   ví dụ  tiên ngân hàng
   chuyển khoản hay card online
   liên kết bảng payment method',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_PAYMENTMETHOD'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại giá nhập khẩu
   cho biết thông tin nhập khẩu vận chuyển giá tương ứng với vị trí nhận hàng mà nhà cung cấp đưa ra
   1 FOB
   2  CIF
   3 C&F
   4  EXW
   danh cho trường hợp nhập khẩu',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_IEPRICETYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'trả trước cho biết chứng từ này được trả trước',
   'user', '', 'table', 'CMPAYMENT', 'column', 'CMP_ISPREPAY'
go

/*==============================================================*/
/* Index: CMPAY_BANK_FK                                         */
/*==============================================================*/
create index CMPAY_BANK_FK on CMPAYMENT (
BAK_AUTOID3 ASC
)
go

/*==============================================================*/
/* Index: CM_PAMENT_CURENCY_TYPE_FK                             */
/*==============================================================*/
create index CM_PAMENT_CURENCY_TYPE_FK on CMPAYMENT (
CUR_AUTOID4 ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_31_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_31_FK on CMPAYMENT (
PUBAT_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_112_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_112_FK on CMPAYMENT (
OBJ_AUTOID2 ASC
)
go

/*==============================================================*/
/* Table: CMPAYMENT_LOG                                         */
/*==============================================================*/
create table CMPAYMENT_LOG (
   CMPL_AUTOID          int                  not null,
   CMP_DOCUMENTID       int                  null,
   IV_DOCUMENTID        bigint               null,
   CMPL_CREATEDATE      datetime             null,
   CMPL_PAYMENTBY       int                  null,
   CMPL_AMOUNT          decimal(18,3)        null,
   constraint PK_CMPAYMENT_LOG primary key nonclustered (CMPL_AUTOID)
)
go

declare @CmtCMPAYMENT_LOG varchar(128)
select @CmtCMPAYMENT_LOG = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Ghi nhận chi tiết cho từng hóa đơn của mỗi chứng từ phải trả
   Dùng để kiểm tra số lần, số tiền, ...  cho từng hóa đơn của mỗi chứng từ',
   'user', @CmtCMPAYMENT_LOG, 'table', 'CMPAYMENT_LOG'
go

execute sp_addextendedproperty 'MS_Description', 
   'CMPL_AutoID',
   'user', '', 'table', 'CMPAYMENT_LOG', 'column', 'CMPL_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã chứng từ',
   'user', '', 'table', 'CMPAYMENT_LOG', 'column', 'CMP_DOCUMENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã hóa đơn lấy từ bảng Document',
   'user', '', 'table', 'CMPAYMENT_LOG', 'column', 'IV_DOCUMENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'CMPL_CreateDate',
   'user', '', 'table', 'CMPAYMENT_LOG', 'column', 'CMPL_CREATEDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'người trả',
   'user', '', 'table', 'CMPAYMENT_LOG', 'column', 'CMPL_PAYMENTBY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Số tiền',
   'user', '', 'table', 'CMPAYMENT_LOG', 'column', 'CMPL_AMOUNT'
go

/*==============================================================*/
/* Index: CMPAYLOG_FK                                           */
/*==============================================================*/
create index CMPAYLOG_FK on CMPAYMENT_LOG (
IV_DOCUMENTID ASC
)
go

/*==============================================================*/
/* Index: CMPAYMENT_LOG_FK                                      */
/*==============================================================*/
create index CMPAYMENT_LOG_FK on CMPAYMENT_LOG (
CMP_DOCUMENTID ASC
)
go

/*==============================================================*/
/* Table: CMRECEIPT                                             */
/*==============================================================*/
create table CMRECEIPT (
   CMR_DOCUMENTID       bigint               not null,
   PUBAT_AUTOID         int                  null,
   ACD_AUTOID           smallint             null,
   CUR_AUTOID4          smallint             null,
   BAK_AUTOID3          smallint             null,
   CMR_DOCUMENTNO       nchar(10)            null,
   CMR_DESCRIPTION      nvarchar(200)        null,
   CMR_RECEIPTBY        smallint             null,
   CMR_OBJECTID         int                  null,
   CMR_FINANCEPERIODID  smallint             null,
   CMR_EXCHANGERATE     decimal(18,3)        null,
   CMR_DEFINEMONEY      decimal(18,3)        null,
   CMR_BASICMONEY       decimal(18,3)        null,
   CMR_ISDIRECT         bit                  null,
   CMR_REFACOUNTID      smallint             null,
   CMR_AMOUNT           decimal(18,3)        null,
   CMR_ISACTIVE         bit                  null,
   CMR_LISTSOURCE       nchar(200)           null,
   CMR_ISRETURN         bit                  null default 0,
   CMR_LISTPLAN         nchar(200)           null,
   CMR_DECIDLIST        nchar(200)           null,
   CMR_LISTPROPOSE      nchar(100)           null,
   CMR_INVOICEIDLIST    nchar(200)           null,
   CMR_TYPE             smallint             null,
   CMR_IEPRICETYPE      smallint             null,
   CMR_ISPRERECEIPT     bit                  null,
   constraint PK_CMRECEIPT primary key nonclustered (CMR_DOCUMENTID)
)
go

declare @CmtCMRECEIPT varchar(128)
select @CmtCMRECEIPT = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nghiệp vụ công nợ phải thu của phân hệ CM (Casch Management)',
   'user', @CmtCMRECEIPT, 'table', 'CMRECEIPT'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự động tăng',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_DOCUMENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã tự động tăng',
   'user', '', 'table', 'CMRECEIPT', 'column', 'PUBAT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Id tự động tăng',
   'user', '', 'table', 'CMRECEIPT', 'column', 'ACD_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CUR_AUTOID4'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'CMRECEIPT', 'column', 'BAK_AUTOID3'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã chứng từ tụ quản lý',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_DOCUMENTNO'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mô tả ',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'người thu',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_RECEIPTBY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã đối tượng',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_OBJECTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'FinanceCycle
   Kì tài chính
   liên kết bảng kì tài ching trong nam
   ',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_FINANCEPERIODID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tỷ giá chuyển đổi',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_EXCHANGERATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'tiền hoạch toán',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_DEFINEMONEY'
go

execute sp_addextendedproperty 'MS_Description', 
   'tiền nguyên tệ',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_BASICMONEY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Trực tiếp
   true : Direct
   false : none',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_ISDIRECT'
go

execute sp_addextendedproperty 'MS_Description', 
   'tài khoản tham chiếu',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_REFACOUNTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'số tiền',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_AMOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'kích hoat không',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_ISACTIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Danh sách nghiệp vụ cha
   SO001;SO002',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_LISTSOURCE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Hàng trả lại
   1 Trả lại
    0 None',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_ISRETURN'
go

execute sp_addextendedproperty 'MS_Description', 
   'kế hoạch nào 
   KH001;KH002',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_LISTPLAN'
go

execute sp_addextendedproperty 'MS_Description', 
   'Danh sách tờ khai',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_DECIDLIST'
go

execute sp_addextendedproperty 'MS_Description', 
   'List Yêu cầu thanh toán',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_LISTPROPOSE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Danh sách hóa đơn',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_INVOICEIDLIST'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại chứng từ 
   1 công nợ
   2 khác',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_TYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại giá nhập khẩu
   cho biết thông tin nhập khẩu vận chuyển giá tương ứng với vị trí nhận hàng mà nhà cung cấp đưa ra
   1 FOB
   2  CIF
   3 C&F
   4  EXW
   danh cho trường hợp nhập khẩu',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_IEPRICETYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Thu trước biết chứng từ này thuộc chứng từ thu trước',
   'user', '', 'table', 'CMRECEIPT', 'column', 'CMR_ISPRERECEIPT'
go

/*==============================================================*/
/* Index: CURENCY_TYPE_FK                                       */
/*==============================================================*/
create index CURENCY_TYPE_FK on CMRECEIPT (
CUR_AUTOID4 ASC
)
go

/*==============================================================*/
/* Index: BANK_FK                                               */
/*==============================================================*/
create index BANK_FK on CMRECEIPT (
BAK_AUTOID3 ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_30_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_30_FK on CMRECEIPT (
PUBAT_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_70_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_70_FK on CMRECEIPT (
ACD_AUTOID ASC
)
go

/*==============================================================*/
/* Table: CMRECEIPTLOG                                          */
/*==============================================================*/
create table CMRECEIPTLOG (
   CMRL_AUTOID          int                  not null,
   IV_DOCUMENTID        bigint               null,
   CMR_DOCUMENTID       bigint               null,
   CMRL_CREATEDATE      datetime             null,
   CMRL_RECEIPTBY       int                  null,
   CMRL_AMOUNT          decimal(18,3)        null,
   constraint PK_CMRECEIPTLOG primary key nonclustered (CMRL_AUTOID)
)
go

declare @CmtCMRECEIPTLOG varchar(128)
select @CmtCMRECEIPTLOG = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Chi tiết cho từng hóa đơn của mỗi chứng từ phải thu
   Dùng để kiểm tra số lần, số tiền, ...  cho từng hóa đơn của mỗi chứng từ',
   'user', @CmtCMRECEIPTLOG, 'table', 'CMRECEIPTLOG'
go

execute sp_addextendedproperty 'MS_Description', 
   'CMRL_AutoID',
   'user', '', 'table', 'CMRECEIPTLOG', 'column', 'CMRL_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã hóa đơn lấy từ bảng Document',
   'user', '', 'table', 'CMRECEIPTLOG', 'column', 'IV_DOCUMENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự động tăng',
   'user', '', 'table', 'CMRECEIPTLOG', 'column', 'CMR_DOCUMENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày tạo',
   'user', '', 'table', 'CMRECEIPTLOG', 'column', 'CMRL_CREATEDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Người nhận',
   'user', '', 'table', 'CMRECEIPTLOG', 'column', 'CMRL_RECEIPTBY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Số lượng',
   'user', '', 'table', 'CMRECEIPTLOG', 'column', 'CMRL_AMOUNT'
go

/*==============================================================*/
/* Index: INVOICE_CMRECEIPT_LOG_FK                              */
/*==============================================================*/
create index INVOICE_CMRECEIPT_LOG_FK on CMRECEIPTLOG (
IV_DOCUMENTID ASC
)
go

/*==============================================================*/
/* Index: CMRECEIPT_LOG_FK                                      */
/*==============================================================*/
create index CMRECEIPT_LOG_FK on CMRECEIPTLOG (
CMR_DOCUMENTID ASC
)
go

/*==============================================================*/
/* Table: PROPPAYDETAIL                                         */
/*==============================================================*/
create table PROPPAYDETAIL (
   PRO_AUTOID4          int                  not null,
   PPAY_DOCUMENTID      bigint               null,
   COT_AUTOID           int                  null,
   PPAYD_ITEMSID        nchar(10)            null,
   PPAYD_ITEMSNAME      nvarchar(200)        null,
   PPAYD_QUANTITY       decimal(10,3)        null,
   PPAYD_NOTE           nvarchar(200)        null,
   PPAYD_TURNOVERITEM   nvarchar(200)        null,
   PPAYD_COSTPRICE      decimal(18,3)        null,
   PPAYD_TOTALAMOUNT    decimal(18,3)        null,
   PPAYD_ISACTIVITY     bit                  null,
   PPAYD_UOM            smallint             null,
   PPAYD_UNITPRICE      decimal(18,3)        null,
   PPAYD_COSTING        smallint             null,
   PPAYD_ATTACHDOC      nchar(200)           null,
   PPAYD_ISACTIVE       bit                  null default 1,
   constraint PK_PROPPAYDETAIL primary key nonclustered (PRO_AUTOID4)
)
go

declare @CmtPROPPAYDETAIL varchar(128)
select @CmtPROPPAYDETAIL = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ProposePayDetail
   Chi tiết yêu cầu thanh toán
   ',
   'user', @CmtPROPPAYDETAIL, 'table', 'PROPPAYDETAIL'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tự đông tăng',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'PRO_AUTOID4'
go

execute sp_addextendedproperty 'MS_Description', 
   'pPay_DocumentID',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'PPAY_DOCUMENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'COT_AutoID',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'COT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã Hàng hóa
   Lấy mã quản lý',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'PPAYD_ITEMSID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên Sản Phẩm
   Dùng keeptract',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'PPAYD_ITEMSNAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Số lượng',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'PPAYD_QUANTITY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ghi chu cho mặt hàng này',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'PPAYD_NOTE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Khoảng mục kinh doanh',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'PPAYD_TURNOVERITEM'
go

execute sp_addextendedproperty 'MS_Description', 
   'Giá thành',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'PPAYD_COSTPRICE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Thành tiền ',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'PPAYD_TOTALAMOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Được kích hoạt không',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'PPAYD_ISACTIVITY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Đơn vị tính',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'PPAYD_UOM'
go

execute sp_addextendedproperty 'MS_Description', 
   'Đơn giá',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'PPAYD_UNITPRICE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Giá thành',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'PPAYD_COSTING'
go

execute sp_addextendedproperty 'MS_Description', 
   'AttachDocument
   
   Chứng từ kèm theo',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'PPAYD_ATTACHDOC'
go

execute sp_addextendedproperty 'MS_Description', 
   'kích hoạt',
   'user', '', 'table', 'PROPPAYDETAIL', 'column', 'PPAYD_ISACTIVE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_59_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_59_FK on PROPPAYDETAIL (
PPAY_DOCUMENTID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_60_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_60_FK on PROPPAYDETAIL (
COT_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBBANK                                               */
/*==============================================================*/
create table PUBBANK (
   BAK_AUTOID3          smallint             not null,
   constraint PK_PUBBANK primary key nonclustered (BAK_AUTOID3)
)
go

declare @CmtPUBBANK varchar(128)
select @CmtPUBBANK = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Danh sách ngân hàng',
   'user', @CmtPUBBANK, 'table', 'PUBBANK'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBBANK', 'column', 'BAK_AUTOID3'
go

/*==============================================================*/
/* Table: PUBBANKDETAIL                                         */
/*==============================================================*/
create table PUBBANKDETAIL (
   ACD_AUTOID           smallint             not null,
   constraint PK_PUBBANKDETAIL primary key nonclustered (ACD_AUTOID)
)
go

declare @CmtPUBBANKDETAIL varchar(128)
select @CmtPUBBANKDETAIL = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Tài khoản ngân hàng',
   'user', @CmtPUBBANKDETAIL, 'table', 'PUBBANKDETAIL'
go

execute sp_addextendedproperty 'MS_Description', 
   'Id tự động tăng',
   'user', '', 'table', 'PUBBANKDETAIL', 'column', 'ACD_AUTOID'
go

/*==============================================================*/
/* Table: PUBBATCH                                              */
/*==============================================================*/
create table PUBBATCH (
   PUBAT_AUTOID         int                  not null,
   PUBAT_DOCUMENTNO     nchar(15)            null,
   PUBAT_BATCHNAME      nvarchar(100)        null,
   PUBAT_CREATEDATE     datetime             null,
   PUBAT_CREATEBY       int                  null,
   PUBBAT_BUSTYPE       smallint             null,
   PUBAT_STATUS         smallint             null,
   PUBAT_ISACTIVE       bit                  null,
   PUBAT_ISPAYMENT      bit                  null,
   PUBAT_ISWRITE        bit                  null,
   constraint PK_PUBBATCH primary key nonclustered (PUBAT_AUTOID)
)
go

declare @CmtPUBBATCH varchar(128)
select @CmtPUBBATCH = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nghiệp vụ sử lý 
   dành cho AR,Ap,CM,IC,FA',
   'user', @CmtPUBBATCH, 'table', 'PUBBATCH'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã tự động tăng',
   'user', '', 'table', 'PUBBATCH', 'column', 'PUBAT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã quản lý',
   'user', '', 'table', 'PUBBATCH', 'column', 'PUBAT_DOCUMENTNO'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên Nghiệp vụ',
   'user', '', 'table', 'PUBBATCH', 'column', 'PUBAT_BATCHNAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày tao',
   'user', '', 'table', 'PUBBATCH', 'column', 'PUBAT_CREATEDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'tao bởi user nào',
   'user', '', 'table', 'PUBBATCH', 'column', 'PUBAT_CREATEBY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại 
   1 AR
   2 AP
   3 CM
   4 FA
   
   ',
   'user', '', 'table', 'PUBBATCH', 'column', 'PUBBAT_BUSTYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'trang thai 
   1 tao moi
   2 ghi so tam
   3 đã ghi sổ
   4 bị lỗi
   5 fixbug',
   'user', '', 'table', 'PUBBATCH', 'column', 'PUBAT_STATUS'
go

execute sp_addextendedproperty 'MS_Description', 
   'được kích hoạt hay chưa',
   'user', '', 'table', 'PUBBATCH', 'column', 'PUBAT_ISACTIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   'danh cho CM để biết là Lô này là lô thu hay chi 
   true : chứng từ chi 
   false : chứng từ thu 
   mặc định là false',
   'user', '', 'table', 'PUBBATCH', 'column', 'PUBAT_ISPAYMENT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Cho phép ghi sổ hay không
   dành cho IC',
   'user', '', 'table', 'PUBBATCH', 'column', 'PUBAT_ISWRITE'
go

/*==============================================================*/
/* Table: PUBCONTRACT                                           */
/*==============================================================*/
create table PUBCONTRACT (
   COT_AUTOID           int                  not null,
   constraint PK_PUBCONTRACT primary key nonclustered (COT_AUTOID)
)
go

declare @CmtPUBCONTRACT varchar(128)
select @CmtPUBCONTRACT = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'hợp đồng',
   'user', @CmtPUBCONTRACT, 'table', 'PUBCONTRACT'
go

execute sp_addextendedproperty 'MS_Description', 
   'COT_AutoID',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_AUTOID'
go

/*==============================================================*/
/* Table: PUBCOSTPRICEINOUT                                     */
/*==============================================================*/
create table PUBCOSTPRICEINOUT (
   CIO_AUTOID           int                  not null,
   TUR_AUTOID           smallint             null,
   CIO_ID               smallint             null,
   CIO_DESCRIPTION      nvarchar(200)        null,
   CIO_CREATEDATE       datetime             null,
   CIO_RESION           nvarchar(200)        null,
   CIO_STATUS           smallint             null,
   CIO_ACCOUNT          nchar(10)            null,
   CIO_PAYFO            nchar(200)           null,
   CIO_PAYBY            smallint             null,
   CIO_PO_SO            nchar(10)            null,
   constraint PK_PUBCOSTPRICEINOUT primary key nonclustered (CIO_AUTOID)
)
go

declare @CmtPUBCOSTPRICEINOUT varchar(128)
select @CmtPUBCOSTPRICEINOUT = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Danh mục chi phí nhập xuất',
   'user', @CmtPUBCOSTPRICEINOUT, 'table', 'PUBCOSTPRICEINOUT'
go

execute sp_addextendedproperty 'MS_Description', 
   'CIO_AutoID',
   'user', '', 'table', 'PUBCOSTPRICEINOUT', 'column', 'CIO_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tu tăng',
   'user', '', 'table', 'PUBCOSTPRICEINOUT', 'column', 'TUR_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã chi phí',
   'user', '', 'table', 'PUBCOSTPRICEINOUT', 'column', 'CIO_ID'
go

execute sp_addextendedproperty 'MS_Description', 
   'CIO_Description',
   'user', '', 'table', 'PUBCOSTPRICEINOUT', 'column', 'CIO_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'CIO_CreateDate',
   'user', '', 'table', 'PUBCOSTPRICEINOUT', 'column', 'CIO_CREATEDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'CIO_Resion',
   'user', '', 'table', 'PUBCOSTPRICEINOUT', 'column', 'CIO_RESION'
go

execute sp_addextendedproperty 'MS_Description', 
   'CIO_Status',
   'user', '', 'table', 'PUBCOSTPRICEINOUT', 'column', 'CIO_STATUS'
go

execute sp_addextendedproperty 'MS_Description', 
   'tài khoan',
   'user', '', 'table', 'PUBCOSTPRICEINOUT', 'column', 'CIO_ACCOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Chi cho ',
   'user', '', 'table', 'PUBCOSTPRICEINOUT', 'column', 'CIO_PAYFO'
go

execute sp_addextendedproperty 'MS_Description', 
   'người chi',
   'user', '', 'table', 'PUBCOSTPRICEINOUT', 'column', 'CIO_PAYBY'
go

execute sp_addextendedproperty 'MS_Description', 
   'CIO_PO/SO',
   'user', '', 'table', 'PUBCOSTPRICEINOUT', 'column', 'CIO_PO_SO'
go

/*==============================================================*/
/* Index: RELATIONSHIP_104_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_104_FK on PUBCOSTPRICEINOUT (
TUR_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBCOUNTRY                                            */
/*==============================================================*/
create table PUBCOUNTRY (
   CON_AUTOID2          int                  not null,
   constraint PK_PUBCOUNTRY primary key nonclustered (CON_AUTOID2)
)
go

declare @CmtPUBCOUNTRY varchar(128)
select @CmtPUBCOUNTRY = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Quốc gia',
   'user', @CmtPUBCOUNTRY, 'table', 'PUBCOUNTRY'
go

execute sp_addextendedproperty 'MS_Description', 
   'CON_AutoID',
   'user', '', 'table', 'PUBCOUNTRY', 'column', 'CON_AUTOID2'
go

/*==============================================================*/
/* Table: PUBCURRENCY                                           */
/*==============================================================*/
create table PUBCURRENCY (
   CUR_AUTOID4          smallint             not null,
   constraint PK_PUBCURRENCY primary key nonclustered (CUR_AUTOID4)
)
go

declare @CmtPUBCURRENCY varchar(128)
select @CmtPUBCURRENCY = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Bảng  danh mục tiển tệ
   loại tiền',
   'user', @CmtPUBCURRENCY, 'table', 'PUBCURRENCY'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBCURRENCY', 'column', 'CUR_AUTOID4'
go

/*==============================================================*/
/* Table: PUBDECLARATION                                        */
/*==============================================================*/
create table PUBDECLARATION (
   RETURNID             bigint               not null,
   CON_AUTOID2          int                  null,
   DEC_DOCUMENTNO       smallint             null,
   DEC_INVOICEBUSNO     nchar(10)            null,
   DEC_CREATEDATE       datetime             null,
   DEC_ORDERDATE        datetime             null,
   DEC_OBJECTID         smallint             null,
   DEC_REGISTEROFFICIAL smallint             null,
   DEC_OBJECTHANDLE     smallint             null,
   DEC_IMPORTHARBOUR    nvarchar(200)        null,
   DEC_EXPORTHARBOUR    nvarchar(200)        null,
   DEC_AMOUNTAF         decimal(18,3)        null,
   DEC_TAXIMEXPER       decimal(2,2)         null,
   DEC_INVOICEBUSDESCRIPTION nvarchar(200)        null,
   DEC_INVOICEBUSCREATEDATE datetime             null,
   DEC_BUSTYPE          smallint             null,
   DEC_ISACTIVE         bit                  null,
   DEC_LISTPAREN        nchar(100)           null,
   DEC_LISTINVOICE      nchar(200)           null,
   constraint PK_PUBDECLARATION primary key nonclustered (RETURNID)
)
go

declare @CmtPUBDECLARATION varchar(128)
select @CmtPUBDECLARATION = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Quản lý tờ khai',
   'user', @CmtPUBDECLARATION, 'table', 'PUBDECLARATION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Lấy từ bảng Document ',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'RETURNID'
go

execute sp_addextendedproperty 'MS_Description', 
   'CON_AutoID',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'CON_AUTOID2'
go

execute sp_addextendedproperty 'MS_Description', 
   'Số tờ khai',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_DOCUMENTNO'
go

execute sp_addextendedproperty 'MS_Description', 
   'hóa Đơn thương mại 
   trường hợp nhập khẩu',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_INVOICEBUSNO'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ngày tạo',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_CREATEDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ngày hóa đơn',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_ORDERDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã đối tượng',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_OBJECTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'cán bộ đăng ký
   đơn vị sử lý tờ khai liên kết với bảng object 
   với loại là cán bộ đăng ký
   người đạ diện cho ObjectHandle
   đối tượng sử lý tờ khai',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_REGISTEROFFICIAL'
go

execute sp_addextendedproperty 'MS_Description', 
   'Đối tượng sử lý tờ khai
   liên kết với bảng object với đối tượng là một công ty trung gian hoặc hải quan',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_OBJECTHANDLE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Cảng rỡ hàng',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_IMPORTHARBOUR'
go

execute sp_addextendedproperty 'MS_Description', 
   'cảng Nhập hàng',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_EXPORTHARBOUR'
go

execute sp_addextendedproperty 'MS_Description', 
   'tổng Số tiền',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_AMOUNTAF'
go

execute sp_addextendedproperty 'MS_Description', 
   '% thuế xuất nhập khẩu',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_TAXIMEXPER'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mô tả cho hóa đơn thương mại',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_INVOICEBUSDESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày xuất hóa đơn thượng mại',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_INVOICEBUSCREATEDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại 
   1 Xuất khẩu 
   2 Nhập khẩu',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_BUSTYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Kich hoạt không
   true :active
   false :none active',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_ISACTIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Danh sach nghiệp vụ cha
   SO
   hoặc PO
   cho hai trường hợp nhập xuất',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_LISTPAREN'
go

execute sp_addextendedproperty 'MS_Description', 
   'Lưu vết lại các hóa đơn VAT tạo ra tờ khai
   
   danh cho trường hợp xuất khẩu',
   'user', '', 'table', 'PUBDECLARATION', 'column', 'DEC_LISTINVOICE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_69_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_69_FK on PUBDECLARATION (
CON_AUTOID2 ASC
)
go

/*==============================================================*/
/* Table: PUBDECLARATIONDETAIL                                  */
/*==============================================================*/
create table PUBDECLARATIONDETAIL (
   DECD_AUTOID          int                  not null,
   TUR_AUTOID           smallint             null,
   PIT_AUTOID           int                  null,
   ET_AUTOID            bigint               null,
   RETURNID             bigint               null,
   DECD_REQQUANTITY     decimal(10,3)        null,
   DECD_REALQUANTITY    decimal(10,3)        null,
   DECD_TOTALAMOUNT     numeric(18,3)        null,
   DECD_EXTAXPER        decimal(2,2)         null,
   DECD_IMPORTTAXPER    decimal(2,2)         null,
   DECD_PERREDUCE       decimal(2,2)         null,
   DECD_PERDISCOUNT     decimal(2,2)         null,
   DECD_NOTE            nvarchar(100)        null,
   DECD_ITEMTYPE        smallint             null,
   DECD_ISACTIVE        bit                  null,
   constraint PK_PUBDECLARATIONDETAIL primary key nonclustered (DECD_AUTOID)
)
go

declare @CmtPUBDECLARATIONDETAIL varchar(128)
select @CmtPUBDECLARATIONDETAIL = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Chi tiết tờ khai',
   'user', @CmtPUBDECLARATIONDETAIL, 'table', 'PUBDECLARATIONDETAIL'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBDECLARATIONDETAIL', 'column', 'DECD_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tu tăng',
   'user', '', 'table', 'PUBDECLARATIONDETAIL', 'column', 'TUR_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'PIT_AutoID',
   'user', '', 'table', 'PUBDECLARATIONDETAIL', 'column', 'PIT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã định khoản tự dộng tăng',
   'user', '', 'table', 'PUBDECLARATIONDETAIL', 'column', 'ET_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Lấy từ bảng Document ',
   'user', '', 'table', 'PUBDECLARATIONDETAIL', 'column', 'RETURNID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Số lượng Trên PO or SO',
   'user', '', 'table', 'PUBDECLARATIONDETAIL', 'column', 'DECD_REQQUANTITY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Số lượng thực tế',
   'user', '', 'table', 'PUBDECLARATIONDETAIL', 'column', 'DECD_REALQUANTITY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Thành tiền',
   'user', '', 'table', 'PUBDECLARATIONDETAIL', 'column', 'DECD_TOTALAMOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   '% thuế nhập xuất',
   'user', '', 'table', 'PUBDECLARATIONDETAIL', 'column', 'DECD_EXTAXPER'
go

execute sp_addextendedproperty 'MS_Description', 
   '% thuế nhập khẩu',
   'user', '', 'table', 'PUBDECLARATIONDETAIL', 'column', 'DECD_IMPORTTAXPER'
go

execute sp_addextendedproperty 'MS_Description', 
   'PercentReduce
   % Giảm giá',
   'user', '', 'table', 'PUBDECLARATIONDETAIL', 'column', 'DECD_PERREDUCE'
go

execute sp_addextendedproperty 'MS_Description', 
   '% CHIẾT KHẤU',
   'user', '', 'table', 'PUBDECLARATIONDETAIL', 'column', 'DECD_PERDISCOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ghi chú',
   'user', '', 'table', 'PUBDECLARATIONDETAIL', 'column', 'DECD_NOTE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại :
   Example : 
   1 Item
   2 None',
   'user', '', 'table', 'PUBDECLARATIONDETAIL', 'column', 'DECD_ITEMTYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Được kích hoat không',
   'user', '', 'table', 'PUBDECLARATIONDETAIL', 'column', 'DECD_ISACTIVE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_46_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_46_FK on PUBDECLARATIONDETAIL (
RETURNID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_55_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_55_FK on PUBDECLARATIONDETAIL (
PIT_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_68_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_68_FK on PUBDECLARATIONDETAIL (
TUR_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_90_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_90_FK on PUBDECLARATIONDETAIL (
ET_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBDESCRIPTORITEM                                     */
/*==============================================================*/
create table PUBDESCRIPTORITEM (
   DEI_AUTOID           smallint             not null,
   OBJ_AUTOID2          int                  null,
   CUR_AUTOID4          smallint             null,
   SEL_DESNO            nchar(10)            null,
   SEI_DESNAME          nvarchar(200)        null,
   SEL_DESTYPE          smallint             null,
   SEI_DESGROUPID       smallint             null,
   SEL_DESVAT           decimal(2,2)         null,
   SEI_DESUNIT          decimal(18,3)        null,
   SEI_DESNOTE          nvarchar(200)        null,
   SEI_DESTURACCOUNT    nchar(10)            null,
   SEI_COSTACCOUNT_     nchar(10)            null,
   SEI_DESDISACCOUNT    nchar(10)            null,
   SEI_REDUCEACCOUNT_   nchar(10)            null,
   SEI_DESFILEURL       nvarchar(200)        null,
   SEI_DESPRICEREAL     decimal(18,3)        null,
   SEI_DESPRIMEPRICE    decimal(18,3)        null,
   SEI_ISACTIVE         bit                  null,
   constraint PK_PUBDESCRIPTORITEM primary key nonclustered (DEI_AUTOID)
)
go

declare @CmtPUBDESCRIPTORITEM varchar(128)
select @CmtPUBDESCRIPTORITEM = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Dịch vụ của nhà cung cấp service',
   'user', @CmtPUBDESCRIPTORITEM, 'table', 'PUBDESCRIPTORITEM'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tự tặng',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'DEI_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã đối tượng tự động tăng',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'OBJ_AUTOID2'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'CUR_AUTOID4'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã service tự quản lý',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'SEL_DESNO'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên service',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'SEI_DESNAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại  Service',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'SEL_DESTYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'nhóm  Dịch vụ',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'SEI_DESGROUPID'
go

execute sp_addextendedproperty 'MS_Description', 
   '% VAT',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'SEL_DESVAT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Đơn vị tính',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'SEI_DESUNIT'
go

execute sp_addextendedproperty 'MS_Description', 
   'ghi chú',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'SEI_DESNOTE'
go

execute sp_addextendedproperty 'MS_Description', 
   'DesTurnoverAccount
    TK doanh thu',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'SEI_DESTURACCOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'TK chi phi',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'SEI_COSTACCOUNT_'
go

execute sp_addextendedproperty 'MS_Description', 
   'DesDiscountAccount
    TK chiết khấu',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'SEI_DESDISACCOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'SEI_DesReduceAccount
   TK giảm giá ',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'SEI_REDUCEACCOUNT_'
go

execute sp_addextendedproperty 'MS_Description', 
   'File kem theo',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'SEI_DESFILEURL'
go

execute sp_addextendedproperty 'MS_Description', 
   ' Giá kinh doanh, giá thực',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'SEI_DESPRICEREAL'
go

execute sp_addextendedproperty 'MS_Description', 
   ' Giá co bản',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'SEI_DESPRIMEPRICE'
go

execute sp_addextendedproperty 'MS_Description', 
   'kích hoạt',
   'user', '', 'table', 'PUBDESCRIPTORITEM', 'column', 'SEI_ISACTIVE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_107_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_107_FK on PUBDESCRIPTORITEM (
CUR_AUTOID4 ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_105_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_105_FK on PUBDESCRIPTORITEM (
OBJ_AUTOID2 ASC
)
go

/*==============================================================*/
/* Table: PUBENTRY                                              */
/*==============================================================*/
create table PUBENTRY (
   ET_AUTOID            bigint               not null,
   COT_AUTOID           int                  null,
   BAK_AUTOID3          smallint             null,
   ET_DEBTORACCOUNT     nchar(10)            null,
   ET_DEBTOREXPLAIN     nvarchar(200)        null,
   ET_CREDITACCOUNT     nchar(10)            null,
   ET_CREDITEXPLAIN     nvarchar(200)        null,
   ET_TOTALAMOUNT       decimal(18,3)        null,
   ET_NOTE              nvarchar(200)        null,
   ET_EXCHANGERATE      decimal(18,3)        null,
   ET_COSTINGID         smallint             null,
   ET_OFSUBSYSTEM       smallint             null,
   ET_BUSSINESSID       bigint               null,
   ET_ISACTIVE          bit                  null,
   constraint PK_PUBENTRY primary key nonclustered (ET_AUTOID)
)
go

declare @CmtPUBENTRY varchar(128)
select @CmtPUBENTRY = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Định khoản cho các phân hệ,AR,AP,CM
   dinh khoản thi phải biết cho nghiệp vu nao các trường hợp cần định khoản
   1 có thể định khoản cho hóa đơn 
   2 có thể định khoản cho tờ khai nếu là trượng hợp xuất nhập khẩu 
   3 có thể định khoản cho nghiệp vụ trường hợp không có hóa đơn 
   4 và trường hợp có cả 3 
    cẩn thạn cái vụ này ',
   'user', @CmtPUBENTRY, 'table', 'PUBENTRY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã định khoản tự dộng tăng',
   'user', '', 'table', 'PUBENTRY', 'column', 'ET_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'COT_AutoID',
   'user', '', 'table', 'PUBENTRY', 'column', 'COT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBENTRY', 'column', 'BAK_AUTOID3'
go

execute sp_addextendedproperty 'MS_Description', 
   'tài khoản nợ ',
   'user', '', 'table', 'PUBENTRY', 'column', 'ET_DEBTORACCOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Diễn giải tài khoản nọ',
   'user', '', 'table', 'PUBENTRY', 'column', 'ET_DEBTOREXPLAIN'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tài khoản có',
   'user', '', 'table', 'PUBENTRY', 'column', 'ET_CREDITACCOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Diễn giải tài khoản có',
   'user', '', 'table', 'PUBENTRY', 'column', 'ET_CREDITEXPLAIN'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tiền nguyên tệ',
   'user', '', 'table', 'PUBENTRY', 'column', 'ET_TOTALAMOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ghi chú',
   'user', '', 'table', 'PUBENTRY', 'column', 'ET_NOTE'
go

execute sp_addextendedproperty 'MS_Description', 
   'tỷ giá ',
   'user', '', 'table', 'PUBENTRY', 'column', 'ET_EXCHANGERATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Giá thành',
   'user', '', 'table', 'PUBENTRY', 'column', 'ET_COSTINGID'
go

execute sp_addextendedproperty 'MS_Description', 
   'dinh khoản cho phân hệ nào
   Dinh khoan cho nghiệp vụ AR,AP,CMP,CMR
   1 AR
   2 AP
   3 CMP
   4 CMR
   5 IC,
   6 FA
   ',
   'user', '', 'table', 'PUBENTRY', 'column', 'ET_OFSUBSYSTEM'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mang ID cua nghiệp vụ Để biết nguồn từ đâu  có thể là hóa đơn, tờ khai, nghiệp vụ nhập kho, tài sản
   ',
   'user', '', 'table', 'PUBENTRY', 'column', 'ET_BUSSINESSID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Được kích hoạt không',
   'user', '', 'table', 'PUBENTRY', 'column', 'ET_ISACTIVE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_54_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_54_FK on PUBENTRY (
BAK_AUTOID3 ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_72_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_72_FK on PUBENTRY (
COT_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBINVOICE                                            */
/*==============================================================*/
create table PUBINVOICE (
   IV_DOCUMENTID        bigint               not null,
   CUR_AUTOID4          smallint             null,
   IV_DOCUMENTNO        nchar(10)            null,
   IV_EXPORTTAX         decimal(2,2)         null,
   IV_TAXCURRENCY       decimal(18,3)        null,
   IV_AMOUNT            money                null,
   IV_BEAMOUNT          money                null,
   IV_AFAMOUNT          decimal(18,3)        null,
   IV_DISCOUNTPER       decimal(3,2)         null,
   IV_DISAMOUNT         decimal(18,3)        null,
   IV_TYPE              smallint             null,
   IV_ISACTIVE          bit                  null,
   constraint PK_PUBINVOICE primary key nonclustered (IV_DOCUMENTID)
)
go

declare @CmtPUBINVOICE varchar(128)
select @CmtPUBINVOICE = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Hóa đơn Chung với hóa đơn này sài chung cho AR,AP,CM,GL 
   nên thông tin nên cẩn thận',
   'user', @CmtPUBINVOICE, 'table', 'PUBINVOICE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã hóa đơn lấy từ bảng Document',
   'user', '', 'table', 'PUBINVOICE', 'column', 'IV_DOCUMENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBINVOICE', 'column', 'CUR_AUTOID4'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã hóa đơn tự quản lý
   Số hóa Đơn',
   'user', '', 'table', 'PUBINVOICE', 'column', 'IV_DOCUMENTNO'
go

execute sp_addextendedproperty 'MS_Description', 
   '% Thuế xuất',
   'user', '', 'table', 'PUBINVOICE', 'column', 'IV_EXPORTTAX'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tiềng thuế',
   'user', '', 'table', 'PUBINVOICE', 'column', 'IV_TAXCURRENCY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tiền nguyên tệ',
   'user', '', 'table', 'PUBINVOICE', 'column', 'IV_AMOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tiền trước thuế',
   'user', '', 'table', 'PUBINVOICE', 'column', 'IV_BEAMOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'tiền sau thuế',
   'user', '', 'table', 'PUBINVOICE', 'column', 'IV_AFAMOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   '%  Chiết khấu',
   'user', '', 'table', 'PUBINVOICE', 'column', 'IV_DISCOUNTPER'
go

execute sp_addextendedproperty 'MS_Description', 
   'tiền chiết khấu',
   'user', '', 'table', 'PUBINVOICE', 'column', 'IV_DISAMOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại Hóa đơn
   1 Mua,
   2: bán 
   3 Mua trả lại
   4 Bán trả lại',
   'user', '', 'table', 'PUBINVOICE', 'column', 'IV_TYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Kích hoạt',
   'user', '', 'table', 'PUBINVOICE', 'column', 'IV_ISACTIVE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_125_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_125_FK on PUBINVOICE (
CUR_AUTOID4 ASC
)
go

/*==============================================================*/
/* Table: PUBINVOICEDETAIL                                      */
/*==============================================================*/
create table PUBINVOICEDETAIL (
   IVD_AUTOID           int                  not null,
   TAXR_AUTOID          smallint             null,
   PIT_AUTOID           int                  null,
   PRJ_AUTOID           smallint             null,
   IV_DOCUMENTID        bigint               null,
   ET_AUTOID            bigint               null,
   COT_AUTOID           int                  null,
   TUR_AUTOID           smallint             null,
   WH_AUTOID            int                  null,
   IVD_ITEMNAME         nvarchar(200)        null,
   IVD_ITEMNO           nchar(10)            null,
   IVD_TYPE             smallint             null,
   IVD_REQQUANTITY      decimal(18,3)        null,
   IVD_QUANTITYREAL     decimal(18,3)        null,
   IVD_TOTALAMOUNT      numeric(18,3)        null,
   IVD_PERCENTTAX       decimal(10,3)        null,
   IVD_IMPORTPERCENTTAX decimal(10,3)        null,
   IVD_REDUCEPER        decimal(3,2)         null,
   IVD_REDUCEMONEY      decimal(18,3)        null,
   IVD_NOTE             nvarchar(100)        null,
   IVD_CONVERTQUANTITY  numeric(10,3)        null,
   IVD_UNITOM           smallint             null,
   IVD_UNITOMEXTEND     smallint             null,
   IVD_UNITPPICE        decimal(18,3)        null,
   IVD_ISACTIVE         bit                  null,
   constraint PK_PUBINVOICEDETAIL primary key nonclustered (IVD_AUTOID)
)
go

declare @CmtPUBINVOICEDETAIL varchar(128)
select @CmtPUBINVOICEDETAIL = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Chi tiết hóa đơn',
   'user', @CmtPUBINVOICEDETAIL, 'table', 'PUBINVOICEDETAIL'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã chi tiết hóa đơn tự động tăng',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tự động tăng',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'TAXR_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'PIT_AutoID',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'PIT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'PRJ_AutoID',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'PRJ_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã hóa đơn lấy từ bảng Document',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IV_DOCUMENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã định khoản tự dộng tăng',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'ET_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'COT_AutoID',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'COT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tu tăng',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'TUR_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'WH_AutoID',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'WH_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên mặt hàng',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_ITEMNAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã mặt hàng tự quản lý',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_ITEMNO'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại :
   Example : 
   1 Item
   2 None',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_TYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Số lượng yêu cầu',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_REQQUANTITY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Số lượng thực mua hoặc bán',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_QUANTITYREAL'
go

execute sp_addextendedproperty 'MS_Description', 
   'Thành tiền',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_TOTALAMOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   '% thuế',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_PERCENTTAX'
go

execute sp_addextendedproperty 'MS_Description', 
   '% thuế nhập khẩu',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_IMPORTPERCENTTAX'
go

execute sp_addextendedproperty 'MS_Description', 
   '% Giảm giá',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_REDUCEPER'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tiền giảm giá',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_REDUCEMONEY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ghi chú',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_NOTE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Số lượng chuyển đổi',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_CONVERTQUANTITY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Đơn vị tính chuẩn
   nói về số lượng',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_UNITOM'
go

execute sp_addextendedproperty 'MS_Description', 
   'Đơn vị yêu cầu hay đơn vị thực tế',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_UNITOMEXTEND'
go

execute sp_addextendedproperty 'MS_Description', 
   'Đơn giá',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_UNITPPICE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Được kích hoat không',
   'user', '', 'table', 'PUBINVOICEDETAIL', 'column', 'IVD_ISACTIVE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_62_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_62_FK on PUBINVOICEDETAIL (
TAXR_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_63_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_63_FK on PUBINVOICEDETAIL (
WH_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_65_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_65_FK on PUBINVOICEDETAIL (
TUR_AUTOID ASC
)
go

/*==============================================================*/
/* Index: ITEM_FK                                               */
/*==============================================================*/
create index ITEM_FK on PUBINVOICEDETAIL (
IV_DOCUMENTID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_130_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_130_FK on PUBINVOICEDETAIL (
PIT_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_128_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_128_FK on PUBINVOICEDETAIL (
PRJ_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_129_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_129_FK on PUBINVOICEDETAIL (
COT_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_61_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_61_FK on PUBINVOICEDETAIL (
ET_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBITEMS                                              */
/*==============================================================*/
create table PUBITEMS (
   PIT_AUTOID           int                  not null,
   OBJ_AUTOID2          int                  null,
   CUR_AUTOID4          smallint             null,
   WH_AUTOID            int                  null,
   constraint PK_PUBITEMS primary key nonclustered (PIT_AUTOID)
)
go

declare @CmtPUBITEMS varchar(128)
select @CmtPUBITEMS = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Hoàn hóa',
   'user', @CmtPUBITEMS, 'table', 'PUBITEMS'
go

execute sp_addextendedproperty 'MS_Description', 
   'PIT_AutoID',
   'user', '', 'table', 'PUBITEMS', 'column', 'PIT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã đối tượng tự động tăng',
   'user', '', 'table', 'PUBITEMS', 'column', 'OBJ_AUTOID2'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBITEMS', 'column', 'CUR_AUTOID4'
go

execute sp_addextendedproperty 'MS_Description', 
   'WH_AutoID',
   'user', '', 'table', 'PUBITEMS', 'column', 'WH_AUTOID'
go

/*==============================================================*/
/* Index: RELATIONSHIP_87_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_87_FK on PUBITEMS (
WH_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_88_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_88_FK on PUBITEMS (
OBJ_AUTOID2 ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_106_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_106_FK on PUBITEMS (
CUR_AUTOID4 ASC
)
go

/*==============================================================*/
/* Table: PUBOBJECT                                             */
/*==============================================================*/
create table PUBOBJECT (
   OBJ_AUTOID2          int                  not null,
   constraint PK_PUBOBJECT primary key nonclustered (OBJ_AUTOID2)
)
go

declare @CmtPUBOBJECT varchar(128)
select @CmtPUBOBJECT = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'là một đối tượng Tượng chưng cho nhà cung cấp, khách hàng,...',
   'user', @CmtPUBOBJECT, 'table', 'PUBOBJECT'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã đối tượng tự động tăng',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_AUTOID2'
go

/*==============================================================*/
/* Table: PUBPAYMENTMETHOD                                      */
/*==============================================================*/
create table PUBPAYMENTMETHOD (
   PAY_AUTOID3          int                  not null,
   constraint PK_PUBPAYMENTMETHOD primary key nonclustered (PAY_AUTOID3)
)
go

declare @CmtPUBPAYMENTMETHOD varchar(128)
select @CmtPUBPAYMENTMETHOD = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Phương thức thanh toán
   Thanh toán bằng tiền mặt, tiền ngân hàng',
   'user', @CmtPUBPAYMENTMETHOD, 'table', 'PUBPAYMENTMETHOD'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBPAYMENTMETHOD', 'column', 'PAY_AUTOID3'
go

/*==============================================================*/
/* Table: PUBPLAN                                               */
/*==============================================================*/
create table PUBPLAN (
   PLA_DOCUMENTID       bigint               not null,
   PLA_DESCRIPTION      nchar(200)           null,
   PLA_TYPE             smallint             null,
   PLA_STATUS           smallint             null,
   PLA_BUSINESSES       smallint             null,
   PLA_AMOUNTREAL       decimal(18,3)        null,
   PLA_PROPOSEPAY       nchar(100)           null,
   PLA_BEGINDATE        datetime             null,
   PLA_ENDDATE          datetime             null,
   PLA_AMOUNT           decimal(18,3)        null,
   PLA_OBJECT           nvarchar(200)        null,
   PLA_RESION           nvarchar(200)        null,
   PLA_ISATIVE          bit                  null,
   PLA_SUBSYSTEM        smallint             null,
   constraint PK_PUBPLAN primary key nonclustered (PLA_DOCUMENTID)
)
go

declare @CmtPUBPLAN varchar(128)
select @CmtPUBPLAN = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Lập kế hoạch',
   'user', @CmtPUBPLAN, 'table', 'PUBPLAN'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tài liệu',
   'user', '', 'table', 'PUBPLAN', 'column', 'PLA_DOCUMENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Miêu tả',
   'user', '', 'table', 'PUBPLAN', 'column', 'PLA_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại 
   1 Công nợ phải thu
   2  Công nợ phải trả
   3 Casch Management
   4 CMPayment',
   'user', '', 'table', 'PUBPLAN', 'column', 'PLA_TYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   '1 Mới
   2 :Đang thực hiện
   3:Kết thúc
   4: Trễ kế hoạch
   ',
   'user', '', 'table', 'PUBPLAN', 'column', 'PLA_STATUS'
go

execute sp_addextendedproperty 'MS_Description', 
   'Nghiệp vụ
   1: Trong nước,
   2: xuất,
   3:  nhập khẩu
   ',
   'user', '', 'table', 'PUBPLAN', 'column', 'PLA_BUSINESSES'
go

execute sp_addextendedproperty 'MS_Description', 
   'Giá trị thực thanh toán',
   'user', '', 'table', 'PUBPLAN', 'column', 'PLA_AMOUNTREAL'
go

execute sp_addextendedproperty 'MS_Description', 
   'List ID Đề xuất thanh toán
   danh sách đề xuất thanh toán
   cách nhau bằng dấu ; khi lập trình có thể cắt ra sử lý
   
   DX001;DX002',
   'user', '', 'table', 'PUBPLAN', 'column', 'PLA_PROPOSEPAY'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày bắt đầu',
   'user', '', 'table', 'PUBPLAN', 'column', 'PLA_BEGINDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày kết thúc',
   'user', '', 'table', 'PUBPLAN', 'column', 'PLA_ENDDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Số tiền',
   'user', '', 'table', 'PUBPLAN', 'column', 'PLA_AMOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Đối tượng',
   'user', '', 'table', 'PUBPLAN', 'column', 'PLA_OBJECT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Lý do ',
   'user', '', 'table', 'PUBPLAN', 'column', 'PLA_RESION'
go

execute sp_addextendedproperty 'MS_Description', 
   'kích hoạt',
   'user', '', 'table', 'PUBPLAN', 'column', 'PLA_ISATIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   ' Nguồn từ phân hệ nào
   1 AR
   2 AP
   3 CM
   4 GL',
   'user', '', 'table', 'PUBPLAN', 'column', 'PLA_SUBSYSTEM'
go

/*==============================================================*/
/* Table: PUBPROJECT                                            */
/*==============================================================*/
create table PUBPROJECT (
   PRJ_AUTOID           smallint             not null,
   constraint PK_PUBPROJECT primary key nonclustered (PRJ_AUTOID)
)
go

declare @CmtPUBPROJECT varchar(128)
select @CmtPUBPROJECT = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Dự án',
   'user', @CmtPUBPROJECT, 'table', 'PUBPROJECT'
go

execute sp_addextendedproperty 'MS_Description', 
   'PRJ_AutoID',
   'user', '', 'table', 'PUBPROJECT', 'column', 'PRJ_AUTOID'
go

/*==============================================================*/
/* Table: PUBPROPOSEPAY                                         */
/*==============================================================*/
create table PUBPROPOSEPAY (
   PPAY_DOCUMENTID      bigint               not null,
   PPAY_TYPE            smallint             null
      constraint CKC_PPAY_TYPE_PUBPROPO check (PPAY_TYPE is null or (PPAY_TYPE = lower(PPAY_TYPE))),
   PRE_DESCRIPTION      nchar(200)           null,
   PPAY_AMOUNT          decimal(18,3)        null,
   PPAY_STATUS          smallint             null default 1,
   PPAY_VALUEREAL       decimal(18,3)        null,
   PPAY_CLASSIFY        nchar(1)             null,
   PPAY_SUBSYSTEM       smallint             null,
   PPAY_ISACTIVE        bit                  null default 0,
   PPAY_PAYDATE         datetime             null,
   PPAY_PAYTIME         smallint             null,
   constraint PK_PUBPROPOSEPAY primary key nonclustered (PPAY_DOCUMENTID)
)
go

declare @CmtPUBPROPOSEPAY varchar(128)
select @CmtPUBPROPOSEPAY = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Yêu cầu thanh toán',
   'user', @CmtPUBPROPOSEPAY, 'table', 'PUBPROPOSEPAY'
go

execute sp_addextendedproperty 'MS_Description', 
   'pPay_DocumentID',
   'user', '', 'table', 'PUBPROPOSEPAY', 'column', 'PPAY_DOCUMENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'loại
   1 Thu
   2 chi
   3 Công nợ AP
   4 công nợ AR',
   'user', '', 'table', 'PUBPROPOSEPAY', 'column', 'PPAY_TYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Pre_Description',
   'user', '', 'table', 'PUBPROPOSEPAY', 'column', 'PRE_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Giá trị Đề xuất, Po So, Giá trị về tiền',
   'user', '', 'table', 'PUBPROPOSEPAY', 'column', 'PPAY_AMOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Trang thai
   1 News,
   2 Duyệt
   3 Đưa vào kế hoạch',
   'user', '', 'table', 'PUBPROPOSEPAY', 'column', 'PPAY_STATUS'
go

execute sp_addextendedproperty 'MS_Description', 
   'Giá trị thực tế',
   'user', '', 'table', 'PUBPROPOSEPAY', 'column', 'PPAY_VALUEREAL'
go

execute sp_addextendedproperty 'MS_Description', 
   'Phân loại',
   'user', '', 'table', 'PUBPROPOSEPAY', 'column', 'PPAY_CLASSIFY'
go

execute sp_addextendedproperty 'MS_Description', 
   ' Nguồn từ phân hệ nào
   1 SO
   2 PO',
   'user', '', 'table', 'PUBPROPOSEPAY', 'column', 'PPAY_SUBSYSTEM'
go

execute sp_addextendedproperty 'MS_Description', 
   'Kích hoạt',
   'user', '', 'table', 'PUBPROPOSEPAY', 'column', 'PPAY_ISACTIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày yêu cầu thanh toán',
   'user', '', 'table', 'PUBPROPOSEPAY', 'column', 'PPAY_PAYDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Lầng thanh toán',
   'user', '', 'table', 'PUBPROPOSEPAY', 'column', 'PPAY_PAYTIME'
go

/*==============================================================*/
/* Table: PUBTAX                                                */
/*==============================================================*/
create table PUBTAX (
   TAX_AUTOID4          int                  not null,
   TAXR_AUTOID          smallint             null,
   TAX_TYPEID           smallint             null,
   TAX_ACCOUNTID        nchar(10)            null,
   TAX_DESCRITION       nvarchar(200)        null,
   TAX_NOTE             nvarchar(100)        null,
   TAX_ISACTIVE         bit                  null,
   constraint PK_PUBTAX primary key nonclustered (TAX_AUTOID4)
)
go

declare @CmtPUBTAX varchar(128)
select @CmtPUBTAX = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Thuế',
   'user', @CmtPUBTAX, 'table', 'PUBTAX'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID Tự tăng',
   'user', '', 'table', 'PUBTAX', 'column', 'TAX_AUTOID4'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tự động tăng',
   'user', '', 'table', 'PUBTAX', 'column', 'TAXR_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại thuế',
   'user', '', 'table', 'PUBTAX', 'column', 'TAX_TYPEID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tài khoản',
   'user', '', 'table', 'PUBTAX', 'column', 'TAX_ACCOUNTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mô tả',
   'user', '', 'table', 'PUBTAX', 'column', 'TAX_DESCRITION'
go

execute sp_addextendedproperty 'MS_Description', 
   'ghi chú',
   'user', '', 'table', 'PUBTAX', 'column', 'TAX_NOTE'
go

execute sp_addextendedproperty 'MS_Description', 
   'TAX_IsActive',
   'user', '', 'table', 'PUBTAX', 'column', 'TAX_ISACTIVE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_73_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_73_FK on PUBTAX (
TAXR_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBTAXRATE                                            */
/*==============================================================*/
create table PUBTAXRATE (
   TAXR_AUTOID          smallint             not null,
   TAXR_NAME            nvarchar(100)        null,
   TAXR_DESCRIPTION     nvarchar(200)        null,
   TAXR_ISACTIVE        bit                  null,
   constraint PK_PUBTAXRATE primary key nonclustered (TAXR_AUTOID)
)
go

declare @CmtPUBTAXRATE varchar(128)
select @CmtPUBTAXRATE = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Biểu đồ thuế hay loại thuế',
   'user', @CmtPUBTAXRATE, 'table', 'PUBTAXRATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tự động tăng',
   'user', '', 'table', 'PUBTAXRATE', 'column', 'TAXR_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên ',
   'user', '', 'table', 'PUBTAXRATE', 'column', 'TAXR_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mô tả ',
   'user', '', 'table', 'PUBTAXRATE', 'column', 'TAXR_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'kích hoạt',
   'user', '', 'table', 'PUBTAXRATE', 'column', 'TAXR_ISACTIVE'
go

/*==============================================================*/
/* Table: PUBTURNOVER                                           */
/*==============================================================*/
create table PUBTURNOVER (
   TUR_AUTOID           smallint             not null,
   TURT_AUTOID          smallint             null,
   TUR_NAME             nvarchar(150)        null,
   TUR_COSTPRICE        decimal(18,3)        null,
   TUR_SUMMARY          nvarchar(200)        null,
   TUR_ISACTIVE         bit                  null,
   TUR_PARENTID         smallint             null,
   TUR_LEVEL            smallint             null,
   TUR_PATH             nchar(200)           null,
   constraint PK_PUBTURNOVER primary key nonclustered (TUR_AUTOID)
)
go

declare @CmtPUBTURNOVER varchar(128)
select @CmtPUBTURNOVER = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Khoản mục',
   'user', @CmtPUBTURNOVER, 'table', 'PUBTURNOVER'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tu tăng',
   'user', '', 'table', 'PUBTURNOVER', 'column', 'TUR_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tu tăng',
   'user', '', 'table', 'PUBTURNOVER', 'column', 'TURT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên khoản mục',
   'user', '', 'table', 'PUBTURNOVER', 'column', 'TUR_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Chi phí',
   'user', '', 'table', 'PUBTURNOVER', 'column', 'TUR_COSTPRICE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Miêu tả',
   'user', '', 'table', 'PUBTURNOVER', 'column', 'TUR_SUMMARY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Kích hoạt',
   'user', '', 'table', 'PUBTURNOVER', 'column', 'TUR_ISACTIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Liên kết với tra nó',
   'user', '', 'table', 'PUBTURNOVER', 'column', 'TUR_PARENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Cấp',
   'user', '', 'table', 'PUBTURNOVER', 'column', 'TUR_LEVEL'
go

execute sp_addextendedproperty 'MS_Description', 
   'Đường dẫng',
   'user', '', 'table', 'PUBTURNOVER', 'column', 'TUR_PATH'
go

/*==============================================================*/
/* Index: RELATIONSHIP_64_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_64_FK on PUBTURNOVER (
TURT_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBTURNOVERTYPE                                       */
/*==============================================================*/
create table PUBTURNOVERTYPE (
   TURT_AUTOID          smallint             not null,
   TURT_NAME            smallint             null,
   TURT_DESCRIPTION     nvarchar(200)        null,
   constraint PK_PUBTURNOVERTYPE primary key nonclustered (TURT_AUTOID)
)
go

declare @CmtPUBTURNOVERTYPE varchar(128)
select @CmtPUBTURNOVERTYPE = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Loại khoản mục 
   Exam : Chi phí doanh thu,khoản mục kinh doanh',
   'user', @CmtPUBTURNOVERTYPE, 'table', 'PUBTURNOVERTYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tu tăng',
   'user', '', 'table', 'PUBTURNOVERTYPE', 'column', 'TURT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên ',
   'user', '', 'table', 'PUBTURNOVERTYPE', 'column', 'TURT_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'mô tả',
   'user', '', 'table', 'PUBTURNOVERTYPE', 'column', 'TURT_DESCRIPTION'
go

/*==============================================================*/
/* Table: PUBWAREHOUSE                                          */
/*==============================================================*/
create table PUBWAREHOUSE (
   WH_AUTOID            int                  not null,
   constraint PK_PUBWAREHOUSE primary key nonclustered (WH_AUTOID)
)
go

declare @CmtPUBWAREHOUSE varchar(128)
select @CmtPUBWAREHOUSE = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Kho hàng ',
   'user', @CmtPUBWAREHOUSE, 'table', 'PUBWAREHOUSE'
go

execute sp_addextendedproperty 'MS_Description', 
   'WH_AutoID',
   'user', '', 'table', 'PUBWAREHOUSE', 'column', 'WH_AUTOID'
go

alter table APBUSINESS
   add constraint FK_APBUSINE_RELATIONS_PUBCURRE foreign key (CUR_AUTOID4)
      references PUBCURRENCY (CUR_AUTOID4)
go

alter table APBUSINESS
   add constraint FK_APBUSINE_RELATIONS_PUBPAYME foreign key (PAY_AUTOID3)
      references PUBPAYMENTMETHOD (PAY_AUTOID3)
go

alter table APBUSINESS
   add constraint FK_APBUSINE_RELATIONS_PUBBATCH foreign key (PUBAT_AUTOID)
      references PUBBATCH (PUBAT_AUTOID)
go

alter table APBUSINESS
   add constraint FK_APBUSINE_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID2)
      references PUBOBJECT (OBJ_AUTOID2)
go

alter table ARBUSINESS
   add constraint FK_ARBUSINE_RELATIONS_PUBPAYME foreign key (PAY_AUTOID3)
      references PUBPAYMENTMETHOD (PAY_AUTOID3)
go

alter table ARBUSINESS
   add constraint FK_ARBUSINE_RELATIONS_PUBBATCH foreign key (PUBAT_AUTOID)
      references PUBBATCH (PUBAT_AUTOID)
go

alter table ARBUSINESS
   add constraint FK_ARBUSINE_RELATIONS_PUBCURRE foreign key (CUR_AUTOID4)
      references PUBCURRENCY (CUR_AUTOID4)
go

alter table ARBUSINESS
   add constraint FK_ARBUSINE_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID2)
      references PUBOBJECT (OBJ_AUTOID2)
go

alter table CMPAYMENT
   add constraint FK_CMPAYMEN_CMPAY_BAN_PUBBANK foreign key (BAK_AUTOID3)
      references PUBBANK (BAK_AUTOID3)
go

alter table CMPAYMENT
   add constraint FK_CMPAYMEN_CM_PAMENT_PUBCURRE foreign key (CUR_AUTOID4)
      references PUBCURRENCY (CUR_AUTOID4)
go

alter table CMPAYMENT
   add constraint FK_CMPAYMEN_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID2)
      references PUBOBJECT (OBJ_AUTOID2)
go

alter table CMPAYMENT
   add constraint FK_CMPAYMEN_RELATIONS_PUBBATCH foreign key (PUBAT_AUTOID)
      references PUBBATCH (PUBAT_AUTOID)
go

alter table CMPAYMENT_LOG
   add constraint FK_CMPAYMEN_CMPAYLOG_PUBINVOI foreign key (IV_DOCUMENTID)
      references PUBINVOICE (IV_DOCUMENTID)
go

alter table CMPAYMENT_LOG
   add constraint FK_CMPAYMEN_CMPAYMENT_CMPAYMEN foreign key (CMP_DOCUMENTID)
      references CMPAYMENT (CMP_DOCUMENTID)
go

alter table CMRECEIPT
   add constraint FK_CMRECEIP_BANK_PUBBANK foreign key (BAK_AUTOID3)
      references PUBBANK (BAK_AUTOID3)
go

alter table CMRECEIPT
   add constraint FK_CMRECEIP_CURENCY_T_PUBCURRE foreign key (CUR_AUTOID4)
      references PUBCURRENCY (CUR_AUTOID4)
go

alter table CMRECEIPT
   add constraint FK_CMRECEIP_RELATIONS_PUBBATCH foreign key (PUBAT_AUTOID)
      references PUBBATCH (PUBAT_AUTOID)
go

alter table CMRECEIPT
   add constraint FK_CMRECEIP_RELATIONS_PUBBANKD foreign key (ACD_AUTOID)
      references PUBBANKDETAIL (ACD_AUTOID)
go

alter table CMRECEIPTLOG
   add constraint FK_CMRECEIP_CMRECEIPT_CMRECEIP foreign key (CMR_DOCUMENTID)
      references CMRECEIPT (CMR_DOCUMENTID)
go

alter table CMRECEIPTLOG
   add constraint FK_CMRECEIP_INVOICE_C_PUBINVOI foreign key (IV_DOCUMENTID)
      references PUBINVOICE (IV_DOCUMENTID)
go

alter table PROPPAYDETAIL
   add constraint FK_PROPPAYD_RELATIONS_PUBPROPO foreign key (PPAY_DOCUMENTID)
      references PUBPROPOSEPAY (PPAY_DOCUMENTID)
go

alter table PROPPAYDETAIL
   add constraint FK_PROPPAYD_RELATIONS_PUBCONTR foreign key (COT_AUTOID)
      references PUBCONTRACT (COT_AUTOID)
go

alter table PUBCOSTPRICEINOUT
   add constraint FK_PUBCOSTP_RELATIONS_PUBTURNO foreign key (TUR_AUTOID)
      references PUBTURNOVER (TUR_AUTOID)
go

alter table PUBDECLARATION
   add constraint FK_PUBDECLA_RELATIONS_PUBCOUNT foreign key (CON_AUTOID2)
      references PUBCOUNTRY (CON_AUTOID2)
go

alter table PUBDECLARATIONDETAIL
   add constraint FK_PUBDECLA_RELATIONS_PUBDECLA foreign key (RETURNID)
      references PUBDECLARATION (RETURNID)
go

alter table PUBDECLARATIONDETAIL
   add constraint FK_PUBDECLA_RELATIONS_PUBITEMS foreign key (PIT_AUTOID)
      references PUBITEMS (PIT_AUTOID)
go

alter table PUBDECLARATIONDETAIL
   add constraint FK_PUBDECLA_RELATIONS_PUBTURNO foreign key (TUR_AUTOID)
      references PUBTURNOVER (TUR_AUTOID)
go

alter table PUBDECLARATIONDETAIL
   add constraint FK_PUBDECLA_RELATIONS_PUBENTRY foreign key (ET_AUTOID)
      references PUBENTRY (ET_AUTOID)
go

alter table PUBDESCRIPTORITEM
   add constraint FK_PUBDESCR_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID2)
      references PUBOBJECT (OBJ_AUTOID2)
go

alter table PUBDESCRIPTORITEM
   add constraint FK_PUBDESCR_RELATIONS_PUBCURRE foreign key (CUR_AUTOID4)
      references PUBCURRENCY (CUR_AUTOID4)
go

alter table PUBENTRY
   add constraint FK_PUBENTRY_RELATIONS_PUBBANK foreign key (BAK_AUTOID3)
      references PUBBANK (BAK_AUTOID3)
go

alter table PUBENTRY
   add constraint FK_PUBENTRY_RELATIONS_PUBCONTR foreign key (COT_AUTOID)
      references PUBCONTRACT (COT_AUTOID)
go

alter table PUBINVOICE
   add constraint FK_PUBINVOI_RELATIONS_PUBCURRE foreign key (CUR_AUTOID4)
      references PUBCURRENCY (CUR_AUTOID4)
go

alter table PUBINVOICEDETAIL
   add constraint FK_PUBINVOI_ITEM_PUBINVOI foreign key (IV_DOCUMENTID)
      references PUBINVOICE (IV_DOCUMENTID)
go

alter table PUBINVOICEDETAIL
   add constraint FK_PUBINVOI_RELATIONS_PUBPROJE foreign key (PRJ_AUTOID)
      references PUBPROJECT (PRJ_AUTOID)
go

alter table PUBINVOICEDETAIL
   add constraint FK_PUBINVOI_RELATIONS_PUBCONTR foreign key (COT_AUTOID)
      references PUBCONTRACT (COT_AUTOID)
go

alter table PUBINVOICEDETAIL
   add constraint FK_PUBINVOI_RELATIONS_PUBITEMS foreign key (PIT_AUTOID)
      references PUBITEMS (PIT_AUTOID)
go

alter table PUBINVOICEDETAIL
   add constraint FK_PUBINVOI_RELATIONS_PUBENTRY foreign key (ET_AUTOID)
      references PUBENTRY (ET_AUTOID)
go

alter table PUBINVOICEDETAIL
   add constraint FK_PUBINVOI_RELATIONS_PUBTAXRA foreign key (TAXR_AUTOID)
      references PUBTAXRATE (TAXR_AUTOID)
go

alter table PUBINVOICEDETAIL
   add constraint FK_PUBINVOI_RELATIONS_PUBWAREH foreign key (WH_AUTOID)
      references PUBWAREHOUSE (WH_AUTOID)
go

alter table PUBINVOICEDETAIL
   add constraint FK_PUBINVOI_RELATIONS_PUBTURNO foreign key (TUR_AUTOID)
      references PUBTURNOVER (TUR_AUTOID)
go

alter table PUBITEMS
   add constraint FK_PUBITEMS_RELATIONS_PUBCURRE foreign key (CUR_AUTOID4)
      references PUBCURRENCY (CUR_AUTOID4)
go

alter table PUBITEMS
   add constraint FK_PUBITEMS_RELATIONS_PUBWAREH foreign key (WH_AUTOID)
      references PUBWAREHOUSE (WH_AUTOID)
go

alter table PUBITEMS
   add constraint FK_PUBITEMS_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID2)
      references PUBOBJECT (OBJ_AUTOID2)
go

alter table PUBTAX
   add constraint FK_PUBTAX_RELATIONS_PUBTAXRA foreign key (TAXR_AUTOID)
      references PUBTAXRATE (TAXR_AUTOID)
go

alter table PUBTURNOVER
   add constraint FK_PUBTURNO_RELATIONS_PUBTURNO foreign key (TURT_AUTOID)
      references PUBTURNOVERTYPE (TURT_AUTOID)
go

