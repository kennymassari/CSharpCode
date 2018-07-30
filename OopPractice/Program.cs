using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Home myHome = new Home();
            myHome.OpenDoor();
            myHome.CloseDoor();
            myHome._address = "755 Wimbledon Drive";
            Console.WriteLine(myHome._address);
        }
    }
    public class Home
    {
        public string _address { get; set; }
        public DateTime _yearBuilt;
        public double _size;
        public bool _garage;
        public bool _swimmingPool;
        public bool _doorOpen;

        public void OpenDoor()
        {
            _doorOpen = true;
            Console.WriteLine("Door is open", _doorOpen);
            Console.Read();
        }

        public void CloseDoor()
        {
            _doorOpen = false;
            Console.WriteLine("Door is closed", _doorOpen);
        }

        public string GetAddress()
        {
            return _address;
        }
    }
}
