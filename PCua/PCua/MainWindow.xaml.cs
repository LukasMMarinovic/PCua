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
//| v0.0.0.4              |//
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
//|     Adam Williams                               |//
//|         https://github.com/AdamLlama            |//
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
            HardwareInfo MySystem = new HardwareInfo();

            //display system information
            lbl_TestOutput.Content = MySystem.getSystemInfo(); ;
            
        }
    }
}



