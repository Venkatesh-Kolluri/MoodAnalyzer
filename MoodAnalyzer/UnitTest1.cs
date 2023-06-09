namespace MoodAnalyzer
{
    public class Tests
    {

        [Test]
        public void GivenSadMoodReturnSad()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        [Test]
        public void GivenHappyMoodReturnHappy()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in Any Mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
   
    }
}
