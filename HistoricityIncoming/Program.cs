using System;
using Engine;
using HistoricityIncoming.Views;

namespace HistoricityIncoming
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new MainGame(new LabSceneView(), new ScreenSize(900, 600)))
                game.Run();
        }
    }
#endif
}
