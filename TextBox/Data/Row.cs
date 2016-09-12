using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using TextBox.Utils;

namespace TextBox.Data
{
    public class Row : Composition
    {
        public Row() {}

        public Row(Compositor compositor) : base(compositor) {}

        public override void Draw(Graphics graphics)
        {
            throw new NotImplementedException();
        }
    }
}
