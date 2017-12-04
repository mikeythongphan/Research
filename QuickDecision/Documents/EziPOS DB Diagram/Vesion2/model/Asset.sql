create table AMASSETITEM 
(
   ASI_AUTOID           integer                        not null,
   PIT_AUTOID           integer                        null,
   ACIG_AUTOID          smallint                       null,
   ST_AUTOID            smallint                       null,
   ASI_TYPE             smallint                       null,
   PIT_ITEMNO           varchar(10)                      null,
   ASI_ASSETITEMNO      varchar(10)                      null,
   PIT_ITEMNAME         nvarchar(200)                  null,
   ASI_DESCRIPTION      nvarchar(200)                  null,
   ASI_PRODUCTIONDATE   datetime                      null,
   ASI_WARRANTYNU       smallint                       null,
   ASI_WARRANTYTYPE     smallint                       null,
   ASI_PRODUCTIONCOUNTRY nvarchar(200)                  null,
   ASI_FORM             smallint                       null,
   ASI_MANUFACTURER     nvarchar(100)                  null,
   IV_DOCUMENTID        integer                        null,
   PO_DOCUMENTID        integer                        null,
   OTHER_LSTDOCUMENNO   varchar(100)                     null,
   constraint PK_AMASSETITEM primary key (ASI_AUTOID)
);

/*==============================================================*/
/* Table: AMCAPITAL                                             */
/*==============================================================*/
create table AMCAPITAL 
(
   ASO_AUTOID           smallint                       not null,
   ASI_AUTOID           integer                        null,
   ASS_AUTOID           smallint                       null,
   OBJ_AUTOID          integer                        null,
   ASO_UNIT             varchar(10)                      null,
   ASO_AMOUNT           decimal(18,3)                  null,
   ASO_ISACTIVE         smallint                       null,
   constraint PK_AMCAPITAL primary key (ASO_AUTOID)
);

/*==============================================================*/
/* Table: AMCAPITALTYPE                                         */
/*==============================================================*/
create table AMCAPITALTYPE 
(
   ASS_AUTOID           smallint                       not null,
   ASS_NAME             Nvarchar(100)                      null,
   ASS_DESCRIPTION      nvarchar(200)                  null,
   ASS_ISACTIVE         smallint                       null,
   constraint PK_AMCAPITALTYPE primary key (ASS_AUTOID)
);

/*==============================================================*/
/* Table: AMDECREASE                                            */
/*==============================================================*/
create table AMDECREASE 
(
   AMB_DOCUMENTID      integer                        not null,
   ST_AUTOID            smallint                       null,
   DOTY_AUTOID          smallint                       null,
   FICI_AUTOID          smallint                       null,
   PUBAT_AUTOID         integer                        null,
   AMV_LISTDOCUMENT     varchar(200)                     null,
   AMV_ACCESSTYPE       smallint                       null,
   AMV_ISWRITE          smallint                       null,
   AMV_ISUSSING         smallint                       null,
   constraint PK_AMDECREASE primary key (AMB_DOCUMENTID)
);

/*==============================================================*/
/* Table: AMDECREASEDETAIL                                      */
/*==============================================================*/
create table AMDECREASEDETAIL 
(
   ADD_AUTOID           integer                        not null,
   ST_AUTOID            smallint                       null,
   PIT_AUTOID           integer                        null,
   ORG_AUTOID           integer                        null,
   AMB_DOCUMENTID      integer                        null,
   RES_AUTOID           smallint                       null,
   OBJ_AUTOID           integer                        null,
   PIT_ITEMNAME         nvarchar(200)                  null,
   PIT_ITEMNO           varchar(10)                      null,
   AED_AMOUNT           decimal(18,3)                  null,
   ADD_WEAR             decimal(18,3)                  null,
   ADD_FICIDEPRECIATION smallint                       null,
   ADD_REMAINAMOUNT     decimal(18,3)                  null,
   COT_LISTDOCUMENTNO   varchar(200)                     null,
   CON_LSTDOCUMENTNO    varchar(200)                     null,
   constraint PK_AMDECREASEDETAIL primary key (ADD_AUTOID)
);

