/*==============================================================*/
/* DBMS name:      Sybase SQL Anywhere 10                       */
/* Created on:     10/27/2009 2:39:35 PM                        */
/*==============================================================*/


if exists(select 1 from sys.sysforeignkey where role='FK_AMASSETI_RELATIONS_PUBSTATU') then
    alter table AMASSETITEM
       delete foreign key FK_AMASSETI_RELATIONS_PUBSTATU
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMASSETI_RELATIONS_PUBITEMS') then
    alter table AMASSETITEM
       delete foreign key FK_AMASSETI_RELATIONS_PUBITEMS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMASSETI_RELATIONS_AMTASSET') then
    alter table AMASSETITEM
       delete foreign key FK_AMASSETI_RELATIONS_AMTASSET
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMCAPITA_RELATIONS_AMCAPITA') then
    alter table AMCAPITAL
       delete foreign key FK_AMCAPITA_RELATIONS_AMCAPITA
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMCAPITA_RELATIONS_AMASSETI') then
    alter table AMCAPITAL
       delete foreign key FK_AMCAPITA_RELATIONS_AMASSETI
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMCAPITA_RELATIONS_PUBOBJEC') then
    alter table AMCAPITAL
       delete foreign key FK_AMCAPITA_RELATIONS_PUBOBJEC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMDECREA_RELATIONS_PUBDOCUM') then
    alter table AMDECREASE
       delete foreign key FK_AMDECREA_RELATIONS_PUBDOCUM
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMDECREA_RELATIONS_PUBSTATU') then
    alter table AMDECREASE
       delete foreign key FK_AMDECREA_RELATIONS_PUBSTATU
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMDECREA_RELATIONS_FINANCYC') then
    alter table AMDECREASE
       delete foreign key FK_AMDECREA_RELATIONS_FINANCYC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMDECREA_RELATIONS_PUBBATCH') then
    alter table AMDECREASE
       delete foreign key FK_AMDECREA_RELATIONS_PUBBATCH
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMDECREA_RELATIONS_AMDECREA') then
    alter table AMDECREASEDETAIL
       delete foreign key FK_AMDECREA_RELATIONS_AMDECREA
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMDECREA_RELATIONS_PUBORGAN') then
    alter table AMDECREASEDETAIL
       delete foreign key FK_AMDECREA_RELATIONS_PUBORGAN
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMDECREA_RELATIONS_PUBOBJEC') then
    alter table AMDECREASEDETAIL
       delete foreign key FK_AMDECREA_RELATIONS_PUBOBJEC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMDECREA_RELATIONS_PUBSTATU') then
    alter table AMDECREASEDETAIL
       delete foreign key FK_AMDECREA_RELATIONS_PUBSTATU
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMDECREA_RELATIONS_AMREASON') then
    alter table AMDECREASEDETAIL
       delete foreign key FK_AMDECREA_RELATIONS_AMREASON
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMDECREA_RELATIONS_PUBITEMS') then
    alter table AMDECREASEDETAIL
       delete foreign key FK_AMDECREA_RELATIONS_PUBITEMS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMENTRY_RELATIONS_AMASSETI') then
    alter table AMENTRY
       delete foreign key FK_AMENTRY_RELATIONS_AMASSETI
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMENTRY_RELATIONS_PUBOBJEC') then
    alter table AMENTRY
       delete foreign key FK_AMENTRY_RELATIONS_PUBOBJEC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMENTRY_RELATIONS_PUBCURRE') then
    alter table AMENTRY
       delete foreign key FK_AMENTRY_RELATIONS_PUBCURRE
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMENTRY_RELATIONS_PUBCONTR') then
    alter table AMENTRY
       delete foreign key FK_AMENTRY_RELATIONS_PUBCONTR
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMENTRY_RELATIONS_PUBCOSTP') then
    alter table AMENTRY
       delete foreign key FK_AMENTRY_RELATIONS_PUBCOSTP
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMENTRY_RELATIONS_PUBDOCUM') then
    alter table AMENTRY
       delete foreign key FK_AMENTRY_RELATIONS_PUBDOCUM
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMEVALUA_RELATIONS_PUBDOCUM') then
    alter table AMEVALUATION
       delete foreign key FK_AMEVALUA_RELATIONS_PUBDOCUM
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMEVALUA_RELATIONS_PUBBATCH') then
    alter table AMEVALUATION
       delete foreign key FK_AMEVALUA_RELATIONS_PUBBATCH
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMEVALUA_RELATIONS_FINANCYC') then
    alter table AMEVALUATION
       delete foreign key FK_AMEVALUA_RELATIONS_FINANCYC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMEVALUA_RELATIONS_PUBSTATU') then
    alter table AMEVALUATION
       delete foreign key FK_AMEVALUA_RELATIONS_PUBSTATU
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMEVALUA_RELATIONS_AMEVALUA') then
    alter table AMEVALUATIONDETAIL
       delete foreign key FK_AMEVALUA_RELATIONS_AMEVALUA
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMEVALUA_RELATIONS_PUBORGAN') then
    alter table AMEVALUATIONDETAIL
       delete foreign key FK_AMEVALUA_RELATIONS_PUBORGAN
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMEVALUA_RELATIONS_AMREASON') then
    alter table AMEVALUATIONDETAIL
       delete foreign key FK_AMEVALUA_RELATIONS_AMREASON
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMINCREA_RELATIONS_PUBBATCH') then
    alter table AMINCREASE
       delete foreign key FK_AMINCREA_RELATIONS_PUBBATCH
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMINCREA_RELATIONS_FINANCYC') then
    alter table AMINCREASE
       delete foreign key FK_AMINCREA_RELATIONS_FINANCYC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMINCREA_RELATIONS_PUBDOCUM') then
    alter table AMINCREASE
       delete foreign key FK_AMINCREA_RELATIONS_PUBDOCUM
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMINCREA_TRANG_THA_PUBSTATU') then
    alter table AMINCREASE
       delete foreign key FK_AMINCREA_TRANG_THA_PUBSTATU
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMINCREA_RELATIONS_AMREASON') then
    alter table AMINCREASEDETAIL
       delete foreign key FK_AMINCREA_RELATIONS_AMREASON
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMINCREA_RELATIONS_PUBITEMS') then
    alter table AMINCREASEDETAIL
       delete foreign key FK_AMINCREA_RELATIONS_PUBITEMS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMINCREA_RELATIONS_AMINCREA') then
    alter table AMINCREASEDETAIL
       delete foreign key FK_AMINCREA_RELATIONS_AMINCREA
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMINCREA_RELATIONS_PUBUOM') then
    alter table AMINCREASEDETAIL
       delete foreign key FK_AMINCREA_RELATIONS_PUBUOM
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREB_RELATIONS_PUBBATCH') then
    alter table AMPEPREBUS
       delete foreign key FK_AMPEPREB_RELATIONS_PUBBATCH
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREB_RELATIONS_FINANCYC') then
    alter table AMPEPREBUS
       delete foreign key FK_AMPEPREB_RELATIONS_FINANCYC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREB_RELATIONS_PUBCURRE') then
    alter table AMPEPREBUS
       delete foreign key FK_AMPEPREB_RELATIONS_PUBCURRE
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREB_RELATIONS_PUBSTATU') then
    alter table AMPEPREBUS
       delete foreign key FK_AMPEPREB_RELATIONS_PUBSTATU
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREB_RELATIONS_AMPEPREB') then
    alter table AMPEPREBUSDETAIL
       delete foreign key FK_AMPEPREB_RELATIONS_AMPEPREB
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREB_RELATIONS_AMASSETI') then
    alter table AMPEPREBUSDETAIL
       delete foreign key FK_AMPEPREB_RELATIONS_AMASSETI
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREB_RELATIONS_PUBORGAN') then
    alter table AMPEPREBUSDETAIL
       delete foreign key FK_AMPEPREB_RELATIONS_PUBORGAN
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREB_RELATIONS_PUBCONTR') then
    alter table AMPEPREBUSDETAIL
       delete foreign key FK_AMPEPREB_RELATIONS_PUBCONTR
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREB_RELATIONS_PUBCOSTP') then
    alter table AMPEPREBUSDETAIL
       delete foreign key FK_AMPEPREB_RELATIONS_PUBCOSTP
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREC_RELATIONS_AMASSETI') then
    alter table AMPEPRECIATION
       delete foreign key FK_AMPEPREC_RELATIONS_AMASSETI
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREC_RELATIONS_AMDEPMET') then
    alter table AMPEPRECIATION
       delete foreign key FK_AMPEPREC_RELATIONS_AMDEPMET
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREC_RELATIONS_FINANCYC') then
    alter table AMPEPRECIATION
       delete foreign key FK_AMPEPREC_RELATIONS_FINANCYC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREC_RELATIONS_PUBCOSTP') then
    alter table AMPEPRECIATION
       delete foreign key FK_AMPEPREC_RELATIONS_PUBCOSTP
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREC_RELATIONS_AMPEPRED') then
    alter table AMPEPRECOSTPRICE
       delete foreign key FK_AMPEPREC_RELATIONS_AMPEPRED
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREC_RELATIONS_PUBCOSTP') then
    alter table AMPEPRECOSTPRICE
       delete foreign key FK_AMPEPREC_RELATIONS_PUBCOSTP
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREC_RELATIONS_PUBCONTR') then
    alter table AMPEPRECOSTPRICE
       delete foreign key FK_AMPEPREC_RELATIONS_PUBCONTR
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPREC_RELATIONS_PUBACCOU') then
    alter table AMPEPRECOSTPRICE
       delete foreign key FK_AMPEPREC_RELATIONS_PUBACCOU
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPRED_RELATIONS_AMPEPREC') then
    alter table AMPEPREDETAIL
       delete foreign key FK_AMPEPRED_RELATIONS_AMPEPREC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMPEPRED_RELATIONS_FINANCYC') then
    alter table AMPEPREDETAIL
       delete foreign key FK_AMPEPRED_RELATIONS_FINANCYC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMUSEINF_RELATIONS_PUBORGAN') then
    alter table AMUSEINFOR
       delete foreign key FK_AMUSEINF_RELATIONS_PUBORGAN
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMUSEINF_RELATIONS_PUBOBJEC') then
    alter table AMUSEINFOR
       delete foreign key FK_AMUSEINF_RELATIONS_PUBOBJEC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMUSEINF_RELATIONS_AMASSETI') then
    alter table AMUSEINFOR
       delete foreign key FK_AMUSEINF_RELATIONS_AMASSETI
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMUSEINF_RELATIONS_PUBPOSIT') then
    alter table AMUSEINFOR
       delete foreign key FK_AMUSEINF_RELATIONS_PUBPOSIT
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_AMUSEINF_RELATIONS_AMITEMUS') then
    alter table AMUSEINFOR
       delete foreign key FK_AMUSEINF_RELATIONS_AMITEMUS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_INSURANC_RELATIONS_AMASSETI') then
    alter table INSURANCEITEM
       delete foreign key FK_INSURANC_RELATIONS_AMASSETI
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_43_FK'
     and t.table_name='AMASSETITEM'
) then
   drop index AMASSETITEM.RELATIONSHIP_43_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_42_FK'
     and t.table_name='AMASSETITEM'
) then
   drop index AMASSETITEM.RELATIONSHIP_42_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_41_FK'
     and t.table_name='AMASSETITEM'
) then
   drop index AMASSETITEM.RELATIONSHIP_41_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMASSETITEM_PK'
     and t.table_name='AMASSETITEM'
) then
   drop index AMASSETITEM.AMASSETITEM_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMASSETITEM'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMASSETITEM
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_44_FK'
     and t.table_name='AMCAPITAL'
) then
   drop index AMCAPITAL.RELATIONSHIP_44_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_5_FK'
     and t.table_name='AMCAPITAL'
) then
   drop index AMCAPITAL.RELATIONSHIP_5_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_4_FK'
     and t.table_name='AMCAPITAL'
) then
   drop index AMCAPITAL.RELATIONSHIP_4_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMCAPITAL_PK'
     and t.table_name='AMCAPITAL'
) then
   drop index AMCAPITAL.AMCAPITAL_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMCAPITAL'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMCAPITAL
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMCAPITALTYPE_PK'
     and t.table_name='AMCAPITALTYPE'
) then
   drop index AMCAPITALTYPE.AMCAPITALTYPE_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMCAPITALTYPE'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMCAPITALTYPE
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_32_FK'
     and t.table_name='AMDECREASE'
) then
   drop index AMDECREASE.RELATIONSHIP_32_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_30_FK'
     and t.table_name='AMDECREASE'
) then
   drop index AMDECREASE.RELATIONSHIP_30_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_29_FK'
     and t.table_name='AMDECREASE'
) then
   drop index AMDECREASE.RELATIONSHIP_29_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_24_FK'
     and t.table_name='AMDECREASE'
) then
   drop index AMDECREASE.RELATIONSHIP_24_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMDECREASE_PK'
     and t.table_name='AMDECREASE'
) then
   drop index AMDECREASE.AMDECREASE_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMDECREASE'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMDECREASE
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_36_FK'
     and t.table_name='AMDECREASEDETAIL'
) then
   drop index AMDECREASEDETAIL.RELATIONSHIP_36_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_35_FK'
     and t.table_name='AMDECREASEDETAIL'
) then
   drop index AMDECREASEDETAIL.RELATIONSHIP_35_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_34_FK'
     and t.table_name='AMDECREASEDETAIL'
) then
   drop index AMDECREASEDETAIL.RELATIONSHIP_34_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_33_FK'
     and t.table_name='AMDECREASEDETAIL'
) then
   drop index AMDECREASEDETAIL.RELATIONSHIP_33_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_31_FK'
     and t.table_name='AMDECREASEDETAIL'
) then
   drop index AMDECREASEDETAIL.RELATIONSHIP_31_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_27_FK'
     and t.table_name='AMDECREASEDETAIL'
) then
   drop index AMDECREASEDETAIL.RELATIONSHIP_27_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMDECREASEDETAIL_PK'
     and t.table_name='AMDECREASEDETAIL'
) then
   drop index AMDECREASEDETAIL.AMDECREASEDETAIL_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMDECREASEDETAIL'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMDECREASEDETAIL
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMDEPMETHOD_PK'
     and t.table_name='AMDEPMETHOD'
) then
   drop index AMDEPMETHOD.AMDEPMETHOD_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMDEPMETHOD'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMDEPMETHOD
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_67_FK'
     and t.table_name='AMENTRY'
) then
   drop index AMENTRY.RELATIONSHIP_67_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_66_FK'
     and t.table_name='AMENTRY'
) then
   drop index AMENTRY.RELATIONSHIP_66_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_65_FK'
     and t.table_name='AMENTRY'
) then
   drop index AMENTRY.RELATIONSHIP_65_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_64_FK'
     and t.table_name='AMENTRY'
) then
   drop index AMENTRY.RELATIONSHIP_64_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_63_FK'
     and t.table_name='AMENTRY'
) then
   drop index AMENTRY.RELATIONSHIP_63_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_62_FK'
     and t.table_name='AMENTRY'
) then
   drop index AMENTRY.RELATIONSHIP_62_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMENTRY_PK'
     and t.table_name='AMENTRY'
) then
   drop index AMENTRY.AMENTRY_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMENTRY'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMENTRY
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_60_FK'
     and t.table_name='AMEVALUATION'
) then
   drop index AMEVALUATION.RELATIONSHIP_60_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_56_FK'
     and t.table_name='AMEVALUATION'
) then
   drop index AMEVALUATION.RELATIONSHIP_56_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_50_FK'
     and t.table_name='AMEVALUATION'
) then
   drop index AMEVALUATION.RELATIONSHIP_50_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_37_FK'
     and t.table_name='AMEVALUATION'
) then
   drop index AMEVALUATION.RELATIONSHIP_37_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMEVALUATION_PK'
     and t.table_name='AMEVALUATION'
) then
   drop index AMEVALUATION.AMEVALUATION_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMEVALUATION'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMEVALUATION
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_39_FK'
     and t.table_name='AMEVALUATIONDETAIL'
) then
   drop index AMEVALUATIONDETAIL.RELATIONSHIP_39_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_38_FK'
     and t.table_name='AMEVALUATIONDETAIL'
) then
   drop index AMEVALUATIONDETAIL.RELATIONSHIP_38_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_28_FK'
     and t.table_name='AMEVALUATIONDETAIL'
) then
   drop index AMEVALUATIONDETAIL.RELATIONSHIP_28_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMEVALUATIONDETAIL_PK'
     and t.table_name='AMEVALUATIONDETAIL'
) then
   drop index AMEVALUATIONDETAIL.AMEVALUATIONDETAIL_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMEVALUATIONDETAIL'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMEVALUATIONDETAIL
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_25_FK'
     and t.table_name='AMINCREASE'
) then
   drop index AMINCREASE.RELATIONSHIP_25_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_23_FK'
     and t.table_name='AMINCREASE'
) then
   drop index AMINCREASE.RELATIONSHIP_23_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='TRANG_THAI_FK'
     and t.table_name='AMINCREASE'
) then
   drop index AMINCREASE.TRANG_THAI_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_21_FK'
     and t.table_name='AMINCREASE'
) then
   drop index AMINCREASE.RELATIONSHIP_21_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMINCREASE_PK'
     and t.table_name='AMINCREASE'
) then
   drop index AMINCREASE.AMINCREASE_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMINCREASE'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMINCREASE
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_26_FK'
     and t.table_name='AMINCREASEDETAIL'
) then
   drop index AMINCREASEDETAIL.RELATIONSHIP_26_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_17_FK'
     and t.table_name='AMINCREASEDETAIL'
) then
   drop index AMINCREASEDETAIL.RELATIONSHIP_17_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_16_FK'
     and t.table_name='AMINCREASEDETAIL'
) then
   drop index AMINCREASEDETAIL.RELATIONSHIP_16_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_2_FK'
     and t.table_name='AMINCREASEDETAIL'
) then
   drop index AMINCREASEDETAIL.RELATIONSHIP_2_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMINCREASEDETAIL_PK'
     and t.table_name='AMINCREASEDETAIL'
) then
   drop index AMINCREASEDETAIL.AMINCREASEDETAIL_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMINCREASEDETAIL'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMINCREASEDETAIL
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMITEMUSEPURPOSE_PK'
     and t.table_name='AMITEMUSEPURPOSE'
) then
   drop index AMITEMUSEPURPOSE.AMITEMUSEPURPOSE_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMITEMUSEPURPOSE'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMITEMUSEPURPOSE
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_73_FK'
     and t.table_name='AMPEPREBUS'
) then
   drop index AMPEPREBUS.RELATIONSHIP_73_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_70_FK'
     and t.table_name='AMPEPREBUS'
) then
   drop index AMPEPREBUS.RELATIONSHIP_70_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_69_FK'
     and t.table_name='AMPEPREBUS'
) then
   drop index AMPEPREBUS.RELATIONSHIP_69_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_68_FK'
     and t.table_name='AMPEPREBUS'
) then
   drop index AMPEPREBUS.RELATIONSHIP_68_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMPEPREBUS_PK'
     and t.table_name='AMPEPREBUS'
) then
   drop index AMPEPREBUS.AMPEPREBUS_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMPEPREBUS'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMPEPREBUS
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_76_FK'
     and t.table_name='AMPEPREBUSDETAIL'
) then
   drop index AMPEPREBUSDETAIL.RELATIONSHIP_76_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_75_FK'
     and t.table_name='AMPEPREBUSDETAIL'
) then
   drop index AMPEPREBUSDETAIL.RELATIONSHIP_75_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_74_FK'
     and t.table_name='AMPEPREBUSDETAIL'
) then
   drop index AMPEPREBUSDETAIL.RELATIONSHIP_74_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_72_FK'
     and t.table_name='AMPEPREBUSDETAIL'
) then
   drop index AMPEPREBUSDETAIL.RELATIONSHIP_72_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_71_FK'
     and t.table_name='AMPEPREBUSDETAIL'
) then
   drop index AMPEPREBUSDETAIL.RELATIONSHIP_71_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMPEPREBUSDETAIL_PK'
     and t.table_name='AMPEPREBUSDETAIL'
) then
   drop index AMPEPREBUSDETAIL.AMPEPREBUSDETAIL_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMPEPREBUSDETAIL'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMPEPREBUSDETAIL
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_77_FK'
     and t.table_name='AMPEPRECIATION'
) then
   drop index AMPEPRECIATION.RELATIONSHIP_77_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_57_FK'
     and t.table_name='AMPEPRECIATION'
) then
   drop index AMPEPRECIATION.RELATIONSHIP_57_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_55_FK'
     and t.table_name='AMPEPRECIATION'
) then
   drop index AMPEPRECIATION.RELATIONSHIP_55_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_49_FK'
     and t.table_name='AMPEPRECIATION'
) then
   drop index AMPEPRECIATION.RELATIONSHIP_49_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMPEPRECIATION_PK'
     and t.table_name='AMPEPRECIATION'
) then
   drop index AMPEPRECIATION.AMPEPRECIATION_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMPEPRECIATION'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMPEPRECIATION
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_54_FK'
     and t.table_name='AMPEPRECOSTPRICE'
) then
   drop index AMPEPRECOSTPRICE.RELATIONSHIP_54_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_53_FK'
     and t.table_name='AMPEPRECOSTPRICE'
) then
   drop index AMPEPRECOSTPRICE.RELATIONSHIP_53_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_52_FK'
     and t.table_name='AMPEPRECOSTPRICE'
) then
   drop index AMPEPRECOSTPRICE.RELATIONSHIP_52_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_51_FK'
     and t.table_name='AMPEPRECOSTPRICE'
) then
   drop index AMPEPRECOSTPRICE.RELATIONSHIP_51_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMPEPRECOSTPRICE_PK'
     and t.table_name='AMPEPRECOSTPRICE'
) then
   drop index AMPEPRECOSTPRICE.AMPEPRECOSTPRICE_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMPEPRECOSTPRICE'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMPEPRECOSTPRICE
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_58_FK'
     and t.table_name='AMPEPREDETAIL'
) then
   drop index AMPEPREDETAIL.RELATIONSHIP_58_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_3_FK'
     and t.table_name='AMPEPREDETAIL'
) then
   drop index AMPEPREDETAIL.RELATIONSHIP_3_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMPEPREDETAIL_PK'
     and t.table_name='AMPEPREDETAIL'
) then
   drop index AMPEPREDETAIL.AMPEPREDETAIL_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMPEPREDETAIL'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMPEPREDETAIL
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMREASON_PK'
     and t.table_name='AMREASON'
) then
   drop index AMREASON.AMREASON_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMREASON'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMREASON
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMTASSETGROUP_PK'
     and t.table_name='AMTASSETGROUP'
) then
   drop index AMTASSETGROUP.AMTASSETGROUP_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMTASSETGROUP'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMTASSETGROUP
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_61_FK'
     and t.table_name='AMUSEINFOR'
) then
   drop index AMUSEINFOR.RELATIONSHIP_61_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_48_FK'
     and t.table_name='AMUSEINFOR'
) then
   drop index AMUSEINFOR.RELATIONSHIP_48_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_47_FK'
     and t.table_name='AMUSEINFOR'
) then
   drop index AMUSEINFOR.RELATIONSHIP_47_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_46_FK'
     and t.table_name='AMUSEINFOR'
) then
   drop index AMUSEINFOR.RELATIONSHIP_46_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_45_FK'
     and t.table_name='AMUSEINFOR'
) then
   drop index AMUSEINFOR.RELATIONSHIP_45_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='AMUSEINFOR_PK'
     and t.table_name='AMUSEINFOR'
) then
   drop index AMUSEINFOR.AMUSEINFOR_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='AMUSEINFOR'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table AMUSEINFOR
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='FINANCYCICLE_PK'
     and t.table_name='FINANCYCICLE'
) then
   drop index FINANCYCICLE.FINANCYCICLE_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='FINANCYCICLE'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table FINANCYCICLE
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_59_FK'
     and t.table_name='INSURANCEITEM'
) then
   drop index INSURANCEITEM.RELATIONSHIP_59_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='INSURANCEITEM_PK'
     and t.table_name='INSURANCEITEM'
) then
   drop index INSURANCEITEM.INSURANCEITEM_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='INSURANCEITEM'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table INSURANCEITEM
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='PUBACCOUNT_PK'
     and t.table_name='PUBACCOUNT'
) then
   drop index PUBACCOUNT.PUBACCOUNT_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBACCOUNT'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBACCOUNT
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='PUBBATCH_PK'
     and t.table_name='PUBBATCH'
) then
   drop index PUBBATCH.PUBBATCH_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBBATCH'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBBATCH
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='PUBCONTRACT_PK'
     and t.table_name='PUBCONTRACT'
) then
   drop index PUBCONTRACT.PUBCONTRACT_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBCONTRACT'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBCONTRACT
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='PUBCOSTPRICE_PK'
     and t.table_name='PUBCOSTPRICE'
) then
   drop index PUBCOSTPRICE.PUBCOSTPRICE_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBCOSTPRICE'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBCOSTPRICE
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='PUBCURRENCY_PK'
     and t.table_name='PUBCURRENCY'
) then
   drop index PUBCURRENCY.PUBCURRENCY_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBCURRENCY'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBCURRENCY
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='PUBDOCUMENT_PK'
     and t.table_name='PUBDOCUMENT'
) then
   drop index PUBDOCUMENT.PUBDOCUMENT_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBDOCUMENT'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBDOCUMENT
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='PUBDOCUMENTTYPE_PK'
     and t.table_name='PUBDOCUMENTTYPE'
) then
   drop index PUBDOCUMENTTYPE.PUBDOCUMENTTYPE_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBDOCUMENTTYPE'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBDOCUMENTTYPE
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='PUBITEMS_PK'
     and t.table_name='PUBITEMS'
) then
   drop index PUBITEMS.PUBITEMS_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBITEMS'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBITEMS
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='PUBOBJECT_PK'
     and t.table_name='PUBOBJECT'
) then
   drop index PUBOBJECT.PUBOBJECT_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBOBJECT'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBOBJECT
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='PUBORGANIZATION_PK'
     and t.table_name='PUBORGANIZATION'
) then
   drop index PUBORGANIZATION.PUBORGANIZATION_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBORGANIZATION'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBORGANIZATION
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='PUBPOSITION_PK'
     and t.table_name='PUBPOSITION'
) then
   drop index PUBPOSITION.PUBPOSITION_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBPOSITION'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBPOSITION
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='PUBSTATUS_PK'
     and t.table_name='PUBSTATUS'
) then
   drop index PUBSTATUS.PUBSTATUS_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBSTATUS'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBSTATUS
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='PUBUOM_PK'
     and t.table_name='PUBUOM'
) then
   drop index PUBUOM.PUBUOM_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBUOM'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBUOM
