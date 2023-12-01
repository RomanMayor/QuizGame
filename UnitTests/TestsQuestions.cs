using Assignment2.Player;
using Assignment2.Quiz;

namespace UnitTests
{
    public class TestsQuestions
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestShortAnswer()
        {
            var question = new ShortAnswer(QuestionType.ARTS, "question", 1, "answer");
            
            Assert.IsTrue(question.EvaluateAnswer("answer"));
            Assert.IsTrue(question.EvaluateAnswer("AnsWeR"));
            Assert.IsFalse(question.EvaluateAnswer("XXXXX"));
        }
        
        [Test]
        public void TestTestQuestion()
        {
            var question = new TestQuestion(QuestionType.ARTS, "question list", 1);
            question.AddOption("one");
            question.AddOption("two");
            //question.AddOption("one");
            question.SetCorrect(0);
            //question.SetCorrect(666);

            Assert.IsTrue(question.EvaluateAnswer("one"));
            Assert.IsFalse(question.EvaluateAnswer("two"));
        }
    }
}