/*==============================================================*/
/* Table: AMDEPMETHOD                                           */
/*==============================================================*/
create table AMDEPMETHOD 
(
   ADM_AUTOID           smallint                       not null,
   ADM_NAME             nvarchar(100)                  null,
   ADM_DESCRIPTION      nvarchar(200)                  null,
   ADM_ISACTIVE         smallint                       null,
   constraint PK_AMDEPMETHOD primary key (ADM_AUTOID)
);

/*==============================================================*/
/* Table: AMENTRY                                               */
/*==============================================================*/
create table AMENTRY 
(
   AME_AUTOID           integer                        not null,
   DOC_DOCUMENTID       integer                        null,
   CP_AUTOID            integer                        null,
   OBJ_AUTOID           integer                        null,
   CUR_AUTOID           smallint                       null,
   COT_AUTOID           integer                        null,
   ASI_AUTOID           integer                        null,
   ACC_DEPT             varchar(10)                      null,
   ACC_CREDIT           varchar(10)                      null,
   AME_AMOUNT           decimal(18,3)                  null,
   CUR_EXCHANGERATE     decimal(4,2)                   null,
   AME_BASEAMOUNT       decimal(18,3)                  null,
   AME_NOTE             nvarchar(200)                  null,
   PO_DOCUMENTID        integer                        null,
   constraint PK_AMENTRY primary key (AME_AUTOID)
);

/*==============================================================*/
/* Table: AMEVALUATION                                          */
/*==============================================================*/
create table AMEVALUATION 
(
   AMB_DOCUMENTID      integer                        not null,
   DOTY_AUTOID          smallint                       null,
   ST_AUTOID            smallint                       null,
   PUBAT_AUTOID         integer                        null,
   FICI_AUTOID          smallint                       null,
   AMV_LISTDOCUMENT     varchar(200)                     null,
   AMV_ACCESSTYPE       smallint                       null,
   AMV_ISWRITE          smallint                       null,
   AMV_ISUSSING         smallint                       null,
   constraint PK_AMEVALUATION primary key (AMB_DOCUMENTID)
);

/*==============================================================*/
/* Table: AMEVALUATIONDETAIL                                    */
/*==============================================================*/
create table AMEVALUATIONDETAIL 
(
   AED_AUTOID           integer                        not null,
   AMB_DOCUMENTID      integer                        null,
   ORG_AUTOID           integer                        null,
   RES_AUTOID           smallint                       null,
   AED_AMOUNT           decimal(18,3)                  null,
   AED_WEAR             decimal(18,3)                  null,
   AED_FICIDEPRECIATION smallint                       null,
   AED_REMAINAMOUNT     decimal(18,3)                  null,
   AED_ISEDIT           smallint                       null,
   AED_STOPDATE         datetime                      null,
   AED_CORRUPTDATE      datetime                      null,
   AED_CORRUPTDESCRIPTION nvarchar(200)                  null,
   AED_EDITAMOUNT       decimal(18,3)                  null,
   AED_EDITWEAR         decimal(18,3)                  null,
   AED_EDITFICIDEPRECIATION smallint                       null,
   AED_EDITREMAINAMOUNT decimal(18,3)                  null,
   constraint PK_AMEVALUATIONDETAIL primary key (AED_AUTOID)
);

/*==============================================================*/
/* Table: AMINCREASE                                            */
/*==============================================================*/
create table AMINCREASE 
(
   ABI_DOCUMENTID       integer                        not null,
   PUBAT_AUTOID         integer                        null,
   DOTY_AUTOID          smallint                       null,
   FICI_AUTOID          smallint                       null,
   ST_AUTOID            smallint                       null,
   AMV_LISTDOCUMENT     varchar(200)                     null,
   AMV_ACCESSTYPE       smallint                       null,
   AMV_ISWRITE          smallint                       null,
   AMV_ISUSSING         smallint                       null,
   constraint PK_AMINCREASE primary key (ABI_DOCUMENTID)
);

