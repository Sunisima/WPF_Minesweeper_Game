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
        //– Har properties som: Row, Col, IsMine, IsFlagged, IsRevealed, AdjacentMines.
        //Kan ændre tilstand(blive afsløret, sættes flag på).

        // Variabler / properties
        public int Row { get; }
        public int Col { get; }
        public bool IsAMine { get; set; }
        public bool IsFlagged { get; set; }
        public bool IsRevealed { get; set; }
        public int AdjacentMines { get; set; }

        // Constructor
        public Cell(int row, int col)
        {
            // TODO: gem row/col
            // TODO: init IsMine/IsFlagged/IsRevealed = false
        }


    }
}
