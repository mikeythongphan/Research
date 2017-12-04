/*==============================================================*/
/* DBMS name:      Sybase SQL Anywhere 11                       */
/* Created on:     12/8/2009 10:24:28 AM                        */
/*==============================================================*/


if exists(select 1 from sys.sysforeignkey where role='FK_ICASSEMB_RELATIONS_FINANCYC') then
    alter table ICASSEMBLY
       delete foreign key FK_ICASSEMB_RELATIONS_FINANCYC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICASSEMB_RELATIONS_PUBSTATU') then
    alter table ICASSEMBLY
       delete foreign key FK_ICASSEMB_RELATIONS_PUBSTATU
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICASSEMB_RELATIONS_PUBCURRE') then
    alter table ICASSEMBLY
       delete foreign key FK_ICASSEMB_RELATIONS_PUBCURRE
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICCONTEN_RELATIONS_PUBWAREH') then
    alter table ICCONTENTITEM
       delete foreign key FK_ICCONTEN_RELATIONS_PUBWAREH
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICCONTEN_RELATIONS_ICINWARD') then
    alter table ICCONTENTITEM
       delete foreign key FK_ICCONTEN_RELATIONS_ICINWARD
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICCONTEN_RELATIONS_PUBITEMS') then
    alter table ICCONTENTITEM
       delete foreign key FK_ICCONTEN_RELATIONS_PUBITEMS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICDIMENT_RELATIONS_ICPURPOS') then
    alter table ICDIMENTIONS
       delete foreign key FK_ICDIMENT_RELATIONS_ICPURPOS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICDIMENT_RELATIONS_PUBCONTR') then
    alter table ICDIMENTIONS
       delete foreign key FK_ICDIMENT_RELATIONS_PUBCONTR
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICDIMENT_RELATIONS_PUBCOSTP') then
    alter table ICDIMENTIONS
       delete foreign key FK_ICDIMENT_RELATIONS_PUBCOSTP
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICDIMENT_RELATIONS_INVOICE') then
    alter table ICDIMENTIONS
       delete foreign key FK_ICDIMENT_RELATIONS_INVOICE
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICENTRY_RELATIONS_PUBITEMS') then
    alter table ICENTRY
       delete foreign key FK_ICENTRY_RELATIONS_PUBITEMS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICENTRY_RELATIONS_PUBOBJEC') then
    alter table ICENTRY
       delete foreign key FK_ICENTRY_RELATIONS_PUBOBJEC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICENTRY_RELATIONS_PUBCURRE') then
    alter table ICENTRY
       delete foreign key FK_ICENTRY_RELATIONS_PUBCURRE
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICENTRY_RELATIONS_PUBCONTR') then
    alter table ICENTRY
       delete foreign key FK_ICENTRY_RELATIONS_PUBCONTR
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICENTRY_RELATIONS_INVOICE') then
    alter table ICENTRY
       delete foreign key FK_ICENTRY_RELATIONS_INVOICE
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICENTRY_RELATIONS_PUBDOCUM') then
    alter table ICENTRY
       delete foreign key FK_ICENTRY_RELATIONS_PUBDOCUM
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICENTRY_RELATIONS_PUBCOSTP') then
    alter table ICENTRY
       delete foreign key FK_ICENTRY_RELATIONS_PUBCOSTP
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICINOUTS_NGHIEP_VU_PUBDOCUM') then
    alter table ICINOUTSTOCK
       delete foreign key FK_ICINOUTS_NGHIEP_VU_PUBDOCUM
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICINOUTS_RELATIONS_PUBOBJEC') then
    alter table ICINOUTSTOCK
       delete foreign key FK_ICINOUTS_RELATIONS_PUBOBJEC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICINOUTS_RELATIONS_PUBBATCH') then
    alter table ICINOUTSTOCK
       delete foreign key FK_ICINOUTS_RELATIONS_PUBBATCH
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICINOUTS_RELATIONS_ICREQUES') then
    alter table ICINOUTSTOCK
       delete foreign key FK_ICINOUTS_RELATIONS_ICREQUES
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICINOUTS_RELATIONS_FINANCYC') then
    alter table ICINOUTSTOCK
       delete foreign key FK_ICINOUTS_RELATIONS_FINANCYC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICINOUTS_RELATIONS_PUBWAREH') then
    alter table ICINOUTSTOCK
       delete foreign key FK_ICINOUTS_RELATIONS_PUBWAREH
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICINOUTS_RELATIONS_PUBSTATU') then
    alter table ICINOUTSTOCK
       delete foreign key FK_ICINOUTS_RELATIONS_PUBSTATU
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICINWARD_RELATIONS_ITEMTYPE') then
    alter table ICINWARDSTOCKDETAIL
       delete foreign key FK_ICINWARD_RELATIONS_ITEMTYPE
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICINWARD_RELATIONS_CLASSIFI') then
    alter table ICINWARDSTOCKDETAIL
       delete foreign key FK_ICINWARD_RELATIONS_CLASSIFI
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICINWARD_RELATIONS_ICINOUTS') then
    alter table ICINWARDSTOCKDETAIL
       delete foreign key FK_ICINWARD_RELATIONS_ICINOUTS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICINWARD_RELATIONS_PUBITEMS') then
    alter table ICINWARDSTOCKDETAIL
       delete foreign key FK_ICINWARD_RELATIONS_PUBITEMS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICINWARD_RELATIONS_PUBCURRE') then
    alter table ICINWARDSTOCKDETAIL
       delete foreign key FK_ICINWARD_RELATIONS_PUBCURRE
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICINWARD_RELATIONS_PUBUOM') then
    alter table ICINWARDSTOCKDETAIL
       delete foreign key FK_ICINWARD_RELATIONS_PUBUOM
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICMOVE_RELATIONS_FINANCYC') then
    alter table ICMOVE
       delete foreign key FK_ICMOVE_RELATIONS_FINANCYC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICMOVE_RELATIONS_PUBSTATU') then
    alter table ICMOVE
       delete foreign key FK_ICMOVE_RELATIONS_PUBSTATU
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICMOVE_RELATIONS_PUBSHIPM') then
    alter table ICMOVE
       delete foreign key FK_ICMOVE_RELATIONS_PUBSHIPM
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICMOVE_RELATIONS_PUBOBJEC') then
    alter table ICMOVE
       delete foreign key FK_ICMOVE_RELATIONS_PUBOBJEC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICMOVE_RELATIONS_PUBBATCH') then
    alter table ICMOVE
       delete foreign key FK_ICMOVE_RELATIONS_PUBBATCH
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICMOVEDE_CONTENT_D_ICMOVE') then
    alter table ICMOVEDETAIL
       delete foreign key FK_ICMOVEDE_CONTENT_D_ICMOVE
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICMOVEDE_RELATIONS_CLASSIFI') then
    alter table ICMOVEDETAIL
       delete foreign key FK_ICMOVEDE_RELATIONS_CLASSIFI
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICMOVEDE_RELATIONS_ITEMTYPE') then
    alter table ICMOVEDETAIL
       delete foreign key FK_ICMOVEDE_RELATIONS_ITEMTYPE
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICMOVEDE_RELATIONS_PUBSTATU') then
    alter table ICMOVEDETAIL
       delete foreign key FK_ICMOVEDE_RELATIONS_PUBSTATU
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICMOVEDE_RELATIONS_PUBUOM') then
    alter table ICMOVEDETAIL
       delete foreign key FK_ICMOVEDE_RELATIONS_PUBUOM
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICMOVEDE_RELATIONS_PUBITEMS') then
    alter table ICMOVEDETAIL
       delete foreign key FK_ICMOVEDE_RELATIONS_PUBITEMS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICOTHERC_ICOTHERCO_INVOICE') then
    alter table ICOTHERCOST
       delete foreign key FK_ICOTHERC_ICOTHERCO_INVOICE
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICOTHERC_ICOTHERCO_PUBDOCUM') then
    alter table ICOTHERCOST
       delete foreign key FK_ICOTHERC_ICOTHERCO_PUBDOCUM
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICPLAN_RELATIONS_PUBOBJEC') then
    alter table ICPLAN
       delete foreign key FK_ICPLAN_RELATIONS_PUBOBJEC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICPLAN_RELATIONS_PUBWAREH') then
    alter table ICPLAN
       delete foreign key FK_ICPLAN_RELATIONS_PUBWAREH
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICPLANDE_RELATIONS_CLASSIFI') then
    alter table ICPLANDETAIL
       delete foreign key FK_ICPLANDE_RELATIONS_CLASSIFI
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICPLANDE_RELATIONS_ITEMTYPE') then
    alter table ICPLANDETAIL
       delete foreign key FK_ICPLANDE_RELATIONS_ITEMTYPE
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICPLANDE_RELATIONS_ICPLAN') then
    alter table ICPLANDETAIL
       delete foreign key FK_ICPLANDE_RELATIONS_ICPLAN
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICPLANDE_RELATIONS_PUBITEMS') then
    alter table ICPLANDETAIL
       delete foreign key FK_ICPLANDE_RELATIONS_PUBITEMS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICREQUES_RELATIONS_PUBWAREH') then
    alter table ICREQUES
       delete foreign key FK_ICREQUES_RELATIONS_PUBWAREH
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICREQUES_RELATIONS_FINANCYC') then
    alter table ICREQUES
       delete foreign key FK_ICREQUES_RELATIONS_FINANCYC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICREQUES_RELATIONS_PUBOBJEC') then
    alter table ICREQUES
       delete foreign key FK_ICREQUES_RELATIONS_PUBOBJEC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICREQUES_RELATIONS_PUBSTATU') then
    alter table ICREQUES
       delete foreign key FK_ICREQUES_RELATIONS_PUBSTATU
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICREQUES_RELATIONS_PUBDOCUM') then
    alter table ICREQUES
       delete foreign key FK_ICREQUES_RELATIONS_PUBDOCUM
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICREQUES_RELATIONS_CLASSIFI') then
    alter table ICREQUESDETAIL
       delete foreign key FK_ICREQUES_RELATIONS_CLASSIFI
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICREQUES_RELATIONS_ITEMTYPE') then
    alter table ICREQUESDETAIL
       delete foreign key FK_ICREQUES_RELATIONS_ITEMTYPE
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICREQUES_RELATIONS_ICREQUES') then
    alter table ICREQUESDETAIL
       delete foreign key FK_ICREQUES_RELATIONS_ICREQUES
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICREQUES_RELATIONS_PUBITEMS') then
    alter table ICREQUESDETAIL
       delete foreign key FK_ICREQUES_RELATIONS_PUBITEMS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOCK_RELATIONS_PUBORGAN') then
    alter table ICSTOCK
       delete foreign key FK_ICSTOCK_RELATIONS_PUBORGAN
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOCK_RELATIONS_PUBITEMS') then
    alter table ICSTOCK
       delete foreign key FK_ICSTOCK_RELATIONS_PUBITEMS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOCK_RELATIONS_FINANCYC') then
    alter table ICSTOCK
       delete foreign key FK_ICSTOCK_RELATIONS_FINANCYC
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOCKJ_ICSTOCKJO_ICINWARD') then
    alter table ICSTOCKJOIN
       delete foreign key FK_ICSTOCKJ_ICSTOCKJO_ICINWARD
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOCKJ_ICSTOCKJO_CLASSIFI') then
    alter table ICSTOCKJOIN
       delete foreign key FK_ICSTOCKJ_ICSTOCKJO_CLASSIFI
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOCKJ_ICSTOCKJO_PUBMANUF') then
    alter table ICSTOCKJOIN
       delete foreign key FK_ICSTOCKJ_ICSTOCKJO_PUBMANUF
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOCKJ_ICSTOCKJO_PUBCURRE') then
    alter table ICSTOCKJOIN
       delete foreign key FK_ICSTOCKJ_ICSTOCKJO_PUBCURRE
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOCKJ_ICSTOCKJO_ICSTOCKD') then
    alter table ICSTOCKJOIN
       delete foreign key FK_ICSTOCKJ_ICSTOCKJO_ICSTOCKD
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOCKJ_ICSTOCKJO_ICSTOCK') then
    alter table ICSTOCKJOIN
       delete foreign key FK_ICSTOCKJ_ICSTOCKJO_ICSTOCK
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOCKJ_ICSTOCKJO_ICMOVEDE') then
    alter table ICSTOCKJOIN
       delete foreign key FK_ICSTOCKJ_ICSTOCKJO_ICMOVEDE
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOCKJ_ICSTOCKJO_ICPLOT') then
    alter table ICSTOCKJOIN
       delete foreign key FK_ICSTOCKJ_ICSTOCKJO_ICPLOT
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOCKJ_ICSTOCKJO_PUBWAREH') then
    alter table ICSTOCKJOIN
       delete foreign key FK_ICSTOCKJ_ICSTOCKJO_PUBWAREH
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOCKJ_ICSTOCKJO_ITEMSPOS') then
    alter table ICSTOCKJOIN
       delete foreign key FK_ICSTOCKJ_ICSTOCKJO_ITEMSPOS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOCKJ_ICSTOCKJO_PUBPACKI') then
    alter table ICSTOCKJOIN
       delete foreign key FK_ICSTOCKJ_ICSTOCKJO_PUBPACKI
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOCKJ_ICSTOCKJO_ICWARRAN') then
    alter table ICSTOCKJOIN
       delete foreign key FK_ICSTOCKJ_ICSTOCKJO_ICWARRAN
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOREW_RELATIONS_PUBMANUF') then
    alter table ICSTOREWARRANTY
       delete foreign key FK_ICSTOREW_RELATIONS_PUBMANUF
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOREW_RELATIONS_ITEMSPOS') then
    alter table ICSTOREWARRANTY
       delete foreign key FK_ICSTOREW_RELATIONS_ITEMSPOS
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOREW_RELATIONS_ICWARRAN') then
    alter table ICSTOREWARRANTY
       delete foreign key FK_ICSTOREW_RELATIONS_ICWARRAN
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOREW_RELATIONS_PUBWAREH') then
    alter table ICSTOREWARRANTY
       delete foreign key FK_ICSTOREW_RELATIONS_PUBWAREH
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOREW_RELATIONS_PUBPACKI') then
    alter table ICSTOREWARRANTY
       delete foreign key FK_ICSTOREW_RELATIONS_PUBPACKI
