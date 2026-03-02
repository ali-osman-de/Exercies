class OOP_1_Abstract_Class
{
    // Tercihen kullanılan yapılardandır.
    static void Main(string[] args)
    {
        // MyClass myClass;

        // new MyAbstractClass(); Nesne üretilebilir bir tür değildir.
        MyClass2 myClass2 = new MyClass2();
        MyAbstractClass myAbstractClass = new MyClass2();
    }


    abstract class MyAbstractClass
    {
        // Nesne üretilebilir bir tür değildir.
        public MyAbstractClass()
        {
            
        }
        // Normal yapıları barındırabilir.
        string name = "ali";
        public int MyProperty { get; set; }
        public int ReturnNumber()
        {
            return 0;
        }

        // Ek olarak member imzaları tanımlanabilir.
        // zorun olarak public ile işaretli olmalıdır.
        abstract public void Sum(int a, int b);
    }

    class MyClass2 : MyAbstractClass
    {
        // burada implementasyondan alınanlar abstract classtan geldiği için override edilmek zorunda
        public override void Sum(int a, int b)
        {
            Console.WriteLine($"{a} + {b}");
        }
    }

    // Ayrıca bir abstract class ile başka bir diğer abstract class kalıtım verebilir.
    // Bunu asla bir implemantasyon demiyoruz.

}