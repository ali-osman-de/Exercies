class OOP_1_Inheritence
{
    // Kalıtım Nedir? 
    // Gerçek hayattan uyarlanmıştır
    // Üretilen nesneler farklı nesnelere özelliklerini aktarabilir ve böylece hiyerarşik düzenleme yapılabilir.
    // Field, property, metotları aktarılabilir.
    // aynı aile grubundan gelen veya yatayda eşit seviyede olan tüm classların benzer özelliklerini tek bir üst sınıftan almaya denir.
    // İnsan --> Erkek,  İnsan --> Kadın *** Burada Erkek ve Kadın classları İnsan sınıfından Miras alırlar. Yani İnsan classını kalıtırlar.
    // Genellenemeyen özellikler kendi sınıfında tanımlanır. Örnek Erkekte sakal Kadında ise makyaj gibi bunlar ortak değiller.
    // Kalıtımı hangi yapılar kalıtım alabilirler --> Class yapısına ait bir özellik, bir sınıf sadece bir sınıftan kalıtım alabilir.
    // Recordlar kendi aralarında kalıtım alabilirler, tek istisna Object.
    // Kalıtım : operatörü ile alınır. Her iki : kalıtım değildir.
    // Kalıtım veren Base Class(kalıtım veren) --> Derived Class(kalıtım alan) olarak adlandırılır terminolojide
    // Bir class hem base class hem de derived class olabilir
    // Üretim Sırası --> Eğer bir nesne üretilecekse kalıtımlıysa ilk önce base daha sonra istenen class üretilecektir.
    static void Main()
    {
        // Opel nesnesinden erişilenler
        Opel opel = new Opel();
        opel.Brand = "Corsa";
        opel.Model = 2013;
        opel.KeylessGo = true;
        
        //Araba nesnesinde erişilenler
        Araba araba = new Araba();
        araba.Brand = "Focus";
        araba.Model = 2009;
    }

    class Araba
    {
        public Araba()
        {
            
        }
        public Araba(int a)
        {
            
        }
        public string Brand { get; set; }
        public int Model { get; set; }
    }

    // Örnek kalıtım 
    class Opel : Araba
    {
        public Opel() // Eğer boş bir constructor varsa varsayılan olarak Arabadaki boş parametreli constructor gelecek
        {
            
        }
        public Opel(int a) : base(a)
        {
            
        }
        public bool KeylessGo { get; set; }
    }
}