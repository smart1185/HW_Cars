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

namespace HW_3.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }        
        private void tbxVIN_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tbxVIN.Text = null;
            tbxVIN.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void tbx1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tbx1.Text = null;
            tbx1.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void tbx2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tbx2.Text = null;
            tbx2.Foreground = new SolidColorBrush(Colors.Black);
        }
    }
}
