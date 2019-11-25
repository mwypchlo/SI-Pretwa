using System.Windows.Forms;
using System.Drawing;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Threading;
using System;
using System.Windows.Input;

namespace SI_PretwaGUI
{
    /// <summary>
    /// Logika interakcji dla klasy Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        public Game()
        {
            InitializeComponent();
           
        }

        private void Grid_MouseMove(object sender, MouseButtonEventArgs e)
        {
            Textblock.Text = Mouse.GetPosition(this).X.ToString();
            Textblock2.Text = Mouse.GetPosition(this).Y.ToString();
        }
    }
}
