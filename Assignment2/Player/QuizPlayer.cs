using Assignment2.Quiz;
using System.Linq;

namespace Assignment2.Player
{
    public class QuizPlayer
    {
        protected Dictionary<QuestionType, float> knowledgeLevel;

        public QuizPlayer(Dictionary<QuestionType, float> knowledgeLevel)
        {
            this.knowledgeLevel = knowledgeLevel;
        }

        public void SetKnowledgeLevel(QuestionType category, float knowledgeLevel)
        {
            this.knowledgeLevel[category] = knowledgeLevel;
        }

        public virtual string GetGuess(AbstractQuestion question)
        {
            return question.GetAnswer(knowledgeLevel.ContainsKey(question.Category) ? knowledgeLevel[question.Category] : 0);
        }

        public float GetKnowledgeLevel(QuestionType questionType)
        {
            return knowledgeLevel.ContainsKey(questionType) ? knowledgeLevel[questionType] : 0f;
        }
    }

    public class PlayerScore
    {
        public float Score { get; set; }
        public QuizPlayer Player { get; private set; }
        public PlayerScore(QuizPlayer player, float score) 
        {
            Player = player;
            Score = score;
        }
    }
}
