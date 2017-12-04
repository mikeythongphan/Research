/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     2/9/2009 4:20:03 PM                          */
/*==============================================================*/


alter table FINANCYCICLE
   drop constraint FK_FINANCYC_RELATIONS_PUBYEAR
go

alter table ITEMSPOSITION
   drop constraint FK_ITEMSPOS_RELATIONS_PUBWAREH
go

alter table PUBBANKDETAIL
   drop constraint FK_PUBBANKD_RELATIONS_PUBBANK
go

alter table PUBCAREERDETAIL
   drop constraint FK_PUBCAREE_PUBCAREER_PUBCAREE
go

alter table PUBCAREERDETAIL
   drop constraint FK_PUBCAREE_PUBCAREER_PUBORGAN
go

alter table PUBCONTACT
   drop constraint FK_PUBCONTA_THONG_TIN_PUBOBJEC
go

alter table PUBCONTRACT
   drop constraint FK_PUBCONTR_DU_AN_PUBPROJE
go

alter table PUBCONTRACT
   drop constraint FK_PUBCONTR_HOP_DONG__PUBORGAN
go

alter table PUBCONTRACT
   drop constraint FK_PUBCONTR_LOAI_TIEN_PUBCURRE
go

alter table PUBCONTRACT
   drop constraint FK_PUBCONTR_RELATIONS_PUBCONTR
go

alter table PUBCONTRACT
   drop constraint FK_PUBCONTR_RELATIONS_PUBCONTA
go

alter table PUBCURRENCYRATE
   drop constraint FK_PUBCURRE_TY_GIA_PUBCURRE
go

alter table PUBDOCUMENT
   drop constraint FK_PUBDOCUM_RELATIONS_PUBDOCUM
go

alter table PUBDOCUMENT
   drop constraint FK_PUBDOCUM_RELATIONS_PUBORGAN
go

alter table PUBOBJECT
   drop constraint FK_PUBOBJEC_ACCOUNT_O_PUBACCOU
go

alter table PUBOBJECT
   drop constraint FK_PUBOBJEC_BANK_ACCO_PUBBANKD
go

alter table PUBOBJECT
   drop constraint FK_PUBOBJEC_DIA_CHI_C_PUBPROVI
go

alter table PUBOBJECT
   drop constraint FK_PUBOBJEC_LEVEL_PUBOBJLE
go

alter table PUBOBJECT
   drop constraint FK_PUBOBJEC_RELATIONS_PUBOBJGR
go

alter table PUBOBJECT
   drop constraint FK_PUBOBJEC_RELATIONS_PUBPAYME
go

alter table PUBORGANIZATION
   drop constraint FK_PUBORGAN_LOAI_HINH_PUBORGTY
go

alter table PUBORGANIZATION
   drop constraint FK_PUBORGAN_LOAI_TIEN_PUBCURRE
go

alter table PUBORGANIZATION
   drop constraint FK_PUBORGAN_RELATIONS_PUBPROVI
go

alter table PUBORGOBJ
   drop constraint FK_PUBORGOB_CONTENT_T_PUBOBJEC
go

alter table PUBORGOBJ
   drop constraint FK_PUBORGOB_PUBORGOBJ_PUBORGAN
go

alter table PUBORGOBJ
   drop constraint FK_PUBORGOB_PUBORGOBJ_PUBPOSIT
go

alter table PUBORGOBJ
   drop constraint FK_PUBORGOB_PUBORGOBJ_PUBOBJEC
go

alter table PUBPAYMENTTERM
   drop constraint FK_PUBPAYME_RELATIONS_PUB_PAYM
go

alter table PUBPAYMENTTERMDETAIL
   drop constraint FK_PUBPAYME_RELATIONS_PUBPAYME
go

alter table PUBPROJECT
   drop constraint FK_PUBPROJE_RELATIONS_PUBPROJE
go

alter table PUBPROJECT
   drop constraint FK_PUBPROJE_RELATIONS_PUBOBJEC
go

alter table PUBPROVINCE
   drop constraint FK_PUBPROVI_RELATIONS_PUBPLACE
go

alter table PUBPROVINCE
   drop constraint FK_PUBPROVI_RELATIONS_PUBCOUNT
go

alter table PUBPROVINCE
   drop constraint FK_PUBPROVI_RELATIONS_PUBORGAN
go

alter table PUBPROVINCE
   drop constraint FK_PUBPROVI_RELATIONS_PUBBANK
go

alter table PUBSHIPPING
   drop constraint FK_PUBSHIPP_RELATIONS_PUBPROVI
go

alter table PUBSHIPPING
   drop constraint FK_PUBSHIPP_RELATIONS_PUBCOUNT
go

alter table PUBSHIPPING
   drop constraint FK_PUBSHIPP_RELATIONS_PUBWAREH
go

alter table PUBSHIPPING
   drop constraint FK_PUBSHIPP_RELATIONS_PUBOBJEC
go

alter table PUBSHIPPING
   drop constraint FK_PUBSHIPP_RELATIONS_PUBSHIPM
go

alter table PUBTAX
   drop constraint FK_PUBTAX_RELATIONS_PUBTAXRA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FINANCYCICLE')
            and   name  = 'RELATIONSHIP_32_FK'
            and   indid > 0
            and   indid < 255)
   drop index FINANCYCICLE.RELATIONSHIP_32_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ITEMSPOSITION')
            and   name  = 'RELATIONSHIP_35_FK'
            and   indid > 0
            and   indid < 255)
   drop index ITEMSPOSITION.RELATIONSHIP_35_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBBANKDETAIL')
            and   name  = 'RELATIONSHIP_100_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBBANKDETAIL.RELATIONSHIP_100_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBCAREERDETAIL')
            and   name  = 'PUBCAREERDETAIL2_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBCAREERDETAIL.PUBCAREERDETAIL2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBCAREERDETAIL')
            and   name  = 'PUBCAREERDETAIL_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBCAREERDETAIL.PUBCAREERDETAIL_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBCONTACT')
            and   name  = 'THONG_TIN_LIEN_LAC_CUA_DOI_TUONG_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBCONTACT.THONG_TIN_LIEN_LAC_CUA_DOI_TUONG_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBCONTRACT')
            and   name  = 'DU_AN_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBCONTRACT.DU_AN_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBCONTRACT')
            and   name  = 'HOP_DONG_CUA_CONG_TY_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBCONTRACT.HOP_DONG_CUA_CONG_TY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBCONTRACT')
            and   name  = 'LOAI_TIEN_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBCONTRACT.LOAI_TIEN_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBCONTRACT')
            and   name  = 'RELATIONSHIP_108_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBCONTRACT.RELATIONSHIP_108_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBCONTRACT')
            and   name  = 'RELATIONSHIP_33_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBCONTRACT.RELATIONSHIP_33_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBCURRENCYRATE')
            and   name  = 'TY_GIA_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBCURRENCYRATE.TY_GIA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBDOCUMENT')
            and   name  = 'RELATIONSHIP_28_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBDOCUMENT.RELATIONSHIP_28_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBDOCUMENT')
            and   name  = 'RELATIONSHIP_30_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBDOCUMENT.RELATIONSHIP_30_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBOBJECT')
            and   name  = 'ACCOUNT_OF_OBJECT_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBOBJECT.ACCOUNT_OF_OBJECT_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBOBJECT')
            and   name  = 'BANK_ACCOUNT_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBOBJECT.BANK_ACCOUNT_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBOBJECT')
            and   name  = 'DIA_CHI_CUA_DOI_TUONG_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBOBJECT.DIA_CHI_CUA_DOI_TUONG_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBOBJECT')
            and   name  = 'LEVEL_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBOBJECT.LEVEL_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBOBJECT')
            and   name  = 'RELATIONSHIP_80_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBOBJECT.RELATIONSHIP_80_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBOBJECT')
            and   name  = 'RELATIONSHIP_82_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBOBJECT.RELATIONSHIP_82_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBORGANIZATION')
            and   name  = 'LOAI_HINH_HOAT_DONG_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBORGANIZATION.LOAI_HINH_HOAT_DONG_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBORGANIZATION')
            and   name  = 'LOAI_TIEN_AP_DUNG_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBORGANIZATION.LOAI_TIEN_AP_DUNG_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBORGANIZATION')
            and   name  = 'RELATIONSHIP_97_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBORGANIZATION.RELATIONSHIP_97_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBORGOBJ')
            and   name  = 'PUBORGOBJ2_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBORGOBJ.PUBORGOBJ2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBORGOBJ')
            and   name  = 'PUBORGOBJ3_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBORGOBJ.PUBORGOBJ3_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBORGOBJ')
            and   name  = 'PUBORGOBJ4_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBORGOBJ.PUBORGOBJ4_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBORGOBJ')
            and   name  = 'PUBORGOBJ_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBORGOBJ.PUBORGOBJ_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBPAYMENTTERM')
            and   name  = 'RELATIONSHIP_34_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBPAYMENTTERM.RELATIONSHIP_34_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBPAYMENTTERMDETAIL')
            and   name  = 'RELATIONSHIP_71_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBPAYMENTTERMDETAIL.RELATIONSHIP_71_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBPROJECT')
            and   name  = 'RELATIONSHIP_109_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBPROJECT.RELATIONSHIP_109_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBPROJECT')
            and   name  = 'RELATIONSHIP_112_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBPROJECT.RELATIONSHIP_112_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBPROVINCE')
            and   name  = 'RELATIONSHIP_36_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBPROVINCE.RELATIONSHIP_36_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBPROVINCE')
            and   name  = 'RELATIONSHIP_92_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBPROVINCE.RELATIONSHIP_92_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBPROVINCE')
            and   name  = 'RELATIONSHIP_96_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBPROVINCE.RELATIONSHIP_96_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBPROVINCE')
            and   name  = 'RELATIONSHIP_98_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBPROVINCE.RELATIONSHIP_98_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBSHIPPING')
            and   name  = 'RELATIONSHIP_104_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBSHIPPING.RELATIONSHIP_104_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBSHIPPING')
            and   name  = 'RELATIONSHIP_105_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBSHIPPING.RELATIONSHIP_105_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBSHIPPING')
            and   name  = 'RELATIONSHIP_26_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBSHIPPING.RELATIONSHIP_26_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBSHIPPING')
            and   name  = 'RELATIONSHIP_27_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBSHIPPING.RELATIONSHIP_27_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBSHIPPING')
            and   name  = 'RELATIONSHIP_29_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBSHIPPING.RELATIONSHIP_29_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PUBTAX')
            and   name  = 'RELATIONSHIP_25_FK'
            and   indid > 0
            and   indid < 255)
   drop index PUBTAX.RELATIONSHIP_25_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FINANCYCICLE')
            and   type = 'U')
   drop table FINANCYCICLE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ITEMSPOSITION')
            and   type = 'U')
   drop table ITEMSPOSITION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBACCOUNT')
            and   type = 'U')
   drop table PUBACCOUNT
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
           where  id = object_id('PUBCAREER')
            and   type = 'U')
   drop table PUBCAREER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBCAREERDETAIL')
            and   type = 'U')
   drop table PUBCAREERDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBCONTACT')
            and   type = 'U')
   drop table PUBCONTACT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBCONTRACT')
            and   type = 'U')
   drop table PUBCONTRACT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBCONTRACTGROUP')
            and   type = 'U')
   drop table PUBCONTRACTGROUP
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
           where  id = object_id('PUBCURRENCYRATE')
            and   type = 'U')
   drop table PUBCURRENCYRATE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBDOCUMENT')
            and   type = 'U')
   drop table PUBDOCUMENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBDOCUMENTTYPE')
            and   type = 'U')
   drop table PUBDOCUMENTTYPE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBOBJECT')
            and   type = 'U')
   drop table PUBOBJECT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBOBJECTTYPE')
            and   type = 'U')
   drop table PUBOBJECTTYPE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBOBJGROUP')
            and   type = 'U')
   drop table PUBOBJGROUP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBOBJLEVEL')
            and   type = 'U')
   drop table PUBOBJLEVEL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBORGANIZATION')
            and   type = 'U')
   drop table PUBORGANIZATION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBORGOBJ')
            and   type = 'U')
   drop table PUBORGOBJ
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBORGTYPE')
            and   type = 'U')
   drop table PUBORGTYPE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBPAYMENTMETHOD')
            and   type = 'U')
   drop table PUBPAYMENTMETHOD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBPAYMENTTERM')
            and   type = 'U')
   drop table PUBPAYMENTTERM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBPAYMENTTERMDETAIL')
            and   type = 'U')
   drop table PUBPAYMENTTERMDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBPLACE')
            and   type = 'U')
   drop table PUBPLACE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBPOSITION')
            and   type = 'U')
   drop table PUBPOSITION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBPROJECT')
            and   type = 'U')
   drop table PUBPROJECT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBPROJECTGROUP')
            and   type = 'U')
   drop table PUBPROJECTGROUP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBPROVINCE')
            and   type = 'U')
   drop table PUBPROVINCE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBSHIPMETHOD')
            and   type = 'U')
   drop table PUBSHIPMETHOD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBSHIPPING')
            and   type = 'U')
   drop table PUBSHIPPING
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
           where  id = object_id('PUBWAREHOUSE')
            and   type = 'U')
   drop table PUBWAREHOUSE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBYEAR')
            and   type = 'U')
   drop table PUBYEAR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUB_PAYMENTTERMTYPE')
            and   type = 'U')
   drop table PUB_PAYMENTTERMTYPE
