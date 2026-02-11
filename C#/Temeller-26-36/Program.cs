#region Top-Level-Statements Nedir?
// Hazır Gelen Main ve class'ı yazmak zorunda bırakılmaması, fakat gizli bir yazılan kodu kavrayan bir Main olduğunu unutmamak lazım.
internal class Program
{
    #region Main Nedir?
    // Program.cs içerisinde Main fonksiyonu oluşturulan tüm uygulamalardaki başlangıç noktası
    // .cs => C#
    // Uygulama ayağa kalktığında işletim sistemi ile iletişim kuran fonksiyon
    // en fazla 1 adet olmalıdır
    private static void Main(string[] args)
    {
        /*
            dotnet run ali
            output => "Hello, World!"
                       ali
        */
        // Burada args aslında console bir dinleme yapıyor fakat dotnet run [(),(),()] gibi
        Console.WriteLine("Hello, World!");
        Console.WriteLine(args[0]);

        /*
            dotnet run ali osman
            output => "Hello, World!"
                       ali osman
        */
        Console.WriteLine("Hello, World!");
        Console.WriteLine($"{args[0]} {args[1]}");
    }
    #endregion

}
#endregion