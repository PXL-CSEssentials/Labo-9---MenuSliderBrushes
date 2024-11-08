using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labo_9___MenuSliderBrushes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void numberOneMenuItem_Click(object sender, RoutedEventArgs e)
        {
            numberOneSlider.Value = 2;
        }

        private void numberTwoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            numberTwoSlider.Value = 2;
        }

        private void closeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Afsluiten", "Bent u zeker dat u wil afsluiten?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.No)
                e.Cancel = true;
        }

        private void numberTwoSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numberTwoTextBox.Text = numberTwoSlider.Value.ToString();
        }

        private void numberOneSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numberOneTextBox.Text = numberOneSlider.Value.ToString();
        }

        private void numberOneTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            numberOneSlider.Value = int.Parse(numberOneTextBox.Text);
        }

        private void numberTwoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            numberTwoSlider.Value = int.Parse(numberTwoTextBox.Text);
        }
    }
}