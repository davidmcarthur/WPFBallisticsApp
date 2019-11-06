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

        #region TEXTBOXES
        private void Temperature_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        
        private void Velocity_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void WindDirection_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TargetDist_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void WindVelocity_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BallCoef_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Diameter_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Mass_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ImpactTime_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FinalVelocity_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BulletDrop_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void WindValue_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void WindPush_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        #endregion

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // Create code to ensure all required blocks are present before executing calculation
            b.Velocity = VelocityTextBox.Text;
            b.Mass = MassTextBox.Text;
            b.Diameter = DiameterTextBox.Text;
            b.Distance = TargetDistTextBox.Text;
            b.TempFarenheit = TemperatureTextBox.Text;
            b.DragCoef = BallCoefTextBox.Text;
            b.WindVelocityMPH = WindVelocityTextBox.Text;
            b.WindDirection = WindDirectionTextBox.Text;
            // input variables complete

            // Call constructor and collect data from index page
            b.SetBallistics(b.Velocity, b.Mass,
                b.Diameter, b.Distance, b.TempFarenheit,
                b.DragCoef, b.WindDirection, b.WindVelocityMPH);

            b.CalculatePressure(b.TempCelcius);
            b.DoBallisticsMath();
            // ballistics math must run first
            b.EstimateWind();

            ImpactTimeTextBox.Text = b.ImpactTime;
            FinalVelocityTextBox.Text = b.FinalVelocity;
            BulletDropTextBox.Text = b.BulletDrop;
            WindValueTextBox.Text = b.WindValue;
            WindPushTextBox.Text = b.WindPush;

        }
    }
}
