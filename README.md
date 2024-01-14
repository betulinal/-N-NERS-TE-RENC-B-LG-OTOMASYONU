

 AKIŞ ŞEMASI



![akış şeması](https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/8cadc675-a44e-484f-8fda-7a9ad4b2b08c)


[Proje ile ilgili açıklamalar.odt](https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/files/13931973/Proje.ile.ilgili.aciklamalar.odt)


[Proje-ile-ilgili-açıklamalar.pdf](https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/files/13931974/Proje-ile-ilgili-aciklamalar.pdf)



PROJE ADI: ÜNİVERSİTE ÖĞRENCİ BİLGİ OTOMASYONU

PROJEYİ YAPAN ÖĞRENCİ
AD: BETÜL
SOYAD: İNAL
BÖLÜMÜ: BİLGİSAYAR MÜHENDİSLİĞİ
NUMARA: 221041007

DERS: NESNEYE YÖNELİK PROGRAMLAMA
DERSİN HOCASI: Dr. ARZU KILITCI CALAYIR 

            
                    PROJENİN AMACI VE GENEL TANIMI
Öğrencinin eğitim sürecini daha etkili ve kullanıcı dostu hale getirmek amacıyla, öğrencinin ders kaydını oluşturmasına, katılmak istediği okul kulüplerini seçmesine ve bu tercihleriyle ilgili bilgileri okul transkriptinde kolayca görüntülemesine olanak sağlayan bir sistem, öğrencinin akademik ve sosyal hayatını yönetmeyi büyük ölçüde kolaylaştırıyor. 
Bu entegre sistem, öğrencilere daha önce hiç olmadığı kadar kapsamlı ve kişiselleştirilmiş bir deneyim sunarak, ders seçiminden kulüp katılımlarına kadar her aşamada onlara rehberlik ediyor. Ayrıca kulüp ve ders kayıtlarını daha sonra istedikleri gibi silebilme olanağına da sahiptirler. 
Bu sayede, öğrencilerin akademik ve sosyal deneyimleri arasındaki dengeyi korumalarına ve daha verimli bir şekilde gelişmelerine olanak tanıyan bu sistemin, eğitim kurumlarında öğrenci yönetimi alanında önemli bir iyileştirme sağladığı söylenebilir.
Proje Visual Studio consol ortamında C# yazılım dili ile geliştirilmiştir.
                        PROJE İLE YAPILABİLEN ŞEYLER
1. Ders kaydı yapmak
2. Ders kaydı silmek
3. Kayıtlı dersleri listelemek
4. Kulüp kaydı yapmak
5. Kulüp kaydı silmek
6. Kayıtlı kulüpleri listelemek
7. Öğrenci transkriptini görüntülemek
8. Çıkış

                                   GEREKSİNİMLER
Yazılım Gereksinimleri:
Visual Studio gibi bir C# geliştirme ortamına ihtiyaç duyulacaktır.
Donanım Gereksinimleri:
Standart bir bilgisayar veya dizüstü bilgisayar kullanılabilir.





                                    KURULUM ADIMLARI

Visual Studio Kurulumu:
   Visual Studio'yu indirip yükleyin. Visual Studio İndirme Sayfası üzerinden indirme işlemini gerçekleştirebilirsiniz.

Projenin İndirilmesi:
  Eğer bu projeyi bir depodan (GitHub gibi) indirdiyseniz, projeyi bilgisayarınıza bir klasöre çıkartın.

Projeyi Visual Studio'da Açma:
   Visual Studio'yu açın.
   Visual Studio ana ekranında "Dosya" menüsünden "Proje veya Çalışma Alanı Aç" seçeneğini kullanarak indirdiğiniz projenin bulunduğu klasörü seçin.

Proje Derleme ve Çalıştırma:
   Visual Studio'da açtığınız projeyi derleyin (Build) ve ardından çalıştırın (Run).
   Çalıştır tuşuna basarak uygulamayı başlatın.

