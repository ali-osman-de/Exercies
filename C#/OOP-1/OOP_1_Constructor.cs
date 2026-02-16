class Constructor
{
    //Constructor bir fonksiyondur.
    // new Type(); --> nesne ayağa kaldırılırken ilk yapılan ayardır.
    // yapıcı metot
    // new ile nesne oluştuktan sonra constructor çalışır.
    static void Main(string[] args)
    {
        MyClass myClass = new(5);
        MyClass myClass1 = new MyClass(120);
    }

    class MyClass
    {
        int a;
        int b;
        int c;

        // metotun adı sınıf adı ile aynı ve dönüş değeri yok ise Constructor metottur.
        // Her classta olmak zorun değil
        // normal bir class üyesi class adı ile aynı olamaz
        // eğer sınıfın içinde constructor tanımlamamış olsak dahi default constructor vardır, yazarsan ezmiş olursun.
        // parametreli constructor yapabiliriz
        // birden fazla constructor tanımlanabilir
        // yani overload method özelliği kullanabiliyoruz.
        // aynı isimde iki metot tanımlanamaz fakat parametre farklı aynı isimde metotlar tanımlanabilir.
        // constructor metot eğer private olursa nesne oluşturulamaz. Singleton Design Pattern incelenebilir.
        public MyClass()
        {
            a= 5;
            b= 10;
            c= 15;
        }

        public MyClass(int a)
        {
            this.a= 5;
            b= 10;
            c= 15;
        }

        // her iki constructorıda kullanmak istediğimiz
        // this() keywordü kullanıyoruz
        public MyClass(int a, int b) : this(a) // burada sırasıyla ilk önce a daha sonra ana ctor daha sonra bunu işleyecek
        {                                      // a vermeseydik ilk önce ana ctor daha sonra bunu işleyecekti
            this.a = a;                        // repeation yoktur yani 1 kere işlenen ctor bir dahakine tekrar çalışmaz.
            this.b = b;
            c = 12;
        }
    }
}