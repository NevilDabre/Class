using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Car_Class
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CarVM cvm;
        private const string Year = "2015";
        private const string Make = "Ford";

        public MainWindow()
        {
            InitializeComponent();
            cvm = new CarVM(Year, Make);
            DataContext = cvm;
        }

        private void BtnAccelerate_Click(object sender, RoutedEventArgs e)
        {
            cvm.Accelerate();
        }

        private void BtnBrake_Click(object sender, RoutedEventArgs e)
        {
            cvm.Brake();
        }


    }
}
