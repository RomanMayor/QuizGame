using Assignment2.Quiz;

namespace Assignment2.Player
{
    public class KnowItAll : QuizPlayer
    {
        public KnowItAll(List<QuestionType> interests) : base(new Dictionary<QuestionType, float>())
        {
            foreach(QuestionType interest in interests){
                SetKnowledgeLevel(interest, 1f);
            }
        }
    }
}
