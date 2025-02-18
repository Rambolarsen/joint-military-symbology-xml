using JointMilitarySymbologyLibrary;
using NUnit.Framework;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for SIDCTest and is intended
    ///to contain all SIDCTest Unit Tests
    ///</summary>
    [TestFixture]
    public class SIDCTest
    {
        /// <summary>
        ///A test for SIDC Constructor
        ///</summary>
        [Test]
        public void SIDCConstructorTest()
        {
            string partA = string.Empty;
            string partB = string.Empty;
            SIDC target = new SIDC(partA, partB);
            Assert.That(target.PartAString, Is.EqualTo("1001980000"));
            Assert.That(target.PartBString, Is.EqualTo("1000000000"));
        }

        /// <summary>
        ///A test for SIDC Constructor
        ///</summary>
        [Test]
        public void SIDCConstructorTest1()
        {
            uint partA = 0;
            uint partB = 0;
            SIDC target = new SIDC(partA, partB);
            Assert.That(target.PartAUInt, Is.EqualTo((uint)1001980000));
            Assert.That(target.PartBUInt, Is.EqualTo((uint)1000000000));
        }

        /// <summary>
        ///A test for PartAString
        ///</summary>
        [Test]
        public void PartAStringTest()
        {
            uint partA = 0; 
            uint partB = 0; 
            SIDC target = new SIDC(partA, partB);
            string expected = "1000980000";
            string actual;
            target.PartAString = expected;
            actual = target.PartAString;
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        ///A test for PartAUInt
        ///</summary>
        [Test]
        public void PartAUIntTest()
        {
            uint partA = 0;
            uint partB = 0;
            SIDC target = new SIDC(partA, partB);
            uint expected = 1000980000;
            uint actual;
            target.PartAUInt = expected;
            actual = target.PartAUInt;
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        ///A test for PartBString
        ///</summary>
        [Test]
        public void PartBStringTest()
        {
            uint partA = 0;
            uint partB = 0;
            SIDC target = new SIDC(partA, partB);
            string expected = "1000000000";
            string actual;
            target.PartBString = expected;
            actual = target.PartBString;
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        ///A test for PartBUInt
        ///</summary>
        [Test]
        public void PartBUIntTest()
        {
            uint partA = 0;
            uint partB = 0;
            SIDC target = new SIDC(partA, partB);
            uint expected = 1000000000;
            uint actual;
            target.PartBUInt = expected;
            actual = target.PartBUInt;
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        ///A test for PartAString and PartAUInt
        ///</summary>
        [Test]
        public void PartAStringMixTest()
        {
            uint partA = 0;
            uint partB = 0;
            SIDC target = new SIDC(partA, partB);
            string expected = "1000980000";
            uint actual;
            target.PartAString = expected;
            actual = target.PartAUInt;
            Assert.That((uint)1000980000, Is.EqualTo(actual));
        }

        /// <summary>
        ///A test for PartBString and PartBUInt
        ///</summary>
        [Test]
        public void PartBStringMixTest()
        {
            uint partA = 0;
            uint partB = 0;
            SIDC target = new SIDC(partA, partB);
            string expected = "1000000000";
            uint actual;
            target.PartBString = expected;
            actual = target.PartBUInt;
            Assert.That((uint)1000000000, Is.EqualTo(actual));
        }

        /// <summary>
        ///A test for PartBString and PartBUInt
        ///</summary>
        [Test]
        public void PartBUIntMixTest()
        {
            uint partA = 0;
            uint partB = 0;
            SIDC target = new SIDC(partA, partB);
            uint expected = 1000000000;
            string actual;
            target.PartBUInt = expected;
            actual = target.PartBString;
            Assert.That("1000000000", Is.EqualTo(actual));
        }

        /// <summary>
        ///A test for PartAString and PartAUInt
        ///</summary>
        [Test]
        public void PartAUIntMixTest()
        {
            uint partA = 0;
            uint partB = 0;
            SIDC target = new SIDC(partA, partB);
            uint expected = 1000980000;
            string actual;
            target.PartAUInt = expected;
            actual = target.PartAString;
            Assert.That("1000980000", Is.EqualTo(actual));
        }

        /// <summary>
        ///A test for Invalid SIDC constant
        ///</summary>
        [Test]
        public void InvalidSIDC()
        {
            SIDC target = SIDC.INVALID;
            uint expected1 = 1001980000;
            uint expected2 = 1000000000;
            uint actual1 = target.PartAUInt;
            uint actual2 = target.PartBUInt;
            Assert.That(expected1, Is.EqualTo(actual1));
            Assert.That(expected2, Is.EqualTo(actual2));
        }

        /// <summary>
        ///A test for Retired SIDC constant
        ///</summary>
        [Test]
        public void RetiredSIDC()
        {
            SIDC target = SIDC.RETIRED;
            uint expected1 = 1001980000;
            uint expected2 = 1100000000;
            uint actual1 = target.PartAUInt;
            uint actual2 = target.PartBUInt;
            Assert.That(expected1, Is.EqualTo(actual1));
            Assert.That(expected2, Is.EqualTo(actual2));
        }
    }
}
