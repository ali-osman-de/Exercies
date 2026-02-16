class OOP_1_Record
{
    static void Main(string[] args)
    {
        MyClass myClass = new MyClass()
        {
           MyProp = "2"  
        };
        
        MyRecord myRecord = new MyRecord()
        {
            MyProperty2 = "2312"
        };
        MyRecord myRecord1 = myRecord with { MyProperty2 = "a12321"};
        
        // Positional Record
        PositionalRecord positionalRecord = new PositionalRecord("ali", "osman");
        var (n, m) = positionalRecord;

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
        // public int MyProperty { get; set; }
        public string MyProperty2 { get; init; } // amaca uygun bu şekilde kullanım

        // public int Metot()
        // {
        //     return 1;
        // }
    } 

    // Positional Record
    record PositionalRecord(string name, string lastname) // hem constructor hem de decontructor
    {
        // bu yukardaki propertyler compiler-time sırasında init olarak oluşturulacaktır.
    }

}