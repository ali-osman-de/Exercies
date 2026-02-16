### Nesne Yönelimli Programlama // Yaklaşım Prensibi
- Gerçek hayattı olguları, birer nesnelere indirgeyerek onları yazılımda simüle edibilmemizi sağlayan yaklaşım.
- her şey nesnedir.
- Sen, Ben, Yolda Yürüyen, Ev, Bina.
- Nesneler birbiri ile haberleşebilir.
- Nesneler birer objedir ve içlerinde veri barındırdıkları kısımlar ise birer Field'lardır.
- Nesneler ayrıca metotlar yani fonksiyonlar barındırabilir.
- Nesne --> Class'ın bir ürünüdür.
- Bir class modelinden birden fazla nesne üretebiliriz.
- Nesneler hangi türdendir? --> Referans türlüdür.
- Direkt nesnelere erişim sağlamıyoruz. Bir referans türlü değişken tanımlıyoruz --> bu değişken bir nesneye refere ediyor. Yani ref. değişken Stack'te, Nesne ise Heap'te.


### Class Kavramı - Sınıf Kavramı - Sınıf Nesne Arasındaki ilişki
- Bir obje modellenmesi gerekir, yani bir obje bir Class nesnesine denk gelir.
- Sınıf ile Nesne arasındaki ilişki --> Class'tan birçok nesne oluşturulabilir.
- Class'lar ayrıca tür özelliği de taşır.
- Namespace içerisinde, dışında, Class içerisinde(Nested type) oluşturulabilirler.

### Class Members
- Field --> Nesne içerisinde depolanan değişkenler, herbiri farklı türden olabilir.
- Property --> özünde bir metotdur, fiziksel olarak değer almayan ve get,set blok barındırmaktadır. Metottan farkı yoktur
Get --> değer okuma, Set --> değer atama  *** Bu özelliğe ENCAPSULATION / KAPSÜLLEME / SARMALAMA diyoruz ***
* ENCAPSULATION / KAPSÜLLEME / SARMALAMA bir nesnedeki fieldların dışarıya kontrollü olarak açılması ve dışardan değer alınması işlemine denir.

### Nesne Nedir? Derinlemesine
- Birden fazla birbirleriyle ilişki bir yapılanma, veri bütünü
- Bir insan bütün olarak veridir yani nesnedir, ayrıca bunların tüm diğer özellikleri de fieldları desek yanlış olmaz ama yine de bir nesnedir.
- Complex veriler birer Nesnedir diyebiliriz.
- Lüzumsuz değerleri içermemelidir.
- Classlar ise Complex Type olarak geçer yani türdür.
- Nesneyi neden kullanırız diye soru gelirse, daha sistematik ve düzenli, hızlı bir şekilde yapabilmek adına

### Referans Nedir?
- Ram'in stack bölgesinde tanımlanan ve Heap bölgesindeki nesneleri işaretleyen değişkenlerdir.
- a değişkeni stackte a'nin referesi yani referansı heapte tutulur.
- interface, class, abstract class birer referanslardır. Record'ta bir referanstır.
- Nesne sadece ve sadece Class'tan  Class == Nesne
- Referanslar bir nesne refere etmek zorunda değil ve null olarak işaretlenebilir.


### Shallow Copy vs Deep Copy
- a = 5; b = a; bu deep copy'dir, çünkü artık elimizde iki tane 5 vardır.
- Referanslar shallow copy'dir, bir referans diğer değişkene atanınınca aslında bir önceki referansı almış olur.
- Referans türlü değerler default olarak shallow copy yaparlar, elde var 1 tane elde olacak 1 tane
- Değer türlü değişkenler ise default'ta deep copy yaparlar.
- MemberwiseClone() --> ile ilgili nesne referansını deep olarak kopyalamamızı sağlar.

### Encapsulation/ Kapsülleme/ Sarmalama
- Nesne içerisindeki fieldları kontrollü olarak dışarı açılmasıdır veya içeri alınması.
- Başka kişilerin yanlış kullanımlarını önlemek.
- Bir kapı görevi görür demek yanlış olmaz, şartları biz belirliyoruz.

### Record Sınıfı Nedir?
- C#9 ile birlikte gelen Init-Only properyies özelliği.
- Bu özellik hem o fieldları read-only yapıyor hemde ilk tanımlama aşaması için set; bloğu yoksa ortadan kaldırıyor.
- Nesnenin ilk yaratılış anında propertylerine değer atanmakta ve böylece iş kuralları gereği run-time'da değiştirilmemesi.
- Nesne önplanda ise class nesnenin değerleri ön planda ise record
- lightweight class olarakta düşünülebilir.
- Record dataları sabitleyerek onları önplana atar.