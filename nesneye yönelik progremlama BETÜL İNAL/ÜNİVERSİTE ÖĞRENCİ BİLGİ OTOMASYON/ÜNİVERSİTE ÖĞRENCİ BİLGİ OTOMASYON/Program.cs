using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using static Ogrenci;

// Ogrenci sınıfı öğrenci bilgilerini içerir.
public class Ogrenci
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string OgrenciNo { get; set; }
    public string Bolumu { get; set; }
    public List<string> SecilenDersler { get; set; }
    public List<string> SecilenKulüpler { get; set; }

    public class Kullanici
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
    // OgrenciBilgiSistemi sınıfı öğrenci bilgileri ve işlemleriyle ilgilenir.
    public class OgrenciBilgiSistemi
    {
        private Ogrenci ogrenciler;

        private Kullanici kullanici;

        // Harf kontrolü yapan yardımcı metot.
        private bool Harf(string text)  //kullanıcı sayı yazmadıysa doğru kabul et
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        // Sayı kontrolü yapan yardımcı metot.
        private bool Sayı(string text)  //kullanıcı sayı yazdıysa doğru kabul et
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        // OgrenciBilgiSistemi sınıfının constructor'ı.
        public OgrenciBilgiSistemi()
        {
            ogrenciler = new Ogrenci();

            kullanici = new Kullanici();
        }

        // Kullanıcı girişi yapılmasını sağlayan metot.
        public void KullaniciGirisi()
        {
            Console.WriteLine("           Kullanıcı Girişi\n");
            Console.Write("Kullanıcı Adı(isim/tc): ");
            kullanici.KullaniciAdi = Console.ReadLine();

            Console.Write("Şifre: ");
            kullanici.Sifre = SifreliYaz();
        }

        // Şifreyi gizli bir şekilde yazdıran yardımcı metot.
        private static string SifreliYaz()
        {
            string sifre = "";
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    sifre += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && sifre.Length > 0)
                    {
                        sifre = sifre.Substring(0, (sifre.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);

            Console.WriteLine(); // Yeni satıra geçmek için
            return sifre;
        }

        // Öğrenci bilgilerini giriş yapmasını sağlayan metot
        public void OgrenciEkle()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("         Öğrenci Bilgilerini Girin\n");

            Console.Write("Ad: ");
            string ad = Console.ReadLine();
            while (!Harf(ad))
            {
                Console.WriteLine("Geçersiz ad. Harf giriniz:");
                Console.Write("Ad: ");
                ad = Console.ReadLine();
            }

            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();
            while (!Harf(soyad))
            {
                Console.WriteLine("Geçersiz soyad. Harf giriniz:");
                Console.Write("Soyad: ");
                soyad = Console.ReadLine();
            }

            Console.Write("Öğrenci No: ");
            string ogrenciNo = Console.ReadLine();
            while (!Sayı(ogrenciNo))
            {
                Console.WriteLine("Geçersiz öğrenci numarası. Sayı giriniz:");
                Console.Write("Öğrenci No: ");
                ogrenciNo = Console.ReadLine();

            }

            Console.Write("Bölüm: ");
            string bolum = Console.ReadLine();
            while (!Harf(bolum))
            {
                Console.WriteLine("Geçersiz bölüm. Harf giriniz:");
                Console.Write("Bölüm: ");
                bolum = Console.ReadLine();
            }

            Ogrenci ogrenci = new Ogrenci { Ad = ad, Soyad = soyad, OgrenciNo = ogrenciNo, Bolumu = bolum };


            Console.WriteLine("\nGiriş Yapıldı..");
            Console.WriteLine("\nAna menüye gitmek için bir tuşa basın...");
            Console.ReadKey();

            Console.Clear();
        }

    }

    public Ogrenci()
    {
        SecilenDersler = new List<string>();
        SecilenKulüpler = new List<string>();
    }
}


// OgrenciOtomasyon sınıfı öğrenciye ait ders ve kulüp işlemleri ile ilgilenir.
public class OgrenciOtomasyon
{

    private Ogrenci ogrenci;
    private List<string> tumDersler;
    private List<string> tumKulüpler;

    public OgrenciOtomasyon()  //KULÜP VE DERSLERİN LİSTELERİ
    {
        ogrenci = new Ogrenci();
        tumDersler = new List<string> { "Matematik", "Kimya", "Programlama", "Fizik", "İngilizce", "Türkçe", "İnkılap" };
        tumKulüpler = new List<string> { "Yazılım Kulübü", "Edebiyat Kulübü", "Resim Kulübü", "Müzik Kulübü" };
    }

