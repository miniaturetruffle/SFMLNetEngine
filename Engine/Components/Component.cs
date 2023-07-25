using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLNetEngine.Engine.Components
{
    public abstract class Component
    {
        public GameObject? attached { get; private set; }
        
        public void Assign(GameObject toAttach)
        {
            if (attached != null)
            {
                attached.RemoveComponent(this);
            }
            toAttach.AddComponent(this);
            attached = toAttach;
            
        }

        public void SetAttached(GameObject? toAttach)
        {
            attached = toAttach;
        }

        public virtual void Start() { }
        public virtual void Update() { }
    }
}
