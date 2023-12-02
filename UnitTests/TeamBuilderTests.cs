using Assignment2;
using Assignment2.Player;
using Assignment2.Quiz;

namespace UnitTests
{
    public class TeamBuilderTests
    {
        [Test]
        public void FindBestTeamTest()
        {
            var quiz = new QuestionQuiz(2);
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question ART", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question ART", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question ART", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question ART", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question ART", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question ART", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question ART", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question ART", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question ART", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question ART", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question ART", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question ART", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question ART", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.ARTS, "question ART", 1, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.GEOGRAPHY, "question GEO", 2, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.GEOGRAPHY, "question GEO", 2, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.GEOGRAPHY, "question GEO", 2, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.GEOGRAPHY, "question GEO", 2, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.GEOGRAPHY, "question GEO", 2, true));
            quiz.AddQuestion(new TFQuestion(QuestionType.MATHS, "question MATH", 5, true));
            quiz.Reset();

            var allPlayers = new List<QuizPlayer>()
            {
                new QuizPlayer(new Dictionary<QuestionType, float>()
                {
                    { QuestionType.MATHS, 0.8f}
                }),
                new QuizPlayer(new Dictionary<QuestionType, float>()
                {
                    { QuestionType.GEOGRAPHY, 0.8f}
                }),
                new QuizPlayer(new Dictionary<QuestionType, float>()
                {
                    { QuestionType.ARTS, 0.8f}
                })
            };


            var team = TeamBuilder.FindBestTeam(quiz, allPlayers, 2);
            
            Assert.IsTrue(team.Count == 2);
        }
    }
}