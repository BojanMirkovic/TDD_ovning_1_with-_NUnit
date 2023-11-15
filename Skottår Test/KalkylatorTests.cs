using SkottårKalkylator;

namespace SkottårTest
{
    public class KalkylatorTests
    {
        private År SkottårKalkylator { get; set; } = null!;
        private År DagNummerKalkylator { get; set; } = null!;

        private År DagNamnKalkylator { get; set;} = null!;

        private År VeckaNummerKalkylator { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
           SkottårKalkylator = new År();

           DagNummerKalkylator = new År();

           DagNamnKalkylator=new År();

           VeckaNummerKalkylator = new År();
        }

        [Test]
        public void ÄrSkottår_EqualTest()
        {
            //Arrange
            var år = 2016;
            //Act
            var skottår = År.ÄrSkottår(år);
            //Assert
             Assert.That(skottår, Is.EqualTo(true));
           // Assert.IsTrue(skottår);
        }
        [Test]
        public void FåDagNummer_EqualTest()
        {
            var date = "1.january.2024";

            var dagNummer = År.FåDagNummer(date);

            Assert.That(dagNummer, Is.EqualTo(1));
        }
        [Test]
        public void FåDagNamn_EqualTest()
        {
            var date = "15.november.2023";

            var dagNamn = År.FåDagNamn(date);

            Assert.That(dagNamn, Is.EqualTo("Wednesday"));
        }
        [Test]
        public void FåVeckaNummer_EqualTest()
        {
            var date = "31.december.2023";

            var veckaNummer = År.FåVeckaNummer(date);

            Assert.That(veckaNummer, Is.EqualTo(52));
        }
    }
}