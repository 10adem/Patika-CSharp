namespace Degiskenler;
class Program
{
    static void Main(string[] args)
    {
        /*int sayi = 2;
        string? degisken = null;
        string? Degisken = null;
        Console.WriteLine(sayi + degisken + Degisken);
        Console.ReadLine();*/

        DateTime dt = DateTime.Now;
        System.Console.WriteLine(dt);

        string str1 = string.Empty;
        string ad = "Adem";
        string soyad = "Yıldız";
        string tamIsım = ad + " " + soyad;

        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        System.Console.WriteLine(datetime);

        string datetime1 = DateTime.Now.ToString("dd/MM/yyyy");
        System.Console.WriteLine(datetime1);

        string hour = DateTime.Now.ToString("hh.mm");
        System.Console.WriteLine(hour);
    }
}
