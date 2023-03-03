using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Passionflower.DataAccess.Context
{
    public class FISARSIV
    {
        [Key]
        public int FISCOUNTER { get; set; }
        public string DEPKODU { get; set; }
        public string MASANO { get; set; }
        public DateTime TARIH { get; set; }
        public DateTime ASAATI { get; set; }
        public DateTime KSAATI { get; set; }
        public int FISNO { get; set; }
        public string ODERNO { get; set; }
        public string ADISYONNO { get; set; }
        public string GARSONKODU { get; set; }
        public string YETKILIKODU { get; set; }
        public string TUR { get; set; }
        public string MUSTERIKODU { get; set; }
        public string MUSTERIADI { get; set; }
        public float MUSTERIBAKIYE { get; set; }
        public float INDORAN { get; set; }
        public float INDTOPLAM { get; set; }
        public float SERVISORAN { get; set; }
        public float SERVISTUTAR { get; set; }
        public float TOPLAM { get; set; }
        public string FUNVANI { get; set; }
        public string FADRESI1 { get; set; }
        public string FADRESI2 { get; set; }
        public string FVD { get; set; }
        public string FVDNO { get; set; }
        public float KDV { get; set; }
        public float MATRAH { get; set; }
        public float ONAKIT { get; set; }
        public float OKK { get; set; }
        public float OTICKET { get; set; }
        public float OACIK { get; set; }
        public float YTOPLAM { get; set; }
        public float ITOPLAM { get; set; }
        public string FYAZIYLA { get; set; }
        public int KISI { get; set; }
        public string MODANO { get; set; }
        public float MKNO { get; set; }
        public bool FISLI { get; set; }
        public float STOPLAM { get; set; }
        public int YAZCOUNT { get; set; }
        public string KKTURU { get; set; }
        public string TICKETTURU { get; set; }
        public int DIRTY { get; set; }
        public string DTURU { get; set; }
        public float DTOPLAM { get; set; }
        public string FKISINO { get; set; }
        public float OTICKET2 { get; set; }
        public float OTICKET3 { get; set; }
        public float OTICKET4 { get; set; }
        public float VPARA { get; set; }
        public int MUSTERIID { get; set; }
        public string MODAADI { get; set; }
        public float DOVIZTOPLAM { get; set; }
        public float DOVIZKURU { get; set; }
        public string KASIYER { get; set; }
        public int SECINDID { get; set; }
        public string INDSEBEP { get; set; }
        public float PBAKIYE { get; set; }
        public float INDTUTAR { get; set; }
        public int MID { get; set; }
        public int SUBEID { get; set; }
        public int AKTARILDI { get; set; }
        public string ACIKLAMA { get; set; }
        public string MUSKARTNO { get; set; }
        public int MARS { get; set; }
        public string MARSSAATI { get; set; }
        public float KALANKREDI { get; set; }
        //public string ODENMEZTOPLAM { get; set; }
        //public string ODERSERINO { get; set; }
        //public string MASASTATU { get; set; }
        //public string WEBPOSMSG { get; set; }
        //public string URUNFIYATTIPI { get; set; }
        //public string YAZARKASA_REF_NO { get; set; }
        //public string YAZARKASA_DURUM { get; set; }
        //public string EFATURADURUM { get; set; }
        //public string EFATURA_PKUTUSU { get; set; }
        //public string OTICKET5 { get; set; }
        //public string OTICKET6 { get; set; }
        //public string OTICKET7 { get; set; }
        //public string OTICKET1 { get; set; }
        //public string BELGETURU { get; set; }
        //public string FISTUTAR { get; set; }
        //public string FATURATUTAR { get; set; }
        //public string IPTALCOUNTER { get; set; }
        //public string OMDKI { get; set; }
        //public string BAGISBORCU { get; set; }
        //public string AIDATBORCU { get; set; }
        //public string OMDINDORAN { get; set; }
        //public string UYEOLMAKISTIYOR { get; set; }
        //public string ODEMEONAYKODU { get; set; }
        //public string PUANONAYKODU { get; set; }
        //public string SORGUTURU { get; set; }
        //public string SORGUNO { get; set; }
        //public string REZKISIID { get; set; }
        //public string DIGEROTEL { get; set; }
        //public string FILCE { get; set; }
        //public string FSEHIR { get; set; }
        //public string FULKE { get; set; }
        //public string SEZLONG { get; set; }
    }
}