/*==============================================================*/
/* Table: AMINCREASEDETAIL                                      */
/*==============================================================*/
create table AMINCREASEDETAIL 
(
   ABID_AUTOID          integer                        not null,
   ABI_DOCUMENTID       integer                        null,
   UOM_AUTOID           smallint                       null,
   RES_AUTOID           smallint                       null,
   PIT_AUTOID           integer                        null,
   PIT_ITEMNAME         nvarchar(200)                  null,
   PIT_ITEMNO           varchar(10)                      null,
   AED_QUANTITY         decimal(10,3)                  null,
   AED_AMOUNT           decimal(18,3)                  null,
   AED_TOTALAMOUNT      decimal(18,3)                  null,
   PO_DOCUMENTID        integer                        null,
   IC_DOCUMENTID        varchar(100)                     null,
   PAY_DOCUMENTID       varchar(100)                     null,
   AED_ISCREATEDDEP     smallint                       null,
   constraint PK_AMINCREASEDETAIL primary key (ABID_AUTOID)
);

/*==============================================================*/
/* Table: AMITEMUSEPURPOSE                                      */
/*==============================================================*/
create table AMITEMUSEPURPOSE 
(
   AIUP_AUTOID          smallint                       not null,
   AIUP_NAME            nvarchar(100)                  null,
   AIUP_DESCRIPTION     nvarchar(200)                  null,
   AIUP_ISACTIVE        smallint                       null,
   constraint PK_AMITEMUSEPURPOSE primary key (AIUP_AUTOID)
);

/*==============================================================*/
/* Table: AMPEPREBUS                                            */
/*==============================================================*/
create table AMPEPREBUS 
(
   APB_DOCUMENTID       integer                        not null,
   FICI_AUTOID          smallint                       null,
   CUR_AUTOID           smallint                       null,
   PUBAT_AUTOID         integer                        null,
   ST_AUTOID            smallint                       null,
   APB_DOCUMENTNO       varchar(20)                      null,
   APB_AMOUNT           decimal(18,3)                  null,
   constraint PK_AMPEPREBUS primary key (APB_DOCUMENTID)
);

/*==============================================================*/
/* Table: AMPEPREBUSDETAIL                                      */
/*==============================================================*/
create table AMPEPREBUSDETAIL 
(
   APBD_AUTOID          integer                        not null,
   ASI_AUTOID           integer                        null,
   APB_DOCUMENTID       integer                        null,
   CP_AUTOID            integer                        null,
   ORG_AUTOID           integer                        null,
   COT_AUTOID           integer                        null,
   PIT_ITEMNO           varchar(10)                      null,
   PIT_ITEMNAME         nvarchar(200)                  null,
   ASI_ASSETITEMNO      varchar(10)                      null,
   ASI_TYPE             smallint                       null,
   APBD_BASEAMOUNT      decimal(18,3)                  null,
   APBD_NOTE            nvarchar(100)                  null,
   constraint PK_AMPEPREBUSDETAIL primary key (APBD_AUTOID)
);

/*==============================================================*/
/* Table: AMPEPRECIATION                                        */
/*==============================================================*/
create table AMPEPRECIATION 
(
   AMP_AUTOID           integer                        not null,
   CP_AUTOID            integer                        null,
   ADM_AUTOID           smallint                       null,
   FICI_AUTOID          smallint                       null,
   ASI_AUTOID           integer                        null,
   ASI_ASSETITEMNO      varchar(10)                      null,
   AMP_AMOUNT           decimal(18,3)                  null,
   AMP_BEGINDATE        datetime                           null,
   AMP_WEAR             decimal(18,3)                  null,
   FICI_NUMBER          smallint                       null,
   ACC_ORIACCOUNT       varchar(10)                      null,
   ACC_WEARACCOUNT      varchar(10)                      null,
   ACC_COSTACCOUNT      varchar(10)                      null,
   constraint PK_AMPEPRECIATION primary key (AMP_AUTOID)
);

