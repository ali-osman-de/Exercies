public class Program
{
    internal static void Main(string[] args)
    {
        #region Array - Diziler
            // Aynı türdeki değişkenleri tek bir değerde toplamak amacı ile oluşturulan küme
            // prosedürel programlama koleksiyonların temelidir.
            // referans türlü değerlerdir. yani nesnel ve özünde class
            // Type[] Degisken = new Type[Eleman sayısı];    [] --> indexer operatörü
            int[] numbers = new int[6];
            /*
                Sınırlılık
                    --> Eleman sayısı
            */
            numbers[3] = 10; // Burada 3.index değerine 10 atanır.
            // Dizilerde eleman sayısını aşamayız. run-time error verir.
            numbers[0] = 20;
            numbers[1] = 30;
            numbers[2] = 40;
            numbers[4] = 50;
            numbers[5] = 60;
            // Değer çağırma
            Console.WriteLine(numbers[2]);

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
            short counter = 0;
            while(counter < numbers.Length)
            {
                Console.WriteLine(numbers[counter]);
                counter++;
            }

            #region Varyasyonlar
                //1
                int[] studentNumbers = new int[10];
                //2
                int[] students = {30, 25, 41, 25};
                //3
                string[] names = new string[] {"ali", "osman", "demirkollu"};
                //4
                short[] shortNumbers = new short[3] { 1, 2, 3 }; // Burada eleman sayısı belirttiğin için yazman gerekiyor
                //5
                var varNums = new[] { 1, 2, 3, 4 }; // Burada var zaten şapkacı peki türünü nasıl alıyor süslü parantez içindekilerden yine hepsi tek tür ref etmesi gerekiyor.

            #endregion
        
            #region Array Sınıfı
                // Array == dizi yani 
                //diziler array sınıfından türetilmiştir. yani array bir object.
                // dizi eğer kendi referansında tutuluyorsa indexer kullanılmaz, Arrayde ise kullanılamaz.
                Array arrayNums = new int[3] {1, 2, 3};
                //Değer atama (value, index); void döner yani hiçbir şey dönmez
                arrayNums.SetValue(30, 0);
                //Değer okuma (index); object olarak döner bunu cast edebiliriz.
                arrayNums.GetValue(0);

                #region Metotlar
                    //Clear Dizi elemanlarına default değer atar yani bir nevi sıfırlar. (array, başlangıç, en son nereye kadar)
                    Array.Clear(arrayNums, 0, 1);
                    //Copy (orijinal array, hedef dizi, orijinalde nereye kadar kopyalanacak)
                    var copyNums = new[] {4,3,2};
                    Array.Copy(arrayNums, copyNums, arrayNums.Length);
                    //IndexOf Dizi içersinde bir elemanın var mı yok mu olduğunu sorgular (array, aranacak değer, başlangıç noktası?)
                    int index = Array.IndexOf(arrayNums, 6);
                    //Reverse Dizinin elemanlarını var olan sırasından tersine sıralar
                    Array.Reverse(arrayNums);
                    //Sort Diziyi sıralar küçükten büyüğe doğru
                    Array.Sort(arrayNums);
                #endregion 

                #region Özellikler
                    // IsReadOnly bool döner sadece okunabilir mi?
                    Array ozellikDizisi = new[]{1,2,3,4};
                    Console.WriteLine(ozellikDizisi.IsReadOnly);
                    // IsFixedSize bool döner size genişletilebilir mi? ArrayList sınıfında false döner.
                    Console.WriteLine(ozellikDizisi.IsFixedSize);
                    // Length eleman sayısını söyler
                    Console.WriteLine(ozellikDizisi.Length);
                    // Rank dizinin derecesini söyler, 1 boyutlu, 2 boyutlu vs.
                    Console.WriteLine(ozellikDizisi.Rank);
                #endregion

                #region CreateInstance
                    // tüm diziler arka planda createInstance kullanıyor
                    Array diziInstance = Array.CreateInstance(typeof(int), 10);
                #endregion

                #region Ranges ve Indices
                    
                    // Index index = 3 0,1,2,3 ile başlar baştan sona
                    // Index index = ^3 ise 3,2,1 ile başlar sondan başa

                    int[] rangeNumbers = new int[]{1,2,3,4,5,6,7,8,9,10};
                    Index rangeIndex = ^2; // Burada 0 yazarsan Index was outside the bounds of the array. hatası verecektir. run-time sırasında veriyor compilerda hata yok!
                    Console.WriteLine(rangeNumbers[rangeIndex]);
                

                    //Range
                    Range rangeBetween = 5..8; // (a)..(b) a--> index sırası iken b sıra sırasıdır.  sağ sol boş bırakılırsa .. tüm dize gelir.
                    // Tersine olduğu yer ^5..^8 gibi yine aynı.
                    // ayrıca Index türünde de verilebilir.
                    var range2 = rangeNumbers[rangeBetween];
                    // Console.WriteLine(range2);

                #endregion

            #endregion
        
            #region Çok Boyutlu Diziler
                /*
                    , + 1 dizinin boyutu
                    type[] -> tek boyut
                    type[,] -> iki boyut  x,y boyutlarında
                    type[,,] -> üç boyut  x,y,z boyutlarında
                */
                int[,] cokBoyutluluk = new int[3,4];
                cokBoyutluluk[1,3] = 5;
                cokBoyutluluk[0,1] = 7;
                
                //Farklı Varyasyonda
                int[,] cokBoyutlu = {{1,2,3},    // x = 3, y = 4 excel karesi
                                     {4,5,6}, 
                                     {4,2,1},
                                     {42,32,12}};

                // Değer okuma
                Console.WriteLine(cokBoyutlu[3,2]); // burada düşeydeki 3, yataydaki 2
                Console.WriteLine(cokBoyutlu.Rank);
                Console.WriteLine(cokBoyutlu.Length);
                Console.WriteLine(cokBoyutlu.GetLength(0));
            #endregion
        
            #region Düzensiz Diziler
                // Herbir elemanı farklı bir dizi barındıranlara diyoruz.
                
                //Çok kullanılmamakla birlikte
                //Bu şekilde tanımlanıyor
                int[][] düzensizDiziler = new int[3][];

                düzensizDiziler[0] = new int[3]{2,5,7};
                düzensizDiziler[1] = new int[5]{5,6,7,2,1};
                düzensizDiziler[2] = new int[7]{2,6,7,9,7,4,3};

                for(int i = 0; i < düzensizDiziler.Length; i++)
                {
                    for (int j = 0; j < düzensizDiziler[i].Length; j++)
                    {
                        Console.Write(düzensizDiziler[i][j] + "   -    ");
                    }
                    Console.WriteLine("");
                }

            #endregion
        
        #endregion
    }
}