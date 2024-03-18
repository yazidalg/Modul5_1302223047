public class Penjumlahan
{
    public static void JumlahTigaAngka<T>(T prm1, T prm2, T prm3)
    {
        dynamic temp;
        dynamic angka1 = prm1;
        dynamic angka2 = prm2;
        dynamic angka3 = prm3;
        temp = angka1 + angka2 + angka3;
        Console.WriteLine(temp);
    }
}

public class MainProgram
{
    public static void Main(String[] args)
    {
        Penjumlahan.JumlahTigaAngka<int>(13, 02, 22);
    }
}