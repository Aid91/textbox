using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextBox.Data;

namespace TextBox.Utils
{
    public class Compositor
    {
        protected Composition _composition;

        public void SetComposition(Composition composition)
        {
            _composition = composition;
        }

        public virtual void Compose()
        {
          
        }

    }
}
