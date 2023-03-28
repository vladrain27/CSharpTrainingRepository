using CSharpThirdSession.Functionality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpThirdSession
{
    internal class GamingPhone : Smartphone
    {
        public Fan fan;

        public void PlayGame()
        {
            Console.WriteLine("Playing COD");
        }
    }
}
