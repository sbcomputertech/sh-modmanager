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

namespace CWMM2.Controls
{
    /// <summary>
    /// Interaction logic for ModControl.xaml
    /// </summary>
    public partial class ModControl : UserControl
    {
        public string ModName { get; set; }
        public string ModVersion { get; set; }
        public string ModAuthor { get; set; }
        public string ModDescription { get; set; }

        public ModControl(string modName, string modVersion, string modAuthor, string modDescription)
        {
            ModName = modName;
            ModVersion = modVersion;
            ModAuthor = modAuthor;
            ModDescription = modDescription[..15]; // take first 15 chars

            InitializeComponent();
            DataContext = this;
        }

        public ModControl()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
