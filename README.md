# BookStore Web API

Bu proje, modern web API geliştirme prensiplerini uygulayan, ölçeklenebilir ve bakımı kolay bir **BookStore Web API** uygulamasıdır. ASP.NET Core ve Entity Framework Core kullanılarak tasarlanmış olup kitap mağazası işlemleri için kapsamlı özellikler sunar.

## Projenin Amacı
Kitap mağazası işlemlerini yönetmek için geliştirilen bu API, CRUD işlemleri, gelişmiş veri formatları ve API navigasyonu gibi özellikleriyle istemcilerin ihtiyaçlarına esnek bir şekilde yanıt verir. Projenin temel özellikleri şunlardır:
- Kitap yönetimi (CRUD)
- Filtreleme, sayfalama ve veri şekillendirme
- API navigasyonu için HATEOAS desteği
- Çoklu veri formatı (JSON, XML, CSV) desteği
- Gelişmiş hata yönetimi ve güvenlik

## Kullanılan Teknolojiler
### Ana Framework ve Altyapı
- .NET Core 8.0
- ASP.NET Core Web API
- Entity Framework Core (Veritabanı işlemleri için)
- AutoMapper (DTO dönüşümleri için)

### Loglama ve Dokümantasyon
- **NLog**: Detaylı loglama sistemi
- **Swagger/OpenAPI**: API dokümantasyonu

### Veri Formatları ve İşleme
- JSON ve XML desteği
- Özel CSV formatter
- HATEOAS (Hypermedia as the Engine of Application State)
- Data Shaping (Veri şekillendirme)

### Güvenlik ve Filtreleme
- CORS politikası
- Custom Action Filters
- Validation Filters
- Media Type Validation

## Proje Yapısı ve Katmanları
### Presentation Layer
- Controllers
- Action Filters
- Route yapılandırması

### Services Layer
- İş mantığı (Business Logic)
- Servis arayüzleri
- Data Shaping ve HATEOAS implementasyonu

### Repositories Layer
- Veri erişim katmanı
- Repository Pattern implementasyonu

### Entities Layer
- Model sınıfları
- DTO'lar (Data Transfer Objects)
- Link modelleri (HATEOAS için)

## Projenin Özellikleri
### Temel İşlevler
- Kitap kayıtlarının yönetimi (CRUD işlemleri)
- Kitapların listelenmesi ve filtrelenmesi
- Detaylı kitap bilgisi görüntüleme

### Gelişmiş Özellikler
- HATEOAS desteği ile API navigasyonu
- Data Shaping (istemcinin istediği alanlara göre veri şekillendirme)
- JSON, XML ve CSV formatlarında veri desteği
- Sayfalama ve filtreleme
- Versiyonlama desteği

### Teknik Özellikler
- Exception handling (Hata yönetimi)
- Loglama sistemi
- Model validation
- Content negotiation
- CORS yapılandırması

