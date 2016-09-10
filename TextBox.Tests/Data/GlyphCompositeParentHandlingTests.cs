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
    public class GlyphCompositeParentHandlingTests
    {
        [Test]
        public void SetParentToTheCharaterIfItIsAddedToComposition()
        {
            //arrange
            Glyph composition = new Composition();
            Glyph character = new Character('a');

            //act
            composition.Add(character);
            Glyph actualResult = character.GetParent();

            //assert
            Glyph expectedResult = composition;
            Assert.AreSame(expectedResult, actualResult);
        }

        [Test]
        public void SetParentToThePolygonIfItIsAddedToComposition()
        {
            //arrange
            Glyph composition = new Composition();
            Glyph polygon = new Polygon();

            //act
            composition.Add(polygon);
            Glyph actualResult = polygon.GetParent();

            //assert
            Glyph expectedResult = composition;
            Assert.AreSame(expectedResult, actualResult);
        }

        [Test]
        public void SetParentToTheRectangleIfItIsAddedToComposition()
        {
            //arrange
            Glyph composition = new Composition();
            Glyph rectangle = new Rect();

            //act
            composition.Add(rectangle);
            Glyph actualResult = rectangle.GetParent();

            //assert
            Glyph expectedResult = composition;
            Assert.AreSame(expectedResult, actualResult);
        }

        [Test]
        public void SetParentToTheRowIfItIsAddedToComposition()
        {
            //arrange
            Glyph composition = new Composition();
            Glyph row = new Row();

            //act
            composition.Add(row);
            Glyph actualResult = row.GetParent();

            //assert
            Glyph expectedResult = composition;
            Assert.AreSame(expectedResult, actualResult);
        }

        [Test]
        public void SetParentToTheColumnIfItIsAddedToComposition()
        {
            //arrange
            Glyph composition = new Composition();
            Glyph column = new Column();

            //act
            composition.Add(column);
            Glyph actualResult = column.GetParent();

            //assert
            Glyph expectedResult = composition;
            Assert.AreSame(expectedResult, actualResult);
        }

        [Test]
        public void ChangeParentOfTheCharacterIfItIsRemovedFromComposition()
        {
            //arrange
            Glyph composition = new Composition();
            Glyph character = new Character('a');
          
            //act
            composition.Add(character);
            composition.Remove(character);
            Glyph actualResult = character.GetParent();

            //assert
            Glyph expectedResult = null;
            Assert.AreSame(expectedResult, actualResult);
        }

        [Test]
        public void ChangeParentOfThePolygonIfItIsRemovedFromComposition()
        {
            //arrange
            Glyph composition = new Composition();
            Glyph polygon = new Polygon();

            //act
            composition.Add(polygon);
            composition.Remove(polygon);
            Glyph actualResult = polygon.GetParent();

            //assert
            Glyph expectedResult = null;
            Assert.AreSame(expectedResult, actualResult);
        }

        [Test]
        public void ChangeParentOfTheRectangleIfItIsRemovedFromComposition()
        {
            //arrange
            Glyph composition = new Composition();
            Glyph rectangle = new Rect();

            //act
            composition.Add(rectangle);
            composition.Remove(rectangle);
            Glyph actualResult = rectangle.GetParent();

            //assert
            Glyph expectedResult = null;
            Assert.AreSame(expectedResult, actualResult);
        }
    }
}
