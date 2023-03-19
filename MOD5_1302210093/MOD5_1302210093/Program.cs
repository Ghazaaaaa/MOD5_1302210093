internal class Program
{
    private static void Main(string[] args)
    {
        HelloGeneric helloGeneric = new HelloGeneric();
        helloGeneric.SapaUser("Ghaza Gymnastiar");
        DataGeneric dataGeneric = new DataGeneric("1302210093");
        dataGeneric.printData();
    }
}
class HelloGeneric
{
    public void SapaUser(string username)
    {
        Console.WriteLine("Helo User " + username);
    }
}

internal class DataGeneric
{
    string t;
    public DataGeneric(string t)
    {
        this.t = t;
    }
    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah : " + t);
    }
}