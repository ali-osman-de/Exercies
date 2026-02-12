using System.Runtime.Serialization;

public class Program
{
    public static void Main(string[] args)
    {
        #region Operatörler
            // Genellikle iki değer arasında mantıksal veya matematiksel işlem yapalır.
            // Geriye dönüş tipleri önemli

            #region Aritmetik Operatörler
                // +, -, *, /, %  İki sayısal değer üzerinde işlem yaparlar.

                int result = 5 + 7;
                int d1 = 1;
                double d2 = 354;
                double resultDouble = d1 + d2;

                // eğer sayısal veriler farklı ise double + int gibi büyük tür dönüş yapar.

                // *** İSTİSNA *** byte + byte = int bilinçsiz bir tür değişimi yapılır.
                byte b1 = 25;
                byte b2 = 43;
                int resultByte = b1 + b2;

                // Matematik prensiplerinin tamamı programlama da geçerlidir.
            #endregion

            #region Karşılaştırma Operatörleri
                // <, >, <=, >=, ==
                // çıktı olarak bool bir değer döner.

                int i1 = 729;
                int i2 = 231;
                bool karsılastırma = i1 > i2;

            #endregion

            #region Mantıksal Operatörler
                // ve &&, tüm şartlar geçerli ise kod devam eder
                
                bool ve = true;
                bool ve2 = false;
                bool resultVe = ve && ve2;
                Console.WriteLine(resultVe);

                // veya ||, şartlardan 1 tanesi geçerliyse kod devam eder
                
                bool resultVeya = ve || ve2;
                Console.WriteLine(resultVeya);
                /*
                ya da ^, şartlardan 1 tanesi gelmesi şartıyla kod devam eder, 
                    diğer iki durumda da mesela 2 şart kabulse kod devam etmez, 
                    ya da 2 şart kabul edilmemişse kod devam etmez
                */ 
                bool resultYada = ve ^ ve2;
                Console.WriteLine(resultYada);
            #endregion

            #region Arttırma ve Azaltma Operatörleri
                // ++, --

                int arttırma = 5;
                Console.WriteLine(arttırma++); // önce değeri döner daha sonra değeri arttırır 5 işlem sonu değer 6
                Console.WriteLine(++arttırma); // önce değeri arttırır daha sonra değeri döner 7

                Console.WriteLine(arttırma--); // önce değeri döner daha sonra değeri azaltır 7 işlem sonu değer 6
                Console.WriteLine(--arttırma); // önce değeri azaltır daha sonra değeri döner 5

            #endregion

            #region Üzerine Ekleme Operatörleri
            // +=, -=, *=, /=, %=
            byte numberEkleme = 20;
            byte resultEkleme = numberEkleme%=3;

            Console.WriteLine(resultEkleme);

            #endregion

            #region Metinsel İfadelerde Operatörler
                string metin = "ali", metin2 = "osman"; // yanyana birleştirme
                Console.WriteLine(metin + metin2); // Burada aynı işlemi metin += metin2; olarakta yazılabilir

                string metin3 = "demirkollu";
                int metinNum = 5;
                string metin4 = "ali";
                Console.WriteLine(metin3 + metinNum); // Herhangi bir türü metinle toplama yapılırsa string olarak döner.
                Console.WriteLine(metin3 == metin4); // Bu şekilde bir karşılaştırmada bool bir değer dönecektir.
                Console.WriteLine(metin3 != metin4); // Bu şekilde bir karşılaştırmada bool bir değer dönecektir. ! Olumsuzluk(değil) işaret eder.
            #endregion

            #region (int değer == condition ? int : int) Ternary Operatörü
                // Bir değişkene atanacak değer bir şarta bağlı değişkenlik gösterdiğinde kullanılır.
                // dönecek türler aynı olmak zorunda
                
                int ternary = 5;
                int ternary2 = 10;
                bool ter = true;

                Console.WriteLine(ter == true ? ternary : ternary2);
                Console.WriteLine(ter == false ? (ter == false ? true : false) : (ter == false ? false : true)); // birden fazla kullanılmak istediğinde

                #region Example-1
                    string inputReadline = Console.ReadLine();           
                    int input = int.Parse(inputReadline);
                    Console.WriteLine(input < 3 == true ? (input * 5) : ((input > 3 && input < 9) == true ? (input * 3) : 
                                                                        ((input >= 9 && input % 2 == 0) == true ? input * 10 : 
                                                                          input)));

                #endregion

                #region Example-2 
                    string inputExample2 = Console.ReadLine().ToLower();
                    Console.WriteLine(inputExample2 == "rainy" ? "Take an umbrella" : 
                                      (inputExample2== "sunny") ? "Take D vitamins from sun": "The weather may change");
                #endregion

            #endregion

            #region Üye Erişim Operatörü .
                int accessNumber = 5;
                string accessStr = accessNumber.ToString(); // int.member.otherMember gibi gibi
            
            #endregion
        
            #region typeof Operatörü
                // verilen türün/ değerini type türünü getirir.
                // reflection'da kullanılan ileri seviye 
                // metinsel bir operatör
                Type t = typeof(int);
                // t.IsPrimitive();
                // t.IsClass();
                // t.IsValueType();
            #endregion
        
            #region is ve is null ve is not null
                // is Boxing edilmiş bir değerin öz türünü öğrenmek için kullanılır.
                object xIs = true;
                Console.WriteLine(xIs is bool);

                // is null bir değişkenin değerini kontrol edip bool değer döndürür. Sadece null olabilen değişkenlerde kullanılabilir. Değer türlüler NOT NULLABLE Referans türleri NULLABLE  olduğu için sadece Referans tiplerde kullanılır.
                object xIsNull = null;
                object xIsNotNull = 10;
                Console.WriteLine(xIsNull is null);
                Console.WriteLine(xIsNotNull is not null);
            #endregion
        
            #region as Operatörü
                //Cast operatörüne alternatif üretmek için türetilmiş bir operatör
                //Unboxing yaparken türüne uygun bir şekilde çıkarabilirsin eğer türü uygun değilse null dönecektir.
                // object x = 123;   Type y = x as Type
                // Referans türler ile çalışır.

                object x = 12;
                Program y = x as Program;
                Console.WriteLine(y);

            #endregion
        
            #region Nullable Operatörü
                //Değer türlü değişkenler null olamaz normal şartlarda fakat bu operatör sayesinde nullable diyebiliyoruz.
                int? a = null;
                bool? b = null;
                // Type? degiskenAdı = (deger)
                // is null ve is not null özellikleri açılmış olur.

                // Kritik
                object objecNull = 12;
                int? nullable = objecNull as int?;
            #endregion
        
            #region ?? Null Coalescing ve ??= Null Coalescing Assigment
                //Değişken null ise farklı bir değer göndermemizi sağlar
                string? stringa = null;
                Console.WriteLine(stringa ?? "Merhaba");
                // --------------------------------------
                //Değişken null ise hem farklı bir değer gönder hemde o değişkene atama yap.
                Console.WriteLine(stringa ??= "Merhaba");
                Console.WriteLine(stringa);
            #endregion
        
            

        #endregion
    }
}