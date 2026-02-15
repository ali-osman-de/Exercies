class OOP_1_Class_Members
{
    static void Main(string[] args)
    {
        
        FieldClass fieldClass = new FileAccess(); 
        fieldClass.Name = "Ali";  // Set bloğu tetiklenir propertyler bu şekilde
        fieldClass.Topla(); // metotlar ise bu şekilde
        fieldClass["Ali Osman Demirkollu"];

        Console.WriteLine(fieldClass.Name); // Get bloğu tetiklenir.
        
    }


    class FieldClass
    {
        // class içerisinde fieldlara erişim sağlamak için herbirini field olarak işaretlenmeli
        // fieldlarda otomatik default değer atama vardır
        string name;
        string lastName;

        // Full Property
        // [Erişim belirleyicisi][Türü][Adı] { get{} set{} } 
        // Sadece Get tanımlanırsa readonly, Sadece set tanımlanırsa writeonly property tanımlanmış olur
        // Aşağıdaki olaya biz Kapsülleme/Sarmalama/Encapsülation denir.
        public string Name
        {
            get
            {
                return name+"a";
                // Değer buradan döndürülür.
            }
            set
            {
                name = value;
            }
        }

        // Prop Property
        // Direkt olarak hiçbir müdahale yapılmadan atama ve okuma işlemleri yapılıyorsa bu daha hızlı yazma işlevi görecektir.
        // Arka planda aslında bir field tanımlıyor ve onun üzerinden işlemler yapılıyor.
        // Kendi field'ını kullanıyorsan prop kullanma, prop kullanıyorsan field kullanma.
        public string LastName { get; set; } // kısa yöntemi prop yazıp gelen tamamlayıcı kullanılabilir
        // Auto Property Iniliazer
        // Proplar get only yani readonly olabilirler fakat set only olamazlar yani writeonly olamazlar.
        public int Yas { get; set; } = 15; // İlk değer ataması bu şekilde yapılabilir.

        // Yine classlar içerisinde de metot tanımlamaları yapabiliyoruz
        public int Topla()
        {
            return 1;
        }
        
        //Indexer özelliği
        public string this[string FullName]
        {
            get
            {
                return FullName;
            }
            set
            {
                FullName = value;
            }
        }
    }

}