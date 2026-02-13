public class Program
{
    public static void Main(string[] args)
    {
        #region Akış Kontrol Şemaları
            // Temelde iki tanedir if-else, switch-case
            
            #region Switch-Case
                // kodun akışında bir şarta göre ilerletir, ve bir tane defaultu olur hiçbir şart uymuyorsa default değer döner.
                // sadece eşitlik şartına göre çalışır.
                // kontrol edilen tür kontrol edilen değerler ile aynı tipte olmalı.
                // buradan yola çıkarsak kontrol edilen değer ve caselerdeki değerler sabit veya static değer olup değişmemesi gerekir.

                char alpth = 'B';
                switch (alpth)
                {
                    case 'B':
                        Console.WriteLine("B eşitiymiş");
                        break; // ---> çıkışı sağlar.
                    case 'C':
                        Console.WriteLine("C eşitiymiş");
                        break;
                    default: // ---> opsiyonel koymak zorunda değilsin fakat diğer tüm kurallar geçersizse bir değer dönmez.
                        Console.WriteLine(alpth);
                        break;
                }
                
                #region when keyword
                    short money = 100;
                    switch (money)
                    {
                        case 100 when (3 == 6): // Burada kod yazım sırasında zaten uyarı veriyor, run-time veya compile-time zamanına gitmeden hangi blok çalışak gösteriyor.
                            Console.WriteLine($"Şarta bağlı gelen değer {money}");
                            break;
                        default:
                            Console.WriteLine(money);
                            break;
                    }
                #endregion

                #region goto keyword
                    short gotoKeyword = 10;
                    short counter = 0;
                    switch (gotoKeyword)
                    {
                        case 10:
                            counter++;
                            Console.WriteLine(counter);
                            break;
                        case 7:
                            goto case 10; // goto kullandığımızda işlemi duraklatmıyoruz.
                        default:
                            break;
                    }
                
                #endregion

                #region switch Expressions
                    // Tek farkı yeni ve => (ise operatörü kullanılıyor) 
                    short i = 9;
                    string sonuc = i switch
                    {
                        9 => "3*3 çarpım sonucu",
                        10 => "5*2 çarpım sonucu",
                        11 => "çarpım sonucu yok"
                    };
                    Console.WriteLine(sonuc);

                    #region Expression with when
                        
                        string sonucWhen = i switch
                        {
                            9 when 3 == 2 => "3*3 çarpım sonucu",
                            short x when x == 9 && x % 2 == 1 => "5*2 çarpım sonucu", // önemli kısım burada bir değişken üzerinden kontroller sağlanmalı
                            11 => "çarpım sonucu yok",
                            var x => "hiçbiri"
                        };
                        Console.WriteLine(sonucWhen);

                    #endregion

                #endregion

                #region tuple pattern in switch
                    string tupleName = "aliosman";
                    short tupleAge = 24;

                    string tupleMesaj = (tupleName, tupleAge) switch
                    {
                        ("ali", 23) when (true) => tupleMesaj = "Ali 23 yaşında",
                        ("osman", 24) => tupleMesaj = "Osman 24 yaşında",
                        ("aliosman", 24) when (true) => tupleMesaj = "Ali Osman 24 yaşına",
                        (_,_) => tupleMesaj = "Doğru değer bulamadım"
                    };
                    Console.WriteLine(tupleMesaj);
                    // ikiside aynı yapıya hizmet ediyor.

                    // switch (tupleName, tupleAge)
                    // {
                    //     case ("ali", 23) when (true):
                    //         Console.WriteLine("Ali 23 yaşında");
                    //         break;
                    //     case ("osman", 24):
                    //         Console.WriteLine("Osman 24 yaşında");
                    //         break;
                    //     case ("aliosman", 24):
                    //         Console.WriteLine("Ali Osman 24 yaşına");
                    //         break;
                    //     default:
                    //         Console.WriteLine("Doğru değer bulamadım");
                    //         break;
                    // }
                #endregion



            #endregion

            #region if-else
                //switchden en büyük fark tüm şartları kullanarak bir akış oluşturulabilir.
                // else kullanımı zorun değildir.
                bool ifElseStatus = true;
                string resultStatus;
                if (ifElseStatus && false)
                {
                    resultStatus = "false gelir";
                }
                else if (ifElseStatus ^ true)
                {
                    resultStatus = "false gelir";
                }
                else
                {
                    resultStatus = "zaten trueymuş";
                }
                Console.WriteLine(resultStatus);

                #region Scopesuz if-else

                    // Birden fazla işlem için scope oluşturulması gerekiyor.
                    if (ifElseStatus) Console.WriteLine("True fakat scopesuz!");
                    else Console.WriteLine("Yukardaki çalışacak zaten");

                #endregion

                #region Örnek-Kritik
                    string userName = "aliosman";
                    string password = "12345";

                    string mesaj = (userName, password) switch
                    {
                        ("aliosman","12345") => mesaj = "Giriş başarılı",
                        (_,_) => mesaj = "Giriş hatalı"  
                    };
                    Console.WriteLine(mesaj);
                #endregion

                #region Örnek-Kritik2
                    short kritiknum = Convert.ToInt16(Console.ReadLine());
                    short kritiknum2 = Convert.ToInt16(Console.ReadLine());
                    string kritikOperatör = Console.ReadLine();
                    int kritikResult = kritikOperatör switch
                    {
                        ("+") => kritikResult = kritiknum + kritiknum2,
                        ("-") => kritikResult = kritiknum - kritiknum2,
                        ("/") => kritikResult = kritiknum / kritiknum2,
                        ("*") => kritikResult = kritiknum * kritiknum2,                        
                            _ => kritikResult = 0
                    };
                    Console.WriteLine(kritikResult);

                #endregion


            #endregion
        
            #region Type Pattern
                // x is Type xx
                // is operatörü ile kullanılıyor
                object tpyePatternX = 124;
                if (tpyePatternX is string typePatternValue) Console.WriteLine($"Bu bir int değeriymiş {typePatternValue}");
                // tpyePatternX bir int ise typePatternValue değilse hiç işleme girmez!!

            #endregion
        
            #region Constant Pattern
                // tüm türlerde yapılır. tür kontrolünde yani int, string gibi bu pattern'e girmiyor aşağıdaki gibi bir pattern constant pattern
                object constPattern = "ali";
                if (constPattern is "ali") Console.WriteLine("ali'ye eşitmiş");

            #endregion
        
            #region Var Pattern
                // normal var variable kod yazarken belirleniyor.
                int ab = 123; //object, string, hatırlatma var tüm türlerde bir şapka takıyor ve run-time'da 
                if (ab is var abc) Console.WriteLine(abc);

            #endregion
        
            #region Recursive Pattern
                // tür kontrolü yaptığı için type pattern kapsar.
                // ayrıca null değer kontrolü yaptığı için coğu özellikleri kapsar.
            #endregion

       #endregion
    }
}