using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.VisualStyles;
using TextBox.Data;

namespace TextBox.Utils
{
    public class SimpleCompositor : Compositor
    {
        public override void Compose()
        {
            int i = 0;
            int xLocation = 0;
            int yLocation = 0;
            while (true)
            {
                Glyph glyph = _composition.Child(i);
                if (glyph != null)
                {
                    glyph.Location = new Point(xLocation + (int) glyph.GetBounds().Width, yLocation);
                    xLocation += (int) glyph.GetBounds().Width;
                    ++i;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
