public class Program
{
    internal static async Task Main(string[] args)
    {
        #region Döngüler

            #region For Döngüsü
                // for(başlangıç değer; şart; başlangıç değeri azaltma, arttırma)
                // for (int a = 1; a <= 9; a++)
                //for (int a = 10; a >= 1; a--)
                for(int i = 1; i <=10 ; i++)
                {
                    Console.WriteLine(i);
                } 

                int totalSayi = 0;
                for(int sayi = 1; sayi <= 40; sayi++)
                {
                    totalSayi += sayi % 2 == 0 ? sayi : 0;
                }
                Console.WriteLine(totalSayi);
                
                #region Faktöriyel Kritik
                    int inputUser = Convert.ToInt32(Console.ReadLine());
                    int inputResult = 1;
                    for(; inputUser > 0; ) // bu şekilde de yapılabilmektedir. illaki başlangıç durumu for içine  yazılmasına gerek yok. Varyasyon 1 
                    { // Aynı şekilde şartı da farklı bir şekilde tanımlayabiliriz. Varyasyon 3
                        inputResult *= inputUser;
                        inputUser--; // bu şekilde arttırma azalmada kullanılabilir. Varyasyon 2
                    }
                    Console.WriteLine(inputResult);
                #endregion

                for (int i = 0, i2 = 0; i < 12 && i2 < 10; i++, i2++)
                {
                    // Bu şekilde de tanımlama mevcut!!!
                }


            #endregion

            #region While Döngüsü
                // Bir bağlantıyı 15dk ile açmak ve bunu kullanmayı sağlanmak ardından bağlantıyı bitirmek için ideal.
                int numWhile = 0;
                while (numWhile <= 10) // Şarta bağlı bir döngüdür.
                {
                    Console.WriteLine(numWhile);
                    numWhile++;
                }

                #region Faktöriyel
                    int inputWhile = int.Parse(Console.ReadLine());
                    int whileResult = 1;
                    while (inputWhile > 0)
                    {
                        whileResult *= inputWhile--;
                    }
                    Console.WriteLine(whileResult);

                    // int whileSecond = DateTime.Now.Second;
                    // while(true)
                    // {
                    //     if (whileSecond % 5 == 0) Console.WriteLine(DateTime.Now);
                    // }
                #endregion
            #endregion

            #region Do-While Döngüsü
                // Tek fark şarta bakılmaksızın do 1 kere garanti çalışır.
                do
                {
                    Console.WriteLine("selam");
                } while (false);
            #endregion
        
            // For-each bir döngü değildir bir iteration olduğu için onu iterasyonlarda inceledik.
        
        #endregion
    }
}