using JointMilitarySymbologyLibrary;
using NUnit.Framework;

namespace UnitTests
{
    /// <summary>
    ///This is a test class for librarianTest and is intended
    ///to contain all librarianTest Unit Tests
    ///</summary>
    [TestFixture]
    public class LibrarianTest
    {
        /// <summary>
        ///A test for librarian Constructor
        ///</summary>
        [Test]
        public void LibrarianConstructorTest()
        {
            string configPath = string.Empty;
            Librarian target = new Librarian(configPath);
            Assert.That(target,Is.Not.Null, "Librarian object is null.");
        }

        /// <summary>
        ///A test for makeSymbol
        ///</summary>
        [Test]
        public void MakeSymbolTest()
        {
            string configPath = string.Empty;
            Librarian target = new Librarian(configPath);
            SIDC sidc = new SIDC(1003010000,1100000000);
            Symbol actual = null;
            actual = target.MakeSymbol(sidc);
            Assert.That(actual, Is.Not.Null, "Symbol object is null.");
        }

        /// <summary>
        ///A test of the InvalidSymbol property
        ///</summary>
        [Test]
        public void InvalidSymbolTest()
        {
            string configPath = string.Empty;
            Librarian target = new Librarian(configPath);
            Symbol sym = target.InvalidSymbol;
            string expected1 = "1001980000";
            string expected2 = "1000000000";
            string actual1 = sym.SIDC.PartAString;
            string actual2 = sym.SIDC.PartBString;
            Assert.That(actual1, Is.EqualTo(expected1));
            Assert.That(actual2, Is.EqualTo(expected2));
        }

        /// <summary>
        ///A test of the RetiredSymbol property
        ///</summary>
        [Test]
        public void RetiredSymbolTest()
        {
            string configPath = string.Empty;
            Librarian target = new Librarian(configPath);
            Symbol sym = target.RetiredSymbol;
            string expected1 = "1001980000";
            string expected2 = "1100000000";
            string actual1 = sym.SIDC.PartAString;
            string actual2 = sym.SIDC.PartBString;
            Assert.That(actual1, Is.EqualTo(expected1));
            Assert.That(actual2, Is.EqualTo(expected2));
        }
    }
}
