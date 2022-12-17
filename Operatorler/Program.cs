namespace Operatorler;
class Program
{
    static void Main(string[] args)
    {
        // Atama ve İşlemli Atama
        int x = 3;
        int y = 3;
        y = y + 2;
        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);
        y /= 1;
        Console.WriteLine(y);
        x *= 2;
        Console.WriteLine(x);

        // Mantıksal Operatörler
        // ||, &&, !

        bool isSuccsess = true;
        bool isCompleted = false;
        if (isSuccsess && isCompleted)
            Console.WriteLine("Perfect!");
        if (isSuccsess || isCompleted)
            Console.WriteLine("Great!");
        if (isSuccsess && !isCompleted)
            Console.WriteLine("Fine!");

        // İlişkisel Operatörler
        // <, >, <=, >=, !=

        int a = 3;
        int b = 4;
        bool sonuc = a < b;
        Console.WriteLine(sonuc);
        sonuc = a > b;
        Console.WriteLine(sonuc);
        sonuc = a >= b;
        Console.WriteLine(sonuc);
        sonuc = a <= b;
        Console.WriteLine(sonuc);
        sonuc = a == b;
        Console.WriteLine(sonuc);
        sonuc = a != b;
        Console.WriteLine(sonuc);


        // Aritmetik Operatörler
        // /, *, -, +

        int sayi1 = 10;
        int sayi2 = 5;
        int sonuc1 = sayi1 / sayi2;
        Console.WriteLine(sonuc1);
        int sonuc1 = sayi1 * sayi2;
        Console.WriteLine(sonuc1);
        int sonuc1 = sayi1 - sayi2;
        Console.WriteLine(sonuc1);
        int sonuc1 = sayi1 + sayi2;
        Console.WriteLine(sonuc1);
        int sonuc1 = sayi1++;
        Console.WriteLine(sayi1);

        // % : Mod alır
        int sonuc2 = 20 % 3;
        Console.WriteLine(sonuc2);
    }
}
