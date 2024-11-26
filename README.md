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

## <mark> 📌 Sealed </mark>

*C#'ta sealed, bir sınıfın veya bir metodun türetilmesini veya üzerine yazılmasını engellemek için kullanılan bir anahtar kelimedir.*

- Sınıflarda: Bir sınıfın başka bir sınıf tarafından inherit edilmesini önler.
- Metotlarda: Bir metodun alt sınıflarda geçersiz kılınmasını engeller.

🌟 Kod Güvenliği: Hatalı türetmelerin önüne geçilir.
🎯 Tasarım Tutarlılığı: İstenmeyen değişikliklerin önüne geçilir.

## <mark> 📌 Performance Log </mark>

*Bir uygulamanın performansını izlemek ve optimize etmek için kullanılan bir araçtır. İşlem sürelerini, kaynak kullanımını ve performans sorunlarını kaydederek daha hızlı ve verimli bir uygulama geliştirilmesine olanak tanır.*

#### 🔎 Kullanım Alanları
- Web Uygulamaları: API çağrıları, sorgu süreleri ve yanıt sürelerini izlemek.
- Masaüstü Uygulamaları: Uzun süren işlemleri veya kritik görevleri analiz etmek.
- Veritabanı İşlemleri: SQL sorgularının performansını izlemek ve optimize etmek.
- Dağıtık Sistemler: Mikroservisler arasındaki iletişim sürelerini ölçmek.

## <mark> 📌 AsReadOnly Metodu </mark>

*C#'ta AsReadOnly, bir koleksiyonu yalnızca okuma modunda kullanıma sunar. Bu yöntem, koleksiyonun yapısal değişikliklere (ekleme, silme) karşı korunmasını sağlar. Ancak, koleksiyon içindeki nesnelerin özellikleri değiştirilebilir.*

🚀 Örnek Kullanım
```csharp
    IReadOnlyList<Product> products = context.Products.ToList().AsReadOnly();
```

## <mark> 📌 Any ve All Metotları </mark>

*🔍 Bir koleksiyonda en az bir elemanın belirli bir koşulu sağlayıp sağlamadığını kontrol eder. Eğer koşulu sağlayan en az bir eleman varsa, true döner.*

*🔍Bir koleksiyondaki tüm elemanların belirli bir koşulu sağlayıp sağlamadığını kontrol eder. Eğer tüm elemanlar koşulu sağlıyorsa, true döner.*

⚠️ Bu metotlar, koleksiyonlar üzerinde hızlı ve etkili koşul kontrolleri yapmak için kullanılır. Any, koşulu sağlayan tek bir eleman ararken, All, tüm elemanların koşula uygun olup olmadığını kontrol eder.

## <mark> 📌 Eager Loading / Lazy Loading </mark>

### **Eager Loading**

*İlişkili tüm veriler **ilk sorguda** yüklenir.*
  - Performansı büyük veri setlerinde optimize eder.

- **Ne Zaman Kullanılır?**
  - İlişkili tüm verilere hemen ihtiyaç varsa.

**Örnek Kod:**
```csharp
    IList<Product> products2 = context.Products.Include(p => p.Category).ToList();
```
---

### **Lazy Loading**

*İlişkili veriler yalnızca **ihtiyaç duyulduğunda** yüklenir.*
  - Daha az bellek kullanımı.
  - Kullanılmayan veriler yüklenmez.

- **Ne Zaman Kullanılır?**
  - Verilerin tamamına her zaman ihtiyaç yoksa.

**Örnek Kod:**
```csharp
    IList<Product> products = context.Products.ToList();
```
---

| **Özellik**         | **Eager Loading**              | **Lazy Loading**               |
|-----------------------|--------------------------------|---------------------------------|
| **Yükleme Zamanı**  | İlk sorguda                  | İhtiyaç duyulduğunda          |
| **Sorgu Sayısı**     | Daha az (tek seferde)          | Daha fazla (parça parça)        |
| **Performans**        | Çoklu veri çekiminde daha iyi  | Az veride daha iyi             |
| **Kullanım Durumu** | Verilerin tümü gerekiyorsa      | Veri parça parça çekilecekse    |

---

## <mark> 📌 Required Member </mark>

*Belirli üyelerin atanmasını zorunlu kılan bir özelliktir. Bu, eksik veri kaynaklı hataları önler ve kodu daha güvenli hale getirir.*

- Eksik Veri Hatalarını Önler: Zorunlu üyelerin atlanmasını engeller.
- Güvenli Kod: Derleme aşamasında eksik atamaları kontrol eder.
- Okunabilirlik: Gerekli üyeleri açıkça belirtir.

**Örnek Kullanım:**
```csharp
  public required string Name { get; set; }
```