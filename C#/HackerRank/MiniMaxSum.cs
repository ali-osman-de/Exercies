public class MiniMaxSum
{
    // 1.Çözüm 3 case'den geçti
    public static void miniMaxSum(List<int> arr)
    {
        var minValue =  arr.Sum() - arr.Max();
        var maxValue =  arr.Sum() - arr.Min();
        Console.WriteLine($"{minValue} {maxValue}");
    }

    // 2.Çözüm tüm caselerden geçti
    public static void miniMaxSum(List<int> arr)
    {
        long total = 0;
        for(int i = 0; i < arr.Count; i++){
            total += arr[i];
        }
        long minValue = total - arr.Max();
        long maxValue = total - arr.Min();
        Console.WriteLine($"{minValue} {maxValue}");
    }
}

/*
 Mini-Max Sum

 Problem:
 5 pozitif tam sayı verilir.
 Bu 5 sayıdan tam olarak 4 tanesini toplayarak:

 - En küçük toplamı
 - En büyük toplamı

 bulup ekrana yazdırmamız istenir.

 Mantık:
 - Minimum toplam = Toplam - En büyük sayı
 - Maximum toplam = Toplam - En küçük sayı

 Neden?
 Çünkü 4 sayı toplarken:
 - En küçük toplam için en büyük sayıyı dışarıda bırakırız.
 - En büyük toplam için en küçük sayıyı dışarıda bırakırız.

 Örnek:
 Input: 1 2 3 4 5

 Toplam = 15
 Min = 15 - 5 = 10
 Max = 15 - 1 = 14

 Output:
 10 14

 Not:
 Taşma (overflow) olmaması için long (64-bit) veri tipi kullanılmalıdır.
*/