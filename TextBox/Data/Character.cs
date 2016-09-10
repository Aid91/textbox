using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextBox.Data
{
    public class Character : Glyph
    {
        private readonly char _character;

        private Font _font;

        public Font Font
        {
            get
            {
                return _font ?? Control.DefaultFont;
            }
            set { _font = value; }
        }

        public Character(Char character)
        {
            _character = character;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawString(_character.ToString(), Font, new SolidBrush(Color.Black), GetBounds());
        }

        public override RectangleF GetBounds()
        {
            SizeF size = TextRenderer.MeasureText(_character.ToString(), _font);
            return new RectangleF(0, 0, size.Width, size.Height);
        }
    }
}
