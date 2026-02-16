class OOP_1_Descontruct
{
    static void Main(string[] args)
    {
        MyClass myClass = new MyClass();
        var (name, age) = myClass;
        
    }


    // imzası  [erişim belirteci] void Desconstruct(out [Type] [değişken adi], out [Type] [değişken adi]){}
    class MyClass
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void Deconstruct(out string name, out int age)
        {
            name = Name;
            age = Age;
        }
    }

}