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

int num = 14;
float floatNumber = 3.14f;
double doubleNumber = 3.14;
decimal decimalNumber = 3.14m;

// Tanımlama yapıldıktan sonra değer atama 
// Değişkene atanan en son değer onun ömrünün sonuna kadar geçerlidir.
num = 25;


#endregion

#region Tuple Türü ile Değer Atama

(int a, int b, char c) z = (1, 2, 'a');

/*  Yukardakine alternatif olarak bu şekilde
    z.a = 1;
    z.b = 2;
    z.c = 'a';
*/
#endregion


