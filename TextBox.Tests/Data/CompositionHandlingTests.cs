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
    public class CompositionHandlingTests
    {
        [Test]
        public void ChecksIfGetCompositeRetrunsReferenceForColumnComposition()
        {
           //arrange
           Glyph column = new Column();

            //act
            Glyph actualResult = column.GetComposition();

            //assert
            Glyph expectedResult = column;
            Assert.AreSame(expectedResult, actualResult);
        }

        [Test]
        public void ChecksIfGetCompositeRetrunsReferenceForRowComposition()
        {
            //arrange
            Glyph row = new Row();

            //act
            Glyph actualResult = row.GetComposition();

            //assert
            Glyph expectedResult = row;
            Assert.AreSame(expectedResult, actualResult);
        }

        [Test]
        public void ChecksIfGetCompositeRetrunsNullReferenceForOneCharacter()
        {
            //arrange
            Glyph character = new Character('a');

            //act
            Glyph actualResult = character.GetComposition();

            //assert
            Glyph expectedResult = null;
            Assert.AreSame(expectedResult, actualResult);
        }

        [Test]
        public void ChecksIfGetCompositeRetrunsNullReferenceForOnePolygon()
        {
            //arrange
            Glyph polygon = new Polygon();

            //act
            Glyph actualResult = polygon.GetComposition();

            //assert
            Glyph expectedResult = null;
            Assert.AreSame(expectedResult, actualResult);
        }

        [Test]
        public void ChecksIfGetCompositeRetrunsNullReferenceForOneRectangle()
        {
            //arrange
            Glyph rectangle = new Rect();

            //act
            Glyph actualResult = rectangle.GetComposition();

            //assert
            Glyph expectedResult = null;
            Assert.AreSame(expectedResult, actualResult);
        }
    }
}
