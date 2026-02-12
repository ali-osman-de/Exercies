#region Bir Değerin Primitive Olup Olmadığını Öğrenme
/*
Output =>   False
            True
            True
            True
            True
            True
            True
*/
using System.ComponentModel;

Console.WriteLine(typeof(decimal).IsPrimitive);
    Console.WriteLine(typeof(double).IsPrimitive);
    Console.WriteLine(typeof(int).IsPrimitive);
    Console.WriteLine(typeof(byte).IsPrimitive);
    Console.WriteLine(typeof(char).IsPrimitive);
    Console.WriteLine(typeof(float).IsPrimitive);
    Console.WriteLine(typeof(sbyte).IsPrimitive);
#endregion

#region Değişken Tanımlama
// Type DeğişkenAdı; şeklinde tanımlanır.

/* Ram Yapısı
STACK -> Değer tiplerini ve değerlerini tutulan kısım, metot isimleri de bu kısımda tutulur.
HEAP -> Nesne tutulan kısım

Alan tahsisi run-time zamanında gerçekleşir.
*/

// PascalCase
string Name;
// camelCase genel olarak
short ageYear;
// snake_case
bool married_status;
// @DegiskenAdı dedimiz'de sistemde bir keyword'a denk gelen bir kelime ezmek ve değişken adı olarak kullanmaya yarar.
int @int;

#endregion

#region Değişkene Değer Tanımlama

int num76 = 14;
float floatNumber = 3.14f;
double doubleNumber = 3.14;
decimal decimalNumber = 3.14m;

// Tanımlama yapıldıktan sonra değer atama 
// Değişkene atanan en son değer onun ömrünün sonuna kadar geçerlidir.
num123 = 25;


#endregion

#region Tuple Türü ile Değer Atama

(int a, int b, char c) z = (1, 2, 'a');

/*  Yukardakine alternatif olarak bu şekilde
    z.a = 1;
    z.b = 2;
    z.c = 'a';
*/
#endregion

#region Değişkenlerde Default Değer Atama
// default değerleri öğrenmek için veya atamak için default(degiskenAdı);

bool value = default(bool);
int num = default(int);
string name = default(name);

// veya

bool val1 = default;
int num2 = default;
string name2 = default;

#endregion

#region Atanmış Değişkeni Okuma

int x = 5;
int y;
// x -> 5 y -> 5 değeri gelir sol kısım değişkenin kendisi sağ kısım ise değerini belirtir.
y = x;

#endregion

#region Scope Kavramı { .. }
// Değişken faaliyet alanı
// Kapsamı belirtir
{
    int numberScope = 5;
}
{
    //Bu kısımda yukardaki scopedaki değişken alta scope'a etki edemez ve erişilemez, çünkü yatay düzlem de bulunuyor.
    //numberScope = 10;  
    //Fakat üst scopedan alt scope'a erişim sağlanabilir.

    numberScopeDown = 5;
    {
        numberScopeDown2 = numberScopeDown;
        numberScopeDown2 = 20;
    }
}
#endregion

#region Sabitler
// Süreçte veri değiştirilmez, compiler hata oluşur.
// Static yapıdadır.
// Constant const
// Readonly sadece okunabilir değişken, static değildir.

// (Sabit Tip) (Type) DegiskenAdi = Değeri;   Değişken tanımlanırken değeri verilir.

const double pi = 3.14;

#endregion

#region Değişken Tanımlama

// int a = 5;
// int b = 6;

int ax = 5, bx = 6;

#endregion

#region *** Object Nedir? ***
// ilk türdür diyebiliriz, referans türlü değişkendir.
// Tüm türleri karşılar. Tüm türler objectten türer.
// RAM'de string olarak işaretli ve içerisinde ali var.
string name = "ali";

// RAM'de object türünde ve object'in içerisinde string türünde ali olarak tutuyor.
object name2 = "ali"; // bu işlem boxing işlemi, tam tersi bu obje içerisinden çıkarmaya ise unboxing denir.

Console.WriteLine(name);

    // Cast Operatörü -> Boxing edilmiş veriyi yani obje içerisindeki veriyi elde etmemizi sağlar
    #region Casting Operatörü

    // ()object;
    // kendi türü ney ise o türde yine unboxing edilir!
    Console.WriteLine((string)name2);

    #endregion

#endregion

#region *** Var Keyword? ***
// compiler time
// var tipi hangi tür belirtilmişse ona göre bir şapka takar ve yoluna devam eder. *** BİR TÜR DEĞİLDİR. ***
// çok büyük bir maliyet olmamakla birlikte tür belirterek kullanmak daha performanslıdır.
var usedNumber = 2;
var first_name = "ali";

#endregion

#region *** Dynamic Keyword? ***
// run-time zamanında türe bürünüp o işlem görür.

var varA = 5;
dynamic dynA = 5; // Daha çok run-time'da gelecek veriyi bilmiyorsak gelen veriye bürünmek gibi düşünebiliriz.

#endregion


