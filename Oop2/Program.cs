using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12356";
            musteri1.Adi = "Nida";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "123456789";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "45687";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123487596";

            //Gercek müsteri -tüzel müsteri
            // SOLID
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

        }
    }
}
