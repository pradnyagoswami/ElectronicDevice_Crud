using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDevice_Crud
{
    internal class Device
    {
        int device_id;
        string device_name;
        int device_price;
        public Device(int device_id,string device_name,int device_price)
        { 
        
            this.Device_id = device_id;
            this.Device_name = device_name;
            this.Device_price = device_price;

        
        }
        public override string ToString() 
        {

            return $"{device_id},{device_name},{device_price}";
        
        }
        public int Device_id { get => device_id; set => device_id = value; }
        public string Device_name { get => device_name; set => device_name = value; }
        public int Device_price { get => device_price; set => device_price = value; }
    }
}
