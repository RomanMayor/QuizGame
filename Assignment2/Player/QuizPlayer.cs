using Assignment2.Quiz;

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
            string end = "false";
            if (knowledgeLevel.ContainsKey(question.Category))
            {

                float probability = knowledgeLevel[question.Category];


                Random random = new Random();
                bool isCorrect = random.NextDouble() < probability;
                    
                end = isCorrect ? question.getAnswer() : "false";
            }
            else
            {
                if(question is ShortAnswer || question is TFQuestion)
                {

                    Random random = new Random();
                    bool randomGuess = random.NextDouble() < 0.5; 


                    end = randomGuess ? question.getAnswer() : "false";
                }
                else if(question is TestQuestion)
                {
                    TestQuestion testQuestion = (TestQuestion)question;
                    Random random = new Random();
                    bool randomGuess = random.NextDouble() < 1.0/testQuestion.GetOptionsCount(); 


                    end = randomGuess ? question.getAnswer() : "false";
                } 
            }
            return end;
        }

        public Dictionary<QuestionType, float> GetKnowledgeLevel()
        {
            return knowledgeLevel;
        }

    }
}