    // Ana menüyü gösteren metot.
    public void AnaMenu()
    {
        Console.WriteLine("\n        ANA MENÜ");
        Console.WriteLine("----------------------------");
        Console.WriteLine("1. Ders Kaydı Yap ");
        Console.WriteLine("2. Ders Kaydı Sil");
        Console.WriteLine("3. Kayıtlı Dersleri Listele");
        Console.WriteLine("----------------------------");
        Console.WriteLine("4. Kulüp Kaydı Yap");
        Console.WriteLine("5. Kulüp Kaydı Sil");
        Console.WriteLine("6. Kayıtlı Kulüpleri Listele");
        Console.WriteLine("----------------------------");
        Console.WriteLine("7. Öğrenci Transkripti");
        Console.WriteLine("8. Çıkış");
        Console.WriteLine("----------------------------");
        Console.Write("Seçenek Girin (1 ~ 8): ");

        string secenek = Console.ReadLine();

        //SWİTCH CASE

        switch (secenek)
        {
            case "1":
                DersSecimi();
                break;
            case "2":
                DersSilme();
                break;
            case "3":
                SecilenDersleriListele();
                break;
            case "4":
                KulüpSecimi();
                break;
            case "5":
                KulüpSilme();
                break;
            case "6":
                SecilenKulüpleriListele();
                break;
            case "7":
                BilgileriGoster(ogrenci);
                break;
            case "8":
                Console.WriteLine("Çıkış yapılıyor...");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                break;
        }

        AnaMenu();
    }

    //DERS KAYIT
    private void DersSecimi()
    {
        Console.Clear();
        Console.WriteLine("\n----- Ders Kaydı -----");
        Console.WriteLine("Mevcut Dersler:");


        foreach (var ders in tumDersler)
        {
            Console.WriteLine($"- {ders}");
        }

        Console.Write("Eklemek istediğiniz dersi girin: ");
        string secilenDers = Console.ReadLine();

        if (tumDersler.Contains(secilenDers, StringComparer.OrdinalIgnoreCase))  //büyük küçük harf farketmez
        {
            ogrenci.SecilenDersler.Add(secilenDers);
            Console.WriteLine($"{secilenDers} dersinin kaydı oluşturuldu.");
        }
        else
        {
            Console.WriteLine("Geçersiz ders. Lütfen mevcut dersler arasından seçin.");   //eğer ders adı yanlışsa kayıt oluşturulamaz
        }
    }

    //KULÜP KAYIT
    private void KulüpSecimi()
    {
        Console.Clear();
        Console.WriteLine("\n----- Kulüp Kaydı -----");
        Console.WriteLine("Mevcut Kulüpler:");


        foreach (var kulüp in tumKulüpler)
        {
            Console.WriteLine($"- {kulüp}");
        }

        Console.Write("Eklemek istediğiniz kulübü girin: ");
        string secilenKulüp = Console.ReadLine();

        if (tumKulüpler.Contains(secilenKulüp, StringComparer.OrdinalIgnoreCase))   //büyük küçük harf farketmez
        {
            ogrenci.SecilenKulüpler.Add(secilenKulüp);
            Console.WriteLine($"{secilenKulüp}nün kaydı oluşturuldu.");
        }
        else
        {
            Console.WriteLine("Geçersiz kulüp. Lütfen mevcut kulüpler arasından seçin.");    //eğer kulüp adı yanlışsa kayıt oluşturulamaz
        }
    }

    //SEÇİLEN DERSLERİN LİSTELENMESİ
    private void SecilenDersleriListele()
    {
        Console.Clear();
        Console.WriteLine("\n----- Kayıtlı Dersler -----");
        if (ogrenci.SecilenDersler.Count > 0)       //eğer seçilen ders sayısı sıfır değilse listele
        {
            foreach (var secilenDers in ogrenci.SecilenDersler)
            {
                Console.WriteLine($"- {secilenDers}");
            }
        }
        else
        {
            Console.WriteLine("Henüz ders kaydı yapılmamıştır.");   // sıfır ise kayıt yok
        }
    }

    //SEÇİLEN KULÜPLERİN LİSTELENMESİ
    private void SecilenKulüpleriListele()
    {
        Console.Clear();
        Console.WriteLine("\n----- Kayıtlı Kulüpler -----");
        if (ogrenci.SecilenKulüpler.Count > 0)         //eğer seçilen kulüp sayısı sıfır değilse listele
        {
            foreach (var secilenKulüp in ogrenci.SecilenKulüpler)
            {
                Console.WriteLine($"- {secilenKulüp}");
            }
        }
        else
        {
            Console.WriteLine("Henüz kulüp kaydı yapılmamıştır.");   // sıfır ise kayıt yok
        }
    }

