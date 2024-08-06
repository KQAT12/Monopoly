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

namespace WpfApp4
{
   
    public partial class wplay : Window
    {
        public wplay(string player1n, string player2n)
        {
            InitializeComponent();
            buyb.IsEnabled = false;
            imagechecker();
            pl1.Content = player1n;
            pl2.Content = player2n;
            roll1r1.Visibility = Visibility.Hidden;
            roll2r1.Visibility = Visibility.Hidden;
            roll3r1.Visibility = Visibility.Hidden;
            roll4r1.Visibility = Visibility.Hidden;
            roll5r1.Visibility = Visibility.Hidden;
            roll6r1.Visibility = Visibility.Hidden;

            roll1r2.Visibility = Visibility.Hidden;
            roll2r2.Visibility = Visibility.Hidden;
            roll3r2.Visibility = Visibility.Hidden;
            roll4r2.Visibility = Visibility.Hidden;
            roll5r2.Visibility = Visibility.Hidden;
            roll6r2.Visibility = Visibility.Hidden;
        }
        int sum1 = 1;
        int sum2 = 1;
        int turn = 1;
        int balances1 = 15000;
        int balances2 = 15000;
        int kerch = 0; int kerchsum = 440;
        int bridge = 0; int bridgesum = 440;
        int yalta  = 0; int yaltasum = 440;
        int sev = 0; int sevsum = 480;
        int sochi = 0; int sochisum = 600;
        int tuapse = 0; int tuapsesum = 600;
        int gelenzik = 0; int gelenziksum = 660;
        int msk = 0; int msksum = 800;
        int krasnogorsk = 0; int krasnogorsksum = 700;
        int port = 0; int portsum = 400;
        int balachiha = 0; int balachihasum = 660;
        int kirovsk = 0; int kirovsksum = 320;
        int airport = 0; int airportsum = 400;
        int viborg = 0; int viborgsum = 380;
        int spb = 0; int spbsum = 440;
        int road = 0; int roadsum = 400;

