using Assignment2.Quiz;

namespace Assignment2.Player
{
    public class LazyPlayer : QuizPlayer
    {
        public LazyPlayer(List<QuestionType> interests) : base(new Dictionary<QuestionType, float>())
        {
            foreach(QuestionType interest in interests){
                SetKnowledgeLevel(interest, 0f);
            }
        }
    }
}
