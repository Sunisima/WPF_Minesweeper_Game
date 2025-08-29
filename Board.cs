using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WPF_Minesweeper_Game
{
    class Board
    {
        //Ejer alle felter(GameField-objekter).
        //Har logik til at:
        //Placere miner(med din 0–8 regel)
        //Tælle nabo-miner(CountAdjacentMines)
        //Håndtere reveal/flag på felter.

        // Variabler / properties
        public int Rows { get; } = 9;
        public int Cols { get; } = 9;
        public int TotalMines { get; } = 11;

        public Cell[,] Cells { get; private set; }
        public int CountFlags { get; private set; }
        public int RevealedSafeCells { get; private set; }
        public GameState State { get; private set; } = new GameState();

        public int RemainingMines => TotalMines - CountFlags;

        // Metoder
        public void StartGame()
        {
            // GUARD: intet
            // TRIN: opret celler, nulstil tællere
            // TRIN: placer miner
            // TRIN: beregn MinesAroundCell
            // SIDE-EFFEKT: spillet går i Ready
        }

        public void ResetGame()
        {
            // TRIN: nulstil Cells, CountFlags, RevealedSafeCells
            // TRIN: reset GameState
            // TRIN: nulstil timer
            // SIDE-EFFEKT: nyt spil startes
        }

        public void EndGame(GameResult result)
        {
            // GUARD: intet
            // TRIN: hvis Win → GameState.Win()
            // TRIN: hvis Lose → GameState.Lose()
            // SIDE-EFFEKT: stop timer, afslør miner
        }

        public void RevealCell(int row, int col)
        {
            // GUARD: hvis spil slut, cell er flagget eller allerede afsløret → return
            // Venstre museklik til reveal af felter.
            // TRIN: hvis mine → EndGame(Lose)
            // TRIN: ellers afslør cell
            // TRIN: hvis MinesAroundCell == 0 → flood-fill naboer (recursion)
            // STOP-BETINGELSE: hvis alle sikre felter afsløret → EndGame(Win)
        }

        public void ToggleFlag(int row, int col)
        {
            // GUARD: hvis spil slut eller cell afsløret → return
            //Højre museklik bruges til flag/fjern flag
            // TRIN: hvis allerede flagget → fjern flag
            // TRIN: ellers → sæt flag
            // SIDE-EFFEKT: opdater FlagCount
        }

        private void PlaceMines()
        {
            // TRIN: læg TotalMines miner på tomme celler
        }

        // // Går igennem alle celler i brættet og beregner for hver celle,
        // hvor mange af de 8 naboer der er miner.
        // Resultatet (0–8) gemmes i cellens MinesAroundCell property.
        private void ComputeMinesAround()
        {
            // TRIN: for hver cell → CountMinesAroundCell(row,col)
            // SIDE-EFFEKT: sæt MinesAroundCell på hver cell
        }


        private int CountMinesAroundCell(int row, int col)
        {
            // TRIN: tæl naboer med IsAMine
            // RETURN: tal fra 0–8
            return 0;
        }

        private bool InBounds(int row, int col)
        {
            // TRIN: check 0 <= row < Rows og 0 <= col < Cols
            return false;
        }

        private bool IsAWin()
        {
            // TRIN: tjek om RevealedSafeCells == Rows*Cols - TotalMines
            // RETURN: true/false
            return false;
        }
    }
}
