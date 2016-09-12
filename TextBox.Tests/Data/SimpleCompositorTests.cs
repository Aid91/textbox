using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBox.Data;

namespace TextBox.Tests.Data
{
    [TestFixture]
    public class SimpleCompositorTests
    {
        [Test]
        public void TestMethod()
        {
            //arrange
            Composition column = new Column();
            Glyph characterA = new Character('a');
            Glyph characterB = new Character('b');

            //act
            column.Insert(characterA, 0);
            column.Insert(characterB, 1);

            //assert
            float expectedWidth = characterA.GetBounds().Width + characterB.GetBounds().Width;
            float actualWidth = column.GetBounds().Width;

            Assert.AreEqual(expectedWidth, actualWidth);
        }
    }
}
