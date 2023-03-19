internal class Program
{
    private static void Main(string[] args)
    {
        HelloGeneric helloGeneric = new HelloGeneric();
        helloGeneric.SapaUser("Ghaza Gymnastiar")
    }
}
class HelloGeneric
{
    public void SapaUser(string username)
    {
        Console.WriteLine("Helo User " + username);
    }
}