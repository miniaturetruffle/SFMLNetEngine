using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLNetEngine.Engine.Components
{
    public class Entity : Component
    {
        public Drawable? drawable { get; private set; }
        public Transformable? transform { get; private set; }

        public Entity() {   }

        public void Set(Shape shape)
        {
            transform = shape;
            drawable = shape;
        }

        public void Set(Sprite sprite)
        {
            transform = sprite;
            drawable = sprite;
        }

        public override void Update()
        {
            if (transform != null)
            {
                transform.Position = attached.position;
                transform.Scale = attached.scale;
                transform.Rotation = attached.rotation;
            }
        }
    }
}
