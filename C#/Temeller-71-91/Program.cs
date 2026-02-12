public class Program
{
    static void Main(string[] args)
    {
        string inputFromConsole = "";
        // inputFromConsole =  Console.ReadLine()!;
        Console.WriteLine(inputFromConsole);

        #region Senkron vs Asenkron
            /*
                Senkronda bir gişeye sıra mantığı vardır. önceki kişinin işi bitmeden bir sonrakine geçilmez
                Asenkronda birden fazla gişeye bir sıra var gibi düşünebiliriz. burada ise öncekini beklemeden açık olan gişeye geçebilir.
            
            */
        #endregion

        #region Tür Dönüşümleri
            /*
                Veriyi değiştirmek değil!!! verinin türünü değiştirmektir.
            */

            #region Parse metodu
                //string verileri hedef türe dönüştürmede kullanılır.
                string valueStr = "123";
                int valueNum = int.Parse(valueStr);
                Console.WriteLine(valueNum);
            #endregion
            
            #region Convert metodu
                string valueStr2 = "123";
                int valueNum2 = Convert.ToInt16(valueStr2);
                Console.WriteLine(valueNum2);

                short valueNum3 = 123;
                string ValueStr3 = Convert.ToString(valueNum3);
                Console.WriteLine($"{ValueStr3} short stringe çevrildi");
            #endregion

            #region ToString metodu
                // Bu fonksiyon tüm türlerde vardır ve kullanılır.
                long valueNum4 = 1321456786;
                string valueStr4 = valueNum4.ToString();
                Console.WriteLine($"{valueStr4} long stringe çevrildi");
            #endregion

            #region Bilinçli ve Bilinçsiz Dönüşümler
            
                //int --> float Bilinçsiz Dönüşüm
                int CValue = 5;
                float FValue = CValue;
                Console.WriteLine(FValue);
                //short <-- int Bilinçli Dönüşüm
                int CValue2 = 10;
                short SValue = Convert.ToInt16(CValue2); 
                short SValue2 = (short) CValue2; // veya casting yapılabilir 
                Console.WriteLine(SValue);

                // Veri kaybının kontrolü için Check aracı kullanılabilir.
                // checked run-time sırasında çalışır ve söz konusu veri kaybı varsa exception fırlatır.
                checked
                {
                    
                }
                // Veri kaybı varsa run-time'da hata fırlatmasını engeller 
                // default durumda uncheck olarak gelir.
                unchecked
                {
                    
                }
            #endregion

            #region Ekstra Bool Dönüşümü
                // Mantıksal değerleri sayısal değere convert edebiliriz.
                bool bValue = false;
                int boolValue = Convert.ToInt32(bValue);
                Console.WriteLine(boolValue);

                // 0 değeri false diğer tüm diğer sayı türleri true olarak gelir.
                int sayısalValue = 234;
                bool convertValue = Convert.ToBoolean(sayısalValue);
                Console.WriteLine(convertValue);
            #endregion
        #endregion


    }
}