end if;

if exists(select 1 from sys.sysforeignkey where role='FK_ICSTOREW_RELATIONS_ICPLOT') then
    alter table ICSTOREWARRANTY
       delete foreign key FK_ICSTOREW_RELATIONS_ICPLOT
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='CLASSIFIED_PK'
     and t.table_name='CLASSIFIED'
) then
   drop index CLASSIFIED.CLASSIFIED_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='CLASSIFIED'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table CLASSIFIED
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
     and i.index_name='RELATIONSHIP_93_FK'
     and t.table_name='ICASSEMBLY'
) then
   drop index ICASSEMBLY.RELATIONSHIP_93_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_92_FK'
     and t.table_name='ICASSEMBLY'
) then
   drop index ICASSEMBLY.RELATIONSHIP_92_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_91_FK'
     and t.table_name='ICASSEMBLY'
) then
   drop index ICASSEMBLY.RELATIONSHIP_91_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICASSEMBLY_PK'
     and t.table_name='ICASSEMBLY'
) then
   drop index ICASSEMBLY.ICASSEMBLY_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICASSEMBLY'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICASSEMBLY
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_63_FK'
     and t.table_name='ICCONTENTITEM'
) then
   drop index ICCONTENTITEM.RELATIONSHIP_63_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_62_FK'
     and t.table_name='ICCONTENTITEM'
) then
   drop index ICCONTENTITEM.RELATIONSHIP_62_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_61_FK'
     and t.table_name='ICCONTENTITEM'
) then
   drop index ICCONTENTITEM.RELATIONSHIP_61_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICCONTENTITEM_PK'
     and t.table_name='ICCONTENTITEM'
) then
   drop index ICCONTENTITEM.ICCONTENTITEM_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICCONTENTITEM'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICCONTENTITEM
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_70_FK'
     and t.table_name='ICDIMENTIONS'
) then
   drop index ICDIMENTIONS.RELATIONSHIP_70_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_89_FK'
     and t.table_name='ICDIMENTIONS'
) then
   drop index ICDIMENTIONS.RELATIONSHIP_89_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_77_FK'
     and t.table_name='ICDIMENTIONS'
) then
   drop index ICDIMENTIONS.RELATIONSHIP_77_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_88_FK'
     and t.table_name='ICDIMENTIONS'
) then
   drop index ICDIMENTIONS.RELATIONSHIP_88_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICDIMENTIONS_PK'
     and t.table_name='ICDIMENTIONS'
) then
   drop index ICDIMENTIONS.ICDIMENTIONS_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICDIMENTIONS'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICDIMENTIONS
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_108_FK'
     and t.table_name='ICENTRY'
) then
   drop index ICENTRY.RELATIONSHIP_108_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_116_FK'
     and t.table_name='ICENTRY'
) then
   drop index ICENTRY.RELATIONSHIP_116_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_113_FK'
     and t.table_name='ICENTRY'
) then
   drop index ICENTRY.RELATIONSHIP_113_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_112_FK'
     and t.table_name='ICENTRY'
) then
   drop index ICENTRY.RELATIONSHIP_112_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_111_FK'
     and t.table_name='ICENTRY'
) then
   drop index ICENTRY.RELATIONSHIP_111_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_110_FK'
     and t.table_name='ICENTRY'
) then
   drop index ICENTRY.RELATIONSHIP_110_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_114_FK'
     and t.table_name='ICENTRY'
) then
   drop index ICENTRY.RELATIONSHIP_114_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICENTRY_PK'
     and t.table_name='ICENTRY'
) then
   drop index ICENTRY.ICENTRY_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICENTRY'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICENTRY
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_76_FK'
     and t.table_name='ICINOUTSTOCK'
) then
   drop index ICINOUTSTOCK.RELATIONSHIP_76_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='NGHIEP_VU_NHAP_KHO_FK'
     and t.table_name='ICINOUTSTOCK'
) then
   drop index ICINOUTSTOCK.NGHIEP_VU_NHAP_KHO_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_33_FK'
     and t.table_name='ICINOUTSTOCK'
) then
   drop index ICINOUTSTOCK.RELATIONSHIP_33_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_34_FK'
     and t.table_name='ICINOUTSTOCK'
) then
   drop index ICINOUTSTOCK.RELATIONSHIP_34_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_120_FK'
     and t.table_name='ICINOUTSTOCK'
) then
   drop index ICINOUTSTOCK.RELATIONSHIP_120_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_67_FK'
     and t.table_name='ICINOUTSTOCK'
) then
   drop index ICINOUTSTOCK.RELATIONSHIP_67_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_3_FK'
     and t.table_name='ICINOUTSTOCK'
) then
   drop index ICINOUTSTOCK.RELATIONSHIP_3_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICINOUTSTOCK_PK'
     and t.table_name='ICINOUTSTOCK'
) then
   drop index ICINOUTSTOCK.ICINOUTSTOCK_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICINOUTSTOCK'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICINOUTSTOCK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_71_FK'
     and t.table_name='ICINWARDSTOCKDETAIL'
) then
   drop index ICINWARDSTOCKDETAIL.RELATIONSHIP_71_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_147_FK'
     and t.table_name='ICINWARDSTOCKDETAIL'
) then
   drop index ICINWARDSTOCKDETAIL.RELATIONSHIP_147_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_146_FK'
     and t.table_name='ICINWARDSTOCKDETAIL'
) then
   drop index ICINWARDSTOCKDETAIL.RELATIONSHIP_146_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_74_FK'
     and t.table_name='ICINWARDSTOCKDETAIL'
) then
   drop index ICINWARDSTOCKDETAIL.RELATIONSHIP_74_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_5_FK'
     and t.table_name='ICINWARDSTOCKDETAIL'
) then
   drop index ICINWARDSTOCKDETAIL.RELATIONSHIP_5_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_4_FK'
     and t.table_name='ICINWARDSTOCKDETAIL'
) then
   drop index ICINWARDSTOCKDETAIL.RELATIONSHIP_4_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICINWARDSTOCKDETAIL_PK'
     and t.table_name='ICINWARDSTOCKDETAIL'
) then
   drop index ICINWARDSTOCKDETAIL.ICINWARDSTOCKDETAIL_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICINWARDSTOCKDETAIL'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICINWARDSTOCKDETAIL
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_66_FK'
     and t.table_name='ICMOVE'
) then
   drop index ICMOVE.RELATIONSHIP_66_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_86_FK'
     and t.table_name='ICMOVE'
) then
   drop index ICMOVE.RELATIONSHIP_86_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_69_FK'
     and t.table_name='ICMOVE'
) then
   drop index ICMOVE.RELATIONSHIP_69_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_36_FK'
     and t.table_name='ICMOVE'
) then
   drop index ICMOVE.RELATIONSHIP_36_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_81_FK'
     and t.table_name='ICMOVE'
) then
   drop index ICMOVE.RELATIONSHIP_81_FK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICMOVE'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICMOVE
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_82_FK'
     and t.table_name='ICMOVEDETAIL'
) then
   drop index ICMOVEDETAIL.RELATIONSHIP_82_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_79_FK'
     and t.table_name='ICMOVEDETAIL'
) then
   drop index ICMOVEDETAIL.RELATIONSHIP_79_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_39_FK'
     and t.table_name='ICMOVEDETAIL'
) then
   drop index ICMOVEDETAIL.RELATIONSHIP_39_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_38_FK'
     and t.table_name='ICMOVEDETAIL'
) then
   drop index ICMOVEDETAIL.RELATIONSHIP_38_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_85_FK'
     and t.table_name='ICMOVEDETAIL'
) then
   drop index ICMOVEDETAIL.RELATIONSHIP_85_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_84_FK'
     and t.table_name='ICMOVEDETAIL'
) then
   drop index ICMOVEDETAIL.RELATIONSHIP_84_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICMOVEDETAIL_PK'
     and t.table_name='ICMOVEDETAIL'
) then
   drop index ICMOVEDETAIL.ICMOVEDETAIL_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICMOVEDETAIL'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICMOVEDETAIL
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICOTHERCOST'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICOTHERCOST
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_35_FK'
     and t.table_name='ICPLAN'
) then
   drop index ICPLAN.RELATIONSHIP_35_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_78_FK'
     and t.table_name='ICPLAN'
) then
   drop index ICPLAN.RELATIONSHIP_78_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICPLAN_PK'
     and t.table_name='ICPLAN'
) then
   drop index ICPLAN.ICPLAN_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICPLAN'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICPLAN
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_41_FK'
     and t.table_name='ICPLANDETAIL'
) then
   drop index ICPLANDETAIL.RELATIONSHIP_41_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_40_FK'
     and t.table_name='ICPLANDETAIL'
) then
   drop index ICPLANDETAIL.RELATIONSHIP_40_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_97_FK'
     and t.table_name='ICPLANDETAIL'
) then
   drop index ICPLANDETAIL.RELATIONSHIP_97_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_96_FK'
     and t.table_name='ICPLANDETAIL'
) then
   drop index ICPLANDETAIL.RELATIONSHIP_96_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICPLANDETAIL_PK'
     and t.table_name='ICPLANDETAIL'
) then
   drop index ICPLANDETAIL.ICPLANDETAIL_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICPLANDETAIL'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICPLANDETAIL
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICPLOT'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICPLOT
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICPURPOSEUSE_PK'
     and t.table_name='ICPURPOSEUSE'
) then
   drop index ICPURPOSEUSE.ICPURPOSEUSE_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICPURPOSEUSE'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICPURPOSEUSE
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_72_FK'
     and t.table_name='ICREQUES'
) then
   drop index ICREQUES.RELATIONSHIP_72_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_87_FK'
     and t.table_name='ICREQUES'
) then
   drop index ICREQUES.RELATIONSHIP_87_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_53_FK'
     and t.table_name='ICREQUES'
) then
   drop index ICREQUES.RELATIONSHIP_53_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_37_FK'
     and t.table_name='ICREQUES'
) then
   drop index ICREQUES.RELATIONSHIP_37_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_100_FK'
     and t.table_name='ICREQUES'
) then
   drop index ICREQUES.RELATIONSHIP_100_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICREQUES_PK'
     and t.table_name='ICREQUES'
) then
   drop index ICREQUES.ICREQUES_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICREQUES'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICREQUES
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_43_FK'
     and t.table_name='ICREQUESDETAIL'
) then
   drop index ICREQUESDETAIL.RELATIONSHIP_43_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_42_FK'
     and t.table_name='ICREQUESDETAIL'
) then
   drop index ICREQUESDETAIL.RELATIONSHIP_42_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_99_FK'
     and t.table_name='ICREQUESDETAIL'
) then
   drop index ICREQUESDETAIL.RELATIONSHIP_99_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_98_FK'
     and t.table_name='ICREQUESDETAIL'
) then
   drop index ICREQUESDETAIL.RELATIONSHIP_98_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICREQUESDETAIL_PK'
     and t.table_name='ICREQUESDETAIL'
) then
   drop index ICREQUESDETAIL.ICREQUESDETAIL_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICREQUESDETAIL'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICREQUESDETAIL
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_109_FK'
     and t.table_name='ICSTOCK'
) then
   drop index ICSTOCK.RELATIONSHIP_109_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_83_FK'
     and t.table_name='ICSTOCK'
) then
   drop index ICSTOCK.RELATIONSHIP_83_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_64_FK'
     and t.table_name='ICSTOCK'
) then
   drop index ICSTOCK.RELATIONSHIP_64_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOCK_PK'
     and t.table_name='ICSTOCK'
) then
   drop index ICSTOCK.ICSTOCK_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICSTOCK'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICSTOCK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOCKDETAIL_PK'
     and t.table_name='ICSTOCKDETAIL'
) then
   drop index ICSTOCKDETAIL.ICSTOCKDETAIL_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICSTOCKDETAIL'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICSTOCKDETAIL
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOCKJOIN12_FK'
     and t.table_name='ICSTOCKJOIN'
) then
   drop index ICSTOCKJOIN.ICSTOCKJOIN12_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOCKJOIN11_FK'
     and t.table_name='ICSTOCKJOIN'
) then
   drop index ICSTOCKJOIN.ICSTOCKJOIN11_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOCKJOIN10_FK'
     and t.table_name='ICSTOCKJOIN'
) then
   drop index ICSTOCKJOIN.ICSTOCKJOIN10_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOCKJOIN9_FK'
     and t.table_name='ICSTOCKJOIN'
) then
   drop index ICSTOCKJOIN.ICSTOCKJOIN9_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOCKJOIN8_FK'
     and t.table_name='ICSTOCKJOIN'
) then
   drop index ICSTOCKJOIN.ICSTOCKJOIN8_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOCKJOIN7_FK'
     and t.table_name='ICSTOCKJOIN'
) then
   drop index ICSTOCKJOIN.ICSTOCKJOIN7_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOCKJOIN6_FK'
     and t.table_name='ICSTOCKJOIN'
) then
   drop index ICSTOCKJOIN.ICSTOCKJOIN6_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOCKJOIN5_FK'
     and t.table_name='ICSTOCKJOIN'
) then
   drop index ICSTOCKJOIN.ICSTOCKJOIN5_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOCKJOIN4_FK'
     and t.table_name='ICSTOCKJOIN'
) then
   drop index ICSTOCKJOIN.ICSTOCKJOIN4_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOCKJOIN3_FK'
     and t.table_name='ICSTOCKJOIN'
) then
   drop index ICSTOCKJOIN.ICSTOCKJOIN3_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOCKJOIN2_FK'
     and t.table_name='ICSTOCKJOIN'
) then
   drop index ICSTOCKJOIN.ICSTOCKJOIN2_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOCKJOIN_FK'
     and t.table_name='ICSTOCKJOIN'
) then
   drop index ICSTOCKJOIN.ICSTOCKJOIN_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOCKJOIN_PK'
     and t.table_name='ICSTOCKJOIN'
) then
   drop index ICSTOCKJOIN.ICSTOCKJOIN_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICSTOCKJOIN'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICSTOCKJOIN
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_73_FK'
     and t.table_name='ICSTOREWARRANTY'
) then
   drop index ICSTOREWARRANTY.RELATIONSHIP_73_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_60_FK'
     and t.table_name='ICSTOREWARRANTY'
) then
   drop index ICSTOREWARRANTY.RELATIONSHIP_60_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_68_FK'
     and t.table_name='ICSTOREWARRANTY'
) then
   drop index ICSTOREWARRANTY.RELATIONSHIP_68_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_75_FK'
     and t.table_name='ICSTOREWARRANTY'
) then
   drop index ICSTOREWARRANTY.RELATIONSHIP_75_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_90_FK'
     and t.table_name='ICSTOREWARRANTY'
) then
   drop index ICSTOREWARRANTY.RELATIONSHIP_90_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='RELATIONSHIP_80_FK'
     and t.table_name='ICSTOREWARRANTY'
) then
   drop index ICSTOREWARRANTY.RELATIONSHIP_80_FK
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICSTOREWARRANTY_PK'
     and t.table_name='ICSTOREWARRANTY'
) then
   drop index ICSTOREWARRANTY.ICSTOREWARRANTY_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICSTOREWARRANTY'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICSTOREWARRANTY
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ICWARRANTYCODE_PK'
     and t.table_name='ICWARRANTYCODE'
) then
   drop index ICWARRANTYCODE.ICWARRANTYCODE_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ICWARRANTYCODE'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ICWARRANTYCODE
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='INVOICE_PK'
     and t.table_name='INVOICE'
) then
   drop index INVOICE.INVOICE_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='INVOICE'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table INVOICE
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ITEMSPOSITION_PK'
     and t.table_name='ITEMSPOSITION'
) then
   drop index ITEMSPOSITION.ITEMSPOSITION_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ITEMSPOSITION'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ITEMSPOSITION
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='ITEMTYPE_PK'
     and t.table_name='ITEMTYPE'
) then
   drop index ITEMTYPE.ITEMTYPE_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='ITEMTYPE'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table ITEMTYPE
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
     and i.index_name='PUBMANUFACTURER_PK'
     and t.table_name='PUBMANUFACTURER'
) then
   drop index PUBMANUFACTURER.PUBMANUFACTURER_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBMANUFACTURER'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBMANUFACTURER
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
     and i.index_name='PUBPACKING_PK'
     and t.table_name='PUBPACKING'
) then
   drop index PUBPACKING.PUBPACKING_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBPACKING'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBPACKING
