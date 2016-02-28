using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Management;

namespace PCua
{
    class Motherboard
    {
        /// searches Win32_BaseBoard for motherboard name/info
        /// returns: Motherboard name as string (MotherboardName)
        public static string getMotherboardName()
        {
            string MotherboardName = "";

            ManagementObjectSearcher Motherboarddetail = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
            ManagementObjectCollection detailsmotherboard = Motherboarddetail.Get();
            foreach (ManagementObject detail in detailsmotherboard)
            {
                MotherboardName = (detail["Model"].ToString());   //*BROKEN*  fix needed. 
                                                                  //find a way to deal with prebuilt system motherboards.
            }

            return MotherboardName;
        }
    }
}
