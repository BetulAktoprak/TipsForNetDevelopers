# TipsForNetDevelopers

## <mark> 📌 BenchmarkDotNet Paketi</mark>

*BenchmarkDotNet, .NET projelerinde kodun performansını ölçmek ve karşılaştırmak için kullanılan bir kütüphanedir. Farklı algoritma ve yöntemleri test ederek, hangi çözümün daha hızlı ve verimli olduğunu belirlememize yardımcı olur.*

## <mark> 📌 AsNoTracking Mekanizması</mark>

*Normalde Entity Framework bir sorgu çalıştırıldığı zaman dönen varlıkları izlemeye alır ve bu varlıklar üzerinde yapılan değişiklikleri otomatik olarak algılar. Değişikliğin izlenmesine gerek olmayan durumlarda "mesela sadece verileri listeleme işlemi yapıyorsak" AsNoTracking metodu ile bu süreci devre dışı bırakarak daha az bellek kullanımı ve daha hızlı sorgu performansı elde ederiz.*

## <mark> 📌 Single Methods / Unique Keyword</mark>

*Single ve SingleOrDefault metotları sorgudan tek bir kayıt döndürmek için kullanırız. Birden fazla aynı kayıt var ise hata(exception) fırlatır.*

*Unique keywordü ise bir sütun grubunun her bir satırda benzersiz olmasını sağlamak için kullanılan bir kısıtlamadır. Aynı değerlerin girilmesini önlemek için kullanırız.*

```csharp
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Product>()
        .HasIndex(e => e.Name)
        .IsUnique();
}
```
## <mark> 📌 Code First ile Index</mark>

```csharp
    .HasIndex()
```
*ifadesi, Entity Framework Core kullanılarak bir tablo sütununa indeks eklemek için kullanılan bir Fluent API yöntemidir. Bu, veritabanında daha hızlı sorgular ve daha iyi performans sağlamak için kullanılır.*

## <mark> 📌 Pagination </mark>

## <mark> 📌 Asenkron Programlama </mark>

*Bir uygulamanın uzun süreli veya gecikme potansiyeli olan işlemleri (örneğin, dosya okuma/yazma, veritabanı sorguları, api istekleri) uygulamanın ana iş parçacığını (main thread) bloke etmeden gerçekleştirmesine olanak tanıyan bir programlama modelidir. Bu model, aynı anda birden fazla işlemi idare edebilir ve kullanıcı deneyimini iyileştirir.*
- UI uygulamalarında, uzun süren işlemler sırasında arayüzün donmasını engeller.
- Uygulama aynı anda birden fazla işlemi yürütürken diğer iş parçacıkları kullanılabilir.
- CPU ve bellek gibi sistem kaynaklarını daha verimli kullanır.
  
**`Task` ve `Task<T>` :**

* Task: Geri dönüşü olmayan bir asenkron işlemi temsil eder.
* `Task<T>`: Bir değeri döndüren asenkron işlemi temsil eder.

## <mark> 📌 CancellationToken </mark>

*C#'da asenkron işlemlerin veya uzun süre çalışan işlemlerin kontrollü bir şekilde iptal edilmesini sağlamak için kullanılan bir mekanizmadır*

- CancellationToken: İptal isteğini taşıyan ve dinleyen nesnedir.

## <mark> 📌 Hata Loglama (ErrorLog) </mark>

*Uygulama sırasında oluşan hataların detaylarını (örneğin hata mesajı, zaman damgası, yığın izi) kaydetmek için kullanılan bir sistemdir. Hatalar bir dosyaya, veritabanına veya merkezi bir loglama servisine kaydedilir. Sorun tespiti, performans optimizasyonu ve kullanıcı deneyimini iyileştirmek için kullanılır.*

#### Hata Yakalama (Exception Handling):
- try-catch blokları ile hatalar yakalanır.

#### ErrorLog'da Kaydedilen Bilgiler
- Hata Mesajı (Error Message): Hatanın kısa açıklaması.
- Yığın İzi (Stack Trace): Hatanın nerede oluştuğunu gösteren kod izleri.
- Zaman Damgası (Timestamp): Hatanın oluştuğu tarih ve saat.

## <mark> 📌 IQueryable </mark>

*Büyük veri kümeleri veya veritabanları ile çalışırken performanslı ve esnek sorgulama yapmayı sağlayan bir arayüzdür. Özellikle Entity Framework gibi ORM araçlarında, SQL sorgularını optimize ederek sadece gerekli veriyi almayı sağlar.*

- 🌟 Gecikmeli Yürütme (Deferred Execution): Sorgu, ihtiyaç anında çalıştırılır.
- ⚡ Performanslı Veri İşleme: Sorgular doğrudan veritabanına SQL olarak gönderilir.
- 🔄 Dinamik Sorgu Bileşimi: Karmaşık işlemleri sadeleştirir.

## <mark> 📌 Record </mark>

*C#'ta record, immutable (değiştirilemez) ve değer tabanlı veri yapıları oluşturmak için kullanılan bir türdür. Veri transfer objeleri (DTO) ve veri modellerinde kod okunabilirliğini ve güvenliğini artırır.*

✨ Avantajları
- 🔒 Immutable Yapı: Veri değiştirilemez.
- 🎯 Değer Eşitliği: Referans yerine değerler karşılaştırılır.
- 🖋️ Daha Az Kod: ToString, Equals, ve GetHashCode otomatik oluşturulur.

```csharp
    public record class Login(
        string Email,
        string Password);
```