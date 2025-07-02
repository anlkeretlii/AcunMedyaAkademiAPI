-- Hotel Projesi Sample Verileri
-- Tüm tabloları doldurmak için SQL Script

-- 1. About Tablosu
INSERT INTO Abouts (Title1, Title2, Content, RoomCount, StaffCount, CustomerCount) VALUES
(N'Lüks Konaklama Deneyimi', N'Modern ve Konforlu Otelimizde Unutulmaz Anılar', N'2010 yılından beri hizmet veren otelimiz, modern mimarisi, lüks odaları ve eşsiz hizmet kalitesiyle misafirlerine unutulmaz bir konaklama deneyimi sunmaktadır. Şehrin kalbinde yer alan otelimiz, iş ve tatil seyahatleriniz için ideal konumdadır. Profesyonel ekibimiz ve premium hizmetlerimizle her anınızı özel kılmaya devam ediyoruz.', 120, 85, 15000);

-- 2. Services Tablosu
INSERT INTO Services (ServiceIcon, Title, Description) VALUES
(N'fa fa-hotel', N'Lüks Odalar', N'Şehir manzaralı, kliması, minibarı ve ücretsiz WiFi olan lüks odalarımızda konfor dolu bir konaklama deneyimi yaşayın.'),
(N'fa fa-utensils', N'Restoran', N'Dünya mutfağından seçkin lezzetleri sunan restoranımızda, usta şeflerimizin hazırladığı özel menüleri deneyimleyin.'),
(N'fa fa-swimmer', N'Yüzme Havuzu', N'Kapalı ve açık yüzme havuzlarımızda dinlendirici bir yüzme keyfi yaşayın. Çocuk havuzumuz da mevcuttur.'),
(N'fa fa-dumbbell', N'Fitness Center', N'Modern ekipmanlarla donatılmış fitness salonumuzda formunuzu koruyabilir, kişisel antrenör desteği alabilirsiniz.'),
(N'fa fa-spa', N'Spa & Wellness', N'Uzman terapistlerimizin ellerinde rahatlatıcı masajlar ve sağlık hizmetleriyle kendinizi yenileyin.'),
(N'fa fa-wifi', N'Ücretsiz WiFi', N'Tüm otel alanlarında yüksek hızlı ücretsiz internet erişimi ile bağlantınızı hiç kaybetmeyin.'),
(N'fa fa-concierge-bell', N'24/7 Resepsiyon', N'Gece gündüz hizmetinizdeki profesyonel resepsiyon ekibimizle tüm ihtiyaçlarınızı karşılayın.'),
(N'fa fa-car', N'Valet Park', N'Kapı önü otopark hizmeti ile araçınızı güvenle park edebilir, anahtarını teslim edebilirsiniz.');

-- 3. Rooms Tablosu
INSERT INTO Rooms (RoomNumber, RoomCoverImage, Price, Title, BedCount, BathCount, Wifi, Description) VALUES
(N'101', N'/images/rooms/room1.jpg', 2500, N'Standart Tek Kişilik Oda', N'1', N'1', N'Var', N'Şehir manzaralı, klimalı, 25 m² tek kişilik odamızda LCD TV, minibar ve çalışma masası bulunmaktadır.'),
(N'102', N'/images/rooms/room2.jpg', 3500, N'Standart Çift Kişilik Oda', N'1', N'1', N'Var', N'35 m² büyüklüğündeki çift kişilik odamızda king size yatak, oturma alanı ve şehir manzarası yer almaktadır.'),
(N'201', N'/images/rooms/room3.jpg', 4500, N'Deluxe Oda', N'1', N'1', N'Var', N'45 m² lüks odamızda ayrı oturma alanı, mini mutfak ve geniş balkon ile konforlu bir konaklama deneyimi.'),
(N'202', N'/images/rooms/room4.jpg', 6000, N'Junior Suite', N'1', N'2', N'Var', N'65 m² suite odamızda ayrı yatak odası, oturma salonu, jakuzili banyo ve deniz manzarası bulunmaktadır.'),
(N'301', N'/images/rooms/room5.jpg', 8500, N'Executive Suite', N'2', N'2', N'Var', N'85 m² executive suite odamızda 2 yatak odası, salon, mutfak ve özel balkon ile lüks konaklama.'),
(N'302', N'/images/rooms/room6.jpg', 12000, N'Presidential Suite', N'2', N'3', N'Var', N'150 m² presidential suite odamızda özel havuz, jakuzi, salon ve panoramik şehir manzarası.'),
(N'103', N'/images/rooms/room7.jpg', 3000, N'Aile Odası', N'2', N'1', N'Var', N'40 m² aile odamızda 4 kişiye kadar konaklama imkanı, çocuk yatağı ve aile dostu amenityler.'),
(N'104', N'/images/rooms/room8.jpg', 2800, N'Economy Oda', N'1', N'1', N'Var', N'20 m² ekonomik odamızda temel ihtiyaçlarınızı karşılayacak konforda uygun fiyatlı konaklama.');

