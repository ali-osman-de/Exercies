public class Program
{
    static void Main(string[] args)
    {
        // Referans türlü olup keyword ile karşılanabilen tek türdür.
        #region String Türü

            #region Null ve Empty Durum Farkları
                
                // Null demek alan tahsisi bile yapılmamıştır.
                string? a = null;
                // Empty ise alan tahsisi yapılmış fakat içi boştur, değişken değeri yoktur.
                // Tüm değerlere empty atanabilir.
                // Default değerlerde birer empty olarak nitelendirilir.
                // Null ile bir işlemde run-time error verir.

                int num = 0;
                string b = string.Empty;

                #region IsNullOrEmpty 
                // Kontrol amaçlı null veya empty mi? özellikle auth işlemlerinde
                if (!string.IsNullOrEmpty(b))
                {
                    Console.WriteLine("Bu ekrana yazılmaz! çünkü b bir empty");
                }
                #endregion

                #region IsNullOrWhiteSpace
                    // null, empty veya boşluksa true gelir 
                    if (!string.IsNullOrWhiteSpace(b))
                    {
                        Console.WriteLine("Bu ekrana yazılmaz çünkü b bir empty");
                    }
                #endregion
            #endregion

            #region String - Char Dizisi
                
            #endregion      
            
                 
        #endregion
    }
}