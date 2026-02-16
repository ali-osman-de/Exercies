class AppleAndOrange
{
    #region Tüm Caselerden Geçti
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int elmaCount = 0;
            int portakalCount = 0;
            for(int i = 0; i < apples.Count; i++){
                int elmaKonumu = apples[i] + a;
                if(elmaKonumu >= s && elmaKonumu <= t){
                    elmaCount++;
                }
            }
            for(int y = 0; y < oranges.Count; y++){
                int portakalKonumu = oranges[y] + b;
                if(portakalKonumu >= s && portakalKonumu <= t){
                    portakalCount++;
                }
            }
            Console.WriteLine(elmaCount);
            Console.WriteLine(portakalCount);
        }
    #endregion
}

/*
Sam'in evinin yanında bir elma ağacı ve bir portakal ağacı vardır.
Ağaçlar bol miktarda meyve vermektedir.

Verilen bilgilere göre, Sam'in evine kaç elma ve kaç portakal düştüğünü hesaplayınız.

Tanımlar:

- Sam'in evi x ekseni üzerinde bir aralıkta yer almaktadır.
- s: Evin başlangıç noktası
- t: Evin bitiş noktası (dahil)

- Elma ağacı a noktasında bulunmaktadır (evin solunda).
- Portakal ağacı b noktasında bulunmaktadır (evin sağında).

Meyvelerin düşme mantığı:

Bir meyve ağaçtan düştüğünde, ağacın bulunduğu noktadan
x ekseni boyunca belirli bir mesafe kadar ilerleyerek yere düşer.

- Negatif mesafe: Meyve ağacın soluna düşer.
- Pozitif mesafe: Meyve ağacın sağına düşer.

Bir elmanın düştüğü gerçek konum:
    a + elma_mesafesi

Bir portakalın düştüğü gerçek konum:
    b + portakal_mesafesi

Amaç:

Her bir meyvenin düştüğü gerçek konumu hesaplayarak,
[s, t] aralığında (dahil) kalan kaç elma ve kaç portakal olduğunu bulmak.

Fonksiyon Açıklaması:

countApplesAndOranges parametreleri:

s: Sam'in evinin başlangıç noktası
t: Sam'in evinin bitiş noktası
a: Elma ağacının konumu
b: Portakal ağacının konumu
apples: Her elmanın ağaçtan düştüğü mesafeleri içeren dizi
oranges: Her portakalın ağaçtan düştüğü mesafeleri içeren dizi

Fonksiyon, Sam'in evine düşen elma ve portakal sayılarını
ayrı ayrı iki satır halinde ekrana yazdırmalıdır.

Örnek:

Girdi:
7 11
5 15
3 2
-2 2 1
5 -6

Hesaplama:

Elmaların düştüğü noktalar:
5 + (-2) = 3
5 + 2 = 7
5 + 1 = 6

Portakalların düştüğü noktalar:
15 + 5 = 20
15 + (-6) = 9

[7, 11] aralığında:
- 1 elma (7)
- 1 portakal (9)

Çıktı:
1
1
*/