        public void rollb_Click(object sender, RoutedEventArgs e)
        {
            roll1r1.Visibility = Visibility.Hidden;
            roll2r1.Visibility = Visibility.Hidden;
            roll3r1.Visibility = Visibility.Hidden;
            roll4r1.Visibility = Visibility.Hidden;
            roll5r1.Visibility = Visibility.Hidden;
            roll6r1.Visibility = Visibility.Hidden;

            roll1r2.Visibility = Visibility.Hidden;
            roll2r2.Visibility = Visibility.Hidden;
            roll3r2.Visibility = Visibility.Hidden;
            roll4r2.Visibility = Visibility.Hidden;
            roll5r2.Visibility = Visibility.Hidden;
            roll6r2.Visibility = Visibility.Hidden;
            Random rand = new Random();
            buyb.IsEnabled = true;
            int randomNumber1 = rand.Next(1, 7);
            switch (randomNumber1)
            {
                case 1:
                    roll1r1.Visibility = Visibility.Visible;
                    break;
                case 2:
                    roll2r1.Visibility = Visibility.Visible;
                    break;
                case 3:
                    roll3r1.Visibility = Visibility.Visible;
                    break;
                case 4:
                    roll4r1.Visibility = Visibility.Visible;
                    break;
                case 5:
                    roll5r1.Visibility = Visibility.Visible;
                    break;
                case 6:
                    roll6r1.Visibility = Visibility.Visible;
                    break;
            }
            int randomNumber2 = rand.Next(1, 7);
            switch (randomNumber2)
            {
                case 1:
                    roll1r2.Visibility = Visibility.Visible;
                    break;
                case 2:
                    roll2r2.Visibility = Visibility.Visible;
                    break;
                case 3:
                    roll3r2.Visibility = Visibility.Visible;
                    break;
                case 4:
                    roll4r2.Visibility = Visibility.Visible;
                    break;
                case 5:
                    roll5r2.Visibility = Visibility.Visible;
                    break;
                case 6:
                    roll6r2.Visibility = Visibility.Visible;
                    break;
            }
            winnerchecker();
            int roll = randomNumber1 + randomNumber2;
            
            switch (turn)
            {
                case 1:
                case 0:
                    turnplayer.Content = "Ход игрока 1";
                    sum1 = sum1 + roll;
                    

                    turn = turn + 1;
                    if (sum1 > 28) { sum1 = sum1 - 28; balances1 += 1000; }
                    switch (sum1)
                    {
                        case 1:
                            Canvas.SetLeft(player1, 835);
                            Canvas.SetTop(player1, 855);
                            buyb.IsEnabled = false;
                            break;
                        case 2:
                            Canvas.SetLeft(player1, 735);
                            Canvas.SetTop(player1, 855);
                            if (kerch == 2){balances1 =balances1 - kerchsum ; buyb.IsEnabled = false; }
                            break;
                        case 3:
                            Canvas.SetLeft(player1, 625);
                            Canvas.SetTop(player1, 855);
                            balances1 = balances1 - 2000;
                            
                            buyb.IsEnabled = false;
                            break;
                        case 4:
                            Canvas.SetLeft(player1, 515);
                            Canvas.SetTop(player1, 855);
                            if (bridge == 2) { balances1 = balances1 - bridgesum; buyb.IsEnabled = false; }

                            break;
                        case 5:
                            Canvas.SetLeft(player1, 405);
                            Canvas.SetTop(player1, 855);
                            if (yalta == 2) { balances1 = balances1 - yaltasum; buyb.IsEnabled = false; }
                            break;
                        case 6:
                            Canvas.SetLeft(player1, 295);
                            Canvas.SetTop(player1, 855);

                            Random rndchance = new Random();
                            int randomNumberChance = rndchance.Next(-2000, 2001);
                            balances1 = balances1 - randomNumberChance;
                            buyb.IsEnabled = false;
                            break;
                        case 7:
                            Canvas.SetLeft(player1, 185);
                            Canvas.SetTop(player1, 855);
                            if (sev == 2) { balances1 = balances1 - sevsum; buyb.IsEnabled = false; }

                            break;
                        case 8:
                            Canvas.SetLeft(player1, 75);
                            Canvas.SetTop(player1, 855);
                            buyb.IsEnabled = false;
                            turn = turn + 1;
                            break;
                        case 9:
                            Canvas.SetTop(player1, 715);
                            Canvas.SetLeft(player1, 50);
                            if (sochi == 2) { balances1 = balances1 - sochisum; buyb.IsEnabled = false; }

                            break;
                        case 10:
                            Canvas.SetTop(player1, 605);
                            Canvas.SetLeft(player1, 50);
                            buyb.IsEnabled = false;

                            balances1 = balances1 - 1000;
                            balance1.Content = balances1.ToString();
                            break;
                        case 11:
                            Canvas.SetTop(player1, 495);
                            Canvas.SetLeft(player1, 50);
                            if (tuapse == 2) { balances1 = balances1 - tuapsesum; buyb.IsEnabled = false; }

                            break;
                        case 12:
                            Canvas.SetTop(player1, 385);
                            Canvas.SetLeft(player1, 50);
                            if (road == 2) { balances1 = balances1 - roadsum; buyb.IsEnabled = false; }

                            break;
                        case 13:
                            Canvas.SetTop(player1, 275);
                            Canvas.SetLeft(player1, 50);
                            if (gelenzik == 2) { balances1 = balances1 - gelenziksum; buyb.IsEnabled = false; }
                             
                            break;
                        case 14:
                            Canvas.SetTop(player1, 165);
                            Canvas.SetLeft(player1, 50);
                            Random rndchance2 = new Random();
                            int randomNumberChance2 = rndchance2.Next(-2000, 2001);
                            balances1 = balances1 - randomNumberChance2;
                            balance1.Content = balances1.ToString();
                            buyb.IsEnabled = false;

                            break;
                            
                            
                        case 15:
                            Canvas.SetTop(player1, 55);
                            Canvas.SetLeft(player1, 50);
                            buyb.IsEnabled = false;

                            break;
                        case 16:
                            Canvas.SetTop(player1, 55);
                            Canvas.SetLeft(player1, 185);
                            if (msk == 2) { balances1 = balances1 - msksum; buyb.IsEnabled = false; }

                            break;
                        case 17:
                            Canvas.SetTop(player1, 55);
                            Canvas.SetLeft(player1, 295);

                            Random rndchance1 = new Random();
                            int randomNumberChance1 = rndchance1.Next(-2000, 2001);
                            balances1 = balances1 - randomNumberChance1;
                            balance1.Content = balances1.ToString();
                            break;
                        case 18:
                            Canvas.SetTop(player1, 55);
                            Canvas.SetLeft(player1, 405);
                            if (krasnogorsk == 2) { balances1 = balances1 - krasnogorsksum; buyb.IsEnabled = false; }

                            break;
                        case 19:
                            Canvas.SetTop(player1, 55);
                            Canvas.SetLeft(player1, 515);
                            if (port == 2) { balances1 = balances1 - portsum; buyb.IsEnabled = false; }
                            
                            break;
                        case 20:
                            Canvas.SetTop(player1, 55);
                            Canvas.SetLeft(player1, 625);
                            if (balachiha == 2) { balances1 = balances1 - balachihasum; buyb.IsEnabled = false; }

                            break;
                        case 21:
                            Canvas.SetTop(player1, 55);
                            Canvas.SetLeft(player1, 735);

                            Random rndchance4 = new Random();
                            int randomNumberChance4 = rndchance4.Next(1000, 2001);
                            balances1 = balances1 + randomNumberChance4;
                            buyb.IsEnabled = false;


                            break;
                        case 22:
                            Canvas.SetTop(player1, 55);
                            Canvas.SetLeft(player1, 855);
                            buyb.IsEnabled = false;

                            break;
                        case 23:
                            Canvas.SetTop(player1, 175);
                            Canvas.SetLeft(player1, 855);
                            buyb.IsEnabled = false;

                            balances1 = balances1 + 1500;
                            balance1.Content = balances1.ToString();

                            break;
                        case 24:
                            Canvas.SetTop(player1, 285);
                            Canvas.SetLeft(player1, 855);
                            if (kirovsk == 2) { balances1 = balances1 - kirovsksum; buyb.IsEnabled = false; }

                            break;
                        case 25:
                            Canvas.SetTop(player1, 395);
                            Canvas.SetLeft(player1, 855);
                            if (airport == 2) { balances1 = balances1 - airportsum; buyb.IsEnabled = false; }

                            break;
                        case 26:
                            Canvas.SetTop(player1, 505);
                            Canvas.SetLeft(player1, 855);
                            if (viborg == 2) { balances1 = balances1 - viborgsum; buyb.IsEnabled = false; }

                            break;
                        case 27:
                            Canvas.SetTop(player1, 615);
                            Canvas.SetLeft(player1, 855);
                            balances1 = balances1 - 2000;
                            buyb.IsEnabled = false;


                            break;
                        case 28:
                            Canvas.SetTop(player1, 725);
                            Canvas.SetLeft(player1, 855);
                            if (spb == 2) { balances1 = balances1 - spbsum; buyb.IsEnabled = false; }

                            break;

                    }
                    balance1.Content = balances1.ToString();
                    imagechecker();


                    break;
                case 2:
                case 3:

                    turnplayer.Content = "Ход игрока 2";
                    turn = turn - 1;
                    
                    sum2 = sum2 + roll;
                    
                    if (sum2 > 28) { sum2 = sum2 - 28; balances2 += 1000; }

                    switch (sum2)
                    {
                        case 1:
                            Canvas.SetLeft(player2, 835);
                            Canvas.SetTop(player2, 855);
                            buyb.IsEnabled = false;
                            break;
                        case 2:
                            Canvas.SetLeft(player2, 735);
                            Canvas.SetTop(player2, 855);
                            if (kerch == 1) { balances2 = balances2 - kerchsum; buyb.IsEnabled = false; }



                            break;
                        case 3:
                            Canvas.SetLeft(player2, 625);
                            Canvas.SetTop(player2, 855);
                            balances2 = balances2 - 2000;
                            buyb.IsEnabled = false;

                            break;
                        case 4:
                            Canvas.SetLeft(player2, 515);
                            Canvas.SetTop(player2, 855);
                            if (bridge == 1) { balances2 = balances2 - bridgesum; buyb.IsEnabled = false; }

                            break;
                        case 5:
                            Canvas.SetLeft(player2, 405);
                            Canvas.SetTop(player2, 855);
                            if (yalta == 1) { balances2 = balances2 - yaltasum; buyb.IsEnabled = false; }

                            break;
                        case 6:
                            Canvas.SetLeft(player2, 295);
                            Canvas.SetTop(player2, 855);

                            Random rndchance = new Random();
                            int randomNumberChance = rndchance.Next(-2000, 2001);
                            balances2 = balances2 - randomNumberChance;
                            buyb.IsEnabled = false;

                            break;
                        case 7:
                            Canvas.SetLeft(player2, 185);
                            Canvas.SetTop(player2, 855);
                            if (sev == 1) { balances2 = balances2 - sevsum; buyb.IsEnabled = false; }

                            break;
                        case 8:
                            Canvas.SetLeft(player2, 75);
                            Canvas.SetTop(player2, 855);
                            turn = turn - 1;
                            buyb.IsEnabled = false;
                            break;
                        case 9:
                            Canvas.SetTop(player2, 715);
                            Canvas.SetLeft(player2, 50);
                            if (sochi == 1) { balances2 = balances2 - sochisum; buyb.IsEnabled = false; }

                            break;
                        case 10:
                            Canvas.SetTop(player2, 605);
                            Canvas.SetLeft(player2, 50);

                            balances2 = balances2 - 1000;
                            buyb.IsEnabled = false;

                            break;
                        case 11:
                            Canvas.SetTop(player2, 495);
                            Canvas.SetLeft(player2, 50);
                            if (tuapse == 1) { balances2 = balances2 - tuapsesum; buyb.IsEnabled = false; }

                            break;
                        case 12:
                            Canvas.SetTop(player2, 385);
                            Canvas.SetLeft(player2, 50);
                            if (road == 1) { balances2 = balances2 - roadsum; buyb.IsEnabled = false; }

                            break;
                        case 13:
                            Canvas.SetTop(player2, 275);
                            Canvas.SetLeft(player2, 50);
                            if (tuapse == 1) { balances2 = balances2 - tuapsesum; buyb.IsEnabled = false; }

                            break;
                        case 14:
                            Canvas.SetTop(player2, 165);
                            Canvas.SetLeft(player2, 50);
                            
                            Random rndchance3 = new Random();
                            int randomNumberChance3 = rndchance3.Next(-2000, 2001);
                            balances2 = balances2 - randomNumberChance3;
                            buyb.IsEnabled = false;

                            break;
                        case 15:
                            Canvas.SetTop(player2, 55);
                            Canvas.SetLeft(player2, 50);
                            buyb.IsEnabled = false;
                            break;
                        case 16:
                            Canvas.SetTop(player2, 55);
                            Canvas.SetLeft(player2, 185);
                            if (msk == 1) { balances2 = balances2 - msksum; buyb.IsEnabled = false; }


                            break;
                        case 17:
                            Canvas.SetTop(player2, 55);
                            Canvas.SetLeft(player2, 295);

                            Random rndchance1 = new Random();
                            int randomNumberChance1 = rndchance1.Next(-2000, 2001);
                            balances2 = balances2 - randomNumberChance1;
                            buyb.IsEnabled = false;

                            break;
                        case 18:
                            Canvas.SetTop(player2, 55);
                            Canvas.SetLeft(player2, 405);
                            if (krasnogorsk == 1) { balances2 = balances2 - krasnogorsksum; buyb.IsEnabled = false; }

                            break;
                        case 19:
                            Canvas.SetTop(player2, 55);
                            Canvas.SetLeft(player2, 515);
                            if (port == 1) { balances2 = balances2 - portsum; buyb.IsEnabled = false; }

                            break;
                        case 20:
                            Canvas.SetTop(player2, 55);
                            Canvas.SetLeft(player2, 625);
                            if (balachiha == 1) { balances2 = balances2 - balachihasum; buyb.IsEnabled = false; }

                            break;
                        case 21:
                            Canvas.SetTop(player2, 55);
                            Canvas.SetLeft(player2, 735);

                            Random rndchance2 = new Random();
                            int randomNumberChance2 = rndchance2.Next(1000, 2001);
                            balances2 = balances2 + randomNumberChance2;
                            buyb.IsEnabled = false;

                            break;
                        case 22:
                            Canvas.SetTop(player2, 55);
                            Canvas.SetLeft(player2, 855);
                            buyb.IsEnabled = false;

                            break;
                        case 23:
                            Canvas.SetTop(player2, 175);
                            Canvas.SetLeft(player2, 855);


                            balances2 = balances2 + 1500;
                           
                            buyb.IsEnabled = false;

                            break;
                        case 24:
                            Canvas.SetTop(player2, 285);
                            Canvas.SetLeft(player2, 855);
                            if (kirovsk == 1) { balances2 = balances2 - kirovsksum; buyb.IsEnabled = false; }

                            break;
                        case 25:
                            Canvas.SetTop(player2, 395);
                            Canvas.SetLeft(player2, 855);
                            if (airport == 1) { balances2 = balances2 - airportsum; buyb.IsEnabled = false; }

                            break;
                        case 26:
                            Canvas.SetTop(player2, 505);
                            Canvas.SetLeft(player2, 855);
                            if (viborg == 1) { balances2 = balances2 - viborgsum; buyb.IsEnabled = false; }

                            break;
                        case 27:
                            Canvas.SetTop(player2, 615);
                            Canvas.SetLeft(player2, 855);
                            balances2 = balances2 - 2000;
                            buyb.IsEnabled = false;

                            balance2.Content = balances2.ToString();
                            break;
                        case 28:
                            Canvas.SetTop(player2, 725);
                            Canvas.SetLeft(player2, 855);
                            if (spb == 1) { balances2 = balances2 - spbsum; buyb.IsEnabled = false; }

                            break;

                    }
                   
                    balance2.Content = balances2.ToString();
                    imagechecker();
                    break;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            buyb.IsEnabled = false;
            
            switch (turn)
            {
                case 2: //1player
                    switch (sum1)
                    {
                        case 1:
                          
                            break;
                        case 2:
                            if (balances1-2200 > 0)
                            {
                                balances1 = balances1 - 2200;
                                kerch = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 3:
                           
                            break;
                        case 4:
                            if (balances1 - 2200 > 0)
                            {
                                balances1 = balances1 - 2000;
                                bridge = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 5:
                            if (balances1 - 2200 > 0)
                            {

                                balances1 = balances1 - 2200;
                                yalta = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 6:
                            
                            break;
                        case 7:
                            if (balances1 - 2400 > 0)
                            {
                                balances1 = balances1 - 2400;
                                sev = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }

                            break;
                        case 8:
                            //скип ход
                            break;
                        case 9:
                            if (balances1 - 2400 > 0)
                            {
                                balances1 = balances1 - 2400;
                                sochi = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }

                            break;
                        case 10:
                            
                            break;
                        case 11:
                            if (balances1 - 3000 > 0)
                            {
                                balances1 = balances1 - 3000;
                                tuapse = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 12:
                            if (balances1 - 2000 > 0)
                            {
                                balances1 = balances1 - 2000;
                                road = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }

                            break;
                        case 13:
                            if (balances1 - 3300 > 0)
                            {

                                balances1 = balances1 - 3300;
                                gelenzik = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }

                            break;
                        case 14:
                            
                            break;
                        case 15:
                            
                            break;
                        case 16:
                            if (balances1 - 4000 > 0)
                            {
                                balances1 = balances1 - 4000;
                                msk = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 17:
                            //
                            break;
                        case 18:
                            if (balances1 - 3500 > 0)
                            {
                                balances1 = balances1 - 3500;
                                krasnogorsk = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 19:
                            if (balances1 - 2000 > 0)
                            {

                                balances1 = balances1 - 2000;
                                port = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 20:
                            if (balances1 - 3300 > 0)
                            { 
                                balances1 = balances1 - 3300;
                            balachiha = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 21:
                            
                            break;
                        case 22:
                           
                            break;
                        case 23:
                            
                            break;
                        case 24:
                            if (balances1 - 1600 > 0)
                            {
                                balances1 = balances1 - 1600;
                                kirovsk = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 25:
                            if (balances1 - 2000 > 0)
                            {
                                balances1 = balances1 - 2000;
                                airport = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                            
                        case 26:
                            if (balances1 - 1900 > 0)
                            {
                                balances1 = balances1 - 1900;
                                viborg = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                            
                        case 27:
                            //
                            break;
                        case 28:
                            if (balances1 - 2200 > 0)
                            {

                                balances1 = balances1 - 2200;
                                spb = 1;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                    }
                    balance1.Content = balances1.ToString();
                    imagechecker();
                    break;






                case 1: //2player
                 
                    switch (sum2)
                    {
                        case 1:

                            break;
                        case 2:
                            if (balances2 - 2200 > 0)
                            {
                                balances2 = balances2 - 2200;
                                kerch = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса" ); }
                            break;
                        case 3:

                            break;
                        case 4:
                            if (balances2 - 2000 > 0)
                            {
                                balances2 = balances2 - 2000;
                                bridge = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 5:
                            if (balances2 - 2200 > 0)
                            {
                                balances2 = balances2 - 2200;
                                yalta = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }

                            break;
                        case 6:

                            break;
                        case 7:
                            if (balances2 - 2400 > 0)
                            {
                                balances2 = balances2 - 2400;
                                sev = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 8:
                            //скип ход
                            break;
                        case 9:
                            if (balances2 - 3000 > 0)
                            {
                                balances2 = balances2 - 3000;
                                sochi = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 10:

                            break;
                        case 11:
                            if (balances2 - 3000 > 0)
                            {
                                balances2 = balances2 - 3000;
                                tuapse = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 12:
                            if (balances2 - 2000 > 0)
                            {
                                balances2 = balances2 - 2000;
                                road = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;  
                        case 13:
                            if (balances2 - 3300 > 0)
                            {
                                balances2 = balances2 - 3300;
                            gelenzik = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 14:

                            break;
                        case 15:

                            break;
                        case 16:
                            if (balances2 - 4000 > 0)
                            {
                                balances2 = balances2 - 4000;
                                msk = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 17:
                            //
                            break;
                        case 18:
                            if (balances2 - 3500 > 0)
                            {

                                balances2 = balances2 - 3500;
                                krasnogorsk = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 19:

                            if (balances2 - 2000 > 0)
                            {
                                balances2 = balances2 - 2000;
                                port = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 20:
                            if (balances2 - 3300 > 0)
                            {

                                balances2 = balances2 - 3300;
                                balachiha = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }
                            break;
                        case 21:

                            break;
                        case 22:

                            break;
                        case 23:

                            break;
                        case 24:
                            if (balances2 - 1600 > 0)
                            {
                                balances2 = balances2 - 1600;
                                kirovsk = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }

                            break;
                        case 25:
                            if (balances2 - 2000 > 0)
                            {
                                balances2 = balances2 - 2000;
                                airport = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }

                            break;

                        case 26:
                            if (balances2 - 1900 > 0)
                            {
                                balances2 = balances2 - 1900;
                                viborg = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }

                            break;

                        case 27:
                            //
                            break;
                        case 28:
                            if (balances2 - 2200 > 0)
                            {
                                balances2 = balances2 - 2200;
                                spb = 2;
                            }
                            else { MessageBox.Show("Не хватает баланса"); }

                            break;
                    }
                    balance2.Content = balances2.ToString();
                    imagechecker();
                    
                    break;
                   
            }
        }

        private void Kerchimage1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances1 = balances1 + kerchsum * 3;
            kerch = 0;
            balance1.Content = balances1.ToString();
            imagechecker();

        }

        private void Yaltaimage1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            balances1 = balances1 + yaltasum * 3;
            yalta = 0;
            balance1.Content = balances1.ToString();

            imagechecker();

        }

        private void Sevimage1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances1 = balances1 + sevsum * 3;
            sev = 0;
            balance1.Content = balances1.ToString();

            imagechecker();

        }
        private void Sochiimage1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances1 = balances1 + sochisum * 3;
            sochi = 0;
            balance1.Content = balances1.ToString();

            imagechecker();

        }
        private void timage1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances1 = balances1 + tuapsesum * 3;
            tuapse = 0;
            balance1.Content = balances1.ToString();

            imagechecker();

        }
        private void gelenzikimage1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances1 = balances1 + gelenziksum * 3;
            gelenzik = 0;
            balance1.Content = balances1.ToString();

            imagechecker();

        }

        private void mskimage1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances1 = balances1 + msksum * 3;
            msk = 0;
            balance1.Content = balances1.ToString();

            imagechecker();
        }

        private void krasnogorskimage1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances1 = balances1 + krasnogorsksum * 3;
            krasnogorsk = 0;
            balance1.Content = balances1.ToString();
        
            imagechecker();

        }

        private void balachixaimage1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances1 = balances1 + balachihasum * 3;
            balachiha = 0;
            balance1.Content = balances1.ToString();

            imagechecker();
        }

        private void kirovskimage1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances1 = balances1 + kirovsksum * 3;
            kirovsk = 0;
            balance1.Content = balances1.ToString();

            imagechecker();
        }
        private void viborggimage1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            balances1 = balances1 + viborgsum * 3;
            viborg = 0;
            balance1.Content = balances1.ToString();

            imagechecker();
        }

        private void sapbimage1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances1 = balances1 + spbsum * 3;
            spb = 0;
            balance1.Content = balances1.ToString();

            imagechecker();
        }

        private void Kerchimage2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
            balances2 = balances2 + kerchsum * 3;
            kerch = 0;
            balance2.Content = balances2.ToString();

            imagechecker();
        }

        private void Yaltaimage2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            balances2 = balances2 + yaltasum * 3;
            yalta = 0;
            balance2.Content = balances2.ToString();

            imagechecker();

        }

        private void Sevimage2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances2 = balances2 + sevsum * 3;
            sev = 0;
            balance1.Content = balances2.ToString();

            imagechecker();

        }
        private void Sochiimage2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances2 = balances2 + sochisum * 3;
            sochi = 0;
            balance1.Content = balances2.ToString();

            imagechecker();

        }
        private void timage2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances2 = balances2 + tuapsesum * 3;
            tuapse = 0;
            balance2.Content = balances2.ToString();

            imagechecker();

        }
        private void gelenzikimage2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances1 = balances2 + gelenziksum * 3;
            gelenzik = 0;
            balance2.Content = balances2.ToString();

            imagechecker();

        }

        private void mskimage2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances2 = balances2 + msksum * 3;
            msk = 0;
            balance2.Content = balances2.ToString();

            imagechecker();
        }

        private void krasnogorskimage2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances2 = balances2 + krasnogorsksum * 3;
            krasnogorsk = 0;
            balance2.Content = balances2.ToString();

            imagechecker();

        }

        private void balachixaimage2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances2 = balances2 + balachihasum * 3;
            balachiha = 0;
            balance2.Content = balances2.ToString();

            imagechecker();
        }

        private void kirovskimage2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances2 = balances2 + kirovsksum * 3;
            kirovsk = 0;
            balance2.Content = balances2.ToString();

            imagechecker();
        }
        private void viborggimage2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            balances2 = balances2 + viborgsum * 3;
            viborg = 0;
            balance2.Content = balances2.ToString();

            imagechecker();
        }