end if;

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='PUBSHIPMETHOD_PK'
     and t.table_name='PUBSHIPMETHOD'
) then
   drop index PUBSHIPMETHOD.PUBSHIPMETHOD_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBSHIPMETHOD'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBSHIPMETHOD
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

if exists(
   select 1 from sys.sysindex i, sys.systable t
   where i.table_id=t.table_id 
     and i.index_name='PUBWAREHOUSE_PK'
     and t.table_name='PUBWAREHOUSE'
) then
   drop index PUBWAREHOUSE.PUBWAREHOUSE_PK
end if;

if exists(
   select 1 from sys.systable 
   where table_name='PUBWAREHOUSE'
     and table_type in ('BASE', 'GBL TEMP')
) then
    drop table PUBWAREHOUSE
end if;

/*==============================================================*/
/* Table: CLASSIFIED                                            */
/*==============================================================*/
create table CLASSIFIED 
(
   ITET_AUTOID          smallint                       not null,
   constraint PK_CLASSIFIED primary key (ITET_AUTOID)
);

comment on table CLASSIFIED is 
'Phân lo?i  Hàng hóa
- Hang hóa
- V?t Tu
- Công c? d?ng c?
- Tài s?n
- Bán Thành Ph?m
- Thành ph?m

form nay ko code';

comment on column CLASSIFIED.ITET_AUTOID is 
'Mã t? d?ng tang';

