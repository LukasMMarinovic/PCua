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
    class HardwareInfo
    {
        string SystemInfo;

        CPU cpu = new CPU();
        GPU gpu = new GPU();

        //list containing all pc components in system
        List<PCPart> parts = new List<PCPart>();


        public HardwareInfo()
        {
            parts.Add(cpu);
            parts.Add(gpu);

            //package system info into a single string
            foreach (PCPart part in parts)
            {
                SystemInfo = SystemInfo + "\n" + part.getInfo();

            }
        }
       
        /// grabs SystemInfo
        /// returns SystemInfo
        public string getSystemInfo()
        {
            return SystemInfo;

        }
         


    }
}
