class OOP_1_Object_Concept
{
    static void Main(string[] args)
    {
        // Type adı = new Type(); --> prototip nesne oluşturma fonksiyonu
        MyClass myClass = new MyClass();
        MyClass myClass1 = new(); // C#9.0 ile birlikte bu şekilde kullanım yapabiliyoruz. 
        myClass.Fun();

        MyClass myClass2 = new MyClass(); // --> referansa HEAP bölgesinde nesne refere edilir
        myClass2.Fun();

        MyClass myClass3 = null; // --> referansa HEAP bölgesinde nesne refere edilmediği için
        myClass3.Fun(); // Burada run-time sırasında NullReferenceError hatası verir.

        // Garbage Collector mekanızması sayesinde referansız nesneler HEAP bölgesinde imha edilir. 
        new MyClass().Fun(); // --> referensı olmadığı için HEAP bölgesinde nesne oluşturulmuştur fakat erişimimiz yoktur.
    }

    class MyClass
    {
        public void Fun(){
            Console.WriteLine("Fun");
        }
    }
}