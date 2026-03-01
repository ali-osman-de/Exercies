class OOP_1_Partial
{
    static void Main(string[] args)
    {
        
    }
    // Partial metot örneği
    class MyClass
    {
        public MyClass()
        {
            this.X();
            this.Y();
        }
        partial void X(); // Gövdesi tanımlanmazsa asla derlenmez
        partial void Y(); // Gövdesi tanımlanmazsa asla derlenmez

        partial void Y()
        {
            Console.WriteLine("Y partial");
        }
    }
    // partial class örneği

    partial class MyClass2
    {
        public int MyProperty { get; set; }
    }

    partial class MyClass2
    {
        public MyClass2()
        {
            MyProperty = int.Abs(12);
        }
    }
    
}