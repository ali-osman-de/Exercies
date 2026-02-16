class OOP_1_Static_Constructor
{
    // Bir class'ta ilk tetiklenen constructor değildir.
    // İlk Tetiklenen static constructor --> constructor gelir. Belirli bir durum istinaden!!! 
    // Burada detayı bakcaz
    // Static constructor ile constructor arasında fark vardır.
    // Static constructor ilgili nesne ilk kez üretilirken tetiklenir
    // Constructor ise her nesne üretilirken devreye girer.
    static void Main()
    {
        


    }

    class MyClass
    {
        public MyClass()
        {
            // Her nesne üretimi buradan tetiklenecektir.
        }

        // İmzası static [Class Adı](){}
        // Overload yapılmaz, erişim belileyicisi yoktur, dönüş değeri yok, ismi sınıf ismi ile aynı olmalı
        static MyClass()
        {
            // İlk kez nesne üretimi yapılacaksa tetiklenecektir, bir daha tetiklenmez.
            // İlgili sınıftan bir static yapılanmayı tetiklenirse static constructor yine tetiklenir fakat yine de 1 sınıfta 1 kere tetiklenir.
            
        }
    }
}