    //kullanıcı sayı yazmadıysa doğru kabul et
    private bool Harf(string text)
    {
        foreach (char c in text)
        {
            if (!char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }

    //TRANSKRİPTİN GÖRÜNTÜLENMESİ
    private void BilgileriGoster(Ogrenci ogrenci)
    {
        Console.Write("Adınızı giriniz: ");
        string ad = Console.ReadLine();
        while (!Harf(ad))
        {
            Console.WriteLine("Geçersiz ad. Harf giriniz:");
            Console.Write("Ad: ");
            ad = Console.ReadLine();
        }

        Console.Write("Soyadınızı giriniz: ");
        string soyad = Console.ReadLine();
        while (!Harf(soyad))
        {
            Console.WriteLine("Geçersiz soyad. Harf giriniz:");
            Console.Write("Soyad: ");
            soyad = Console.ReadLine();
        }

        Console.Clear();
        Console.WriteLine("\n----- TRANSKRİPT -----");
        Console.WriteLine($"\nÖğrenci Bilgileri: ");
        Console.WriteLine($"Ad: {ad}");
        Console.WriteLine($"Soyad: {soyad}");

        Console.WriteLine("---------------------------");
        if (ogrenci.SecilenDersler.Count > 0)        //eğer seçilen ders sayısı sıfır değilse listele
        {
            Console.WriteLine("Kayıtlı Dersler:");
            foreach (var secilenDers in ogrenci.SecilenDersler)   // FOREACH - arama
            {
                Console.WriteLine($"- {secilenDers}");
            }
        }
        else
        {
            Console.WriteLine("\nHenüz ders kaydı yapılmamıştır.");
        }

        Console.WriteLine("---------------------------");

        if (ogrenci.SecilenKulüpler.Count > 0)         //eğer seçilen kulüp sayısı sıfır değilse listele
        {
            Console.WriteLine("Kayıtlı Kulüpler:");
            foreach (var secilenKulüp in ogrenci.SecilenKulüpler)
            {
                Console.WriteLine($"- {secilenKulüp}");
            }
        }
        else
        {
            Console.WriteLine("Henüz kulüp kaydı yapılmamıştır.");
        }
    }

    // DERS KAYDI SİLME
    private void DersSilme()
    {
        Console.Clear();
        Console.WriteLine("\n------- Ders Kaydı Silme -------");

        if (ogrenci.SecilenDersler.Count > 0)
        {
            Console.WriteLine("\nKayıtlı Dersler:");
            for (int i = 0; i < ogrenci.SecilenDersler.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ogrenci.SecilenDersler[i]}");
            }

            Console.Write("\nSilmek istediğiniz dersin numarasını girin: ");
            if (int.TryParse(Console.ReadLine(), out int silinecekDersIndex) &&
                silinecekDersIndex >= 1 && silinecekDersIndex <= ogrenci.SecilenDersler.Count)
            {
                string silinecekDers = ogrenci.SecilenDersler[silinecekDersIndex - 1];

                Console.Write($"Emin misiniz? {silinecekDers} dersini silmek istediğinize dair (E/H): ");  //silmek istediğine emin misin diye soruluyor.
                string onay = Console.ReadLine();

                if (onay.ToUpper() == "E")
                {
                    ogrenci.SecilenDersler.Remove(silinecekDers);                // REMOVE - SİLMEK
                    Console.WriteLine($"\n{silinecekDers} dersi silindi.");
                }
                else
                {
                    Console.WriteLine("\nİşlem iptal edildi.");
                }
            }
            else
            {
                Console.WriteLine("\nGeçersiz ders numarası. Lütfen tekrar deneyin.");
            }
        }
        else
        {
            Console.WriteLine("\nHenüz ders kaydı yapılmamıştır.");
        }
    }

    // KULÜP KAYDI SİLME
    private void KulüpSilme()
    {
        Console.Clear();
        Console.WriteLine("\n------- Kulüp Kaydı Silme -------");

        if (ogrenci.SecilenKulüpler.Count > 0)
        {
            Console.WriteLine("\nKayıtlı Kulüpler:");
            for (int i = 0; i < ogrenci.SecilenKulüpler.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ogrenci.SecilenKulüpler[i]}");
            }

            Console.Write("\nSilmek istediğiniz kulübün numarasını girin: ");
            if (int.TryParse(Console.ReadLine(), out int silinecekKulüpIndex) &&
                silinecekKulüpIndex >= 1 && silinecekKulüpIndex <= ogrenci.SecilenKulüpler.Count)
            {
                string silinecekKulüp = ogrenci.SecilenKulüpler[silinecekKulüpIndex - 1];

                Console.Write($"Emin misiniz? {silinecekKulüp}nü silmek istediğinize dair (E/H): ");   //silmek istediğine emin misin diye soruluyor.
                string onay = Console.ReadLine();

                if (onay.ToUpper() == "E")
                {
                    ogrenci.SecilenKulüpler.Remove(silinecekKulüp);           // REMOVE - SİLMEK
                    Console.WriteLine($"\n{silinecekKulüp} silindi.");
                }
                else
                {
                    Console.WriteLine("\nİşlem iptal edildi.");
                }
            }
            else
            {
                Console.WriteLine("\nGeçersiz kulüp numarası. Lütfen tekrar deneyin.");
            }
        }
        else
        {
            Console.WriteLine("\nHenüz kulüp kaydı yapılmamıştır.");
        }
    }

    class Program
    {
        static void Main()
        {

            OgrenciBilgiSistemi obs = new OgrenciBilgiSistemi();  // OgrenciBilgiSistemi sınıfından bir nesne oluşturulur.
            obs.KullaniciGirisi();
            obs.OgrenciEkle();

            OgrenciOtomasyon ogrenciOtomasyon = new OgrenciOtomasyon();  // OgrenciOtomasyon sınıfından bir nesne oluşturulur.

            ogrenciOtomasyon.AnaMenu();   // Ana menü gösterilir.
        }
    }
}