Uygulamayı Kullanma:
   Uygulama başladığında, konsol penceresinde yönergeleri takip ederek kullanıcı girişi yapabilir ve öğrenci bilgilerini girebilirsiniz.


        KULLANIM SENARYOLARI

Senaryo 1: Kullanıcı Girişi ve Öğrenci Ekleme
    1. Senaryo Başlangıcı: Program başladığında, kullanıcıya bir kullanıcı adı ve şifre sorulur.
    2. Kullanıcı Girişi: Geçerli bir kullanıcı adı ve şifre girildikten sonra, "Kullanıcı Girişi Başarılı!" mesajı alınır.
    3. Öğrenci Bilgisi Ekleme: Kullanıcıya öğrenci bilgileri (ad, soyad, öğrenci no, bölüm) sorulur ve girilen bilgiler doğrultusunda bir öğrenci oluşturulur.
       

<img width="332" alt="1" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/08ec2fcc-c526-48c2-807d-c22f135d7461">





Senaryo 2: Ders Kaydı Yapma
   1. Ana Menüye Giriş: Öğrenci bilgisi ekledikten sonra ana menüye yönlendirilirsiniz.
   2. Ders Kaydı Yapma: Ana menüden "Ders Kaydı Yap" seçeneği seçilir. Mevcut dersler listelenir ve kullanıcıdan bir ders seçmesi istenir. Doğru bir ders seçildiğinde, "Ders kaydı oluşturuldu." mesajı görüntülenir.



<img width="266" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/6ca3e1f6-213d-46f5-81cf-bfe72fc4e77d">


<img width="166" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/c89d0e6b-c23c-41d3-89f6-aceaa7df2918">



Senaryo 3: Ders Kaydı Silme
    1. Ana Menüye Giriş: Ana menüden "Ders Kaydı Sil" seçeneği seçilir. Kayıtlı dersler listelenir.
    2. Ders Seçme: Kullanıcı, sileceği dersin numarasını girer. Doğru bir numara girildiğinde, "Emin misiniz?" sorusu ile karşılaşılır.
3. Onaylama ve Silme: Kullanıcı "E" (Evet) derse, seçilen ders silinir ve "Ders silindi." mesajı görüntülenir.



<img width="374" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/b7b69c52-bb3b-4488-98f9-7f46874f2e31">



Senaryo 4: Kayıtlı Dersleri Listeleme
1. Ana Menüye Giriş: Ana menüden "Kayıtlı Dersleri Listele" seçeneği seçilir. Kayıtlı dersler listelenir.


<img width="173" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/af9c6f60-a633-4721-bd83-5ceda2c05668">



Senaryo 5: Kulüp Kaydı Yapma
    1. Ana Menüye Giriş: Ana menüden "Kulüp Kaydı Yap" seçeneği seçilir. Mevcut kulüpler listelenir ve kullanıcıdan bir kulüp seçmesi istenir.
     2. Kulüp Kaydı Yapma: Doğru bir kulüp seçildiğinde, "Kulüp kaydı oluşturuldu." mesajı görüntülenir.


<img width="285" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/32c5c1d7-7628-4944-ace2-a01281fcf4fb">






Senaryo 6: Kulüp Kaydı Silme
    1. Ana Menüye Giriş: Ana menüden "Kulüp Kaydı Sil" seçeneği seçilir. Kayıtlı kulüpler listelenir.
    2. Kulüp Seçme: Kullanıcı, sileceği kulübün numarasını girer. Doğru bir numara girildiğinde, "Emin misiniz?" sorusu ile karşılaşılır     
3.  Onaylama ve Silme: Kullanıcı "E" (Evet) derse, seçilen kulüp silinir ve "Kulüp silindi." mesajı görüntülenir.


<img width="370" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/522cd686-b095-4edd-ae55-0b23d47ccb2c">




Senaryo 7: Kayıtlı Kulüpleri Listeleme
    1. Ana Menüye Giriş: Ana menüden "Kayıtlı Kulüpleri Listele" seçeneği seçilir. Kayıtlı kulüpler listelenir.


