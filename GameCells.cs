namespace WPF_Minesweeper_Game
{
    public class GameCells
    {
        public int Row { get; }
        public int Col { get; }
        public bool IsAMine { get; set; }
        public bool IsRevealed { get; set; }
        //Holds the number of mines around the cell (0-8)
        public int MinesAroundCell { get; set; }


        // Initializes the cell with its row and column position.
        // Sets IsAMine and IsRevealed to false at the beginning of the game.
        public GameCells(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            IsAMine = false;
            IsRevealed = false;
        }


    }
}
