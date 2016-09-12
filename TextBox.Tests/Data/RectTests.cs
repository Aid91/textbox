using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBox.Data;

namespace TextBox.Tests.Data
{
    [TestFixture]
    public class RectTests
    {
        [Test]
        public void ReturnsTheRealBoundsOnGetBoundsCallTest()
        {
            //arrange
            Glyph rect = new Rect(0,0,10,20);

            //act
            RectangleF bounds = rect.GetBounds();

            //assert
            Assert.AreEqual(0, bounds.X);
            Assert.AreEqual(0, bounds.Y);
            Assert.AreEqual(10, bounds.Width);
            Assert.AreEqual(20, bounds.Height);
        }
    }
}