-- 4. Staff Tablosu
INSERT INTO Staff (Name, Title, SocialMedia1, SocialMedia2, SocialMedia3) VALUES
(N'Ahmet Yılmaz', N'Genel Müdür', N'https://linkedin.com/in/ahmetyilmaz', N'https://twitter.com/ahmetyilmaz', N'https://instagram.com/ahmetyilmaz'),
(N'Elif Kaya', N'Resepsiyon Müdürü', N'https://linkedin.com/in/elifkaya', N'https://twitter.com/elifkaya', N'https://instagram.com/elifkaya'),
(N'Mehmet Demir', N'Aşçıbaşı', N'https://linkedin.com/in/mehmetdemir', N'https://twitter.com/mehmetdemir', N'https://instagram.com/mehmetdemir'),
(N'Ayşe Şahin', N'Housekeeping Müdürü', N'https://linkedin.com/in/aysesahin', N'https://twitter.com/aysesahin', N'https://instagram.com/aysesahin'),
(N'Can Özkan', N'Concierge', N'https://linkedin.com/in/canozkan', N'https://twitter.com/canozkan', N'https://instagram.com/canozkan'),
(N'Zeynep Arslan', N'Spa Müdürü', N'https://linkedin.com/in/zeyneparslan', N'https://twitter.com/zeyneparslan', N'https://instagram.com/zeyneparslan'),
(N'Burak Kılıç', N'Güvenlik Şefi', N'https://linkedin.com/in/burakkilic', N'https://twitter.com/burakkilic', N'https://instagram.com/burakkilic'),
(N'Selin Yıldız', N'Etkinlik Koordinatörü', N'https://linkedin.com/in/selinyildiz', N'https://twitter.com/selinyildiz', N'https://instagram.com/selinyildiz');

-- 5. Testimonials Tablosu
INSERT INTO Testimonials (Name, Title, Description, Image) VALUES
(N'Ali Veli', N'İş İnsanı', N'Harika bir deneyimdi! Personel çok ilgili ve odalar temizdi. Kesinlikle tekrar geleceğim.', N'/images/testimonials/person1.jpg'),
(N'Fatma Öztürk', N'Mimar', N'Muhteşem bir otel! Spa hizmetleri çok kaliteli, restoran menüsü de çok başarılı. Herkese tavsiye ederim.', N'/images/testimonials/person2.jpg'),
(N'Emre Yılmaz', N'Yazılım Mühendisi', N'Lokasyon mükemmel, WiFi hızı çok iyi. İş seyahati için ideal bir yer. 5 yıldızı hak ediyor.', N'/images/testimonials/person3.jpg'),
(N'Sibel Korkmaz', N'Doktor', N'Ailecek kaldık ve çok memnun olduk. Çocuk dostu hizmetler çok iyiydi. Teşekkürler!', N'/images/testimonials/person4.jpg'),
(N'Murat Aslan', N'Avukat', N'Suite odamız harika, manzara muhteşemdi. Kahvaltı çeşitliliği de çok zengin. Mutlaka tekrar geliyoruz.', N'/images/testimonials/person5.jpg'),
(N'Nermin Soylu', N'Öğretmen', N'Temizlik standartları çok yüksek, personel çok kibar. Fiyat performans açısından çok başarılı.', N'/images/testimonials/person6.jpg');

