namespace WPF_Minesweeper_Game
{
    /// <summary>
    /// Holds all information about our board and cells within the board 
    /// and the actions to take when a cell is clicked
    /// </summary>
    class Board
    {
        //Rows on the minesweeper board
        public int Rows { get; } = 9;
        //Columns on the Minesweeper board
        public int Cols { get; } = 9;
        //Total mines to be placed on the board
        public int TotalMines { get; } = 11;
        //2D-array that holds all cells within the board (Rows and Cols)
        public GameCells[,] Cells { get; private set; }
        //Used to determine whether or not a player has revealed all cells with no mines
        public int RevealedSafeCells { get; private set; }
        //Random object for placing mines on board
        private readonly Random _rdnPosition = new Random();

        /// <summary>
        /// Creates a new board with 81 cells
        /// Resets counters (flag, revealed cells)
        /// Mines are placed in randomly
        /// Computes the number of neighbor mines for each cell
        /// Resets GameState to ready
        /// </summary>
        public void StartGame()
        {
            //Instansiates 2D array to hold 81 cells
            Cells = new GameCells[Rows, Cols];
            //Loops through every row/col combination and instansiates with at cell
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Cols; c++)
                {
                    Cells[r, c] = new GameCells(r, c);
                }
            }
            RevealedSafeCells = 0;
            PlaceMines();
            ComputeMinesAround();
        }

        public void RevealCell(int row, int col)
        {
            var cell = Cells[row, col];
            cell.IsRevealed = true;
        }

        /// <summary>
        /// Places 11 mines randomly
        /// </summary>
        private void PlaceMines()
        {
            int mineCount = 0; //Sets mines placed to zero

            do
            {
                int row = _rdnPosition.Next(9);
                int col = _rdnPosition.Next(9);

                if (Cells[row, col].IsAMine == false)
                {
                    mineCount++;
                    Cells[row, col].IsAMine = true;
                }               
            }
            while (mineCount < TotalMines);                       
        }

        // Loops through ever cell on the board and calculates the number of neighbor mines for each cell. 
        // The result (0-8) is saved in the MinesAroundCell property
        private void ComputeMinesAround()
        {            
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Cols; c++)
                {
                    int mines = CountMinesAroundCell(r, c);
                    Cells[r, c].MinesAroundCell = mines;                    
                }
            }
        }

        /// <summary>
        /// Counts how many of the neighbor cells around the given cell is a mine
        /// Does not count the given cell itself.
        /// </summary>
        /// <param name="row">the row of the cell to check for neighbouring mines</param>
        /// <param name="col">the column of the cell to check for neighbouring mines</param>
        /// <returns></returns>
        private int CountMinesAroundCell(int row, int col)
        {
            int mineCount = 0;
            
            for (int r = row - 1; r <= row + 1; r++)
            {
                for (int c = col - 1; c <= col + 1; c++)
                {
                    if(InBounds(r,c))
                    {
                        if(r == row && c == col)
                        {
                            continue;                            
                        }
                        if(Cells[r, c].IsAMine == true)
                        {
                            mineCount++;
                        }
                    }                 
                }
            }
            return mineCount;
        }

        /// <summary>
        /// Checking if cols and rows are within the bounds of the board
        /// </summary>
        /// <param name="row"> the specific row of the cell to check the bounds around </param>
        /// <param name="col"> the specific column of the cell to check the bounds around </param>
        /// <returns> true if it in within bounds </returns>
        private bool InBounds(int row, int col)
        {
            if(row >= 0 && row < Rows && col >= 0 && col < Cols)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}
