using Assignment2.Player;
using Assignment2.Quiz;

namespace UnitTests
{
    public class PlayerTests
    {
        [Test]
        public void ShortAnswerTest()
        {
            var question = new ShortAnswer(QuestionType.GENERAL, "question", 1, "answer");

            var knowledgeLevel = new Dictionary<QuestionType, float>()
            {
                { QuestionType.GENERAL, 0.8f}
            };            
            var player = new QuizPlayer(knowledgeLevel);

            int points = 0;
            for (int i = 0; i < 1000; i++)
            {
                var answer = player.GetGuess(question);
                if (question.EvaluateAnswer(answer))
                {
                    points++;
                }
            }

            Assert.IsTrue(770 <= points && points <= 830);
        }

        [Test]
        public void ShortAnswerLazyTest()
        {
            var question = new ShortAnswer(QuestionType.GENERAL, "question", 1, "answer");

            var knowledgeLevel = new Dictionary<QuestionType, float>()
            {
                { QuestionType.GENERAL, 0.0f}
            };            
            var player = new QuizPlayer(knowledgeLevel);

            int points = 0;
            for (int i = 0; i < 1000; i++)
            {
                var answer = player.GetGuess(question);
                if (question.EvaluateAnswer(answer))
                {
                    points++;
                }
            }

            Assert.IsTrue(470 <= points && points <= 530);
        }
        
        [Test]
        public void TestQuestionTest()
        {
            var question = new TestQuestion(QuestionType.GENERAL, "question", 1);
            question.AddOption("one");
            question.AddOption("two");
            question.AddOption("three");
            question.SetCorrect(1);

            var knowledgeLevel = new Dictionary<QuestionType, float>()
            {
                { QuestionType.GENERAL, 0.8f}
            };            
            var player = new QuizPlayer(knowledgeLevel);

            int points = 0;

            for (int i = 0; i < 1000; i++)
            {
                var answer = player.GetGuess(question);
                if (question.EvaluateAnswer(answer))
                {
                    points++;
                }
            }

            Assert.IsTrue(770 <= points && points <= 830);
        }

        [Test]
        public void TestQuestionLazyTest()
        {
            var question = new TestQuestion(QuestionType.GENERAL, "question", 1);
            question.AddOption("one");
            question.AddOption("two");
            question.AddOption("three");
            question.AddOption("four");
            question.AddOption("five");

            question.SetCorrect(1);

            var knowledgeLevel = new Dictionary<QuestionType, float>()
            {
                { QuestionType.GENERAL, 0.0f}
            };            
            var player = new QuizPlayer(knowledgeLevel);

            int points = 0;

            for (int i = 0; i < 1000; i++)
            {
                var answer = player.GetGuess(question);
                if (question.EvaluateAnswer(answer))
                {
                    points++;
                }
            }

            Assert.IsTrue(170 <= points && points <= 230);
        }

        [Test]
        public void TFQuestionTest()
        {
            var question = new TFQuestion(QuestionType.GENERAL, "question", 1, true);

            var knowledgeLevel = new Dictionary<QuestionType, float>()
            {
                { QuestionType.GENERAL, 0.0f}
            };
            var player = new QuizPlayer(knowledgeLevel);

            int points = 0;
            for (int i = 0; i < 1000; i++)
            {
                var answer = player.GetGuess(question);
                if (question.EvaluateAnswer(answer))
                {
                    points++;
                }
            }

            Assert.IsTrue(470 <= points && points <= 530);
        }
    }
}