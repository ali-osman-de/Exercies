class OOP_1_Interface
{
    static void Main(string[] args)
    {
        
    }
    // Nesnelere birer arayüz sağlaması ile ilgili nesnede hangi memberlar gerekiyorsa ona göre çalışan bir yapıdır.
    // Birebir abstraction davranışı sergiler.

    // Gelenek olarak interface adı IAdım gibi
    // Interfaceler classlar nerede tanımlanırsa aynı yerlerde tanımlanabilir.
    interface IMyInterface
    {
        // imza örneği metot veya propertyler olabilir, erişim belirteçleri yoktur.
        //  Dönüş değeri Değişken Adı();

        public int MyProperty { get; set; }
        public void MyMetot();
    }

    interface IMyInterface2
    {
        public int MultipleImp { get; set; }
        public void MyMultiImp();      
    }

    class MyClass : IMyInterface
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MyMetot()
        {
            throw new NotImplementedException();
        }
    }

    class MyClass2 : IMyInterface, IMyInterface2
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MultipleImp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MyMetot()
        {
            throw new NotImplementedException();
        }

        public void MyMultiImp()
        {
            throw new NotImplementedException();
        }
    }

    // Class : Interface --> implementation
    // Interface : Interface --> Inheritance
    // Class : Class --> Inheritance
    // Abstract Class : Abstract Class --> Inheritence
    // Class : Abstract Class --> implementation (Eğer memberlar abstract ile işaretli ise)

    // Ayrıca bir sınıf hem bir sınıftan kalıtım hemde bir interfaceden implementation yapılabilir.

    class MyClass3 : MyClass, IMyInterface2 // Birden fazla interface eklenebilir.    öncelikle class, interface1, interface2, ...
    {
        public int MultipleImp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MyMultiImp()
        {
            throw new NotImplementedException();
        }
    }

} 