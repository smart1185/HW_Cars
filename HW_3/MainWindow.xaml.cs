using HW_3.Pages;
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

namespace HW_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static Frame mf { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            mf = MainFrame;
        }
        private void MainFrame_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.mf.Source = new Uri("Pages/Page1.xaml", UriKind.RelativeOrAbsolute);
            Page1 page1 = new Page1();
            MainWindow.mf.NavigationService.Navigate(page1);
        }
    }
}
