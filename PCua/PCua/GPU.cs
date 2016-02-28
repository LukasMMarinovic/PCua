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
    class GPU
    {
        string GPUName = "";
        ///constructor that sets GPU name
        public GPU()
        {
            ManagementObjectSearcher GPUdetail = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            ManagementObjectCollection detailsgpu = GPUdetail.Get();
            foreach (ManagementObject detail in detailsgpu)
            {
                GPUName = (detail["name"].ToString());
            }
        }
        ///returns gpu name after object has been initialized
        public string getGPU()
        {
            return GPUName;
        }
    }
}
