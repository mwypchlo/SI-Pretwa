using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
            Game subWindow = new Game();
            subWindow.Show();
         }
    }
}