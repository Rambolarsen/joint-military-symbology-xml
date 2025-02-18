using JointMilitarySymbologyLibrary;

namespace UnitTests
{
    /// <summary>
    ///This is a test class for symbolTest and is intended
    ///to contain all symbolTest Unit Tests
    ///</summary>
    [TestFixture]
    public class SymbolTest
    {

        private static Librarian _librarian;


        [SetUp]
        public static void MyClassInitialize()
        {
            _librarian = new Librarian(string.Empty);
        }


        /// <summary>
        ///A test for legacySIDC
        ///</summary>
        [Test]
        public void LegacySIDCTest_MakeThenGet()
        {
            Symbol target = _librarian.MakeSymbol("2525C", "SFAPM----------");
            string expected = "SFAPM----------";
            string actual = target.LegacySIDC;
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        ///A test for legacySIDC
        ///</summary>
        [Test]
        public void LegacySIDCTest_ConversionFrom2525D_Air()
        {
            Symbol target = _librarian.MakeSymbol(1003010000, 1100000000);
            string expected = "SFAPM----------";
            string actual = target.LegacySIDC;
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        ///A test for legacySIDC
        ///</summary>
        [Test]
        public void LegacySIDCTest_ConversionFrom2525D_Space()
        {
            Symbol target = _librarian.MakeSymbol(1003050000, 1107000000);
            string expected = "SFPPS----------";
            string actual = target.LegacySIDC;
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        ///A test for legacySIDC
        ///</summary>
        [Test]
        public void LegacySIDCTest_ConversionFrom2525D_Sea()
        {
            Symbol target = _librarian.MakeSymbol(1004301000, 1301040000);
            string expected = "SNSANI---------";
            string actual = target.LegacySIDC;
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        ///A test for sidc
        ///</summary>
        [Test]
        public void SIDCTest_MakeThenGet()
        {
            Symbol target = _librarian.MakeSymbol(1003010000, 1100000000);
            UInt32 expectedPartA = 1003010000;
            UInt32 expectedPartB = 1100000000;
            SIDC actual = target.SIDC;
            Assert.That(expectedPartA, Is.EqualTo(actual.PartAUInt));
            Assert.That(expectedPartB, Is.EqualTo(actual.PartBUInt));
        }

        /// <summary>
        ///A test for sidc
        ///</summary>
        [Test]
        public void SIDCTest_ConversionFrom2525C_Air()
        {
            Symbol target = _librarian.MakeSymbol("2525C", "SFAPM----------");
            UInt32 expectedPartA = 1003010000;
            UInt32 expectedPartB = 1100000000;
            SIDC actual = target.SIDC;
            Assert.That(expectedPartA, Is.EqualTo(actual.PartAUInt));
            Assert.That(expectedPartB, Is.EqualTo(actual.PartBUInt));
        }

        /// <summary>
        ///A test for sidc
        ///</summary>
        [Test]
        public void SIDCTest_ConversionFrom2525C_Space()
        {
            Symbol target = _librarian.MakeSymbol("2525C", "SFPPS----------");
            UInt32 expectedPartA = 1003050000;
            UInt32 expectedPartB = 1107000000;
            SIDC actual = target.SIDC;
            Assert.That(expectedPartA, Is.EqualTo(actual.PartAUInt));
            Assert.That(expectedPartB, Is.EqualTo(actual.PartBUInt));
        }

        /// <summary>
        ///A test for sidc
        ///</summary>
        [Test]
        public void SIDCTest_ConversionFrom2525C_Sea()
        {
            Symbol target = _librarian.MakeSymbol("2525C", "SJSPCUS--------");
            UInt32 expectedPartA = 1015300000;
            UInt32 expectedPartB = 1207000300;
            SIDC actual = target.SIDC;
            Assert.That(expectedPartA, Is.EqualTo(actual.PartAUInt));
            Assert.That(expectedPartB, Is.EqualTo(actual.PartBUInt));
        }

        /// <summary>
        ///A test conversion/legacy data for METOC Atmospheric
        ///</summary>
        [Test]
        public void SIDCTest_ConversionFrom2525C_METOC_Atmos()
        {
            Symbol target = _librarian.MakeSymbol("2525C", "WA-DPFC-FY-L---");
            UInt32 expectedPartA = 1000450000;
            UInt32 expectedPartB = 1103040000;
            SIDC actual = target.SIDC;
            Assert.That(actual.PartAUInt, Is.EqualTo(expectedPartA));
            Assert.That(actual.PartBUInt, Is.EqualTo(expectedPartB));
        }

        /// <summary>
        ///A test conversion/legacy data for METOC Oceanographic
        ///</summary>
        [Test]
        public void SIDCTest_ConversionFrom2525C_METOC_Oceano()
        {
            Symbol target = _librarian.MakeSymbol("2525C", "WOS-IITM--P----");
            UInt32 expectedPartA = 1000460000;
            UInt32 expectedPartB = 1104010000;
            SIDC actual = target.SIDC;
            Assert.That(expectedPartA, Is.EqualTo(actual.PartAUInt));
            Assert.That(expectedPartB, Is.EqualTo(actual.PartBUInt));
        }

        /// <summary>
        ///A test conversion/legacy data for METOC Oceanographic
        ///</summary>
        [Test]
        public void SIDCTest_ConversionFrom2525C_METOC_Oceano_Area()
        {
            var target = _librarian.MakeSymbol("2525C", "WO-DHDDA----A--");
            const int expectedPartA = 1000460000;
            const int expectedPartB = 1201040000;
            var actual = target.SIDC;
            Assert.That(actual.PartAUInt, Is.EqualTo(expectedPartA));
            Assert.That(actual.PartBUInt, Is.EqualTo(expectedPartB));
        }

        /// <summary>
        ///A test for bad/invalid sidc
        ///</summary>
        [Test]
        public void SIDCTest_Invalid2525CCode()
        {
            var target = _librarian.MakeSymbol("2525C", "XXXXXXXXXXXXXXX");
            Assert.That(target, Is.Null);
        }

        /// <summary>
        ///A test for bad/invalid sidc
        ///</summary>
        [Test]
        public void SIDCTest_Invalid2525DCode()
        {
            Symbol target = _librarian.MakeSymbol(1111111111, 1111111111);
            Assert.That(target, Is.Null);
        }

        /// <summary>
        ///A test for checking the GeometryType property
        ///</summary>
        [Test]
        public void SIDCTest_GeometryType()
        {
            Symbol target = _librarian.MakeSymbol("2525C", "SJSPCUS--------");
            GeometryType expected = GeometryType.POINT;
            GeometryType actual = target.GeometryType;
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        ///A test for checking the Tags property
        ///</summary>
        [Test]
        public void SIDCTest_Tags()
        {
            Symbol target = _librarian.MakeSymbol(1004301000, 1301040000);
            string expected = "Reality; Neutral; Sea Surface; Military Noncombatant; Auxiliary Ship; Intelligence Collector; Unspecified; SNSANI---------";
            string actual = target.Tags;
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        ///A test for checking the Labels property
        ///</summary>
        [Test]
        public void SIDCTest_Labels()
        {
            Symbol target = _librarian.MakeSymbol(1004301000, 1301040000);
            int expected = 12;
            List<Dictionary<string, string>> actual = target.Labels;
            Assert.That(expected, Is.EqualTo(actual.Count));
        }

        /// <summary>
        ///A test for checking the DrawRule property
        ///</summary>
        [Test]
        public void SIDCTest_DrawRule()
        {
            Symbol target = _librarian.MakeSymbol(1004301000, 1301040000);
            string expected = "POINT_RULE";
            Dictionary<string, string> actual = target.DrawRule;
            Assert.That(expected, Is.EqualTo(actual["Name"]));
        }

        /// <summary>
        ///A test for checking the DrawNote property
        ///</summary>
        [Test]
        public void SIDCTest_DrawNote()
        {
            Symbol target = _librarian.MakeSymbol(1004301000, 1301040000);
            string expected = "Not Applicable";
            string actual = target.DrawNote;
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
