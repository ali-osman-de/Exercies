public class Program
{
    internal static void Main(string[] args)
    {
        #region Hata Kontrol Mekanizmaları

            #region Syntax - Sözdizimi Hataları
                // derleme sırasında hata verilir.
                // gelişmiş IDE'lerde derlemeye gitmeden önce hatayı gösterir.
            #endregion

            #region Run-Time Hataları 
                // yazılım ayaktayken uygulamanın patlaması yani takılıp bozulması.
                // son kullanıcıya etkisi yüksektir, yazılımcıların istemediği bir hata boyutudur.
                // hata önemliyse hızlıca müdahale edilmelidir.

                /*
                    En sık hatalar
                    - Veritabanı bağlantısı kopması
                    - Olmayan dataya yazma veya okuma istemi veya üzerinde işlem yapma.                
                */

                #region Try-Catch Yapılanması
                    // TRY-CATCH YAPISI MALİYETLİDİR O YÜZDEN OLASI HATA VERECEK KODLAR SCOPE İÇERİSİNDE YER ALMALIDIR.
                    try
                    {
                        short numberFirst = short.Parse(Console.ReadLine());
                        short numberSecond = short.Parse(Console.ReadLine());
                        Console.WriteLine(numberFirst+numberSecond);
                    }
                    catch (DivideByZeroException divideByZero) when (3 == 3)// A previous catch clause already catches all exceptions of this or of a super type ('Exception')
                    {
                        Console.WriteLine(divideByZero.Message); // Burada en üstte atam duruyor diyor ve ona uyarı veriyor fakat yer değiştirince bu ortadan kalkacaktır.
                    }
                    catch (NullReferenceException nullReferenceException) // A previous catch clause already catches all exceptions of this or of a super type ('Exception')
                    {
                        Console.WriteLine(nullReferenceException.Message); // Burada en üstte atam duruyor diyor ve ona uyarı veriyor fakat yer değiştirince bu ortadan kalkacaktır.
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"HATALI İŞLEM!, {ex.Message}");
                    } finally
                    {
                        // Her iki taraftada oluşan kodlardan sonra çalışmasını istediğimiz durum.
                    }



                #endregion

            #endregion

            #region Mantıksal Hatalar - Bug
                // Bir mantık hatası, bir işlemin yapması gerekenden farklı bir şekilde çalışması, tespiti zor ve tehlikelidir.
            #endregion
        #endregion
    }
}