/*==============================================================*/
/* Table: AMPEPRECOSTPRICE                                      */
/*==============================================================*/
create table AMPEPRECOSTPRICE 
(
   APC_AUTOID           integer                        not null,
   ASPD_AUTOID          integer                        null,
   CP_AUTOID            integer                        null,
   ACC_CODE             varchar(10)                      null,
   COT_AUTOID           integer                        null,
   APC_PERCENT          decimal(5,2)                   null,
   ACC_ACCOUNTCOST      varchar(10)                      null,
   constraint PK_AMPEPRECOSTPRICE primary key (APC_AUTOID)
);

/*==============================================================*/
/* Table: AMPEPREDETAIL                                         */
/*==============================================================*/
create table AMPEPREDETAIL 
(
   ASPD_AUTOID          integer                        not null,
   AMP_AUTOID           integer                        null,
   FICI_AUTOID          smallint                       null,
   ASPD_AMOUNT          decimal(18,3)                  null,
   ASPD_ISPEPRE         smallint                       null,
   constraint PK_AMPEPREDETAIL primary key (ASPD_AUTOID)
);

/*==============================================================*/
/* Table: AMREASON                                              */
/*==============================================================*/
create table AMREASON 
(
   RES_AUTOID           smallint                       not null,
   RES_RESIONID         varchar(10)                      null,
   RES_RESIONNAME       nvarchar(200)                  null,
   RES_BUSSINES         smallint                       null,
   RES_DESCRIPTION      nvarchar(200)                  null,
   RES_ISACTIVE         smallint                       null,
   constraint PK_AMREASON primary key (RES_AUTOID)
);

/*==============================================================*/
/* Table: AMTASSETGROUP                                         */
/*==============================================================*/
create table AMTASSETGROUP 
(
   ACIG_AUTOID          smallint                       not null,
   ACIG_NAME            nvarchar(200)                  null,
   ACIG_DESCRIPTION     nvarchar(200)                  null,
   ACIG_ISACTIVE        smallint                       null,
   ACC_ORIACCOUNT       varchar(10)                      null,
   ACC_WEARACCOUNT      varchar(10)                      null,
   ACC_COSTPRICEACCOUNT varchar(10)                      null,
   ACC_SOURCEACCOUNT    varchar(10)                      null,
   YEAR_NUMBER          smallint                       null,
   constraint PK_AMTASSETGROUP primary key (ACIG_AUTOID)
);

/*==============================================================*/
/* Table: AMUSEINFOR                                            */
/*==============================================================*/
create table AMUSEINFOR 
(
   AUI_AUTOID           smallint                       not null,
   ASI_AUTOID           integer                        null,
   ORG_AUTOID           integer                        null,
   POS_AUTOID           integer                        null,
   AIUP_AUTOID          smallint                       null,
   OBJ_AUTOID           integer                        null,
   AUI_NOTE             nvarchar(200)                  null,
   constraint PK_AMUSEINFOR primary key (AUI_AUTOID)
);

/*==============================================================*/
/* Table: INSURANCEITEM                                         */
/*==============================================================*/
create table INSURANCEITEM 
(
   INS_AUTOID           smallint                       not null,
   ASI_AUTOID           integer                        null,
   INS_INSUREID         varchar(10)                      null,
   INS_DESCRIPTION      nvarchar(200)                  null,
   INS_SERIAL           varchar(10)                      null,
   INS_SERDESCRIPTION   nvarchar(200)                  null,
   INS_TYPE             smallint                       null,
   INS_VALIDDATE        datetime                           null,
   INS_EXPIREDATE       datetime                          null,
   INS_PAYDATE          datetime                           null,
   INS_SO_TIEN_         decimal(18,3)                  null,
   INS_MININSURE        decimal(18,3)                  null,
   INS_MAXINSURE        decimal(18,3)                  null,
   INS_FILLEURL         nvarchar(200)                     null,
   constraint PK_INSURANCEITEM primary key (INS_AUTOID)
);