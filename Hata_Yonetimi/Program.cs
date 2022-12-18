namespace Hata_Yonetimi;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş Olduğunuz Sayı : " + sayi);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata : " + ex.Message.ToString());
        }
        // finally
        // {
        //     Console.WriteLine("İşlem Tamamlandı.");
        // }


        try
        {
            int a = int.Parse(null);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş Değer Girdiniz!");
            Console.WriteLine(ex);
        }


        try
        {
            int a = int.Parse("test");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Veri Tipi Uygun Değil!");
            Console.WriteLine(ex);
        }


        try
        {
            int a = int.Parse("-2000000000");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Çok Küçük ya da Çok Büyük Bir Değer Girdiniz!");
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("İşlem Başarıyla Tamamlandı.");
        }
    }
}
