public class Program
{
    static void Main()
    {
        #region Keywords
            // dilde önceden tanımlanmış parçacıklar.
            // bir keyword bir operatör olabilir örnek typeof(),
            // bazıları ise olamaz static, public vb.

            // bazı keywordler tek başına hiçbir şey ifade etmezler mesela class, static bunlar konsept keywordlerdir.
            // konseptsiz keywordler return, continue, break, goto vb.

            /* 
                Döngü durdurmak --> break; döngü ve switch case yapısında kullanılır.
                Döngüde atlanmak istenen yer --> continue; sadece döngülerde kullanılır.
            */

            for(int sayi = 1; sayi <= 10; sayi++)
            {
                if(sayi == 8) continue; // döngüde kendisini atlatır ve direkt for içine gidip bir sonraki sıradaki sayıya geçer.
                if(sayi == 10) break; // döngüyü durdurur ve çıkar 
                if(sayi == 11) return; // döngüden çıkmaya yarar ve 7'de işlemi keser, ayrıca return ile değer geriye döndürülür.
                Console.WriteLine(sayi);
            }

        #endregion
    }
}