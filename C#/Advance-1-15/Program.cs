using System.Dynamic;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {

    }

    #region Ref Return & Ref Local
        /*
        int a = 5;
        // ref return imza ref olmalı ve return ref değer şeklinde olmalı
        MathRef mathRef = new();
        ref int karsılama = ref mathRef.Topla(ref a);
        Console.WriteLine(a); // 10
        Console.WriteLine(karsılama); // 10
        
        class MathRef
        {
            public ref int Topla(ref int a)
            {
                a += 5;
                return ref a;
            }
        }


        */
    #endregion
    
    #region Operator Overloading

        /*
            İkili Beyan Gerektirenler -- Aksi takdirde compiler hata verir
            ==, !=
            < ,>
            <=, >=
            true, false


            ++ veya -- operatörler tekil parametre ile tanımlanmalıdır. verilen parametre overloading yapılan türden olmalıdır. Dönüş değeri de yine aynı türden olmalıdır.

            true veya false operatörlerinde geriye dönüş değeri ise boolean olmak zorunda, parametreleri tekil şeklinde overloading edilen sınıf referansından olmalıdır.

            Geriye dönüş değeri yapılcak işlemlerde operatör overloading yapılır.
            access modifiersda ise public veya static olabilir.

            MyClass myClass = new();
            MyClass2 myClass2 = new();
            var result = myClass + myClass2;
        
        */
        class MyClass
        {
            public int MyProperty { get; set; }
            public List<MyClass2> MyClasses2 { get; set; } = new();
        }

        class MyClass2
        {
            public int MyProperty2 { get; set; }

            public static MyClass operator +(MyClass myClass, MyClass2 myClass2)
            {
                myClass.MyClasses2.Add(myClass2);
                return myClass;
            }
        }


    #endregion

    #region Implicit / Explicit Operators Overloading
        /*
            A a = new A() { MyProperty = 10 };
            B b = a; // Implicit conversion sayesinde A nesnesi B nesnesine dönüştürülmüş olur.
            B b1 = (A) new A();

            B b2 = new B() { MyProperty = 20 };
            A a2 = (A)b2; // Explicit conversion sayesinde B nesnesi A nesnesine dönüştürülmüş olur.
        */

        // Implicit operatörler (Implicit conversion) Kapalı dönüşüm --> kendi türünden olmayan türlere dönüşüm yaparken tür dönüştürme işlemlerinini açıklamak için kullanılan kavramlardır.
        // int a = 5;
        // double b = a; // implicit conversion

        class A
        {
            public int MyProperty { get; set; }
            
            public static implicit operator B(A a)
            {
                return new B() { MyProperty = a.MyProperty }; // Burada A nesnesi B nesnesine dönüştürülmüş olur.
            }
        }

        // Explicit operatörler (Explicit conversion) Açık dönüşüm --> kendi türünden olmayan türlere dönüşüm yaparken tür dönüştürme işlemlerini açıklamak için kullanılan kavramlardır.
        // double c = 5.5;
        // int d = (int)c; // explicit conversion

        class B
        {
            public int MyProperty { get; set; }

            public static explicit operator A(B b)
            {
                return new A() { MyProperty = b.MyProperty }; // Burada B nesnesi A nesnesine dönüştürülmüş olur.
            }
        }

    #endregion

    #region Exception Handler (İstisnai Durum)
        /*
            int a= 1, b=1;
            try
            {
                if (a == b)
                {
                    throw new CustomException("a ve b eşit olamaz")
                    {
                        MyProperty = 10
                    };
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"{ex.Message} - MyProperty: {ex.MyProperty}");
            }
        
        */
        
        // İstenmeyen davranışları kontrol altına almak ve programın çökmesini engellemek için kullanılır.

        class CustomException : Exception
        {
            public CustomException() : base("Custom hata")
            {
                
            }

            public CustomException(string message) : base(message)
            {
                
            }
            public int MyProperty { get; set; }
        }

    #endregion

    #region Programatik Nesne Üretimi

        #region Activator
            // dinamik olan bilmediğimiz türlerde nesne üretmek için önce nesnenin türünü ardından o türden bir nesne üretmek için Activator sınıfını kullanırız.

            /*
                Type type = typeof(ActivatorClass);
                ActivatorClass myClass = (ActivatorClass)Activator.CreateInstance(type);
                Console.WriteLine($"{myClass.GetType().Name} nesnesi oluşturuldu.");
            */
            class ActivatorClass
            {
                
            }
        #endregion

        #region Dynamic Object
            // türünü belirmediğimiz nesneler oluşturmak için kullanılır. Dynamic türünde bir nesne oluşturduğumuzda, o nesnenin türü çalışma zamanında belirlenir ve o türün özelliklerine ve yöntemlerine erişebiliriz.

            /*
                dynamic generalClass = new GeneralClass();
                generalClass.DynamicProperty = "Hello, World!";
            */
            class GeneralClass : DynamicObject
            {

                private readonly Dictionary<string, object> _properties = new();
                public override bool TrySetMember(SetMemberBinder binder, object? value)
                {
                    _properties.Add(binder.Name, value!);
                    return true;
                }

                public override bool TryGetMember(GetMemberBinder binder, out object? result)
                {
                    return _properties.TryGetValue(binder.Name, out result);
                }
                
            }
        #endregion

        #region Expando Object
            // Bir tür varmış gibi işlemler yapmamız sağlar.
            /*
                dynamic expando = new ExpandoObject();
                expando.MyProperty = "Hello, World!";
                Console.WriteLine(expando.MyProperty); // Hello, World!
            */
        #endregion
    #endregion

    #region Generic Yapılar
        /*
            GenericClass<bool, string, int, int> genericClass = new();
        */

        // Interface, Record, Struct birer generic yapılar olabilirler.
        // Tür bildirimi mecburidir.
        class GenericClass<T, T1, T2, T3> : GenericClass3<T>
        {
            T field;
            public T1 MyProperty { get; set; }
            public void Y<T2>()
            {
                
            }
            public void X<T2>(T3 par)
            {
                return par;
            }
        }

        // Generic bir sınıf başka bir generic veya normal classtan miras alabilirde verebilirde.
        // Bir Metot Generic veya generic olmayan yapılar kurulabilir.
        class NormalClass : GenericClass<int, int, int, int>
        {
            public void X<T>()
            {
                
            }
        }

        class GenericClass2<T> : GenericClass3<T>
        {
            
        }

        class GenericClass3<T> where T : class
        {
            
        }

        // Kısıtlamalar --> Tür güvenliği, 
        // class Myclass<T> where T : <constraint> { }
        // constraint --> struct, class, new(), Base Class, Interface, Enum, notnull, default

    #endregion

    #region Covariance & Contravariance

        // Covariance --> İki değişken arasındaki ilişki biri artarken diğeri de artar.
        // Override metotlarda geçerlidir.
        IEnumerable<A> strings = new List<A>();
        IEnumerable<B> objects = strings; // Covariance sayesinde IEnumerable<string> türündeki bir nesne, IEnumerable<object> türündeki bir nesneye atanabilir. Çünkü string türü object türünden türemiştir.

        // Contravariance --> İki değişken arasındaki ilişki biri artarken diğeri azalır.
        void XMethod(A a) { }
        Action<A> aDelegate = XMethod;
        Action<B> bDelegate = XMethod; // Contravariance sayesinde Action<A> türündeki bir nesne, Action<B> türündeki bir nesneye atanabilir. Çünkü A türü B türünden türemiştir.

    #endregion

    #region Delegates
        // Methodların temsil edilmesidir.
        // Kodlama sürecinde bir methodun temsilcisi olarak kullanılırlar. Delegeler, bir methodun imzasını tanımlar ve o methodu çağırmak için kullanılabilirler.

        // Delegatelere bir sınıfın davranışını özelleştirebildikleri için ihtiyaç duyarız.
        // Temsilci Örneği --> public delegate void MyHandler(string message, string model);
        // Kullanım Örneği --> MyHandler handler = new MyHandler();
        // Delegatelerde bir referans türlüdür. özünde bir classtır, System.Delegate sınıfından türemiştir.

        // delegate çalıştır veya tetikleme --> handler.Invoke(); veya handler();

    #endregion

    #region Events
        // Olaylara tepki vermek
        // event sourcing --> olayları takip etmek
        // iletişim içinde kalmak

        // Bir event o eventi tetikleyebilecek bir metot veya metotları içeren bir delegate ile birlikte kullanılır. Eventler, bir olay meydana geldiğinde tetiklenir ve o olaya tepki vermek için delegate tarafından tanımlanan metotları çağırır.

        /*
            EventClass eventClass = new();
            eventClass.MyEvent += () // --> event daha tetiklenmedi sadece bağlandı.
            eventClass.TriggerEvent(); // Eventi tetikliyoruz.
            eventClass.MyEvent -= () // --> event bağlantısını kesiyoruz.
        */

        //Event Tanımlama

        class EventClass
        {
            public delegate void XHandler();
            public event XHandler MyEvent; // Eventlerin türleri vardır ve kullandıkları delegate türünde olmalıdırlar.
            public void TriggerEvent()
            {
                MyEvent();
            } 
        }

        // Kritik
        // Delegateler tanımlandıkları classlar içerisinden üretilen instancelar tarafından erişelememektedir.
        // Classların direkt değişken adından değil türleri üzerinden erişilebilir.
        // Eğerki bir sınıfın objesi üzerinden yani instance üzerinden erişmeye çalışırsak bunu eventler üzerinden sağlayabiliyoruz.

        // Event Add & Remove
        // XHandler XMyEvent;
        // public event XHandler MyEvent
        // {
        //     add
        //     {
                    //XMyEvent += value; // event tetiklendiğinde MyEvent'e bağlanan metotları XMyEvent'e ekleriz.
        //     }
        //     remove
        //     {
                    //XMyEvent -= value; // event bağlantısı kesildiğinde MyEvent'e bağlanan metotları XMyEvent'ten çıkarırız.
        //     }
        // };

        // Belirli bir dizin 5mb geçtiği anda bir event oluşturalım.

    #endregion

    #region Hazır delegateler

        // Action --> Geriye dönüş değeri olmayan delegatelerdir. parametre almayan ve geri dönüş değeri olmayan

        Action action = () => Console.WriteLine("Hello, World!"); // Action delegate'ini kullanarak bir lambda ifadesi oluşturduk. Bu ifade, "Hello, World!" mesajını konsola yazdırır.
        action(); // Action delegate'ini çağırarak lambda ifadesini çalıştırırız

        // Action<T> --> Generic parametre alan ve geri dönüş değeri olmayan delegatelerdir.

        Action<string> action2 = (message) => Console.WriteLine(message); // Action<T> delegate'ini kullanarak bir lambda ifadesi oluşturduk. Bu ifade, kendisine verilen mesajı konsola yazdırır.
        action2("Hello, World!"); // Action<T> delegate'ini çağırarak

        Action<string, int> action3 = (message, number) => Console.WriteLine($"{message} - {number}"); // Action<T1, T2> delegate'ini kullanarak bir lambda ifadesi oluşturduk. Bu ifade, kendisine verilen mesajı ve sayıyı konsola yazdırır.
        action3("Hello, World!", 42); // Action<T1, T2>

        // Func --> generic olarak hem parametre alan hem de geri dönüş değeri olan delegatelerdir.
        // en çok kullanılan
        
        // Func<T1, T2, T3, T4, Tn> Burada en sondaki Tn bizim dönüş türümüzken diğerleri ise bizim generic parametrelerimiz 
        // Func<string, int, bool>  func = (string, int) => true  örnek olarak bu şekilde diyebiliriz.
        Func<int> func1 = () => 3; // bu şekilde olursa yani tek bir tane olursa, burada dönüş değerine denk gelir.

        Func<string, int, bool> func = ("Ali", 12) => true;

        // Predicate --> Generic bir parametre alan ve geriye bool değer döndüren delegatelerdir.

        Predicate<int> predicate = num => num < 10; // sonuç bool olacaktır.

    #endregion

    #region Anonymous Structures İsimsiz Yapılar
        // var keyword ile karşılanırlar.
        // Anonymouse Objects --> derleme sırasında adlandırılmayan ve tanımlanmayan, anlık ve tek kullanımlık veri yapısında oluşturmada kullanışlı.
            // readonly olarak tasarlanırlar.
            var anonymouseObjectPerson = new
            {
                Name = "ali",
                Age = 24
            };

        // Anonymouse Methods --> bir metodu ihtiyaç anında direkt tanımlayıp kullanılmasıdır.

            //lambda ifadesi ile birlikte ve delegate keyword anonymous methodlardır
            delegate int Topla(int num1, int num2);
            Topla topla = new Topla((sayi1, sayi2) => sayi1 + sayi2);

        // Anonymouse Collections --> adı ve türü belirtilmeyen bir koleksiyondur.
            //array
            var x = new[] {1,2,3,4};
            //list
            var y = new Collection()
            {
                new {A = 1},
                new {B = 2}
            }
    #endregion

    #region ExpandoObject

        // Run-time zamanında dinamik objeler oluşturmamızı sağlar
        // client tarafından gelecek isteğe göre bir objeyi tasarlamak istediğimizde kullanabiliiz.
        // özünde IDictionary<string, object> yapısındadır.

        dynamic expandoObject = new ExpandoObject();

        expandoObject.Name = "Ali";
        expandoObject.MiddleName = "Osman";
        expandoObject.Age = 24;

        List<ExpandoObject> list = new()
        {
            expandoObject
        }

        // Serialize 
            var jsonData = JsonSerializer.Serialize(list);

        // Deserialize
            dynamic data = JsonSerializer.Deserialize<List<ExpandoObject>>(jsonData);
    
    #endregion

    #region Access Modifiers
        
        // Felsefesi: her yapının her zaman erişilebilir olmasını istemeyiz.
        public // her yerden erişilebilir
        private // sadece ilgili class içerisinde erişilebilir.
        protected // sadece ilgili class içerisinde erişim sağlanır, Türe ait instancelarda private davranışı sergiler, fakat kalıtım alıyorsa yine class modeli içersinden erişim sağlanır burada önemli nokta yine instance üzerinden erişim sağlanamaz.
        internal // aynı assembly içerisinden diğer sınıfların erişilebileceğini belirtir. classlar default olarak internal'dır.
        protected internal // tanımlandığı proje içerisinde instance erişimi ve farklı bir assembly tarafından da erişim sağlanır. her biri birbirini ezme durumu var.
        private protected // aynı assembly içerisinde erişim serbest fakat farklı bir assemblyde çalışmaz.

        // Access Modifiers - Kapsülleme Handikapı
        // bazı durumlarda mantıksal bozukluklar olabilir.

    #endregion

}
