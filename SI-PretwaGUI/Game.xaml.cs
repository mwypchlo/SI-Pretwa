using System.Windows.Forms;
using System.Drawing;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Threading;
using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace SI_PretwaGUI
{
    
    /// <summary>
    /// Logika interakcji dla klasy Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        public List<System.Windows.Point> BoardPoints = new List<System.Windows.Point>();
    

        List<Grid> czerwone = new List<Grid>();
        List<Grid> zolte = new List<Grid>();
        private Boolean pierwszyKlik; //kazdy ruch to dwa klikniecia - zrodlo i cel
        private Boolean blokujPionek; //zmusza gracza do gry jednym pionkiem (wielokrotne bicie)
        private Boolean ruchWykonany;
        private int[] mv, xy, blokowany;
        private System.Windows.Controls.Button sndr, tempBtn;
        private DoubleAnimation fadeIn;
        private double anlen;
        private void FillGameBoard()
        {
            BoardPoints.Add(new System.Windows.Point(400, 401)); //0
            BoardPoints.Add(new System.Windows.Point(400, 499)); //1 dół
            BoardPoints.Add(new System.Windows.Point(400, 601)); //2 dół
            BoardPoints.Add(new System.Windows.Point(400, 704)); //3 dół
            BoardPoints.Add(new System.Windows.Point(311, 451)); //1 dolny lewy
            BoardPoints.Add(new System.Windows.Point(224, 501)); //2 dolny lewy
            BoardPoints.Add(new System.Windows.Point(138, 551)); //3 dolny lewy
            BoardPoints.Add(new System.Windows.Point(308, 436)); //1 górny lewy
            BoardPoints.Add(new System.Windows.Point(221, 295)); //2 górny lewy
            BoardPoints.Add(new System.Windows.Point(136, 247)); //3 górny lewy
            BoardPoints.Add(new System.Windows.Point(400, 294)); //1 góra 
            BoardPoints.Add(new System.Windows.Point(400, 194)); //2 góra
            BoardPoints.Add(new System.Windows.Point(400, 95)); //3 góra
            BoardPoints.Add(new System.Windows.Point(487, 349)); //1 górny prawy
            BoardPoints.Add(new System.Windows.Point(575, 299)); //2 górny prawy
            BoardPoints.Add(new System.Windows.Point(664, 247)); //3 górny prawy
            BoardPoints.Add(new System.Windows.Point(484, 448)); //1 dolny prawy
            BoardPoints.Add(new System.Windows.Point(574, 499)); //2 dolny prawy
            BoardPoints.Add(new System.Windows.Point(665, 552)); //3 dolny prawy
        }
        public Game()
        {
            InitializeComponent();
            FillGameBoard();
        }

        private void Grid_MouseMove(object sender, MouseButtonEventArgs e)
        {
            Textblock.Text = Mouse.GetPosition(this).X.ToString();
            Textblock2.Text = Mouse.GetPosition(this).Y.ToString();

        }

        private void ResButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
           Game reset = new Game();
            reset.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void z1Btn_Click(object sender, RoutedEventArgs e)
        {                
            
        }
    }
}