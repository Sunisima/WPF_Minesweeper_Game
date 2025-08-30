using System.Windows;
using System.Windows.Controls;

namespace WPF_Minesweeper_Game
{
    public partial class MinesweeperWindow : Window
    {
        public MinesweeperWindow()
        {
            InitializeComponent();

            //Loops through 81 times and adds 81 buttons to my ug_GameBoard in UI giving them a specific color
            // And adding everyone to the same clickevent
            for (int i = 0; i < 81; i++)
            {
                var btn = new Button();
                {
                    Style = (Style)FindResource("PlayButton");
                    Tag = i;
                }
                ;
                btn.Click += GameBoardButton_Click;
                ug_GameBoard.Children.Add(btn);
            }
            ;
        }

        /// <summary>
        /// Resets everything in the game and allows the user to start over
        /// </summary>
        /// <param name="sender"></param> the PlayAgain button
        /// <param name="e"></param> Resets everything
        private void btn_ResetGame_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Find the row and column of the button that's pressed
        /// </summary>
        /// <param name="sender"></param> 
        /// <param name="e"></param>
        private void GameBoardButton_Click(object sender, RoutedEventArgs e)
        {
            var clickedButton = sender as Button;
            if (clickedButton != null)
            {

                int buttonIndex = (int)clickedButton.Tag;

                int row = buttonIndex / 9;

                int col = buttonIndex % 9;
            }
        }
    }
}