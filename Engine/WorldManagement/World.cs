using SFML.Graphics;
using SFMLNetEngine.Engine.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLNetEngine.Engine.WorldManagement
{
    public class World
    {
        public readonly string name;
        public readonly GameObject[] objects;
        public readonly List<Entity> entities = new List<Entity>();

        public World(GameObject[] objects, string name) 
        {
            this.objects = objects;
            this.name = name;
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i].HasComponent<Entity>())
                {
                    entities.Add(objects[i].GetComponent<Entity>());
                }
            }
        }

        public GameObject? Find(string name)
        {
            for(int i = 0; i < objects.Length; i++)
            {
                if (objects[i].name == name)
                {
                    return objects[i];
                }
            }

            return null;
        }

        public void Update()
        {
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].Update();
            }
        }

        public void Render(in RenderWindow window)
        {
            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].drawable != null)
                {
                    window.Draw(entities[i].drawable);
                }
            }
        }
    }
}