-- 6. Guests Tablosu
INSERT INTO Guests (Name, Surname, City) VALUES
(N'Ahmet', N'Mehmet', N'İstanbul'),
(N'Ayşe', N'Yılmaz', N'Ankara'),
(N'Mehmet', N'Kaya', N'İzmir'),
(N'Fatma', N'Demir', N'Bursa'),
(N'Ali', N'Şahin', N'Antalya'),
(N'Zeynep', N'Özkan', N'Adana'),
(N'Burak', N'Arslan', N'Gaziantep'),
(N'Selin', N'Kılıç', N'Konya'),
(N'Can', N'Yıldız', N'Mersin'),
(N'Elif', N'Çelik', N'Trabzon'),
(N'Murat', N'Aydın', N'Diyarbakır'),
(N'Ebru', N'Özdemir', N'Samsun'),
(N'Serkan', N'Güneş', N'Malatya'),
(N'Deniz', N'Kaplan', N'Erzurum'),
(N'Gizem', N'Akar', N'Van');

-- 7. Bookings Tablosu
INSERT INTO Bookings (Name, Mail, Checkin, CheckOut, AdultCount, ChildCount, RoomCount, SpecialRequest, Description, Status, City, Country) VALUES
(N'Ahmet Yılmaz', N'ahmet@gmail.com', '2024-12-25', '2024-12-30', N'2', N'0', N'1', N'Deniz manzaralı oda', N'Balayı için konaklama', N'Onaylandı', N'İstanbul', N'Türkiye'),
(N'Elif Kaya', N'elif@hotmail.com', '2024-12-20', '2024-12-22', N'1', N'0', N'1', N'Geç check-out', N'İş seyahati', N'Beklemede', N'Ankara', N'Türkiye'),
(N'Mehmet Demir', N'mehmet@yahoo.com', '2025-01-05', '2025-01-10', N'4', N'2', N'2', N'Çocuk yatağı', N'Aile tatili', N'Onaylandı', N'İzmir', N'Türkiye'),
(N'Ayşe Şahin', N'ayse@gmail.com', '2024-12-28', '2025-01-02', N'2', N'1', N'1', N'Yüksek kat', N'Yılbaşı tatili', N'Onaylandı', N'Bursa', N'Türkiye'),
(N'Can Özkan', N'can@outlook.com', '2025-01-15', '2025-01-18', N'2', N'0', N'1', N'Spa randevusu', N'Romantik kaçamak', N'Beklemede', N'Antalya', N'Türkiye'),
(N'Zeynep Arslan', N'zeynep@gmail.com', '2025-02-01', '2025-02-05', N'3', N'1', N'2', N'Havuz manzarası', N'Arkadaş grubu tatili', N'İptal Edildi', N'Adana', N'Türkiye'),
(N'Burak Kılıç', N'burak@hotmail.com', '2024-12-22', '2024-12-25', N'1', N'0', N'1', N'Sessiz oda', N'İş toplantısı', N'Onaylandı', N'Gaziantep', N'Türkiye'),
(N'Selin Yıldız', N'selin@yahoo.com', '2025-01-20', '2025-01-25', N'2', N'0', N'1', N'Yoga matı', N'Wellness tatili', N'Beklemede', N'Konya', N'Türkiye');

-- 8. Subscribe Tablosu (E-bülten aboneleri)
INSERT INTO Subscribes (Mail) VALUES
(N'ahmet.yilmaz@gmail.com'),
(N'elif.kaya@hotmail.com'),
(N'mehmet.demir@yahoo.com'),
(N'ayse.sahin@gmail.com'),
(N'can.ozkan@outlook.com'),
(N'zeynep.arslan@gmail.com'),
(N'burak.kilic@hotmail.com'),
(N'selin.yildiz@yahoo.com'),
(N'murat.aslan@gmail.com'),
(N'deniz.kaplan@outlook.com');

-- 9. MessageCategory Tablosu (Önce bu tablo doldurulmalı - Foreign Key için)
INSERT INTO MessageCategories (MessageCategoryName) VALUES
(N'Rezervasyon'),
(N'Şikayet'),
(N'Öneri'),
(N'Bilgi'),
(N'Organizasyon'),
(N'Teknik Destek');