go

/*==============================================================*/
/* Table: FINANCYCICLE                                          */
/*==============================================================*/
create table FINANCYCICLE (
   FICI_AUTOID          smallint             not null,
   YEA_AUTOID           smallint             null,
   FICI_NAME            nchar(10)            null,
   FICI_DESCRIPTION     nvarchar(200)        null,
   FICI_DATEFROM        datetime             null,
   FICI_DATETO          datetime             null,
   FICI_ISACTIVE        bit                  null,
   constraint PK_FINANCYCICLE primary key nonclustered (FICI_AUTOID)
)
go

declare @CmtFINANCYCICLE varchar(128)
select @CmtFINANCYCICLE = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'kì tài chính',
   'user', @CmtFINANCYCICLE, 'table', 'FINANCYCICLE'
go

execute sp_addextendedproperty 'MS_Description', 
   'FiCi_AutoID',
   'user', '', 'table', 'FINANCYCICLE', 'column', 'FICI_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Yea_AutoID',
   'user', '', 'table', 'FINANCYCICLE', 'column', 'YEA_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Kì tài chính',
   'user', '', 'table', 'FINANCYCICLE', 'column', 'FICI_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'mô tả',
   'user', '', 'table', 'FINANCYCICLE', 'column', 'FICI_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'từ ngày',
   'user', '', 'table', 'FINANCYCICLE', 'column', 'FICI_DATEFROM'
go

execute sp_addextendedproperty 'MS_Description', 
   'tới ngày',
   'user', '', 'table', 'FINANCYCICLE', 'column', 'FICI_DATETO'
go

execute sp_addextendedproperty 'MS_Description', 
   'kich hoat',
   'user', '', 'table', 'FINANCYCICLE', 'column', 'FICI_ISACTIVE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_32_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_32_FK on FINANCYCICLE (
YEA_AUTOID ASC
)
go

/*==============================================================*/
/* Table: ITEMSPOSITION                                         */
/*==============================================================*/
create table ITEMSPOSITION (
   ITP_AUTOID           smallint             not null,
   WH_AUTOID            int                  null,
   ITP_NAME             nvarchar(100)        null,
   ITP_DESCRIPTION      nvarchar(200)        null,
   ITP_ISACTIVE         bit                  null,
   constraint PK_ITEMSPOSITION primary key nonclustered (ITP_AUTOID)
)
go

declare @CmtITEMSPOSITION varchar(128)
select @CmtITEMSPOSITION = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'vi tri hang hoa trong kho',
   'user', @CmtITEMSPOSITION, 'table', 'ITEMSPOSITION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Id tự tăng',
   'user', '', 'table', 'ITEMSPOSITION', 'column', 'ITP_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tự tăng',
   'user', '', 'table', 'ITEMSPOSITION', 'column', 'WH_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên ',
   'user', '', 'table', 'ITEMSPOSITION', 'column', 'ITP_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'mô tả',
   'user', '', 'table', 'ITEMSPOSITION', 'column', 'ITP_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'ITP_IsActive',
   'user', '', 'table', 'ITEMSPOSITION', 'column', 'ITP_ISACTIVE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_35_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_35_FK on ITEMSPOSITION (
WH_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBACCOUNT                                            */
/*==============================================================*/
create table PUBACCOUNT (
   ACC_AUTOID6          smallint             not null,
   constraint PK_PUBACCOUNT primary key nonclustered (ACC_AUTOID6)
)
go

declare @CmtPUBACCOUNT varchar(128)
select @CmtPUBACCOUNT = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Tài khoản hạch toán',
   'user', @CmtPUBACCOUNT, 'table', 'PUBACCOUNT'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBACCOUNT', 'column', 'ACC_AUTOID6'
go