        private void sapbimage2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            balances2 = balances2 + spbsum * 3;
            spb = 0;
            balance2.Content = balances2.ToString();

            imagechecker();
        }



        public void imagechecker()
        {
            if (kerch == 0) { Kerchimage1.Visibility = Visibility.Hidden; Kerchimage2.Visibility = Visibility.Hidden;}
            else if (kerch == 1) { Kerchimage1.Visibility = Visibility.Visible; Kerchimage2.Visibility = Visibility.Hidden; }
            else if (kerch == 2) { Kerchimage2.Visibility = Visibility.Visible; Kerchimage1.Visibility = Visibility.Hidden; }

            if (yalta == 0) { Yaltaimage1.Visibility = Visibility.Hidden; Yaltaimage2.Visibility = Visibility.Hidden; }
            else if (yalta == 1) { Yaltaimage1.Visibility = Visibility.Visible; Yaltaimage2.Visibility = Visibility.Hidden; }
            else if (yalta == 2) { Yaltaimage2.Visibility = Visibility.Visible; Yaltaimage1.Visibility = Visibility.Hidden; }

            if (sev == 0) { Sevimage1.Visibility = Visibility.Hidden; Sevimage2.Visibility = Visibility.Hidden; }
            else if (sev == 1) { Sevimage1.Visibility = Visibility.Visible; Sevimage2.Visibility = Visibility.Hidden; }
            else if (sev == 2) { Sevimage2.Visibility = Visibility.Visible; Sevimage1.Visibility = Visibility.Hidden; }

            if (sochi == 0) { Sochiimage1.Visibility = Visibility.Hidden; Sochiimage2.Visibility = Visibility.Hidden; }
            else if (sochi == 1) { Sochiimage1.Visibility = Visibility.Visible; Sochiimage2.Visibility = Visibility.Hidden; }
            else if (sochi == 2) { Sochiimage2.Visibility = Visibility.Visible; Sochiimage1.Visibility = Visibility.Hidden; }

            if (tuapse == 0) { timage1.Visibility = Visibility.Hidden; timage2.Visibility = Visibility.Hidden; }
            else if (tuapse == 1) { timage1.Visibility = Visibility.Visible; timage2.Visibility = Visibility.Hidden; }
            else if (tuapse == 2) { timage2.Visibility = Visibility.Visible; timage1.Visibility = Visibility.Hidden; }

            if (gelenzik == 0) { gelenzikimage1.Visibility = Visibility.Hidden; gelenzikimage2.Visibility = Visibility.Hidden; }
            else if (gelenzik == 1) { gelenzikimage1.Visibility = Visibility.Visible; gelenzikimage2.Visibility = Visibility.Hidden; }
            else if (gelenzik == 2) { gelenzikimage2.Visibility = Visibility.Visible; gelenzikimage1.Visibility = Visibility.Hidden; }

            if (msk == 0) { mskimage1.Visibility = Visibility.Hidden; mskimage2.Visibility = Visibility.Hidden; }
            else if (msk == 1) { mskimage1.Visibility = Visibility.Visible; mskimage2.Visibility = Visibility.Hidden; }
            else if (msk == 2) { mskimage2.Visibility = Visibility.Visible; mskimage1.Visibility = Visibility.Hidden; }

            if (krasnogorsk == 0) { krasnogorskimage1.Visibility = Visibility.Hidden; krasnogorskimage2.Visibility = Visibility.Hidden; }
            else if (krasnogorsk == 1) { krasnogorskimage1.Visibility = Visibility.Visible; krasnogorskimage2.Visibility = Visibility.Hidden; }
            else if (krasnogorsk == 2) { krasnogorskimage2.Visibility = Visibility.Visible; krasnogorskimage1.Visibility = Visibility.Hidden; }

            if (balachiha == 0) { balachixaimage1.Visibility = Visibility.Hidden; balachixaimage2.Visibility = Visibility.Hidden; }
            else if (balachiha == 1) { balachixaimage1.Visibility = Visibility.Visible; balachixaimage2.Visibility = Visibility.Hidden; }
            else if (balachiha == 2) { balachixaimage2.Visibility = Visibility.Visible; balachixaimage1.Visibility = Visibility.Hidden; }

            if (kirovsk == 0) { kirovskimage1.Visibility = Visibility.Hidden; kirovskimage2.Visibility = Visibility.Hidden; }
            else if (kirovsk == 1) { kirovskimage1.Visibility = Visibility.Visible; kirovskimage2.Visibility = Visibility.Hidden; }
            else if (kirovsk == 2) { kirovskimage2.Visibility = Visibility.Visible; kirovskimage1.Visibility = Visibility.Hidden; }

            if (viborg == 0) { viborggimage1.Visibility = Visibility.Hidden; viborggimage2.Visibility = Visibility.Hidden; }
            else if (viborg == 1) { viborggimage1.Visibility = Visibility.Visible; viborggimage2.Visibility = Visibility.Hidden; }
            else if (viborg == 2) { viborggimage2.Visibility = Visibility.Visible; viborggimage1.Visibility = Visibility.Hidden; }

            if (spb == 0) { sapbimage1.Visibility = Visibility.Hidden; sapbimage2.Visibility = Visibility.Hidden; }
            else if (spb == 1) { sapbimage1.Visibility = Visibility.Visible; sapbimage2.Visibility = Visibility.Hidden; }
            else if (spb == 2) { sapbimage2.Visibility = Visibility.Visible; sapbimage1.Visibility = Visibility.Hidden; }

            if (bridge == 0) { bridgeTextBox.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFCCDEA8")); }
            else if (bridge == 1) { bridgeTextBox.Background = new SolidColorBrush(Colors.Blue); }
            else if (bridge == 2) { bridgeTextBox.Background = new SolidColorBrush(Colors.Red); }

            if (road == 0) { roadTextBox.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFCCDEA8")); }
            else if (road == 1) { roadTextBox.Background = new SolidColorBrush(Colors.Blue); }
            else if (road == 2) { roadTextBox.Background = new SolidColorBrush(Colors.Red); }

            if (airport == 0) { airTextBox.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFCCDEA8")); }
            else if (airport == 1) { airTextBox.Background = new SolidColorBrush(Colors.Blue); }
            else if (airport == 2) { airTextBox.Background = new SolidColorBrush(Colors.Red); }

            if (port == 0) { PortTextBox.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFCCDEA8")); }
            else if (port == 1) { PortTextBox.Background = new SolidColorBrush(Colors.Blue); }
            else if (port == 2) { PortTextBox.Background = new SolidColorBrush(Colors.Red); }

            if (balances1 < 0 || balances2 < 0)
            {
                rollb.IsEnabled = false;
                buyb.IsEnabled = false;
                 
            }
           
           if (balances1 > 0 && turn ==2)
           {
               rollb.IsEnabled = true;
                

            }
            if (balances2 > 0 && turn == 1)
            {
                rollb.IsEnabled = true;
               

            }
            winnerchecker();
            sumbalance();
        }

        public void sumbalance() {

            kerchsum = 440;
            yaltasum = 440;
            sevsum = 480;
            if (sev==1 && kerch==1 && yalta == 1)
            {
             
                sevsum *= 3;
                yaltasum *= 3;
                kerchsum *= 3;
                

            }
            sochisum = 600;
            tuapsesum = 600;
            gelenziksum = 660;

            if (sochi == 1 && tuapse == 1 && gelenzik == 1)
            {

                sochisum *= 3;
                tuapsesum *= 3;
                gelenziksum *= 3;
                

            }
            msksum = 800;
            krasnogorsksum = 700;
            balachihasum = 660;

            if (msk == 1 && krasnogorsk == 1 && balachiha == 1)
            {

                msksum *= 3;
                krasnogorsksum *= 3;
                balachihasum *= 3;
                

            }

            kirovsksum = 320;
            viborgsum = 380;
            spbsum = 440;

            if (kirovsk == 1 && viborg == 1 && spb == 1)
            {

                kirovsksum *= 3;
                viborgsum *= 3;
                spbsum *= 3;
                

            }

        }


        public void winnerchecker() {

            
            if (balances1 <= 0 && kerch != 1 && yalta != 1 && sev != 1 && sochi != 1 && tuapse != 1 && sev != 1 && msk != 1 && sev!= 1 && balachiha !=1 && kirovsk != 1 && viborg != 1 &&  spb != 1)
            {
                VictoryWindow victoryWindow = new VictoryWindow("Игрок 2 победил",2);
                
                victoryWindow.ShowDialog();
                this.Close();
            }
            if (balances2 <= 0 && kerch != 2 && yalta != 2 && sev != 2 && sochi != 2 && tuapse != 2 && sev != 2 && msk != 2 && sev != 2 && balachiha != 2 && kirovsk != 2 && viborg != 2 && spb != 2)
            {
                VictoryWindow victoryWindow = new VictoryWindow("Игрок 1 победил",1);
                
                victoryWindow.ShowDialog();
                this.Close();
            }
        }




    }
}
