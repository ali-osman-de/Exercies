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
                //String ifadeler char dizisi olarak tutulur.
                //referans türlü nesnedir ve HEAP alanında tutulur.
                string song = "şarkılar sokaklara ait";
                Console.WriteLine(song[0]);
                Console.WriteLine(song.Length);

                // Array arrayString = song; Bu şekilde bir tanımlama yapılamaz.

                for (int ct = 0; ct < song.Length; ct++)
                {
                    Console.Write(song[ct] + " - ");
                }

            #endregion      

            #region String Operatörler
                // Tüm değerlerle + operatörü kullanılır, toplanan değer eğer string dışında ise  string + object olarak davranış sergileyecek. 
                string nameOps = "ali";
                string lastNameOps= "osman";
                int numberOps = 1;
                Console.WriteLine(nameOps + lastNameOps + numberOps); // string + string + object
                
            #endregion
        
            #region String Formatlama
                string customer = "ali";
                string lCustomer = "demirkollu";
                bool marriedStatus = false;
                // Formatlamalarda kullanılmaz, performans ve maliyet
                Console.WriteLine("name: " + customer + "; " +"last name: " + lCustomer + "; " + "medeni hal: " + (marriedStatus ? "Evli" : "Bekar"));
                // String Format ("{0} {1}", 0, 1)
                Console.WriteLine(string.Format("name: {0}; last name: {1}; medeni hal: {2}", customer, lCustomer, marriedStatus ? "Evli" : "Bekar"));
                // Ternary operatörü parantez içinde kullanılması şart burada!!
                // String interpolation
                // {{ burada normal strin çıktısı olur }} --> output: { burada normal strin çıktısı olur }
                Console.WriteLine($"name: {customer}; last name: {lCustomer}; medeni hal: {(marriedStatus ? "Evli" : "Bekar")}");

                // Escape (Kaçış) Karakterler  \,\n, kendisinden sonra gelen karakterin bir metinsel değer olduğunu belirtir.
                Console.WriteLine($"\"name\": {customer}; \n\"last name\": {lCustomer}; \n\"medeni hal\": \\{(marriedStatus ? "Evli" : "Bekar")}"); 
            
                #region @ Verbatim Strings
                    // Sistemdeki keywordları değiken olarak kullanmamızı sağlar.
                    int @void = 5;
                    @void = 10;
                    Console.WriteLine(@void);

                    // Kaçış karakterlerinde kullanılır.
                    string VerbatimSt = @"hava çok ""çok güzel""";
                    Console.WriteLine(VerbatimSt);

                    //Satırlı metinler
                    string VerSatırlar = @"

                            Hava çoook güzel!
                    
                    ";
                    Console.WriteLine(VerSatırlar);

                    //String interpolation ile kullanılıyorsa
                    string mixSatırlar = @$"
                        adı: {customer},
                        soyadı: {lCustomer},
                        medeni: {(marriedStatus ? "Evli" : "Bekar")}";
                    Console.WriteLine(mixSatırlar);
                
                #endregion
            
                
            
            #endregion

            #region String Fonksiyonları
                // Contains içeriyor mu? Küçük büyük duyarlı
                string Func = "Unutamazsın Şarkısı benden sana";
                bool bendenİçeriyorMu = Func.Contains("benden"); // bool döner
                Console.WriteLine(bendenİçeriyorMu);

                // StartWith Küçük büyük duyarlı
                Console.WriteLine(Func.StartsWith("Unut")); // bool döner
                
                // EndWith Küçük büyük duyarlı
                Console.WriteLine(Func.EndsWith("ana")); // bool döner
                
                //Equals bool döner
                Console.WriteLine(Func.Equals("ali"));

                //Compare int döner
                // 0, 1, -1, 
                // 0 --> her iki değer eşit
                // 1 --> soldaki sağdakinden büyükse
                // -1 --> soldaki sağdakinden küçükse
                Console.WriteLine(string.Compare(Func, "Unutamazsın"));
                Console.WriteLine(Func.CompareTo("Şarkısı"));

                // IndexOf bir stringin içersinde var mı yok mu int döndürür
                // index'i döndürür.
                Console.WriteLine(Func.IndexOf("U"));

                // Insert metinsel ifadeye değer dahil edilmesi
                Console.WriteLine(Func.Insert(31, " bir şarkı")); // orijinal bir metin ile eklenmiş referansları farklıdır.
                // Yani orijinal veri ile eklenen arasında fark var.

                //Remove
                //metinde değer aralığını siler
                // orijinal bir metin ile eklenmiş referansları farklıdır.
                Console.WriteLine(Func.Remove(5)); // sadece ilk 5 karakter alır sornasını siler
                Console.WriteLine(Func.Remove(1,10)); // değer aralığını siler

                //Replace
                //metinde ifade veya karakterlerin yeri değiştirir.
                Console.WriteLine(Func.Replace('a', 'b'));
                Console.WriteLine(Func.Replace("sı", "sa"));

                //Split
                //string değeri parçalamamızı sağlar.
                //metinsel ifadeye göre parçalama yapar
                string[] arrSplit = Func.Split(" "); // her boşluk gördüğü yerde parçalar
                // Func.Split(" ", "a"); // hem a hem de boşluk gördüğü yerde parçalar
                for(int splitA = 0; splitA < arrSplit.Length; splitA++)
                {
                    Console.WriteLine(arrSplit[splitA]);
                }

                //Substring
                //en önemlisi 
                // metinin belirli bir aralığını elde etmemizi sağlar
                Console.WriteLine(Func.Substring(5)); //5den sonra tümünü getir.
                Console.WriteLine(Func.Substring(5, 20)); // 5den başla 20 karakter getir.

                //ToLower tümünü küçük
                Console.WriteLine(Func.ToLower());

                //ToUpper tümünü büyük
                Console.WriteLine(Func.ToUpper());

                //Trim baştan ve sondan boşlukları yok eder
                Console.WriteLine(Func.Trim());

                //TrimEnd sondan boşlukları siler
                Console.WriteLine(Func.TrimEnd());

                //TrimStart baştan boşlukları siler
                Console.WriteLine(Func.TrimStart());
            #endregion       

            #region Kritikler
                
                string nameK = "ali osman demirkollu";
                Console.WriteLine($"{nameK[2]} {nameK[15]}"); // 1.çözüm
                //2.çzöüm
                Console.WriteLine(nameK.Substring(2,1));
                Console.WriteLine(nameK.Substring(15,1));

                //3.çözüm
                string aralik = nameK[2..^4];
                Console.WriteLine(aralik[0]);
                Console.WriteLine(aralik[aralik.Length - 1]);


            #endregion

        #endregion
    }
}