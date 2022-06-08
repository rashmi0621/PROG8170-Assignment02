using NUnit.Framework;
using Assignment02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment02.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void GetLengthWithDefaultValuesTest()
        {
            Rectangle rectangle = new Rectangle();
            var result = rectangle.GetLength();
            Assert.AreEqual(1, result);
        }
        [Test]
        public void GetLengthWithInjectedValuesTest()
        {
            Rectangle rectangle = new Rectangle(3, 4);
            var result = rectangle.GetLength();
            Assert.AreEqual(3, result);
        }
        [Test]
        public void GetLengthWithNullValuesTest()
        {
            Rectangle rectangle = new Rectangle(null, null);
            var result = rectangle.GetLength();
            Assert.AreEqual(null, result);
        }


        [Test]
        public void GetWidthWithDefaultValuesTest()
        {
            Rectangle rectangle = new Rectangle();
            var result = rectangle.GetWidth();
            Assert.AreEqual(1, result);
        }
        [Test]
        public void GetWidthWithInjectedValuesTest()
        {
            Rectangle rectangle = new Rectangle(3, 4);
            var result = rectangle.GetWidth();
            Assert.AreEqual(4, result);
        }
        [Test]
        public void GetWidthWithNullValuesTest()
        {
            Rectangle rectangle = new Rectangle(null, null);
            var result = rectangle.GetWidth();
            Assert.AreEqual(null, result);
        }

        [Test]
        public void SetLengthWithDefaultValuesTest()
        {
            Rectangle rectangle = new Rectangle();
            var result = rectangle.SetLength(3);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void SetLengthWithInjectedValuesTest()
        {
            Rectangle rectangle = new Rectangle(3, 4);
            var result = rectangle.SetLength(null);
            Assert.AreEqual(null, result);
        }
        [Test]
        public void SetLengthWithNullValuesTest()
        {
            Rectangle rectangle = new Rectangle(null, null);
            var result = rectangle.SetLength(4);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void SetWidthWithDefaultValuesTest()
        {
            Rectangle rectangle = new Rectangle();
            var result = rectangle.SetWidth(3);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void SetWidthWithInjectedValuesTest()
        {
            Rectangle rectangle = new Rectangle(5, 6);
            var result = rectangle.SetWidth(null);
            Assert.AreEqual(null, result);
        }
        [Test]
        public void SetWidthWithNullValuesTest()
        {
            Rectangle rectangle = new Rectangle(null, null);
            var result = rectangle.SetWidth(9);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void SetPerimeterWithDefaultValuesTest()
        {
            Rectangle rectangle = new Rectangle();
            var result = rectangle.GetPerimeter();
            Assert.AreEqual(4, result);
        }

        [Test]
        public void SetPerimeterWithInjectedValuesTest()
        {
            Rectangle rectangle = new Rectangle(5, 6);
            var result = rectangle.GetPerimeter();
            Assert.AreEqual(22, result);
        }

        [Test]
        public void SetPerimeterWithNullValuesTest()
        {
            Rectangle rectangle = new Rectangle(null, null);
            var result = rectangle.GetPerimeter();
            Assert.AreEqual(null, result);
        }

        [Test]
        public void SetAreaWithDefaultValuesTest()
        {
            Rectangle rectangle = new Rectangle();
            var result = rectangle.GetArea();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void SetAreaWithInjectedValuesTest()
        {
            Rectangle rectangle = new Rectangle(2, 3);
            var result = rectangle.GetArea();
            Assert.AreEqual(6, result);
        }

        [Test]
        public void SetAreaWithNullValuesTest()
        {
            Rectangle rectangle = new Rectangle(null, null);
            var result = rectangle.GetArea();
            Assert.AreEqual(null, result);
        }

    }
}
