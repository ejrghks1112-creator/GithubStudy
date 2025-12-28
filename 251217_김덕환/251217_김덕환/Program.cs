namespace _251217_김덕환;

class Program
{
    static void Main(string[] args)
    {
        TesterStruct ts1 = new TesterStruct();
        TesterStruct ts2 = ts1;
        ts2.value = 5;
        Console.WriteLine(ts1.value);
        Console.WriteLine(ts2.value);
    } 
}