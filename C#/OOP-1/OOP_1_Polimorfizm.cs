class OOP_1_Polimorfizm
{
    // Çok Biçimlilik
    // Bir sınıfın kendine ait sınıf dışında farklı türdeki sınıflardan da karşılanabilmesine diyoruz.
    // yani bir sınıfın birden farklı sınıfın davranışını sergilemesidir.

    /*
        Statik Polimorfizm -> Bir class içerisinde aynı isimde metotların overload edilmiş hallerine ve aynı zamanda derleme-sırasında hangisini kullanacağımızın kararını alabiliyorsak statik oluyor

        Dinamik Polimorfizm -> Herhangi bir override edilmiş virtual prop veya metotlarımızın run-time sırasında hangisinin çalışacağı kararının verilmesidir.
    
        Eğer C referansını ile B işaretlersek derleyici hatası alırız.
        
        Eğer B referansı ile A'yı işaretlersek run-time hatası alırız.
    */


    static void Main(string[] args)
    {
        C c = new B(); // Derleyici Hatası alırız
        A a = new A();
        B b = (B)a; // Run-time hatası alırız
    }

    class A
    {
        
    }

    class B : A
    {
        
    }
    class C
    {
        
    }

}