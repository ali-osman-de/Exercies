class OOP_1_Destructor_Finalizer
{
    static void Main()
    {

        Garbage();
        GC.Collect(); // Bu durumda manuel olarak garbage collector tetikledik. önerilmiyor.
        Console.ReadLine();
    }

    static void Garbage()
    {
        MyClass myClass = new MyClass();
    }

    // Nesnenin yok edilmesini sağlar, selametle :D
    // Bir class sadece bir destructor metottur sadece 1 kere tanımlanır ve overload yapılamaz.
    // Davranışı nesne oluşturulduktan sonra imha aşamasında görev alır.
    // Destructor Yıkıcı metot
    // Ne zaman kullanırız
    // Nesne herhangi bir referans işaretlenmemişse
    // Scope sona ermişse
    // bir daha erişelemeyecekse imha edilir.
    // Garbage Collector ile imha edilir.
    // Pac-Man oyunu gibi

    class MyClass
    {
        //Constructor bu şekildeydi
        public MyClass()
        {
            Console.WriteLine("Nesne üretildi.");
        }

        // Destructor bu şekilde tanımlanır.
        ~MyClass()
        {
            Console.WriteLine("Nesne çöpe gitti.");
        }

    }
}