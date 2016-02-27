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

//|=======================|//
//| PCua                  |//
//| v0.0.0.2              |//
//|                       |//
//| Analyzes current      |//
//| PC build and offers   |//
//| upgrade suggestions   |//
//|=======================|//

//|=================================================|//
//|Scratch-A-Bear inc.                              |//
//|                                                 |//
//|please visit:                                    |//
//|      http://www.scratch-a-bear.edu              |//     
//|                                                 |//
//|Developers:                                      |//
//|      Lukas Marinovic                            |//
//|         https://github.com/LukasMMarinovic      |//
//|      Vijaysrinivas Rajagopal                    |//
//|         https://github.com/MedicAlert           |//
//|=================================================|//




namespace PCua
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            //display system information
            lbl_TestOutput.Content = (Motherboard.getMotherboardName());          
        }
    }
}

//responsible for all system hardware data and methods
public class HardwareInfo
{
    //complete collection of all hardware data
}

//responsible for all CPU data and methods
public class CPU
{
    /// searches Win32_Processor for CPU name/info
    /// returns: CPU name as string (CPUName)
    public static string getCPUName()
    {
        string CPUName = "";

        ManagementObjectSearcher CPUdetail = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
        ManagementObjectCollection detailscpu = CPUdetail.Get();
        foreach (ManagementObject detail in detailscpu)
        {
            CPUName = (detail["name"].ToString());
        }

        return CPUName;
    }
}


// in progress
//responsible for all Motherboard data and methods
public class Motherboard
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
        }

        return MotherboardName;
    }

}







//to do
public class RAM
{
   /* public static string getRAMName()
    {
        string RAMName = "";

        ManagementObjectSearcher RAMdetail = new ManagementObjectSearcher("Select name From Win32_MotherboardDevice ");
        ManagementObjectCollection detailsram = RAMdetail.Get();
        foreach (ManagementObject detail in detailsram)
        {
            RAMName = (detail["name"].ToString());
        }

        return RAMName;
    }*/

}

public class GPU
{

}
public class Storage
{

}


public class PSU
{

}

