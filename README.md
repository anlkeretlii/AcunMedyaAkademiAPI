# AcunMedyaAkademiAPI

## 🏨 Otel Rezervasyon Sistemi

Bu proje, **AkademIQ.ai.net** tarafından verilen **"C# ile Programlamaya Giriş"** eğitimi kapsamında geliştirilmiştir.  
Modern yazılım geliştirme prensiplerine uygun olarak **N-Tier (Katmanlı) Mimari** yapısında tasarlanmış uçtan uca bir **Otel Rezervasyon Sistemi** sunmaktadır.

## 🚀 Proje Hakkında
Proje, hem son kullanıcı hem de yönetici tarafını kapsayan; güvenli, ölçeklenebilir ve yönetilebilir bir rezervasyon platformudur.  
Teorik bilgilerin pratiğe dökülmesi ve bir fikrin **analizden çalışan ürüne dönüşme sürecinin** deneyimlenmesi hedeflenmiştir.

## 🛠 Kullanılan Teknolojiler

**Backend:**
- ASP.NET Core Web API – Güvenli ve performanslı RESTful servisler
- Entity Framework Core – ORM tabanlı veritabanı yönetimi
- Generic Repository Pattern – Soyutlanmış veri erişimi
- JWT (JSON Web Token) Authentication – Kimlik doğrulama

**Frontend:**
- ASP.NET Core MVC – Kullanıcı arayüzü ve yönetici paneli

**Veri Yönetimi:**
- DTO (Data Transfer Object) – Katmanlar arası veri taşıma
- AutoMapper – Veri dönüştürme

**Entegrasyon:**
- RapidAPI – Döviz kurları gibi harici API verilerinin entegrasyonu

## 📂 Proje Mimarisi
📦 OtelRezervasyonSistemi
├── 📁 BusinessLayer # İş mantığı ve servisler
├── 📁 DataAccessLayer # Veritabanı işlemleri ve repository yapısı
├── 📁 EntityLayer # Veri modelleri
├── 📁 WebAPI # RESTful API katmanı
└── 📁 WebUI # MVC tabanlı frontend (kullanıcı & admin paneli)


## 🔐 Güvenlik
Tüm API endpoint’leri, **JWT tabanlı kimlik doğrulama** ile korunmaktadır.  
Kullanıcılar yalnızca yetkilendirildikleri alanlara erişebilir.

## 📸 Ekran Görselleri

<img width="1317" height="898" alt="Ekran görüntüsü 2025-08-15 114504" src="https://github.com/user-attachments/assets/25498bd8-510c-427b-9f8d-7880e4c2d9d1" />

<img width="1318" height="912" alt="Ekran görüntüsü 2025-08-15 114551" src="https://github.com/user-attachments/assets/899b8df0-7844-4192-98ff-b79223a88438" />

<img width="1918" height="929" alt="Ekran görüntüsü 2025-08-15 114910" src="https://github.com/user-attachments/assets/3dc0871e-20a7-42de-a52f-5593f366c2a8" />

<img width="1425" height="927" alt="Ekran görüntüsü 2025-08-15 114321" src="https://github.com/user-attachments/assets/016a1205-c319-469a-a388-56a986511da3" />


