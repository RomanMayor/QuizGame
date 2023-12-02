using Assignment2.Player;
using Assignment2.Quiz;

namespace UnitTests
{
    public class TestsQuize
    {
        [Test]
        public void QuizTest()
        {
            var quiz = new QuestionQuiz(2);
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question TF 1", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question TF 2", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question TF 3", 1, true));

            Assert.IsTrue(quiz.Count() == 2);
        }
        
        [Test]
        public void QuizDuplicationTest()
        {
            var quiz = new QuestionQuiz(2);
            var question = new TFQuestion(QuestionType.ARTS, "question TF 1", 1, true);
            quiz.AddQuestion(question);
            quiz.AddQuestion(question);

            Assert.IsTrue(quiz.Count() == 1);
        }

        [Test]
        public void QuizGetNextTest()
        {
            var quiz = new QuestionQuiz(1);
            Assert.IsTrue(quiz.GetNextQuestion() == null);

            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question TF 1", 1, true));
            Assert.IsTrue(quiz.GetNextQuestion() != null);
            Assert.IsTrue(quiz.GetNextQuestion() == null);

            quiz.Reset();
            Assert.IsTrue(quiz.GetNextQuestion() != null);
        }
    }
}