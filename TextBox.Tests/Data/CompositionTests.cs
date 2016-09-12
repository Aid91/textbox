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
    public class CompositionTests
    {
        [Test]
        public void ReturnsNonNullElementWhenThereIsAChildOnTheGivenIndexOnColumn()
        {
            //arrange
            Composition column = new Column();
            Glyph character = new Character('a');

            //act
            column.Add(character);

            //assert
            Glyph expectedResult = character;
            Assert.AreSame(expectedResult, column.Child(0));
        }

        [Test]
        public void ReturnsNullElementWhenThereIsntAChildOnTheGivenIndexOnColumn()
        {
            //arrange
            Composition column = new Column();

            //assert
            Glyph expectedResult = null;
            Assert.AreSame(expectedResult, column.Child(0));
        }

        [Test]
        public void ReturnsNonNullElementWhenThereIsAChildOnTheGivenIndexOnRow()
        {
            //arrange
            Composition row = new Row();
            Glyph character = new Character('a');

            //act
            row.Add(character);

            //assert
            Glyph expectedResult = character;
            Assert.AreSame(expectedResult, row.Child(0));
        }

        [Test]
        public void ReturnsNullElementWhenThereIsntAChildOnTheGivenIndexOnRow()
        {
            //arrange
            Composition row = new Row();

            //assert
            Glyph expectedResult = null;
            Assert.AreSame(expectedResult, row.Child(0));
        }
    }
}
