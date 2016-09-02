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
    public class GlyphCompositeParentHandling
    {
        [Test]
        public void SetParentToTheCharaterIfItIsAddedToComposition()
        {
            //arrange
            Glyph composition = new Composition();
            Glyph character = new Character();

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
            Glyph rectangle = new Rectangle();

            //act
            composition.Add(rectangle);
            Glyph actualResult = rectangle.GetParent();

            //assert
            Glyph expectedResult = composition;
            Assert.AreSame(expectedResult, actualResult);
        }

        [Test]
        public void ChangeParentOfTheCharacterIfItIsRemovedFromComposition()
        {
            //arrange
            Glyph composition = new Composition();
            Glyph character = new Character();
          
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
            Glyph rectangle = new Rectangle();

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
