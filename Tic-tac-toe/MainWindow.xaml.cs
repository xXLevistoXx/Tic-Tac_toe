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
using System.Windows.Shell;

namespace Tic_tac_toe
{

    public partial class MainWindow : Window
    {
        public string player_f = "X";
        public string pc_f = "O";
        public List<Button> buttons= new List<Button>();
        public int count = 0;
        public List<int> steps = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void But_NG_Click(object sender, RoutedEventArgs e)
        {
            buttons.Add(But1);
            buttons.Add(But2);
            buttons.Add(But3);
            buttons.Add(But4);
            buttons.Add(But5);
            buttons.Add(But6);
            buttons.Add(But7);
            buttons.Add(But8);
            buttons.Add(But9);
            foreach(Button but in buttons)
            {
                but.IsEnabled = true;
                but.Content = "";
            }
            if (count % 2 == 0)
            {
                player_f = "X";
                pc_f = "O";
            }
            else
            {
                player_f = "O";
                pc_f = "X";
            }
            steps.Clear();
            fighWinner.Content = "";
            fighWinner.Content = "You play for: " + player_f;  
            count += 1;        
            endGame();
            Robot();
        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            if (But1.Content != null)
            {
                But1.Content = player_f;
                But1.IsEnabled = false;
                endGame();
                Robot();
                endGame();
            }
        }

        private void But2_Click(object sender, RoutedEventArgs e)
        {
            if (But2.Content != null)
            {
                But2.Content = player_f;
                But2.IsEnabled = false;
                steps.Add(1);
                endGame();
                Robot();
                endGame();
            }
        }

        private void But3_Click(object sender, RoutedEventArgs e)
        {
            if (But3.Content != null)
            {
                But3.Content = player_f;
                But3.IsEnabled = false;
                steps.Add(1);
                endGame();
                Robot();
                endGame();
            }
        }

        private void But4_Click(object sender, RoutedEventArgs e)
        {
            if (But4.Content != null)
            {
                But4.Content = player_f;
                But4.IsEnabled = false;
                steps.Add(1);
                endGame();
                Robot();
            }
        }

        private void But5_Click(object sender, RoutedEventArgs e)
        {
            if (But5.Content != null)
            {
                But5.Content = player_f;
                But5.IsEnabled = false;
                steps.Add(1);
                endGame();
                Robot();
                endGame();
            }
        }

        private void But6_Click(object sender, RoutedEventArgs e)
        {
            if (But6.Content != null)
            {
                But6.Content = player_f;
                But6.IsEnabled = false;
                steps.Add(1);
                endGame();
                Robot();
                endGame();
            }
        }

        private void But7_Click(object sender, RoutedEventArgs e)
        {
            if (But7.Content != null)
            {
                But7.Content = player_f;
                But7.IsEnabled = false;
                endGame();
                Robot();
                endGame();
            }
        }

        private void But8_Click(object sender, RoutedEventArgs e)
        {
            if (But8.Content != null)
            {
                But8.Content = player_f;
                But8.IsEnabled = false;
                steps.Add(1);
                endGame();
                Robot();
                endGame();
            }
        }

        private void But9_Click(object sender, RoutedEventArgs e)
        {
            if (But9.Content != null)
            {
                But9.Content = player_f;
                But9.IsEnabled = false;
                steps.Add(1);
                endGame();
                Robot();
                endGame();
            }
        }
        private void Robot()
        {
            Random rand = new Random();
            bool isWorking = true;
            while (isWorking)
            {
                int rStep = rand.Next(1, 9);
                switch (rStep)
                {
                    case 1:
                        if (But1.Content == "")
                        {
                            But1.Content = pc_f;
                            steps.Add(1);
                            But1.IsEnabled = false;
                            isWorking = false;
                        }
                        break;
                    case 2:
                        if (But2.Content == "")
                        {
                            But2.Content = pc_f;
                            steps.Add(1);
                            But2.IsEnabled = false;
                            isWorking = false;
                        }
                        break;
                    case 3:
                        if (But3.Content == "")
                        {
                            But3.Content = pc_f;
                            steps.Add(1);
                            But3.IsEnabled = false;
                            isWorking = false;
                        }
                        break;
                    case 4:
                        if (But4.Content == "")
                        {
                            But4.Content = pc_f;
                            steps.Add(1);
                            But4.IsEnabled = false;
                            isWorking = false;
                        }
                        break;
                    case 5:
                        if (But5.Content == "")
                        {
                            But5.Content = pc_f;
                            steps.Add(1);
                            But5.IsEnabled = false;
                            isWorking = false;
                        }
                        break;
                    case 6:
                        if (But6.Content == "")
                        {
                            But6.Content = pc_f;
                            steps.Add(1);
                            But6.IsEnabled = false;
                            isWorking = false;
                        }
                        break;
                    case 7:
                        if (But7.Content == "")
                        {
                            But7.Content = pc_f;
                            steps.Add(1);
                            But7.IsEnabled = false;
                            isWorking = false;
                        }
                        break;
                    case 8:
                        if (But8.Content == "")
                        {
                            But8.Content = pc_f;
                            steps.Add(1);
                            But8.IsEnabled = false;
                            isWorking = false;
                        }
                        break;
                    case 9:
                        if (But9.Content == "")
                        {
                            But9.Content = pc_f;
                            steps.Add(1);
                            But9.IsEnabled = false;
                            isWorking = false;
                        }
                        break;
                }
                
            }
        }
        private void endGame()
        {
            if (steps.Count == 8)
            {
                fighWinner.Content = "There is no winner";
            }
            else
            {
                if (But1.Content == But2.Content && But2.Content == But3.Content)
                {
                    winnerIs(But1);
                }
                if (But4.Content == But5.Content && But5.Content == But6.Content)
                {
                    winnerIs(But4);
                }
                if (But7.Content == But8.Content && But8.Content == But9.Content)
                {
                    winnerIs(But7);
                }
                if (But1.Content == But4.Content && But4.Content == But7.Content)
                {
                    winnerIs(But1);
                }
                if (But2.Content == But5.Content && But5.Content == But8.Content)
                {
                    winnerIs(But2);
                }
                if (But3.Content == But6.Content && But6.Content == But9.Content)
                {
                    winnerIs(But3);
                }
                if (But1.Content == But5.Content && But5.Content == But9.Content)
                {
                    winnerIs(But1);
                }
                if (But3.Content == But5.Content && But5.Content == But7.Content)
                {
                    winnerIs(But3);
                }
            }
           
        }
        private void winnerIs(Button but)
        {
            if (but.Content != "")
            {
                if (but.Content == "O")
                {
                    fighWinner.Content = "Winner: O";
                    d();
                }
                else 
                {
                    fighWinner.Content = "Winner: X";
                    d();
                }
            }

        }
        private void d()
        {
            foreach(Button but in buttons)
            {
                but.IsEnabled = false;
                
            }
        }
    }
}
