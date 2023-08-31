using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDevice_Crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
          ElectronicDevice_Implementations device = new ElectronicDevice_Implementations();
            char ch = ' ';
            do
            {
                Console.WriteLine("1.Insert\n2.Show\n3.Update\n4.Delete\n 5.Serach");
                Console.WriteLine("enter the choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How many Device you want to add");
                        int n = Convert.ToInt32(Console.ReadLine());
                        device.AddDevice(n);
                        break;
                    case 2:
                        Console.WriteLine(".....");
                        device.ShowAllDevice();
                        break;
                    case 3:
                        Console.WriteLine("enter the id for update");
                        int did = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the new price");
                        int price = int.Parse(Console.ReadLine());
                        device.UpdateDevice(did, price);
                        break;
                    case 4:
                        Console.WriteLine("Enter the id for delete");
                        int deid = Convert.ToInt32(Console.ReadLine());
                        device.DeleteDevice(deid);
                        break;
                    case 5:
                        Console.WriteLine("Enter id for search");
                        int id = int.Parse(Console.ReadLine());
                        device.SearchDeviceById(id);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
                Console.WriteLine("Do you want to continue....");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'y' || ch == 'Y');
        }
    }
}
