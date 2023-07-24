using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLNetEngine.Engine.Components
{
    public class Rectangle : Entity
    {
        public Rectangle(Vector2f size)
        {
            Set(new RectangleShape(size));
        }
    }
}
