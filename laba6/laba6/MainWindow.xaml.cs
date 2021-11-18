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

namespace laba6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum Player
        {
            Player1,
            Player2
        }
        Player player = Player.Player1;
        enum Game
        {
            Win,
            Draw,
            Play
        }
        Game game = Game.Play;
        char[,] map = new char[3, 3] { {'1', '2', '3'}, {'4', '5', '6'}, {'7', '8', '9'} };
        bool isWin = false;
        int moves = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            ClearButtons();
            EditEnableButtons(true);
            moves = 1;
            lbWinner.Visibility = Visibility.Hidden;
            player = Player.Player1;
            game = Game.Play;
            int k = 1;
            for (int i = 0; i < map.GetLength(0); i++)
                for (int j = 0; j < map.GetLength(1); j++)
                    map[i,j] = Convert.ToChar(k++);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
        }

        private void but_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int col = Grid.GetColumn(btn);
            int row = Grid.GetRow(btn) - 1;
            int k = 1;
            if (btn != null)
            {
                switch (player)
                {
                    case Player.Player1:
                        btn.Foreground = Brushes.Red;
                        lbWinner.Foreground = Brushes.Red;
                        btn.Content = 'X';
                        map[row, col] = 'X';
                        k = 1;
                        break;
                    case Player.Player2:
                        btn.Foreground = Brushes.Blue;
                        lbWinner.Foreground = Brushes.Blue;
                        btn.Content = 'O';
                        map[row, col] = 'O';
                        k = -1;
                        break;
                }
            }
            btn.IsEnabled = false;
            if (moves == 9) game = Game.Draw;
            if (CheckWin(row, col)) game = Game.Win;
            if (game == Game.Draw || game == Game.Win)
            {
                GameOver();
            }
            player = player + k;
            moves++;
        }
        
        private bool CheckWin(int row, int col)
        {
            isWin = true;
            for (int i = 0; i < map.GetLength(0) - 1 && isWin; i++)
            {
                isWin = isWin && (map[i, col] == map[i + 1, col]);
            }
            if (isWin) return true;
            isWin = true;
            for (int j = 0; j < map.GetLength(1) - 1 && isWin; j++)
            {
                isWin = isWin && (map[row, j] == map[row, j + 1]);
            }
            if (isWin) return true;
            isWin = false;
            bool toright = true, toleft = true;
            for (int i = 0; i < map.GetLength(1) - 1; i++)
            {
                toright &= (map[i, i] == map[i + 1, i + 1]);
                toleft &= (map[i, map.GetLength(1) - i - 1] == map[i + 1, map.GetLength(1) - i - 2]);
            }
            isWin = toright || toleft;
            return isWin;
        }

        private void GameOver()
        {
            if (game == Game.Win)
            {
                lbWinner.Content = player.ToString() + " Win!";
                EditEnableButtons(false);
            }
            if (game == Game.Draw)
            {
                lbWinner.Foreground = Brushes.Green;
                lbWinner.Content = "Draw!";
            }
            lbWinner.Visibility = Visibility.Visible;
        }

        private void EditEnableButtons(bool f)
        {
            butA1.IsEnabled = f;
            butA2.IsEnabled = f;
            butA3.IsEnabled = f;
            butB1.IsEnabled = f;
            butB2.IsEnabled = f;
            butB3.IsEnabled = f;
            butC1.IsEnabled = f;
            butC2.IsEnabled = f;
            butC3.IsEnabled = f;
        }

        private void ClearButtons()
        {
            butA1.Content = "";
            butA2.Content = "";
            butA3.Content = "";
            butB1.Content = "";
            butB2.Content = "";
            butB3.Content = "";
            butC1.Content = "";
            butC2.Content = "";
            butC3.Content = "";
            butA1.Foreground = new SolidColorBrush(Color.FromRgb(142, 142, 166));
            butA2.Foreground = new SolidColorBrush(Color.FromRgb(142, 142, 166));
            butA3.Foreground = new SolidColorBrush(Color.FromRgb(142, 142, 166));
            butB1.Foreground = new SolidColorBrush(Color.FromRgb(142, 142, 166));
            butB2.Foreground = new SolidColorBrush(Color.FromRgb(142, 142, 166));
            butB3.Foreground = new SolidColorBrush(Color.FromRgb(142, 142, 166));
            butC1.Foreground = new SolidColorBrush(Color.FromRgb(142, 142, 166));
            butC2.Foreground = new SolidColorBrush(Color.FromRgb(142, 142, 166));
            butC3.Foreground = new SolidColorBrush(Color.FromRgb(142, 142, 166));
        }
        private void but_Enter(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            switch (player)
            {
                    case Player.Player1:
                        btn.Content = 'X';
                        break;
                    case Player.Player2:
                        btn.Content = 'O';
                        break;
            }
        }

        private void but_Leave(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn.IsEnabled)
                btn.Content = "";
        }
    }
}
