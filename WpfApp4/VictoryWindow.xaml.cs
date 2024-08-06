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
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для VictoryWindow.xaml
    /// </summary>
    public partial class VictoryWindow : Window
    {
        public VictoryWindow(string message, int winner)
        {
            InitializeComponent();
            Player1Image.Visibility = Visibility.Hidden; Player2Image.Visibility = Visibility.Hidden;
            VictoryMessage.Text = message;
            if (winner == 1)
            {
                Player1Image.Visibility = Visibility.Visible;
            }
            else if (winner == 2)
            {
                Player2Image.Visibility = Visibility.Visible;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
