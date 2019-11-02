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

        private void TextBox_TempChanged(object sender, TextChangedEventArgs e)
        {
            
                b.TempFarenheit = sender.ToString();
            
        }

        private void TextBox_DiameterChanged(object sender, TextChangedEventArgs e)
        {
            b.Diameter = sender.ToString();
        }


        private void TextBox_VelocityChanged(object sender, TextChangedEventArgs e)
        {
            b.Velocity = sender.ToString();
        }

        private void TextBox_MassChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_CoefChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_DistanceChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void TextBox_FinalVelocityChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_ImpactTimeChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_DropChanged(object sender, TextChangedEventArgs e)
        {

        }

        /**************************************************************************/
       // WIND ACTIONS
        private void TextBox_WindValChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_WindPushChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_WindDirectionChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_WindVelocityChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
