namespace CSharpThirdSession
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassicPhone classicPhone = new ClassicPhone();
            Smartphone smartphone = new Smartphone();
            smartphone.AcceptCall();
            GamingPhone gamingPhone = new GamingPhone();
            gamingPhone.PlayGame();
        }
    }
}