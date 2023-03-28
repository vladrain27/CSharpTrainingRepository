using CSharpThirdSession.Functionality;

namespace CSharpThirdSession
{
    internal class FirstPhone : CallFunctionality
    {
        String batteryLevel;
        public FirstPhone()
        {
            batteryLevel = "100";
        }

        public void AcceptCall()
        {
            Console.WriteLine("Accepting call");
        }

        public void DeclineCall()
        {
            Console.WriteLine("Declining call");
        }

        public void MakeCall()
        {
            Console.WriteLine("Making call");
        }
    }
}
