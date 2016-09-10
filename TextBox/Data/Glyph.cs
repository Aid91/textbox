using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TextBox.Data
{
    public abstract class Glyph
    {
        private Glyph _parent = null;

        public abstract void Draw(Graphics graphics);

        public virtual void Add(Glyph glyph) { }

        public virtual void Remove(Glyph glyph) { }

        public Glyph GetParent()
        {
            return _parent;
        }

        public void SetParent(Glyph parent)
        {
            _parent = parent;
        }

        public virtual Composition GetComposition()
        {
            return null;
        }

        public abstract RectangleF GetBounds();
    }
}
