using SFML.Graphics;
using SFML.Window;
using System;

namespace Game01Drawing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            new Game().GameMain();

        }
    }
}