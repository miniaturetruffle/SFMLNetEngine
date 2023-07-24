using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.Window;
using SFML.System;
using SFML.Graphics;

using Program;
using SFMLNetEngine.Engine.WorldManagement;

namespace SFMLNetEngine.Engine
{
    public class Engine
    {
        public static void Main()
        {
            RenderWindow window = new RenderWindow(new VideoMode(Program.Program.WINDOW_SIZE.X, Program.Program.WINDOW_SIZE.Y), Program.Program.PROGRAM_TITLE);
            window.RequestFocus();
            window.Closed += Window_Closed;

            Program.Program.Run(out World main);
            WorldManager.Construct(new World[] { main });

            while(window.IsOpen)
            {
                Program.Program.PreDraw();
                window.Clear();
                window.DispatchEvents();
                Program.Program.Draw(in window);
                WorldManager.RenderCurrent(in window);
                window.Display();
                Program.Program.PostDraw();
            }
        }

        private static void Window_Closed(object? sender, EventArgs e)
        {
            Environment.Exit(0);
        }


    }
}
