using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_1170505031_Kerim_Öztürk
{
    class KralSuit_Rezervasyon: Oda_Rezervasyon
    {
        public KralSuit_Rezervasyon(int rezerv_Id,
                                    string oda_Adi,
                                    int oda_Id,
                                    bool manzara,
                                    bool odaServisi,
                                    int musteri_Id,
                                    string musteri_Adi,
                                    string musteri_Soyadi,
                                    string musteri_GSM,
                                    int musteri_kisi_sayisi,
                                    DateTime giris_Tarihi,
                                    DateTime cikis_Tarihi,
                                    int kapora,
                                    bool tadilat)
        {
            this.rezerv_Id = rezerv_Id;
            this.oda_Ad = oda_Adi;
            this.oda_Id = oda_Id;
            this.musteri_id = musteri_Id;
            this.manzara = manzara;
            this.odaServisi = odaServisi;
            this.musteri_Ad = musteri_Adi;
            this.musteri_Soyad = musteri_Soyadi;
            this.musteri_GSM = musteri_GSM;
            this.musteri_Kisi_Sayisi = musteri_kisi_sayisi;
            this.giris_Tarihi = giris_Tarihi;
            this.cikis_Tarihi = cikis_Tarihi;
            this.kapora = kapora;
            this.tadilat = tadilat;
        }

        public override int Ucret_Hesabi(bool manzara, bool odaServisi)
        {
            int ucret = konak_Suresi() * 250;
            if (this.kapora != 0)
            {
                ucret -= this.kapora;
                return ucret;
            }
            else
            {
                return ucret;
            }
        }
    }
}
