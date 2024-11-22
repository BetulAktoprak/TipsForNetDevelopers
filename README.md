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

