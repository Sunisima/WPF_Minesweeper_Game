using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace WPF_Minesweeper_Game
{
    internal class Timer
    {
        //Starter/stopper tid.
        //Holder ElapsedSeconds(eller lignende).
        //Opdateres af en WPF-DispatcherTimer og evt.et Stopwatch.

        // Variabler
        private Stopwatch stopwatch;
        private DispatcherTimer dispatcherTimer;
        public int TimeElapsed { get; private set; }

        // Constructor
        public Timer()
        {
            // TRIN: initialiser stopwatch og dispatcherTimer
        }

        public void StartTimer()
        {
            // GUARD: hvis allerede kører → return
            // TRIN: start stopwatch og dispatcherTimer ved StartNew() fra GameState
        }

        public void StopTimer()
        {
            // TRIN: stop stopwatch og dispatcherTimer
        }

        public void ResetTimer()
        {
            // TRIN: nulstil stopwatch og TimeElapsed
        }

    }
}
