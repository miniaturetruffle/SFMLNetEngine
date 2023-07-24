using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLNetEngine.Engine.WorldManagement
{
    public static class WorldManager
    {
        public static World[] worlds;

        public static int worldIndex;

        public static void Construct(World[] worldsToSet)
        {
            worlds = worldsToSet;
        }

        public static void RenderCurrent(in RenderWindow window)
        {
            worlds[worldIndex].Render(in window);
        }

        public static void Load(string name)
        {
            for (int i = 0; i < worlds.Length; i++)
            {
                if (worlds[i].name == name)
                {
                    worldIndex = i;
                }
            }
        }
    }
}
