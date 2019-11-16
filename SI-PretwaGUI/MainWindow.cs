using System.Windows;
using System.Windows.Controls;

namespace SI_PretwaGUI
{
    public partial class MainWindow : Window
    {

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Rozpoczynam grę");
            this.Close();
        }
    }

}