using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using TextBox.Utils;

namespace TextBox.Data
{
    public class Composition : Glyph
    {
        private readonly List<Glyph> _glyphs = new List<Glyph>();

        private Compositor _compositor;

        public Composition() {}

        public Composition(Compositor compositor)
        {
            _compositor = compositor;
        }

        public override void Draw(Graphics graphics)
        {
            throw new NotImplementedException();
        }

        public override void Add(Glyph glyph)
        {
            glyph.SetParent(this);
            _glyphs.Add(glyph);
        }

        public override void Remove(Glyph glyph)
        {
            glyph?.SetParent(null);

            if (_glyphs.Contains(glyph))
            {
                _glyphs.Remove(glyph);
            }
        }

        public override void Insert(Glyph glyph, int index)
        {
            _glyphs.Insert(index, glyph);
        }

        public override Glyph Child(int i)
        {
            if (i <= _glyphs.Count - 1)
            {
                return _glyphs[i];
            }
            return base.Child(i);
        }

        public override Composition GetComposition()
        {
            return this;
        }

        public override RectangleF GetBounds()
        {
            throw new NotImplementedException();
        }
    }
}
