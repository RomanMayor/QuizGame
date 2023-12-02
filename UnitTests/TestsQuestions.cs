using Assignment2.Player;
using Assignment2.Quiz;

namespace UnitTests
{
    public class TestsQuestions
    {
        [Test]
        public void ShortAnswerTest()
        {
            var question = new ShortAnswer(QuestionType.ARTS, "question", 1, "answer");
            
            Assert.IsTrue(question.EvaluateAnswer("answer"));
            Assert.IsTrue(question.EvaluateAnswer("AnsWeR"));
            Assert.IsFalse(question.EvaluateAnswer("XXXXX"));
        }
        
        [Test]
        public void TestQuestionTest()
        {
            var question = new TestQuestion(QuestionType.ARTS, "question list", 1);
            question.AddOption("one");
            question.AddOption("two");
            question.SetCorrect(0);

            Assert.IsTrue(question.EvaluateAnswer("one"));
            Assert.IsFalse(question.EvaluateAnswer("two"));
        }

        [Test]
        public void TestQuestionIncorrectCountTest()
        {
            var question = new TestQuestion(QuestionType.ARTS, "question list", 1);
            question.AddOption("one");
            question.AddOption("two");
            question.AddOption("two");

            Assert.IsTrue(question.GetOptionsCount() == 2);
        }

        [Test]
        public void TestQuestionIncorrectDataTest()
        {
            var question = new TestQuestion(QuestionType.ARTS, "question list", 1);
            question.AddOption("one");
            question.AddOption("two");
            question.SetCorrect(0);
            
            question.SetCorrect(666);

            Assert.IsTrue(question.EvaluateAnswer("one"));
            
            question.SetCorrect(-5);

            Assert.IsTrue(question.EvaluateAnswer("one"));
        }

        [Test]
        public void TFQuestionTest()
        {
            var question = new TFQuestion(QuestionType.ARTS, "question TF", 1, true);
            
            Assert.IsFalse(question.EvaluateAnswer("one"));
            Assert.IsTrue(question.EvaluateAnswer("TRUE"));
        }
        
        [Test]
        public void TFQuestionAddIncorrectOptionsTest()
        {
            var question = new TFQuestion(QuestionType.ARTS, "question TF", 1, true);
            question.AddOption("one");
            question.AddOption("two");
            question.SetCorrect(3);

            Assert.IsFalse(question.EvaluateAnswer("one"));
            Assert.IsTrue(question.EvaluateAnswer("TRUE"));
        }        
    }
}