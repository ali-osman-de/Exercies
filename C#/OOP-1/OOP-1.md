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