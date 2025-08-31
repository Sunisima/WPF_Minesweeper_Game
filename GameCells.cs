using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace WPF_Minesweeper_Game
{
    public class Cell
    {
        //– Har properties som: Row, Col, IsAMine, IsFlagged, IsRevealed, AdjacentMines.
        //Kan ændre tilstand(blive afsløret, sættes flag på).

        // Variabler / properties
        public int Row { get; }
        public int Col { get; }
        public bool IsAMine { get; set; }
        public bool IsFlagged { get; set; }
        public bool IsRevealed { get; set; }
        //Holds the number of mines around the cell (0-8)
        public int MinesAroundCell { get; set; }

        // Constructor
        public Cell(int row, int col)
        {
            // TODO: gem row/col
            // TODO: init IsMine/IsFlagged/IsRevealed = false
        }


    }
}
