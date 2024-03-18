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
public class SimpleDataBase<T>
{
    private List<T> storeDataList;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storeDataList = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        this.storeDataList.Add(data);
        this.inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < this.storeDataList.Count; i++)
        {
            Console.WriteLine($"Data {i+1} berisi: {this.storeDataList.ElementAt(i)}, yang disimpan pada waktu {this.inputDates.ElementAt(i)}");
        }
    }
}

public class MainProgram
{
    public static void Main(String[] args)
    {
        Penjumlahan.JumlahTigaAngka<int>(13, 02, 22);
        SimpleDataBase<int> test = new SimpleDataBase<int>();
        test.AddNewData(13);
        test.AddNewData(02);
        test.AddNewData(22);
        test.PrintAllData();
    }
}