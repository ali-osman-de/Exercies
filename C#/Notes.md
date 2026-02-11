### C# Orta Seviyeli Dillerden (Yüksek - Konuşma dili --> Düşük - Makina Dili)
- Microsoft Tarafından Open-Source olarak sunulmaktadır.

### .NET Framework vs .NET Core
- .NET bir geliştirme çatısıdır.
- Framework ve Core her türlü platform için geliştirilebilir fakat framework windows sunucu özelinde, core ise tüm makinalara deploy edelebilir. Kısaca framework windows'a bağlı core ise cross-platform diyebiliyoruz.

### Compiler Nedir? ve Nasıl Çalışır?
- Derlemek yazılan dilin bilgisayarın anlayacağı dile çevrilmesidir. (Örnek olarak .exe dosyaları bilgisayarın anlayacağı dille çevrilmiş dosyalardandır.)

### Project vs Solution 
- Solution: İçerisinde bir veya birden fazla projeyi kapsayan bütünlük.
- Project: Kodlarının yazdığın bir bütün parçası.

### Temel Kod Prensipleri
- Kendi Tekrar Etmeme, anlık çözüm oluşturma, ezberleme yok.
- Anlamlı isimlendirme.

### Değişken Nedir?
- Yazılımda veriler RAM üzerinde tutulur ve oradan kullanılır
- Bu esnada yazılımdaki değişkenler veriyi gidip ram'e yazıp daha sonra ihtiyaç duyduğu anda tekrar o değişken adıyla çağırması.
- Veri türleri bildirilmelidir.
- Primitive Türler (BYTE, INT, CHAR) -> Değer Türlü Değişkenler(DECIMAL)
- Reference Türler -> Nesne Tutan Değişkenler
- Type(Ram'de alan tahsisi) DeğişkenAdı = değeri;
- Bu DeğişkenAdı adlı değişkene artık Type ne ise o türde veriler atanabilir.

### C# Dili Özellikleri
- Büyük küçük harf duyarlılığı ali!=Ali!=aLi
- Tip Güvenli, int a = 5;   a!='5';

