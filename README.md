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