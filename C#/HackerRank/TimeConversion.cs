public class TimeConversion
{
    #region Tüm Caselerden Geçti
    public static string timeConversion(string s)
    {
        
        // 1. durum AM olması yani 00.00.00 - 11.59.59 --> AM ise 12 eklicez. 12 ise -12 diğerlerine dokunmadan devam.
        // 2. durum PM olması yani 12.00.00 - 11.59.59 --> PM ise 12 ise dokunma 01 + 12 eklicez.
        
        /*
            2.Durum Ele alalım.
        */
        
        string correctionVal = s.Remove(8,2);
        string index = s[0..2];
        
        if(s[8..10] == "PM"){
            if(index == "12"){
                return correctionVal;
            };
            int clock = int.Parse(index) + 12;
            return s.Replace(s[0..2], clock.ToString()).Remove(8,2);
        };
        
        /*
            1.Durum Ele alalım.
        */
        
        if(index == "12" && s[8..10] == "AM"){
            int clock = int.Parse(index) - 12; // Buraya dikkat 0 dönüyor saat formatın 00 bekleniyor
            return s.Replace(s[0..2], clock.ToString() + "0").Remove(8,2);
        }
        
        return s.Remove(8,2);
    } 
    #endregion    
}


/*
    PROBLEM:
    12 saatlik AM/PM formatındaki bir zamanı,
    24 saatlik (military time) formata çeviriniz.

    NOTLAR:
    - 12:00:00AM  -> 00:00:00  (Gece yarısı)
    - 12:00:00PM  -> 12:00:00  (Öğlen)

    ÖRNEK:
    Input  : 07:05:45PM
    Output : 19:05:45

    Input  : 12:01:00AM
    Output : 00:01:00

    Input  : 12:01:00PM
    Output : 12:01:00

    FONKSİYON AÇIKLAMASI:
    timeConversion fonksiyonunu tamamlayınız.

    Parametre:
        string s -> 12 saatlik formatta zaman (örn: "07:05:45PM")

    Dönüş Değeri:
        string -> 24 saatlik formatta zaman (örn: "19:05:45")

    Girdi Formatı:
        - Tek bir string değer
        - Format: "hh:mm:ssAM" veya "hh:mm:ssPM"

    Kısıt:
        - Tüm girişler geçerli zaman değeridir.
*/
