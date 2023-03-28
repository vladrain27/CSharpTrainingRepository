using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpThirdSession.Functionality;

namespace CSharpThirdSession
{
    internal class Smartphone : ClassicPhone, Camera
    {
        public string memory;
        public string processorType;
        public string screenSize;
        public string screenType;
        public string chargingPortType;

        public void TakePicture()
        {
            Console.WriteLine("Picture taken");
        }

        public void OrderFood()
        {
            Console.WriteLine("Food ordered");
        }
    }
}
