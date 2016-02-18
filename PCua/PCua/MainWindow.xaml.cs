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
//| v0.0.0.1              |//
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
            lbl_TestOutput.Content = CPU.getCPUName();          
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

        ManagementObjectSearcher CPUdetail = new ManagementObjectSearcher("SELECT name FROM Win32_Processor");
        ManagementObjectCollection details = CPUdetail.Get();
        foreach (ManagementObject detail in details)
        {
            CPUName = (detail["name"].ToString());
        }

        return CPUName;
    }
}

//todo
public class RAM
{

}
public class GPU
{

}
public class Storage
{

}

//things that change with other things
public class Motherboard
{

}
public class PSU
{

}

