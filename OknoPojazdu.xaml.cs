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
using System.Windows.Shapes;
using System.Xml;

namespace Zadanie4
{
    /// <summary>
    /// Logika interakcji dla klasy OknoPojazdu.xaml
    /// </summary>
    public partial class OknoPojazdu : Window
    {
        public OknoPojazdu(XmlNode pojazd)
        {
            DataContext = pojazd;
            InitializeComponent();
        }
    }
}
