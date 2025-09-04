using System.Windows;
using System.Windows.Controls;

namespace WPF_Minesweeper_Game
{
    public partial class MinesweeperWindow : Window
    {
        private Board _board;
        public MinesweeperWindow()
        {
            InitializeComponent();

            _board = new Board();
            _board.StartGame();
            //Loops through 81 times and adds 81 buttons to my ug_GameBoard in UI giving them a specific color
            // And adding everyone to the same clickevent
            for (int i = 0; i < 81; i++)
            {
                var btn = new Button();
                { 
                    btn.Tag = i; 
                };
                btn.Click += GameBoardButton_Click;
                ug_GameBoard.Children.Add(btn);
            };
        }

        /// <summary>
        /// Loops through all buttons in the UI and updates their content based on the state of the cell.
        /// Shows a mine, a number or nothing.
        /// </summary>
        private void UpdateUI()
        {
            for (int i = 0; i < ug_GameBoard.Children.Count; i++)
            {
                var btn = ug_GameBoard.Children[i] as Button;
                int row = i / _board.Cols;
                int col = i % _board.Cols;
                var cell = _board.Cells[row, col];

                if (cell.IsRevealed)
                {
                    btn.IsEnabled = false;
                    if (cell.IsAMine)
                        btn.Content = "💣";
                    else if (cell.MinesAroundCell > 0)
                        btn.Content = cell.MinesAroundCell.ToString();
                    else
                        btn.Content = "";
                }
                else
                {
                    btn.IsEnabled = true;
                    btn.Content = ""; // skjult celle
                }
            }
        }


        /// <summary>
        /// Resets everything in the game and allows the user to start over
        /// </summary>
        /// <param name="sender"></param> the PlayAgain button
        /// <param name="e"></param> Resets everything
        private void btn_ResetGame_Click(object sender, RoutedEventArgs e)
        {
            _board = new Board();
            _board.StartGame();
            UpdateUI();
        }


        /// <summary>
        /// Find the row and column of the button that's pressed
        /// </summary>
        /// <param name="sender"></param> 
        /// <param name="e"></param>
        private void GameBoardButton_Click(object sender, RoutedEventArgs e)
        {
            var clickedButton = sender as Button;
            if (clickedButton == null) return;
            int buttonIndex = (int)clickedButton.Tag;
            int row = buttonIndex / _board.Cols;
            int col = buttonIndex % _board.Cols;

            _board.RevealCell(row, col);
            UpdateUI();
        }

    }
}