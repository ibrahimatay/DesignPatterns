using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class Composite : Component
    {
        private List<Component> _childrenComponents = new List<Component>();

        public Composite(string name):base(name)
        {
            
        }

        public override void Add(Component component)
        {
            this._childrenComponents.Add(component);
        }

        public override void Remove(Component component)
        {
            this._childrenComponents.Remove(component);
        }

        public override void Display(int depth)
        {
            foreach (var component in _childrenComponents)
            {
                component.Display(1)
            }
        }
    }
}