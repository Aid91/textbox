using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TextBox.Data
{
    public class Composition : Glyph
    {
        private List<Glyph> _glyphs = new List<Glyph>();

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
