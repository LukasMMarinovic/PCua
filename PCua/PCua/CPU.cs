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
    //responsible for all CPU data and methods
    class CPU
    {
        string CPUName = "";

        public CPU()
        {
            ManagementObjectSearcher CPUdetail = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            ManagementObjectCollection detailscpu = CPUdetail.Get();
            foreach (ManagementObject detail in detailscpu)
            {
                CPUName = (detail["name"].ToString());
            }            
        }

    }
}
