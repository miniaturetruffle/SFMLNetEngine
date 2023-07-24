using SFML.System;
using SFMLNetEngine.Engine.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLNetEngine.Engine
{
    public class GameObject
    {

        public readonly Vector2f position, scale;
        public readonly float rotation;

        public readonly List<Component> components;

        public string name;

        public GameObject(List<Component> components, Vector2f position, Vector2f scale, float rotation, string name) 
        {
            this.components = components;
            this.position = position;
            this.scale = scale;
            this.rotation = rotation;
            this.name = name;
        }

        public GameObject(string name)
        {
            this.components = new List<Component>();
            this.position = new Vector2f(0f, 0f);
            this.scale = new Vector2f(1f, 1f);
            this.rotation = 0f;
            this.name = name;
        }

        public void Start()
        {
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Start();
            }
        }

        public void Update()
        {
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Update();
            }
        }

        public void AddComponent(Component toAdd)
        {
            components.Add(toAdd);
        }
        public T GetComponent<T>() where T : Component
        {
            for (int i = 0; i < components.Count; i++)
            {
                if (components[i] is T)
                {
                    return (T)components[i];
                }
            }

            return null;
        }

        public bool HasComponent<T>() where T : Component
        {
            for (int i = 0; i < components.Count; i++)
            {
                if (components[i] is T)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
