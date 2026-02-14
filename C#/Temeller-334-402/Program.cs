using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
    {
        #region ArraySegment ve StringSegment
            //ArraySegment bir orijinal diziden referans almadan o dizi üzerinde işlem yapılmasıdır. Yani ekstra bir ref oluşturmadan işlem yapabilmek.
            int[] diziSegment = {1,2,3,4,5,6};
            ArraySegment<int> segment1 = new ArraySegment<int>(diziSegment); // Burada aslında dizisegmenti referansına ref attık.
            ArraySegment<int> slice = segment1.Slice(0,3);
            ArraySegment<int> segment2 = new ArraySegment<int>(diziSegment, 2, 3); // 2.indexten  3 kadar daha gidecek
            Console.WriteLine(segment2);

            // StringSegment --> Microsoft.Extensions.Primitive paketten yüklenmesi gerekiyor.

            string stringSegment = "Gelecek geçmişten bir parça içerir!";
            // stringSegment segment3 = new(stringSegment, 3, 5); 
        #endregion
        
        #region StringBuilder Sınıfı
            // performanslı string segment alg. kullanarak textleri birleştirip döndürür.
            string name = "ali";
            string lname = "osman";

            StringBuilder builder = new StringBuilder();
            builder.Append(name);
            builder.Append(lname);

            Console.WriteLine(builder.ToString());
        #endregion
    
        #region Span, ReadOnlySpan ve Memory, ReadOnlyMemory
            // Span vs arraysegment,  span heap veya stack kısmı fark etmeksizin reference edebilir.
            // segmentlere kıyasla daha fazla tür temsil edilir.
            // Span struct bir sınıftır.
            int[] spanArr = {1,2,3,4,5,6};
            // Span<int> spanNew = new Span<int>(spanArr,2,0);
            // spanNew.Slice(1,0);
            spanArr.AsSpan(); // readonly span
        #endregion

        #region Regular Expressions Regex
            //metinler içerisinde koşulları sağlayan yerleri elde etmek
            // ^ Operatörü --> Satır başında herhangi bir ifade ile başlanacaksa bu kullanılır.
            //^9: 9adsafas --> uygun ifade
            string ops = "9sadfdasdsadas";
            Regex regex = new Regex("^9");
            Match match = regex.Match(ops);
            Console.WriteLine(match.Success);

            //\ Belirli karakterlerin içermesini istiyorsak onları belirtiyoruz.
            string ops1 = "93ali1osman";
            Regex regex1 = new Regex(@"^9\d\S");
            Match match1 = regex1.Match(ops1);
            Console.WriteLine(match1.Success);

            // + Operatörü
            string ops2 = "93ali1osman";
            Regex regex2 = new Regex(@"^9\d+\S"); // + mantığı 9 ile başlayan arada sayısal ifadeler olabilir ve son karakter boşluk olmayan
            Match match2 = regex2.Match(ops2);
            Console.WriteLine(match2.Success);         

            // | veya Operatörü
            // baş harfi a veya b veya c olan a|b|c
            string ops3 = "aliosman";
            Regex regex3 = new Regex(@"a|b|c|A|B|C"); // büyük küçük harf duyarlı
            Match match3 = regex3.Match(ops3);
            Console.WriteLine(match3.Success);  
            
            //Diğer tüm operatörler araştır!
        #endregion
    
        #region Koleksiyonlar
            //Dizi Tanımlama Hatırlatma
            int[] ints = new int[3];
            int[] ints1 = new [] {1,2,3,4};
            // int[] ints2 = {1,2,3,4};

            //Koleksiyon Tanımlama
            ArrayList arrayList = new ArrayList {1,2,3,4,5,6,7,8,9,10};
            ArrayList arrayList1 = new ArrayList {"ali", 1,23,456,"caas"}; // her bir değer object olarak tutuluyor!
            //Değer Atama & Okuma
            arrayList.Add(11); // en sona ekler.
            
            arrayList.AddRange(new ArrayList {12,13});

            int arrSum = 0;
            int? arrSum2 = 0;
            //Boxing ve Unboxing
            for (int i = 0; i< arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
                arrSum += (int)arrayList[i];
                arrSum2 += arrayList[i] as int?;
            }
            Console.WriteLine($"Cast edilen: {arrSum} - As operatörlü nullable object yaklaşımı: {arrSum2}");
        #endregion
    
        #region Iterations
            // her tahminin altında iterasyon vardır.
            // dizi veya koleksiyonlar üzerinde çalışırken 

            // foreach bir iterasyondur yani bir veri kümesi gerekmektedir.
            int[] ints2 = {1,2,3,4};

            foreach (int item in ints2)
            {
                Console.WriteLine(item);
            }
            
        #endregion

        #region Hazır Fonksiyonlar
            #region Math
                // Abs --> mutlak değer işlemi
                Math.Abs(1);
                // Ceilling --> yukarı yuvarlama işlemi 3 yuvarlar
                Math.Ceiling(2.14);
                // Floor --> aşağı yukarı yuvarlama işlemi 2 yuvarlar
                Math.Floor(2.14);
                // Round --> en yakın olan tam sayıya yuvarlama işlemi 2.00 - 2.49 aşağı 2.50 - 2.59 yukarı
                Math.Round(2.5);
                // Pow --> bir sayının bir üs alınması 
                Math.Pow(2,4);
                // Sqrt --> sayının karekökünü alır.
                Math.Sqrt(4);
                // Truncate --> ondalıklı değerlerin tam değer kısmını almak için
                Math.Truncate(2.04); 
            #endregion

            #region Datetime
                // Direkt araştır!
            #endregion

            #region Random
                Random random = new Random();
                Console.WriteLine(random.Next());
                Console.WriteLine(random.Next(100)); // 0 - 100
                Console.WriteLine(random.Next(10000)); // 0 - 10000

                Console.WriteLine(random.NextDouble()); // 0 - 1 arasında
            #endregion

        #endregion

        #region Metot
            // Functions --> Metot
            // Fiili olarak yapılan tüm operasyonlar birer metotdur.
            
            #region Metot Imzası
                // [access modifier] [geri dönüş değeri] [Metot adı](){}
                // access modifier oluşturulmuş bir yapının başka bir classtan erişilmesi olayıdır. 
                Console.WriteLine(Metot3(3,4));
                Optional();
            #endregion

            // Class --> herhangi bir gerçek dünyadaki olgu
            // Nesne --> Class'tan üretilen bir değer veya veri
            // Referans --> Class'tan üretilen değeri kullanmamızı sağlanyan yapı

            Matematik matematik = new Matematik();
            Console.WriteLine(matematik.Topla(4,5));

            // Local funclarda erişim belirleyicisi olmadan hazırlanır
            int Topla(int c, int d)
            {
                return c+d;
            }

            Console.WriteLine(Topla(10,1));

            //Recursive Fonk --> kendi içerisinde kendisini çağıran fonksiyon
            void Recursive()
            {
                Console.WriteLine("1");
                Recursive();
                Console.WriteLine("2");
            }

            // Recursive();

            // Ref Keywordü
            int refa = 5;
            ref int refb = ref refa;
            Console.WriteLine(refa);
            refa *=5;
            Console.WriteLine(refb);

            ref int RefTopla(ref int y)
            {
                return ref y;
            }


            // Out Keyword
            // out parametreler barındırılıyor kendi içerisinde değer atanmalı aksi takdirde compiler error verir.

            int _b = 0;
            string _d = "";
            OutKeyword(out _b, 10, out _d);

            int OutKeyword(out int b, int c, out string d)
            {
                b= 1;
                d = "iki";
                return 0;
            }

        #endregion
    
    }

    class Matematik
    {
        public int Topla(int a, int b)
        {
            return a+b;
        }
        // In parameter --> alınan değerin değişmemesini sağlar ve readonly olur
        public int Değişmez(in int c)
        {
            return c;
        }
        // Overloading Method
        // Birden aynı isimde method oluşturmada overload fonksiyonları diyoruz
        // imzaları farklı olmalıdır
        // isimleri aynı olmalı
        // parametre türleri veya sayısı farklı olmalı
        public int Değişmez(in int c, in int d)
        {
            return c+d;
        }
    }

    // Geriye değer dönmüyor, parametre almıyor
    public void Metot()
    {
        Console.WriteLine("Geriye değer dönmüyor, parametre almıyor");
    }

    //Geriye değer döndürmeyen, parametre alan
    private void Metot1(int a = 5, int b =7)
    {
        Console.WriteLine(a+b);
    }

    //Geriye değer döndüren, parametre almıyor
    private int Metot2()
    {
        return 5;
    }

    //Geriye değer döndüren, parametre alan
    static int Metot3(int a, int b)
    {
        return a+b;
    }

    // Optional Parameters
    static void Optional(int a = 1, int b = 1)
    {
        
    }
}