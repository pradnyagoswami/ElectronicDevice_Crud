using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDevice_Crud
{
    internal class ElectronicDevice_Implementations
    {
        Device[] device;
        int count;
        public ElectronicDevice_Implementations()
        { 
        
            device = new Device[3];
            count = 0;
        }
        public void AddDevice(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the device id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Device name");
                String devicename = Console.ReadLine();
                Console.WriteLine("Entre the device price");
                int deviceprice = int.Parse(Console.ReadLine());
                device[count] = new Device(id, devicename, deviceprice);
                count++;
            }


        }
        public void ShowAllDevice()
        {
            for (int i = 0; i < count; i++)
            {
                if (device[i] != null)
                {
                    Console.WriteLine(device[i]);
                }
            }

        }
        public void SearchDeviceById(int id)
        {
            for (int i = 0; i < device.Length; i++)
            {
                if (device[i] != null)
                {
                    if (device[i].Device_id == id)
                    {
                        Console.WriteLine(device[i]);
                    }
                }
            }


        }
        public void UpdateDevice(int id, int newprice)
        {
            for (int i = 0; i < device.Length; i++)
            {
                if (device[i] != null)
                {
                    if (device[i].Device_id == id)
                    {
                        device[i].Device_price = newprice;
                    }
                }
            }

        }
        public void DeleteDevice(int id) 
        {

            for (int i = 0; i < device.Length; i++)
            {
                if (device[i] != null)
                {
                    if (device[i].Device_id == id)
                    {
                        device[i] = null;
                    }
                }
            }

        }

    }
}
