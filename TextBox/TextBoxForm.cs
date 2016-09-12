using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TextBox.Data;

namespace TextBox
{
    public partial class TextBoxForm : Form
    {
        public TextBoxForm()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Character character = new Character('c');
            character.Draw(e.Graphics);
            Rect rect = new Rect(20,0,50,20);
            rect.Draw(e.Graphics);
        }
    }
}
