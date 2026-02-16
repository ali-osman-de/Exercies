class GradingStudents{
    
    #region Tüm Caselerden Geçti
        public static List<int> gradingStudents(List<int> grades)
        {
            for(int i = 0; i < grades.Count; i++){
                var sonrakiKat = (grades[i] / 5 + 1) *5;
                if(sonrakiKat - grades[i] < 3){
                    if(grades[i] >= 38){
                        grades[i] = sonrakiKat;
                    }
                }
                
            }
            
            return grades;
        }


    #endregion
}

/*
HackerLand Üniversitesi aşağıdaki notlandırma politikasını uygulamaktadır:

- Her öğrenciye 0 ile 100 (dahil) arasında bir not verilir.
- 40'ın altındaki her not başarısız sayılır.

Üniversitede profesör olan Sam, öğrencilerin notlarını şu kurallara göre yuvarlamayı sevmektedir:

1) Eğer not ile bir sonraki 5'in katı arasındaki fark 3'ten küçükse,
   not bir sonraki 5'in katına yuvarlanır.

2) Eğer not 38'den küçükse, yuvarlama yapılmaz.
   Çünkü yuvarlansa bile sonuç yine başarısız olacaktır.

Örnekler:

- 84 → 85'e yuvarlanır (85 - 84 = 1, bu değer 3'ten küçüktür)
- 29 → Yuvarlanmaz (sonuç yine 40'ın altında kalacaktır)
- 57 → Yuvarlanmaz (60 - 57 = 3, bu değer 3 veya daha büyüktür)

Görev:

Sam'in öğrencilerinin başlangıç notları verildiğinde,
notları yukarıdaki kurallara göre otomatik olarak yuvarlayan
bir fonksiyon yazınız.

Fonksiyon Açıklaması:

grades: Yuvarlama öncesi notları içeren liste
Dönüş değeri: Yuvarlama sonrası notları içeren liste

Girdi Formatı:

- İlk satırda öğrenci sayısı (n) bulunur.
- Sonraki n satırın her birinde bir öğrencinin notu yer alır.

Örnek Girdi:
4
73
67
38
33

Örnek Çıktı:
75
67
40
33

Açıklama:

- 73 → Bir sonraki 5'in katı 75'tir. Fark 2 olduğu için yuvarlanır.
- 67 → Bir sonraki 5'in katı 70'tir. Fark 3 olduğu için yuvarlanmaz.
- 38 → Bir sonraki 5'in katı 40'tır. Fark 2 olduğu için yuvarlanır.
- 33 → 38'den küçük olduğu için yuvarlanmaz.
*/
