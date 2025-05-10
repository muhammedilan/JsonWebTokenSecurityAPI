
# Proje Başlığı

Entity Framework Core, SQL Server ve JSON Web Token yapıları ile register, login, authentication, authorization, role-based authorization ve refresh token işlemlerini gerçekleştirdim. 

Projede API dokümantasyonu için Scalar kullandım ve Git commit'lerini temiz ve düzenli tuttum.

&nbsp;
## Kullanılan Teknolojiler
- C#
- .NET 9.0
- Visual Studio
- ASP.NET Core Web API
- Scalar API Documentation
- Entity Framework Core 9.0
- Microsoft SQL Server
- JSON Web Token

&nbsp;
## Ekran Görüntüleri

![Scalar API Docs](https://res.cloudinary.com/dd5hzgg9i/image/upload/v1746880966/JsonWebTokenSecurityAPI_rkav6h.png)

&nbsp;
## Ortam Değişkenleri

Bu projeyi çalıştırmak için aşağıdaki ortam değişkenlerini appsettings.Development.json dosyanıza eklemeniz gerekecek

- Not: Gerçek proje geliştirme ortamında gizli bilgilerin development ortamındayken secrets.json'da ve production ortamındayken environment variables olarak verilmesi daha doğrudur. Ancak örnek bir proje yaptığım için bilerek appsettings.Development.json'a gizli bilgileri yerleştirdim.

`ConnectionStrings__UserDatabase`

`AppSettings__Token`

`AppSettings__Issuer`

`AppSettings__Audience`

&nbsp;
## Bilgisayarınızda Çalıştırın

Projeyi klonlayın

```bash
git clone https://github.com/muhammedilan/JsonWebTokenSecurityAPI.git
```

Proje dizinine gidin

```bash
cd JsonWebTokenSecurityAPI
```

Gerekli paketleri yükleyin

```bash
dotnet restore
```

Veritabanını hazırlayın

```bash
dotnet ef database update
```

Sunucuyu çalıştırın

```bash
dotnet run
```

&nbsp;
## Geri Bildirim

Herhangi bir geri bildiriminiz varsa, lütfen muhammed.ilan.se@gmail.com adresinden bize ulaşın.

&nbsp;
