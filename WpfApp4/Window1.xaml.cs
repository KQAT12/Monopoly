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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string Player1Namestr = Player1Name.Text.ToString();
            string Player2Namestr = Player2Name.Text.ToString();
            if (Player1Namestr =="")
            {
                Player1Namestr = "Player1";
            }
            if (Player2Namestr=="")
            {
                Player2Namestr = "Player2";
            }
            wplay wplay = new wplay(Player1Namestr, Player2Namestr);
            wplay.Show();
           
            this.Close();
            

        }
    }
}
