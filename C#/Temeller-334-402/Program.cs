using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        #region ArraySegment ve StringSegment
            //ArraySegment bir orijinal diziden referans almadan o dizi üzerinde işlem yapılmasıdır. Yani ekstra bir ref oluşturmadan işlem yapabilmek.
            int[] diziSegment = {1,2,3,4,5,6};
            ArraySegment<int> segment1 = ArraySegment<int>(diziSegment); // Burada aslında dizisegmenti referansına ref attık.
            ArraySegment<int> slice = segment1.Slice(0,3);
            ArraySegment<int> segment2 = ArraySegment<int>(diziSegment, 2, 3); // 2.indexten  3 kadar daha gidecek
            Console.WriteLine(segment2);

            // StringSegment --> Microsoft.Extensions.Primitive paketten yüklenmesi gerekiyor.

            string stringSegment = "Gelecek geçmişten bir parça içerir!";
            // stringSegment segment3 = new(stringSegment, 3, 5); 
        #endregion
        
        #region StringBuilder Sınıfı
            // performanslı string segment alg. kullanarak textleri birleştirip döndürür.
            string name = "ali";
            string lname = "osman";

            StringBuilder builder = new StringBuilder();
            builder.Append(name);
            builder.Append(lname);

            Console.WriteLine(builder.ToString());
        #endregion
    }
}