<img width="170" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/d03ac512-e1ca-4991-ad33-7419d3b4e082">




Senaryo 8: Öğrenci Transkripti Görüntüleme
    1. Ana Menüye Giriş: Ana menüden "Öğrenci Transkripti" seçeneği seçilir.
2. Bilgileri Giriş: Kullanıcıdan ad ve soyad bilgisi istenir. Bu bilgilerle öğrencinin ders ve kulüp kayıtları görüntülenir.

<img width="166" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/6c17530e-4677-4b74-960f-38055fced413">





Senaryo 9: Çıkış
        1. Ana Menüden Çıkış: Ana menüden "Çıkış" seçeneği seçilir. Programdan çıkış yapılır.



<img width="179" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/ca9e8d2a-d7b2-4e03-93ec-0b737b0258b2">




SORUNLAR VE ÇÖZÜMLER

Kullanıcın şifreyi gizli yazmasıyla güvenli bir giriş sağlar.
Kullanıcının adını, soyadını ve bölümünü yazdırırken harf girmesini sağlar böylece hatalı girişi engeller.
Kullanıcının numarasını yazdırırken sayı girmesini sağlar böylece hatalı girişi engeller.
Ders ve kulüp kaydı oluşturulurken istenen ders ve kulüplerin isminin yazımında büyük küçük harf ayrımı yapılmamaktadır.
Oluşturulan ders ve kulüp kayıtları menüden seçilen ilgili numaralar ile istenirse silinebilir. 



     PROJE DETAYI
Sınıflar ve Nesneler: 
    • Ogrenci sınıfı, öğrenci bilgilerini içerir. Program sınıfında bir örneği oluşturulur ve bu sınıf üzerinden öğrenci bilgileri işlenir.
    • Kullanici sınıfı, kullanıcı adı ve şifreyi içerir.
    • OgrenciBilgiSistemi sınıfı, öğrenci bilgileri ve işlemleriyle ilgilenir. Ogrenci sınıfından bir örneği içerir ve öğrenci bilgilerini giriş yapma ve ekleme işlemleriyle işler.
    • OgrenciOtomasyon sınıfı, ders ve kulüp işlemleriyle ilgilenir. Aynı şekilde Ogrenci sınıfından bir örneği içerir.





<img width="469" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/b81ddbf5-43c6-4f6f-9ace-d748ae737b3e">




<img width="452" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/ec4e45ec-73f2-41e9-a9fe-9b813bb1653b">




<img width="481" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/b984c305-fe51-4595-aa61-b6551addef8c">




<img width="718" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/cd0c8575-d5dd-490b-b63b-1f09fcefc8a1">




Encapsulation (Kapsülleme):
    • Ogrenci sınıfındaki tüm özellikler (Ad, Soyad, OgrenciNo, Bolumu, SecilenDersler, SecilenKulüpler) private set ve public get ile kapsüllenmiştir.  Bu şekilde, sınıfın içindeki verilere kontrollü bir erişim sağlanmış olur. 



<img width="359" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/2fad19f8-9793-4772-9066-4b04aaddba19">



Polymorphism (Çok Biçimlilik):
    • OgrenciOtomasyon sınıfındaki AnaMenu metodu içinde switch bloğu, polimorfizmin bir örneğidir. Farklı şartlara göre farklı metotları çağırabilir.



<img width="440" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/8513f900-53d8-4357-b9fc-e60406fbb848">



Abstraction (Soyutlama):
    • Ogrenci sınıfı soyutlanmış bir yapıdır. Gerçek bir öğrenciyi temsil eder ancak tam anlamıyla somutlaştırılmamıştır. Aynı şekilde OgrenciBilgiSistemi sınıfı, işlemleri soyutlamak amacıyla kullanılmıştır.



<img width="442" alt="image" src="https://github.com/betulinal/ogrenci-otomasyon-BETUL-INAL/assets/144665070/eb2bff2c-c6d1-46cd-9c28-be87761114b9">


























