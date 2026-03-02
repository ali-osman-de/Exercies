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



}
