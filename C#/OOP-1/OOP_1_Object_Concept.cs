class OOP_1_Object_Concept
{
    static void Main(string[] args)
    {
        // Type adı = new Type(); --> prototip nesne oluşturma fonksiyonu
        MyClass myClass = new MyClass();
        MyClass myClass1 = new(); // C#9.0 ile birlikte bu şekilde kullanım yapabiliyoruz. 
        myClass.Fun();
    }

    class MyClass
    {
        public void Fun(){
            Console.WriteLine("Fun");
        }
    }
}