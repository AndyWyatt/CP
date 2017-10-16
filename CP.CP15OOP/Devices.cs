using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP15OOP
{
    public class Device
    {
        public string DeviceName { get; private set; }
        public double Price { get; private set; }
        public int RamInGB { get; set; }
        public int StorageInGB { get; set; }
        public string OperatingSystem { get; set; }
        public string Brand { get; set; }
        public int ModelNumber { get; private set; }

        private Device()
        {

        }

        public Device(
            string deviceName,
            double price,
            int modelNumber) : this()
        {
            DeviceName = deviceName;
            Price = price;
            ModelNumber = modelNumber;
        }

        public void SwitchOn()
        {

        }

        public virtual void SwitchOff()
        {
            Console.WriteLine("Turned Off");
        }

        public string Login(string loginInfo)
        {
            string result = string.Empty;

            return result;
        }
    }

    class PC : Device
    {
        public bool HasGraphicsCard { get; set; }
        public int RamSlots { get; set; }
        public string[] StorageConnectivity { get; set; }

        public PC(string deviceName, double price, int modelNumber) : base(deviceName, price, modelNumber)
        {

        }

        public void MouseConnect()
        {

        }

        public void KeyboardConnect()
        {

        }

        public override void SwitchOff()
        {
            Console.WriteLine(
@"Applying auto updates
stopping background services
parking hard disks");
            base.SwitchOff();
        }

        public bool IsMonitorConnected()
        {
            bool IsMonitorConnected = true;

            return IsMonitorConnected;
        }
    }

    class Tablet : Device
    {
        public decimal ScreenSize { get; set; }
        public bool Has3DTouch { get; set; }
        public bool HasCamera { get; set; }

        public Tablet(string deviceName, double price, int modelNumber) : base(deviceName, price, modelNumber)
        {

        }

        public bool BetteryFull()
        {
            bool result = true;

            return result;
        }

        public bool ScreenOn()
        {
            bool screenOn = true;

            return screenOn;
        }
    }
}
