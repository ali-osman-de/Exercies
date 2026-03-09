-- Yorum satırı yapmak için bu şekilde

-- Büyük harf küçük harf duyarlı değildir.

-- Use Komutu Kullanımı
USE <DboName> -- veri tabanı kullanımı yani seçmemizi sağlar.

-- SELECT KOMUTU KULLANIMI

SELECT 3 -- TEK KOLON İÇERİSİNDE GÖNDERECEK

SELECT 'ALİ OSMAN' -- TEK KOLON İÇERİSİNDE GÖNDERECEK

SELECT 'ALİ OSMAN', 24 -- HER BİRİ İÇİN AYRI KOLON İÇERİSİNDE GÖNDERECEK

SELECT * FROM dbo.Customers -- Tüm kolonlar gelir.

SELECT Ad, Soyad FROM dbo.Customers -- Seçili olanlar gelir.

-- ALIAS ATAMA KULLANIMI

SELECT 3 AS NUMARA -- Kolon adı ataması

SELECT 3 NUMARA -- Yukardaki ile aynı çalışma mantığı 

SELECT Ad FirstName, Soyad LastName FROM dbo.Customers -- Bu şekilde de atama yapılabilir.

-- BOŞLUK KARAKTERLİ KOLON ADLANDIRMA

SELECT 1453 [İSTANBULUN FETHİ] -- Eğer boşluk karakterleri varsa aralarda [<Kolon Adı>]

-- AYNI TİPTE KOLONLAR BİRLEŞTİRME

SELECT Ad, Soyad FROM dbo.Customers

SELECT Ad + ' ' + Soyad [Personel Bilgileri] FROM dbo.Customers

-- FARKLI TİPTE KOLONLAR BİRLEŞTİRME

SELECT Ad, Soyad, KayitTarihi FROM dbo.Customers

SELECT Ad + ' ' + Soyad + ' ' + CONVERT(NVARCHAR, KayitTarihi) [İLK KAZANIMLAR] FROM dbo.Customers -- CONVERT operatörü

SELECT Ad + ' ' + Soyad + ' ' + CAST(KayitTarihi AS NVARCHAR) [İLK KAZANIMLAR] FROM dbo.Customers -- CAST operatörü