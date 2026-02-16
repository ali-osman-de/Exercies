class OOP_1_Record
{
    static void Main(string[] args)
    {
        MyClass myClass = new MyClass()
        {
           MyProp = "2"  
        };
        
    }

    class MyClass
    {
        readonly int number;

        public int Number
        {
            get
            {
                return number;
            }
            init
            {
                number = value;
            }
        }

        public string MyProp { get; set; } = "3"; // read ,write yapılır
        public int MyProperty { get; init; } = 3; // readonly, ilk oluşturmada değer atanabilir. get bloğu olmadan çalışmaz
        public int MyProperty2 { get; } // readonly, değer atayamazsın
    }

    // Record class'ın ta kendisi
    // record [Name]{}
    // Class'ın Tüm özelliklerini kullanırız

    record MyRecord
    {
        public int MyProperty { get; set; }
        public string MyProperty2 { get; init; } // amaca uygun bu şekilde kullanım

        public int Metot()
        {
            return 1;
        }
    } 
}