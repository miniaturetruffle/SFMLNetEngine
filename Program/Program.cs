﻿using SFML.Graphics;
using SFML.System;
using SFML.Window;
using SFMLNetEngine.Engine;
using SFMLNetEngine.Engine.Components;
using SFMLNetEngine.Engine.WorldManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        public static string PROGRAM_TITLE = "Program";
        public static Vector2u WINDOW_SIZE = new Vector2u(1920, 1080);
        public static Styles VIDEO_STYLE = Styles.Close;

        public static void Run(out World main)
        {
            GameObject obj = new GameObject("main_object");
            obj.AddComponent(new Rectangle(new Vector2f(200, 200)));
            obj.position = new Vector2f(50, 50);


            main = new World(new GameObject[] {obj}, "Main");
        }

        public static void PreDraw()
        {

        }

        public static void Draw(in RenderWindow window)
        {
            GameObject? found = WorldManager.currentWorld.Find("main_object");
            if (found != null)
                found.position += new Vector2f(1f, 0f);
        }

        public static void PostDraw()
        {

        }
    }
}
