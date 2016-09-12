using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TextBox.Data
{
    public class Rect : Glyph
    {
        private readonly Rectangle _rect = Rectangle.Empty;

        public Rect() { }

        public Rect(int x, int y, int width, int height)
        {
            _rect = new Rectangle(x, y, width, height);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(Pens.Black, _rect);
        }

        public override RectangleF GetBounds()
        {
            return _rect;
        }
    }
}
