﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TextBox.Data
{
    public abstract class Glyph
    {
        public abstract void Draw(Graphics graphics);
    }
}