end if;

/*==============================================================*/
/* Table: AMASSETITEM                                           */
/*==============================================================*/
create table AMASSETITEM 
(
   ASI_AUTOID           integer                        not null,
   PIT_AUTOID           integer                        null,
   ACIG_AUTOID          smallint                       null,
   ST_AUTOID            smallint                       null,
   ASI_TYPE             smallint                       null,
   PIT_ITEMNO           nchar(10)                      null,
   ASI_ASSETITEMNO      nchar(10)                      null,
   PIT_ITEMNAME         nvarchar(200)                  null,
   ASI_DESCRIPTION      nvarchar(200)                  null,
   ASI_PRODUCTIONDATE   timestamp                      null,
   ASI_WARRANTYNU       smallint                       null,
   ASI_WARRANTYTYPE     smallint                       null,
   ASI_PRODUCTIONCOUNTRY nvarchar(200)                  null,
   ASI_FORM             smallint                       null,
   ASI_MANUFACTURER     nvarchar(100)                  null,
   IV_DOCUMENTID        integer                        null,
   PO_DOCUMENTID        integer                        null,
   OTHER_LSTDOCUMENNO   nchar(100)                     null,
   constraint PK_AMASSETITEM primary key (ASI_AUTOID)
);

comment on column AMASSETITEM.ST_AUTOID is 
'mã t? d?ng tang';

