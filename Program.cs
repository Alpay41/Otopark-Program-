namespace Otopark_Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double odenecekTutar = 0;
            int kalinanSure = 0, aracTipi = 0, baslangicSaati, bitisSaati,
                taksiBİrimSaat=20,minibusBirimSaat=25,ticariBirimSaat=30;
            Console.WriteLine("Araç Tipleri Taksi : 1, Minübüs : 2, Ticari : 3");
            Console.Write("Lütfen Araç Tipini Giriniz : ");
            aracTipi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Başlangıç Saatini Giriniz : ");
            baslangicSaati = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş Saatini Giriniz : ");
            bitisSaati = Convert.ToInt32(Console.ReadLine());
            kalinanSure = bitisSaati-baslangicSaati;
            if (kalinanSure > 1)
            {
                for (int i = 1; i <= kalinanSure; i++)
                {
                    if (i == 1)
                    {
                        if (aracTipi == 1) { odenecekTutar = i * taksiBİrimSaat; }
                        else if (aracTipi == 2) { odenecekTutar = i * minibusBirimSaat; }
                        else if (aracTipi == 3) { odenecekTutar = i * ticariBirimSaat; }
                    }
                    else
                    {
                        kalinanSure -= 1;
                        if (aracTipi == 1) { odenecekTutar += kalinanSure * ticariBirimSaat * 1.20; }
                        else if (aracTipi == 2) { odenecekTutar += kalinanSure * minibusBirimSaat * 1.215; }
                        else if (aracTipi == 3) { odenecekTutar += kalinanSure * ticariBirimSaat * 1.25; }
                    }
                }
            }
            else
            {
                if (aracTipi == 1) { odenecekTutar = kalinanSure * ticariBirimSaat; }
                else if (aracTipi == 2) { odenecekTutar = kalinanSure * minibusBirimSaat; }
                else if (aracTipi == 3) { odenecekTutar = kalinanSure * ticariBirimSaat; }
            }
            Console.WriteLine("Ödenecek Tutar : {0} TL", odenecekTutar);
        }
    }
}