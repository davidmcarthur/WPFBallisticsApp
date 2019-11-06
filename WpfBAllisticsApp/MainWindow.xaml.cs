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
using System.Xml;

namespace WpfBAllisticsApp
{

    

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Ballistics b = new Ballistics();

        public MainWindow()
        {
            
            InitializeComponent();
            
        }

        // Text box for Velocity
        // TODO: parse text information from sender remove unused information
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

            b.TempFarenheit = TempTextBox.Text;

        }


        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Create code to ensure all required blocks are present before executing calculation
        }
    }
}
