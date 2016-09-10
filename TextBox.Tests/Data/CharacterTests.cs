using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TextBox.Data;
using System.Drawing;

namespace TextBox.Tests.Data
{
    [TestFixture]
    public class CharacterTests
    {
        [Test]
        public void ChecksIfGetBoundsReturnsProperValues()
        {
            //arrange
            Character character = new Character('a');
            character.Font = new Font("Arial", 8.0F);

            //act
            RectangleF result = character.GetBounds();

            //assert bottom
            Assert.AreEqual(0, result.X);
            Assert.AreEqual(0, result.Y);
            Assert.AreEqual(13, result.Width);
            Assert.AreEqual(14, result.Height);
        }
    }
}