/*==============================================================*/
/* Index: CLASSIFIED_PK                                         */
/*==============================================================*/
create unique index CLASSIFIED_PK on CLASSIFIED (
ITET_AUTOID ASC
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
/* Table: ICASSEMBLY                                            */
/*==============================================================*/
create table ICASSEMBLY 
(
   ICA_DOCUMENTID       integer                        not null,
   CUR_AUTOID           smallint                       null,
   ST_AUTOID            smallint                       null,
   FICI_AUTOID          smallint                       null,
   ICA_EXCUTEBY         integer                        null,
   ICA_ATTACTDOCUMENT   char(20)                       null,
   ICA_CURRENCYRATE     decimal(5,3)                   null,
   constraint PK_ICASSEMBLY primary key (ICA_DOCUMENTID)
);

comment on table ICASSEMBLY is 
'L?p ghép theo g?';

comment on column ICASSEMBLY.CUR_AUTOID is 
'ID t? tang';

comment on column ICASSEMBLY.ST_AUTOID is 
'mã t? d?ng tang';

comment on column ICASSEMBLY.ICA_EXCUTEBY is 
'ngu?i th?c hi?n';

comment on column ICASSEMBLY.ICA_ATTACTDOCUMENT is 
'ch?ng t? kèm theo';

comment on column ICASSEMBLY.ICA_CURRENCYRATE is 
't? giá';

/*==============================================================*/
/* Index: ICASSEMBLY_PK                                         */
/*==============================================================*/
create unique index ICASSEMBLY_PK on ICASSEMBLY (
ICA_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_91_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_91_FK on ICASSEMBLY (
FICI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_92_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_92_FK on ICASSEMBLY (
ST_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_93_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_93_FK on ICASSEMBLY (
CUR_AUTOID ASC
);

/*==============================================================*/
/* Table: ICCONTENTITEM                                         */
/*==============================================================*/
create table ICCONTENTITEM 
(
   ICCO_AUTOID          integer                        not null,
   ICID_AUTOID          integer                        null,
   WH_AUTOID            integer                        null,
   PIT_AUTOID           integer                        null,
   ICCO_ISBOM           smallint                       null,
   ICCO_ITEMNO          char(20)                       null,
   ICCO_ITEMNAME        varchar(150)                   null,
   ICCO_QUANTITY        decimal(10,2)                  null,
   ICCO_UOM1            smallint                       null,
   ICCO_HAO_HUT         decimal(4,2)                   null,
   ICCO_QUANTITY2       decimal(10,2)                  null,
   ICCO_UOM2            smallint                       null,
   ICCO_LOSSPER2        decimal(4,2)                   null,
   DOC_DOCUMENTID       integer                        null,
   ICCO_OTHERCOST       decimal(18,3)                  null,
   constraint PK_ICCONTENTITEM primary key (ICCO_AUTOID)
);

comment on table ICCONTENTITEM is 
'Danh sach nhung mat hang duoc tru kho theo bom khi nhap kho thanh pham';

comment on column ICCONTENTITEM.ICID_AUTOID is 
'Mã t? dông tang';

comment on column ICCONTENTITEM.ICCO_HAO_HUT is 
'% hao hut';

comment on column ICCONTENTITEM.ICCO_LOSSPER2 is 
'% hao hut 2';

comment on column ICCONTENTITEM.DOC_DOCUMENTID is 
'chung tu xuat kho 
khi ma nhap kho ban thanh pham hay thanh pham theo cong thuc bom thi tu dong tao ra mot chung tu xuat kho tuong ung, neu chung tu xuat kho co loi thi qoay lai chung tu nha kho cha cua no lam lai thao tac nhap kho


....';

comment on column ICCONTENTITEM.ICCO_OTHERCOST is 
'chi phi lien quan';

/*==============================================================*/
/* Index: ICCONTENTITEM_PK                                      */
/*==============================================================*/
create unique index ICCONTENTITEM_PK on ICCONTENTITEM (
ICCO_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_61_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_61_FK on ICCONTENTITEM (
WH_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_62_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_62_FK on ICCONTENTITEM (
ICID_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_63_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_63_FK on ICCONTENTITEM (
PIT_AUTOID ASC
);

/*==============================================================*/
/* Table: ICDIMENTIONS                                          */
/*==============================================================*/
create table ICDIMENTIONS 
(
   IV_DOCUMENTID        integer                        null,
   CP_AUTOID            integer                        null,
   COT_AUTOID           integer                        null,
   PPU_AUTOID           smallint                       null,
   ICDI_AUTOID          integer                        null,
   POSO_DOCUMENTID      integer                        null,
   DOC_OFSUBSYSTEM      smallint                       not null,
   ICD_DETAILID         integer                        not null,
   constraint PK_ICDIMENTIONS primary key (DOC_OFSUBSYSTEM, ICD_DETAILID)
);

comment on table ICDIMENTIONS is 
'Thông tin phân tích cho IC dung cho nhap xu?t chuy?n kho';

comment on column ICDIMENTIONS.POSO_DOCUMENTID is 
'PO hoac SO

PO truong hop xuat kho ban hang tra lai
SO nhap kho ban hang tra lai';

comment on column ICDIMENTIONS.DOC_OFSUBSYSTEM is 
'phân h? con nào t?o ra';

comment on column ICDIMENTIONS.ICD_DETAILID is 
'mã chi ti?t c?a ch?ng t?';

/*==============================================================*/
/* Index: ICDIMENTIONS_PK                                       */
/*==============================================================*/
create unique index ICDIMENTIONS_PK on ICDIMENTIONS (
DOC_OFSUBSYSTEM ASC,
ICD_DETAILID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_88_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_88_FK on ICDIMENTIONS (
CP_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_77_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_77_FK on ICDIMENTIONS (
COT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_89_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_89_FK on ICDIMENTIONS (
IV_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_70_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_70_FK on ICDIMENTIONS (
PPU_AUTOID ASC
);

/*==============================================================*/
/* Table: ICENTRY                                               */
/*==============================================================*/
create table ICENTRY 
(
   ICE_AUTOID           integer                        not null,
   CUR_AUTOID           smallint                       null,
   OBJ_AUTOID           integer                        null,
   COT_AUTOID           integer                        null,
   CP_AUTOID            integer                        null,
   PIT_AUTOID           integer                        null,
   DOC_DOCUMENTID       integer                        null,
   IV_DOCUMENTID        integer                        null,
   ACC_DEPT             char(10)                       null,
   ACC_CREDIT           char(10)                       null,
   ICE_AMOUNT           decimal(18,3)                  null,
   ICE_EXCHANGERATE     decimal(18,3)                  null,
   ICE_BASEAMOUNT       decimal(18,3)                  null,
   ICE_NOTE             varchar(200)                   null,
   PO_DOCUMENTID        integer                        null,
   constraint PK_ICENTRY primary key (ICE_AUTOID)
);

comment on table ICENTRY is 
'Hách Toán cho AM';

comment on column ICENTRY.CUR_AUTOID is 
'ID t? tang';

comment on column ICENTRY.OBJ_AUTOID is 
'mã d?i tu?ng t? d?ng tang';

comment on column ICENTRY.DOC_DOCUMENTID is 
'chung tu xuat kho 
khi ma nhap kho ban thanh pham hay thanh pham theo cong thuc bom thi tu dong tao ra mot chung tu xuat kho tuong ung, neu chung tu xuat kho co loi thi qoay lai chung tu nha kho cha cua no lam lai thao tac nhap kho


....';

comment on column ICENTRY.ACC_DEPT is 
'tài kho?n n?';

comment on column ICENTRY.ACC_CREDIT is 
'tài kho?n có';

comment on column ICENTRY.PO_DOCUMENTID is 
'PO mua hàng 
liên k?t PO';

/*==============================================================*/
/* Index: ICENTRY_PK                                            */
/*==============================================================*/
create unique index ICENTRY_PK on ICENTRY (
ICE_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_114_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_114_FK on ICENTRY (
DOC_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_110_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_110_FK on ICENTRY (
OBJ_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_111_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_111_FK on ICENTRY (
CUR_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_112_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_112_FK on ICENTRY (
COT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_113_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_113_FK on ICENTRY (
IV_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_116_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_116_FK on ICENTRY (
CP_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_108_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_108_FK on ICENTRY (
PIT_AUTOID ASC
);

/*==============================================================*/
/* Table: ICINOUTSTOCK                                          */
/*==============================================================*/
create table ICINOUTSTOCK 
(
   ICIO_DOCUMENTID      integer                        not null,
   OBJ_AUTOID           integer                        null,
   FICI_AUTOID          smallint                       null,
   PUBAT_AUTOID         integer                        null,
   DOTY_AUTOID          smallint                       null,
   WH_AUTOID            integer                        null,
   REIC_DOCUMENTID      integer                        null,
   ST_AUTOID            smallint                       null,
   ICIO_INOUTPUTDATE    timestamp                      null,
   ICIO_ADDRESS         varchar(200)                   null,
   ICIO_INPUTTIME       smallint                       null,
   OBJ_EXECUTEBY        integer                        null,
   ICIO_REASON          varchar(500)                   null,
   WH_ISAPPLY           smallint                       null,
   OBJ_DELIVERYBY       varchar(200)                   null,
   OBJ_RECEIVEBY        varchar(200)                   null,
   ICIO_APTYPE          smallint                       null,
   ICIO_TOTALAMOUNT     decimal(18,3)                  null,
   ICIO_ISINPUT         smallint                       null,
   ICIO_APPORTIONTYPE   smallint                       null,
   constraint PK_ICINOUTSTOCK primary key (ICIO_DOCUMENTID)
);

comment on table ICINOUTSTOCK is 
'Nghi?p v? nh?p kho
danh cho nh?ng l?n nh?p kho
va nghiep vu xuat kho';

comment on column ICINOUTSTOCK.ICIO_DOCUMENTID is 
'l?y t? b?ng document';

comment on column ICINOUTSTOCK.OBJ_AUTOID is 
'mã d?i tu?ng t? d?ng tang';

comment on column ICINOUTSTOCK.PUBAT_AUTOID is 
'mã t? d?ng tang';

comment on column ICINOUTSTOCK.DOTY_AUTOID is 
'Mã mình thêm vào';

comment on column ICINOUTSTOCK.REIC_DOCUMENTID is 
'Mã tài li?u ';

comment on column ICINOUTSTOCK.ST_AUTOID is 
'mã t? d?ng tang';

comment on column ICINOUTSTOCK.ICIO_INOUTPUTDATE is 
'ngay nhap/xu?t kho';

comment on column ICINOUTSTOCK.ICIO_INPUTTIME is 
'L?n nh?p ';

comment on column ICINOUTSTOCK.OBJ_EXECUTEBY is 
'ngu?i th?c hi?n
1 Minh Ðông
nh?p kho là ngu?i nh?p
xu?t kho thì là ngu?i xu?t';

comment on column ICINOUTSTOCK.WH_ISAPPLY is 
'Áp d?ng kho hàng này cho toàn b? Item';

comment on column ICINOUTSTOCK.OBJ_DELIVERYBY is 
'ngu?i giao hàng
danh cho xuat kho';

comment on column ICINOUTSTOCK.OBJ_RECEIVEBY is 
'ngu?i nh?n 
n?u nh?p kho thì là ngu?i bên công ty 
xu?t kho thì là khách hàng';

comment on column ICINOUTSTOCK.ICIO_APTYPE is 
'Lo?i phân b? dùng cho danh sách hóa don phân b?
1 s? lu?ng
2 Giá tr?';

comment on column ICINOUTSTOCK.ICIO_TOTALAMOUNT is 
'Thành ti?n h?ch toán';

comment on column ICINOUTSTOCK.ICIO_ISINPUT is 
'nghi?p v? nh?p kho ngu?c l?i là xu?t kho';

comment on column ICINOUTSTOCK.ICIO_APPORTIONTYPE is 
'Lo?i Phân b? Dành cho phân b? chi phí
1 Phân b? theo s? lu?ng
2 Phân b? theo giá tr?';

/*==============================================================*/
/* Index: ICINOUTSTOCK_PK                                       */
/*==============================================================*/
create unique index ICINOUTSTOCK_PK on ICINOUTSTOCK (
ICIO_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_3_FK on ICINOUTSTOCK (
PUBAT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_67_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_67_FK on ICINOUTSTOCK (
WH_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_120_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_120_FK on ICINOUTSTOCK (
OBJ_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_34_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_34_FK on ICINOUTSTOCK (
FICI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_33_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_33_FK on ICINOUTSTOCK (
REIC_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: NGHIEP_VU_NHAP_KHO_FK                                 */
/*==============================================================*/
create index NGHIEP_VU_NHAP_KHO_FK on ICINOUTSTOCK (
DOTY_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_76_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_76_FK on ICINOUTSTOCK (
ST_AUTOID ASC
);

/*==============================================================*/
/* Table: ICINWARDSTOCKDETAIL                                   */
/*==============================================================*/
create table ICINWARDSTOCKDETAIL 
(
   ICID_AUTOID          integer                        not null,
   PIT_AUTOID           integer                        null,
   ITT_AUTOID           smallint                       null,
   CUR_AUTOID           smallint                       null,
   ITET_AUTOID          smallint                       null,
   UOM_AUTOID           smallint                       null,
   ICIO_DOCUMENTID      integer                        null,
   PIT_ITEMID           integer                        null,
   PIT_ITEMSNO          varchar(150)                   null,
   PIT_ITEMNAME         varchar(200)                   null,
   PO_QUANTITY          decimal(10,3)                  null,
   ICMD_REQUANTITY      decimal(10,3)                  null,
   ICID_INOUTQUANTITY   decimal(10,3)                  null,
   ICID_UNITPRICE       decimal(18,3)                  null,
   ICID_CURRENCYRATE    decimal(18,3)                  null,
   ICID_AMOUNT          decimal(18,3)                  null,
   ICID_OTHERCOST       decimal(18,3)                  null,
   ICID_TOTALAMOUNT     decimal(18,3)                  null,
   ICID_CONVERTQUANTITY1 decimal(18,4)                  null,
   ICID_QUANTITY1       decimal(18,4)                  null,
   ICID_CONVERTQUANTITY2 decimal(10,2)                  null,
   ICID_QUANTITY2       decimal(10,2)                  null,
   UOM_AUTOID2          smallint                       null,
   ICID_DESCRIPTION     varchar(50)                    null,
   ICID_STOCKQUANTITY1  decimal(10,2)                  null,
   ICID_STOCKQUANTITY2  decimal(10,2)                  null,
   constraint PK_ICINWARDSTOCKDETAIL primary key (ICID_AUTOID)
);

comment on table ICINWARDSTOCKDETAIL is 
'chi ti?t nghi?p v? nh?p kho';

comment on column ICINWARDSTOCKDETAIL.ICID_AUTOID is 
'Mã t? dông tang';

comment on column ICINWARDSTOCKDETAIL.CUR_AUTOID is 
'ID t? tang';

comment on column ICINWARDSTOCKDETAIL.ITET_AUTOID is 
'Mã t? d?ng tang';

comment on column ICINWARDSTOCKDETAIL.ICIO_DOCUMENTID is 
'l?y t? b?ng document';

comment on column ICINWARDSTOCKDETAIL.PIT_ITEMID is 
'mã hàng hóa qu?n lý';

comment on column ICINWARDSTOCKDETAIL.PIT_ITEMNAME is 
'Tên ';

comment on column ICINWARDSTOCKDETAIL.PO_QUANTITY is 
'S? lu?ng trên don hàng';

comment on column ICINWARDSTOCKDETAIL.ICMD_REQUANTITY is 
's? lu?ng yêu c?u nh?p/xu?t';

comment on column ICINWARDSTOCKDETAIL.ICID_INOUTQUANTITY is 
's? lu?ng nh?p/xu?t';

comment on column ICINWARDSTOCKDETAIL.ICID_UNITPRICE is 
'Ðon giá nguyên t? (nh?p)
giá v?n';

comment on column ICINWARDSTOCKDETAIL.ICID_CURRENCYRATE is 
't? giá chuy?n d?i';

comment on column ICINWARDSTOCKDETAIL.ICID_AMOUNT is 
'thành ti?n';

comment on column ICINWARDSTOCKDETAIL.ICID_OTHERCOST is 
'chi phi khac';

comment on column ICINWARDSTOCKDETAIL.ICID_TOTALAMOUNT is 
't?ng ti?n';

comment on column ICINWARDSTOCKDETAIL.ICID_CONVERTQUANTITY1 is 
's? lu?ng chuy?n d?i 1';

comment on column ICINWARDSTOCKDETAIL.ICID_QUANTITY1 is 
's? lu?ng quy d?i 1';

comment on column ICINWARDSTOCKDETAIL.ICID_CONVERTQUANTITY2 is 
's? lu?ng chuy?n d?i 2';

comment on column ICINWARDSTOCKDETAIL.ICID_QUANTITY2 is 
's? lu?ng quy d?i 2';

comment on column ICINWARDSTOCKDETAIL.UOM_AUTOID2 is 
'don v? tính quy d?i 2';

comment on column ICINWARDSTOCKDETAIL.ICID_DESCRIPTION is 
'Ghi chu cho m?t hàng này';

comment on column ICINWARDSTOCKDETAIL.ICID_STOCKQUANTITY1 is 
'S? lu?ng t?n kho 1';

comment on column ICINWARDSTOCKDETAIL.ICID_STOCKQUANTITY2 is 
'S? luong t?n kho 2';

/*==============================================================*/
/* Index: ICINWARDSTOCKDETAIL_PK                                */
/*==============================================================*/
create unique index ICINWARDSTOCKDETAIL_PK on ICINWARDSTOCKDETAIL (
ICID_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_4_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_4_FK on ICINWARDSTOCKDETAIL (
ICIO_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_5_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_5_FK on ICINWARDSTOCKDETAIL (
PIT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_74_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_74_FK on ICINWARDSTOCKDETAIL (
UOM_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_146_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_146_FK on ICINWARDSTOCKDETAIL (
ITT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_147_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_147_FK on ICINWARDSTOCKDETAIL (
ITET_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_71_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_71_FK on ICINWARDSTOCKDETAIL (
CUR_AUTOID ASC
);

/*==============================================================*/
/* Table: ICMOVE                                                */
/*==============================================================*/
create table ICMOVE 
(
   ICM_DOCUMENTID       integer                        not null,
   SMT_AUTOID           smallint                       null,
   OBJ_AUTOID           integer                        null,
   FICI_AUTOID          smallint                       null,
   PUBAT_AUTOID         integer                        null,
   ST_AUTOID            smallint                       null,
   ICM_EXECUTEBY        integer                        null,
   ORG_ORGTO            integer                        null,
   ORG_ORGFROM          integer                        null,
   ICM_DOCUMENTATTACH   varchar(200)                   null,
   ICM_RESON            varchar(200)                   null,
   ICM_REQUESTMOVEDATE  timestamp                      null,
   constraint PK_ICMOVE primary key clustered (ICM_DOCUMENTID)
);

comment on table ICMOVE is 
'Nh?p xu?t kho chuy?n';

comment on column ICMOVE.SMT_AUTOID is 
'I tu tang';

comment on column ICMOVE.OBJ_AUTOID is 
'mã d?i tu?ng t? d?ng tang';

comment on column ICMOVE.PUBAT_AUTOID is 
'mã t? d?ng tang';

comment on column ICMOVE.ST_AUTOID is 
'mã t? d?ng tang';

comment on column ICMOVE.ICM_EXECUTEBY is 
'nguoi thuc hien';

comment on column ICMOVE.ORG_ORGTO is 
'Phong ban nhan';

comment on column ICMOVE.ORG_ORGFROM is 
'b? ph?n chuy?n';

comment on column ICMOVE.ICM_DOCUMENTATTACH is 
'Ch?ng t? kèm theo la mot file ';

comment on column ICMOVE.ICM_REQUESTMOVEDATE is 
'ngày yêu c?u chuy?n';

/*==============================================================*/
/* Index: RELATIONSHIP_81_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_81_FK on ICMOVE (
OBJ_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_36_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_36_FK on ICMOVE (
FICI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_69_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_69_FK on ICMOVE (
SMT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_86_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_86_FK on ICMOVE (
PUBAT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_66_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_66_FK on ICMOVE (
ST_AUTOID ASC
);

/*==============================================================*/
/* Table: ICMOVEDETAIL                                          */
/*==============================================================*/
create table ICMOVEDETAIL 
(
   ICMD_AUTOID          integer                        not null,
   UOM_AUTOID           smallint                       null,
   ITT_AUTOID           smallint                       null,
   PIT_AUTOID           integer                        null,
   ST_AUTOID            smallint                       null,
   ITET_AUTOID          smallint                       null,
   ICM_DOCUMENTID       integer                        null,
   PIT_ITEMNO           char(10)                       null,
   PIT_ITEMNAME         varchar(200)                   null,
   ICMD_QUANTITY        numeric(18,2)                  null,
   WH_WHOUSEFROM        integer                        null,
   ITP_POSITIONFROM     smallint                       null,
   WH_WHOUSETO          smallint                       null,
   ITP_POSITIONTO       smallint                       null,
   ICMD_REQUANTITY      decimal(10,3)                  null,
   ICMD_STOREQUANTITY   decimal(10,3)                  null,
   ICMD_MOVEDATE        timestamp                      null,
   ICMD_UNITPRICE       decimal(18,3)                  null,
   ICMD_AMOUNT          decimal(18,3)                  null,
   ICMD_OTHERAMOUNT     decimal(18,3)                  null,
   ICMD_TOTALAMOUNT     decimal(18,3)                  null,
   ICMD_NOTE            varchar(50)                    null,
   ICMD_CONVERTQUANTITY1 smallint                       null,
   ICMD_QUANTITY1       decimal(10,2)                  null,
   ICMD_CONVERTQUANTITY2 decimal(10,2)                  null,
   ICMD_QUANTITY2       decimal(10,2)                  null,
   UOM_AUTOID2          smallint                       null,
   constraint PK_ICMOVEDETAIL primary key (ICMD_AUTOID)
);

comment on table ICMOVEDETAIL is 
'Chi ti?t c?a IC';

comment on column ICMOVEDETAIL.ICMD_AUTOID is 
'Mã t? dông tang';

comment on column ICMOVEDETAIL.ST_AUTOID is 
'mã t? d?ng tang';

comment on column ICMOVEDETAIL.ITET_AUTOID is 
'Mã t? d?ng tang';

comment on column ICMOVEDETAIL.PIT_ITEMNO is 
'Mã Item t? qu?n lý';

comment on column ICMOVEDETAIL.PIT_ITEMNAME is 
'Tên ';

comment on column ICMOVEDETAIL.ICMD_QUANTITY is 
'S? lu?ng';

comment on column ICMOVEDETAIL.WH_WHOUSEFROM is 
't? kho nào';

comment on column ICMOVEDETAIL.WH_WHOUSETO is 
't?i kho nào';

comment on column ICMOVEDETAIL.ICMD_REQUANTITY is 
's? lu?ng yêu c?u nh?p/xu?t';

comment on column ICMOVEDETAIL.ICMD_STOREQUANTITY is 
's? lu?ng t?n kho';

comment on column ICMOVEDETAIL.ICMD_MOVEDATE is 
'ngày chuy?n';

comment on column ICMOVEDETAIL.ICMD_UNITPRICE is 
'don giá';

comment on column ICMOVEDETAIL.ICMD_AMOUNT is 
'thành ti?n';

comment on column ICMOVEDETAIL.ICMD_OTHERAMOUNT is 
'chi phi khac hay chi phi lien quan
';

comment on column ICMOVEDETAIL.ICMD_TOTALAMOUNT is 
't?ng ti?n';

comment on column ICMOVEDETAIL.ICMD_NOTE is 
'Ghi chu cho m?t hàng này';

comment on column ICMOVEDETAIL.ICMD_CONVERTQUANTITY1 is 
'so luong chuyen doi 1';

comment on column ICMOVEDETAIL.ICMD_QUANTITY1 is 
's? lu?ng 1';

comment on column ICMOVEDETAIL.ICMD_QUANTITY2 is 
'S? lu?ng 2';

comment on column ICMOVEDETAIL.UOM_AUTOID2 is 
'don v? tính quy d?i 2';

/*==============================================================*/
/* Index: ICMOVEDETAIL_PK                                       */
/*==============================================================*/
create unique index ICMOVEDETAIL_PK on ICMOVEDETAIL (
ICMD_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_84_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_84_FK on ICMOVEDETAIL (
ICM_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_85_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_85_FK on ICMOVEDETAIL (
PIT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_38_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_38_FK on ICMOVEDETAIL (
ITET_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_39_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_39_FK on ICMOVEDETAIL (
ITT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_79_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_79_FK on ICMOVEDETAIL (
ST_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_82_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_82_FK on ICMOVEDETAIL (
UOM_AUTOID ASC
);

/*==============================================================*/
/* Table: ICOTHERCOST                                           */
/*==============================================================*/
create table ICOTHERCOST 
(
   IV_DOCUMENTID        integer                        not null,
   DOC_DOCUMENTID       integer                        not null,
   constraint PK_ICOTHERCOST primary key clustered (IV_DOCUMENTID, DOC_DOCUMENTID)
);

comment on table ICOTHERCOST is 
'Chi phí khác dành cho phân b?';

comment on column ICOTHERCOST.DOC_DOCUMENTID is 
'chung tu xuat kho 
khi ma nhap kho ban thanh pham hay thanh pham theo cong thuc bom thi tu dong tao ra mot chung tu xuat kho tuong ung, neu chung tu xuat kho co loi thi qoay lai chung tu nha kho cha cua no lam lai thao tac nhap kho


....';

/*==============================================================*/
/* Table: ICPLAN                                                */
/*==============================================================*/
create table ICPLAN 
(
   ACPL_DOCUMENTID      integer                        not null,
   OBJ_AUTOID           integer                        null,
   WH_AUTOID            integer                        null,
   ACPL_SUMMARY         varchar(100)                   null,
   ACPL_RESION          varchar(100)                   null,
   OBJ_REQUESTBY        smallint                       null,
   OBJ_REQUESTNAME      varchar(150)                   null,
   ACPL_STARTDATE       timestamp                      null,
   ACPL_ENDDATE         timestamp                      null,
   ACPL_COSTID          numeric(18,3)                  null,
   ACPL_OVERDUEDATE     numeric(10,2)                  null,
   ACPL_INOUTDATE       timestamp                      null,
   ACPL_ISACTIVE        smallint                       null,
   ORG_REQUIRE          integer                        null,
   ORG_CREATEID         integer                        null,
   constraint PK_ICPLAN primary key (ACPL_DOCUMENTID)
);

comment on table ICPLAN is 
'K? ho?ch nh?p xu?t';

comment on column ICPLAN.OBJ_AUTOID is 
'mã d?i tu?ng t? d?ng tang';

comment on column ICPLAN.ACPL_SUMMARY is 
'Diengiai cho phieu nay';

comment on column ICPLAN.ACPL_RESION is 
'lý do t?o phi?u ';

comment on column ICPLAN.OBJ_REQUESTBY is 
'Ngu?i yêu c?u
NV001';

comment on column ICPLAN.OBJ_REQUESTNAME is 
'Ten nguoi yeu cau';

comment on column ICPLAN.ACPL_STARTDATE is 
'ngày b?t d?u';

comment on column ICPLAN.ACPL_ENDDATE is 
'ngày k?t thúc';

comment on column ICPLAN.ACPL_COSTID is 
'Chi phi nh?p xu?t';

comment on column ICPLAN.ACPL_OVERDUEDATE is 
'ngày tr? h?n cho phép';

comment on column ICPLAN.ACPL_INOUTDATE is 
'ngày nh?p xu?t th?c t?';

comment on column ICPLAN.ORG_REQUIRE is 
'Bo phan yeu cau';

comment on column ICPLAN.ORG_CREATEID is 
'bo phan tao';

/*==============================================================*/
/* Index: ICPLAN_PK                                             */
/*==============================================================*/
create unique index ICPLAN_PK on ICPLAN (
ACPL_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_78_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_78_FK on ICPLAN (
WH_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_35_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_35_FK on ICPLAN (
OBJ_AUTOID ASC
);

/*==============================================================*/
/* Table: ICPLANDETAIL                                          */
/*==============================================================*/
create table ICPLANDETAIL 
(
   ICPD_AUTOID          integer                        not null,
   ITET_AUTOID          smallint                       null,
   PIT_AUTOID           integer                        null,
   ITT_AUTOID           smallint                       null,
   ACPL_DOCUMENTID      integer                        null,
   ICPD_ITEMID          char(10)                       null,
   ICPD_ITEMNAME        varchar(200)                   null,
   ICPD_PACKING         varchar(100)                   null,
   ICPD_QUANTITY        numeric(18,2)                  null,
   ICPD_NOTE            varchar(50)                    null,
   ICPD_ISACTIVITY      smallint                       null,
   ICPD_UOMINPUT        smallint                       null,
   ICPD_BARCODE         char(10)                       null,
   ICPD_QUANTITY1       decimal(10,2)                  null,
   ICPD_UOM1            smallint                       null,
   ICPD_QUANTITY2       decimal(10,2)                  null,
   ICPD_UOM2            smallint                       null,
   constraint PK_ICPLANDETAIL primary key (ICPD_AUTOID)
);

comment on table ICPLANDETAIL is 
'Chi ti?t c?a IC';

comment on column ICPLANDETAIL.ICPD_AUTOID is 
'Mã t? dông tang';

comment on column ICPLANDETAIL.ITET_AUTOID is 
'Mã t? d?ng tang';

comment on column ICPLANDETAIL.ICPD_ITEMID is 
'Mã Item t? qu?n lý';

comment on column ICPLANDETAIL.ICPD_PACKING is 
' Qui cách bao bì ';

comment on column ICPLANDETAIL.ICPD_QUANTITY is 
'S? lu?ng';

comment on column ICPLANDETAIL.ICPD_NOTE is 
'Ghi chu cho m?t hàng này';

comment on column ICPLANDETAIL.ICPD_ISACTIVITY is 
'Ðu?c kích ho?t không';

comment on column ICPLANDETAIL.ICPD_UOMINPUT is 
'Ðon v? tính nh?p';

comment on column ICPLANDETAIL.ICPD_QUANTITY1 is 
's? lu?ng 1';

comment on column ICPLANDETAIL.ICPD_UOM1 is 
'Ðon v? tính tòn kho 1';

comment on column ICPLANDETAIL.ICPD_QUANTITY2 is 
'S? lu?ng 2';

comment on column ICPLANDETAIL.ICPD_UOM2 is 
'Ðon v? tính t?n kho 2';

/*==============================================================*/
/* Index: ICPLANDETAIL_PK                                       */
/*==============================================================*/
create unique index ICPLANDETAIL_PK on ICPLANDETAIL (
ICPD_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_96_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_96_FK on ICPLANDETAIL (
ACPL_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_97_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_97_FK on ICPLANDETAIL (
PIT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_40_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_40_FK on ICPLANDETAIL (
ITET_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_41_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_41_FK on ICPLANDETAIL (
ITT_AUTOID ASC
);

/*==============================================================*/
/* Table: ICPLOT                                                */
/*==============================================================*/
create table ICPLOT 
(
   ICP_AUTOID           integer                        not null,
   ICP_NAME             varchar(100)                   null,
   ICP_FIRSTPART        char(10)                       null,
   ICP_NUMBERPART       integer                        null,
   ICP_LASTPART         char(10)                       null,
   ICP_DESCRIPTION      varchar(200)                   null,
   ICP_ISACTIVE         smallint                       null,
   ICP_SERIALEND        char(40)                       null,
   constraint PK_ICPLOT primary key clustered (ICP_AUTOID)
);

comment on table ICPLOT is 
'Lô hàng ';

comment on column ICPLOT.ICP_NAME is 
'tên ';

comment on column ICPLOT.ICP_FIRSTPART is 
'Ph?n d?u';

comment on column ICPLOT.ICP_NUMBERPART is 
'Ph?n s?';

comment on column ICPLOT.ICP_LASTPART is 
'Ph?n duôi';

comment on column ICPLOT.ICP_SERIALEND is 
'serial cuoi cung';

/*==============================================================*/
/* Table: ICPURPOSEUSE                                          */
/*==============================================================*/
create table ICPURPOSEUSE 
(
   PPU_AUTOID           smallint                       not null,
   PPU_NAME             varchar(150)                   null,
   PPU_DESCRIPTION      varchar(200)                   null,
   PPU_ISACTIVE         smallint                       null,
   constraint PK_ICPURPOSEUSE primary key (PPU_AUTOID)
);

comment on table ICPURPOSEUSE is 
'M?c dích nh?p kho';

/*==============================================================*/
/* Index: ICPURPOSEUSE_PK                                       */
/*==============================================================*/
create unique index ICPURPOSEUSE_PK on ICPURPOSEUSE (
PPU_AUTOID ASC
);

/*==============================================================*/
/* Table: ICREQUES                                              */
/*==============================================================*/
create table ICREQUES 
(
   REIC_DOCUMENTID      integer                        not null,
   WH_AUTOID            integer                        null,
   OBJ_AUTOID           integer                        null,
   ST_AUTOID            smallint                       null,
   DOTY_AUTOID          smallint                       null,
   FICI_AUTOID          smallint                       null,
   REID_REQUIREDATE     date                           null,
   OBJ_REQUIREBY        smallint                       null,
   ORG_REQUIRE          integer                        null,
   REID_INOUTDATE       timestamp                      null,
   REID_RESION          varchar(200)                   null,
   constraint PK_ICREQUES primary key (REIC_DOCUMENTID)
);

comment on table ICREQUES is 
'yêu c?u cho kho có th? nh?p ho?c có th? xu?t';

comment on column ICREQUES.REIC_DOCUMENTID is 
'Mã tài li?u ';

comment on column ICREQUES.OBJ_AUTOID is 
'mã d?i tu?ng t? d?ng tang';

comment on column ICREQUES.ST_AUTOID is 
'mã t? d?ng tang';

comment on column ICREQUES.DOTY_AUTOID is 
'Mã mình thêm vào';

comment on column ICREQUES.REID_REQUIREDATE is 
'Ngày yêu c?u';

comment on column ICREQUES.OBJ_REQUIREBY is 
'Ngu?i yêu c?u ';

comment on column ICREQUES.ORG_REQUIRE is 
'Bo phan yeu cau';

comment on column ICREQUES.REID_INOUTDATE is 
'ngày nh?p xu?t hàng ';

comment on column ICREQUES.REID_RESION is 
'lý do ';

/*==============================================================*/
/* Index: ICREQUES_PK                                           */
/*==============================================================*/
create unique index ICREQUES_PK on ICREQUES (
REIC_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_100_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_100_FK on ICREQUES (
WH_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_37_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_37_FK on ICREQUES (
FICI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_53_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_53_FK on ICREQUES (
OBJ_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_87_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_87_FK on ICREQUES (
DOTY_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_72_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_72_FK on ICREQUES (
ST_AUTOID ASC
);

/*==============================================================*/
/* Table: ICREQUESDETAIL                                        */
/*==============================================================*/
create table ICREQUESDETAIL 
(
   RICD_AUTOID          integer                        not null,
   ITET_AUTOID          smallint                       null,
   REIC_DOCUMENTID      integer                        null,
   PIT_AUTOID           integer                        null,
   ITT_AUTOID           char(10)                       null,
   RICD_ITEMID          char(10)                       null,
   RICD_ITEMNAME        varchar(200)                   null,
   POSO_QUANTITY        decimal(10,2)                  null,
   POSO_UOM             smallint                       null,
   RICD_QUANTITY1       decimal(10,2)                  null,
   RICD_UOM1            smallint                       null,
   RICD_QUANTITY2       decimal(10,2)                  null,
   RICD_UOM2            smallint                       null,
   RICD_PO_SO           integer                        null,
   RICD_PURQUANTITY     decimal(10,2)                  null,
   RICD_PURUOM          smallint                       null,
   RICD_APPQUANTITY     decimal(10,2)                  null,
   RICD_APPUOM          smallint                       null,
   RICD_APPUNITPRICE    decimal(18,3)                  null,
   RICD_CURRENTCYRATE   decimal(4,2)                   null,
   RICD_TOTALAMOUNT     decimal(18,3)                  null,
   RICD_POSTAMOUNT      decimal(18,3)                  null,
   constraint PK_ICREQUESDETAIL primary key (RICD_AUTOID)
);

comment on table ICREQUESDETAIL is 
'Chi ti?t c?a IC';

comment on column ICREQUESDETAIL.RICD_AUTOID is 
'Mã t? dông tang';

comment on column ICREQUESDETAIL.ITET_AUTOID is 
'Mã t? d?ng tang';

comment on column ICREQUESDETAIL.REIC_DOCUMENTID is 
'Mã tài li?u ';

comment on column ICREQUESDETAIL.RICD_ITEMID is 
'Mã Item t? qu?n lý';

comment on column ICREQUESDETAIL.POSO_QUANTITY is 
'S? lu?ng  tren don hang SO hoac PO';

comment on column ICREQUESDETAIL.POSO_UOM is 
'Ðon v? tính nh?p Tren PO hoac SO';

comment on column ICREQUESDETAIL.RICD_QUANTITY1 is 
's? lu?ng 1';

comment on column ICREQUESDETAIL.RICD_UOM1 is 
'Ðon v? tính tòn kho 1';

comment on column ICREQUESDETAIL.RICD_QUANTITY2 is 
'S? lu?ng 2';

comment on column ICREQUESDETAIL.RICD_UOM2 is 
'Ðon v? tính t?n kho 2';

comment on column ICREQUESDETAIL.RICD_PO_SO is 
'Danh cho PO hoac SO';

comment on column ICREQUESDETAIL.RICD_PURQUANTITY is 
'So luong yeu cau';

comment on column ICREQUESDETAIL.RICD_PURUOM is 
'Don vi yeu cau nhap';

comment on column ICREQUESDETAIL.RICD_APPQUANTITY is 
'So luong Duyet';

comment on column ICREQUESDETAIL.RICD_APPUOM is 
'D9on vi duyet';

comment on column ICREQUESDETAIL.RICD_APPUNITPRICE is 
'Don gia';

comment on column ICREQUESDETAIL.RICD_CURRENTCYRATE is 
'Ty gia';

comment on column ICREQUESDETAIL.RICD_TOTALAMOUNT is 
'tien nguyen te';

comment on column ICREQUESDETAIL.RICD_POSTAMOUNT is 
'tien hach toan';

/*==============================================================*/
/* Index: ICREQUESDETAIL_PK                                     */
/*==============================================================*/
create unique index ICREQUESDETAIL_PK on ICREQUESDETAIL (
RICD_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_98_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_98_FK on ICREQUESDETAIL (
REIC_DOCUMENTID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_99_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_99_FK on ICREQUESDETAIL (
PIT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_42_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_42_FK on ICREQUESDETAIL (
ITET_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_43_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_43_FK on ICREQUESDETAIL (
ITT_AUTOID ASC
);

/*==============================================================*/
/* Table: ICSTOCK                                               */
/*==============================================================*/
create table ICSTOCK 
(
   PST_AUTOID           integer                        not null,
   ORG_AUTOID           integer                        null,
   FICI_AUTOID          smallint                       null,
   PIT_AUTOID           integer                        null,
   PIT_ITEMNAME         varchar(200)                   null,
   PIT_ITEMNO           char(10)                       null,
   PST_BEGINQUANTITY1   char(10)                       null,
   UOM_BEGINAUTOID1     char(10)                       null,
   PST_BEGINQUANTITY2   char(10)                       null,
   UOM_BEGINAUTOID2     char(10)                       null,
   UOM_AUTOID1          smallint                       null,
   PST_QUANTITY1        decimal(10,3)                  null,
   PST_QUANTITY2        decimal(10,3)                  null,
   UOM_AUTOID2          smallint                       null,
   PST_UNITPRICE        decimal(18,3)                  null,
   PST_ENDQUANTITY1     char(10)                       null,
   UOM_ENDAUTOID1       char(10)                       null,
   PST_ENDQUANTITY2     char(10)                       null,
   UOM_ENDAUTOID2       char(10)                       null,
   constraint PK_ICSTOCK primary key (PST_AUTOID)
);

comment on table ICSTOCK is 
'Kho hàng noi dây du?c coi là m?t cái kho hàng hóa mà ch?a s? lu?ng và s? serrial 
khi nh?p kho t? d?ng c?p nh?t s? lu?ng trong kho 
khi xuât hàng t? d?ng tr? s? lu?ng trong kho này tuong ?ng v?i 

';

comment on column ICSTOCK.PST_AUTOID is 
'ID này du?c l?y t? b?ng Item';

comment on column ICSTOCK.ORG_AUTOID is 
'Mã t? ch?c - Mã Công ty - Mã Chi Nhánh - Mã Phòng ban';

comment on column ICSTOCK.PIT_ITEMNAME is 
'Tên ';

comment on column ICSTOCK.PIT_ITEMNO is 
'Mã Item t? qu?n lý';

comment on column ICSTOCK.PST_QUANTITY2 is 
'S? lu?ng chu?n 1';

comment on column ICSTOCK.UOM_AUTOID2 is 
'don v? tính quy d?i 2';

comment on column ICSTOCK.PST_UNITPRICE is 
'Don gia';

/*==============================================================*/
/* Index: ICSTOCK_PK                                            */
/*==============================================================*/
create unique index ICSTOCK_PK on ICSTOCK (
PST_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_64_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_64_FK on ICSTOCK (
PIT_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_83_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_83_FK on ICSTOCK (
FICI_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_109_FK                                   */
/*==============================================================*/
create index RELATIONSHIP_109_FK on ICSTOCK (
ORG_AUTOID ASC
);

/*==============================================================*/
/* Table: ICSTOCKDETAIL                                         */
/*==============================================================*/
create table ICSTOCKDETAIL 
(
   ICSD_AUTOID          integer                        not null,
   ICSD_DOCUMENTNO      char(20)                       null,
   constraint PK_ICSTOCKDETAIL primary key (ICSD_AUTOID)
);

comment on table ICSTOCKDETAIL is 
'Serial cho Item
chua ma serrial';

/*==============================================================*/
/* Index: ICSTOCKDETAIL_PK                                      */
/*==============================================================*/
create unique index ICSTOCKDETAIL_PK on ICSTOCKDETAIL (
ICSD_AUTOID ASC
);

/*==============================================================*/
/* Table: ICSTOCKJOIN                                           */
/*==============================================================*/
create table ICSTOCKJOIN 
(
   ICID_AUTOID          integer                        not null,
   ICSD_AUTOID          integer                        not null,
   PST_AUTOID           integer                        not null,
   ICMD_AUTOID          integer                        not null,
   WH_AUTOID            integer                        not null,
   ITP_AUTOID           smallint                       not null,
   PK_AUTOID            smallint                       not null,
   ICWC_AUTOID          smallint                       not null,
   ITET_AUTOID          smallint                       not null,
   MANU_AUTOID          smallint                       not null,
   CUR_AUTOID           smallint                       not null,
   ICP_AUTOID           integer                        null,
   ICS_STOCQUANTITY1    decimal(10,2)                  null,
   UOM_AUTOID1          smallint                       null,
   ISC_UNITPRICE        decimal(18,3)                  null,
   ICS_CURRENCYRATE     decimal(18,3)                  null,
   ICS_DOCUMENTID       integer                        null,
   ICS_OTHERCOST        decimal(18,3)                  null,
   ICS_STATUS           smallint                       null,
   ICS_STOCQUANTITY2    decimal(10,2)                  null,
   UOM_AUTOID2          smallint                       null,
   ICS_WARRANTYENDDATE  timestamp                      null,
   ICS_WARRANTYBEGINDATE timestamp                      null,
   PIT_ITEMNO           char(10)                       null,
   PIT_ITEMNAME         varchar(200)                   null,
   constraint PK_ICSTOCKJOIN primary key clustered (ICID_AUTOID, ICSD_AUTOID, PST_AUTOID, ICMD_AUTOID, WH_AUTOID, ITP_AUTOID, PK_AUTOID, ICWC_AUTOID, ITET_AUTOID, MANU_AUTOID, CUR_AUTOID)
);

comment on table ICSTOCKJOIN is 
'bang ket giua IC va Serial
';

comment on column ICSTOCKJOIN.ICID_AUTOID is 
'Mã t? dông tang';

comment on column ICSTOCKJOIN.PST_AUTOID is 
'ID này du?c l?y t? b?ng Item';

comment on column ICSTOCKJOIN.ICMD_AUTOID is 
'Mã t? dông tang';

comment on column ICSTOCKJOIN.ITP_AUTOID is 
'Id t? tang';

comment on column ICSTOCKJOIN.ITET_AUTOID is 
'Mã t? d?ng tang';

comment on column ICSTOCKJOIN.CUR_AUTOID is 
'ID t? tang';

comment on column ICSTOCKJOIN.ISC_UNITPRICE is 
'don giá quy d?i s? t? l? v?i don giá ';

comment on column ICSTOCKJOIN.ICS_DOCUMENTID is 
'Mã ch?ng t? g?c';

comment on column ICSTOCKJOIN.ICS_OTHERCOST is 
'chi phi liên quan';

comment on column ICSTOCKJOIN.ICS_STATUS is 
'Trang thai cua M?t hàng này
1 nh?p
2 xu?t 
3 Chuyên kho

cho biet tinh trang mat hàng này th? nào d? báo cáo cho d?';

comment on column ICSTOCKJOIN.UOM_AUTOID2 is 
'don v? tính quy d?i 2';

comment on column ICSTOCKJOIN.ICS_WARRANTYENDDATE is 
'Ngày k?t thúc b?o hành';

comment on column ICSTOCKJOIN.ICS_WARRANTYBEGINDATE is 
'ngay bat dau bao hanh';

comment on column ICSTOCKJOIN.PIT_ITEMNO is 
'Mã Item t? qu?n lý';

comment on column ICSTOCKJOIN.PIT_ITEMNAME is 
'Tên ';

/*==============================================================*/
/* Index: ICSTOCKJOIN_PK                                        */
/*==============================================================*/
create unique clustered index ICSTOCKJOIN_PK on ICSTOCKJOIN (
ICID_AUTOID ASC,
ICSD_AUTOID ASC,
PST_AUTOID ASC,
ICMD_AUTOID ASC,
WH_AUTOID ASC,
ITP_AUTOID ASC,
PK_AUTOID ASC,
ICWC_AUTOID ASC,
ITET_AUTOID ASC,
MANU_AUTOID ASC,
CUR_AUTOID ASC
);

/*==============================================================*/
/* Index: ICSTOCKJOIN_FK                                        */
/*==============================================================*/
create index ICSTOCKJOIN_FK on ICSTOCKJOIN (
ICID_AUTOID ASC
);

/*==============================================================*/
/* Index: ICSTOCKJOIN2_FK                                       */
/*==============================================================*/
create index ICSTOCKJOIN2_FK on ICSTOCKJOIN (
ICSD_AUTOID ASC
);

/*==============================================================*/
/* Index: ICSTOCKJOIN3_FK                                       */
/*==============================================================*/
create index ICSTOCKJOIN3_FK on ICSTOCKJOIN (
PST_AUTOID ASC
);

/*==============================================================*/
/* Index: ICSTOCKJOIN4_FK                                       */
/*==============================================================*/
create index ICSTOCKJOIN4_FK on ICSTOCKJOIN (
ICMD_AUTOID ASC
);

/*==============================================================*/
/* Index: ICSTOCKJOIN5_FK                                       */
/*==============================================================*/
create index ICSTOCKJOIN5_FK on ICSTOCKJOIN (
ICP_AUTOID ASC
);

/*==============================================================*/
/* Index: ICSTOCKJOIN6_FK                                       */
/*==============================================================*/
create index ICSTOCKJOIN6_FK on ICSTOCKJOIN (
WH_AUTOID ASC
);

/*==============================================================*/
/* Index: ICSTOCKJOIN7_FK                                       */
/*==============================================================*/
create index ICSTOCKJOIN7_FK on ICSTOCKJOIN (
ITP_AUTOID ASC
);

/*==============================================================*/
/* Index: ICSTOCKJOIN8_FK                                       */
/*==============================================================*/
create index ICSTOCKJOIN8_FK on ICSTOCKJOIN (
PK_AUTOID ASC
);

/*==============================================================*/
/* Index: ICSTOCKJOIN9_FK                                       */
/*==============================================================*/
create index ICSTOCKJOIN9_FK on ICSTOCKJOIN (
ICWC_AUTOID ASC
);

/*==============================================================*/
/* Index: ICSTOCKJOIN10_FK                                      */
/*==============================================================*/
create index ICSTOCKJOIN10_FK on ICSTOCKJOIN (
ITET_AUTOID ASC
);

/*==============================================================*/
/* Index: ICSTOCKJOIN11_FK                                      */
/*==============================================================*/
create index ICSTOCKJOIN11_FK on ICSTOCKJOIN (
MANU_AUTOID ASC
);

/*==============================================================*/
/* Index: ICSTOCKJOIN12_FK                                      */
/*==============================================================*/
create index ICSTOCKJOIN12_FK on ICSTOCKJOIN (
CUR_AUTOID ASC
);

/*==============================================================*/
/* Table: ICSTOREWARRANTY                                       */
/*==============================================================*/
create table ICSTOREWARRANTY 
(
   ICSW_AUTOID          integer                        not null,
   PK_AUTOID            smallint                       null,
   ITP_AUTOID           smallint                       null,
   WH_AUTOID            integer                        null,
   ICWC_AUTOID          smallint                       null,
   MANU_AUTOID          smallint                       null,
   ICP_AUTOID           integer                        null,
   DOC_OFSUBSYSTEM      smallint                       null,
   ICD_DETAILID         integer                        null,
   ICSW_WARRANTYDATE    timestamp                      null,
   ICSW_WARRANTYENDDATE timestamp                      null,
   ICSW_EXPRICEDATE     timestamp                      null,
   constraint PK_ICSTOREWARRANTY primary key (ICSW_AUTOID)
);

comment on table ICSTOREWARRANTY is 
'Luu tr? b?o hành';

comment on column ICSTOREWARRANTY.ITP_AUTOID is 
'Id t? tang';

comment on column ICSTOREWARRANTY.DOC_OFSUBSYSTEM is 
'phân h? con nào t?o ra';

comment on column ICSTOREWARRANTY.ICD_DETAILID is 
'mã chi ti?t c?a ch?ng t?';

comment on column ICSTOREWARRANTY.ICSW_WARRANTYDATE is 
'ngày b?t d?u b?o hành 
';

comment on column ICSTOREWARRANTY.ICSW_EXPRICEDATE is 
'han su dung';

/*==============================================================*/
/* Index: ICSTOREWARRANTY_PK                                    */
/*==============================================================*/
create unique index ICSTOREWARRANTY_PK on ICSTOREWARRANTY (
ICSW_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_80_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_80_FK on ICSTOREWARRANTY (
PK_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_90_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_90_FK on ICSTOREWARRANTY (
ICP_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_75_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_75_FK on ICSTOREWARRANTY (
WH_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_68_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_68_FK on ICSTOREWARRANTY (
ITP_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_60_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_60_FK on ICSTOREWARRANTY (
MANU_AUTOID ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_73_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_73_FK on ICSTOREWARRANTY (
ICWC_AUTOID ASC
);

/*==============================================================*/
/* Table: ICWARRANTYCODE                                        */
/*==============================================================*/
create table ICWARRANTYCODE 
(
   ICWC_AUTOID          smallint                       not null,
   ICWC_DOCUMENTNO      char(20)                       null,
   ICWC_DESCRIPTION     varchar(200)                   null,
   ICWC_VAULES          decimal(10,2)                  null,
   ICWC_TYPE            smallint                       null,
   ICWC_ISACTIVE        smallint                       null,
   constraint PK_ICWARRANTYCODE primary key (ICWC_AUTOID)
);

comment on table ICWARRANTYCODE is 
'nhãn b?o hành';

comment on column ICWARRANTYCODE.ICWC_TYPE is 
'Lo?i 
1 ngày 
2 tu?n  6 ngay
3 tháng 30 ngay
4 nam 365 ngay';

/*==============================================================*/
/* Index: ICWARRANTYCODE_PK                                     */
/*==============================================================*/
create unique index ICWARRANTYCODE_PK on ICWARRANTYCODE (
ICWC_AUTOID ASC
);

/*==============================================================*/
/* Table: INVOICE                                               */
/*==============================================================*/
create table INVOICE 
(
   IV_DOCUMENTID        integer                        not null,
   constraint PK_INVOICE primary key (IV_DOCUMENTID)
);

comment on table INVOICE is 
'Hóa don Chung v?i hóa don này sài chung cho AR,AP,CM,GL 
nên thông tin nên c?n th?n';

/*==============================================================*/
/* Index: INVOICE_PK                                            */
/*==============================================================*/
create unique index INVOICE_PK on INVOICE (
IV_DOCUMENTID ASC
);

/*==============================================================*/
/* Table: ITEMSPOSITION                                         */
/*==============================================================*/
create table ITEMSPOSITION 
(
   ITP_AUTOID           smallint                       not null,
   constraint PK_ITEMSPOSITION primary key (ITP_AUTOID)
);

comment on table ITEMSPOSITION is 
'vi tri hang hoa trong kho';

comment on column ITEMSPOSITION.ITP_AUTOID is 
'Id t? tang';

/*==============================================================*/
/* Index: ITEMSPOSITION_PK                                      */
/*==============================================================*/
create unique index ITEMSPOSITION_PK on ITEMSPOSITION (
ITP_AUTOID ASC
);

/*==============================================================*/
/* Table: ITEMTYPE                                              */
/*==============================================================*/
create table ITEMTYPE 
(
   ITT_AUTOID           char(10)                       not null,
   constraint PK_ITEMTYPE primary key (ITT_AUTOID)
);

comment on table ITEMTYPE is 
'Lo?i Dùng d? ch?n
Item
Descriptor
None

form nay khong code';

/*==============================================================*/
/* Index: ITEMTYPE_PK                                           */
/*==============================================================*/
create unique index ITEMTYPE_PK on ITEMTYPE (
ITT_AUTOID ASC
);

/*==============================================================*/
/* Table: PUBBATCH                                              */
/*==============================================================*/
create table PUBBATCH 
(
   PUBAT_AUTOID         integer                        not null,
   constraint PK_PUBBATCH primary key (PUBAT_AUTOID)
);

comment on table PUBBATCH is 
'Nghi?p v? s? lý 
dành cho AR,Ap,CM,IC,FA';

comment on column PUBBATCH.PUBAT_AUTOID is 
'mã t? d?ng tang';

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
'h?p d?ng';

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
'B?ng  danh m?c ti?n t?
lo?i ti?n';

comment on column PUBCURRENCY.CUR_AUTOID is 
'ID t? tang';

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

comment on column PUBDOCUMENT.DOC_DOCUMENTID is 
'chung tu xuat kho 
khi ma nhap kho ban thanh pham hay thanh pham theo cong thuc bom thi tu dong tao ra mot chung tu xuat kho tuong ung, neu chung tu xuat kho co loi thi qoay lai chung tu nha kho cha cua no lam lai thao tac nhap kho


....';

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
/* Table: PUBMANUFACTURER                                       */
/*==============================================================*/
create table PUBMANUFACTURER 
(
   MANU_AUTOID          smallint                       not null,
   constraint PK_PUBMANUFACTURER primary key (MANU_AUTOID)
);

comment on table PUBMANUFACTURER is 
'nhà s?n xu?t';

/*==============================================================*/
/* Index: PUBMANUFACTURER_PK                                    */
/*==============================================================*/
create unique index PUBMANUFACTURER_PK on PUBMANUFACTURER (
MANU_AUTOID ASC
);

/*==============================================================*/
/* Table: PUBOBJECT                                             */
/*==============================================================*/
create table PUBOBJECT 
(
   OBJ_AUTOID           integer                        not null,
   constraint PK_PUBOBJECT primary key (OBJ_AUTOID)
);

comment on table PUBOBJECT is 
'là m?t d?i tu?ng Tu?ng chung cho nhà cung c?p, khách hàng,...';

comment on column PUBOBJECT.OBJ_AUTOID is 
'mã d?i tu?ng t? d?ng tang';

/*==============================================================*/
/* Index: PUBOBJECT_PK                                          */
/*==============================================================*/
create unique index PUBOBJECT_PK on PUBOBJECT (
OBJ_AUTOID ASC
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
'T? ch?c - Công ty - Chi nhánh - Phòng ban
';

comment on column PUBORGANIZATION.ORG_AUTOID is 
'Mã t? ch?c - Mã Công ty - Mã Chi Nhánh - Mã Phòng ban';

/*==============================================================*/
/* Index: PUBORGANIZATION_PK                                    */
/*==============================================================*/
create unique index PUBORGANIZATION_PK on PUBORGANIZATION (
ORG_AUTOID ASC
);

/*==============================================================*/
/* Table: PUBPACKING                                            */
/*==============================================================*/
create table PUBPACKING 
(
   PK_AUTOID            smallint                       not null,
   constraint PK_PUBPACKING primary key (PK_AUTOID)
);

comment on table PUBPACKING is 
'quy cách bao bì';

/*==============================================================*/
/* Index: PUBPACKING_PK                                         */
/*==============================================================*/
create unique index PUBPACKING_PK on PUBPACKING (
PK_AUTOID ASC
);

/*==============================================================*/
/* Table: PUBSHIPMETHOD                                         */
/*==============================================================*/
create table PUBSHIPMETHOD 
(
   SMT_AUTOID           smallint                       not null,
   constraint PK_PUBSHIPMETHOD primary key (SMT_AUTOID)
);

comment on table PUBSHIPMETHOD is 
'Phuong th?c v?n chuy?n';

comment on column PUBSHIPMETHOD.SMT_AUTOID is 
'I tu tang';

/*==============================================================*/
/* Index: PUBSHIPMETHOD_PK                                      */
/*==============================================================*/
create unique index PUBSHIPMETHOD_PK on PUBSHIPMETHOD (
SMT_AUTOID ASC
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

/*==============================================================*/
/* Table: PUBWAREHOUSE                                          */
/*==============================================================*/
create table PUBWAREHOUSE 
(
   WH_AUTOID            integer                        not null,
   constraint PK_PUBWAREHOUSE primary key (WH_AUTOID)
);

comment on table PUBWAREHOUSE is 
'Kho hàng ';

/*==============================================================*/
/* Index: PUBWAREHOUSE_PK                                       */
/*==============================================================*/
create unique index PUBWAREHOUSE_PK on PUBWAREHOUSE (
WH_AUTOID ASC
);

alter table ICASSEMBLY
   add constraint FK_ICASSEMB_RELATIONS_FINANCYC foreign key (FICI_AUTOID)
      references FINANCYCICLE (FICI_AUTOID)
      on update restrict
      on delete restrict;

alter table ICASSEMBLY
   add constraint FK_ICASSEMB_RELATIONS_PUBSTATU foreign key (ST_AUTOID)
      references PUBSTATUS (ST_AUTOID)
      on update restrict
      on delete restrict;

alter table ICASSEMBLY
   add constraint FK_ICASSEMB_RELATIONS_PUBCURRE foreign key (CUR_AUTOID)
      references PUBCURRENCY (CUR_AUTOID)
      on update restrict
      on delete restrict;

alter table ICCONTENTITEM
   add constraint FK_ICCONTEN_RELATIONS_PUBWAREH foreign key (WH_AUTOID)
      references PUBWAREHOUSE (WH_AUTOID)
      on update restrict
      on delete restrict;

alter table ICCONTENTITEM
   add constraint FK_ICCONTEN_RELATIONS_ICINWARD foreign key (ICID_AUTOID)
      references ICINWARDSTOCKDETAIL (ICID_AUTOID)
      on update restrict
      on delete restrict;

alter table ICCONTENTITEM
   add constraint FK_ICCONTEN_RELATIONS_PUBITEMS foreign key (PIT_AUTOID)
      references PUBITEMS (PIT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICDIMENTIONS
   add constraint FK_ICDIMENT_RELATIONS_ICPURPOS foreign key (PPU_AUTOID)
      references ICPURPOSEUSE (PPU_AUTOID)
      on update restrict
      on delete restrict;

alter table ICDIMENTIONS
   add constraint FK_ICDIMENT_RELATIONS_PUBCONTR foreign key (COT_AUTOID)
      references PUBCONTRACT (COT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICDIMENTIONS
   add constraint FK_ICDIMENT_RELATIONS_PUBCOSTP foreign key (CP_AUTOID)
      references PUBCOSTPRICE (CP_AUTOID)
      on update restrict
      on delete restrict;

alter table ICDIMENTIONS
   add constraint FK_ICDIMENT_RELATIONS_INVOICE foreign key (IV_DOCUMENTID)
      references INVOICE (IV_DOCUMENTID)
      on update restrict
      on delete restrict;

alter table ICENTRY
   add constraint FK_ICENTRY_RELATIONS_PUBITEMS foreign key (PIT_AUTOID)
      references PUBITEMS (PIT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICENTRY
   add constraint FK_ICENTRY_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID)
      references PUBOBJECT (OBJ_AUTOID)
      on update restrict
      on delete restrict;

alter table ICENTRY
   add constraint FK_ICENTRY_RELATIONS_PUBCURRE foreign key (CUR_AUTOID)
      references PUBCURRENCY (CUR_AUTOID)
      on update restrict
      on delete restrict;

alter table ICENTRY
   add constraint FK_ICENTRY_RELATIONS_PUBCONTR foreign key (COT_AUTOID)
      references PUBCONTRACT (COT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICENTRY
   add constraint FK_ICENTRY_RELATIONS_INVOICE foreign key (IV_DOCUMENTID)
      references INVOICE (IV_DOCUMENTID)
      on update restrict
      on delete restrict;

alter table ICENTRY
   add constraint FK_ICENTRY_RELATIONS_PUBDOCUM foreign key (DOC_DOCUMENTID)
      references PUBDOCUMENT (DOC_DOCUMENTID)
      on update restrict
      on delete restrict;

alter table ICENTRY
   add constraint FK_ICENTRY_RELATIONS_PUBCOSTP foreign key (CP_AUTOID)
      references PUBCOSTPRICE (CP_AUTOID)
      on update restrict
      on delete restrict;

alter table ICINOUTSTOCK
   add constraint FK_ICINOUTS_NGHIEP_VU_PUBDOCUM foreign key (DOTY_AUTOID)
      references PUBDOCUMENTTYPE (DOTY_AUTOID)
      on update restrict
      on delete restrict;

comment on foreign key ICINOUTSTOCK.FK_ICINOUTS_NGHIEP_VU_PUBDOCUM is 
'nghi?p vu nhap kho 
 Nh?p kho hàng hóa
- Nh?p kho tài san
- Nh?p kho công c? d?ng c?
- Nh?p kho thành ph?m (co tru kho theo Bom hay khong ket hop voi tru kho theo bom)
- Nh?p kho bán thành ph?m
- Nh?p kho nguyên v?t li?u
- Nh?p kho hàng bán tr? l?i
- Nh?p kho t?ng h?p (Nhi?u lo?i m?t hàng)
- Nh?p kho khác';

alter table ICINOUTSTOCK
   add constraint FK_ICINOUTS_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID)
      references PUBOBJECT (OBJ_AUTOID)
      on update restrict
      on delete restrict;

alter table ICINOUTSTOCK
   add constraint FK_ICINOUTS_RELATIONS_PUBBATCH foreign key (PUBAT_AUTOID)
      references PUBBATCH (PUBAT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICINOUTSTOCK
   add constraint FK_ICINOUTS_RELATIONS_ICREQUES foreign key (REIC_DOCUMENTID)
      references ICREQUES (REIC_DOCUMENTID)
      on update restrict
      on delete restrict;

alter table ICINOUTSTOCK
   add constraint FK_ICINOUTS_RELATIONS_FINANCYC foreign key (FICI_AUTOID)
      references FINANCYCICLE (FICI_AUTOID)
      on update restrict
      on delete restrict;

alter table ICINOUTSTOCK
   add constraint FK_ICINOUTS_RELATIONS_PUBWAREH foreign key (WH_AUTOID)
      references PUBWAREHOUSE (WH_AUTOID)
      on update restrict
      on delete restrict;

alter table ICINOUTSTOCK
   add constraint FK_ICINOUTS_RELATIONS_PUBSTATU foreign key (ST_AUTOID)
      references PUBSTATUS (ST_AUTOID)
      on update restrict
      on delete restrict;

alter table ICINWARDSTOCKDETAIL
   add constraint FK_ICINWARD_RELATIONS_ITEMTYPE foreign key (ITT_AUTOID)
      references ITEMTYPE (ITT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICINWARDSTOCKDETAIL
   add constraint FK_ICINWARD_RELATIONS_CLASSIFI foreign key (ITET_AUTOID)
      references CLASSIFIED (ITET_AUTOID)
      on update restrict
      on delete restrict;

alter table ICINWARDSTOCKDETAIL
   add constraint FK_ICINWARD_RELATIONS_ICINOUTS foreign key (ICIO_DOCUMENTID)
      references ICINOUTSTOCK (ICIO_DOCUMENTID)
      on update restrict
      on delete restrict;

alter table ICINWARDSTOCKDETAIL
   add constraint FK_ICINWARD_RELATIONS_PUBITEMS foreign key (PIT_AUTOID)
      references PUBITEMS (PIT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICINWARDSTOCKDETAIL
   add constraint FK_ICINWARD_RELATIONS_PUBCURRE foreign key (CUR_AUTOID)
      references PUBCURRENCY (CUR_AUTOID)
      on update restrict
      on delete restrict;

alter table ICINWARDSTOCKDETAIL
   add constraint FK_ICINWARD_RELATIONS_PUBUOM foreign key (UOM_AUTOID)
      references PUBUOM (UOM_AUTOID)
      on update restrict
      on delete restrict;

alter table ICMOVE
   add constraint FK_ICMOVE_RELATIONS_FINANCYC foreign key (FICI_AUTOID)
      references FINANCYCICLE (FICI_AUTOID)
      on update restrict
      on delete restrict;

alter table ICMOVE
   add constraint FK_ICMOVE_RELATIONS_PUBSTATU foreign key (ST_AUTOID)
      references PUBSTATUS (ST_AUTOID)
      on update restrict
      on delete restrict;

alter table ICMOVE
   add constraint FK_ICMOVE_RELATIONS_PUBSHIPM foreign key (SMT_AUTOID)
      references PUBSHIPMETHOD (SMT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICMOVE
   add constraint FK_ICMOVE_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID)
      references PUBOBJECT (OBJ_AUTOID)
      on update restrict
      on delete restrict;

alter table ICMOVE
   add constraint FK_ICMOVE_RELATIONS_PUBBATCH foreign key (PUBAT_AUTOID)
      references PUBBATCH (PUBAT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICMOVEDETAIL
   add constraint FK_ICMOVEDE_CONTENT_D_ICMOVE foreign key (ICM_DOCUMENTID)
      references ICMOVE (ICM_DOCUMENTID)
      on update restrict
      on delete restrict;

alter table ICMOVEDETAIL
   add constraint FK_ICMOVEDE_RELATIONS_CLASSIFI foreign key (ITET_AUTOID)
      references CLASSIFIED (ITET_AUTOID)
      on update restrict
      on delete restrict;

alter table ICMOVEDETAIL
   add constraint FK_ICMOVEDE_RELATIONS_ITEMTYPE foreign key (ITT_AUTOID)
      references ITEMTYPE (ITT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICMOVEDETAIL
   add constraint FK_ICMOVEDE_RELATIONS_PUBSTATU foreign key (ST_AUTOID)
      references PUBSTATUS (ST_AUTOID)
      on update restrict
      on delete restrict;

alter table ICMOVEDETAIL
   add constraint FK_ICMOVEDE_RELATIONS_PUBUOM foreign key (UOM_AUTOID)
      references PUBUOM (UOM_AUTOID)
      on update restrict
      on delete restrict;

alter table ICMOVEDETAIL
   add constraint FK_ICMOVEDE_RELATIONS_PUBITEMS foreign key (PIT_AUTOID)
      references PUBITEMS (PIT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICOTHERCOST
   add constraint FK_ICOTHERC_ICOTHERCO_INVOICE foreign key (IV_DOCUMENTID)
      references INVOICE (IV_DOCUMENTID)
      on update restrict
      on delete restrict;

alter table ICOTHERCOST
   add constraint FK_ICOTHERC_ICOTHERCO_PUBDOCUM foreign key (DOC_DOCUMENTID)
      references PUBDOCUMENT (DOC_DOCUMENTID)
      on update restrict
      on delete restrict;

alter table ICPLAN
   add constraint FK_ICPLAN_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID)
      references PUBOBJECT (OBJ_AUTOID)
      on update restrict
      on delete restrict;

alter table ICPLAN
   add constraint FK_ICPLAN_RELATIONS_PUBWAREH foreign key (WH_AUTOID)
      references PUBWAREHOUSE (WH_AUTOID)
      on update restrict
      on delete restrict;

alter table ICPLANDETAIL
   add constraint FK_ICPLANDE_RELATIONS_CLASSIFI foreign key (ITET_AUTOID)
      references CLASSIFIED (ITET_AUTOID)
      on update restrict
      on delete restrict;

alter table ICPLANDETAIL
   add constraint FK_ICPLANDE_RELATIONS_ITEMTYPE foreign key (ITT_AUTOID)
      references ITEMTYPE (ITT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICPLANDETAIL
   add constraint FK_ICPLANDE_RELATIONS_ICPLAN foreign key (ACPL_DOCUMENTID)
      references ICPLAN (ACPL_DOCUMENTID)
      on update restrict
      on delete restrict;

alter table ICPLANDETAIL
   add constraint FK_ICPLANDE_RELATIONS_PUBITEMS foreign key (PIT_AUTOID)
      references PUBITEMS (PIT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICREQUES
   add constraint FK_ICREQUES_RELATIONS_PUBWAREH foreign key (WH_AUTOID)
      references PUBWAREHOUSE (WH_AUTOID)
      on update restrict
      on delete restrict;

alter table ICREQUES
   add constraint FK_ICREQUES_RELATIONS_FINANCYC foreign key (FICI_AUTOID)
      references FINANCYCICLE (FICI_AUTOID)
      on update restrict
      on delete restrict;

alter table ICREQUES
   add constraint FK_ICREQUES_RELATIONS_PUBOBJEC foreign key (OBJ_AUTOID)
      references PUBOBJECT (OBJ_AUTOID)
      on update restrict
      on delete restrict;

alter table ICREQUES
   add constraint FK_ICREQUES_RELATIONS_PUBSTATU foreign key (ST_AUTOID)
      references PUBSTATUS (ST_AUTOID)
      on update restrict
      on delete restrict;

alter table ICREQUES
   add constraint FK_ICREQUES_RELATIONS_PUBDOCUM foreign key (DOTY_AUTOID)
      references PUBDOCUMENTTYPE (DOTY_AUTOID)
      on update restrict
      on delete restrict;

alter table ICREQUESDETAIL
   add constraint FK_ICREQUES_RELATIONS_CLASSIFI foreign key (ITET_AUTOID)
      references CLASSIFIED (ITET_AUTOID)
      on update restrict
      on delete restrict;

alter table ICREQUESDETAIL
   add constraint FK_ICREQUES_RELATIONS_ITEMTYPE foreign key (ITT_AUTOID)
      references ITEMTYPE (ITT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICREQUESDETAIL
   add constraint FK_ICREQUES_RELATIONS_ICREQUES foreign key (REIC_DOCUMENTID)
      references ICREQUES (REIC_DOCUMENTID)
      on update restrict
      on delete restrict;

alter table ICREQUESDETAIL
   add constraint FK_ICREQUES_RELATIONS_PUBITEMS foreign key (PIT_AUTOID)
      references PUBITEMS (PIT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOCK
   add constraint FK_ICSTOCK_RELATIONS_PUBORGAN foreign key (ORG_AUTOID)
      references PUBORGANIZATION (ORG_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOCK
   add constraint FK_ICSTOCK_RELATIONS_PUBITEMS foreign key (PIT_AUTOID)
      references PUBITEMS (PIT_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOCK
   add constraint FK_ICSTOCK_RELATIONS_FINANCYC foreign key (FICI_AUTOID)
      references FINANCYCICLE (FICI_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOCKJOIN
   add constraint FK_ICSTOCKJ_ICSTOCKJO_ICINWARD foreign key (ICID_AUTOID)
      references ICINWARDSTOCKDETAIL (ICID_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOCKJOIN
   add constraint FK_ICSTOCKJ_ICSTOCKJO_CLASSIFI foreign key (ITET_AUTOID)
      references CLASSIFIED (ITET_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOCKJOIN
   add constraint FK_ICSTOCKJ_ICSTOCKJO_PUBMANUF foreign key (MANU_AUTOID)
      references PUBMANUFACTURER (MANU_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOCKJOIN
   add constraint FK_ICSTOCKJ_ICSTOCKJO_PUBCURRE foreign key (CUR_AUTOID)
      references PUBCURRENCY (CUR_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOCKJOIN
   add constraint FK_ICSTOCKJ_ICSTOCKJO_ICSTOCKD foreign key (ICSD_AUTOID)
      references ICSTOCKDETAIL (ICSD_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOCKJOIN
   add constraint FK_ICSTOCKJ_ICSTOCKJO_ICSTOCK foreign key (PST_AUTOID)
      references ICSTOCK (PST_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOCKJOIN
   add constraint FK_ICSTOCKJ_ICSTOCKJO_ICMOVEDE foreign key (ICMD_AUTOID)
      references ICMOVEDETAIL (ICMD_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOCKJOIN
   add constraint FK_ICSTOCKJ_ICSTOCKJO_ICPLOT foreign key (ICP_AUTOID)
      references ICPLOT (ICP_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOCKJOIN
   add constraint FK_ICSTOCKJ_ICSTOCKJO_PUBWAREH foreign key (WH_AUTOID)
      references PUBWAREHOUSE (WH_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOCKJOIN
   add constraint FK_ICSTOCKJ_ICSTOCKJO_ITEMSPOS foreign key (ITP_AUTOID)
      references ITEMSPOSITION (ITP_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOCKJOIN
   add constraint FK_ICSTOCKJ_ICSTOCKJO_PUBPACKI foreign key (PK_AUTOID)
      references PUBPACKING (PK_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOCKJOIN
   add constraint FK_ICSTOCKJ_ICSTOCKJO_ICWARRAN foreign key (ICWC_AUTOID)
      references ICWARRANTYCODE (ICWC_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOREWARRANTY
   add constraint FK_ICSTOREW_RELATIONS_PUBMANUF foreign key (MANU_AUTOID)
      references PUBMANUFACTURER (MANU_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOREWARRANTY
   add constraint FK_ICSTOREW_RELATIONS_ITEMSPOS foreign key (ITP_AUTOID)
      references ITEMSPOSITION (ITP_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOREWARRANTY
   add constraint FK_ICSTOREW_RELATIONS_ICWARRAN foreign key (ICWC_AUTOID)
      references ICWARRANTYCODE (ICWC_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOREWARRANTY
   add constraint FK_ICSTOREW_RELATIONS_PUBWAREH foreign key (WH_AUTOID)
      references PUBWAREHOUSE (WH_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOREWARRANTY
   add constraint FK_ICSTOREW_RELATIONS_PUBPACKI foreign key (PK_AUTOID)
      references PUBPACKING (PK_AUTOID)
      on update restrict
      on delete restrict;

alter table ICSTOREWARRANTY
   add constraint FK_ICSTOREW_RELATIONS_ICPLOT foreign key (ICP_AUTOID)
      references ICPLOT (ICP_AUTOID)
      on update restrict
      on delete restrict;

