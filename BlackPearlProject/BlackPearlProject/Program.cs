using System;

namespace BlackPearlProject
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (BlackPearlGame game = new BlackPearlGame())
            {
                game.Run();
            }
        }
    }
#endif
}