comment on column AMASSETITEM.ASI_TYPE is 
'Lo?i Tài s?n Công c? D?ng c?
tài s?n';

comment on column AMASSETITEM.PIT_ITEMNO is 
'Mã tài s?n';

comment on column AMASSETITEM.ASI_ASSETITEMNO is 
'Mã tài s?n';

comment on column AMASSETITEM.PIT_ITEMNAME is 
'Tên tài s?n';

comment on column AMASSETITEM.ASI_DESCRIPTION is 
'Di?n gi?i';

comment on column AMASSETITEM.ASI_WARRANTYNU is 
'S? b?o hành 
Exam : 12';

comment on column AMASSETITEM.ASI_WARRANTYTYPE is 
'Lo?i b?o hành
1 Nam
2 Tháng
3 ngày
4 Gi?';

comment on column AMASSETITEM.ASI_PRODUCTIONCOUNTRY is 
'Qu?c Gia So?n Xu?t';

comment on column AMASSETITEM.ASI_FORM is 
'hình th?c
huu hình 
vô hình';

comment on column AMASSETITEM.ASI_MANUFACTURER is 
'Nhà s?n xu?t';

comment on column AMASSETITEM.PO_DOCUMENTID is 
'PO mua hàng 
liên k?t PO';

/*==============================================================*/
/* Index: AMASSETITEM_PK                                        */
/*==============================================================*/
create unique index AMASSETITEM_PK on AMASSETITEM (
ASI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_41_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_41_FK on AMASSETITEM (
ST_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_42_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_42_FK on AMASSETITEM (
PIT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_43_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_43_FK on AMASSETITEM (
ACIG_AUTOID ASC
);

/*==============================================================*/
/* Table: AMCAPITAL                                             */
/*==============================================================*/
create table AMCAPITAL 
(
   ASO_AUTOID           smallint                       not null,
   ASI_AUTOID           integer                        null,
   ASS_AUTOID           smallint                       null,
   OBJ_AUTOID2          integer                        null,
   ASO_UNIT             nchar(10)                      null,
   ASO_AMOUNT           decimal(18,3)                  null,
   ASO_ISACTIVE         char(10)                       null,
   constraint PK_AMCAPITAL primary key (ASO_AUTOID)
);

comment on table AMCAPITAL is 
'Chi ti?t nguyên giá TS';

comment on column AMCAPITAL.OBJ_AUTOID2 is 
'mã d?i tu?ng t? d?ng tang';

comment on column AMCAPITAL.ASO_UNIT is 
'Ðon v?';

comment on column AMCAPITAL.ASO_AMOUNT is 
'S? ti?n';

/*==============================================================*/
/* Index: AMCAPITAL_PK                                          */
/*==============================================================*/
create unique index AMCAPITAL_PK on AMCAPITAL (
ASO_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_4_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_4_FK on AMCAPITAL (
ASS_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_5_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_5_FK on AMCAPITAL (
OBJ_AUTOID2 ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_44_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_44_FK on AMCAPITAL (
ASI_AUTOID ASC
);

/*==============================================================*/
/* Table: AMCAPITALTYPE                                         */
/*==============================================================*/
create table AMCAPITALTYPE 
(
   ASS_AUTOID           smallint                       not null,
   ASS_NAME             nchar(10)                      null,
   ASS_DESCRIPTION      nvarchar(200)                  null,
   ASS_ISACTIVE         smallint                       null,
   constraint PK_AMCAPITALTYPE primary key (ASS_AUTOID)
);

comment on table AMCAPITALTYPE is 
'Lo?i  Ngu?n v?n
chu ngu?n v?n
Vay';

comment on column AMCAPITALTYPE.ASS_NAME is 
'tên ngu?n v?n';

comment on column AMCAPITALTYPE.ASS_ISACTIVE is 
'kích ho?t ';

/*==============================================================*/
/* Index: AMCAPITALTYPE_PK                                      */
/*==============================================================*/
create unique index AMCAPITALTYPE_PK on AMCAPITALTYPE (
ASS_AUTOID ASC
);

/*==============================================================*/
/* Table: AMDECREASE                                            */
/*==============================================================*/
create table AMDECREASE 
(
   AMB_DOCUMENTID2      integer                        not null,
   ST_AUTOID            smallint                       null,
   DOTY_AUTOID          smallint                       null,
   FICI_AUTOID          smallint                       null,
   PUBAT_AUTOID         integer                        null,
   AMV_LISTDOCUMENT     nchar(200)                     null,
   AMV_ACCESSTYPE       smallint                       null,
   AMV_ISWRITE          smallint                       null,
   AMV_ISUSSING         smallint                       null,
   constraint PK_AMDECREASE primary key (AMB_DOCUMENTID2)
);

comment on table AMDECREASE is 
'nghi?p v? Gi?m tài s?n c? d?nh ';

comment on column AMDECREASE.ST_AUTOID is 
'mã t? d?ng tang';

comment on column AMDECREASE.DOTY_AUTOID is 
'Mã mình thêm vào';

comment on column AMDECREASE.PUBAT_AUTOID is 
'mã t? d?ng tang';

comment on column AMDECREASE.AMV_LISTDOCUMENT is 
'Ch?ng t? kèm theo';

comment on column AMDECREASE.AMV_ACCESSTYPE is 
'Lo?i Ch?ng t?
 1 Tài s?n c? d?nh
2 Công c? d?ng c?';

comment on column AMDECREASE.AMV_ISWRITE is 
'Ghi s? k? toán ?';

comment on column AMDECREASE.AMV_ISUSSING is 
'Có dang s? d?ng hay không
true : dang dung
false : ko dung nua';

/*==============================================================*/
/* Index: AMDECREASE_PK                                         */
/*==============================================================*/
create unique index AMDECREASE_PK on AMDECREASE (
AMB_DOCUMENTID2 ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_24_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_24_FK on AMDECREASE (
DOTY_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_29_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_29_FK on AMDECREASE (
ST_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_30_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_30_FK on AMDECREASE (
FICI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_32_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_32_FK on AMDECREASE (
PUBAT_AUTOID ASC
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
   AMB_DOCUMENTID2      integer                        null,
   RES_AUTOID           smallint                       null,
   OBJ_AUTOID2          integer                        null,
   PIT_ITEMNAME         nvarchar(200)                  null,
   PIT_ITEMNO           nchar(10)                      null,
   AED_AMOUNT           decimal(18,3)                  null,
   ADD_WEAR             char(10)                       null,
   ADD_FICIDEPRECIATION smallint                       null,
   ADD_REMAINAMOUNT     decimal(18,3)                  null,
   COT_LISTDOCUMENTNO   nchar(200)                     null,
   CON_LSTDOCUMENTNO    nchar(200)                     null,
   constraint PK_AMDECREASEDETAIL primary key (ADD_AUTOID)
);

comment on table AMDECREASEDETAIL is 
'chi ti?t nghi?p v? tài s?n c? d?nh ';

comment on column AMDECREASEDETAIL.ADD_AUTOID is 
'Mã t? tang';

comment on column AMDECREASEDETAIL.ST_AUTOID is 
'mã t? d?ng tang';

comment on column AMDECREASEDETAIL.ORG_AUTOID is 
'Mã t? ch?c - Mã Công ty - Mã Chi Nhánh - Mã Phòng ban';

comment on column AMDECREASEDETAIL.OBJ_AUTOID2 is 
'mã d?i tu?ng t? d?ng tang';

comment on column AMDECREASEDETAIL.PIT_ITEMNAME is 
'Tên tài s?n';

comment on column AMDECREASEDETAIL.PIT_ITEMNO is 
'Mã tài s?n';

comment on column AMDECREASEDETAIL.AED_AMOUNT is 
'nguyên giá tài s?n';

comment on column AMDECREASEDETAIL.ADD_WEAR is 
'hào mòn luy k?';

comment on column AMDECREASEDETAIL.ADD_FICIDEPRECIATION is 
's? k? dã kh?u hao';

comment on column AMDECREASEDETAIL.ADD_REMAINAMOUNT is 
's? ti?n còn l?i';

comment on column AMDECREASEDETAIL.COT_LISTDOCUMENTNO is 
'danh sách giá thành';

comment on column AMDECREASEDETAIL.CON_LSTDOCUMENTNO is 
'Danh Sách H?p Ð?ng
HD001;HD002';

/*==============================================================*/
/* Index: AMDECREASEDETAIL_PK                                   */
/*==============================================================*/
create unique index AMDECREASEDETAIL_PK on AMDECREASEDETAIL (
ADD_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_27_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_27_FK on AMDECREASEDETAIL (
AMB_DOCUMENTID2 ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_31_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_31_FK on AMDECREASEDETAIL (
ORG_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_33_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_33_FK on AMDECREASEDETAIL (
OBJ_AUTOID2 ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_34_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_34_FK on AMDECREASEDETAIL (
ST_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_35_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_35_FK on AMDECREASEDETAIL (
RES_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_36_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_36_FK on AMDECREASEDETAIL (
PIT_AUTOID ASC
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

comment on table AMDEPMETHOD is 
'Phuong pháp kh?u hao';

/*==============================================================*/
/* Index: AMDEPMETHOD_PK                                        */
/*==============================================================*/
create unique index AMDEPMETHOD_PK on AMDEPMETHOD (
ADM_AUTOID ASC
);

/*==============================================================*/
/* Table: AMENTRY                                               */
/*==============================================================*/
create table AMENTRY 
(
   AME_AUTOID           integer                        not null,
   DOC_DOCUMENTID       integer                        null,
   CP_AUTOID            integer                        null,
   OBJ_AUTOID2          integer                        null,
   CUR_AUTOID           smallint                       null,
   COT_AUTOID           integer                        null,
   ASI_AUTOID           integer                        null,
   ACC_DEPT             nchar(10)                      null,
   ACC_CREDIT           nchar(10)                      null,
   AME_AMOUNT           decimal(18,3)                  null,
   CUR_EXCHANGERATE     decimal(4,2)                   null,
   AME_BASEAMOUNT       decimal(18,3)                  null,
   AME_NOTE             nvarchar(200)                  null,
   PO_DOCUMENTID        integer                        null,
   constraint PK_AMENTRY primary key (AME_AUTOID)
);

comment on table AMENTRY is 
'Hách Toán cho AM';

comment on column AMENTRY.OBJ_AUTOID2 is 
'mã d?i tu?ng t? d?ng tang';

comment on column AMENTRY.COT_AUTOID is 
'Mã Id t? d?ng tang';

comment on column AMENTRY.ACC_DEPT is 
'tài kho?n n?';

comment on column AMENTRY.ACC_CREDIT is 
'tài kho?n có';

comment on column AMENTRY.PO_DOCUMENTID is 
'PO mua hàng 
liên k?t PO';

/*==============================================================*/
/* Index: AMENTRY_PK                                            */
/*==============================================================*/
create unique index AMENTRY_PK on AMENTRY (
AME_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_62_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_62_FK on AMENTRY (
ASI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_63_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_63_FK on AMENTRY (
OBJ_AUTOID2 ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_64_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_64_FK on AMENTRY (
CUR_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_65_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_65_FK on AMENTRY (
COT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_66_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_66_FK on AMENTRY (
CP_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_67_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_67_FK on AMENTRY (
DOC_DOCUMENTID ASC
);

/*==============================================================*/
/* Table: AMEVALUATION                                          */
/*==============================================================*/
create table AMEVALUATION 
(
   AMB_DOCUMENTID3      integer                        not null,
   DOTY_AUTOID          smallint                       null,
   ST_AUTOID            smallint                       null,
   PUBAT_AUTOID         integer                        null,
   FICI_AUTOID          smallint                       null,
   AMV_LISTDOCUMENT     nchar(200)                     null,
   AMV_ACCESSTYPE       smallint                       null,
   AMV_ISWRITE          smallint                       null,
   AMV_ISUSSING         smallint                       null,
   constraint PK_AMEVALUATION primary key (AMB_DOCUMENTID3)
);

comment on table AMEVALUATION is 
'nghi?p v? Gi?m tài s?n c? d?nh ';

comment on column AMEVALUATION.DOTY_AUTOID is 
'Mã mình thêm vào';

comment on column AMEVALUATION.ST_AUTOID is 
'mã t? d?ng tang';

comment on column AMEVALUATION.PUBAT_AUTOID is 
'mã t? d?ng tang';

comment on column AMEVALUATION.AMV_LISTDOCUMENT is 
'Ch?ng t? kèm theo';

comment on column AMEVALUATION.AMV_ACCESSTYPE is 
'Lo?i Ch?ng t?
 1 Tài s?n c? d?nh
2 Công c? d?ng c?';

comment on column AMEVALUATION.AMV_ISWRITE is 
'Ghi s? k? toán ?';

comment on column AMEVALUATION.AMV_ISUSSING is 
'Có dang s? d?ng hay không
true : dang dung
false : ko dung nua';

/*==============================================================*/
/* Index: AMEVALUATION_PK                                       */
/*==============================================================*/
create unique index AMEVALUATION_PK on AMEVALUATION (
AMB_DOCUMENTID3 ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_37_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_37_FK on AMEVALUATION (
DOTY_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_50_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_50_FK on AMEVALUATION (
PUBAT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_56_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_56_FK on AMEVALUATION (
FICI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_60_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_60_FK on AMEVALUATION (
ST_AUTOID ASC
);

/*==============================================================*/
/* Table: AMEVALUATIONDETAIL                                    */
/*==============================================================*/
create table AMEVALUATIONDETAIL 
(
   AED_AUTOID           integer                        not null,
   AMB_DOCUMENTID3      integer                        null,
   ORG_AUTOID           integer                        null,
   RES_AUTOID           smallint                       null,
   AED_AMOUNT           decimal(18,3)                  null,
   AED_WEAR             decimal(18,3)                  null,
   AED_FICIDEPRECIATION smallint                       null,
   AED_REMAINAMOUNT     decimal(18,3)                  null,
   AED_ISEDIT           smallint                       null,
   AED_STOPDATE         timestamp                      null,
   AED_CORRUPTDATE      timestamp                      null,
   AED_CORRUPTDESCRIPTION nvarchar(200)                  null,
   AED_EDITAMOUNT       char(10)                       null,
   AED_EDITWEAR         decimal(18,3)                  null,
   AED_EDITFICIDEPRECIATION smallint                       null,
   AED_EDITREMAINAMOUNT decimal(18,3)                  null,
   constraint PK_AMEVALUATIONDETAIL primary key (AED_AUTOID)
);

comment on table AMEVALUATIONDETAIL is 
'chi ti?t nghi?p v? tài s?n c? d?nh ';

comment on column AMEVALUATIONDETAIL.AED_AUTOID is 
'Mã t? tang';

comment on column AMEVALUATIONDETAIL.ORG_AUTOID is 
'Mã t? ch?c - Mã Công ty - Mã Chi Nhánh - Mã Phòng ban';

comment on column AMEVALUATIONDETAIL.AED_AMOUNT is 
'nguyên giá tài s?n';

comment on column AMEVALUATIONDETAIL.AED_WEAR is 
'hao mòn luy k?';

comment on column AMEVALUATIONDETAIL.AED_FICIDEPRECIATION is 
'S? k? dã kh?u hao kh?u hao';

comment on column AMEVALUATIONDETAIL.AED_REMAINAMOUNT is 
'giá tr? còn l?i';

comment on column AMEVALUATIONDETAIL.AED_ISEDIT is 
'Ðu?c di?u ch?nh';

comment on column AMEVALUATIONDETAIL.AED_STOPDATE is 
'ngày ngùng kh?u hao';

comment on column AMEVALUATIONDETAIL.AED_CORRUPTDESCRIPTION is 
'mô t? hu h?ng';

comment on column AMEVALUATIONDETAIL.AED_EDITAMOUNT is 
'nguyên giá di?u ch?nh';

comment on column AMEVALUATIONDETAIL.AED_EDITWEAR is 
'hao mòn luy k? di?u ch?nh';

comment on column AMEVALUATIONDETAIL.AED_EDITFICIDEPRECIATION is 
'S? k? kh?u hao di?u ch?nh';

comment on column AMEVALUATIONDETAIL.AED_EDITREMAINAMOUNT is 
'Giá tr? còn lai ÐC';

/*==============================================================*/
/* Index: AMEVALUATIONDETAIL_PK                                 */
/*==============================================================*/
create unique index AMEVALUATIONDETAIL_PK on AMEVALUATIONDETAIL (
AED_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_28_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_28_FK on AMEVALUATIONDETAIL (
AMB_DOCUMENTID3 ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_38_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_38_FK on AMEVALUATIONDETAIL (
ORG_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_39_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_39_FK on AMEVALUATIONDETAIL (
RES_AUTOID ASC
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
   AMV_LISTDOCUMENT     nchar(200)                     null,
   AMV_ACCESSTYPE       smallint                       null,
   AMV_ISWRITE          smallint                       null,
   AMV_ISUSSING         smallint                       null,
   constraint PK_AMINCREASE primary key (ABI_DOCUMENTID)
);

comment on table AMINCREASE is 
'nghi?p v? tang tài s?n c? d?nh ';

comment on column AMINCREASE.PUBAT_AUTOID is 
'mã t? d?ng tang';

comment on column AMINCREASE.DOTY_AUTOID is 
'Mã mình thêm vào';

comment on column AMINCREASE.ST_AUTOID is 
'mã t? d?ng tang';

comment on column AMINCREASE.AMV_LISTDOCUMENT is 
'Ch?ng t? kèm theo';

comment on column AMINCREASE.AMV_ACCESSTYPE is 
'Lo?i Ch?ng t?
 1 Tài s?n c? d?nh
2 Công c? d?ng c?';

comment on column AMINCREASE.AMV_ISWRITE is 
'Ghi s? k? toán ?';

comment on column AMINCREASE.AMV_ISUSSING is 
'Có dang s? d?ng hay không
true : dang dung
false : ko dung nua';

/*==============================================================*/
/* Index: AMINCREASE_PK                                         */
/*==============================================================*/
create unique index AMINCREASE_PK on AMINCREASE (
ABI_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_21_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_21_FK on AMINCREASE (
PUBAT_AUTOID ASC
);

/*==============================================================*/
/* Index: TRANG_THAI_FK                                         */
/*==============================================================*/
create index TRANG_THAI_FK on AMINCREASE (
ST_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_23_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_23_FK on AMINCREASE (
FICI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_25_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_25_FK on AMINCREASE (
DOTY_AUTOID ASC
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
   PIT_ITEMNO           nchar(10)                      null,
   AED_QUANTITY         decimal(10,3)                  null,
   AED_AMOUNT           decimal(18,3)                  null,
   AED_TOTALAMOUNT      decimal(18,3)                  null,
   PO_DOCUMENTID        integer                        null,
   IC_DOCUMENTID        nchar(100)                     null,
   PAY_DOCUMENTID       nchar(100)                     null,
   AED_ISCREATEDDEP     smallint                       null,
   constraint PK_AMINCREASEDETAIL primary key (ABID_AUTOID)
);

comment on table AMINCREASEDETAIL is 
'chi ti?t nghi?p v? tài s?n c? d?nh ';

comment on column AMINCREASEDETAIL.ABID_AUTOID is 
'Mã t? tang';

comment on column AMINCREASEDETAIL.PIT_ITEMNAME is 
'Tên tài s?n';

comment on column AMINCREASEDETAIL.PIT_ITEMNO is 
'Mã tài s?n';

comment on column AMINCREASEDETAIL.AED_QUANTITY is 
'S? lu?ng';

comment on column AMINCREASEDETAIL.AED_AMOUNT is 
'nguyên giá tài s?n';

comment on column AMINCREASEDETAIL.AED_TOTALAMOUNT is 
'Nguyên giá khi phân b?';

comment on column AMINCREASEDETAIL.PO_DOCUMENTID is 
'PO mua hàng 
liên k?t PO';

comment on column AMINCREASEDETAIL.IC_DOCUMENTID is 
'Ch?ng t? nh?p kho';

comment on column AMINCREASEDETAIL.PAY_DOCUMENTID is 
'CT Thanh toán';

comment on column AMINCREASEDETAIL.AED_ISCREATEDDEP is 
'Is Depreciation Create
Ðu?c l?p kh?u hao';

/*==============================================================*/
/* Index: AMINCREASEDETAIL_PK                                   */
/*==============================================================*/
create unique index AMINCREASEDETAIL_PK on AMINCREASEDETAIL (
ABID_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_2_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_2_FK on AMINCREASEDETAIL (
ABI_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_16_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_16_FK on AMINCREASEDETAIL (
RES_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_17_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_17_FK on AMINCREASEDETAIL (
PIT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_26_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_26_FK on AMINCREASEDETAIL (
UOM_AUTOID ASC
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

comment on table AMITEMUSEPURPOSE is 
'M?c dích s? d?ng';

/*==============================================================*/
/* Index: AMITEMUSEPURPOSE_PK                                   */
/*==============================================================*/
create unique index AMITEMUSEPURPOSE_PK on AMITEMUSEPURPOSE (
AIUP_AUTOID ASC
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
   APB_DOCUMENTNO       nchar(20)                      null,
   APB_AMOUNT           decimal(18,3)                  null,
   constraint PK_AMPEPREBUS primary key (APB_DOCUMENTID)
);

comment on table AMPEPREBUS is 
'ch?ng t? kh?u hao du?c chay theo cuoi k? du?c k?t s?';

comment on column AMPEPREBUS.PUBAT_AUTOID is 
'mã t? d?ng tang';

comment on column AMPEPREBUS.ST_AUTOID is 
'mã t? d?ng tang';

comment on column AMPEPREBUS.APB_AMOUNT is 
'TONG TIEN';

/*==============================================================*/
/* Index: AMPEPREBUS_PK                                         */
/*==============================================================*/
create unique index AMPEPREBUS_PK on AMPEPREBUS (
APB_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_68_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_68_FK on AMPEPREBUS (
PUBAT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_69_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_69_FK on AMPEPREBUS (
FICI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_70_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_70_FK on AMPEPREBUS (
CUR_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_73_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_73_FK on AMPEPREBUS (
ST_AUTOID ASC
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
   PIT_ITEMNO           nchar(10)                      null,
   PIT_ITEMNAME         nvarchar(200)                  null,
   ASI_ASSETITEMNO      nchar(10)                      null,
   ASI_TYPE             smallint                       null,
   APBD_BASEAMOUNT      decimal(18,3)                  null,
   APBD_NOTE            nvarchar(100)                  null,
   constraint PK_AMPEPREBUSDETAIL primary key (APBD_AUTOID)
);

comment on column AMPEPREBUSDETAIL.ORG_AUTOID is 
'Mã t? ch?c - Mã Công ty - Mã Chi Nhánh - Mã Phòng ban';

comment on column AMPEPREBUSDETAIL.COT_AUTOID is 
'Mã Id t? d?ng tang';

comment on column AMPEPREBUSDETAIL.PIT_ITEMNO is 
'Mã tài s?n';

comment on column AMPEPREBUSDETAIL.PIT_ITEMNAME is 
'Tên tài s?n';

comment on column AMPEPREBUSDETAIL.ASI_ASSETITEMNO is 
'Mã tài s?n';

comment on column AMPEPREBUSDETAIL.ASI_TYPE is 
'Lo?i Tài s?n Công c? D?ng c?
tài s?n';

/*==============================================================*/
/* Index: AMPEPREBUSDETAIL_PK                                   */
/*==============================================================*/
create unique index AMPEPREBUSDETAIL_PK on AMPEPREBUSDETAIL (
APBD_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_71_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_71_FK on AMPEPREBUSDETAIL (
APB_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_72_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_72_FK on AMPEPREBUSDETAIL (
ASI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_74_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_74_FK on AMPEPREBUSDETAIL (
ORG_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_75_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_75_FK on AMPEPREBUSDETAIL (
COT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_76_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_76_FK on AMPEPREBUSDETAIL (
CP_AUTOID ASC
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
   ASI_ASSETITEMNO      nchar(10)                      null,
   AMP_AMOUNT           char(10)                       null,
   AMP_BEGINDATE        date                           null,
   AMP_WEAR             decimal(18,3)                  null,
   FICI_NUMBER          smallint                       null,
   ACC_ORIACCOUNT       nchar(10)                      null,
   ACC_WEARACCOUNT      nchar(10)                      null,
   ACC_COSTACCOUNT      nchar(10)                      null,
   constraint PK_AMPEPRECIATION primary key (AMP_AUTOID)
);

comment on table AMPEPRECIATION is 
'kh?u hao tài s?n';

comment on column AMPEPRECIATION.ASI_ASSETITEMNO is 
'Mã tài s?n';

comment on column AMPEPRECIATION.AMP_AMOUNT is 
'nguyên giá';

comment on column AMPEPRECIATION.AMP_BEGINDATE is 
'ngày b?t d?u';

comment on column AMPEPRECIATION.AMP_WEAR is 
'hao mòn luy k?
SpendtimeAttrition';

comment on column AMPEPRECIATION.FICI_NUMBER is 
'S? k? du?c kh?u hao';

comment on column AMPEPRECIATION.ACC_ORIACCOUNT is 
'TK Nguyên Giá
OriginalPriceAccount';

comment on column AMPEPRECIATION.ACC_WEARACCOUNT is 
'TK hao mòn
';

comment on column AMPEPRECIATION.ACC_COSTACCOUNT is 
'tài kho?n chi phí kh?u hao';

/*==============================================================*/
/* Index: AMPEPRECIATION_PK                                     */
/*==============================================================*/
create unique index AMPEPRECIATION_PK on AMPEPRECIATION (
AMP_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_49_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_49_FK on AMPEPRECIATION (
ASI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_55_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_55_FK on AMPEPRECIATION (
ADM_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_57_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_57_FK on AMPEPRECIATION (
FICI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_77_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_77_FK on AMPEPRECIATION (
CP_AUTOID ASC
);

/*==============================================================*/
/* Table: AMPEPRECOSTPRICE                                      */
/*==============================================================*/
create table AMPEPRECOSTPRICE 
(
   APC_AUTOID           integer                        not null,
   ASPD_AUTOID          integer                        null,
   CP_AUTOID            integer                        null,
   ACC_CODE             nchar(10)                      null,
   COT_AUTOID           integer                        null,
   APC_PERCENT          decimal(5,2)                   null,
   ACC_ACCOUNTCOST      nchar(10)                      null,
   constraint PK_AMPEPRECOSTPRICE primary key (APC_AUTOID)
);

comment on table AMPEPRECOSTPRICE is 
'Kh?u hao giá thành';

comment on column AMPEPRECOSTPRICE.ACC_CODE is 
'Ma tai khoan';

comment on column AMPEPRECOSTPRICE.COT_AUTOID is 
'Mã Id t? d?ng tang';

comment on column AMPEPRECOSTPRICE.APC_PERCENT is 
'% kh?u hao';

/*==============================================================*/
/* Index: AMPEPRECOSTPRICE_PK                                   */
/*==============================================================*/
create unique index AMPEPRECOSTPRICE_PK on AMPEPRECOSTPRICE (
APC_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_51_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_51_FK on AMPEPRECOSTPRICE (
ASPD_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_52_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_52_FK on AMPEPRECOSTPRICE (
CP_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_53_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_53_FK on AMPEPRECOSTPRICE (
COT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_54_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_54_FK on AMPEPRECOSTPRICE (
ACC_CODE ASC
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
   ASPD_ISPEPRE         smallint                       null default 1,
   constraint PK_AMPEPREDETAIL primary key (ASPD_AUTOID)
);

comment on table AMPEPREDETAIL is 
'chi ti?t phân b? kh?u hao ch?a các kh?u hao theo kì tài chính 

';

comment on column AMPEPREDETAIL.ASPD_AMOUNT is 
'S? ti?n kh?u hao trong k? này';

comment on column AMPEPREDETAIL.ASPD_ISPEPRE is 
'Ðã kh?u hao';

/*==============================================================*/
/* Index: AMPEPREDETAIL_PK                                      */
/*==============================================================*/
create unique index AMPEPREDETAIL_PK on AMPEPREDETAIL (
ASPD_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_3_FK on AMPEPREDETAIL (
AMP_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_58_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_58_FK on AMPEPREDETAIL (
FICI_AUTOID ASC
);

/*==============================================================*/
/* Table: AMREASON                                              */
/*==============================================================*/
create table AMREASON 
(
   RES_AUTOID           smallint                       not null,
   RES_RESIONID         nchar(10)                      null,
   RES_RESIONNAME       nvarchar(200)                  null,
   RES_BUSSINES         smallint                       null,
   RES_DESCRIPTION      nvarchar(200)                  null,
   RES_ISACTIVE         smallint                       null,
   constraint PK_AMREASON primary key (RES_AUTOID)
);

comment on table AMREASON is 
'Danh m?c Lý do';

comment on column AMREASON.RES_BUSSINES is 
'nghi?p v? 
1 Tang
2 Gi?m
3  Ðánh giá';

/*==============================================================*/
/* Index: AMREASON_PK                                           */
/*==============================================================*/
create unique index AMREASON_PK on AMREASON (
RES_AUTOID ASC
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
   ACC_ORIACCOUNT       nchar(10)                      null,
   ACC_WEARACCOUNT      nchar(10)                      null,
   ACC_COSTPRICEACCOUNT nchar(10)                      null,
   ACC_SOURCEACCOUNT    nchar(10)                      null,
   YEAR_NUMBER          smallint                       null,
   constraint PK_AMTASSETGROUP primary key (ACIG_AUTOID)
);

comment on table AMTASSETGROUP is 
'Nhóm tài s?n Dùng cho Item 
cho khách hàng t? nh?p';

comment on column AMTASSETGROUP.ACC_ORIACCOUNT is 
'TK Nguyên Giá
OriginalPriceAccount';

comment on column AMTASSETGROUP.ACC_WEARACCOUNT is 
'TK hao mòn
';

comment on column AMTASSETGROUP.ACC_COSTPRICEACCOUNT is 
'Tài kho?n chi phí';

comment on column AMTASSETGROUP.ACC_SOURCEACCOUNT is 
'tài khoan Góp v?n';

comment on column AMTASSETGROUP.YEAR_NUMBER is 
'S? nam kh?u hao';

/*==============================================================*/
/* Index: AMTASSETGROUP_PK                                      */
/*==============================================================*/
create unique index AMTASSETGROUP_PK on AMTASSETGROUP (
ACIG_AUTOID ASC
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
   OBJ_AUTOID2          integer                        null,
   AUI_NOTE             nvarchar(200)                  null,
   constraint PK_AMUSEINFOR primary key (AUI_AUTOID)
);

comment on table AMUSEINFOR is 
'Thông tin s? d?ng cho Item';

comment on column AMUSEINFOR.ORG_AUTOID is 
'Mã t? ch?c - Mã Công ty - Mã Chi Nhánh - Mã Phòng ban';

comment on column AMUSEINFOR.OBJ_AUTOID2 is 
'mã d?i tu?ng t? d?ng tang';

comment on column AMUSEINFOR.AUI_NOTE is 
'Ghi chú';

/*==============================================================*/
/* Index: AMUSEINFOR_PK                                         */
/*==============================================================*/
create unique index AMUSEINFOR_PK on AMUSEINFOR (
AUI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_45_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_45_FK on AMUSEINFOR (
ORG_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_46_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_46_FK on AMUSEINFOR (
OBJ_AUTOID2 ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_47_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_47_FK on AMUSEINFOR (
ASI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_48_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_48_FK on AMUSEINFOR (
POS_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_61_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_61_FK on AMUSEINFOR (
AIUP_AUTOID ASC
);

/*==============================================================*/
/* Table: FINANCYCICLE                                          */
/*==============================================================*/
create table FINANCYCICLE 
(
   FICI_AUTOID          smallint                       not null,
   constraint PK_FINANCYCICLE primary key (FICI_AUTOID)
);

comment on table FINANCYCICLE is 
'kì tài chính';

/*==============================================================*/
/* Index: FINANCYCICLE_PK                                       */
/*==============================================================*/
create unique index FINANCYCICLE_PK on FINANCYCICLE (
FICI_AUTOID ASC
);

/*==============================================================*/
/* Table: INSURANCEITEM                                         */
/*==============================================================*/
create table INSURANCEITEM 
(
   INS_AUTOID           smallint                       not null,
   ASI_AUTOID           integer                        null,
   INS_INSUREID         nchar(10)                      null,
   INS_DESCRIPTION      nvarchar(200)                  null,
   INS_SERIAL           nchar(10)                      null,
   INS_SERDESCRIPTION   nvarchar(200)                  null,
   INS_TYPE             smallint                       null,
   INS_VALIDDATE        date                           null,
   INS_EXPIREDATE       date                           null,
   INS_PAYDATE          date                           null,
   INS_SO_TIEN_         decimal(18,3)                  null,
   INS_MININSURE        decimal(18,3)                  null,
   INS_MAXINSURE        decimal(18,3)                  null,
   INS_FILLEURL         nchar(200)                     null,
   constraint PK_INSURANCEITEM primary key (INS_AUTOID)
);

comment on table INSURANCEITEM is 
'b?o hi?m tài s?n';

comment on column INSURANCEITEM.INS_INSUREID is 
'mã b?o hi?m';

comment on column INSURANCEITEM.INS_DESCRIPTION is 
'm? t?';

comment on column INSURANCEITEM.INS_SERIAL is 
'S? serial';

comment on column INSURANCEITEM.INS_SERDESCRIPTION is 
'mô t? cho serial';

comment on column INSURANCEITEM.INS_TYPE is 
'Lo?i b?o hi?m';

comment on column INSURANCEITEM.INS_VALIDDATE is 
'ngày hi?u l?c';

comment on column INSURANCEITEM.INS_EXPIREDATE is 
' ngày h?t h?n';

comment on column INSURANCEITEM.INS_PAYDATE is 
' ngày dóng';

comment on column INSURANCEITEM.INS_SO_TIEN_ is 
'S? ti?n';

comment on column INSURANCEITEM.INS_MININSURE is 
'M?c BH t?i thi?u';

comment on column INSURANCEITEM.INS_MAXINSURE is 
'M?c b?o hi?m t?i da';

comment on column INSURANCEITEM.INS_FILLEURL is 
'URL t?i file';

/*==============================================================*/
/* Index: INSURANCEITEM_PK                                      */
/*==============================================================*/
create unique index INSURANCEITEM_PK on INSURANCEITEM (
INS_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_59_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_59_FK on INSURANCEITEM (
ASI_AUTOID ASC
);

/*==============================================================*/
/* Table: PUBACCOUNT                                            */
/*==============================================================*/
create table PUBACCOUNT 
(
   ACC_CODE             nchar(10)                      not null,
   constraint PK_PUBACCOUNT primary key (ACC_CODE)
);

comment on table PUBACCOUNT is 
'Tài kho?n h?ch toán';

comment on column PUBACCOUNT.ACC_CODE is 
'Ma tai khoan';

/*==============================================================*/
/* Index: PUBACCOUNT_PK                                         */
/*==============================================================*/
create unique index PUBACCOUNT_PK on PUBACCOUNT (
ACC_CODE ASC
);

/*==============================================================*/
/* Table: PUBBATCH                                              */
/*==============================================================*/
create table PUBBATCH 
(
   PUBAT_AUTOID         integer                        not null,
   PUBAT_DOCUMENTNO     nchar(15)                      null,
   PUBAT_BATCHNAME      nvarchar(100)                  null,
   PUBAT_CREATEDATE     timestamp                      null,
   PUBAT_CREATEBY       integer                        null,
   PUBAT_STATUS         smallint                       null,
   PUBAT_ISACTIVE       smallint                       null,
   PUBAT_ISPAYMENT      smallint                       null,
   PUBAT_ISWRITE        smallint                       null,
   constraint PK_PUBBATCH primary key (PUBAT_AUTOID)
);

comment on table PUBBATCH is 
'Nghi?p v? s? lý 
dành cho AR,Ap,CM,IC,FA';

comment on column PUBBATCH.PUBAT_AUTOID is 
'mã t? d?ng tang';

comment on column PUBBATCH.PUBAT_DOCUMENTNO is 
'Mã qu?n lý';

comment on column PUBBATCH.PUBAT_BATCHNAME is 
'Tên Nghi?p v?';

comment on column PUBBATCH.PUBAT_CREATEDATE is 
'ngày tao';

comment on column PUBBATCH.PUBAT_CREATEBY is 
'tao b?i user nào';

comment on column PUBBATCH.PUBAT_STATUS is 
'trang thai 
1 tao moi
2 ghi so tam
3 dã ghi s?
4 b? l?i
5 fixbug';

comment on column PUBBATCH.PUBAT_ISACTIVE is 
'du?c kích ho?t hay chua';

comment on column PUBBATCH.PUBAT_ISPAYMENT is 
'danh cho CM d? bi?t là Lô này là lô thu hay chi 
true : ch?ng t? chi 
false : ch?ng t? thu 
m?c d?nh là false';

comment on column PUBBATCH.PUBAT_ISWRITE is 
'Cho phép ghi s? hay không
dành cho IC';

/*==============================================================*/
/* Index: PUBBATCH_PK                                           */
/*==============================================================*/
create unique index PUBBATCH_PK on PUBBATCH (
PUBAT_AUTOID ASC
);

/*==============================================================*/
/* Table: PUBCONTRACT                                           */
/*==============================================================*/
create table PUBCONTRACT 
(
   COT_AUTOID           integer                        not null,
   constraint PK_PUBCONTRACT primary key (COT_AUTOID)
);

comment on table PUBCONTRACT is 
'h?p d?ng Nh? khi t?o thì mang ID c?a b?ng Document dem qua làm khóa c?a b?ng này ';

comment on column PUBCONTRACT.COT_AUTOID is 
'Mã Id t? d?ng tang';

/*==============================================================*/
/* Index: PUBCONTRACT_PK                                        */
/*==============================================================*/
create unique index PUBCONTRACT_PK on PUBCONTRACT (
COT_AUTOID ASC
);

/*==============================================================*/
/* Table: PUBCOSTPRICE                                          */
/*==============================================================*/
create table PUBCOSTPRICE 
(
   CP_AUTOID            integer                        not null,
   constraint PK_PUBCOSTPRICE primary key (CP_AUTOID)
);

/*==============================================================*/
/* Index: PUBCOSTPRICE_PK                                       */
/*==============================================================*/
create unique index PUBCOSTPRICE_PK on PUBCOSTPRICE (
CP_AUTOID ASC
);

/*==============================================================*/
/* Table: PUBCURRENCY                                           */
/*==============================================================*/
create table PUBCURRENCY 
(
   CUR_AUTOID           smallint                       not null,
   constraint PK_PUBCURRENCY primary key (CUR_AUTOID)
);

comment on table PUBCURRENCY is 
'B?ng  danh m?c ti?n t?';

/*==============================================================*/
/* Index: PUBCURRENCY_PK                                        */
/*==============================================================*/
create unique index PUBCURRENCY_PK on PUBCURRENCY (
CUR_AUTOID ASC
);

/*==============================================================*/
/* Table: PUBDOCUMENT                                           */
/*==============================================================*/
create table PUBDOCUMENT 
(
   DOC_DOCUMENTID       integer                        not null,
   constraint PK_PUBDOCUMENT primary key (DOC_DOCUMENTID)
);

comment on table PUBDOCUMENT is 
'thay cho nghi?p v? tang gi?m';

/*==============================================================*/
/* Index: PUBDOCUMENT_PK                                        */
/*==============================================================*/
create unique index PUBDOCUMENT_PK on PUBDOCUMENT (
DOC_DOCUMENTID ASC
);

/*==============================================================*/
/* Table: PUBDOCUMENTTYPE                                       */
/*==============================================================*/
create table PUBDOCUMENTTYPE 
(
   DOTY_AUTOID          smallint                       not null,
   constraint PK_PUBDOCUMENTTYPE primary key (DOTY_AUTOID)
);

comment on table PUBDOCUMENTTYPE is 
'Loai nghiep vu danh cho mot so type dung chung
';

comment on column PUBDOCUMENTTYPE.DOTY_AUTOID is 
'Mã mình thêm vào';

/*==============================================================*/
/* Index: PUBDOCUMENTTYPE_PK                                    */
/*==============================================================*/
create unique index PUBDOCUMENTTYPE_PK on PUBDOCUMENTTYPE (
DOTY_AUTOID ASC
);

/*==============================================================*/
/* Table: PUBITEMS                                              */
/*==============================================================*/
create table PUBITEMS 
(
   PIT_AUTOID           integer                        not null,
   constraint PK_PUBITEMS primary key (PIT_AUTOID)
);

comment on table PUBITEMS is 
'Hoàn hóa';

/*==============================================================*/
/* Index: PUBITEMS_PK                                           */
/*==============================================================*/
create unique index PUBITEMS_PK on PUBITEMS (
PIT_AUTOID ASC
);

/*==============================================================*/
/* Table: PUBOBJECT                                             */
/*==============================================================*/
create table PUBOBJECT 
(
   OBJ_AUTOID2          integer                        not null,
   constraint PK_PUBOBJECT primary key (OBJ_AUTOID2)
);

comment on table PUBOBJECT is 
'là m?t d?i tu?ng Tu?ng chung cho nhà cung c?p, khách hàng,Nhân viên,...';

comment on column PUBOBJECT.OBJ_AUTOID2 is 
'mã d?i tu?ng t? d?ng tang';

/*==============================================================*/
/* Index: PUBOBJECT_PK                                          */
/*==============================================================*/
create unique index PUBOBJECT_PK on PUBOBJECT (
OBJ_AUTOID2 ASC
);

/*==============================================================*/
/* Table: PUBORGANIZATION                                       */
/*==============================================================*/
create table PUBORGANIZATION 
(
   ORG_AUTOID           integer                        not null,
   constraint PK_PUBORGANIZATION primary key (ORG_AUTOID)
);

comment on table PUBORGANIZATION is 
'T? ch?c - Công ty - Chi nhánh - Phòng ban';

comment on column PUBORGANIZATION.ORG_AUTOID is 
'Mã t? ch?c - Mã Công ty - Mã Chi Nhánh - Mã Phòng ban';

/*==============================================================*/
/* Index: PUBORGANIZATION_PK                                    */
/*==============================================================*/
create unique index PUBORGANIZATION_PK on PUBORGANIZATION (
ORG_AUTOID ASC
);

/*==============================================================*/
/* Table: PUBPOSITION                                           */
/*==============================================================*/
create table PUBPOSITION 
(
   POS_AUTOID           integer                        not null,
   constraint PK_PUBPOSITION primary key (POS_AUTOID)
);

comment on table PUBPOSITION is 
'Ch?c v?';

/*==============================================================*/
/* Index: PUBPOSITION_PK                                        */
/*==============================================================*/
create unique index PUBPOSITION_PK on PUBPOSITION (
POS_AUTOID ASC
);

/*==============================================================*/
/* Table: PUBSTATUS                                             */
/*==============================================================*/
create table PUBSTATUS 
(
   ST_AUTOID            smallint                       not null,
   constraint PK_PUBSTATUS primary key (ST_AUTOID)
);

comment on table PUBSTATUS is 
'Dung chung cho tat ca moi nghi?p v?';

comment on column PUBSTATUS.ST_AUTOID is 
'mã t? d?ng tang';

/*==============================================================*/
/* Index: PUBSTATUS_PK                                          */
/*==============================================================*/
create unique index PUBSTATUS_PK on PUBSTATUS (
ST_AUTOID ASC
);

/*==============================================================*/
/* Table: PUBUOM                                                */
/*==============================================================*/
create table PUBUOM 
(
   UOM_AUTOID           smallint                       not null,
   constraint PK_PUBUOM primary key (UOM_AUTOID)
);

comment on table PUBUOM is 
'Ðon v? tính chu?n v? s? lu?ng';

/*==============================================================*/
/* Index: PUBUOM_PK                                             */
/*==============================================================*/
create unique index PUBUOM_PK on PUBUOM (
UOM_AUTOID ASC
);

alter table AMASSETITEM
   add constraint FK_AMASSETI_RELATIONS_PUBSTATU foreign key (ST_AUTOID)
      references PUBSTATUS (ST_AUTOID)
      on update restrict
      on delete restrict;

alter table AMASSETITEM
   add constraint FK_AMASSETI_RELATIONS_PUBITEMS foreign key (PIT_AUTOID)
      references PUBITEMS (PIT_AUTOID)
      on update restrict
      on delete restrict;

alter table AMASSETITEM
   add constraint FK_AMASSETI_RELATIONS_AMTASSET foreign key (ACIG_AUTOID)
      references AMTASSETGROUP (ACIG_AUTOID)
      on update restrict
      on delete restrict;

alter table AMCAPITAL
   add constraint FK_AMCAPITA_RELATIONS_AMCAPITA foreign key (ASS_AUTOID)
      references AMCAPITALTYPE (ASS_AUTOID)
      on update restrict
      on delete restrict;

alter table AMCAPITAL
   add constraint FK_AMCAPITA_RELATIONS_AMASSETI foreign key (ASI_AUTOID)
      references AMASSETITEM (ASI_AUTOID)
      on update restrict
      on delete restrict;

alter table AMCAPITAL
   add constraint FK_AMCAPITA_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID2)
      references PUBOBJECT (OBJ_AUTOID2)
      on update restrict
      on delete restrict;

alter table AMDECREASE
   add constraint FK_AMDECREA_RELATIONS_PUBDOCUM foreign key (DOTY_AUTOID)
      references PUBDOCUMENTTYPE (DOTY_AUTOID)
      on update restrict
      on delete restrict;

comment on foreign key AMDECREASE.FK_AMDECREA_RELATIONS_PUBDOCUM is 
'-  Gi?m do nhuong bán tài s?n, thanh lý (Ð?nh kho?n tai lúc bán)
-  Chuy?n sang CCLÐ nh? (Có d?nh kho?n)
-  Góp V?n liên doanh (Có Ð?nh kho?n)';

alter table AMDECREASE
   add constraint FK_AMDECREA_RELATIONS_PUBSTATU foreign key (ST_AUTOID)
      references PUBSTATUS (ST_AUTOID)
      on update restrict
      on delete restrict;

alter table AMDECREASE
   add constraint FK_AMDECREA_RELATIONS_FINANCYC foreign key (FICI_AUTOID)
      references FINANCYCICLE (FICI_AUTOID)
      on update restrict
      on delete restrict;

alter table AMDECREASE
   add constraint FK_AMDECREA_RELATIONS_PUBBATCH foreign key (PUBAT_AUTOID)
      references PUBBATCH (PUBAT_AUTOID)
      on update restrict
      on delete restrict;

alter table AMDECREASEDETAIL
   add constraint FK_AMDECREA_RELATIONS_AMDECREA foreign key (AMB_DOCUMENTID2)
      references AMDECREASE (AMB_DOCUMENTID2)
      on update restrict
      on delete restrict;

alter table AMDECREASEDETAIL
   add constraint FK_AMDECREA_RELATIONS_PUBORGAN foreign key (ORG_AUTOID)
      references PUBORGANIZATION (ORG_AUTOID)
      on update restrict
      on delete restrict;

alter table AMDECREASEDETAIL
   add constraint FK_AMDECREA_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID2)
      references PUBOBJECT (OBJ_AUTOID2)
      on update restrict
      on delete restrict;

alter table AMDECREASEDETAIL
   add constraint FK_AMDECREA_RELATIONS_PUBSTATU foreign key (ST_AUTOID)
      references PUBSTATUS (ST_AUTOID)
      on update restrict
      on delete restrict;

alter table AMDECREASEDETAIL
   add constraint FK_AMDECREA_RELATIONS_AMREASON foreign key (RES_AUTOID)
      references AMREASON (RES_AUTOID)
      on update restrict
      on delete restrict;

alter table AMDECREASEDETAIL
   add constraint FK_AMDECREA_RELATIONS_PUBITEMS foreign key (PIT_AUTOID)
      references PUBITEMS (PIT_AUTOID)
      on update restrict
      on delete restrict;

alter table AMENTRY
   add constraint FK_AMENTRY_RELATIONS_AMASSETI foreign key (ASI_AUTOID)
      references AMASSETITEM (ASI_AUTOID)
      on update restrict
      on delete restrict;

alter table AMENTRY
   add constraint FK_AMENTRY_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID2)
      references PUBOBJECT (OBJ_AUTOID2)
      on update restrict
      on delete restrict;

alter table AMENTRY
   add constraint FK_AMENTRY_RELATIONS_PUBCURRE foreign key (CUR_AUTOID)
      references PUBCURRENCY (CUR_AUTOID)
      on update restrict
      on delete restrict;

alter table AMENTRY
   add constraint FK_AMENTRY_RELATIONS_PUBCONTR foreign key (COT_AUTOID)
      references PUBCONTRACT (COT_AUTOID)
      on update restrict
      on delete restrict;

alter table AMENTRY
   add constraint FK_AMENTRY_RELATIONS_PUBCOSTP foreign key (CP_AUTOID)
      references PUBCOSTPRICE (CP_AUTOID)
      on update restrict
      on delete restrict;

alter table AMENTRY
   add constraint FK_AMENTRY_RELATIONS_PUBDOCUM foreign key (DOC_DOCUMENTID)
      references PUBDOCUMENT (DOC_DOCUMENTID)
      on update restrict
      on delete restrict;

alter table AMEVALUATION
   add constraint FK_AMEVALUA_RELATIONS_PUBDOCUM foreign key (DOTY_AUTOID)
      references PUBDOCUMENTTYPE (DOTY_AUTOID)
      on update restrict
      on delete restrict;

comment on foreign key AMEVALUATION.FK_AMEVALUA_RELATIONS_PUBDOCUM is 
'- Ðánh giá- l?p kh?u hao l?i. (Có d?nh kho?n)
- Thay d?i b? ph?n s? d?ng. Ch? c?p nh?t thông tin thay d?i. không cho phép d?nh kho?n
- Ng?ng kh?u hao (Chuy?n tr?ng thái ng?ng kh?u hao, ko cho phép d?nh kho?n)';

alter table AMEVALUATION
   add constraint FK_AMEVALUA_RELATIONS_PUBBATCH foreign key (PUBAT_AUTOID)
      references PUBBATCH (PUBAT_AUTOID)
      on update restrict
      on delete restrict;

alter table AMEVALUATION
   add constraint FK_AMEVALUA_RELATIONS_FINANCYC foreign key (FICI_AUTOID)
      references FINANCYCICLE (FICI_AUTOID)
      on update restrict
      on delete restrict;

alter table AMEVALUATION
   add constraint FK_AMEVALUA_RELATIONS_PUBSTATU foreign key (ST_AUTOID)
      references PUBSTATUS (ST_AUTOID)
      on update restrict
      on delete restrict;

alter table AMEVALUATIONDETAIL
   add constraint FK_AMEVALUA_RELATIONS_AMEVALUA foreign key (AMB_DOCUMENTID3)
      references AMEVALUATION (AMB_DOCUMENTID3)
      on update restrict
      on delete restrict;

alter table AMEVALUATIONDETAIL
   add constraint FK_AMEVALUA_RELATIONS_PUBORGAN foreign key (ORG_AUTOID)
      references PUBORGANIZATION (ORG_AUTOID)
      on update restrict
      on delete restrict;

alter table AMEVALUATIONDETAIL
   add constraint FK_AMEVALUA_RELATIONS_AMREASON foreign key (RES_AUTOID)
      references AMREASON (RES_AUTOID)
      on update restrict
      on delete restrict;

alter table AMINCREASE
   add constraint FK_AMINCREA_RELATIONS_PUBBATCH foreign key (PUBAT_AUTOID)
      references PUBBATCH (PUBAT_AUTOID)
      on update restrict
      on delete restrict;

alter table AMINCREASE
   add constraint FK_AMINCREA_RELATIONS_FINANCYC foreign key (FICI_AUTOID)
      references FINANCYCICLE (FICI_AUTOID)
      on update restrict
      on delete restrict;

alter table AMINCREASE
   add constraint FK_AMINCREA_RELATIONS_PUBDOCUM foreign key (DOTY_AUTOID)
      references PUBDOCUMENTTYPE (DOTY_AUTOID)
      on update restrict
      on delete restrict;

comment on foreign key AMINCREASE.FK_AMINCREA_RELATIONS_PUBDOCUM is 
'- Tang do mua s?m m?i (Ðon hàng mua) , Ch? luu tai AM mà ko ghi s?
- Ð?u tu xây d?ng co b?n hoàn thành
- Chuy?n t? CCDC Nh? (Xu?t kho )
- Xu?t kho hàng hóa làm tài s?n
- Ði?u chuy?n n?i b? t? don v? khác (Chuy?n kho n?i b?)
- Nh?n góp v?n liên doanh (Ghi s?)
- Ðu?c bi?u t?ng (Ghi s?)  
';

alter table AMINCREASE
   add constraint FK_AMINCREA_TRANG_THA_PUBSTATU foreign key (ST_AUTOID)
      references PUBSTATUS (ST_AUTOID)
      on update restrict
      on delete restrict;

comment on foreign key AMINCREASE.FK_AMINCREA_TRANG_THA_PUBSTATU is 
'Tr?ng thái
trang thai
1 T?o m?i 
2 Ghi s? t?m
3 Ðã ghi s?
4 b? l?i ';

alter table AMINCREASEDETAIL
   add constraint FK_AMINCREA_RELATIONS_AMREASON foreign key (RES_AUTOID)
      references AMREASON (RES_AUTOID)
      on update restrict
      on delete restrict;

alter table AMINCREASEDETAIL
   add constraint FK_AMINCREA_RELATIONS_PUBITEMS foreign key (PIT_AUTOID)
      references PUBITEMS (PIT_AUTOID)
      on update restrict
      on delete restrict;

alter table AMINCREASEDETAIL
   add constraint FK_AMINCREA_RELATIONS_AMINCREA foreign key (ABI_DOCUMENTID)
      references AMINCREASE (ABI_DOCUMENTID)
      on update restrict
      on delete restrict;

alter table AMINCREASEDETAIL
   add constraint FK_AMINCREA_RELATIONS_PUBUOM foreign key (UOM_AUTOID)
      references PUBUOM (UOM_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPREBUS
   add constraint FK_AMPEPREB_RELATIONS_PUBBATCH foreign key (PUBAT_AUTOID)
      references PUBBATCH (PUBAT_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPREBUS
   add constraint FK_AMPEPREB_RELATIONS_FINANCYC foreign key (FICI_AUTOID)
      references FINANCYCICLE (FICI_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPREBUS
   add constraint FK_AMPEPREB_RELATIONS_PUBCURRE foreign key (CUR_AUTOID)
      references PUBCURRENCY (CUR_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPREBUS
   add constraint FK_AMPEPREB_RELATIONS_PUBSTATU foreign key (ST_AUTOID)
      references PUBSTATUS (ST_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPREBUSDETAIL
   add constraint FK_AMPEPREB_RELATIONS_AMPEPREB foreign key (APB_DOCUMENTID)
      references AMPEPREBUS (APB_DOCUMENTID)
      on update restrict
      on delete restrict;

alter table AMPEPREBUSDETAIL
   add constraint FK_AMPEPREB_RELATIONS_AMASSETI foreign key (ASI_AUTOID)
      references AMASSETITEM (ASI_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPREBUSDETAIL
   add constraint FK_AMPEPREB_RELATIONS_PUBORGAN foreign key (ORG_AUTOID)
      references PUBORGANIZATION (ORG_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPREBUSDETAIL
   add constraint FK_AMPEPREB_RELATIONS_PUBCONTR foreign key (COT_AUTOID)
      references PUBCONTRACT (COT_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPREBUSDETAIL
   add constraint FK_AMPEPREB_RELATIONS_PUBCOSTP foreign key (CP_AUTOID)
      references PUBCOSTPRICE (CP_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPRECIATION
   add constraint FK_AMPEPREC_RELATIONS_AMASSETI foreign key (ASI_AUTOID)
      references AMASSETITEM (ASI_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPRECIATION
   add constraint FK_AMPEPREC_RELATIONS_AMDEPMET foreign key (ADM_AUTOID)
      references AMDEPMETHOD (ADM_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPRECIATION
   add constraint FK_AMPEPREC_RELATIONS_FINANCYC foreign key (FICI_AUTOID)
      references FINANCYCICLE (FICI_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPRECIATION
   add constraint FK_AMPEPREC_RELATIONS_PUBCOSTP foreign key (CP_AUTOID)
      references PUBCOSTPRICE (CP_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPRECOSTPRICE
   add constraint FK_AMPEPREC_RELATIONS_AMPEPRED foreign key (ASPD_AUTOID)
      references AMPEPREDETAIL (ASPD_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPRECOSTPRICE
   add constraint FK_AMPEPREC_RELATIONS_PUBCOSTP foreign key (CP_AUTOID)
      references PUBCOSTPRICE (CP_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPRECOSTPRICE
   add constraint FK_AMPEPREC_RELATIONS_PUBCONTR foreign key (COT_AUTOID)
      references PUBCONTRACT (COT_AUTOID)
      on update restrict
      on delete restrict;

alter table AMPEPRECOSTPRICE
   add constraint FK_AMPEPREC_RELATIONS_PUBACCOU foreign key (ACC_CODE)
      references PUBACCOUNT (ACC_CODE)
      on update restrict
      on delete restrict;

alter table AMPEPREDETAIL
   add constraint FK_AMPEPRED_RELATIONS_AMPEPREC foreign key (AMP_AUTOID)
      references AMPEPRECIATION (AMP_AUTOID)
      on update restrict
      on delete restrict;

comment on foreign key AMPEPREDETAIL.FK_AMPEPRED_RELATIONS_AMPEPREC is 
'Phân b? tài s?n';

alter table AMPEPREDETAIL
   add constraint FK_AMPEPRED_RELATIONS_FINANCYC foreign key (FICI_AUTOID)
      references FINANCYCICLE (FICI_AUTOID)
      on update restrict
      on delete restrict;

alter table AMUSEINFOR
   add constraint FK_AMUSEINF_RELATIONS_PUBORGAN foreign key (ORG_AUTOID)
      references PUBORGANIZATION (ORG_AUTOID)
      on update restrict
      on delete restrict;

alter table AMUSEINFOR
   add constraint FK_AMUSEINF_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID2)
      references PUBOBJECT (OBJ_AUTOID2)
      on update restrict
      on delete restrict;

alter table AMUSEINFOR
   add constraint FK_AMUSEINF_RELATIONS_AMASSETI foreign key (ASI_AUTOID)
      references AMASSETITEM (ASI_AUTOID)
      on update restrict
      on delete restrict;

alter table AMUSEINFOR
   add constraint FK_AMUSEINF_RELATIONS_PUBPOSIT foreign key (POS_AUTOID)
      references PUBPOSITION (POS_AUTOID)
      on update restrict
      on delete restrict;

alter table AMUSEINFOR
   add constraint FK_AMUSEINF_RELATIONS_AMITEMUS foreign key (AIUP_AUTOID)
      references AMITEMUSEPURPOSE (AIUP_AUTOID)
      on update restrict
      on delete restrict;

alter table INSURANCEITEM
   add constraint FK_INSURANC_RELATIONS_AMASSETI foreign key (ASI_AUTOID)
      references AMASSETITEM (ASI_AUTOID)
      on update restrict
      on delete restrict;

