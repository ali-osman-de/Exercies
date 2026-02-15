namespace OOP_Dersleri
{
    public class OOP_1_Class
    {
        static void Main(string[] args)
        {

            

        }
    }  

    // Class içerisinde class oluşturma (Nested Type)
    // aynı namespace içerisindeki classlar birbirine direkt erişebilirken
    class NestedClass
    {
        
    };

    //Referans alma/noktası alma
    //Şu anda bir herhangi bir nesne ataması yapılmamış hali
    NesneModeli nesneModeli;
}

// Classlar Namespace dışında da oluşturulabilir
// farklı namespacedeki classlar ise namespace üzerinden birbirlerine erişir.  örnek:  namespace.x
// aşağıdaki gibi namespace dışında ise direkt erişim sağlarız.
class NameSpaceClass
{
    
} 

// Sınıf ile Nesne modeli nasıl oluşturulur? 
class NesneModeli
{
    // Field, Metot oluşturulabilir.
    // Değişkenler eğer bir class içerisinde ise onlara Field diyoruz.
    int a;
    int b;

    public int Topla()
    {
        return a+b;
    }
}
