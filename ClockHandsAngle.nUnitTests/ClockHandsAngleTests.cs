namespace ClockHandsAngle.nUnitTests
{
    public class ClockHandsAngleTests
    {
        [Test]
        public void calculateAngle_Test1()
        {
            int hours = 9;
            double minutes = 30;
            var angle = Program.calculateAngle(hours, minutes);
            Assert.AreEqual(91.25, angle);
        }
        [Test]
        public void calculateAngle_Test2()
        {
            int hours = 12;
            double minutes = 30;
            var angle = Program.calculateAngle(hours, minutes);
            Assert.AreEqual(178.75, angle);
        }
    }
}