class Program
{
    static void Main(string[] args)
    {
        GenericClass<bool, string, int, int> genericClass = new();
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

    #region Generic Yapılar

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

}