-- 10. Contact Tablosu (MessageCategoryID ile birlikte)
INSERT INTO Contacts (Name, Mail, Subject, Message, Date, MessageCategoryID) VALUES
(N'Ali Veli', N'ali@gmail.com', N'Rezervasyon Hakkında', N'Merhaba, rezervasyon yapmak istiyorum. Müsait tarihler hakkında bilgi alabilir miyim?', GETDATE(), 1),
(N'Fatma Öztürk', N'fatma@hotmail.com', N'Spa Hizmetleri', N'Spa hizmetleriniz hakkında detaylı bilgi almak istiyorum. Fiyat listesi var mı?', GETDATE(), 4),
(N'Emre Yılmaz', N'emre@yahoo.com', N'Toplantı Salonu', N'50 kişilik toplantı için salon kiralaması yapmak istiyorum. Teklifinizi bekliyorum.', GETDATE(), 5),
(N'Sibel Korkmaz', N'sibel@gmail.com', N'Düğün Organizasyonu', N'Düğün organizasyonu için otel hizmetlerinizi değerlendiriyoruz. Görüşebilir miyiz?', GETDATE(), 5),
(N'Murat Aslan', N'murat@outlook.com', N'Grup Rezervasyonu', N'20 kişilik grup için toplu rezervasyon yapmak istiyorum. İndirim var mı?', GETDATE(), 1),
(N'Deniz Kaya', N'deniz@gmail.com', N'WiFi Problemi', N'Odamda WiFi bağlantısında sorun yaşıyorum. Yardımcı olabilir misiniz?', GETDATE(), 6),
(N'Seda Özkan', N'seda@hotmail.com', N'Temizlik Hizmeti', N'Oda temizleme saatlerini değiştirebilir miyiz? Çok erken geliyorlar.', GETDATE(), 2);

-- 11. WorkLocation Tablosu
INSERT INTO WorkLocations (WorkLocationName, WorkLocationCity) VALUES
(N'Genel Müdürlük', N'İstanbul'),
(N'Resepsiyon', N'İstanbul'),
(N'Mutfak', N'İstanbul'),
(N'Housekeeping', N'İstanbul'),
(N'Spa Merkezi', N'İstanbul'),
(N'Güvenlik', N'İstanbul'),
(N'Etkinlik Salonu', N'İstanbul'),
(N'Restoran', N'İstanbul');

-- 12. SendMessage Tablosu (İç mesajlaşma sistemi)
INSERT INTO SendMessages (SenderName, SenderMail, ReceiverName, ReceiverMail, Title, Content, Date) VALUES
(N'Ahmet Yılmaz', N'ahmet@hotel.com', N'Elif Kaya', N'elif@hotel.com', N'Bugünkü Rezervasyonlar', N'Bugün gelen misafirler için odalar hazır mı? Kontrol edelim.', GETDATE()),
(N'Elif Kaya', N'elif@hotel.com', N'Ayşe Şahin', N'ayse@hotel.com', N'Oda Temizliği', N'301 numaralı oda ekstra temizlik gerekiyor. Misafir şikayet etti.', GETDATE()),
(N'Mehmet Demir', N'mehmet@hotel.com', N'Ahmet Yılmaz', N'ahmet@hotel.com', N'Menü Güncelleme', N'Yeni sezon menüsü hazır. Onayınız için sunuyorum.', GETDATE());

PRINT 'Sample veriler başarıyla eklendi!'
PRINT 'Toplam eklenen kayıtlar:'
PRINT '- About: 1 kayıt'
PRINT '- Services: 8 kayıt' 
PRINT '- Rooms: 8 kayıt'
PRINT '- Staff: 8 kayıt'
PRINT '- Testimonials: 6 kayıt'
PRINT '- Guests: 15 kayıt'
PRINT '- Bookings: 8 kayıt'
PRINT '- Subscribes: 10 kayıt'
PRINT '- MessageCategories: 6 kayıt'
PRINT '- Contacts: 7 kayıt'
PRINT '- WorkLocations: 8 kayıt'
PRINT '- SendMessages: 3 kayıt' 