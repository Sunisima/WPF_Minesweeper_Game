using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Minesweeper_Game
{
    public enum GameResult { Win, Lose }
    public enum GameStatus { Ready, Running, Won, Lost }

    class GameState
    {
        //Holder styr på: Ready, Running, Won, Lost (enum eller property).
        //Ved hvornår spillet slutter/vindes/tabes.

        public GameStatus Current { get; private set; }
        public bool FirstRevealDone { get; private set; }

        public bool IsOver => Current == GameStatus.Won || Current == GameStatus.Lost;
        public bool IsRunning => Current == GameStatus.Running;

        public void ResetAll()
        {
            // TRIN: Current = Ready, FirstRevealDone = false
        }

        public void StartNew()
        {
            // TRIN: Current = Running, FirstRevealDone = true
        }

        public void GameWon()
        {
            // TRIN: Current = Won
        }

        public void GameLost()
        {
            // TRIN: Current = Lost
        }


    }
}
