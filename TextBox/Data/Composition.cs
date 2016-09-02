using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TextBox.Data
{
    public class Composition : Glyph
    {
        public override void Draw(Graphics graphics)
        {
            throw new NotImplementedException();
        }

        public override Composition GetComposition()
        {
            return this;
        }
    }
}