/*==============================================================*/
/* Table: PUBBANK                                               */
/*==============================================================*/
create table PUBBANK (
   BAK_AUTOID3          smallint             not null,
   BAK_SUBNAME          nchar(100)           null,
   BAK_NAME             nvarchar(100)        null,
   BAK_ADDRESS          nvarchar(100)        null,
   BAK_PHONE            nchar(15)            null,
   BAK_FAX              nchar(15)            null,
   BAK_EMAIL            nchar(20)            null,
   BAK_WEBSITE          nchar(100)           null,
   BAK_CONTACTPERSON    nvarchar(200)        null,
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

execute sp_addextendedproperty 'MS_Description', 
   'BAK_SubName',
   'user', '', 'table', 'PUBBANK', 'column', 'BAK_SUBNAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'BAK_Name',
   'user', '', 'table', 'PUBBANK', 'column', 'BAK_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'BAK_Address',
   'user', '', 'table', 'PUBBANK', 'column', 'BAK_ADDRESS'
go

execute sp_addextendedproperty 'MS_Description', 
   'BAK_Phone',
   'user', '', 'table', 'PUBBANK', 'column', 'BAK_PHONE'
go

execute sp_addextendedproperty 'MS_Description', 
   'BAK_Fax',
   'user', '', 'table', 'PUBBANK', 'column', 'BAK_FAX'
go

execute sp_addextendedproperty 'MS_Description', 
   'BAK_Email',
   'user', '', 'table', 'PUBBANK', 'column', 'BAK_EMAIL'
go

execute sp_addextendedproperty 'MS_Description', 
   'BAK_Website',
   'user', '', 'table', 'PUBBANK', 'column', 'BAK_WEBSITE'
go

execute sp_addextendedproperty 'MS_Description', 
   'BAK_ContactPerson',
   'user', '', 'table', 'PUBBANK', 'column', 'BAK_CONTACTPERSON'
go

/*==============================================================*/
/* Table: PUBBANKDETAIL                                         */
/*==============================================================*/
create table PUBBANKDETAIL (
   ACD_AUTOID           smallint             not null,
   BAK_AUTOID3          smallint             null,
   ACD_CODE             nchar(10)            null,
   ACD_ENTRYACC         nchar(10)            null,
   ACD_DESCRIPTION      nvarchar(200)        null,
   ACD_BALANCE          decimal(18,3)        null,
   ACD_BANKID           smallint             null,
   ACD_ISACTIVE         bit                  null,
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

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBBANKDETAIL', 'column', 'BAK_AUTOID3'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã tài khoản',
   'user', '', 'table', 'PUBBANKDETAIL', 'column', 'ACD_CODE'
go

execute sp_addextendedproperty 'MS_Description', 
   'tài khoản hạch toán',
   'user', '', 'table', 'PUBBANKDETAIL', 'column', 'ACD_ENTRYACC'
go

execute sp_addextendedproperty 'MS_Description', 
   'mô tả',
   'user', '', 'table', 'PUBBANKDETAIL', 'column', 'ACD_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'số dư ',
   'user', '', 'table', 'PUBBANKDETAIL', 'column', 'ACD_BALANCE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã ngân hàng',
   'user', '', 'table', 'PUBBANKDETAIL', 'column', 'ACD_BANKID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ACD_IsActive',
   'user', '', 'table', 'PUBBANKDETAIL', 'column', 'ACD_ISACTIVE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_100_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_100_FK on PUBBANKDETAIL (
BAK_AUTOID3 ASC
)
go

/*==============================================================*/
/* Table: PUBCAREER                                             */
/*==============================================================*/
create table PUBCAREER (
   CAR_AUTOID           int                  not null,
   CAR_NAME             nvarchar(50)         null,
   CAR_DESCRIPTION      nvarchar(200)        null,
   CAR_ISACTIVE         bit                  null,
   constraint PK_PUBCAREER primary key nonclustered (CAR_AUTOID)
)
go

declare @CmtPUBCAREER varchar(128)
select @CmtPUBCAREER = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Ngành nghề',
   'user', @CmtPUBCAREER, 'table', 'PUBCAREER'
go

execute sp_addextendedproperty 'MS_Description', 
   'CAR_AutoID',
   'user', '', 'table', 'PUBCAREER', 'column', 'CAR_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'CAR_Name',
   'user', '', 'table', 'PUBCAREER', 'column', 'CAR_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'CAR_Description',
   'user', '', 'table', 'PUBCAREER', 'column', 'CAR_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'CAR_IsActive',
   'user', '', 'table', 'PUBCAREER', 'column', 'CAR_ISACTIVE'
go

/*==============================================================*/
/* Table: PUBCAREERDETAIL                                       */
/*==============================================================*/
create table PUBCAREERDETAIL (
   CAR_AUTOID           int                  not null,
   ORG_AUTOID           int                  not null,
   constraint PK_PUBCAREERDETAIL primary key nonclustered (CAR_AUTOID, ORG_AUTOID)
)
go

declare @CmtPUBCAREERDETAIL varchar(128)
select @CmtPUBCAREERDETAIL = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Ngành nghề hoạt động',
   'user', @CmtPUBCAREERDETAIL, 'table', 'PUBCAREERDETAIL'
go

execute sp_addextendedproperty 'MS_Description', 
   'CAR_AutoID',
   'user', '', 'table', 'PUBCAREERDETAIL', 'column', 'CAR_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tổ chức - Mã Công ty - Mã Chi Nhánh - Mã Phòng ban',
   'user', '', 'table', 'PUBCAREERDETAIL', 'column', 'ORG_AUTOID'
go

/*==============================================================*/
/* Index: PUBCAREERDETAIL_FK                                    */
/*==============================================================*/
create index PUBCAREERDETAIL_FK on PUBCAREERDETAIL (
CAR_AUTOID ASC
)
go

/*==============================================================*/
/* Index: PUBCAREERDETAIL2_FK                                   */
/*==============================================================*/
create index PUBCAREERDETAIL2_FK on PUBCAREERDETAIL (
ORG_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBCONTACT                                            */
/*==============================================================*/
create table PUBCONTACT (
   CON_AUTOID           int                  not null,
   OBJ_AUTOID           int                  null,
   CON_PHONENUMBER1     nvarchar(20)         null,
   CON_PHONENUMBER2     nvarchar(20)         null,
   CON_ADDRESS1         nvarchar(100)        null,
   CON_ADDRESS2         nvarchar(100)        null,
   CON_EMAIL            nvarchar(100)        null,
   CON_DEPARTMENT       nvarchar(20)         null,
   CON_ISACTIVE         bit                  null,
   CON_NAME             nvarchar(150)        null,
   CON_DESCRIPTION      nvarchar(200)        null,
   constraint PK_PUBCONTACT primary key nonclustered (CON_AUTOID)
)
go

declare @CmtPUBCONTACT varchar(128)
select @CmtPUBCONTACT = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Thông tin liên lạc',
   'user', @CmtPUBCONTACT, 'table', 'PUBCONTACT'
go

execute sp_addextendedproperty 'MS_Description', 
   'CON_AutoID',
   'user', '', 'table', 'PUBCONTACT', 'column', 'CON_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã đối tượng tự động tăng',
   'user', '', 'table', 'PUBCONTACT', 'column', 'OBJ_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'CON_PhoneNumber1',
   'user', '', 'table', 'PUBCONTACT', 'column', 'CON_PHONENUMBER1'
go

execute sp_addextendedproperty 'MS_Description', 
   'CON_PhoneNumber2',
   'user', '', 'table', 'PUBCONTACT', 'column', 'CON_PHONENUMBER2'
go

execute sp_addextendedproperty 'MS_Description', 
   'CON_Address1',
   'user', '', 'table', 'PUBCONTACT', 'column', 'CON_ADDRESS1'
go

execute sp_addextendedproperty 'MS_Description', 
   'CON_Address2',
   'user', '', 'table', 'PUBCONTACT', 'column', 'CON_ADDRESS2'
go

execute sp_addextendedproperty 'MS_Description', 
   'CON_Email',
   'user', '', 'table', 'PUBCONTACT', 'column', 'CON_EMAIL'
go

execute sp_addextendedproperty 'MS_Description', 
   'CON_Department',
   'user', '', 'table', 'PUBCONTACT', 'column', 'CON_DEPARTMENT'
go

execute sp_addextendedproperty 'MS_Description', 
   'CON_IsActive',
   'user', '', 'table', 'PUBCONTACT', 'column', 'CON_ISACTIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   'CON_Name',
   'user', '', 'table', 'PUBCONTACT', 'column', 'CON_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'CON_Description',
   'user', '', 'table', 'PUBCONTACT', 'column', 'CON_DESCRIPTION'
go

/*==============================================================*/
/* Index: THONG_TIN_LIEN_LAC_CUA_DOI_TUONG_FK                   */
/*==============================================================*/
create index THONG_TIN_LIEN_LAC_CUA_DOI_TUONG_FK on PUBCONTACT (
OBJ_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBCONTRACT                                           */
/*==============================================================*/
drop table PUBCONTRACT
create table PUBCONTRACT (
   COT_AUTOID           bigint               not null,
   CUR_AUTOID          smallint             null,
   CTG_AUTOID           smallint             null,
   ORG_AUTOID           int                  null,
   CON_AUTOID           int                  null,
   PRJ_AUTOID           smallint             null,
   COT_CONTRACTNO       nchar(10)            null,
   COT_CONTRACTTYPE     smallint             null,
   COT_DESCRIPTION      nvarchar(100)        null,
   COT_ASIGNDATE        datetime             null,
   COT_VALIDDATE        datetime             null,
   COT_EXPIREDATE       datetime             null,
   COT_CURRENCYRATE     decimal(18,3)        null,
   COT_BASICMONEY       decimal(18,3)        null,
   COT_EXCHANGEMONEY    decimal(18,3)        null,
   COT_STATUS           smallint             null,
   COT_COTTINGID        smallint             null,
   COT_OWNEROBJECTID    smallint             null,
   COT_OWNERACOUNTBANK  nchar(10)            null,
   COT_PARTNEROBJECTID  smallint             null,
   COT_PARTNERACOUNTBANK nchar(10)            null,
   COT_CONTENT          nvarchar(2000)       null,
   COT_FILEURL          nchar(100)           null,
   COT_ISACTIVE         bit                  null,
   constraint PK_PUBCONTRACT primary key nonclustered (COT_AUTOID)
)
go

declare @CmtPUBCONTRACT varchar(128)
select @CmtPUBCONTRACT = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'hợp đồng Nhớ khi tạo thì mang ID của bảng Document dem qua làm khóa của bảng này ',
   'user', @CmtPUBCONTRACT, 'table', 'PUBCONTRACT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã Id tự động tăng',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'CUR_AUTOID3'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ctg_AutoID',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'CTG_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tổ chức - Mã Công ty - Mã Chi Nhánh - Mã Phòng ban',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'ORG_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'CON_AutoID',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'CON_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'PRJ_AutoID',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'PRJ_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã số hợp đồng',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_CONTRACTNO'
go

execute sp_addextendedproperty 'MS_Description', 
   'loại Hợp đồng
   1: mua
   2: bán
   3: khác',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_CONTRACTTYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Trích yếu - diễn giải',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày ký kết',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_ASIGNDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày hiệu lực',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_VALIDDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày hết hạn',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_EXPIREDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'tỷ giá',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_CURRENCYRATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'tiền nguyên tệ',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_BASICMONEY'
go

execute sp_addextendedproperty 'MS_Description', 
   'tiền quy đổi
   ',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_EXCHANGEMONEY'
go

execute sp_addextendedproperty 'MS_Description', 
   'trạng thái ơộp đồng
   1 mới 
   2 Đang thực hiện
   3 đã xong chua thanh ly
   4 đã thanh lý
   5 huy bỏ',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_STATUS'
go

execute sp_addextendedproperty 'MS_Description', 
   'Đối tượng giá thành',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_COTTINGID'
go

execute sp_addextendedproperty 'MS_Description', 
   'chu hợp đồng là chính công ty 
   
   ID liên Kết với bảng  Object với loại là nhân viên của công ty cho biet nguoi Đai diện Cho công ty đứng ra ky hợp đồng ',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_OWNEROBJECTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'tài khoản giao dịch ngân hàng của chủ hợp đồng',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_OWNERACOUNTBANK'
go

execute sp_addextendedproperty 'MS_Description', 
   'đại diện cho đối tác 
   liện kết bảng object với loại là khách hàng nhà cung cấp
   ',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_PARTNEROBJECTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'tài khoản giao dịch ngân hàng của đối tác',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_PARTNERACOUNTBANK'
go

execute sp_addextendedproperty 'MS_Description', 
   'Nội dung hợp đồng',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_CONTENT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Cho biet cái file hợp đồng chưa',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_FILEURL'
go

execute sp_addextendedproperty 'MS_Description', 
   'COT_IsActive',
   'user', '', 'table', 'PUBCONTRACT', 'column', 'COT_ISACTIVE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_108_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_108_FK on PUBCONTRACT (
CTG_AUTOID ASC
)
go

/*==============================================================*/
/* Index: LOAI_TIEN_FK                                          */
/*==============================================================*/
create index LOAI_TIEN_FK on PUBCONTRACT (
CUR_AUTOID3 ASC
)
go

/*==============================================================*/
/* Index: DU_AN_FK                                              */
/*==============================================================*/
create index DU_AN_FK on PUBCONTRACT (
PRJ_AUTOID ASC
)
go

/*==============================================================*/
/* Index: HOP_DONG_CUA_CONG_TY_FK                               */
/*==============================================================*/
create index HOP_DONG_CUA_CONG_TY_FK on PUBCONTRACT (
ORG_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_33_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_33_FK on PUBCONTRACT (
CON_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBCONTRACTGROUP                                      */
/*==============================================================*/
drop table PUBCONTRACTGROUP
create table PUBCONTRACTGROUP (
   CTG_AUTOID           smallint             not null,
   CTG_NAME             nvarchar(150)        null,
   CTG_DESCRIPTION      nvarchar(200)        null,
   CTG_ISACTIVE         bit                  null,
   constraint PK_PUBCONTRACTGROUP primary key nonclustered (CTG_AUTOID)
)
go

declare @CmtPUBCONTRACTGROUP varchar(128)
select @CmtPUBCONTRACTGROUP = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nhóm hợp đồng',
   'user', @CmtPUBCONTRACTGROUP, 'table', 'PUBCONTRACTGROUP'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ctg_AutoID',
   'user', '', 'table', 'PUBCONTRACTGROUP', 'column', 'CTG_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ctg_Name',
   'user', '', 'table', 'PUBCONTRACTGROUP', 'column', 'CTG_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ctg_Description',
   'user', '', 'table', 'PUBCONTRACTGROUP', 'column', 'CTG_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ctg_IsActive',
   'user', '', 'table', 'PUBCONTRACTGROUP', 'column', 'CTG_ISACTIVE'
go

/*==============================================================*/
/* Table: PUBCOUNTRY                                            */
/*==============================================================*/
create table PUBCOUNTRY (
   CON_AUTOID2          int                  not null,
   TRY_NAME             nvarchar(100)        null,
   TRY_CONTINENT        char(500)            null,
   TRY_DESCRIPTION      nvarchar(200)        null,
   TRY_ACTIVE           bit                  null,
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
   'TRY_AutoID',
   'user', '', 'table', 'PUBCOUNTRY', 'column', 'CON_AUTOID2'
go

execute sp_addextendedproperty 'MS_Description', 
   'TRY_Name',
   'user', '', 'table', 'PUBCOUNTRY', 'column', 'TRY_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'TRY_Continent',
   'user', '', 'table', 'PUBCOUNTRY', 'column', 'TRY_CONTINENT'
go

execute sp_addextendedproperty 'MS_Description', 
   'TRY_Description',
   'user', '', 'table', 'PUBCOUNTRY', 'column', 'TRY_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'kích hoạt',
   'user', '', 'table', 'PUBCOUNTRY', 'column', 'TRY_ACTIVE'
go

/*==============================================================*/
/* Table: PUBCURRENCY                                           */
/*==============================================================*/
create table PUBCURRENCY (
   CUR_AUTOID3          smallint             not null,
   CUR_NAME             nvarchar(150)        null,
   CUR_DESCRIPTION      nvarchar(200)        null,
   CUR_ACTIVE           bit                  null,
   CUR_CREATEDATE       datetime             null,
   CUR_SIGNS            nchar(100)           null,
   CUR_TOTALRETAIL      smallint             null,
   CUR_SEPARATETH       smallint             null,
   CUR_SEPARATEDECIMALS smallint             null,
   CUR_NEGATIVENO       smallint             null,
   constraint PK_PUBCURRENCY primary key nonclustered (CUR_AUTOID3)
)
go

declare @CmtPUBCURRENCY varchar(128)
select @CmtPUBCURRENCY = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Bảng  danh mục tiển tệ',
   'user', @CmtPUBCURRENCY, 'table', 'PUBCURRENCY'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBCURRENCY', 'column', 'CUR_AUTOID3'
go

execute sp_addextendedproperty 'MS_Description', 
   'CUR_Name',
   'user', '', 'table', 'PUBCURRENCY', 'column', 'CUR_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'CUR_Description',
   'user', '', 'table', 'PUBCURRENCY', 'column', 'CUR_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'CUR_Active',
   'user', '', 'table', 'PUBCURRENCY', 'column', 'CUR_ACTIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   'CUR_CreateDate',
   'user', '', 'table', 'PUBCURRENCY', 'column', 'CUR_CREATEDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ký hiệu',
   'user', '', 'table', 'PUBCURRENCY', 'column', 'CUR_SIGNS'
go

execute sp_addextendedproperty 'MS_Description', 
   'Số lẻ',
   'user', '', 'table', 'PUBCURRENCY', 'column', 'CUR_TOTALRETAIL'
go

execute sp_addextendedproperty 'MS_Description', 
   'Phân cách phần nghìn',
   'user', '', 'table', 'PUBCURRENCY', 'column', 'CUR_SEPARATETH'
go

execute sp_addextendedproperty 'MS_Description', 
   'Phân cách thập phân',
   'user', '', 'table', 'PUBCURRENCY', 'column', 'CUR_SEPARATEDECIMALS'
go

execute sp_addextendedproperty 'MS_Description', 
   'Thể hiện số âm',
   'user', '', 'table', 'PUBCURRENCY', 'column', 'CUR_NEGATIVENO'
go

/*==============================================================*/
/* Table: PUBCURRENCYRATE                                       */
/*==============================================================*/
create table PUBCURRENCYRATE (
   CRR_AUTOID           smallint             not null,
   CUR_AUTOID3          smallint             null,
   CRR_DESCRIPTION      nvarchar(200)        null,
   CRR_RATE             decimal(18,3)        null,
   CRR_DATE             datetime             null,
   CRR_ENTRYCURRENCYID  smallint             null,
   CRR_ACTIVEDATE       datetime             null,
   constraint PK_PUBCURRENCYRATE primary key nonclustered (CRR_AUTOID)
)
go

declare @CmtPUBCURRENCYRATE varchar(128)
select @CmtPUBCURRENCYRATE = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Danh mục tỷ giá',
   'user', @CmtPUBCURRENCYRATE, 'table', 'PUBCURRENCYRATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'CRR_AutoID',
   'user', '', 'table', 'PUBCURRENCYRATE', 'column', 'CRR_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBCURRENCYRATE', 'column', 'CUR_AUTOID3'
go

execute sp_addextendedproperty 'MS_Description', 
   'CRR_Description',
   'user', '', 'table', 'PUBCURRENCYRATE', 'column', 'CRR_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'CRR_Rate',
   'user', '', 'table', 'PUBCURRENCYRATE', 'column', 'CRR_RATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'CRR_Date',
   'user', '', 'table', 'PUBCURRENCYRATE', 'column', 'CRR_DATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tiền hoạch toán',
   'user', '', 'table', 'PUBCURRENCYRATE', 'column', 'CRR_ENTRYCURRENCYID'
go

execute sp_addextendedproperty 'MS_Description', 
   'CRR_ActiveDate',
   'user', '', 'table', 'PUBCURRENCYRATE', 'column', 'CRR_ACTIVEDATE'
go

/*==============================================================*/
/* Index: TY_GIA_FK                                             */
/*==============================================================*/
create index TY_GIA_FK on PUBCURRENCYRATE (
CUR_AUTOID3 ASC
)
go

/*==============================================================*/
/* Table: PUBDOCUMENT                                           */
/*==============================================================*/
create table PUBDOCUMENT (
   DOC_DOCUMENTID       bigint               not null,
   ORG_AUTOID           int                  null,
   DOTY_SYSTEMID        smallint             null,
   DOC_DOCUMENTNO       nchar(10)            null,
   DOC_DESCRIPTION      nvarchar(200)        null,
   DOC_CREATEBY         smallint             null,
   DOC_CRATEDATE        datetime             null,
   DOC_DOCUMENTDATE     datetime             null,
   DOC_POSTTINGDATE     datetime             null,
   DOC_APPROVEBY        smallint             null,
   DOC_APPROVEDATE      datetime             null,
   DOC_DELETEBY         smallint             null,
   DOC_DELETEDATE       datetime             null,
   DOC_LEVEL            smallint             null,
   DOC_PATH             nchar(100)           null,
   DOC_ISACTIVE         bit                  null,
   DOC_LASTUPDATE       datetime             null,
   DOC_UPDATE_BY        smallint             null,
   DOC_OFSYSTEM         smallint             null,
   DOC_OFSUBSYSTEM      smallint             null,
   constraint PK_PUBDOCUMENT primary key nonclustered (DOC_DOCUMENTID)
)
go

declare @CmtPUBDOCUMENT varchar(128)
select @CmtPUBDOCUMENT = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'tai liệu Quản lý work flows',
   'user', @CmtPUBDOCUMENT, 'table', 'PUBDOCUMENT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Doc_DocumentID',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_DOCUMENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tổ chức - Mã Công ty - Mã Chi Nhánh - Mã Phòng ban',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'ORG_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã mình thêm vào',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOTY_SYSTEMID'
go

execute sp_addextendedproperty 'MS_Description', 
   'MÃ chứng từ tự quãn lý',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_DOCUMENTNO'
go

execute sp_addextendedproperty 'MS_Description', 
   'Doc_Description',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'UserID người tạo ra document này',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_CREATEBY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Date ngày tạo ra cái document này',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_CRATEDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngay chứng từ',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_DOCUMENTDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngay ghi sổ',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_POSTTINGDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'UserID cho biet người phê duyệt cho cái document này',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_APPROVEBY'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày duyệt ',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_APPROVEDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'UserID người xóa tài liệu này ',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_DELETEBY'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày bị xóa',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_DELETEDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Cho biết nó cấp độ bao nhiêu, ở nhánh thứ mấy của cây',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_LEVEL'
go

execute sp_addextendedproperty 'MS_Description', 
   'Cho biet dường dẫn để tìm kiêm',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_PATH'
go

execute sp_addextendedproperty 'MS_Description', 
   'Được kích hoạt hay không',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_ISACTIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngay cập nhật cuối cùng',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_LASTUPDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'cập nhật bởi ai',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_UPDATE_BY'
go

execute sp_addextendedproperty 'MS_Description', 
   'thuộc phân hệ nào
   SO,PO,IA,AM, AR,AP,CM GL',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_OFSYSTEM'
go

execute sp_addextendedproperty 'MS_Description', 
   'Phân hệ con danh cho hóa đơn và tờ khai ..
   1 hóa đơn 
   2 tờ khai ',
   'user', '', 'table', 'PUBDOCUMENT', 'column', 'DOC_OFSUBSYSTEM'
go

/*==============================================================*/
/* Index: RELATIONSHIP_28_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_28_FK on PUBDOCUMENT (
DOTY_SYSTEMID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_30_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_30_FK on PUBDOCUMENT (
ORG_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBDOCUMENTTYPE                                       */
/*==============================================================*/
create table PUBDOCUMENTTYPE (
   DOTY_SYSTEMID        smallint             not null,
   DOTY_NAME            nvarchar(200)        null,
   DOTY_SUFFIX          nchar(10)            null,
   DOTY_ISACTIVE        bit                  null,
   DOTY_PARENTID        smallint             null,
   DOTY_LEVEL           smallint             null,
   constraint PK_PUBDOCUMENTTYPE primary key nonclustered (DOTY_SYSTEMID)
)
go

declare @CmtPUBDOCUMENTTYPE varchar(128)
select @CmtPUBDOCUMENTTYPE = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Phân hệ hay nguồn nghiệp vụ 
   
   Loại Document :
   1 PR,
   2 PO,
   3 SO
   4 AR,
   5 AP,
   6 CM,
   7 IC,
   8 GL',
   'user', @CmtPUBDOCUMENTTYPE, 'table', 'PUBDOCUMENTTYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã mình thêm vào',
   'user', '', 'table', 'PUBDOCUMENTTYPE', 'column', 'DOTY_SYSTEMID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên ',
   'user', '', 'table', 'PUBDOCUMENTTYPE', 'column', 'DOTY_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã nhận diện',
   'user', '', 'table', 'PUBDOCUMENTTYPE', 'column', 'DOTY_SUFFIX'
go

execute sp_addextendedproperty 'MS_Description', 
   'kich hoat',
   'user', '', 'table', 'PUBDOCUMENTTYPE', 'column', 'DOTY_ISACTIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Cha của nó là ai',
   'user', '', 'table', 'PUBDOCUMENTTYPE', 'column', 'DOTY_PARENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'cấp độ ',
   'user', '', 'table', 'PUBDOCUMENTTYPE', 'column', 'DOTY_LEVEL'
go

/*==============================================================*/
/* Table: PUBOBJECT                                             */
/*==============================================================*/
create table PUBOBJECT (
   OBJ_AUTOID           int                  not null,
   PRV_AUTOID           smallint             null,
   ACD_AUTOID           smallint             null,
   POBJ_AUTOID          smallint             null,
   PAY_AUTOID3          int                  null,
   ACC_AUTOID6          smallint             null,
   POG_AUTOID           int                  null,
   OBJ_NAME             nvarchar(100)        null,
   OBJ_ADDRESS1         nvarchar(200)        null,
   OBJ_ADDRESS2         nvarchar(200)        null,
   OBJ_BIRTHDAY         datetime             null,
   OBJ_PHONENUMBER1     nvarchar(20)         null,
   OBJ_PHONENUMBER2     nvarchar(20)         null,
   OBJ_SERIALTAX        nvarchar(20)         null,
   OBJ_SPECIFICATION    nvarchar(20)         null,
   OBJ_VATNO            nvarchar(20)         null,
   OBJ_WEBPAGE          nvarchar(100)        null,
   OBJ_EMAIL            nvarchar(100)        null,
   OBJ_PARENTID         int                  null,
   OBJ_HEIGH            decimal(10,2)        null,
   OBJ_WEIGH            decimal(10,2)        null,
   OBJ_DESCRIPTION      nvarchar(200)        null,
   OBJ_GENDER           bit                  null,
   OBJ_IDENTIFYID       nvarchar(20)         null,
   OBJ_ISACTIVE         bit                  null,
   constraint PK_PUBOBJECT primary key nonclustered (OBJ_AUTOID)
)
go

declare @CmtPUBOBJECT varchar(128)
select @CmtPUBOBJECT = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'là một đối tượng Tượng chưng cho nhà cung cấp, khách hàng,Nhân viên,...',
   'user', @CmtPUBOBJECT, 'table', 'PUBOBJECT'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã đối tượng tự động tăng',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự động tăng',
   'user', '', 'table', 'PUBOBJECT', 'column', 'PRV_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Id tự động tăng',
   'user', '', 'table', 'PUBOBJECT', 'column', 'ACD_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tự động tăng',
   'user', '', 'table', 'PUBOBJECT', 'column', 'POBJ_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBOBJECT', 'column', 'PAY_AUTOID3'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBOBJECT', 'column', 'ACC_AUTOID6'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tự động tăng',
   'user', '', 'table', 'PUBOBJECT', 'column', 'POG_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên đối tượng',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Địa chỉ ',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_ADDRESS1'
go

execute sp_addextendedproperty 'MS_Description', 
   'Obj_Address2',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_ADDRESS2'
go

execute sp_addextendedproperty 'MS_Description', 
   'Obj_Birthday',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_BIRTHDAY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Số điện thoại ',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_PHONENUMBER1'
go

execute sp_addextendedproperty 'MS_Description', 
   'Obj_PhoneNumber2',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_PHONENUMBER2'
go

execute sp_addextendedproperty 'MS_Description', 
   'Obj_SerialTax',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_SERIALTAX'
go

execute sp_addextendedproperty 'MS_Description', 
   'Obj_Specification',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_SPECIFICATION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Obj_VATNo',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_VATNO'
go

execute sp_addextendedproperty 'MS_Description', 
   'Obj_WebPage',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_WEBPAGE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Obj_Email',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_EMAIL'
go

execute sp_addextendedproperty 'MS_Description', 
   'Obj_ParentID',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_PARENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Obj_Heigh',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_HEIGH'
go

execute sp_addextendedproperty 'MS_Description', 
   'Obj_Weigh',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_WEIGH'
go

execute sp_addextendedproperty 'MS_Description', 
   'Obj_Description',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Giới tinh',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_GENDER'
go

execute sp_addextendedproperty 'MS_Description', 
   'Chứng minh nhân dân',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_IDENTIFYID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Được kích hoạt 
   True : được kích hoạt
   false : không kích hoạt',
   'user', '', 'table', 'PUBOBJECT', 'column', 'OBJ_ISACTIVE'
go

/*==============================================================*/
/* Index: BANK_ACCOUNT_FK                                       */
/*==============================================================*/
create index BANK_ACCOUNT_FK on PUBOBJECT (
ACD_AUTOID ASC
)
go

/*==============================================================*/
/* Index: ACCOUNT_OF_OBJECT_FK                                  */
/*==============================================================*/
create index ACCOUNT_OF_OBJECT_FK on PUBOBJECT (
ACC_AUTOID6 ASC
)
go

/*==============================================================*/
/* Index: LEVEL_FK                                              */
/*==============================================================*/
create index LEVEL_FK on PUBOBJECT (
POBJ_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_80_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_80_FK on PUBOBJECT (
POG_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_82_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_82_FK on PUBOBJECT (
PAY_AUTOID3 ASC
)
go

/*==============================================================*/
/* Index: DIA_CHI_CUA_DOI_TUONG_FK                              */
/*==============================================================*/
create index DIA_CHI_CUA_DOI_TUONG_FK on PUBOBJECT (
PRV_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBOBJECTTYPE                                         */
/*==============================================================*/
create table PUBOBJECTTYPE (
   OBJT_AUTOID          smallint             not null,
   OBJT_NAME            nvarchar(100)        null,
   OBJT_DESCRIPTION     nvarchar(200)        null,
   OBJT_ISACTIVE        bit                  null,
   constraint PK_PUBOBJECTTYPE primary key nonclustered (OBJT_AUTOID)
)
go

declare @CmtPUBOBJECTTYPE varchar(128)
select @CmtPUBOBJECTTYPE = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'PubObjectType',
   'user', @CmtPUBOBJECTTYPE, 'table', 'PUBOBJECTTYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'ObjT_AutoID',
   'user', '', 'table', 'PUBOBJECTTYPE', 'column', 'OBJT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ObjT_Name',
   'user', '', 'table', 'PUBOBJECTTYPE', 'column', 'OBJT_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'ObjT_Description',
   'user', '', 'table', 'PUBOBJECTTYPE', 'column', 'OBJT_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'ObjT_IsActive',
   'user', '', 'table', 'PUBOBJECTTYPE', 'column', 'OBJT_ISACTIVE'
go

/*==============================================================*/
/* Table: PUBOBJGROUP                                           */
/*==============================================================*/
create table PUBOBJGROUP (
   POG_AUTOID           int                  not null,
   POG_NAME             nvarchar(100)        null,
   POG_DESCRIPTION      nvarchar(200)        null,
   POG_ISACTIVE         bit                  null,
   constraint PK_PUBOBJGROUP primary key nonclustered (POG_AUTOID)
)
go

declare @CmtPUBOBJGROUP varchar(128)
select @CmtPUBOBJGROUP = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nhóm đối tượng',
   'user', @CmtPUBOBJGROUP, 'table', 'PUBOBJGROUP'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tự động tăng',
   'user', '', 'table', 'PUBOBJGROUP', 'column', 'POG_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên nhóm',
   'user', '', 'table', 'PUBOBJGROUP', 'column', 'POG_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mô tả nhóm',
   'user', '', 'table', 'PUBOBJGROUP', 'column', 'POG_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Được kích hoạt',
   'user', '', 'table', 'PUBOBJGROUP', 'column', 'POG_ISACTIVE'
go

/*==============================================================*/
/* Table: PUBOBJLEVEL                                           */
/*==============================================================*/
create table PUBOBJLEVEL (
   POBJ_AUTOID          smallint             not null,
   POBJ_NAME            nvarchar(50)         null,
   POBJ_DESCRIPTION     nvarchar(200)        null,
   POBJ_ISACTIVE        bit                  null,
   constraint PK_PUBOBJLEVEL primary key nonclustered (POBJ_AUTOID)
)
go

declare @CmtPUBOBJLEVEL varchar(128)
select @CmtPUBOBJLEVEL = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Loại đối tượng',
   'user', @CmtPUBOBJLEVEL, 'table', 'PUBOBJLEVEL'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tự động tăng',
   'user', '', 'table', 'PUBOBJLEVEL', 'column', 'POBJ_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'tên',
   'user', '', 'table', 'PUBOBJLEVEL', 'column', 'POBJ_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mô tả',
   'user', '', 'table', 'PUBOBJLEVEL', 'column', 'POBJ_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Được kích hoạt',
   'user', '', 'table', 'PUBOBJLEVEL', 'column', 'POBJ_ISACTIVE'
go

/*==============================================================*/
/* Table: PUBORGANIZATION                                       */
/*==============================================================*/
create table PUBORGANIZATION (
   ORG_AUTOID           int                  not null,
   OTP_AUTOID           int                  null,
   CUR_AUTOID3          smallint             null,
   PRV_AUTOID           smallint             null,
   ORG_NAME             nvarchar(200)        null,
   ORG_BUSSINESSNAME    nvarchar(200)        null,
   ORG_DESCRIPTION      nvarchar(200)        null,
   ORG_ISACTIVE         bit                  null,
   ORG_PARENTID         int                  null,
   ORG_LEVEL            smallint             null,
   ORG_PATH             nvarchar(100)        null,
   ORG_ADDRESS          nvarchar(200)        null,
   ORG_ADDRESS2         nvarchar(200)        null,
   ORG_FOUNDATIONDATE   datetime             null,
   ORG_PHONENUMBER      nvarchar(20)         null,
   ORG_FAX              nvarchar(20)         null,
   ORG_EMAIL            nvarchar(100)        null,
   ORG_TAXID            nvarchar(20)         null,
   ORG_WEBSITE          nvarchar(100)        null,
   ORG_REPRESENTATIVEPERSON nvarchar(100)        null,
   constraint PK_PUBORGANIZATION primary key nonclustered (ORG_AUTOID)
)
go

declare @CmtPUBORGANIZATION varchar(128)
select @CmtPUBORGANIZATION = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Tổ chức - Công ty - Chi nhánh - Phòng ban',
   'user', @CmtPUBORGANIZATION, 'table', 'PUBORGANIZATION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tổ chức - Mã Công ty - Mã Chi Nhánh - Mã Phòng ban',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã loại hình',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'OTP_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'CUR_AUTOID3'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự động tăng',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'PRV_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên Tổ chức - tên công ty - Tên chi nhánh - tên phòng ban',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Org_BussinessName',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_BUSSINESSNAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Diễn giải',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Trạng thái tồn tại của tổ chức - công ty - chi nhánh - phòng ban
   True: còn hoạt động
   False: không hoạt động',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_ISACTIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Cấp độ cao hơn của 1 tổ chức - công ty - chi nhánh - phòng ban
   vd: organization có thể có tổ chức cao hơn quản lý nó, hoặc chính nó qản lý nó, hoặc không ai quản lý nó (tổ chức đó là cao nhất), tương ứng cho công ty - chi nhánh - phòng ban',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_PARENTID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Org_Level',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_LEVEL'
go

execute sp_addextendedproperty 'MS_Description', 
   'Org_Path',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_PATH'
go

execute sp_addextendedproperty 'MS_Description', 
   'Địa chỉ',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_ADDRESS'
go

execute sp_addextendedproperty 'MS_Description', 
   'Org_Address2',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_ADDRESS2'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày thành lập',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_FOUNDATIONDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Org_PhoneNumber',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_PHONENUMBER'
go

execute sp_addextendedproperty 'MS_Description', 
   'Org_Fax',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_FAX'
go

execute sp_addextendedproperty 'MS_Description', 
   'Org_Email',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_EMAIL'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã số thuế mặc dịnh',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_TAXID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Org_Website',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_WEBSITE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Org_RepresentativePerson',
   'user', '', 'table', 'PUBORGANIZATION', 'column', 'ORG_REPRESENTATIVEPERSON'
go

/*==============================================================*/
/* Index: RELATIONSHIP_97_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_97_FK on PUBORGANIZATION (
PRV_AUTOID ASC
)
go

/*==============================================================*/
/* Index: LOAI_HINH_HOAT_DONG_FK                                */
/*==============================================================*/
create index LOAI_HINH_HOAT_DONG_FK on PUBORGANIZATION (
OTP_AUTOID ASC
)
go

/*==============================================================*/
/* Index: LOAI_TIEN_AP_DUNG_FK                                  */
/*==============================================================*/
create index LOAI_TIEN_AP_DUNG_FK on PUBORGANIZATION (
CUR_AUTOID3 ASC
)
go

/*==============================================================*/
/* Table: PUBORGOBJ                                             */
/*==============================================================*/
create table PUBORGOBJ (
   OBJ_AUTOID           int                  not null,
   ORG_AUTOID           int                  not null,
   POS_AUTOID           int                  not null,
   OBJT_AUTOID          smallint             not null,
   ORGO_TYPE            smallint             null,
   constraint PK_PUBORGOBJ primary key nonclustered (OBJ_AUTOID, ORG_AUTOID, POS_AUTOID, OBJT_AUTOID)
)
go

declare @CmtPUBORGOBJ varchar(128)
select @CmtPUBORGOBJ = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nhân viên, chức vụ trong tổ chức',
   'user', @CmtPUBORGOBJ, 'table', 'PUBORGOBJ'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã đối tượng tự động tăng',
   'user', '', 'table', 'PUBORGOBJ', 'column', 'OBJ_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tổ chức - Mã Công ty - Mã Chi Nhánh - Mã Phòng ban',
   'user', '', 'table', 'PUBORGOBJ', 'column', 'ORG_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'POS_AutoID',
   'user', '', 'table', 'PUBORGOBJ', 'column', 'POS_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ObjT_AutoID',
   'user', '', 'table', 'PUBORGOBJ', 'column', 'OBJT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại Khách hàng 
   1 khách hàng
   2 nhân viên 
   3 nhà cung cấp
   4 nhà vận chuyển
   5 ',
   'user', '', 'table', 'PUBORGOBJ', 'column', 'ORGO_TYPE'
go

/*==============================================================*/
/* Index: PUBORGOBJ_FK                                          */
/*==============================================================*/
create index PUBORGOBJ_FK on PUBORGOBJ (
OBJ_AUTOID ASC
)
go

/*==============================================================*/
/* Index: PUBORGOBJ2_FK                                         */
/*==============================================================*/
create index PUBORGOBJ2_FK on PUBORGOBJ (
ORG_AUTOID ASC
)
go

/*==============================================================*/
/* Index: PUBORGOBJ3_FK                                         */
/*==============================================================*/
create index PUBORGOBJ3_FK on PUBORGOBJ (
POS_AUTOID ASC
)
go

/*==============================================================*/
/* Index: PUBORGOBJ4_FK                                         */
/*==============================================================*/
create index PUBORGOBJ4_FK on PUBORGOBJ (
OBJT_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBORGTYPE                                            */
/*==============================================================*/
create table PUBORGTYPE (
   OTP_AUTOID           int                  not null,
   OTP_NAME             nvarchar(100)        null,
   OTP_DESCRIPTION      nvarchar(100)        null,
   OTP_ISACTIVE         bit                  null,
   constraint PK_PUBORGTYPE primary key nonclustered (OTP_AUTOID)
)
go

declare @CmtPUBORGTYPE varchar(128)
select @CmtPUBORGTYPE = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Loại hình tổ chức - công ty - chi nhánh - phòng ban',
   'user', @CmtPUBORGTYPE, 'table', 'PUBORGTYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã loại hình',
   'user', '', 'table', 'PUBORGTYPE', 'column', 'OTP_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'tên loại hình',
   'user', '', 'table', 'PUBORGTYPE', 'column', 'OTP_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'diễn giải',
   'user', '', 'table', 'PUBORGTYPE', 'column', 'OTP_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'trạng thái hoạt động
   True: hoạt động
   False: không hoạt động',
   'user', '', 'table', 'PUBORGTYPE', 'column', 'OTP_ISACTIVE'
go

/*==============================================================*/
/* Table: PUBPAYMENTMETHOD                                      */
/*==============================================================*/
create table PUBPAYMENTMETHOD (
   PAY_AUTOID3          int                  not null,
   PAM_NAME             nvarchar(100)        null,
   PAM_DESCRIPTION      nvarchar(200)        null,
   PAM_EFFECTIVEDATE    datetime             null,
   PAM_ACTIVE           bit                  null,
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

execute sp_addextendedproperty 'MS_Description', 
   'PAM_Name',
   'user', '', 'table', 'PUBPAYMENTMETHOD', 'column', 'PAM_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'PAM_Description',
   'user', '', 'table', 'PUBPAYMENTMETHOD', 'column', 'PAM_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ngày hiệu lực của phương thức thanh toán',
   'user', '', 'table', 'PUBPAYMENTMETHOD', 'column', 'PAM_EFFECTIVEDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'được kích hoạt không
   true : Active
   false :none active',
   'user', '', 'table', 'PUBPAYMENTMETHOD', 'column', 'PAM_ACTIVE'
go

/*==============================================================*/
/* Table: PUBPAYMENTTERM                                        */
/*==============================================================*/
create table PUBPAYMENTTERM (
   PTE_AUTOID2          smallint             not null,
   PPY_AUTOID           int                  null,
   PTE_DESCRIPTION      nvarchar(200)        null,
   PTE_TYPE             smallint             null,
   PTE_ACTIVE           bit                  null,
   PTE_CREATE_DATE      datetime             null,
   PTE_LASTMAINTAINED   datetime             null,
   constraint PK_PUBPAYMENTTERM primary key nonclustered (PTE_AUTOID2)
)
go

declare @CmtPUBPAYMENTTERM varchar(128)
select @CmtPUBPAYMENTTERM = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Điều khoản thanh toán
   
   vi du : lần 1 ngày 22/12/2009
   lần 2 ngày 23/13/2009
   nếu trễ 1 ngày trừ 100 usd',
   'user', @CmtPUBPAYMENTTERM, 'table', 'PUBPAYMENTTERM'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBPAYMENTTERM', 'column', 'PTE_AUTOID2'
go

execute sp_addextendedproperty 'MS_Description', 
   'PPY_AutoID',
   'user', '', 'table', 'PUBPAYMENTTERM', 'column', 'PPY_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Diễn tả của điều khoản thanh toán',
   'user', '', 'table', 'PUBPAYMENTTERM', 'column', 'PTE_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại điều khoản thanh toán',
   'user', '', 'table', 'PUBPAYMENTTERM', 'column', 'PTE_TYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'true: Được kích hoạt
   false: Không được kích hoat
   Default: true',
   'user', '', 'table', 'PUBPAYMENTTERM', 'column', 'PTE_ACTIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngay tao',
   'user', '', 'table', 'PUBPAYMENTTERM', 'column', 'PTE_CREATE_DATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày hết hạn',
   'user', '', 'table', 'PUBPAYMENTTERM', 'column', 'PTE_LASTMAINTAINED'
go

/*==============================================================*/
/* Index: RELATIONSHIP_34_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_34_FK on PUBPAYMENTTERM (
PPY_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBPAYMENTTERMDETAIL                                  */
/*==============================================================*/
create table PUBPAYMENTTERMDETAIL (
   PTD_AUTOID           int                  not null,
   PTE_AUTOID2          smallint             null,
   PTD_DUEPERCENT       decimal(4,2)         null,
   PTD_NOOFDAYS         decimal(4,2)         null,
   PDT_MONTH            smallint             null,
   PDT___DISCOUNT_      decimal(2,2)         null,
   PDT_PAY_IN_NO_OF_DAYS_ smallint             null,
   constraint PK_PUBPAYMENTTERMDETAIL primary key nonclustered (PTD_AUTOID)
)
go

declare @CmtPUBPAYMENTTERMDETAIL varchar(128)
select @CmtPUBPAYMENTTERMDETAIL = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'chi tiết điều khoản thanh toán',
   'user', @CmtPUBPAYMENTTERMDETAIL, 'table', 'PUBPAYMENTTERMDETAIL'
go

execute sp_addextendedproperty 'MS_Description', 
   'PTD_AutoID',
   'user', '', 'table', 'PUBPAYMENTTERMDETAIL', 'column', 'PTD_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBPAYMENTTERMDETAIL', 'column', 'PTE_AUTOID2'
go

execute sp_addextendedproperty 'MS_Description', 
   '% đã trả',
   'user', '', 'table', 'PUBPAYMENTTERMDETAIL', 'column', 'PTD_DUEPERCENT'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ngày gia hạn',
   'user', '', 'table', 'PUBPAYMENTTERMDETAIL', 'column', 'PTD_NOOFDAYS'
go

execute sp_addextendedproperty 'MS_Description', 
   'thang',
   'user', '', 'table', 'PUBPAYMENTTERMDETAIL', 'column', 'PDT_MONTH'
go

execute sp_addextendedproperty 'MS_Description', 
   '% Giảm giá',
   'user', '', 'table', 'PUBPAYMENTTERMDETAIL', 'column', 'PDT___DISCOUNT_'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày thực sự đã trả se được giảm giá 
   nếu số ngày trả <= PayinNoOfDays thì dược giảm giá
   theo % discou',
   'user', '', 'table', 'PUBPAYMENTTERMDETAIL', 'column', 'PDT_PAY_IN_NO_OF_DAYS_'
go

/*==============================================================*/
/* Index: RELATIONSHIP_71_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_71_FK on PUBPAYMENTTERMDETAIL (
PTE_AUTOID2 ASC
)
go

/*==============================================================*/
/* Table: PUBPLACE                                              */
/*==============================================================*/
create table PUBPLACE (
   PL_AUTOID            smallint             not null,
   PL_NAME              nvarchar(100)        null,
   PL_ISACTIVE          bit                  null,
   constraint PK_PUBPLACE primary key nonclustered (PL_AUTOID)
)
go

declare @CmtPUBPLACE varchar(128)
select @CmtPUBPLACE = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Khu vực dùng để áp dụng giảm giá cho khách hàng nào đó',
   'user', @CmtPUBPLACE, 'table', 'PUBPLACE'
go

execute sp_addextendedproperty 'MS_Description', 
   'PL_AutoID',
   'user', '', 'table', 'PUBPLACE', 'column', 'PL_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'PL_Name',
   'user', '', 'table', 'PUBPLACE', 'column', 'PL_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'PL_IsActive',
   'user', '', 'table', 'PUBPLACE', 'column', 'PL_ISACTIVE'
go

/*==============================================================*/
/* Table: PUBPOSITION                                           */
/*==============================================================*/
create table PUBPOSITION (
   POS_AUTOID           int                  not null,
   POS_NAME             nvarchar(100)        null,
   POS_DESCRIPTION      nvarchar(100)        null,
   POS_ISACTIVE         bit                  null,
   constraint PK_PUBPOSITION primary key nonclustered (POS_AUTOID)
)
go

declare @CmtPUBPOSITION varchar(128)
select @CmtPUBPOSITION = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Chức vụ',
   'user', @CmtPUBPOSITION, 'table', 'PUBPOSITION'
go

execute sp_addextendedproperty 'MS_Description', 
   'POS_AutoID',
   'user', '', 'table', 'PUBPOSITION', 'column', 'POS_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'POS_Name',
   'user', '', 'table', 'PUBPOSITION', 'column', 'POS_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'POS_Description',
   'user', '', 'table', 'PUBPOSITION', 'column', 'POS_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'POS_IsActive',
   'user', '', 'table', 'PUBPOSITION', 'column', 'POS_ISACTIVE'
go

/*==============================================================*/
/* Table: PUBPROJECT                                            */
/*==============================================================*/
create table PUBPROJECT (
   PRJ_AUTOID           smallint             not null,
   PRG_AUTOID           smallint             null,
   OBJ_AUTOID           int                  null,
   PRJ_NAME             nvarchar(200)        null,
   PRJ_DESCRIPTION      nvarchar(200)        null,
   PRJ_TYPE             char(50)             null,
   PRJ_ASIGNDATE        datetime             null,
   PRJ_STATEDATE        datetime             null,
   PRJ_ENDDATE          datetime             null,
   PRJ_ISACTIVE         bit                  null,
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

execute sp_addextendedproperty 'MS_Description', 
   'Prg_AutoID',
   'user', '', 'table', 'PUBPROJECT', 'column', 'PRG_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã đối tượng tự động tăng',
   'user', '', 'table', 'PUBPROJECT', 'column', 'OBJ_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'PRJ_Name',
   'user', '', 'table', 'PUBPROJECT', 'column', 'PRJ_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'PRJ_Description',
   'user', '', 'table', 'PUBPROJECT', 'column', 'PRJ_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'PRJ_Type',
   'user', '', 'table', 'PUBPROJECT', 'column', 'PRJ_TYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'PRJ_AsignDate',
   'user', '', 'table', 'PUBPROJECT', 'column', 'PRJ_ASIGNDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'PRJ_StateDate',
   'user', '', 'table', 'PUBPROJECT', 'column', 'PRJ_STATEDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'PRJ_EndDate',
   'user', '', 'table', 'PUBPROJECT', 'column', 'PRJ_ENDDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'PRJ_IsActive',
   'user', '', 'table', 'PUBPROJECT', 'column', 'PRJ_ISACTIVE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_109_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_109_FK on PUBPROJECT (
PRG_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_112_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_112_FK on PUBPROJECT (
OBJ_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBPROJECTGROUP                                       */
/*==============================================================*/
create table PUBPROJECTGROUP (
   PRG_AUTOID           smallint             not null,
   PRG_NAME             nchar(100)           null,
   PRG_DESCRIPTION      nvarchar(150)        null,
   PRG_ISACTIVE         bit                  null,
   constraint PK_PUBPROJECTGROUP primary key nonclustered (PRG_AUTOID)
)
go

declare @CmtPUBPROJECTGROUP varchar(128)
select @CmtPUBPROJECTGROUP = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nhóm dự án',
   'user', @CmtPUBPROJECTGROUP, 'table', 'PUBPROJECTGROUP'
go

execute sp_addextendedproperty 'MS_Description', 
   'Prg_AutoID',
   'user', '', 'table', 'PUBPROJECTGROUP', 'column', 'PRG_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Prg_Name',
   'user', '', 'table', 'PUBPROJECTGROUP', 'column', 'PRG_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Prg_Description',
   'user', '', 'table', 'PUBPROJECTGROUP', 'column', 'PRG_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Prg_IsActive',
   'user', '', 'table', 'PUBPROJECTGROUP', 'column', 'PRG_ISACTIVE'
go

/*==============================================================*/
/* Table: PUBPROVINCE                                           */
/*==============================================================*/
create table PUBPROVINCE (
   PRV_AUTOID           smallint             not null,
   BAK_AUTOID3          smallint             null,
   PL_AUTOID            smallint             null,
   CON_AUTOID2          int                  null,
   ORG_AUTOID           int                  null,
   PRV_NAME             char(200)            null,
   PRV_DESCRIPTION      nvarchar(200)        null,
   PRV_ISACTIVE         bit                  null,
   constraint PK_PUBPROVINCE primary key nonclustered (PRV_AUTOID)
)
go

declare @CmtPUBPROVINCE varchar(128)
select @CmtPUBPROVINCE = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Tỉnh thành',
   'user', @CmtPUBPROVINCE, 'table', 'PUBPROVINCE'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự động tăng',
   'user', '', 'table', 'PUBPROVINCE', 'column', 'PRV_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự tăng',
   'user', '', 'table', 'PUBPROVINCE', 'column', 'BAK_AUTOID3'
go

execute sp_addextendedproperty 'MS_Description', 
   'PL_AutoID',
   'user', '', 'table', 'PUBPROVINCE', 'column', 'PL_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'TRY_AutoID',
   'user', '', 'table', 'PUBPROVINCE', 'column', 'CON_AUTOID2'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tổ chức - Mã Công ty - Mã Chi Nhánh - Mã Phòng ban',
   'user', '', 'table', 'PUBPROVINCE', 'column', 'ORG_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'tên tỉnh thành ',
   'user', '', 'table', 'PUBPROVINCE', 'column', 'PRV_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'PRV_Description',
   'user', '', 'table', 'PUBPROVINCE', 'column', 'PRV_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'kích hoạt',
   'user', '', 'table', 'PUBPROVINCE', 'column', 'PRV_ISACTIVE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_92_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_92_FK on PUBPROVINCE (
CON_AUTOID2 ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_96_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_96_FK on PUBPROVINCE (
ORG_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_98_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_98_FK on PUBPROVINCE (
BAK_AUTOID3 ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_36_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_36_FK on PUBPROVINCE (
PL_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBSHIPMETHOD                                         */
/*==============================================================*/
create table PUBSHIPMETHOD (
   SMT_AUTOID           smallint             not null,
   SMT_NAME             nvarchar(150)        null,
   SMT_DESCRIPTION      nvarchar(200)        null,
   SMT_ISACTIVE         bit                  null,
   constraint PK_PUBSHIPMETHOD primary key nonclustered (SMT_AUTOID)
)
go

declare @CmtPUBSHIPMETHOD varchar(128)
select @CmtPUBSHIPMETHOD = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Phương thức vận chuyển',
   'user', @CmtPUBSHIPMETHOD, 'table', 'PUBSHIPMETHOD'
go

execute sp_addextendedproperty 'MS_Description', 
   'I tu tang',
   'user', '', 'table', 'PUBSHIPMETHOD', 'column', 'SMT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên ',
   'user', '', 'table', 'PUBSHIPMETHOD', 'column', 'SMT_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mô tả',
   'user', '', 'table', 'PUBSHIPMETHOD', 'column', 'SMT_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'kích hoạt',
   'user', '', 'table', 'PUBSHIPMETHOD', 'column', 'SMT_ISACTIVE'
go

/*==============================================================*/
/* Table: PUBSHIPPING                                           */
/*==============================================================*/
drop table PUBSHIPPING
create table PUBSHIPPING (
   SP_AUTOID            int                  not null,
   OBJ_AUTOID           int                  null,
   PRV_AUTOID           smallint             null,
   CON_AUTOID         int                  null,
   WH_AUTOID            int                  null,
   SMT_AUTOID           smallint             null,
   SP_NAME              nvarchar(100)        null,
   SP_ADDRESS           nvarchar(100)        null,
   SP_PHONENO           nchar(15)            null,
   SP_FAXNO             nchar(15)            null,
   SP_EXPECTEDDATE      datetime             null,
   SP_PROMISEDDATE      datetime             null,
   SP_TRANSPORTTIME     nchar(15)            null,
   SP_MODE              nvarchar(100)        null,
   SP_ISRECEIVE         bit                  null,
   SP_SUMMARY           nvarchar(100)        null,
   SP_COST              decimal(18,3)        null,
   SP_ISACTIVE          bit                  null,
   SP_TIME              int                  null,
   SP_TYPE              smallint             null,
   constraint PK_PUBSHIPPING primary key nonclustered (SP_AUTOID)
)
go

declare @CmtPUBSHIPPING varchar(128)
select @CmtPUBSHIPPING = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Vận chuyển',
   'user', @CmtPUBSHIPPING, 'table', 'PUBSHIPPING'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tự đông tăng',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SP_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'mã đối tượng tự động tăng',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'OBJ_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tự động tăng',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'PRV_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'TRY_AutoID',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'CON_AUTOID2'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mã tự tăng',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'WH_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'I tu tang',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SMT_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên ',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SP_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Địa chỉ',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SP_ADDRESS'
go

execute sp_addextendedproperty 'MS_Description', 
   'Số Phone',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SP_PHONENO'
go

execute sp_addextendedproperty 'MS_Description', 
   'Số Fax',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SP_FAXNO'
go

execute sp_addextendedproperty 'MS_Description', 
   'Ngày mong đợi nhận hàng',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SP_EXPECTEDDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'ngày đơn vị vận chuyển hứa',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SP_PROMISEDDATE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Thởi gian vận chuyển ',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SP_TRANSPORTTIME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Phương thức 
   Exam : Xe đạp Or Xe máy',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SP_MODE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Đã nhậ hàng 
   True : đã nhận
   False : chưa nhận',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SP_ISRECEIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mô tã vắn tắt ',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SP_SUMMARY'
go

execute sp_addextendedproperty 'MS_Description', 
   'Chi phi vận chuyển ',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SP_COST'
go

execute sp_addextendedproperty 'MS_Description', 
   'SP_IsActive',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SP_ISACTIVE'
go

execute sp_addextendedproperty 'MS_Description', 
   'Lần thứ mấy ',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SP_TIME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Loại 
   1 bình thường
   2 xuất nhập khẩu',
   'user', '', 'table', 'PUBSHIPPING', 'column', 'SP_TYPE'
go

/*==============================================================*/
/* Index: RELATIONSHIP_104_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_104_FK on PUBSHIPPING (
PRV_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_105_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_105_FK on PUBSHIPPING (
CON_AUTOID2 ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_26_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_26_FK on PUBSHIPPING (
WH_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_27_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_27_FK on PUBSHIPPING (
OBJ_AUTOID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_29_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_29_FK on PUBSHIPPING (
SMT_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBTAX                                                */
/*==============================================================*/
drop table PUBTAX
create table PUBTAX (
   TAX_AUTOID          int                  not null,
   TR_AUTOID            smallint             null,
   TAX_TYPEID           smallint             null,
   TAX_ACCOUNTID        nchar(10)            null,
   TAX_DESCRITION       nvarchar(200)        null,
   TAX_NOTE             nvarchar(100)        null,
   TAX_ISACTIVE         bit                  null,
   constraint PK_PUBTAX primary key nonclustered (TAX_AUTOID)
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
   'user', '', 'table', 'PUBTAX', 'column', 'TR_AUTOID'
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
/* Index: RELATIONSHIP_25_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_25_FK on PUBTAX (
TR_AUTOID ASC
)
go

/*==============================================================*/
/* Table: PUBTAXRATE                                            */
/*==============================================================*/
drop table PUBTAXRATE
create table PUBTAXRATE (
   TR_AUTOID            smallint             not null,
   TR_NAME              nvarchar(100)        null,
   TR_DESCRIPTION       nvarchar(200)        null,
   TR_ISACTIVE          bit                  null,
   constraint PK_PUBTAXRATE primary key nonclustered (TR_AUTOID)
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
   'user', '', 'table', 'PUBTAXRATE', 'column', 'TR_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên ',
   'user', '', 'table', 'PUBTAXRATE', 'column', 'TR_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Mô tả ',
   'user', '', 'table', 'PUBTAXRATE', 'column', 'TR_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'kích hoạt',
   'user', '', 'table', 'PUBTAXRATE', 'column', 'TR_ISACTIVE'
go

/*==============================================================*/
/* Table: PUBWAREHOUSE                                          */
/*==============================================================*/
create table PUBWAREHOUSE (
   WH_AUTOID            int                  not null,
   WH_DEFINEID          nchar(15)            null,
   WH_NAME              nvarchar(100)        null,
   WH_DESCRIPTTION      nvarchar(100)        null,
   WH_ISACTIVE          bit                  null,
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
   'Mã tự tăng',
   'user', '', 'table', 'PUBWAREHOUSE', 'column', 'WH_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'ID tu qquan ly ',
   'user', '', 'table', 'PUBWAREHOUSE', 'column', 'WH_DEFINEID'
go

execute sp_addextendedproperty 'MS_Description', 
   'WH_Name',
   'user', '', 'table', 'PUBWAREHOUSE', 'column', 'WH_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'WH_Descripttion',
   'user', '', 'table', 'PUBWAREHOUSE', 'column', 'WH_DESCRIPTTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'WH_IsActive',
   'user', '', 'table', 'PUBWAREHOUSE', 'column', 'WH_ISACTIVE'
go

/*==============================================================*/
/* Table: PUBYEAR                                               */
/*==============================================================*/
create table PUBYEAR (
   YEA_AUTOID           smallint             not null,
   YEA_NAME             nchar(10)            null,
   YEAR_DESCRIPTION     nvarchar(200)        null,
   YEAR_ISACTIVE        bit                  null,
   constraint PK_PUBYEAR primary key nonclustered (YEA_AUTOID)
)
go

declare @CmtPUBYEAR varchar(128)
select @CmtPUBYEAR = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Bảng nam cho biết nam tài chính',
   'user', @CmtPUBYEAR, 'table', 'PUBYEAR'
go

execute sp_addextendedproperty 'MS_Description', 
   'Yea_AutoID',
   'user', '', 'table', 'PUBYEAR', 'column', 'YEA_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Yea_Name',
   'user', '', 'table', 'PUBYEAR', 'column', 'YEA_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'mo ta ',
   'user', '', 'table', 'PUBYEAR', 'column', 'YEAR_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'kich hoat',
   'user', '', 'table', 'PUBYEAR', 'column', 'YEAR_ISACTIVE'
go

/*==============================================================*/
/* Table: PUB_PAYMENTTERMTYPE                                   */
/*==============================================================*/
create table PUB_PAYMENTTERMTYPE (
   PPY_AUTOID           int                  not null,
   PPY_NAME             nvarchar(20)         null,
   PPY_DESCRIPTION      nvarchar(50)         null,
   PPY_ACTIVE           bit                  null,
   constraint PK_PUB_PAYMENTTERMTYPE primary key nonclustered (PPY_AUTOID)
)
go

declare @CmtPUB_PAYMENTTERMTYPE varchar(128)
select @CmtPUB_PAYMENTTERMTYPE = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Loại điều khoản thanh toán',
   'user', @CmtPUB_PAYMENTTERMTYPE, 'table', 'PUB_PAYMENTTERMTYPE'
go

execute sp_addextendedproperty 'MS_Description', 
   'PPY_AutoID',
   'user', '', 'table', 'PUB_PAYMENTTERMTYPE', 'column', 'PPY_AUTOID'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tên loại điều khoản thanh toán',
   'user', '', 'table', 'PUB_PAYMENTTERMTYPE', 'column', 'PPY_NAME'
go

execute sp_addextendedproperty 'MS_Description', 
   'Miêu tả',
   'user', '', 'table', 'PUB_PAYMENTTERMTYPE', 'column', 'PPY_DESCRIPTION'
go

execute sp_addextendedproperty 'MS_Description', 
   'Tạng thái của loại điều khoản thanh toán
   true: Khích hoạt
   fault: không kích hoạt
   default:true',
   'user', '', 'table', 'PUB_PAYMENTTERMTYPE', 'column', 'PPY_ACTIVE'
go

alter table FINANCYCICLE
   add constraint FK_FINANCYC_RELATIONS_PUBYEAR foreign key (YEA_AUTOID)
      references PUBYEAR (YEA_AUTOID)
go

alter table ITEMSPOSITION
   add constraint FK_ITEMSPOS_RELATIONS_PUBWAREH foreign key (WH_AUTOID)
      references PUBWAREHOUSE (WH_AUTOID)
go

alter table PUBBANKDETAIL
   add constraint FK_PUBBANKD_RELATIONS_PUBBANK foreign key (BAK_AUTOID3)
      references PUBBANK (BAK_AUTOID3)
go

alter table PUBCAREERDETAIL
   add constraint FK_PUBCAREE_PUBCAREER_PUBCAREE foreign key (CAR_AUTOID)
      references PUBCAREER (CAR_AUTOID)
go

alter table PUBCAREERDETAIL
   add constraint FK_PUBCAREE_PUBCAREER_PUBORGAN foreign key (ORG_AUTOID)
      references PUBORGANIZATION (ORG_AUTOID)
go

alter table PUBCONTACT
   add constraint FK_PUBCONTA_THONG_TIN_PUBOBJEC foreign key (OBJ_AUTOID)
      references PUBOBJECT (OBJ_AUTOID)
go

alter table PUBCONTRACT
   add constraint FK_PUBCONTR_DU_AN_PUBPROJE foreign key (PRJ_AUTOID)
      references PUBPROJECT (PRJ_AUTOID)
go

alter table PUBCONTRACT
   add constraint FK_PUBCONTR_HOP_DONG__PUBORGAN foreign key (ORG_AUTOID)
      references PUBORGANIZATION (ORG_AUTOID)
go

alter table PUBCONTRACT
   add constraint FK_PUBCONTR_LOAI_TIEN_PUBCURRE foreign key (CUR_AUTOID3)
      references PUBCURRENCY (CUR_AUTOID3)
go

alter table PUBCONTRACT
   add constraint FK_PUBCONTR_RELATIONS_PUBCONTR foreign key (CTG_AUTOID)
      references PUBCONTRACTGROUP (CTG_AUTOID)
go

alter table PUBCONTRACT
   add constraint FK_PUBCONTR_RELATIONS_PUBCONTA foreign key (CON_AUTOID)
      references PUBCONTACT (CON_AUTOID)
go

alter table PUBCURRENCYRATE
   add constraint FK_PUBCURRE_TY_GIA_PUBCURRE foreign key (CUR_AUTOID3)
      references PUBCURRENCY (CUR_AUTOID3)
go

alter table PUBDOCUMENT
   add constraint FK_PUBDOCUM_RELATIONS_PUBDOCUM foreign key (DOTY_SYSTEMID)
      references PUBDOCUMENTTYPE (DOTY_SYSTEMID)
go

alter table PUBDOCUMENT
   add constraint FK_PUBDOCUM_RELATIONS_PUBORGAN foreign key (ORG_AUTOID)
      references PUBORGANIZATION (ORG_AUTOID)
go

alter table PUBOBJECT
   add constraint FK_PUBOBJEC_ACCOUNT_O_PUBACCOU foreign key (ACC_AUTOID6)
      references PUBACCOUNT (ACC_AUTOID6)
go

alter table PUBOBJECT
   add constraint FK_PUBOBJEC_BANK_ACCO_PUBBANKD foreign key (ACD_AUTOID)
      references PUBBANKDETAIL (ACD_AUTOID)
go

alter table PUBOBJECT
   add constraint FK_PUBOBJEC_DIA_CHI_C_PUBPROVI foreign key (PRV_AUTOID)
      references PUBPROVINCE (PRV_AUTOID)
go

alter table PUBOBJECT
   add constraint FK_PUBOBJEC_LEVEL_PUBOBJLE foreign key (POBJ_AUTOID)
      references PUBOBJLEVEL (POBJ_AUTOID)
go

alter table PUBOBJECT
   add constraint FK_PUBOBJEC_RELATIONS_PUBOBJGR foreign key (POG_AUTOID)
      references PUBOBJGROUP (POG_AUTOID)
go

alter table PUBOBJECT
   add constraint FK_PUBOBJEC_RELATIONS_PUBPAYME foreign key (PAY_AUTOID3)
      references PUBPAYMENTMETHOD (PAY_AUTOID3)
go

alter table PUBORGANIZATION
   add constraint FK_PUBORGAN_LOAI_HINH_PUBORGTY foreign key (OTP_AUTOID)
      references PUBORGTYPE (OTP_AUTOID)
go

alter table PUBORGANIZATION
   add constraint FK_PUBORGAN_LOAI_TIEN_PUBCURRE foreign key (CUR_AUTOID3)
      references PUBCURRENCY (CUR_AUTOID3)
go

alter table PUBORGANIZATION
   add constraint FK_PUBORGAN_RELATIONS_PUBPROVI foreign key (PRV_AUTOID)
      references PUBPROVINCE (PRV_AUTOID)
go

alter table PUBORGOBJ
   add constraint FK_PUBORGOB_CONTENT_T_PUBOBJEC foreign key (OBJT_AUTOID)
      references PUBOBJECTTYPE (OBJT_AUTOID)
go

alter table PUBORGOBJ
   add constraint FK_PUBORGOB_PUBORGOBJ_PUBORGAN foreign key (ORG_AUTOID)
      references PUBORGANIZATION (ORG_AUTOID)
go

alter table PUBORGOBJ
   add constraint FK_PUBORGOB_PUBORGOBJ_PUBPOSIT foreign key (POS_AUTOID)
      references PUBPOSITION (POS_AUTOID)
go

alter table PUBORGOBJ
   add constraint FK_PUBORGOB_PUBORGOBJ_PUBOBJEC foreign key (OBJ_AUTOID)
      references PUBOBJECT (OBJ_AUTOID)
go

alter table PUBPAYMENTTERM
   add constraint FK_PUBPAYME_RELATIONS_PUB_PAYM foreign key (PPY_AUTOID)
      references PUB_PAYMENTTERMTYPE (PPY_AUTOID)
go

alter table PUBPAYMENTTERMDETAIL
   add constraint FK_PUBPAYME_RELATIONS_PUBPAYME foreign key (PTE_AUTOID2)
      references PUBPAYMENTTERM (PTE_AUTOID2)
go

alter table PUBPROJECT
   add constraint FK_PUBPROJE_RELATIONS_PUBPROJE foreign key (PRG_AUTOID)
      references PUBPROJECTGROUP (PRG_AUTOID)
go

alter table PUBPROJECT
   add constraint FK_PUBPROJE_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID)
      references PUBOBJECT (OBJ_AUTOID)
go

alter table PUBPROVINCE
   add constraint FK_PUBPROVI_RELATIONS_PUBPLACE foreign key (PL_AUTOID)
      references PUBPLACE (PL_AUTOID)
go

alter table PUBPROVINCE
   add constraint FK_PUBPROVI_RELATIONS_PUBCOUNT foreign key (CON_AUTOID2)
      references PUBCOUNTRY (CON_AUTOID2)
go

alter table PUBPROVINCE
   add constraint FK_PUBPROVI_RELATIONS_PUBORGAN foreign key (ORG_AUTOID)
      references PUBORGANIZATION (ORG_AUTOID)
go

alter table PUBPROVINCE
   add constraint FK_PUBPROVI_RELATIONS_PUBBANK foreign key (BAK_AUTOID3)
      references PUBBANK (BAK_AUTOID3)
go

alter table PUBSHIPPING
   add constraint FK_PUBSHIPP_RELATIONS_PUBPROVI foreign key (PRV_AUTOID)
      references PUBPROVINCE (PRV_AUTOID)
go

alter table PUBSHIPPING
   add constraint FK_PUBSHIPP_RELATIONS_PUBCOUNT foreign key (CON_AUTOID2)
      references PUBCOUNTRY (CON_AUTOID2)
go

alter table PUBSHIPPING
   add constraint FK_PUBSHIPP_RELATIONS_PUBWAREH foreign key (WH_AUTOID)
      references PUBWAREHOUSE (WH_AUTOID)
go

alter table PUBSHIPPING
   add constraint FK_PUBSHIPP_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID)
      references PUBOBJECT (OBJ_AUTOID)
go

alter table PUBSHIPPING
   add constraint FK_PUBSHIPP_RELATIONS_PUBSHIPM foreign key (SMT_AUTOID)
      references PUBSHIPMETHOD (SMT_AUTOID)
go

alter table PUBTAX
   add constraint FK_PUBTAX_RELATIONS_PUBTAXRA foreign key (TR_AUTOID)
      references PUBTAXRATE (TR_AUTOID)
go

