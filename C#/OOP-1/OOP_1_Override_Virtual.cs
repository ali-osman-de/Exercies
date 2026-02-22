class OOP_1_Override_Virtual
{
    static void Main(string[] args)
    {
        // Virtual yapılandırmalar run-time sırasında hangi sınıftan türediği bildirilir.
        // Virtual --> yapılar metot veya property olabilir
        // Name-hiden farklı olarak virtual yapılar bildirilme esasına dayalı iken name-hiden olayında yani aynı isimde farklı prop veya metotların başka sınıf aynı isimde tanımlanması ile birlikte birlikte artık o sınıftaki isimle kullanılmasıdır.
        // Virtual metotlar veya proplar geç bağlanma yani LATE BINDING ile bağlanır.

        MyClass myClass = new MyClass();
        MyClass2 myClass2 = new MyClass2();
        myClass.Topla(1,2);
        myClass2.Topla(1,2);
    }
    class MyClass
    {
        public virtual int Topla(int a, int b)
        {
            return a+b;
        }
    }

    class MyClass2 : MyClass
    {
        public override int Topla(int a, int b)
        {
            return a-b;
        }
    }
    
    class MyClass3 : MyClass
    {
        public override int Topla(int a, int b)
        {
            return a % 2 + b;
        }
    }
}