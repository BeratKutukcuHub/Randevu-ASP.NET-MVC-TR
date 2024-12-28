Hastane Randevu Sistemi
Bu proje, hastane randevu alma, üye girişi, personel girişi ve admin paneli gibi işlevleri içeren bir web uygulamasıdır. Proje, .NET Core, Entity Framework Core ve AutoMapper kullanarak geliştirilmiştir. Uygulama, MSSQL veritabanı kullanmakta olup, CRUD işlemleri ve kullanıcı doğrulama işlemleri gibi temel işlevleri desteklemektedir.

Proje Özeti
Admin Paneli: Admin kullanıcıları, personel ekleyebilir, düzenleyebilir, silebilir ve listeleyebilir. Admin ayrıca tüm sistemin genel ayarlarını yönetebilir.
Personel Girişi: Personel kullanıcıları sisteme giriş yapabilir ve mesajlaşma gibi belirli işlemleri gerçekleştirebilir.
Kullanıcı Girişi ve Kayıt: Üyeler, sisteme kaydolabilir ve giriş yapabilirler.
Randevu Sistemi: Kullanıcılar, hastaneler için randevu alabilirler.
Teknolojiler
ASP.NET Core MVC: Web uygulaması çatısı
Entity Framework Core: Veritabanı işlemleri
AutoMapper: Nesneler arası veri aktarımı
MSSQL: Veritabanı yönetimi
Session Management: Kullanıcı oturumları

Kurulum: Proje kurulumunu yapabilmek için aşağıdaki adımları takip edebilirsiniz:

1. Projeyi Klonlayın
git clone https://github.com/BeratKutukcuHub/Randevu-ASP.NET-MVC-TR
cd project-directory

3. Bağımlılıkları Yükleyin
Projede kullanılan paketleri yüklemek için aşağıdaki komutu çalıştırın:
dotnet restore

3. Veritabanı Migrasyonunu Uygulayın
Veritabanı şemasını oluşturmak için Entity Framework Core migrasyonlarını kullanın. Bunun için aşağıdaki komutu çalıştırabilirsiniz:

dotnet ef database update
4. Bağlantı Dizesini Yapılandırın : EfCore Konfigürasyonunu Takip edin ve migrate atın.


5. Uygulamayı Çalıştırın : Projeyi başlatmak için aşağıdaki komutu kullanın:
dotnet run
Tarayıcınızda http://localhost:5000 adresine giderek uygulamayı görüntüleyebilirsiniz.

Kullanım
Admin Paneli
Personel Ekleme: Admin, personel adı ve şifresiyle yeni personel kaydı oluşturabilir.
CRUD İşlemleri: Admin, personel bilgilerini düzenleyebilir, silebilir ve listeleyebilir.
Randevu Yönetimi: Admin, tüm randevu verilerini görebilir.
Personel Girişi
Personel, kendi kullanıcı adı ve şifresiyle giriş yapabilir.
Giriş yaptıktan sonra mesajlaşma özelliği kullanabilir.
Üye Girişi ve Kayıt
Kullanıcılar, üyelik işlemleriyle sisteme kaydolabilir ve giriş yapabilirler.
Kullanıcılar, sisteme giriş yaptıktan sonra randevu alabilirler.
Proje Yapısı
diff
- /Controllers          -> Uygulama denetleyicileri (Admin, Personel, Kullanıcı)
- /Models               -> Veritabanı modelleri (Entity)
- /Views                -> Kullanıcı arayüzü
- /Data                 -> Veritabanı bağlantısı ve migrasyonlar
- /Services             -> Uygulama iş mantığı (Personel hizmetleri, kullanıcı yönetimi vb.)
- /wwwroot              -> Statik dosyalar (CSS, JS, vb.)
- /Areas                -> Paneller arasında geçiş
Katkıda Bulunma
Proje, katkılara açık bir projedir. Eğer geliştirme yapmak istiyorsanız, aşağıdaki adımları takip edebilirsiniz:

Fork yapın.
Yeni bir özellik ekleyin veya hata düzeltmesi yapın.
Değişikliklerinizi pull request (PR) olarak gönderin.

Bilinen Sorunlar
Bağlantı dizesi hataları olabilir, veritabanı bağlantısını dikkatlice kontrol edin.
Sistemde bazı mesajlaşma ve oturum yönetimi hataları yaşanabilir.

Lisans
Bu proje MIT Lisansı ile lisanslanmıştır.
