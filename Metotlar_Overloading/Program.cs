namespace Metotlar_Overloading;
class Program
{
    static void Main(string[] args)
    {
        // Out Parametreler
        string sayi = "999";
        int outSayi;

        // bool sonuc = int.TryParse(sayi, out int outSayi);
        bool sonuc = int.TryParse(sayi, out outSayi);
        if (sonuc)
        {
            Console.WriteLine("Başarılı!");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Başarısız!");
        }

        Metotlar Instance = new Metotlar();
        Instance.Topla(4, 5, out int toplamSonuc);
        System.Console.WriteLine(toplamSonuc);

        // Metot Aşırı Yükleme -- Overloading

        int ifade = 999;
        Instance.ekranaYazdir(Convert.ToString(ifade));
        Instance.ekranaYazdir(ifade);
        Instance.ekranaYazdir("Adem", "Yıldız");

        // Metot İmzası
        // Metot Adı + Parametre Saısı + Parametre Tipi
    }
}

class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }

    public void ekranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public void ekranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }

    public void ekranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }
}
